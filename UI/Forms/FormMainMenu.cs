using DataAccess;
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
        InitializeComponent();
        parkingContext.Database.EnsureCreated();
        calc.OccupationCalc(label000, label100);
        bool dbEmpty = ValidateData.IsDbEmpty();//Puts testdata in the db 
        if (dbEmpty)
        {
            TestData.PopulateDb();
        }
    }
    private void btnParkingLotView_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.FormParkingLot());
        panelCount.Visible = false;
    }
    private void btnPrices_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormPrices());
        labelTitle.Text = activeForm.Text;
        panelCount.Visible = false;
    }
    private void btnSettings_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormSettings());
        labelTitle.Text = activeForm.Text;
        panelCount.Visible = false;
        MessageBox.Show("Be aware of making changes!!!!");
    }
    private void btnAbout_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.FormAbout());
        labelTitle.Text=activeForm.Text;
        panelCount.Visible = true;
    }
    private void btnHome_Click(object sender, EventArgs e)
    {
        activeForm.Close();
        panelCount.Visible = true;
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
    }//To let you move the window with the mouse


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
        //TopMost = true;                 //To open application in fullscreen
        //FormBorderStyle = FormBorderStyle.None;
        //WindowState = FormWindowState.Maximized;
    }

   
}

