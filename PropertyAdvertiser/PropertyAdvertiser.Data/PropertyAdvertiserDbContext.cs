namespace PropertyAdvertiser.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using PropertyAdvertiser.Data.Models;

    public class PropertyAdvertiserDbContext : IdentityDbContext<User>
    {
        public PropertyAdvertiserDbContext(DbContextOptions<PropertyAdvertiserDbContext> options)
            : base(options)
        {
        }

        public DbSet<SellingAdvertisement> SellingAds { get; set; }
        public DbSet<LettingAdvertisement> LettingsAds { get; set; }
        public DbSet<ShortLettingAdvertisement> ShortLettingAds { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .HasMany(u => u.Sellings)
                .WithOne(s => s.Advertiser)
                .HasForeignKey(s => s.AdvertiserId);

            builder
                .Entity<User>()
                .HasMany(u => u.Lettings)
                .WithOne(l => l.Advertiser)
                .HasForeignKey(l => l.AdvertiserId);

            builder
                .Entity<User>()
                .HasMany(u => u.ShortLettings)
                .WithOne(s => s.Advertiser)
                .HasForeignKey(s => s.AdvertiserId);

            builder
                .Entity<SellingAdvertisement>()
                .HasMany(s => s.Pictures)
                .WithOne(p => p.SellingAd)
                .HasForeignKey(p => p.SellingAdvertisementId);

            builder
                .Entity<LettingAdvertisement>()
                .HasMany(s => s.Pictures)
                .WithOne(p => p.LettingAd)
                .HasForeignKey(p => p.LettingAdvertisementId);

            builder
             .Entity<ShortLettingAdvertisement>()
             .HasMany(s => s.Pictures)
             .WithOne(p => p.ShortLettingAd)
             .HasForeignKey(p => p.ShortLettingAdvertisementId);

            base.OnModelCreating(builder);
        }
    }
}
