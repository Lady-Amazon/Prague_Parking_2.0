using DataAccess;
using ParkingGarageLibrary;
using System.Data;
using UI.Methods;

namespace UI.Forms;

public partial class FormParkingLot : Form
{
    public List<ParkingGarage> parkingGarages = new List<ParkingGarage>();
    //public List<ParkingFee> parkingFees = new List<ParkingFee>();
    ParkingContext parkingContext = new ParkingContext();
    SpotCalculator calc = new SpotCalculator();
    Config config = new Config();

    int occupied = 0;
    int available = 100;
    public FormParkingLot()
    {
        InitializeComponent();
        populateParking();
        config.ReadFromJson();

    }
    private void btnCheckIn_Click(object sender, EventArgs e)
    {
        txtBoxLicenseNum.Text = txtBoxLicenseNum.Text.Trim();
        string vehicleTypeCar = boxCheckCar.Text;
        string vehicleTypeMc = boxCheckMc.Text;
        try
        {
            if (boxCheckCar.Checked && PickParkingSpot_Click != null && txtBoxLicenseNum.Text != string.Empty && available > 0)
            {
                available = available - 1;
                occupied = occupied + 1;
                using (parkingContext = new ParkingContext())
                {
                    var car = new ParkingGarage()
                    {
                        ParkingSpot = int.Parse(labelParkingSpot.Text),
                        LicenseNum = txtBoxLicenseNum.Text,
                        VehicleType = vehicleTypeCar,
                        VehicleSize = 4,
                        CheckedIn = DateTime.Now,
                        CheckedOut = null

                    };
                    parkingContext.ParkingGarage.Add(car);
                    parkingContext.SaveChanges();
                    MessageBox.Show("Car Parked");
                  

                    
                }
                ClearFields();
                calc.OccupationCalc(label000, label100);




                using (parkingContext = new ParkingContext())
                    {
                    var parkingLotStatus = (from p in parkingContext.ParkingGarage
                                            select p.ParkingSpot).ToList();

                    foreach (var parkingSpot in parkingLotStatus)
                    {
                        for (int i = 0; i < parkingLotStatus.Count; i++)
                        {
                            string spot = parkingSpot.ToString();
                            Button myButton = Controls.Find(spot, true).FirstOrDefault() as Button;
                            SpotsStatus(parkingSpot, myButton);
                        }
                    }

                }
            }
            else if (boxCheckMc.Checked && PickParkingSpot_Click != null && txtBoxLicenseNum.Text != string.Empty && available > 0)
            {
                available = available - 1;
                occupied = occupied + 1;
                using (parkingContext = new ParkingContext())
                {
                    var mc = new ParkingGarage()
                    {
                        ParkingSpot = int.Parse(labelParkingSpot.Text),
                        LicenseNum = txtBoxLicenseNum.Text,
                        VehicleType = vehicleTypeMc,
                        VehicleSize = 2,
                        CheckedIn = DateTime.Now,
                        CheckedOut = null
                    };
                    parkingContext.ParkingGarage.Add(mc);
                    parkingContext.SaveChanges();
                    MessageBox.Show("Mc Parked");
                  


                }
                ClearFields();
                calc.OccupationCalc(label000, label100);


                using (parkingContext = new ParkingContext())
                {
                    var parkingLotStatus = (from p in parkingContext.ParkingGarage
                                            select p.ParkingSpot).ToList();

                    foreach (var parkingSpot in parkingLotStatus)
                    {
                        for (int i = 0; i < parkingLotStatus.Count; i++)
                        {
                            string spot = parkingSpot.ToString();
                            Button myButton = Controls.Find(spot, true).FirstOrDefault() as Button;
                            SpotsStatus(parkingSpot, myButton);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("You have to enter LicenseNum, VehicleType and ParkingSpot!");
            }

        }
        catch (Exception ex)
        {

        }

        using (parkingContext = new ParkingContext())
        {
            parkingGarages = parkingContext.ParkingGarage.ToList();
        }
        dataGridView1.DataSource = parkingGarages;

    }
    private void btnCheckOut_Click_1(object sender, EventArgs e)
    {
        DateTime checkOut = pickTimeOut.Value;
        double price = 0;
        using (parkingContext = new ParkingContext())
        {
            var licenseNum = txtBoxLicenseNum.Text;
           
                var checkIn = parkingContext.ParkingGarage
                    .Where(l => l.LicenseNum == licenseNum)
                    .Select(t => t.CheckedIn)
                    .FirstOrDefault();
             if(checkIn != null)
             {

                 TimeSpan timeParked = TimeParkedCalc(licenseNum, checkOut);
                 string vehicleType= VehicleType(licenseNum);
                   
                if(vehicleType == "Car")
                    {
                        price = Math.Round(((double)timeParked.TotalHours * config.CarFeePerHour), 2); // CHANGES ACCORDING TO JSON

                    txtBoxLicenseNum.Clear();

                        var vehicle = parkingContext.ParkingGarage.FirstOrDefault(x => x.LicenseNum == licenseNum);
                        parkingContext.ParkingGarage.Remove(vehicle);
                        parkingContext.SaveChanges();
                        MessageBox.Show("Vehicle has been picked up");
                    if (price > 0)
                    {
                        txtBoxTotalCharge.Text = "CZK" + price;
                    }
                    else
                    {
                        txtBoxTotalCharge.Text = "Free Parking";
                    }

                    var spot = parkingContext.ParkingGarage
                                .Where(l => l.LicenseNum == licenseNum)
                                .Select(t => t.ParkingSpot)
                                .FirstOrDefault();


                    var hour = ((int)timeParked.TotalHours).ToString();
                    var Minute = timeParked.Minutes.ToString();

                    txtBoxDuration.Text = hour + "hr " + Minute + "min";

                    string takenSpot= spot.ToString();

                    Button myButton = Controls.Find(takenSpot, true).FirstOrDefault() as Button;
                                    
                    SpotsStatus(spot, myButton);
                            
                    }
                else if(vehicleType =="Mc")
                    {
                        price = Math.Round(((double)timeParked.TotalHours * config.McFeePerHour), 2); // CHANGES ACCORDING TO JSON
                        txtBoxLicenseNum.Clear();
                        var vehicle = parkingContext.ParkingGarage.FirstOrDefault(x => x.LicenseNum == licenseNum);
                        parkingContext.ParkingGarage.Remove(vehicle);
                        parkingContext.SaveChanges();

                        MessageBox.Show("Vehicle has been picked up");
                    if (price > 0)
                    {
                        txtBoxTotalCharge.Text = "CZK" + price;
                    }
                    else
                    {
                        txtBoxTotalCharge.Text = "Free Parking";
                    }

                    var hour = ((int)timeParked.TotalHours).ToString();
                    var Minute = timeParked.Minutes.ToString();

                    txtBoxDuration.Text = hour + "hr " + Minute + "min";
  
                    var spot = parkingContext.ParkingGarage
                              .Where(l => l.LicenseNum == licenseNum)
                              .Select(t => t.ParkingSpot)
                              .FirstOrDefault();
                    string takenSpot = spot.ToString();

                    Button myButton = Controls.Find(takenSpot, true).FirstOrDefault() as Button;

                    SpotsStatus(spot, myButton);

                 }

             }
            

        }

            //using (parkingContext = new ParkingContext())
            //{
            //    var licenseNum = txtBoxLicenseNum.Text;
            //    var checkIn = parkingContext.ParkingGarage
            //        .Where(l => l.LicenseNum == licenseNum)
            //        .Select(t => t.CheckedIn)
            //        .FirstOrDefault();
            //    if (occupied > 0)
            //    {
            //        available = available + 1;
            //        occupied = occupied - 1;
            //        var checkOut = DateTime.Parse(pickTimeOut.Text);
            //        var checkOut = DateTime.Parse(pickTimeOut.Text)/*.AddMinutes(-10)*/;

            //        var duration = float.Parse((checkOut - checkIn).TotalMinutes.ToString());
            //        var span = TimeSpan.FromMinutes(duration);
            //        var hour = ((int)span.TotalHours).ToString();
            //        var Minute = span.Minutes.ToString();

            //        txtBoxDuration.Text = hour + "hr " + Minute + "min";

            //        Cost(duration);

            //        var vehicle = parkingContext.ParkingGarage.FirstOrDefault(x => x.LicenseNum == licenseNum);
            //        parkingContext.ParkingGarage.Remove(vehicle);

            //        parkingContext.SaveChanges();
            //        MessageBox.Show("Vehicle has been picked up");


            //        using (parkingContext = new ParkingContext())
            //        {
            //            var parkingLotStatus = (from p in parkingContext.ParkingGarage
            //                                    select p.ParkingSpot).ToList();

            //            foreach (var parkingSpot in parkingLotStatus)
            //            {
            //                for (int i = 0; i < parkingLotStatus.Count; i++)
            //                {
            //                    string spot = parkingSpot.ToString();
            //                    Button myButton = Controls.Find(spot, true).FirstOrDefault() as Button;
            //                    SpotsStatus(parkingSpot, myButton);
            //                }
            //            }

            //        }
            //    }

            //}


            
        }


    public TimeSpan TimeParkedCalc(string licensePlate,DateTime checkOut)
    {
        using (var context = new ParkingContext())
        {
            var checkIn =(from t in parkingContext.ParkingGarage
                          where t.LicenseNum == licensePlate
                          select t.CheckedIn).FirstOrDefault();

            var payTime = checkOut.AddMinutes(-10);
            var duration = payTime - checkIn;

            return duration;    
        }
    }

    public string VehicleType(string licensePlate)
    {
        using (var context = new ParkingContext())
        {
            var vehicleType = (from t in parkingContext.ParkingGarage
                           where t.LicenseNum == licensePlate
                           select t.VehicleType).FirstOrDefault();

            return vehicleType;
        }

    }
    //private double Cost(double tid)
    //{
    //    double price = 0;
    //    TimeSpan time = TimeSpan.FromMinutes(tid);

    //    if (boxCheckCar.Checked && occupied > 0)
    //    {
    //        price = Math.Round(((double)time.TotalHours * 20), 2);
    //        txtBoxLicenseNum.Clear();
    //        boxCheckCar.Checked = false;
    //    }
    //    else if (boxCheckMc.Checked && occupied > 0)
    //    {
    //        price = Math.Round(((double)time.TotalHours * 10), 2);
    //        txtBoxLicenseNum.Clear();
    //        boxCheckMc.Checked = false;
    //    }

    //    txtBoxTotalCharge.Text = "CZK" + price;
    //    return price;
    //}

    private void boxCheckCar_CheckedChanged(object sender, EventArgs e)
    {

        btnCheckIn.Enabled = boxCheckCar.Checked;
    }

    private void boxCheckMc_CheckedChanged(object sender, EventArgs e)
    {

        btnCheckIn.Enabled = boxCheckMc.Checked;
    }

    private void PickParkingSpot_Click(object sender, EventArgs e)//För att få vilken av knapparna man tryckt på. Valet skrivs ut i en label
    {
        string vehicles;
        Button clickedButton = (Button)sender;
        string Space = clickedButton.Tag.ToString();
        labelParkingSpot.Text = Space.Substring(Space.Count() - 2, 2);

        GetSumVehicleSize();
        Calculation();
    }
    public int GetSumVehicleSize()
    {
        using (ParkingContext context = new ParkingContext())
        {
            var result = context.ParkingGarage
                 .Where(p => p.ParkingSpot.Equals(int.Parse(labelParkingSpot.Text)))
                 .Sum(p => p.VehicleSize);
            return result;
        }
    }
    public void Calculation()
    {
        int maxCarSize = 4;
        int maxMcSize = 2;
        int minSize = 0;

        if (boxCheckCar.Checked)//Nu fungerar denna som det ska.
        {
            if (GetSumVehicleSize() <= minSize)
            {
                ChangeColor(labelParkingSpot, Color.Green, minSize);
                parkingavailability.Text = "Empty spot";
                btnCheckIn.Enabled = true;
            }
            else if (GetSumVehicleSize() > minSize)
            {
                ChangeColor(labelParkingSpot, Color.Red, maxCarSize);
                parkingavailability.Text = "Parking spot is already taken";
                btnCheckIn.Enabled = false;
            }
        }
        else if (boxCheckMc.Checked)
        {

            if (GetSumVehicleSize() <= maxMcSize)
            {
                ChangeColor(labelParkingSpot, Color.Green, maxMcSize);
                parkingavailability.Text = "Empty spot";
                btnCheckIn.Enabled = true;
            }
            else if (GetSumVehicleSize() >= maxCarSize)//Ändrade här til >= så nu säger den ifrån om 2 mc står på samma ruta
            {
                ChangeColor(labelParkingSpot, Color.Red, maxCarSize);
                parkingavailability.Text = "Parking spot is already taken";
                btnCheckIn.Enabled = false;
            }
        }
    }
    private void populateParking()
    {
        var rowCount = 10;
        var columnCount = 10;

        viewParkingLot.ColumnCount = columnCount;
        viewParkingLot.RowCount = rowCount;

        viewParkingLot.ColumnStyles.Clear();
        viewParkingLot.RowStyles.Clear();

        for (int i = 0; i < columnCount; i++)
        {
            viewParkingLot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount));
        }
        for (int i = 0; i < rowCount; i++)
        {
            viewParkingLot.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));
        }

