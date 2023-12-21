using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Emit;

namespace Domain.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Log> Logs { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<PricingPlan> PricingPlans { get; set; }
        public DbSet<PricingPlanType> PricingPlanTypes { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            /* builder.Entity<Log>()
                 .HasOne(l => l.Subscription)
                 .WithOne(s => s.Log)
                 .HasForeignKey<Subscription>(s => s.LogId);*/

            builder.Entity<Subscriber>()
                  .HasOne(l => l.Subscription)
                  .WithOne(s => s.Subscriber)
                  .HasForeignKey<Subscription>(s => s.SubscriberId);

            /*        builder.Entity<IdentityUserLogin<string>>().HasNoKey();
                    builder.Entity<IdentityUserRole<string>>().HasNoKey();
                    builder.Entity<IdentityUserLogin<string>>().HasNoKey();*/

            List<PricingPlanType> pricingPlanTypes = new List<PricingPlanType>
            {
                new PricingPlanType
                {
                    Id = 1,
                    Name = "weekday"
                },
                new PricingPlanType
                {
                    Id = 2,
                    Name = "weekend"
                }
            };

            var parkingSpot = new ParkingSpot
            {
                Id = 1,
                TotalSpots = 500
            };

            List<PricingPlan> pricingPlans = new List<PricingPlan>
            {
                new PricingPlan
                {
                    Id = 1,
                    HourlyPricing = 2,
                    DailyPricing=40,
                    MinimumHours=10,
                    PricingPlanTypeId= 2
                },
                new PricingPlan
                {
                    Id = 2,
                    HourlyPricing = 1,
                    DailyPricing=20,
                    MinimumHours=5,
                    PricingPlanTypeId= 1
                },
                new PricingPlan
                {
                    Id = 3,
                    HourlyPricing = 1.5,
                    DailyPricing=30,
                    MinimumHours=12,
                    PricingPlanTypeId= 1
                }
            };

            builder.Entity<PricingPlanType>().HasData(pricingPlanTypes);
            builder.Entity<ParkingSpot>().HasData(parkingSpot);
            builder.Entity<PricingPlan>().HasData(pricingPlans);
        }
    }
}