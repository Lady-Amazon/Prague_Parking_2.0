using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ParkingGarageLibrary;

namespace DataAccess;

public class ParkingContext : DbContext
{
    public DbSet<ParkingGarage> ParkingGarage { get; set; }
    public DbSet<ParkingFee> Fees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
            IConfiguration configuration = configurationBuilder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ParkingGarage>(entity =>
        {
            entity.HasKey(e => e.Id);
        });
        modelBuilder.Entity<ParkingFee>()
        .ToTable("Fees");
    }

}
