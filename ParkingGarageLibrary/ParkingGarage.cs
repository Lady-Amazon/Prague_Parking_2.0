namespace ParkingGarageLibrary
{
    public class ParkingGarage : IParkingSpot
    {
        public int parkingSpot { get; set; }
        public string licenseNum { get; set; }
        public string vehicleType { get; set; }
        public DateTime checkedIn { get; set; }
        public DateTime checkedOut { get; set; }
    }
}
