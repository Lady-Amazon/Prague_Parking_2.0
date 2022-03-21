using DataAccess;
using Microsoft.Extensions.Configuration;

namespace UI;

public partial class FormPrices : Form
{
    public FormPrices()
    {
        InitializeComponent();
    }

    private void FormPrices_Load(object sender, EventArgs e)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build()
            .Get<Config>();

        labelChargeCar.Text = config.CarFeePerHour.ToString();
        labelChargeMc.Text = config.McFeePerHour.ToString();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
