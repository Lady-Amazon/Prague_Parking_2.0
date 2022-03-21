using DataAccess;
using Microsoft.Extensions.Configuration;

namespace UI.Methods
{
    public class SpotCalculation
    {
       // Config config = new Config();
        public void OccupationCalc(Label label, Label parkingLot)
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build()
            .Get<Config>();
            //config.ReadFromJson();
            using (var parkingContext = new ParkingContext())
            {
                string parkingSpaces = config.ParkingLotSize.ToString(); //ReadsFomJson
                var takenSpaces = (from p in parkingContext.ParkingGarage
                                   select p.ParkingSpot).Count();

                //Label for taken spaces
                label.Text = takenSpaces.ToString("000");

                parkingLot.Text = parkingSpaces;
            }
        }

    }
}
