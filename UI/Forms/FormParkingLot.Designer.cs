﻿namespace UI.Forms
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGarageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckIn.Location = new System.Drawing.Point(14, 304);
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
            this.btnCheckOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckOut.Location = new System.Drawing.Point(14, 410);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(157, 35);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "OUT";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // pickTimeIn
            // 
            this.pickTimeIn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeIn.Location = new System.Drawing.Point(33, 271);
            this.pickTimeIn.Name = "pickTimeIn";
            this.pickTimeIn.Size = new System.Drawing.Size(121, 28);
            this.pickTimeIn.TabIndex = 2;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCheckIn.Location = new System.Drawing.Point(33, 244);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(87, 24);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCheckOut.Location = new System.Drawing.Point(32, 350);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(102, 24);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check Out";
            // 
            // pickTimeOut
            // 
            this.pickTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickTimeOut.Location = new System.Drawing.Point(34, 377);
            this.pickTimeOut.Name = "pickTimeOut";
            this.pickTimeOut.Size = new System.Drawing.Size(120, 27);
            this.pickTimeOut.TabIndex = 5;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLicenseNum.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLicenseNum.Location = new System.Drawing.Point(33, 29);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(139, 23);
            this.lblLicenseNum.TabIndex = 9;
            this.lblLicenseNum.Text = "License Number:";
            // 
            // txtBoxLicenseNum
            // 
            this.txtBoxLicenseNum.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxLicenseNum.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxLicenseNum.Location = new System.Drawing.Point(33, 66);
            this.txtBoxLicenseNum.Name = "txtBoxLicenseNum";
            this.txtBoxLicenseNum.Size = new System.Drawing.Size(144, 28);
            this.txtBoxLicenseNum.TabIndex = 10;
            // 
            // viewParkingLot
            // 
            this.viewParkingLot.ColumnCount = 2;
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.Location = new System.Drawing.Point(229, 29);
            this.viewParkingLot.Name = "viewParkingLot";
            this.viewParkingLot.RowCount = 2;
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.Size = new System.Drawing.Size(623, 402);
            this.viewParkingLot.TabIndex = 13;
            // 
            // boxCheckCar
            // 
            this.boxCheckCar.AutoSize = true;
            this.boxCheckCar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxCheckCar.ForeColor = System.Drawing.Color.Gainsboro;
            this.boxCheckCar.Location = new System.Drawing.Point(38, 106);
            this.boxCheckCar.Name = "boxCheckCar";
            this.boxCheckCar.Size = new System.Drawing.Size(65, 31);
            this.boxCheckCar.TabIndex = 14;
            this.boxCheckCar.TabStop = true;
            this.boxCheckCar.Text = "Car";
            this.boxCheckCar.UseVisualStyleBackColor = true;
            this.boxCheckCar.CheckedChanged += new System.EventHandler(this.boxCheckCar_CheckedChanged);
            // 
            // boxCheckMc
            // 
            this.boxCheckMc.AutoSize = true;
            this.boxCheckMc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxCheckMc.ForeColor = System.Drawing.Color.Gainsboro;
            this.boxCheckMc.Location = new System.Drawing.Point(38, 136);
            this.boxCheckMc.Name = "boxCheckMc";
            this.boxCheckMc.Size = new System.Drawing.Size(67, 31);
            this.boxCheckMc.TabIndex = 15;
            this.boxCheckMc.TabStop = true;
            this.boxCheckMc.Text = "MC";
            this.boxCheckMc.UseVisualStyleBackColor = true;
            this.boxCheckMc.CheckedChanged += new System.EventHandler(this.boxCheckMc_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(680, 161);
            this.dataGridView1.TabIndex = 16;
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingSpotDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseNumDataGridViewTextBoxColumn
            // 
            this.licenseNumDataGridViewTextBoxColumn.DataPropertyName = "LicenseNum";
            this.licenseNumDataGridViewTextBoxColumn.HeaderText = "LicenseNum";
            this.licenseNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseNumDataGridViewTextBoxColumn.Name = "licenseNumDataGridViewTextBoxColumn";
            this.licenseNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkedInDataGridViewTextBoxColumn
            // 
            this.checkedInDataGridViewTextBoxColumn.DataPropertyName = "CheckedIn";
            this.checkedInDataGridViewTextBoxColumn.HeaderText = "CheckedIn";
            this.checkedInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkedInDataGridViewTextBoxColumn.Name = "checkedInDataGridViewTextBoxColumn";
            this.checkedInDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkedInDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkedOutDataGridViewTextBoxColumn
            // 
            this.checkedOutDataGridViewTextBoxColumn.DataPropertyName = "CheckedOut";
            this.checkedOutDataGridViewTextBoxColumn.HeaderText = "CheckedOut";
            this.checkedOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkedOutDataGridViewTextBoxColumn.Name = "checkedOutDataGridViewTextBoxColumn";
            this.checkedOutDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.labelParkingSpot.Location = new System.Drawing.Point(34, 194);
            this.labelParkingSpot.Name = "labelParkingSpot";
            this.labelParkingSpot.Size = new System.Drawing.Size(0, 31);
            this.labelParkingSpot.TabIndex = 17;
            // 
            // FormParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(125)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(989, 699);
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
    }
}