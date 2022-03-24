using DataAccess;

namespace UI;

public partial class FormPrices : Form
{
    Config config = new Config();
    public FormPrices()
    {
        InitializeComponent();
        config.ReadFromJson();//Reads the json file
    }

    private void FormPrices_Load(object sender, EventArgs e)//Shows the current prices for parking
    {
        labelChargeCar.Text = config.CarFeePerHour.ToString();
        labelChargeMc.Text = config.McFeePerHour.ToString();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
