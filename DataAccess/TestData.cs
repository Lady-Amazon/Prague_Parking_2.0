using ParkingGarageLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TestData
    {
        public static void PopulateDb()
        {
            string[] parkedVehicles = File.ReadAllLines("20 fordon - Blad1.csv");

            List<string[]> cleanedList = parkedVehicles
                .Skip(1)
                .Select(x => x.Split(','))
                .ToList();

            using (var context = new ParkingContext())
            {
                foreach (var value in cleanedList)
                {
                    ParkingGarage garage = new ParkingGarage();
                    bool exception = false;

                    try
                    {
                        garage.ParkingSpot = Convert.ToInt16(value[0]);
                        garage.LicenseNum = Convert.ToString(value[1]);
                        garage.VehicleType = Convert.ToString(value[2]);
                        garage.VehicleSize = Convert.ToInt16(value[3]);
                        garage.CheckedIn = Convert.ToDateTime(value[4]);
                    }
                    catch (Exception ex)
                    {
                        exception = true;
                    }
                    if (exception == false)
                    {
                        try
                        {
                            context.Add(garage);
                        }
                        catch (Exception ex)
                        {
                            exception = true;
                        }
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
