namespace UI.Forms
{
    partial class FormParkingLot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pickTimeIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.pickTimeOut = new System.Windows.Forms.DateTimePicker();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.txtBoxLicenseNum = new System.Windows.Forms.TextBox();
            this.viewParkingLot = new System.Windows.Forms.TableLayoutPanel();
            this.boxCheckCar = new System.Windows.Forms.RadioButton();
            this.boxCheckMc = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingGarageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelParkingSpot = new System.Windows.Forms.Label();
            this.txtBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelTotalCharge = new System.Windows.Forms.Label();
            this.txtBoxTotalCharge = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckIn.Location = new System.Drawing.Point(1, 298);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(157, 33);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "IN";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckOut.Location = new System.Drawing.Point(1, 409);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(157, 35);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "OUT";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // pickTimeIn
            // 
            this.pickTimeIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pickTimeIn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeIn.Location = new System.Drawing.Point(14, 264);
            this.pickTimeIn.Name = "pickTimeIn";
            this.pickTimeIn.Size = new System.Drawing.Size(121, 28);
            this.pickTimeIn.TabIndex = 2;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCheckIn.Location = new System.Drawing.Point(14, 237);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(87, 24);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCheckOut.Location = new System.Drawing.Point(14, 349);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(102, 24);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check Out";
            // 
            // pickTimeOut
            // 
            this.pickTimeOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pickTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeOut.Location = new System.Drawing.Point(16, 376);
            this.pickTimeOut.Name = "pickTimeOut";
            this.pickTimeOut.Size = new System.Drawing.Size(120, 27);
            this.pickTimeOut.TabIndex = 5;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLicenseNum.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLicenseNum.Location = new System.Drawing.Point(12, 29);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(194, 31);
            this.lblLicenseNum.TabIndex = 9;
            this.lblLicenseNum.Text = "License Number:";
            // 
            // txtBoxLicenseNum
            // 
            this.txtBoxLicenseNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxLicenseNum.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxLicenseNum.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxLicenseNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtBoxLicenseNum.Location = new System.Drawing.Point(14, 63);
            this.txtBoxLicenseNum.Name = "txtBoxLicenseNum";
            this.txtBoxLicenseNum.Size = new System.Drawing.Size(144, 28);
            this.txtBoxLicenseNum.TabIndex = 10;
            // 
            // viewParkingLot
            // 
            this.viewParkingLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewParkingLot.ColumnCount = 2;
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.Location = new System.Drawing.Point(220, 12);
            this.viewParkingLot.Name = "viewParkingLot";
            this.viewParkingLot.RowCount = 2;
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.Size = new System.Drawing.Size(975, 526);
            this.viewParkingLot.TabIndex = 13;
            // 
            // boxCheckCar
            // 
            this.boxCheckCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxCheckCar.AutoSize = true;
            this.boxCheckCar.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxCheckCar.ForeColor = System.Drawing.Color.Gainsboro;
            this.boxCheckCar.Location = new System.Drawing.Point(14, 108);
            this.boxCheckCar.Name = "boxCheckCar";
            this.boxCheckCar.Size = new System.Drawing.Size(83, 42);
            this.boxCheckCar.TabIndex = 14;
            this.boxCheckCar.TabStop = true;
            this.boxCheckCar.Text = "Car";
            this.boxCheckCar.UseVisualStyleBackColor = true;
            this.boxCheckCar.CheckedChanged += new System.EventHandler(this.boxCheckCar_CheckedChanged);
            // 
            // boxCheckMc
            // 
            this.boxCheckMc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxCheckMc.AutoSize = true;
            this.boxCheckMc.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxCheckMc.ForeColor = System.Drawing.Color.Gainsboro;
            this.boxCheckMc.Location = new System.Drawing.Point(14, 138);
            this.boxCheckMc.Name = "boxCheckMc";
            this.boxCheckMc.Size = new System.Drawing.Size(86, 42);
            this.boxCheckMc.TabIndex = 15;
            this.boxCheckMc.TabStop = true;
            this.boxCheckMc.Text = "MC";
            this.boxCheckMc.UseVisualStyleBackColor = true;
            this.boxCheckMc.CheckedChanged += new System.EventHandler(this.boxCheckMc_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.licenseNumDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.checkedInDataGridViewTextBoxColumn,
            this.checkedOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkingGarageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(220, 554);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(714, 311);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseNumDataGridViewTextBoxColumn
            // 
            this.licenseNumDataGridViewTextBoxColumn.DataPropertyName = "LicenseNum";
            this.licenseNumDataGridViewTextBoxColumn.HeaderText = "LicenseNum";
            this.licenseNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseNumDataGridViewTextBoxColumn.Name = "licenseNumDataGridViewTextBoxColumn";
            this.licenseNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkedInDataGridViewTextBoxColumn
            // 
            this.checkedInDataGridViewTextBoxColumn.DataPropertyName = "CheckedIn";
            this.checkedInDataGridViewTextBoxColumn.HeaderText = "CheckedIn";
            this.checkedInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkedInDataGridViewTextBoxColumn.Name = "checkedInDataGridViewTextBoxColumn";
            this.checkedInDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkedOutDataGridViewTextBoxColumn
            // 
            this.checkedOutDataGridViewTextBoxColumn.DataPropertyName = "CheckedOut";
            this.checkedOutDataGridViewTextBoxColumn.HeaderText = "CheckedOut";
            this.checkedOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkedOutDataGridViewTextBoxColumn.Name = "checkedOutDataGridViewTextBoxColumn";
            this.checkedOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingGarageBindingSource
            // 
            this.parkingGarageBindingSource.DataSource = typeof(ParkingGarageLibrary.ParkingGarage);
            // 
            // parkingContextBindingSource
            // 
            this.parkingContextBindingSource.DataSource = typeof(DataAccess.ParkingContext);
            // 
            // labelParkingSpot
            // 
            this.labelParkingSpot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelParkingSpot.AutoSize = true;
            this.labelParkingSpot.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelParkingSpot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.labelParkingSpot.Location = new System.Drawing.Point(14, 183);
            this.labelParkingSpot.Name = "labelParkingSpot";
            this.labelParkingSpot.Size = new System.Drawing.Size(0, 41);
            this.labelParkingSpot.TabIndex = 17;
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDuration.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxDuration.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtBoxDuration.Location = new System.Drawing.Point(16, 511);
            this.txtBoxDuration.Multiline = true;
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.Size = new System.Drawing.Size(142, 32);
            this.txtBoxDuration.TabIndex = 18;
            // 
            // labelDuration
            // 
            this.labelDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDuration.Location = new System.Drawing.Point(14, 477);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(110, 31);
            this.labelDuration.TabIndex = 19;
            this.labelDuration.Text = "Duration";
            // 
            // labelTotalCharge
            // 
            this.labelTotalCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalCharge.AutoSize = true;
            this.labelTotalCharge.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalCharge.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotalCharge.Location = new System.Drawing.Point(14, 567);
            this.labelTotalCharge.Name = "labelTotalCharge";
            this.labelTotalCharge.Size = new System.Drawing.Size(152, 31);
            this.labelTotalCharge.TabIndex = 20;
            this.labelTotalCharge.Text = "Total Charge";
            // 
            // txtBoxTotalCharge
            // 
            this.txtBoxTotalCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxTotalCharge.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxTotalCharge.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTotalCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtBoxTotalCharge.Location = new System.Drawing.Point(16, 601);
            this.txtBoxTotalCharge.Multiline = true;
            this.txtBoxTotalCharge.Name = "txtBoxTotalCharge";
            this.txtBoxTotalCharge.Size = new System.Drawing.Size(142, 34);
            this.txtBoxTotalCharge.TabIndex = 21;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // FormParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(125)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1227, 877);
            this.Controls.Add(this.txtBoxTotalCharge);
            this.Controls.Add(this.labelTotalCharge);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.txtBoxDuration);
            this.Controls.Add(this.labelParkingSpot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boxCheckMc);
            this.Controls.Add(this.boxCheckCar);
            this.Controls.Add(this.viewParkingLot);
            this.Controls.Add(this.txtBoxLicenseNum);
            this.Controls.Add(this.lblLicenseNum);
            this.Controls.Add(this.pickTimeOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.pickTimeIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormParkingLot";
            this.Text = "Parking Lot";
            this.Load += new System.EventHandler(this.FormParkingLot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingContextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCheckIn;
        private Button btnCheckOut;
        private DateTimePicker pickTimeIn;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private DateTimePicker pickTimeOut;
        private Label lblLicenseNum;
        private TextBox txtBoxLicenseNum;
        private TableLayoutPanel viewParkingLot;
        private RadioButton boxCheckCar;
        private RadioButton boxCheckMc;
        private DataGridView dataGridView1;
        private BindingSource parkingContextBindingSource;
        private DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licenseNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkedInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkedOutDataGridViewTextBoxColumn;
        private BindingSource parkingGarageBindingSource;
        private Label labelParkingSpot;
        private TextBox txtBoxDuration;
        private Label labelDuration;
        private Label labelTotalCharge;
        private TextBox txtBoxTotalCharge;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}