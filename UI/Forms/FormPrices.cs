namespace UI;

public partial class FormPrices : Form
{
    public FormPrices()
    {
        InitializeComponent();
    }

    private void FormPrices_Load(object sender, EventArgs e)
    {
        labelChargeCar.Text = "appsettings.json";
        labelChargeMc.Text = "appsettings.json";
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
