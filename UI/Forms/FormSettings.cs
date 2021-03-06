using DataAccess;

namespace UI;

public partial class FormSettings : Form
{
    Config config = new Config();
    public FormSettings()
    {
        InitializeComponent();
    }
    private void btnSavesetting_Click(object sender, EventArgs e)
    {
        //To let the user change the current fee and amount och available parkingspots. 
        string CarFeePerHour = txtChangeFeeCar.Text;
        string McFeePerHour = txtChangeFeeMc.Text;
        string parkingLotSize = txtChangeLotSize.Text;

        ParkingLotSize(int.Parse(parkingLotSize));

        config.UpdateJson(CarFeePerHour, McFeePerHour, parkingLotSize);
        MessageBox.Show("New configuration is set! Everything is saved");

    }
    void ParkingLotSize(int parkingSize)//To change amount of parkingspots that are display in parkinglotview
    {
        config.ReadFromJson();

        using (var parkingContext = new ParkingContext())
        {
            parkingSize = config.ParkingLotSize;
        }
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
