namespace ParkingGarageLibrary
{
    public class ParkingFee : ParkingGarage
    {
        public ParkingFee()
        {
        }

        //First 10 min is free of charge
        //public string LicenseNum { get; set; }
        //public string VehicleType { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime CheckedOut { get; set; }
        public decimal CarFee { get; set; }
        public decimal McFee { get; set; }

    }
}
