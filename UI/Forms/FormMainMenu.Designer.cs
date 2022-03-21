namespace UI
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelMaximize = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnParkingLotView = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblTitleParking = new System.Windows.Forms.Label();
            this.lblTitlePP = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelCount = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelOccupied = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.label000 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(84)))));
            this.panelMenu.Controls.Add(this.labelMaximize);
            this.panelMenu.Controls.Add(this.labelMinimize);
            this.panelMenu.Controls.Add(this.labelExit);
            this.panelMenu.Controls.Add(this.labelTitle);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnSales);
            this.panelMenu.Controls.Add(this.btnParkingLotView);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1188, 154);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // labelMaximize
            // 
            this.labelMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaximize.AutoSize = true;
            this.labelMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMaximize.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMaximize.Location = new System.Drawing.Point(1136, 5);
            this.labelMaximize.Name = "labelMaximize";
            this.labelMaximize.Size = new System.Drawing.Size(22, 27);
            this.labelMaximize.TabIndex = 10;
            this.labelMaximize.Text = "+";
            this.labelMaximize.Click += new System.EventHandler(this.labelMaximize_Click);
            // 
            // labelMinimize
            // 
            this.labelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMinimize.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMinimize.Location = new System.Drawing.Point(1111, 5);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(19, 27);
            this.labelMinimize.TabIndex = 9;
            this.labelMinimize.Text = "-";
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            // 
            // labelExit
            // 
            this.labelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExit.AutoSize = true;
            this.labelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExit.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelExit.Location = new System.Drawing.Point(1164, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(21, 23);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(835, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(154, 55);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "HOME";
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(467, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(118, 154);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSales.Location = new System.Drawing.Point(350, 0);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(117, 154);
            this.btnSales.TabIndex = 7;
            this.btnSales.Text = "PRICES";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.Click += new System.EventHandler(this.btnPrices_Click);
            // 
            // btnParkingLotView
            // 
            this.btnParkingLotView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnParkingLotView.FlatAppearance.BorderSize = 0;
            this.btnParkingLotView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkingLotView.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParkingLotView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParkingLotView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnParkingLotView.Location = new System.Drawing.Point(210, 0);
            this.btnParkingLotView.Name = "btnParkingLotView";
            this.btnParkingLotView.Size = new System.Drawing.Size(140, 154);
            this.btnParkingLotView.TabIndex = 1;
            this.btnParkingLotView.Text = "PARKING LOT";
            this.btnParkingLotView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParkingLotView.UseVisualStyleBackColor = true;
            this.btnParkingLotView.Click += new System.EventHandler(this.btnParkingLotView_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelLogo.Controls.Add(this.lblTitleParking);
            this.panelLogo.Controls.Add(this.lblTitlePP);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 154);
            this.panelLogo.TabIndex = 0;
            // 
            // lblTitleParking
            // 
            this.lblTitleParking.AutoSize = true;
            this.lblTitleParking.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitleParking.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleParking.Location = new System.Drawing.Point(22, 87);
            this.lblTitleParking.Name = "lblTitleParking";
            this.lblTitleParking.Size = new System.Drawing.Size(155, 31);
            this.lblTitleParking.TabIndex = 1;
            this.lblTitleParking.Text = "Prague Parking";
            // 
            // lblTitlePP
            // 
            this.lblTitlePP.AutoSize = true;
            this.lblTitlePP.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitlePP.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitlePP.Location = new System.Drawing.Point(57, 22);
            this.lblTitlePP.Name = "lblTitlePP";
            this.lblTitlePP.Size = new System.Drawing.Size(80, 65);
            this.lblTitlePP.TabIndex = 0;
            this.lblTitlePP.Text = "PP";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktop.Controls.Add(this.panelCount);
            this.panelDesktop.Controls.Add(this.labelWelcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 154);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1188, 636);
            this.panelDesktop.TabIndex = 2;
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
            this.panelCount.Name = "panelCount";
            this.panelCount.Size = new System.Drawing.Size(210, 636);
            this.panelCount.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(0, 549);
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
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.labelWelcome.Location = new System.Drawing.Point(448, 240);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(284, 81);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1188, 790);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelCount.ResumeLayout(false);
            this.panelCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnSettings;
        private Button btnSales;
        private Button btnParkingLotView;
        private Panel panelLogo;
        private Label lblTitleParking;
        private Label lblTitlePP;
        
        private Panel panelDesktop;
        private Label labelWelcome;
        private Label labelTitle;
        private Label labelMinimize;
        private Label labelExit;
        private Label labelMaximize;
        private Panel panelCount;
        private Button btnExit;
        private Label labelOccupied;
        private Label label100;
        private Label labelAvailable;
        private Label label000;
    }
}