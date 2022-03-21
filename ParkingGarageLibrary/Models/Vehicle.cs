namespace ParkingGarageLibrary.Models
{
    public class Vehicle
    {
        public Vehicle(string licenseNum)
        {
            LicenseNum = licenseNum;
            CheckedIn = DateTime.Now;
        }
        public string LicenseNum { get; set; }
        //public string VehicleType { get; set; }
        public int Size { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime? CheckedOut { get; set; }
    }
}