        int counter = 0;
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                for (int k = 0; k < 1; k++)
                {
                    var button = new Button();
                    button.Text = string.Format("{0}{1}", i, j);
                    button.Name = string.Format("{0}", counter++);
                    button.Dock = DockStyle.Fill;
                    button.Click += PickParkingSpot_Click;
                    button.Tag = button;
                    button.BackColor = Color.Green;

                    viewParkingLot.Controls.Add(button, j, i);
                }
            }
        }
    }

    private void FormParkingLot_Load(object sender, EventArgs e)
    {
        using (parkingContext = new ParkingContext())
        {
            parkingGarages = parkingContext.ParkingGarage.ToList();
            calc.OccupationCalc(label000, label100);

        }
        dataGridView1.DataSource = parkingGarages;

        using (parkingContext = new ParkingContext())
        {
            var parkingLotStatus = (from p in parkingContext.ParkingGarage
                                    select p.ParkingSpot).ToList();

            foreach (var parkingSpot in parkingLotStatus)
            {
                for (int i = 0; i < parkingLotStatus.Count; i++)
                {
                    string spot = parkingSpot.ToString();
                    Button myButton = Controls.Find(spot, true).FirstOrDefault() as Button;
                    SpotsStatus(parkingSpot, myButton);
                }
            }

        }
    }
    public void SpotsStatus(int parkingSpot, Button buttonStatus)
    {
        using (var db = new ParkingContext())
        {
            var checkIfFull = (from p in db.ParkingGarage
                               where p.ParkingSpot == parkingSpot
                               select p.VehicleSize).ToArray();

            int total = 0;

            for (int i = 0; i < checkIfFull.Length; i++)
            {
                int value = checkIfFull[i];
                total += value;
            }
            if (buttonStatus != null)
            {
                if (total == 4)
                {
                    buttonStatus.BackColor = Color.Red;
                }
                else if (total == 2)
                {
                    buttonStatus.BackColor = Color.DarkOrange;
                }
            }
            else if (total == 0)
            {
                buttonStatus.BackColor = Color.FromArgb(89, 165, 216);
            }
        }
    }
  
    public void ClearFields()
    {
        txtBoxLicenseNum.Clear();
        boxCheckCar.Checked = false;
        boxCheckMc.Checked = false;
        labelParkingSpot.ResetText();
        parkingavailability.ResetText();
    }
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            txtBoxLicenseNum.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }
    static void ChangeColor(Label label, Color color, int size)
    {
        label.BackColor = color;
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnExit_Click_1(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
