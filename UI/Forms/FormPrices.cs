using DataAccess;

namespace UI;

public partial class FormPrices : Form
{
    Config config = new Config();
    public FormPrices()
    {
        InitializeComponent();
        config.ReadFromJson();
    }

    private void FormPrices_Load(object sender, EventArgs e)
    {
        labelChargeCar.Text = config.CarFeePerHour.ToString();
        labelChargeMc.Text = config.McFeePerHour.ToString();
    }

    

    private void btnExit_Click_1(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
