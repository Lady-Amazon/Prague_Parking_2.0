namespace UI
{
    public partial class FormMainMenu : Form
    {
        private Form activeForm;
        private Button currentButton;
        public FormMainMenu()
        {
            InitializeComponent();
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
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormParkingLot(), sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}