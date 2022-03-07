using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()//Log In before Main screen. Username = Admin, Password = 1234
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "Admin" && textBoxPassword.Text == "1234")
            {
                new FormMainMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
                textBoxUserName.Clear();
                textBoxPassword.Clear();
                textBoxUserName.Focus();
            }
        }

        private void btnExitLogIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
