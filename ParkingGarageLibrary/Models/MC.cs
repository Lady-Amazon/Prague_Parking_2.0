using DataAccess;

namespace ParkingGarageLibrary.Models;

public class MC : Vehicle
{
    public MC(string licenseNum) : base(licenseNum)
    {
        var config = new Config();
        Size = config.McSize;   // TODO: Hämtas från config
    }
}
