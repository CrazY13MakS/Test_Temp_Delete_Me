using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
  public  class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }
        public AppDbContext():base()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<OrderCar>().HasOne(x => x.Car);
           // modelBuilder.Entity<OrderCar>().HasOne(x => x.Order).WithMany().OnDelete( DeleteBehavior.SetNull).IsRequired(false);
           // modelBuilder.Entity<Order>().HasMany(x => x.Cars).WithOne(x=>x.Order).IsRequired(false).OnDelete( DeleteBehavior.SetNull);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<OrderCar> OrderCars { get; set; }
        public virtual DbSet<ManagerInfo> ManagerInfos { get; set; }

    }
}
