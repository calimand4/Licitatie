namespace AuctionSystem.Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AuctionSystem.Models;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data;
    using Interfaces;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Models.Item;

    public class ItemsService : BaseService, IItemsService
    {
        private const string DefaultPictureUrl =
            "https://res.cloudinary.com/do72gylo3/image/upload/v1547833155/default-img.jpg";

        private readonly IPictureService pictureService;

        public ItemsService(AuctionSystemDbContext context, IPictureService pictureService)
            : base(context)
        {
            this.pictureService = pictureService;
        }

        public async Task<T> GetByIdAsync<T>(string id)
            where T : BaseItemServiceModel
        {
            if (id == null)
            {
                return null;
            }

            var item = await this.Context.Items
                .ProjectTo<T>()
                .SingleOrDefaultAsync(i => i.Id == id);

            return item;
        }

        public async Task<string> CreateAsync(ItemCreateServiceModel serviceModel)
        {
            if (!this.IsEntityStateValid(serviceModel))
            {
                return null;
            }

            var user = await this.Context.Users.SingleOrDefaultAsync(u => u.UserName == serviceModel.UserName);

            if (user == null ||
                !await this.Context.SubCategories.AnyAsync(c => c.Id == serviceModel.SubCategoryId))
            {
                return null;
            }

            var item = Mapper.Map<Item>(serviceModel);
            item.UserId = user.Id;

            await this.Context.AddAsync(item);

            item.Pictures = serviceModel.PictFormFiles.Any() ? this.GetPictureUrls(serviceModel.PictFormFiles, item.Id, serviceModel.Title)
                : new List<Picture> { new Picture { Url = DefaultPictureUrl } };

            await this.Context.SaveChangesAsync();

            return item.Id;
        }

        public async Task<IEnumerable<T>> GetAllItemsInGivenCategoryByCategoryIdAsync<T>(string id)
            where T : BaseItemServiceModel
        {
            if (id == null)
            {
                return null;
            }

            var allItemsInGivenCategory = await this.Context
                .Items
                .Where(i => i.SubCategoryId == id)
                .ProjectTo<T>()
                .ToListAsync();

            return allItemsInGivenCategory;
        }

        public async Task<IEnumerable<T>> GetAllItems<T>()
            => await this.Context
                    .Items
                    .ProjectTo<T>()
                    .ToListAsync();

        #region privateMethods

        private ICollection<Picture> GetPictureUrls(ICollection<IFormFile> pictures, string itemId, string title)
        {
            var uploadedPictures = this.pictureService.Upload(pictures, itemId, title).ToList();
            return uploadedPictures.Any() ? uploadedPictures.Select(picture => new Picture { Url = picture.SecureUri.AbsoluteUri }).ToList()
                : new List<Picture> { new Picture { Url = DefaultPictureUrl } };
        }

        #endregion
    }
}