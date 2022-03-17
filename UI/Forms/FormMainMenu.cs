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
        //Occupation();
        InitializeComponent();

    }
    private void btnParkingLotView_Click(object sender, EventArgs e)
    {
        OpenChildForm(new Forms.FormParkingLot());

    }
    private void btnStoreData_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormSales());
        labelTitle.Text = activeForm.Text;
    }
    private void button5_Click(object sender, EventArgs e)
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
    public void Occupation()//Försök till att få till en counter från db
    {


        //var query = "SELECT Count(*) FROM ParkingGarage "; /*'" + labelOccupied.Text + "'*/

        //var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PraugeParking;Integrated Security=True");
        //connection.Open();

        //SqlDataAdapter da = new SqlDataAdapter("Select COUNT(*) From ParkingGarage", connection);
        //var dbData = new DataSet();
        //da.Fill(dbData);

        //labelOccupied.Text = dbData.ToString();
        //SqlCommand data = new SqlCommand(query, connection);
        //SqlDataReader reader;
        //reader = data.ExecuteReader();
        //while (reader.Read())
        //{
        //    labelOccupied.Text = reader.GetType().Name;
        //}


        //var commandBuilder = new SqlCommandBuilder(data);

        //var dbData = new DataSet();
        //data.Fill(dbData);
        //labelOccupied.Text = dbData.ToString();



    }

    //private void FormMainMenu_Load_1(object sender, EventArgs e)//Ingen bra idé att ha igång när en ett fel uppstår, kommenterar ut så länge
    //{
    //    TopMost = true;
    //    FormBorderStyle = FormBorderStyle.None;
    //    WindowState = FormWindowState.Maximized;
    //}


    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

}

