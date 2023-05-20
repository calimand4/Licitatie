namespace AuctionSystem.Web.ViewModels.Item
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common;
    using Common.AutoMapping.Interfaces;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Picture;
    using Services.Models.Item;

    public class ItemEditBindingModel : IMapWith<ItemEditServiceModel>, IValidatableObject
    {
        private const string EndTimeBeforeStartTimeError = "The end time must be after the start time";

        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(ModelConstants.Item.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(ModelConstants.Item.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Starting price")]
        [Range(typeof(decimal), ModelConstants.Item.MinStartingPrice, ModelConstants.Item.MaxStartingPrice)]
        public decimal StartingPrice { get; set; }

        [Required]
        [Display(Name = "Minimal price increase allowed")]
        [Range(typeof(decimal), ModelConstants.Item.MinMinIncrease, ModelConstants.Item.MaxMinIncrease)]
        public decimal MinIncrease { get; set; }

        [Required]
        [Display(Name = "Start time")]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "End time")]
        public DateTime EndTime { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string SubCategoryId { get; set; }

        public IEnumerable<SelectListItem> SubCategories { get; set; }

        public ICollection<PictureDisplayViewModel> Pictures { get; set; }

        public string Url => $"/items/details/{this.Id}/{this.Title.GenerateSlug()}";

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.EndTime.ToUniversalTime() <= this.StartTime.ToUniversalTime())
            {
                yield return new ValidationResult(EndTimeBeforeStartTimeError,
                    new[] {nameof(this.EndTime)});
            }
        }
    }
}