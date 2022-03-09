using Microsoft.EntityFrameworkCore;

namespace ParkingGarageLibrary;


public class Vehicle
{
    //public int ParkingSpot { get; set; }
    public string LicenseNum { get; set; }
    public string VehicleType { get; set; }
    public int UnitSize { get; set; }
    
}
