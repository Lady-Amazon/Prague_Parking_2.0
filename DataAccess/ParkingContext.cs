using Microsoft.EntityFrameworkCore;
using ParkingGarageLibrary;

namespace DataAccess;

public class ParkingContext : DbContext
{
    public DbSet<ParkingGarage> ParkingGarage { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PraugeParking;Integrated Security=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ParkingGarage>(entity =>
        {
            entity.HasKey(e => e.ParkingSpot);
        });
        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(p => p.ParkingSpot);
        });
        //.ToTable("Vehicles");
    }

}
