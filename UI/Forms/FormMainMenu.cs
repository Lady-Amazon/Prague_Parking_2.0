using DataAccess;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;


namespace UI;

public partial class FormMainMenu : Form
{
    private Form activeForm;
    ParkingContext parkingContext = new ParkingContext();
    int occupied = 0;
    int available = 100;
    

    public FormMainMenu()
    {
        parkingContext.Database.EnsureCreated();
        //Occupation();
        InitializeComponent();

    }
    private void btnParkingLotView_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.FormParkingLot());

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
    public void Occupation()//Fungerar inte
    {

        /// Increment number of occupied slots while decrementing the numerber of available slots
        available = available - 1;
        occupied = occupied + 1;

        /// Write data to the label with the format "000"
        labelAvailable.Text = available.ToString("D3");
        labelOccupied.Text = occupied.ToString("D3");

    }


    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

    //private void FormMainMenu_Load(object sender, EventArgs e)
    //{
    //    TopMost = true;
    //    FormBorderStyle = FormBorderStyle.None;
    //    WindowState = FormWindowState.Maximized;
    //}
}

