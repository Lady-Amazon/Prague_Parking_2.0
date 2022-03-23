using ParkingGarageLibrary;

namespace DataAccess;

public class TestData
{
    public static void PopulateDb()
    {
        string[] parkedVehicles = File.ReadAllLines("TestData.csv");

        List<string[]> cleanedList = parkedVehicles
            .Skip(1)
            .Select(x => x.Split(','))
            .ToList();

        using (var parkingContext = new ParkingContext())
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
                        parkingContext.Add(garage);
                    }
                    catch (Exception ex)
                    {
                        exception = true;
                    }
                }
            }
            parkingContext.SaveChanges();
        }
    }
}
