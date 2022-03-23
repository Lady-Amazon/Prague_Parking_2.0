using DataAccess;
using UI.Forms;
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
        string CarFeePerHour = txtChangeFeeCar.Text;
        string McFeePerHour = txtChangeFeeMc.Text;
        string parkingLotSize = txtChangeLotSize.Text;
        ParkinglotSize(int.Parse(parkingLotSize));
        config.UpdateJson(CarFeePerHour, McFeePerHour, parkingLotSize);
        MessageBox.Show("New configuration is set! Everything is saved");

    }

    void ParkinglotSize(int parkingSize)
    {
        config.ReadFromJson();

        using (var context = new ParkingContext())
        {
            parkingSize = config.ParkingLotSize; //ReadsFomJson
        }

    }


    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
