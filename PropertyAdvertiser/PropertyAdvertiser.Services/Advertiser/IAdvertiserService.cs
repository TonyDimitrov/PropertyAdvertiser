using PropertyAdvertiser.Services.Advertiser.Models;
using System.Collections.Generic;

namespace PropertyAdvertiser.Services.Advertiser
{
    public interface IAdvertiserService
    {
        IEnumerable<AdvertiserListViewModel> All();
    }
}
