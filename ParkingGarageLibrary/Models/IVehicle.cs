using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageLibrary.Models
{
    public interface IVehicle
    {
         string LicenseNum { get; set; }
         string VehicleType { get; set; }
         int UnitSize { get; set; }
    }
}
