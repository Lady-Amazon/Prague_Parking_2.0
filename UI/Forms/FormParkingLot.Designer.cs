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
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.txtBoxLicenseNum = new System.Windows.Forms.TextBox();
            this.listParkedVehicles = new System.Windows.Forms.ListView();
            this.viewParkingLot = new System.Windows.Forms.TableLayoutPanel();
            this.boxCheckCar = new System.Windows.Forms.RadioButton();
            this.boxCheckMc = new System.Windows.Forms.RadioButton();
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
            this.listParkedVehicles.Location = new System.Drawing.Point(229, 460);
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
            // FormParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(125)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1056, 699);
            this.Controls.Add(this.boxCheckMc);
            this.Controls.Add(this.boxCheckCar);
            this.Controls.Add(this.viewParkingLot);
            this.Controls.Add(this.listParkedVehicles);
            this.Controls.Add(this.txtBoxLicenseNum);
            this.Controls.Add(this.lblLicenseNum);
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
        private Label lblLicenseNum;
        private TextBox txtBoxLicenseNum;
        private ListView listParkedVehicles;
        private TableLayoutPanel viewParkingLot;
        private RadioButton boxCheckCar;
        private RadioButton boxCheckMc;
    }
}