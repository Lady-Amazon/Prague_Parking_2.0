using DataAccess;
using Microsoft.EntityFrameworkCore;
using Excel = Microsoft.Office.Interop.Excel;


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
        OpenChildForm(new Forms.FormParkingLot(), sender);
    }
    private void btnStoreData_Click(object sender, EventArgs e)
    {
      // OpenChildForm((Forms.FormStoreData)sender);  
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    private void OpenChildForm(Form childForm, object btnSender)//Open other forms in panel(not shifting to other winows)
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
        WindowState= FormWindowState.Minimized;
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
}

