using DataAccess;
using ParkingGarageLibrary;
using System.Linq;
using static ParkingGarageLibrary.Enums;

namespace UI.Forms;

public partial class FormParkingLot : Form
{
    
    public List<ParkingGarage> parkingGarages = new List<ParkingGarage>();
    ParkingContext parkingContext = new ParkingContext();
    //Behöver skapa en json/config fil och prislista. Behöver ordna med parkeringen så att fler fordon inte kan stå i samma ruta. Utskrift av dbn i gridviewn 
    

    //dessa är inte i bruk än. Kanske måste Flyttas till FomrMainMenu
    int occupied = 0;
    int available = 100;
    int numVehicles = 0;
    string attendant;


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
                MessageBox.Show($"ParkingSpot already full : {GetSumVehicleSize()}");
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
                MessageBox.Show($"ParkingSpot already full: {GetSumVehicleSize()}");
            }

        }

    }

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
                        VehicleSize= 2,
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

        
        
        GetSumVehicleSize();
        Calculation();
     
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
