﻿using DataAccess;
using ParkingGarageLibrary;
using static ParkingGarageLibrary.Enums;

namespace UI.Forms;

public partial class FormParkingLot : Form
{
    ParkingContext parkingContext = new ParkingContext();
    //Behöver skapa en json/config fil och prislista. Behöver ordna med parkeringen så att fler fordon inte kan stå i samma ruta. Utskrift av dbn i gridviewn 
<<<<<<< HEAD
   
=======
    public List<ParkingGarage> parkingGarages { get; set; }
>>>>>>> 39cec9b23826a1c4e99a4bc4ab9b8f6c495d1e29

    //dessa är inte i bruk än. Kanske måste Flyttas till FomrMainMenu
    int occupied = 0;
    int available = 100;
    int numVehicles = 0;
    string attendant;
<<<<<<< HEAD
    
=======

    public void Calculations()
    {
        var data = parkingGarages
            .Where(x=> x.ParkingSpot = )
            .Sum(x=> x.VehicleType.)
    }

>>>>>>> 39cec9b23826a1c4e99a4bc4ab9b8f6c495d1e29
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
                    using (parkingContext)
                    {
                        var car = new ParkingGarage()
                        {
                            ParkingSpot = int.Parse(labelParkingSpot.Text),
                            LicenseNum = txtBoxLicenseNum.Text,
                            VehicleType = vehicleTypeCar,
                            CheckedIn = DateTime.Now,
                            CheckedOut = null

<<<<<<< HEAD
                        };
                        parkingContext.ParkingGarage.Add(car);
                        parkingContext.SaveChanges();
                        MessageBox.Show("Car Parked");
                    }
                    txtBoxLicenseNum.Clear();
                    boxCheckCar.Checked = false;
=======
                    };
                    parkingContext.ParkingGarage.Add(car);
                    parkingContext.SaveChanges();
                    MessageBox.Show("Car Parked");
                }
                txtBoxLicenseNum.Clear();
                boxCheckCar.Checked = false;
>>>>>>> 39cec9b23826a1c4e99a4bc4ab9b8f6c495d1e29
            }
            else if (boxCheckMc.Checked && PickParkingSpot_Click != null)
            {
                using (parkingContext)
                {
                    var mc = new ParkingGarage()
                    {
                        ParkingSpot = int.Parse(labelParkingSpot.Text),
                        LicenseNum = txtBoxLicenseNum.Text,
                        VehicleType = vehicleTypeMc,
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
<<<<<<< HEAD
     
=======



        
    }
    public void ab(string a)
    {
        attendant = a.ToString();
>>>>>>> 39cec9b23826a1c4e99a4bc4ab9b8f6c495d1e29
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
