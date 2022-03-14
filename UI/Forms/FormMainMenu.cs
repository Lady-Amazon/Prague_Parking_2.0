using DataAccess;
using System.Runtime.InteropServices;


namespace UI;

public partial class FormMainMenu : Form
{
    private Form activeForm;
    ParkingContext parkingContext = new ParkingContext();

    public FormMainMenu()
    {
        parkingContext.Database.EnsureCreated();
        InitializeComponent();
    }
    private void btnParkingLotView_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.FormParkingLot());

    }
    private void btnSales_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormSales());
        labelTitle.Text = activeForm.Text;
    }
    private void btnSettings_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.FormSettings());
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
        if (WindowState == FormWindowState.Normal)
        {
            WindowState = FormWindowState.Maximized;
        }
        else
        {
            WindowState = FormWindowState.Normal;
        }

    }

    private void panelMenu_MouseMove(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }
    //private void FormMainMenu_Load(object sender, EventArgs e)//Ingen bra idé att ha igång när en ett fel uppstår, kommenterar ut så länge
    //{
    //    TopMost = true;
    //    FormBorderStyle = FormBorderStyle.None;
    //    WindowState = FormWindowState.Maximized;
    //}
    public void Values(string available, string occupied)//Fungerar inte än. Är till för att kunna se hur många bilar som står parkerade. Information från FomrParkinglot ska över hit
    {
        lblCountAvailable.Text = available.ToString();
        lblCountOccupied.Text = occupied.ToString();
    }

    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


}

