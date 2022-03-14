namespace ParkingGarageLibrary.Models;

public interface IVehicle
{
    string LicenseNum { get; set; }
    string VehicleType { get; set; }
    int Size { get; set; }// Bil = 4, Mc = 2. 
}
