using DataAccess;

namespace UI.Methods
{
    public class SpotCalculation
    {
        public void OccupationCalc(Label label, Label parkingLot)
        {
            using (var parkingContext = new ParkingContext())
            {
                string parkingSpaces = "100"; //Change to config value to string 
                var takenSpaces = (from p in parkingContext.ParkingGarage
                                   select p.ParkingSpot).Count();

                //Label for taken spaces
                label.Text = takenSpaces.ToString("000");

                parkingLot.Text = parkingSpaces;
            }
        }

    }
}
