using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class FormParkingLot : Form
    {
        public FormParkingLot()
        {
            InitializeComponent();
        }

        private void FormParkingLot_Load(object sender, EventArgs e)
        {
            var rowCount = 10;
            var columnCount = 10;

            viewParkingLot.ColumnCount = columnCount;
            viewParkingLot.RowCount = rowCount;

            viewParkingLot.ColumnStyles.Clear();
            viewParkingLot.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                viewParkingLot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                viewParkingLot.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var button = new Button();
                    button.Text = string.Format("{0}{1}", i, j);
                    button.Name = string.Format("{0}{1}", i, j);
                    button.Dock = DockStyle.Fill;
                    viewParkingLot.Controls.Add(button, j, i);
                }
            }
        }
    }
}
