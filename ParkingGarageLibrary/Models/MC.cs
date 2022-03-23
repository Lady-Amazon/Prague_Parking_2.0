using ParkingGarageLibrary.Models;

namespace ParkingGarageLibrary;

public class MC : IVehicle
{
    public string LicenseNum { get; set; }
    public string VehicleType { get; set; }
    public int Size { get; set; }

    public MC(string licenseNum, string vehicleType)
    {
        LicenseNum = licenseNum;
        VehicleType = vehicleType;
        Size = 2;

    }

    public MC()
    {
    }
}
