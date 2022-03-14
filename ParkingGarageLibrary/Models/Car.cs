using ParkingGarageLibrary.Models;

namespace ParkingGarageLibrary;

public class Car : IVehicle
{
    public string LicenseNum { get; set; }
    public string VehicleType { get; set; }
    public int Size { get; set; }

    public Car(string licenseNum, string vehicleType)
    {
        LicenseNum = licenseNum;
        VehicleType = vehicleType;
        Size = 4;
    }

    public Car()
    {
    }
}
