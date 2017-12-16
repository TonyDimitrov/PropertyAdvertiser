namespace PropertyAdvertiser.Web.Areas.Advertiser.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PropertyAdvertiser.Services.Advertiser;
    using System;

    [Area("Users")]
    public class AdvertisersController : Controller
    {
        private readonly IAdvertiserService service;
        public AdvertisersController(IAdvertiserService service)
        {
           this.service = service;
        }

       // [Area("Advertiser")]
        public IActionResult Index()
        {
            var model = this.service.All();
            return View(model);
        }
    }
}
