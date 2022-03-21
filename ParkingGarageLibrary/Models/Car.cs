using DataAccess;

namespace ParkingGarageLibrary.Models;


public class Car : Vehicle
{
    public Car(string licenseNum) : base(licenseNum)
    {
        var config = new Config();
        Size = config.CarSize;   // TODO: Hämtas från config
    }
}
