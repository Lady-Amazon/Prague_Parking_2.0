using ParkingGarageLibrary;

namespace DataAccess;

public class ValidateData
{
    public static List<ParkingGarage> Records()
    {
        using (var parkingContext = new ParkingContext())
        {
            List<ParkingGarage> parkingGarages = parkingContext.ParkingGarage.ToList();

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
