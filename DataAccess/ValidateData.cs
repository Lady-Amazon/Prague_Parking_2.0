using ParkingGarageLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ValidateData
    {
        public static List<ParkingGarage> Records()
        {
            using (var context = new ParkingContext())
            {
                List<ParkingGarage> parkingGarages = context.ParkingGarage.ToList();

                return parkingGarages;
            }
        }

        public static bool IsDbEmpty()
        {
            var result = Records();

            if (result.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
