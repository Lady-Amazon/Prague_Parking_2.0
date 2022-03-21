using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Methods
{
    public  class SpotCalculator
    {
        public void OccupationCalc(Label label, Label parkingLot)
        {
            using (var context = new ParkingContext())
            {
                string parkingSpaces = "100"; //Change to config value to string 
                var takenSpaces = (from p in context.ParkingGarage
                                   select p.ParkingSpot).Count();

                //Label for taken spaces
                label.Text = takenSpaces.ToString("000");

                parkingLot.Text = parkingSpaces;
            }
        }
    }
}
