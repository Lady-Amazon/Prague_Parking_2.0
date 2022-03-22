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
        string CarFeePerHour = txtChangeFeeCar.Text;
        string McFeePerHour = txtChangeFeeMc.Text;
        string ParkingLotSize = txtChangeLotSize.Text;

        config.UpdateJson(CarFeePerHour, McFeePerHour, ParkingLotSize);
        MessageBox.Show("New configuration is set! Everything is saved");

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
