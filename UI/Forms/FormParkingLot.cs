using DataAccess;
using Microsoft.Data.SqlClient;
using ParkingGarageLibrary;
using System.Data;

namespace UI.Forms;

public partial class FormParkingLot : Form
{

    public List<ParkingGarage> parkingGarages = new List<ParkingGarage>();
    public List<ParkingFee> parkingFees = new List<ParkingFee>();
    ParkingContext parkingContext = new ParkingContext();
    //public static string AvailableValue = "";
    //public static string OccupiedValue = "";

    public FormParkingLot()
    {
        InitializeComponent();
        populateParking();
    }
    private void btnCheckIn_Click(object sender, EventArgs e)
    {
        txtBoxLicenseNum.Text = txtBoxLicenseNum.Text.Trim();
        string vehicleTypeCar = boxCheckCar.Text;
        string vehicleTypeMc = boxCheckMc.Text;
        try
        {
            if (boxCheckCar.Checked && PickParkingSpot_Click != null)
            {
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
                txtBoxLicenseNum.Clear();
                boxCheckCar.Checked = false;
                labelParkingSpot.ResetText();
                parkingavailability.ResetText();
            }
            else if (boxCheckMc.Checked && PickParkingSpot_Click != null)
            {
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
                txtBoxLicenseNum.Clear();
                boxCheckMc.Checked = false;
                labelParkingSpot.ResetText();
                parkingavailability.ResetText();
            }
            else
            {
                MessageBox.Show("You have to enter LicenseNum, VehicleType and ParkingSpot!");
            }

        }
        catch (Exception ex)
        {
            if (PickParkingSpot_Click != null)
            {
                MessageBox.Show("Parking spot already taken!", ex.Message);
            }
        }

        using (ParkingContext context = new ParkingContext())
        {
            parkingGarages = context.ParkingGarage.ToList();
        }
        dataGridView1.DataSource = parkingGarages;
    }
    private void btnCheckOut_Click_1(object sender, EventArgs e)
    {
<<<<<<< HEAD
        
        using (parkingContext = new ParkingContext())
        {
            var licenseNum = txtBoxLicenseNum.Text;
            var checkIn = parkingContext.ParkingGarage
                .Where(l => l.LicenseNum == licenseNum)
                .Select(t => t.CheckedIn)
                .FirstOrDefault();

            var checkOut = DateTime.Parse(pickTimeOut.Text).AddMinutes(-10);
=======
        using (ParkingContext context = new ParkingContext())
        {
            var licenseNum = txtBoxLicenseNum.Text;
            var checkIn = context.ParkingGarage
                .Where(l => l.LicenseNum == licenseNum)
                .Select(t => t.CheckedIn)
                .FirstOrDefault();
            //DateTime timeOut = DateTime.Parse(pickTimeOut.Text);
            //DateTime timeOut = DateTime.

            var checkOut = DateTime.Parse(pickTimeOut.Text).AddMinutes(-10);

            var duration = float.Parse((checkOut - checkIn).TotalMinutes.ToString());
            var span = TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var Minute = span.Minutes.ToString();

            txtBoxDuration.Text = hour + "hr " + Minute + "min";

            Cost(span);

            //float numHours = duration / 60;
            //double price;

            //if (numHours > 0)
            //{
            //    if (duration / 60 <= 0.25)
            //    {
            //        txtBoxTotalCharge.Text = "CZK" + 0;
            //    }
            //    else if (numHours <= 3 && numHours > 0.25)
            //    {
            //        txtBoxTotalCharge.Text = "CZK" + 20;
            //    }
            //    else if (numHours > 3)
            //    {
            //        price = 20 + ((int)Math.Ceiling(numHours) - 3) * 20;
            //        txtBoxTotalCharge.Text = "CZK" + price;
            //    }
            //}
        }
        
        double Cost(TimeSpan time)
        {
            double price = 0;
            if (boxCheckCar.Checked)
            {
                price = Math.Round(((double)time.TotalHours * 20),2);
            }
            else if (boxCheckMc.Checked)
            {
                price = Math.Round(((double)time.TotalHours * 10),2);
            }

            txtBoxTotalCharge.Text = "CZK" + price;

            return price;
        }
>>>>>>> 43379b8a0544f8ccb5a0050c07cde2a165234afc

            var duration = float.Parse((checkOut - checkIn).TotalMinutes.ToString());
            var span = TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var Minute = span.Minutes.ToString();

            txtBoxDuration.Text = hour + "hr " + Minute + "min";
            
            Cost(span);
    
        }
        double Cost(TimeSpan time)
        {
            double price = 0;
            if (boxCheckCar.Checked)
            {
                price = Math.Round(((double)time.TotalHours * 20), 2);
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;//Ändrar till rött men så fort man trycker på en annan rad försvinner det
                txtBoxLicenseNum.Clear();
                boxCheckCar.Checked = false;
            }
            else if (boxCheckMc.Checked)
            {
                price = Math.Round(((double)time.TotalHours * 10), 2);
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;
                txtBoxLicenseNum.Clear();
                boxCheckMc.Checked = false;
                
            }

            txtBoxTotalCharge.Text = "CZK" + price;

            return price;
        }
        using (parkingContext = new ParkingContext())//Försöker få till att att price ska spara i denna lista
        {
            parkingFees = parkingContext.Fees.ToList();
        }
        dataGridView2.DataSource = parkingFees;

    }

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
    static void ChangeColor(Label label, Color color, int size)
    {
        label.BackColor = color;
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

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                var button = new Button();
                button.Text = string.Format("{0}{1}", i, j);
                button.Name = string.Format("{0}{1}", i, j);
                button.Dock = DockStyle.Fill;
                viewParkingLot.Controls.Add(button, j, i);
                button.Click += PickParkingSpot_Click;
                button.Tag = button;

            }
        }
    }

    private void FormParkingLot_Load(object sender, EventArgs e)
    {
        using (ParkingContext context = new ParkingContext())
        {
            parkingGarages = context.ParkingGarage.ToList();
        }
        dataGridView1.DataSource = parkingGarages;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            txtBoxLicenseNum.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }


}
