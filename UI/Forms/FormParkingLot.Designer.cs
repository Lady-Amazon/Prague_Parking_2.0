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
            this.panelCountSpots = new System.Windows.Forms.Panel();
            this.btnHowTo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelOccupied = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.label000 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingContextBindingSource)).BeginInit();
            this.panelCountSpots.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.btnCheckIn.Location = new System.Drawing.Point(217, 343);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(157, 33);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "IN";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.btnCheckOut.Location = new System.Drawing.Point(217, 474);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(157, 35);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "OUT";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // pickTimeIn
            // 
            this.pickTimeIn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeIn.Location = new System.Drawing.Point(230, 303);
            this.pickTimeIn.Name = "pickTimeIn";
            this.pickTimeIn.Size = new System.Drawing.Size(141, 34);
            this.pickTimeIn.TabIndex = 2;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblCheckIn.Location = new System.Drawing.Point(240, 273);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(94, 27);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblCheckOut.Location = new System.Drawing.Point(240, 392);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(110, 27);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check Out";
            // 
            // pickTimeOut
            // 
            this.pickTimeOut.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeOut.Location = new System.Drawing.Point(230, 422);
            this.pickTimeOut.Name = "pickTimeOut";
            this.pickTimeOut.Size = new System.Drawing.Size(141, 34);
            this.pickTimeOut.TabIndex = 5;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLicenseNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblLicenseNum.Location = new System.Drawing.Point(217, 27);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(194, 31);
            this.lblLicenseNum.TabIndex = 9;
            this.lblLicenseNum.Text = "License Number:";
            // 
            // txtBoxLicenseNum
            // 
            this.txtBoxLicenseNum.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxLicenseNum.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxLicenseNum.Location = new System.Drawing.Point(217, 61);
            this.txtBoxLicenseNum.Name = "txtBoxLicenseNum";
            this.txtBoxLicenseNum.Size = new System.Drawing.Size(184, 28);
            this.txtBoxLicenseNum.TabIndex = 1;
            // 
            // viewParkingLot
            // 
            this.viewParkingLot.ColumnCount = 2;
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.viewParkingLot.Location = new System.Drawing.Point(434, 27);
            this.viewParkingLot.Name = "viewParkingLot";
            this.viewParkingLot.RowCount = 2;
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.Size = new System.Drawing.Size(1270, 568);
            this.viewParkingLot.TabIndex = 13;
            // 
            // boxCheckCar
            // 
            this.boxCheckCar.AutoSize = true;
            this.boxCheckCar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxCheckCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.boxCheckCar.Location = new System.Drawing.Point(222, 113);
            this.boxCheckCar.Name = "boxCheckCar";
            this.boxCheckCar.Size = new System.Drawing.Size(73, 35);
            this.boxCheckCar.TabIndex = 14;
            this.boxCheckCar.TabStop = true;
            this.boxCheckCar.Text = "Car";
            this.boxCheckCar.UseVisualStyleBackColor = true;
            this.boxCheckCar.CheckedChanged += new System.EventHandler(this.boxCheckCar_CheckedChanged);
            // 
            // boxCheckMc
            // 
            this.boxCheckMc.AutoSize = true;
            this.boxCheckMc.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxCheckMc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.boxCheckMc.Location = new System.Drawing.Point(324, 113);
            this.boxCheckMc.Name = "boxCheckMc";
            this.boxCheckMc.Size = new System.Drawing.Size(68, 35);
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
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.dataGridView1.Location = new System.Drawing.Point(452, 621);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(682, 182);
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
            this.labelParkingSpot.AutoSize = true;
            this.labelParkingSpot.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelParkingSpot.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelParkingSpot.Location = new System.Drawing.Point(222, 183);
            this.labelParkingSpot.Name = "labelParkingSpot";
            this.labelParkingSpot.Size = new System.Drawing.Size(0, 31);
            this.labelParkingSpot.TabIndex = 17;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblDuration.Location = new System.Drawing.Point(240, 545);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(116, 31);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "Duration:";
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblTotalCharge.Location = new System.Drawing.Point(234, 646);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(158, 31);
            this.lblTotalCharge.TabIndex = 19;
            this.lblTotalCharge.Text = "Total Charge:";
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxDuration.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtBoxDuration.Location = new System.Drawing.Point(234, 579);
            this.txtBoxDuration.Multiline = true;
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.Size = new System.Drawing.Size(140, 45);
            this.txtBoxDuration.TabIndex = 20;
            // 
            // txtBoxTotalCharge
            // 
            this.txtBoxTotalCharge.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxTotalCharge.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTotalCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtBoxTotalCharge.Location = new System.Drawing.Point(234, 680);
            this.txtBoxTotalCharge.Multiline = true;
            this.txtBoxTotalCharge.Name = "txtBoxTotalCharge";
            this.txtBoxTotalCharge.Size = new System.Drawing.Size(140, 45);
            this.txtBoxTotalCharge.TabIndex = 21;
            // 
            // parkingavailability
            // 
            this.parkingavailability.AutoSize = true;
            this.parkingavailability.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parkingavailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.parkingavailability.Location = new System.Drawing.Point(222, 235);
            this.parkingavailability.Name = "parkingavailability";
            this.parkingavailability.Size = new System.Drawing.Size(0, 23);
            this.parkingavailability.TabIndex = 22;
            // 
            // panelCountSpots
            // 
            this.panelCountSpots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.panelCountSpots.Controls.Add(this.btnHowTo);
            this.panelCountSpots.Controls.Add(this.btnExit);
            this.panelCountSpots.Controls.Add(this.labelOccupied);
            this.panelCountSpots.Controls.Add(this.label100);
            this.panelCountSpots.Controls.Add(this.labelAvailable);
            this.panelCountSpots.Controls.Add(this.label000);
            this.panelCountSpots.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCountSpots.Location = new System.Drawing.Point(0, 0);
            this.panelCountSpots.Name = "panelCountSpots";
            this.panelCountSpots.Size = new System.Drawing.Size(210, 815);
            this.panelCountSpots.TabIndex = 25;
            // 
            // btnHowTo
            // 
            this.btnHowTo.FlatAppearance.BorderSize = 0;
            this.btnHowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowTo.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHowTo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHowTo.Location = new System.Drawing.Point(0, 403);
            this.btnHowTo.Name = "btnHowTo";
            this.btnHowTo.Size = new System.Drawing.Size(207, 81);
            this.btnHowTo.TabIndex = 12;
            this.btnHowTo.Text = "How To";
            this.btnHowTo.UseVisualStyleBackColor = true;
            this.btnHowTo.Click += new System.EventHandler(this.btnHowTo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(0, 728);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(210, 87);
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
            this.labelOccupied.Location = new System.Drawing.Point(32, 40);
            this.labelOccupied.Name = "labelOccupied";
            this.labelOccupied.Size = new System.Drawing.Size(138, 38);
            this.labelOccupied.TabIndex = 10;
            this.labelOccupied.Text = "Occupied";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label100.ForeColor = System.Drawing.Color.Gainsboro;
            this.label100.Location = new System.Drawing.Point(67, 225);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(59, 38);
            this.label100.TabIndex = 9;
            this.label100.Text = "100";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvailable.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAvailable.Location = new System.Drawing.Point(32, 176);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(138, 38);
            this.labelAvailable.TabIndex = 8;
            this.labelAvailable.Text = "Available";
            // 
            // label000
            // 
            this.label000.AutoSize = true;
            this.label000.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label000.ForeColor = System.Drawing.Color.Gainsboro;
            this.label000.Location = new System.Drawing.Point(67, 88);
            this.label000.Name = "label000";
            this.label000.Size = new System.Drawing.Size(59, 38);
            this.label000.TabIndex = 7;
            this.label000.Text = "000";
            // 
            // FormParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1716, 815);
            this.Controls.Add(this.panelCountSpots);
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
            this.Name = "FormParkingLot";
            this.Text = "PARKING LOT";
            this.Load += new System.EventHandler(this.FormParkingLot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingContextBindingSource)).EndInit();
            this.panelCountSpots.ResumeLayout(false);
            this.panelCountSpots.PerformLayout();
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
        private Panel panelCountSpots;
        private Button btnExit;
        private Label labelOccupied;
        private Label label100;
        private Label labelAvailable;
        private Label label000;
        private Button btnHowTo;
    }
}