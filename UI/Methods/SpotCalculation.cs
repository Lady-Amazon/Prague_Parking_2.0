using DataAccess;

namespace UI.Methods
{
    public class SpotCalculation
    {
        Config config = new Config();
        public void OccupationCalc(Label label, Label parkingLot)
        {
            config.ReadFromJson();

            using (var context = new ParkingContext())
            {
                string parkingSpaces = config.ParkingLotSize.ToString(); //ReadsFomJson
                var takenSpaces = (from p in context.ParkingGarage
                                   select p.ParkingSpot).Count();

                //Label for taken spaces
                label.Text = takenSpaces.ToString("000");

                parkingLot.Text = parkingSpaces;
            }
        }

    }
}
