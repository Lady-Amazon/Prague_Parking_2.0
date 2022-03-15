using DataAccess;
using ParkingGarageLibrary;

namespace UI.Forms;

public partial class FormParkingLot : Form
{
    ParkingContext parkingContext = new ParkingContext();
    
    public List<ParkingGarage> parkingGarages = new List<ParkingGarage>();
    int numVehicles = 0;
    public FormParkingLot()
    {
        InitializeComponent();
        populateParking();
    }
    private void btnCheckIn_Click(object sender, EventArgs e)//Fungerar till viss del, går att lägga in bilar/mc men inget felmeddelande om det redan står fordon där
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
                        CheckedIn = DateTime.Now,
                        CheckedOut = null,
                        VehicleSize = 4
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
                using (parkingContext = new ParkingContext())
                {
                    var mc = new ParkingGarage()
                    {
                        ParkingSpot = int.Parse(labelParkingSpot.Text),
                        LicenseNum = txtBoxLicenseNum.Text,
                        VehicleType = vehicleTypeMc,
                        CheckedIn = DateTime.Now,
                        CheckedOut = null,
                        VehicleSize = 2
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
                txtBoxLicenseNum.Clear();
                boxCheckCar.Checked = false;
                boxCheckMc.Checked = false;
            }
        }
        catch (Exception ex)
        {
            //if (PickParkingSpot_Click != null)
            //{
            //    MessageBox.Show("Parking spot already taken!", ex.Message);
            //}
        }
        using (parkingContext = new ParkingContext())
        {
            parkingGarages = parkingContext.ParkingGarage.ToList();
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
        if (boxCheckMc.Checked)
        {
            btnCheckIn.Enabled = boxCheckMc.Checked;
        }
        else
        {
            btnCheckIn.Enabled = false;
        }
        
    }

    private void PickParkingSpot_Click(object sender, EventArgs e)//För att få vilken av knapparna man tryckt på. Valet skrivs ut i en label
    {
        Button clickedButton = (Button)sender;
        string Space = clickedButton.Tag.ToString();
        labelParkingSpot.Text = Space.Substring(Space.Count() - 2, 2);
    }
    private void populateParking()
    {
        var rowCount = 10;
        var columnCount = 10;

        viewParkingLot.ColumnCount = columnCount;//viewParkingLot = TabelLayoutPanel
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
        using (ParkingContext parkingContext = new ParkingContext())
        {
            parkingGarages = parkingContext.ParkingGarage.ToList();
        }
        dataGridView1.DataSource = parkingGarages;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//Klickar man på ett regnummer kommer det upp i Textrutan där man skriver in nya fordon
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            txtBoxLicenseNum.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }

}

