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
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.txtBoxDuration = new System.Windows.Forms.TextBox();
            this.txtBoxTotalCharge = new System.Windows.Forms.TextBox();
            this.parkingavailability = new System.Windows.Forms.Label();
            this.parkingFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelCount = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelOccupied = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.label000 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingFeeBindingSource)).BeginInit();
            this.panelCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.btnCheckIn.Location = new System.Drawing.Point(263, 240);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(137, 25);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "IN";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.btnCheckOut.Location = new System.Drawing.Point(261, 329);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(137, 26);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "OUT";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // pickTimeIn
            // 
            this.pickTimeIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pickTimeIn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeIn.Location = new System.Drawing.Point(275, 210);
            this.pickTimeIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickTimeIn.Name = "pickTimeIn";
            this.pickTimeIn.Size = new System.Drawing.Size(124, 29);
            this.pickTimeIn.TabIndex = 2;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblCheckIn.Location = new System.Drawing.Point(284, 187);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(77, 22);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblCheckOut.Location = new System.Drawing.Point(284, 276);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(90, 22);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check Out";
            // 
            // pickTimeOut
            // 
            this.pickTimeOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pickTimeOut.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeOut.Location = new System.Drawing.Point(275, 299);
            this.pickTimeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickTimeOut.Name = "pickTimeOut";
            this.pickTimeOut.Size = new System.Drawing.Size(124, 29);
            this.pickTimeOut.TabIndex = 5;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLicenseNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblLicenseNum.Location = new System.Drawing.Point(259, 14);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(164, 26);
            this.lblLicenseNum.TabIndex = 9;
            this.lblLicenseNum.Text = "License Number:";
            // 
            // txtBoxLicenseNum
            // 
            this.txtBoxLicenseNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxLicenseNum.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxLicenseNum.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxLicenseNum.Location = new System.Drawing.Point(259, 40);
            this.txtBoxLicenseNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxLicenseNum.Name = "txtBoxLicenseNum";
            this.txtBoxLicenseNum.Size = new System.Drawing.Size(162, 24);
            this.txtBoxLicenseNum.TabIndex = 1;
            // 
            // viewParkingLot
            // 
            this.viewParkingLot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewParkingLot.ColumnCount = 2;
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13193F));
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86807F));
            this.viewParkingLot.Location = new System.Drawing.Point(471, 14);
            this.viewParkingLot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewParkingLot.Name = "viewParkingLot";
            this.viewParkingLot.RowCount = 2;
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.Size = new System.Drawing.Size(758, 341);
            this.viewParkingLot.TabIndex = 13;
            // 
            // boxCheckCar
            // 
            this.boxCheckCar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxCheckCar.AutoSize = true;
            this.boxCheckCar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxCheckCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.boxCheckCar.Location = new System.Drawing.Point(263, 70);
            this.boxCheckCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCheckCar.Name = "boxCheckCar";
            this.boxCheckCar.Size = new System.Drawing.Size(62, 30);
            this.boxCheckCar.TabIndex = 14;
            this.boxCheckCar.TabStop = true;
            this.boxCheckCar.Text = "Car";
            this.boxCheckCar.UseVisualStyleBackColor = true;
            this.boxCheckCar.CheckedChanged += new System.EventHandler(this.boxCheckCar_CheckedChanged);
            // 
            // boxCheckMc
            // 
            this.boxCheckMc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxCheckMc.AutoSize = true;
            this.boxCheckMc.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxCheckMc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.boxCheckMc.Location = new System.Drawing.Point(327, 70);
            this.boxCheckMc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCheckMc.Name = "boxCheckMc";
            this.boxCheckMc.Size = new System.Drawing.Size(57, 30);
            this.boxCheckMc.TabIndex = 15;
            this.boxCheckMc.TabStop = true;
            this.boxCheckMc.Text = "Mc";
            this.boxCheckMc.UseVisualStyleBackColor = true;
            this.boxCheckMc.CheckedChanged += new System.EventHandler(this.boxCheckMc_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.dataGridView1.Location = new System.Drawing.Point(550, 370);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(606, 193);
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
            this.labelParkingSpot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelParkingSpot.AutoSize = true;
            this.labelParkingSpot.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelParkingSpot.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelParkingSpot.Location = new System.Drawing.Point(259, 106);
            this.labelParkingSpot.Name = "labelParkingSpot";
            this.labelParkingSpot.Size = new System.Drawing.Size(0, 26);
            this.labelParkingSpot.TabIndex = 17;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblDuration.Location = new System.Drawing.Point(279, 375);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(99, 26);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "Duration:";
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblTotalCharge.Location = new System.Drawing.Point(277, 448);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(134, 26);
            this.lblTotalCharge.TabIndex = 19;
            this.lblTotalCharge.Text = "Total Charge:";
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxDuration.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxDuration.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtBoxDuration.Location = new System.Drawing.Point(277, 400);
            this.txtBoxDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDuration.Multiline = true;
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.Size = new System.Drawing.Size(121, 25);
            this.txtBoxDuration.TabIndex = 20;
            // 
            // txtBoxTotalCharge
            // 
            this.txtBoxTotalCharge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxTotalCharge.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxTotalCharge.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTotalCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtBoxTotalCharge.Location = new System.Drawing.Point(279, 474);
            this.txtBoxTotalCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTotalCharge.Multiline = true;
            this.txtBoxTotalCharge.Name = "txtBoxTotalCharge";
            this.txtBoxTotalCharge.Size = new System.Drawing.Size(120, 24);
            this.txtBoxTotalCharge.TabIndex = 21;
            // 
            // parkingavailability
            // 
            this.parkingavailability.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.parkingavailability.AutoSize = true;
            this.parkingavailability.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parkingavailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.parkingavailability.Location = new System.Drawing.Point(63, 145);
            this.parkingavailability.Name = "parkingavailability";
            this.parkingavailability.Size = new System.Drawing.Size(0, 19);
            this.parkingavailability.TabIndex = 22;
            // 
            // parkingFeeBindingSource
            // 
            this.parkingFeeBindingSource.DataSource = typeof(ParkingGarageLibrary.ParkingFee);
            // 
            // panelCount
            // 
            this.panelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.panelCount.Controls.Add(this.btnExit);
            this.panelCount.Controls.Add(this.labelOccupied);
            this.panelCount.Controls.Add(this.label100);
            this.panelCount.Controls.Add(this.labelAvailable);
            this.panelCount.Controls.Add(this.label000);
            this.panelCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCount.Location = new System.Drawing.Point(0, 0);
            this.panelCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCount.Name = "panelCount";
            this.panelCount.Size = new System.Drawing.Size(184, 569);
            this.panelCount.TabIndex = 25;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(0, 504);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(184, 65);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // labelOccupied
            // 
            this.labelOccupied.AutoSize = true;
            this.labelOccupied.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOccupied.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelOccupied.Location = new System.Drawing.Point(28, 30);
            this.labelOccupied.Name = "labelOccupied";
            this.labelOccupied.Size = new System.Drawing.Size(109, 29);
            this.labelOccupied.TabIndex = 10;
            this.labelOccupied.Text = "Occupied";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label100.ForeColor = System.Drawing.Color.Gainsboro;
            this.label100.Location = new System.Drawing.Point(59, 169);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(46, 29);
            this.label100.TabIndex = 9;
            this.label100.Text = "100";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvailable.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAvailable.Location = new System.Drawing.Point(28, 132);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(107, 29);
            this.labelAvailable.TabIndex = 8;
            this.labelAvailable.Text = "Available";
            // 
            // label000
            // 
            this.label000.AutoSize = true;
            this.label000.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label000.ForeColor = System.Drawing.Color.Gainsboro;
            this.label000.Location = new System.Drawing.Point(59, 66);
            this.label000.Name = "label000";
            this.label000.Size = new System.Drawing.Size(46, 29);
            this.label000.TabIndex = 7;
            this.label000.Text = "000";
            // 
            // FormParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1278, 569);
            this.Controls.Add(this.panelCount);
            this.Controls.Add(this.parkingavailability);
            this.Controls.Add(this.txtBoxTotalCharge);
            this.Controls.Add(this.txtBoxDuration);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblDuration);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormParkingLot";
            this.Text = "PARKING LOT";
            this.Load += new System.EventHandler(this.FormParkingLot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingFeeBindingSource)).EndInit();
            this.panelCount.ResumeLayout(false);
            this.panelCount.PerformLayout();
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
        private Label lblDuration;
        private Label lblTotalCharge;
        private TextBox txtBoxDuration;
        private TextBox txtBoxTotalCharge;
        private Label parkingavailability;
        private BindingSource parkingFeeBindingSource;
        private Panel panelCount;
        private Button btnExit;
        private Label labelOccupied;
        private Label label100;
        private Label labelAvailable;
        private Label label000;
    }
}