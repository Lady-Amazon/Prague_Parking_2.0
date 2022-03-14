using System.ComponentModel.DataAnnotations;

namespace ParkingGarageLibrary
{
    public class ParkingGarage
    {
        [Key]
        public int Id { get; set; }
        public int ParkingSpot { get; set; } = 100;
        public string LicenseNum { get; set; }
        public string VehicleType { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime? CheckedOut { get; set; }
        //public List<ParkingFee> ParkingFees { get; set; } = new List<ParkingFee>(); Vet int eriktigt vad jag vill med denna, och om den
        //ska ligga här ens

        public int VehicleSize { get; set; }
    }
}
