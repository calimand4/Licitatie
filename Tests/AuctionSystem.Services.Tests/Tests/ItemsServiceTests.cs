﻿namespace AuctionSystem.Services.Tests.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using AuctionSystem.Models;
    using Data;
    using FluentAssertions;
    using Implementations;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models.Item;
    using Moq;
    using Xunit;

    public class ItemsServiceTests : BaseTest
    {
        private const string SampleId = "SmapleId";
        private const string SampleTitle = "SampleTitle";
        private const string SampleDescription = "Very cool item";
        private const string SampleUsername = "TestUser";
        private const string SampleUserFullName = "Test Test";
        private const decimal SampleStartingPrice = 3000000;
        private const decimal SampleMinIncrease = 10;
        private static readonly DateTime SampleStartTime = DateTime.UtcNow.AddDays(10);
        static readonly DateTime SampleEndTime = DateTime.MaxValue;
        private const string SampleSubCategoryId = "SampleSubCategoryId";

        private readonly AuctionSystemDbContext dbContext;
        private readonly IItemsService itemsService;

        public ItemsServiceTests()
        {
            this.dbContext = base.DatabaseInstance;
            this.itemsService = new ItemsService(this.mapper, this.dbContext, Mock.Of<IPictureService>());
        }

        [Fact]
        public async Task GetByIdAsync_WithInvalidId_ShouldReturnEmptyModel()
        {
            // Arrange
            await this.dbContext.Items.AddAsync(new Item { Description = SampleDescription });
            await this.dbContext.SaveChangesAsync();

            // Act
            var result = await this.itemsService.GetByIdAsync<ItemDetailsServiceModel>(null);

            // Assert
            result
                .Should()
                .BeNull();
        }

        [Fact]
        public async Task GetByIdAsync_WithValidId_ShouldReturnCorrectModel()
        {
            // Arrange
            await this.SeedItems(10);
            const string expected = "sampleTestId";
            await this.dbContext.Items.AddAsync(new Item
            {
                Id = expected,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                UserId = this.dbContext.Users.FirstOrDefault()?.Id,
                SubCategoryId = this.dbContext.SubCategories.FirstOrDefault()?.Id,
            });
            await this.dbContext.SaveChangesAsync();

            // Act
            var result = await this.itemsService.GetByIdAsync<ItemDetailsServiceModel>(expected);

            // Assert
            result
                .Should()
                .BeAssignableTo<ItemDetailsServiceModel>();
        }

        [Fact]
        public async Task GetByIdAsync_WithValidId_ShouldReturnCorrectEntity()
        {
            // Arrange
            await this.SeedItems(10);
            const string expected = "expectedId";
            await this.dbContext.Items.AddAsync(new Item
            {
                Id = expected,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                UserId = this.dbContext.Users.FirstOrDefault()?.Id,
                SubCategoryId = this.dbContext.SubCategories.FirstOrDefault()?.Id,
            });
            await this.dbContext.SaveChangesAsync();

            // Act
            var result = await this.itemsService.GetByIdAsync<ItemDetailsServiceModel>(expected);

            // Assert
            result
                .Should()
                .Match(x => x.As<ItemDetailsServiceModel>().Id == expected);
        }

        [Fact]
        public async Task GetHottestItemsAsync_WithInvalidStartingPrice_ShouldReturnNull()
        {
            // Arrange
            await this.dbContext.Items.AddAsync(new Item { StartingPrice = 10 });
            await this.dbContext.SaveChangesAsync();
            // Act
            var result = await this.itemsService.GetHottestItemsAsync<HottestItemServiceModel>();

            // Assert
            result
                .Should()
                .BeNullOrEmpty();
        }

        [Fact]
        public async Task GetHottestItemsAsync_WithInvalidStartTime_ShouldReturnNull()
        {
            // Arrange
            await this.dbContext.Items.AddAsync(new Item { StartingPrice = 100001 });
            await this.dbContext.SaveChangesAsync();
            // Act
            var result = await this.itemsService.GetHottestItemsAsync<HottestItemServiceModel>();

            // Assert
            result
                .Should()
                .BeNullOrEmpty();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        public async Task GetHottestItemsAsync_ShouldReturnCorrectModelAndCount(int count)
        {
            // Arrange
            await this.SeedItems(count);
            // Act
            var result = await this.itemsService.GetHottestItemsAsync<HottestItemServiceModel>();

            // Assert
            result
                .Should()
                .BeAssignableTo<IEnumerable<HottestItemServiceModel>>()
                .And
                .HaveCount(count);
        }

        [Fact]
        public async Task GetAllLiveItemsAsync_WithInvalidStartTime_ShouldReturnNull()
        {
            // Arrange
            await this.dbContext.Items.AddAsync(new Item
            {
                StartTime = DateTime.UtcNow.AddMinutes(10),
                EndTime = DateTime.UtcNow.AddDays(10),
                Pictures = new List<Picture>() { new Picture(), new Picture(), new Picture() }
            });
            await this.dbContext.SaveChangesAsync();
            // Act
            var result = await this.itemsService.GetAllLiveItemsAsync<LiveItemServiceModel>();

            // Assert
            result
                .Should()
                .BeNullOrEmpty();
        }

        [Fact]
        public async Task GetAllLiveItemsAsync_WithInvalidEndTime_ShouldReturnNull()
        {
            // Arrange
            await this.dbContext.Items.AddAsync(new Item
            {
                StartTime = DateTime.UtcNow,
                Pictures = new List<Picture>() { new Picture(), new Picture(), new Picture() }
            });
            await this.dbContext.SaveChangesAsync();
            // Act
            var result = await this.itemsService.GetAllLiveItemsAsync<LiveItemServiceModel>();

            // Assert
            result
                .Should()
                .BeNullOrEmpty();
        }

        [Fact]
        public async Task GetAllLiveItemsAsync_WithInvalidPicturesCount_ShouldReturnNull()
        {
            // Arrange
            await this.dbContext.Items.AddAsync(new Item
            {
                StartTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddDays(10),
                Pictures = new List<Picture>() { new Picture(), }
            });
            await this.dbContext.SaveChangesAsync();
            // Act
            var result = await this.itemsService.GetAllLiveItemsAsync<LiveItemServiceModel>();

            // Assert
            result
                .Should()
                .BeNullOrEmpty();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        public async Task GetAllLiveItemsAsync_WithValidInput_ShouldReturnCorrectModelAndCount(int count)
        {
            // Arrange
            await this.SeedLiveItems(count);
            // Act
            var result = await this.itemsService.GetAllLiveItemsAsync<LiveItemServiceModel>();

            // Assert
            result
                .Should()
                .BeAssignableTo<IEnumerable<LiveItemServiceModel>>()
                .And
                .HaveCount(count);
        }

        [Fact]
        public async Task GetAllItemsForGivenUser_WithValidInput_ShouldReturnCorrectModels()
        {
            // Arrange
            await this.SeedItems(10);

            // Act
            var user = await this.dbContext.Users.FirstOrDefaultAsync();
            var result = await this.itemsService.GetAllItemsForGivenUser<ItemListingServiceModel>(user.Id);

            // Assert
            result
                .All(x => x.As<ItemListingServiceModel>().UserFullName == user.FullName)
                .Should()
                .BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("aa")]
        public async Task SearchByTitleAsync_WithInvalidInput_ShouldReturnNull(string query)
        {
            // Act
            var result = await this.itemsService.SearchByTitleAsync<ItemListingServiceModel>(query);

            // Assert
            result
                .Should()
                .BeNull();
        }

        [Fact]
        public async Task SearchByTitleAsync_WithValidInput_ShouldReturnCorrectEntities()
        {
            // Arrange
            const string expectedTitle = "expected";
            await this.dbContext.Items.AddAsync(new Item
            {
                Title = expectedTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                User = new AuctionUser { FullName = SampleUserFullName, UserName = SampleUsername },
                SubCategory = new SubCategory()
            });
            await this.dbContext.Items.AddAsync(new Item
            {
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                User = new AuctionUser { FullName = SampleUserFullName, UserName = SampleUsername },
                SubCategory = new SubCategory()
            });
            await this.dbContext.Items.AddAsync(new Item
            {
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                User = new AuctionUser { FullName = SampleUserFullName, UserName = SampleUsername },
                SubCategory = new SubCategory()
            });
            await this.dbContext.SaveChangesAsync();
            // Act
            var result = await this.itemsService.SearchByTitleAsync<ItemListingServiceModel>(expectedTitle);

            // Assert
            result
                .Should()
                .BeAssignableTo<IEnumerable<ItemListingServiceModel>>();

            result
                .Should()
                .Subject
                .All(x => x.Title.Contains(expectedTitle));
        }

        [Fact]
        public async Task CreateAsync_WithEmptyModel_ShouldReturnNullId_AndNotInsertItemInDatabase()
        {
            // Act
            var result = await this.itemsService.CreateAsync(new ItemCreateServiceModel());

            // Assert
            result
                .Should()
                .BeNull();

            this.dbContext
                .Items
                .Should()
                .BeEmpty();
        }

        [Fact]
        public async Task CreateAsync_WithInvalidTitle_ShouldReturnNullId_AndNotInsertItemInDatabase()
        {
            // Arrange
            var random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var invalidTitle = new string(Enumerable.Repeat(chars, 121)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            var item = new ItemCreateServiceModel
            {
                Id = SampleId,
                Title = invalidTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.CreateAsync(item);

            // Assert
            result
                .Should()
                .BeNull();

            this.dbContext
                .Items
                .Should()
                .BeEmpty();
        }

        [Fact]
        public async Task CreateAsync_WithInvalidDescription_ShouldReturnNullId_AndNotInsertItemInDatabase()
        {
            // Arrange
            var random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var invalidDescription = new string(Enumerable.Repeat(chars, 501)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            var item = new ItemCreateServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = invalidDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.CreateAsync(item);

            // Assert
            result
                .Should()
                .BeNull();

            this.dbContext
                .Items
                .Should()
                .BeEmpty();
        }

        [Fact]
        public async Task CreateAsync_WithInvalidStartingPrice_ShouldReturnNullId_AndNotInsertItemInDatabase()
        {
            // Arrange
            var item = new ItemCreateServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = -1,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.CreateAsync(item);

            // Assert
            result
                .Should()
                .BeNull();

            this.dbContext
                .Items
                .Should()
                .BeEmpty();
        }

        [Fact]
        public async Task CreateAsync_WithInvalidMinIncrease_ShouldReturnNullId_AndNotInsertItemInDatabase()
        {
            // Arrange
            var item = new ItemCreateServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = -1,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.CreateAsync(item);

            // Assert
            result
                .Should()
                .BeNull();

            this.dbContext
                .Items
                .Should()
                .BeEmpty();
        }

        [Fact]
        public async Task CreateAsync_WithInvalidUsername_ShouldReturnNullId_AndNotInsertItemInDatabase()
        {
            // Arrange
            var item = new ItemCreateServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.CreateAsync(item);

            // Assert
            result
                .Should()
                .BeNull();

            this.dbContext
                .Items
                .Should()
                .BeEmpty();
        }

        [Fact]
        public async Task CreateAsync_WithValidModel_ShouldReturnId_AndInsertItemInDatabase()
        {
            // Arrange
            await this.SeedUserAndSubCategory();
            this.dbContext.SaveChanges();
            var item = new ItemCreateServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserName = SampleUsername,
                PictureStreams = new List<Stream>(),
            };

            // Act
            var result = await this.itemsService.CreateAsync(item);

            // Assert
            result
                .Should()
                .NotBeNullOrEmpty()
                .And
                .Match(x => x.As<string>() == SampleId);

            this.dbContext
                .Items
                .Should()
                .HaveCount(1);
        }

        [Fact]
        public async Task CreateAsync_WithValidModelAndPictures_ShouldReturnId_AndInsertItemInDatabase()
        {
            // Arrange
            await this.SeedUserAndSubCategory();
            var item = new ItemCreateServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = this.dbContext.SubCategories.FirstOrDefault()?.Id,
                UserName = SampleUsername,
                PictureStreams = new List<Stream> { Stream.Null }, // TODO Use valid stream
            };

            // Act
            var result = await this.itemsService.CreateAsync(item);

            // Assert
            result
                .Should()
                .NotBeNullOrEmpty()
                .And
                .Match(x => x.As<string>() == SampleId);

            this.dbContext
                .Items
                .Should()
                .HaveCount(1);
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidInput_ShouldReturnFalse()
        {
            // Act
            var result = await this.itemsService.DeleteAsync(null);

            // Assert
            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task DeleteAsync_WithValidInput_ShouldReturnTrueAndDeleteItemFromDatabase()
        {
            // Assert
            await this.SeedItems(1);
            var item = await this.dbContext.Items.FirstOrDefaultAsync();
            var currentDbCount = this.dbContext.Items.Count();

            // Act
            var result = await this.itemsService.DeleteAsync(item.Id);

            // Assert
            result
                .Should()
                .BeTrue();

            this.dbContext
                .Items
                .Should()
                .HaveCountLessThan(currentDbCount);
        }

        [Fact]
        public async Task UpdateAsync_WithEmptyModel_ShouldReturnFalse()
        {
            // Act
            var result = await this.itemsService.UpdateAsync(new ItemEditServiceModel());

            // Assert
            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_WithInvalidTitle_ShouldReturnFalse()
        {
            // Arrange
            var random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var invalidTitle = new string(Enumerable.Repeat(chars, 121)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            var item = new ItemEditServiceModel
            {
                Id = SampleId,
                Title = invalidTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserUserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.UpdateAsync(item);

            // Assert
            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_WithInvalidDescription_ShouldReturnFalse()
        {
            // Arrange
            var random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var invalidDescription = new string(Enumerable.Repeat(chars, 501)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            var item = new ItemEditServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = invalidDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserUserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.UpdateAsync(item);

            // Assert
            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_WithInvalidStartingPrice_ShouldReturnFalse()
        {
            // Arrange
            var item = new ItemEditServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = -1,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserUserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.UpdateAsync(item);

            // Assert
            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_WithInvalidMinIncrease_ShouldReturnFalse()
        {
            // Arrange
            var item = new ItemEditServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = -1,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserUserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.UpdateAsync(item);

            // Assert
            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_WithInvalidUsername_ShouldReturnFalse()
        {
            // Arrange
            var item = new ItemEditServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserUserName = SampleUsername,
            };

            // Act
            var result = await this.itemsService.UpdateAsync(item);

            // Assert
            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_WithInvalidModel_ShouldReturnFalse()
        {
            // Arrange
            var item = new ItemEditServiceModel
            {
                Id = SampleId,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = SampleSubCategoryId,
                UserUserName = SampleUsername,
            };
            // Act
            var result = await this.itemsService.UpdateAsync(item);

            // Assert
            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public async Task UpdateAsync_WithValidModel_ShouldReturnTrue()
        {
            // Arrange
            await this.SeedItems(10);
            var item = new ItemEditServiceModel
            {
                Id = this.dbContext.Items.FirstOrDefault()?.Id,
                Title = SampleTitle,
                Description = SampleDescription,
                StartingPrice = SampleStartingPrice,
                MinIncrease = SampleMinIncrease,
                StartTime = SampleStartTime,
                EndTime = SampleEndTime,
                SubCategoryId = this.dbContext.SubCategories.FirstOrDefault()?.Id,
                UserUserName = this.dbContext.Users.FirstOrDefault()?.UserName,
            };
            // Act
            var result = await this.itemsService.UpdateAsync(item);

            // Assert
            result
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task GetAllItemsInGivenCategoryByCategoryIdAsync_WithInvalidId_ShouldReturnNull()
        {
            // Arrange
            const int count = 1;
            await this.SeedItems(count);
            // Act
            var result = await this.itemsService.GetAllItemsInGivenCategoryByCategoryIdAsync<ItemListingServiceModel>(null);

            // Assert
            result
                .Should()
                .BeNull();
        }

        [Fact]
        public async Task GetAllItemsInGivenCategoryByCategoryIdAsync_WithValidId_ShouldReturnCollectionOfCorrectModels()
        {
            // Arrange
            const int count = 10;
            await this.SeedItems(count);
            // Act
            var result = await this.itemsService.GetAllItemsInGivenCategoryByCategoryIdAsync<ItemListingServiceModel>(SampleSubCategoryId);

            // Assert
            result
                .Should()
                .BeAssignableTo<IEnumerable<ItemListingServiceModel>>()
                .And
                .HaveCount(count);
        }

        [Fact]
        public async Task GetAllItems_ShouldReturnCollectionOfCorrectModels()
        {
            // Arrange
            const int count = 10;
            await this.SeedItems(count);

            // Act
            var result = await this.itemsService.GetAllItemsAsync<ItemListingServiceModel>();

            // Assert
            result
                .Should()
                .BeAssignableTo<IEnumerable<ItemListingServiceModel>>();
        }

        #region privateMethods

        private async Task SeedItems(int count)
        {
            await this.SeedUserAndSubCategory();

            var items = new List<Item>();
            for (int i = 1; i <= count; i++)
            {
                var item = new Item
                {
                    Title = SampleTitle,
                    Description = SampleDescription,
                    StartingPrice = SampleStartingPrice,
                    MinIncrease = SampleMinIncrease,
                    StartTime = SampleStartTime,
                    EndTime = SampleEndTime,
                    UserId = this.dbContext.Users.FirstOrDefault()?.Id,
                    SubCategoryId = this.dbContext.SubCategories.FirstOrDefault()?.Id,
                };
                items.Add(item);
            }
            for (int i = count + 1; i <= count + count; i++)
            {
                var item = new Item
                {
                    Id = i.ToString(),
                    Description = $"Item_{i}",
                };
                items.Add(item);
            }

            await this.dbContext.Items.AddRangeAsync(items);
            await this.dbContext.SaveChangesAsync();
        }

        private async Task SeedLiveItems(int count)
        {
            var items = new List<Item>();
            for (int i = 1; i <= count; i++)
            {
                var item = new Item
                {
                    Title = SampleTitle,
                    Description = SampleDescription,
                    StartingPrice = SampleStartingPrice,
                    MinIncrease = SampleMinIncrease,
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow.AddDays(10),
                    Pictures = new List<Picture> { new Picture { }, new Picture { }, new Picture { } }
                };
                items.Add(item);
            }

            await this.dbContext.Items.AddRangeAsync(items);
            await this.dbContext.SaveChangesAsync();
        }

        private async Task SeedUserAndSubCategory()
        {
            await this.dbContext.Users.AddAsync(new AuctionUser { UserName = SampleUsername, FullName = SampleUserFullName });
            await this.dbContext.SubCategories.AddAsync(new SubCategory { Id = SampleSubCategoryId });
            await this.dbContext.SaveChangesAsync();
        }

        #endregion
    }
}
