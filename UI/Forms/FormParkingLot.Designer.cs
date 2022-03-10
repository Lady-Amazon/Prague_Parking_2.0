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
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkMc = new System.Windows.Forms.CheckBox();
            this.checkCar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(14, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "OUT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 28);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(33, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Checked In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(32, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Checked Out";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(34, 322);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 27);
            this.dateTimePicker2.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(33, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "License Number:";
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkMc);
            this.Controls.Add(this.checkCar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormParkingLot";
            this.Text = "Parking Lot";
            this.Load += new System.EventHandler(this.FormParkingLot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCheckIn;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkMc;
        private CheckBox checkCar;
        private Label label3;
        private TextBox txtBoxLicenseNum;
        private ListView listParkedVehicles;
        private TableLayoutPanel viewParkingLot;
    }
}