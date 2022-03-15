using DataAccess;
using ParkingGarageLibrary;

namespace UI.Forms;

public partial class FormParkingLot : Form
{

    public List<ParkingGarage> parkingGarages = new List<ParkingGarage>();
    ParkingContext parkingContext = new ParkingContext();

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
                using (ParkingContext context = new ParkingContext())
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
            }
            else if (boxCheckMc.Checked && PickParkingSpot_Click != null)
            {
                using (ParkingContext context = new ParkingContext())
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
    private void btnCheckOut_Click(object sender, EventArgs e)//Work in progress för att checka ut fordon
    {
        DateTime timeIn = DateTime.Parse(pickTimeIn.Text);
        DateTime timeOut = DateTime.Parse(pickTimeOut.Text);

        float duration = float.Parse((timeOut - timeIn).TotalMinutes.ToString());
        var span = TimeSpan.FromMinutes(duration);
        var hour = ((int)span.TotalHours).ToString();
        var Minute = span.Minutes.ToString();

        txtBoxDuration.Text = hour + "hr " + Minute + "min";

        float numHours = duration / 60;
        int price;

        if (numHours > 0)
        {
            if (duration / 60 <= 0.25)
            {
                txtBoxTotalCharge.Text = "CZK" + 0;
            }
            else if (numHours <= 3 && numHours > 0.25)
            {
                txtBoxTotalCharge.Text = "CZK" + 20;
            }
            else if (numHours > 3)
            {
                price = 20 + ((int)Math.Ceiling(numHours) - 3) * 20;
                txtBoxTotalCharge.Text = "CZK" + price;
            }
        }
        //numVehicles = numVehicles + 1;

        //if (!(txtBoxLicenseNum.Text == string.Empty))
        //{
        //    string str = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PraugeParking;Integrated Security=True";
        //    SqlConnection con = new SqlConnection(str);
        //    string query = "DELETE FROM ParkingGarage WHERE LicenseNum = '" + txtBoxLicenseNum + "'";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    SqlDataReader myreader;
        //    try
        //    {
        //        con.Open();
        //        myreader = cmd.ExecuteReader();
        //        MessageBox.Show("successfully data Deleted");
        //        while (myreader.Read())
        //        {
        //        }
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //else
        //{
        //    MessageBox.Show("Choose a Vehicle!");
        //}

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
        Button clickedButton = (Button)sender;
        string Space = clickedButton.Tag.ToString();
        labelParkingSpot.Text = Space.Substring(Space.Count() - 2, 2);

<<<<<<< HEAD
=======
        
        
>>>>>>> 5d94187ae09501027266f966d47e67f5787f6f9f
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
        int newSize;
        if (boxCheckCar.Checked)
        {


            if (GetSumVehicleSize() <= minSize)
            {
                MessageBox.Show("Empty parkingSpot");
            }
            else if (GetSumVehicleSize() > minSize)
            {
                MessageBox.Show($"ParkingSpot already full : ");
            }

        }
        else if (boxCheckMc.Checked)
        {
            newSize = 2;

            if (GetSumVehicleSize() <= minSize)
            {
                MessageBox.Show("Empty parkingSpot");
            }
            else if (GetSumVehicleSize() > maxMcSize)
            {
                MessageBox.Show($"ParkingSpot already full:");
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
}
