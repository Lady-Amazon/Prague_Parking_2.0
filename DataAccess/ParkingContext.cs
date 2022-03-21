﻿using Microsoft.EntityFrameworkCore;
using ParkingGarageLibrary;

namespace DataAccess;

public class ParkingContext : DbContext
{
    public DbSet<ParkingSpot> ParkingGarage { get; set; }
    public DbSet<ParkingFee> Fees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //IConfigurationRoot configuration = new ConfigurationBuilder()
        //       .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //       .AddJsonFile("appsettings.json")
        //       .Build();
        //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PraugeParking;Integrated Security=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ParkingSpot>(entity =>
        {
            entity.HasKey(e => e.Id);
        });
        modelBuilder.Entity<ParkingFee>()
        .ToTable("Fees");
    }

}
