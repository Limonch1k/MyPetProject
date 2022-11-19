using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class KotelContext : DbContext
    {
        public DbSet<Cart> Carts { get; set;}

        public DbSet<User> Users { get; set; }

        public DbSet<Coupon> Coupons { get; set; }

        public DbSet<OrderStory> OrderStories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<UserRequestCall> UsersRequests { get; set; }

        public DbSet<ProductClass> ProductClasses { get; set; }

        public KotelContext(DbContextOptions<KotelContext> options) : base(options) 
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            string connection = "Server=(localdb)\\mssqllocaldb;Database=KotelSiteDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasOne(p => p.User).WithOne(p => p.Cart);
            modelBuilder.Entity<User>().HasMany(p => p.OrderStories).WithOne(p => p.User);
            modelBuilder.Entity<ProductClass>().HasMany(p => p.Products).WithOne(p => p.ProductClass);
        }
    }
}
