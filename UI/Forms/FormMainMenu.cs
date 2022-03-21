using DataAccess;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;
using UI.Methods;

namespace UI;

public partial class FormMainMenu : Form
{
    private Form activeForm;
    ParkingContext parkingContext = new ParkingContext();
    SpotCalculation calc = new SpotCalculation();
    public FormMainMenu()
    {
        parkingContext.Database.EnsureCreated();
        InitializeComponent();
        calc.OccupationCalc(label000, label100);
    }
    private void btnParkingLotView_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.FormParkingLot());
        calc.OccupationCalc(label000, label100);
    }
    private void btnPrices_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormPrices());
        labelTitle.Text = activeForm.Text;
    }
    private void btnSettings_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormSettings());
        labelTitle.Text = activeForm.Text;
        MessageBox.Show("Be aware of making changes!!!!");
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void OpenChildForm(Form childForm)//Open other forms in panel(not shifting to other winows)
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }
        activeForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        labelTitle.Text = childForm.Text;
    }

    private void labelExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void labelMinimize_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void labelMaximize_Click(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Normal)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        else
        {
            this.WindowState = FormWindowState.Normal;
        }

    }

    private void panelMenu_MouseMove(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }


    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    private void btnExit_Click_1(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void FormMainMenu_Load(object sender, EventArgs e)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build()
            .Get<Config>();

        label100.Text = config.ParkingLotSize.ToString();

        //TopMost = true;
        //FormBorderStyle = FormBorderStyle.None;
        //WindowState = FormWindowState.Maximized;
    }
}

