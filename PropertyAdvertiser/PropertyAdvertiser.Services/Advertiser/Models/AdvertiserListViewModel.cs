
namespace PropertyAdvertiser.Services.Advertiser.Models
{
    using PropertyAdvertiser.Common.Mapping;
    using PropertyAdvertiser.Data.Models;
    using System;

    public class AdvertiserListViewModel : IMapFrom<User>
    {
        public string Id { get; set; }

        public bool WorkForAcency { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int SellingsCount { get; set; }

        public int LettingsCount { get; set; }

        public int ShortLettingsCount { get; set; }

        public DateTime LastAdDate { get; set; }
    }
}
