using DataAccess;
using Microsoft.Data.SqlClient;
using ParkingGarageLibrary;
using System.Data;

namespace UI.Forms;

public partial class FormParkingLot : Form
{
    ParkingContext parkingContext = new ParkingContext();
    Car car = new Car();
    MC mc = new MC();
    private DataSet dataSet;
    private SqlDataAdapter adapter;

    private BindingManagerBase binding;
    //string connstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PraugeParking;Integrated Security=True";

    public FormParkingLot()
    {
        InitializeComponent();
        populateParking();
    }
    private void btnCheckIn_Click(object sender, EventArgs e)//Fungerar inte ännu. Fler saker måste fixas som tex PickParkingSpot_Click
    {
        txtBoxLicenseNum.Text = string.Empty;
        string vehicleType = string.Empty;
        if (boxCheckCar.Checked)
        {
            vehicleType = "Car";
        }
        else if (boxCheckMc.Checked)
        {
            vehicleType = "Mc";
        }
        //string constr = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        string connstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PraugeParking;Integrated Security=True";
        using (SqlConnection con = new SqlConnection(connstring))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO PraugeParking(LicenseNum, VechicleType) VALUES( @LicenseNum,@VehicleType)"))
            {
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@LicensNum", txtBoxLicenseNum);
                cmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                con.Open();
                cmd.ExecuteNonQuery();//System.ArgumentException: 'No mapping exists from object type System.Windows.Forms.TextBox to a known managed provider native type.'

                con.Close();
            }
        }
        dataGridView1.ReadOnly = true;
        dataGridView1.DataSource = car;


        MessageBox.Show("Pick Parkingspot");

    }

    private void boxCheckCar_CheckedChanged(object sender, EventArgs e)//Vet ej om det fungerar så här
    {
        if (btnCheckIn.Enabled = boxCheckCar.Checked)
        {
            car = new Car();
        }
        btnCheckIn.Enabled = boxCheckCar.Checked;
    }

    private void boxCheckMc_CheckedChanged(object sender, EventArgs e)//Vet ej om det fungerar så här
    {
        if (btnCheckIn.Enabled = boxCheckMc.Checked)
        {
            mc = new MC();
        }
        btnCheckIn.Enabled = boxCheckMc.Checked;
    }
    private void PickParkingSpot_Click(object sender, EventArgs e)//För att få vilken av knapparna man tryckt på. Inte får till att valet sparas
    {
        Button clickedButton = (Button)sender;
        //Point location = (Point)clickedButton.Tag;
        string test = clickedButton.Tag.ToString();
        labelParkingSpot.Text = test.Substring(test.Count()-2,2);


        //MessageBox.Show("You clicked a button");
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
}
