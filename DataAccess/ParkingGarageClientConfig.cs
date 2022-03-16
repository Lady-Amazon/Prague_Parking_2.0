using ParkingGarageLibrary;

namespace DataAccess
{
    public class ParkingGarageClientConfig
    {
        public bool IsEnabled { get; set; }
        public int ParkingSpotSize { get; set; }
        public int ParkingLotSize { get; set; }
        public int CarSize { get; set; }
        public int McSize { get; set; }
        public int CarFeePerHour { get; set; }
        public int McFeePerHour { get; set; }
    }
}
