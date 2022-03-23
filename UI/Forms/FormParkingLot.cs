using DataAccess;
using Microsoft.Extensions.Configuration;
using ParkingGarageLibrary;
using System.Data;
using UI.Methods;

namespace UI.Forms;
public partial class FormParkingLot : Form
{
    public List<ParkingGarage> parkingGarages = new List<ParkingGarage>();
    Config config = new Config();
    SpotCalculation calc = new SpotCalculation();
    public FormParkingLot()
    {
        InitializeComponent();
        populateParking();
        calc.OccupationCalc(label000, label100);
        config.ReadFromJson();
    }
    private void btnCheckIn_Click(object sender, EventArgs e)
    {
        txtBoxLicenseNum.Text = txtBoxLicenseNum.Text.Trim();
        string vehicleTypeCar = boxCheckCar.Text;
        string vehicleTypeMc = boxCheckMc.Text;
        try
        {
            if (boxCheckCar.Checked && PickParkingSpot_Click != null && txtBoxLicenseNum.Text != string.Empty)
            {
                using (var parkingContext = new ParkingContext())
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

                using (var parkingContext = new ParkingContext())
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
            else if (boxCheckMc.Checked && PickParkingSpot_Click != null && txtBoxLicenseNum.Text != string.Empty)
            {
                using (var parkingContext = new ParkingContext())
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

                using (var parkingContext = new ParkingContext())
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
            MessageBox.Show(Text, ex.Message);
        }

        using (var parkingContext = new ParkingContext())
        {
            parkingGarages = parkingContext.ParkingGarage.ToList();
        }
        dataGridView1.DataSource = parkingGarages;
    }
    private void btnCheckOut_Click_1(object sender, EventArgs e)
    {
        //using (parkingContext = new ParkingContext())
        //{
        //    var licenseNum = txtBoxLicenseNum.Text;
        //    var checkIn = parkingContext.ParkingGarage
        //        .Where(l => l.LicenseNum == licenseNum)
        //        .Select(t => t.CheckedIn)
        //        .FirstOrDefault();

        //    var checkOut = DateTime.Parse(pickTimeOut.Text).AddMinutes(-10);

        //    var duration = float.Parse((checkOut - checkIn).TotalMinutes.ToString());
        //    var span = TimeSpan.FromMinutes(duration);
        //    var hour = ((int)span.TotalHours).ToString();
        //    var Minute = span.Minutes.ToString();

        //    txtBoxDuration.Text = hour + "hr " + Minute + "min";

        //    Cost(duration);

        //    var vehicle = parkingContext.ParkingGarage.FirstOrDefault(x => x.LicenseNum == licenseNum);
        //    parkingContext.ParkingGarage.Remove(vehicle);

        //    parkingContext.SaveChanges();
        //    MessageBox.Show("Vehicle has been picked up");

        //}
        //double Cost(double tid)
        //{
        //    double price = 0;
        //    TimeSpan time = TimeSpan.FromMinutes(tid);

        //    var config = new ConfigurationBuilder()
        //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //        .AddJsonFile("appsettings.json")
        //        .Build()
        //        .Get<Config>();

        //    if (boxCheckCar.Checked)
        //    {
        //        price = Math.Round(((double)time.TotalHours * config.CarFeePerHour), 2);
        //        txtBoxLicenseNum.Clear();
        //        boxCheckCar.Checked = false;
        //    }
        //    else if (boxCheckMc.Checked)
        //    {
        //        price = Math.Round(((double)time.TotalHours * config.McFeePerHour), 2);
        //        txtBoxLicenseNum.Clear();
        //        boxCheckMc.Checked = false;
        //    }

        //    if (price < 0)
        //    {
        //        price = 0;
        //        txtBoxTotalCharge.Text = "CZK" + price;
        //    }
        //    else
        //    {
        //        txtBoxTotalCharge.Text = "CZK" + price;
        //    }

        //    return price;
        //}
        DateTime checkOut = pickTimeOut.Value;
        double price = 0;

        using (var parkingContext = new ParkingContext())
        {
            var licenseNum = txtBoxLicenseNum.Text;

            var checkIn = parkingContext.ParkingGarage
                .Where(l => l.LicenseNum == licenseNum)
                .Select(t => t.CheckedIn)
                .FirstOrDefault();

            if (checkIn != null)
            {
                TimeSpan timeParked = TimeParkedCalc(licenseNum, checkOut);
                string vehicleType = VehicleType(licenseNum);

                if (vehicleType == "Car")
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
                    var minute = timeParked.Minutes.ToString();

                    txtBoxDuration.Text = hour + "hr " + minute + "min";

                    string takenSpot = spot.ToString();
                    Button myButton = Controls.Find(takenSpot, true).FirstOrDefault() as Button;

                    SpotsStatus(spot, myButton);
                }
                else if (vehicleType == "Mc")
                {
                    price = Math.Round((double)timeParked.TotalHours * config.McFeePerHour, 2); // CHANGES ACCORDING TO JSON

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
                    var minute = timeParked.Minutes.ToString();

                    txtBoxDuration.Text = hour + "hr " + minute + "min";

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
    }
    public TimeSpan TimeParkedCalc(string licensePlate, DateTime checkOut)
    {
        using (var parkingContext = new ParkingContext())
        {
            var checkIn = (from l in parkingContext.ParkingGarage
                           where l.LicenseNum == licensePlate
                           select l.CheckedIn).FirstOrDefault();

            var payTime = checkOut.AddMinutes(-10);
            var duration = payTime - checkIn;

            return duration;
        }
    }
    public string VehicleType(string licensePlate)
    {
        using (var parkingContext = new ParkingContext())
        {
            var vehicleType = (from t in parkingContext.ParkingGarage
                               where t.LicenseNum == licensePlate
                               select t.VehicleType).FirstOrDefault();

            return vehicleType;
        }

    }
    private void boxCheckCar_CheckedChanged(object sender, EventArgs e)
    {
        btnCheckIn.Enabled = boxCheckCar.Checked;
    }
    private void boxCheckMc_CheckedChanged(object sender, EventArgs e)
    {
        btnCheckIn.Enabled = boxCheckMc.Checked;
    }
    private void PickParkingSpot_Click(object sender, EventArgs e)//To check witch spot is clicked. The click event shows in a label
    {
        string vehicles;
        Button clickedButton = (Button)sender;
        string Space = clickedButton.Tag.ToString();
        labelParkingSpot.Text = Space.Substring(Space.Count() - 2, 2);

        GetSumVehicleSize();
        Calculation();
    }
    public int GetSumVehicleSize()//
    {
        using (var parkingContext = new ParkingContext())
        {
            var result = parkingContext.ParkingGarage
                 .Where(p => p.ParkingSpot.Equals(int.Parse(labelParkingSpot.Text)))
                 .Sum(p => p.VehicleSize);
            return result;
        }
    }
    public void Calculation()//Checks if a type of wehicle can be parked in the parkingspot
    {
        int maxCarSize = 4;
        int maxMcSize = 2;
        int minSize = 0;

        if (boxCheckCar.Checked)//Use the checkboxes to see if the vehicle type can park
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
            else if (GetSumVehicleSize() >= maxCarSize) 
            {
                ChangeColor(labelParkingSpot, Color.Red, maxCarSize);
                parkingavailability.Text = "Parking spot is already taken";
                btnCheckIn.Enabled = false;
            }
        }
    }
    private void populateParking()//Displays the grid for parkinspots. 
    {
        var rowCount = 10;
        var columnCount = 10;
        int counter = 0;

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
        using (var parkingContext = new ParkingContext())
        {
            parkingGarages = parkingContext.ParkingGarage.ToList();

        }
        dataGridView1.DataSource = parkingGarages;

        using (var parkingContext = new ParkingContext())
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
    public void SpotsStatus(int parkingSpot, Button buttonStatus)//Changes the color of the parkinspot depending on status
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
                buttonStatus.BackColor = Color.FromArgb(253, 153, 0);
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
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//To let you use the datagrid to pick licensnumber for the checkout
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            txtBoxLicenseNum.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }
    static void ChangeColor(Label label, Color color, int size)//To change the color of the label when parkingspot is clicked
    {
        label.BackColor = color;
    }
    private void btnExit_Click_1(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnHowTo_Click(object sender, EventArgs e)
    {
        string title = "How To";
        string msg = "How To Use Parking Managment Check In System." +
            "- Check In: Enter License Number, choose Car/Mc in checkbox, pick parkingspot. Click check in." +
            "- Check Out: Click the license number in the list, use check box for Car/Mc. Click Check out. " +
            "Total Cost and Duration will be displayed";
        MessageBox.Show(msg, title);
    }
}
