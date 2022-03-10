using DataAccess;
using Microsoft.Data.SqlClient;
using ParkingGarageLibrary;
using static ParkingGarageLibrary.Enums;

namespace UI.Forms;

public partial class FormParkingLot : Form
{
    ParkingContext parkingContext = new ParkingContext();
    Car car = new Car();
    MC mc = new MC();
    
    
    public FormParkingLot()
    {
        InitializeComponent();
    }
    
    string connstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PraugeParking;Integrated Security=True";
    private void FormParkingLot_Load(object sender, EventArgs e)
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
            }
        }
    }

    private void btnCheckIn_Click(object sender, EventArgs e)
    {
        if (checkCar.Checked)
        {
            txtBoxLicenseNum.Text = car.LicenseNum.ToString();
           // checkCar.Checked = VehicleType.Car;
        }
        if (checkMc.Checked)
        {
            txtBoxLicenseNum.Text = mc.LicenseNum.ToString();
            //checkMc.Checked = VehicleType.Mc;
        }
        
    }

    private void checkCar_CheckedChanged(object sender, EventArgs e)
    {
        btnCheckIn.Enabled = checkCar.Checked;
        
    }
    private void checkMc_CheckedChanged(object sender, EventArgs e)
    {
        btnCheckIn.Enabled = checkMc.Checked;
    }
   

}
