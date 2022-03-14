using ParkingGarageLibrary;

namespace DataAccess
{
    public class ParkingGarageClientConfig
    {
        public bool IsEnabled { get; set; }
        public int Timeout { get; set; }

        public ParkingGarage ParkingSpots { get; set; }
    }
}
