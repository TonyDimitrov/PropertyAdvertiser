namespace PropertyAdvertiser.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool WorkForAgency { get; set; }

        public List<SellingAdvertisement> Sellings { get; set; } = new List<SellingAdvertisement>();
        public List<LettingAdvertisement> Lettings { get; set; } = new List<LettingAdvertisement>();
        public List<ShortLettingAdvertisement> ShortLettings { get; set; } = new List<ShortLettingAdvertisement>();
    }
}
