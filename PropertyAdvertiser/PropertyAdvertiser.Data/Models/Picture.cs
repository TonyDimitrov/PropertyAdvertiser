namespace PropertyAdvertiser.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Picture
    {
        public int Id { get; set; }
        [Required]
        public string PictureUrl { get; set; }

        public int LettingAdvertisementId { get; set; }
        public LettingAdvertisement LettingAd { get; set; }

        public int SellingAdvertisementId { get; set; }
        public SellingAdvertisement SellingAd { get; set; }

        public int ShortLettingAdvertisementId { get; set; }
        public ShortLettingAdvertisement ShortLettingAd { get; set; }
    }

}
