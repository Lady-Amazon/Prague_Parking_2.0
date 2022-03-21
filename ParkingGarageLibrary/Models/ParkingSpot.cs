using ParkingGarageLibrary.Models;
using System.ComponentModel.DataAnnotations;


namespace ParkingGarageLibrary
{
    public class ParkingSpot
    {
        [Key]
        public int Id { get; set; }
        public int SpotNumber { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        //public string LicenseNum { get; set; }
        //public string VehicleType { get; set; }

        //public int VehicleSize { get; set; }
        //public DateTime CheckedIn { get; set; }
        //public DateTime? CheckedOut { get; set; }

    }
}
