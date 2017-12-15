namespace PropertyAdvertiser.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class LettingAdvertisement
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        [Required]
        [MaxLength(DataConstants.PropertyNameMaxLength)]
        [MinLength(DataConstants.PropertyNameMinLength)]
        public string PropertyName { get; set; }
        [Required]
        [MaxLength(DataConstants.DescriptionMaxLength)]
        [MinLength(DataConstants.DescriptionMinLength)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(DataConstants.LocationMaxLength)]
        [MinLength(DataConstants.LocationMinLength)]
        public string Location { get; set; }
        [Required]
        [MaxLength(DataConstants.ContactNameMaxLength)]
        [MinLength(DataConstants.ContactNameMinLength)]
        public string ContactName { get; set; }
        [Required]
        public string ContactEmail { get; set; }
        [Required]
        [MaxLength(DataConstants.ContactPhoneMaxLength)]
        [MinLength(DataConstants.ContactPhoneMinLength)]
        public string ContactPhone { get; set; }
        public DateTime ViewDate { get; set; }
        public List<Picture> Pictures { get; set; } = new List<Picture>();
        public PropertyActionType PropertyType { get; set; }
        public bool IsApproved { get; set; }
        public bool IsAvailable { get; set; }
        public string AdvertiserId { get; set; }
        public User Advertiser { get; set; }
    }
}
