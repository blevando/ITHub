﻿
using Microsoft.EntityFrameworkCore;
using ITHub.Models.Entity;

namespace ITHub.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Commodity> Commodity { get; set; }
        public DbSet<Shipment> Shipment { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<PaymentGatewayConfig> PaymentGatewayConfig { get; set; }
        public DbSet<SplitConfig> SplitConfig { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<ActionType> ActionType { get; set; }
        public DbSet<Advert> Advert { get; set; }
        public DbSet<AdvertPlan> AdvertPlan { get; set; }
        public DbSet<Benefit> Benefit { get; set; }
        public DbSet<CallToAction> callToAction { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Product> Product { get; set; }


    }
}