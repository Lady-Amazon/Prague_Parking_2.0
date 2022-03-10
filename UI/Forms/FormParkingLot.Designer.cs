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
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.timeIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.timeOut = new System.Windows.Forms.DateTimePicker();
            this.checkMc = new System.Windows.Forms.CheckBox();
            this.checkCar = new System.Windows.Forms.CheckBox();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.txtBoxLicenseNum = new System.Windows.Forms.TextBox();
            this.listParkedVehicles = new System.Windows.Forms.ListView();
            this.viewParkingLot = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckIn.Location = new System.Drawing.Point(14, 249);
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
            this.btnCheckOut.Location = new System.Drawing.Point(14, 355);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(157, 35);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "OUT";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // timeIn
            // 
            this.timeIn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeIn.Location = new System.Drawing.Point(33, 216);
            this.timeIn.Name = "timeIn";
            this.timeIn.Size = new System.Drawing.Size(121, 28);
            this.timeIn.TabIndex = 2;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCheckIn.Location = new System.Drawing.Point(33, 189);
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
            this.lblCheckOut.Location = new System.Drawing.Point(32, 295);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(102, 24);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check Out";
            // 
            // timeOut
            // 
            this.timeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeOut.Location = new System.Drawing.Point(34, 322);
            this.timeOut.Name = "timeOut";
            this.timeOut.Size = new System.Drawing.Size(120, 27);
            this.timeOut.TabIndex = 5;
            // 
            // checkMc
            // 
            this.checkMc.AutoSize = true;
            this.checkMc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkMc.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkMc.Location = new System.Drawing.Point(40, 138);
            this.checkMc.Name = "checkMc";
            this.checkMc.Size = new System.Drawing.Size(64, 31);
            this.checkMc.TabIndex = 7;
            this.checkMc.Text = "MC";
            this.checkMc.UseVisualStyleBackColor = true;
            this.checkMc.CheckedChanged += new System.EventHandler(this.checkMc_CheckedChanged);
            // 
            // checkCar
            // 
            this.checkCar.AutoSize = true;
            this.checkCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkCar.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkCar.Location = new System.Drawing.Point(40, 108);
            this.checkCar.Name = "checkCar";
            this.checkCar.Size = new System.Drawing.Size(62, 31);
            this.checkCar.TabIndex = 6;
            this.checkCar.Text = "Car";
            this.checkCar.UseVisualStyleBackColor = true;
            this.checkCar.CheckedChanged += new System.EventHandler(this.checkCar_CheckedChanged);
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
            // listParkedVehicles
            // 
            this.listParkedVehicles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listParkedVehicles.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listParkedVehicles.Location = new System.Drawing.Point(210, 411);
            this.listParkedVehicles.Name = "listParkedVehicles";
            this.listParkedVehicles.Size = new System.Drawing.Size(391, 166);
            this.listParkedVehicles.TabIndex = 12;
            this.listParkedVehicles.UseCompatibleStateImageBehavior = false;
            // 
            // viewParkingLot
            // 
            this.viewParkingLot.ColumnCount = 2;
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.Location = new System.Drawing.Point(229, 66);
            this.viewParkingLot.Name = "viewParkingLot";
            this.viewParkingLot.RowCount = 2;
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewParkingLot.Size = new System.Drawing.Size(515, 309);
            this.viewParkingLot.TabIndex = 13;
            // 
            // FormParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(125)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1056, 699);
            this.Controls.Add(this.viewParkingLot);
            this.Controls.Add(this.listParkedVehicles);
            this.Controls.Add(this.txtBoxLicenseNum);
            this.Controls.Add(this.lblLicenseNum);
            this.Controls.Add(this.checkMc);
            this.Controls.Add(this.checkCar);
            this.Controls.Add(this.timeOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.timeIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormParkingLot";
            this.Text = "Parking Lot";
            this.Load += new System.EventHandler(this.FormParkingLot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCheckIn;
        private Button btnCheckOut;
        private DateTimePicker timeIn;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private DateTimePicker timeOut;
        private CheckBox checkMc;
        private CheckBox checkCar;
        private Label lblLicenseNum;
        private TextBox txtBoxLicenseNum;
        private ListView listParkedVehicles;
        private TableLayoutPanel viewParkingLot;
    }
}