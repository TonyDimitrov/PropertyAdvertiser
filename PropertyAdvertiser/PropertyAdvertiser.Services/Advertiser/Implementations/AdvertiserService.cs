namespace PropertyAdvertiser.Services.Advertiser.Implementations
{
    using System;
    using System.Collections.Generic;
    using PropertyAdvertiser.Services.Advertiser.Models;
    using PropertyAdvertiser.Data;
    using AutoMapper.QueryableExtensions;
    using System.Linq;

    public class AdvertiserService : IAdvertiserService
    {
        private readonly PropertyAdvertiserDbContext db;

        public AdvertiserService(PropertyAdvertiserDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<AdvertiserListViewModel> All()
        {
            return this.db
                .Users
                .ProjectTo<AdvertiserListViewModel>()
                .ToList();
        }
    }
}
