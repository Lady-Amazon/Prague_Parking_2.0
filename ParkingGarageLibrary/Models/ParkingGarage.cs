using System.ComponentModel.DataAnnotations;

namespace ParkingGarageLibrary
{
    public class ParkingGarage
    {
        [Key]
        public int Id { get; set; }
        public int ParkingSpot { get; set; }
        public string LicenseNum { get; set; }
        public string VehicleType { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime? CheckedOut { get; set; }
        public int VehicleSize { get; set; }

        public ParkingGarage() { }

    }
}
