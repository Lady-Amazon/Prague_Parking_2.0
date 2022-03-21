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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStoreData = new System.Windows.Forms.Button();
            this.btnParkingLotView = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.availableCounter = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.occupiedCounter = new System.Windows.Forms.Label();
            this.labelOccupied = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.btnStoreData);
            this.panelMenu.Controls.Add(this.btnParkingLotView);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1485, 171);
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
            this.labelMaximize.Location = new System.Drawing.Point(1420, 6);
            this.labelMaximize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaximize.Name = "labelMaximize";
            this.labelMaximize.Size = new System.Drawing.Size(26, 32);
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
            this.labelMinimize.Location = new System.Drawing.Point(1389, 6);
            this.labelMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(22, 32);
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
            this.labelExit.Location = new System.Drawing.Point(1455, 11);
            this.labelExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(26, 28);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(969, 48);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(173, 61);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "HOME";
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(795, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(118, 171);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(677, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 171);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(559, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 171);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnStoreData
            // 
            this.btnStoreData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStoreData.FlatAppearance.BorderSize = 0;
            this.btnStoreData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreData.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoreData.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStoreData.Location = new System.Drawing.Point(413, 0);
            this.btnStoreData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStoreData.Name = "btnStoreData";
            this.btnStoreData.Size = new System.Drawing.Size(146, 171);
            this.btnStoreData.TabIndex = 7;
            this.btnStoreData.Text = "Sales";
            this.btnStoreData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStoreData.Click += new System.EventHandler(this.btnStoreData_Click);
            // 
            // btnParkingLotView
            // 
            this.btnParkingLotView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnParkingLotView.FlatAppearance.BorderSize = 0;
            this.btnParkingLotView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkingLotView.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParkingLotView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParkingLotView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnParkingLotView.Location = new System.Drawing.Point(262, 0);
            this.btnParkingLotView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnParkingLotView.Name = "btnParkingLotView";
            this.btnParkingLotView.Size = new System.Drawing.Size(151, 171);
            this.btnParkingLotView.TabIndex = 1;
            this.btnParkingLotView.Text = "ParkingLot";
            this.btnParkingLotView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParkingLotView.UseVisualStyleBackColor = true;
            this.btnParkingLotView.Click += new System.EventHandler(this.btnParkingLotView_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(262, 171);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prauge Parking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "PP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.availableCounter);
            this.panel1.Controls.Add(this.labelAvailable);
            this.panel1.Controls.Add(this.occupiedCounter);
            this.panel1.Controls.Add(this.labelOccupied);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 817);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(0, 756);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(262, 61);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // availableCounter
            // 
            this.availableCounter.AutoSize = true;
            this.availableCounter.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.availableCounter.ForeColor = System.Drawing.Color.Gainsboro;
            this.availableCounter.Location = new System.Drawing.Point(78, 308);
            this.availableCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availableCounter.Name = "availableCounter";
            this.availableCounter.Size = new System.Drawing.Size(71, 45);
            this.availableCounter.TabIndex = 3;
            this.availableCounter.Text = "100";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvailable.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAvailable.Location = new System.Drawing.Point(34, 220);
            this.labelAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(162, 45);
            this.labelAvailable.TabIndex = 2;
            this.labelAvailable.Text = "Available";
            // 
            // occupiedCounter
            // 
            this.occupiedCounter.AutoSize = true;
            this.occupiedCounter.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.occupiedCounter.ForeColor = System.Drawing.Color.Gainsboro;
            this.occupiedCounter.Location = new System.Drawing.Point(78, 136);
            this.occupiedCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.occupiedCounter.Name = "occupiedCounter";
            this.occupiedCounter.Size = new System.Drawing.Size(71, 45);
            this.occupiedCounter.TabIndex = 1;
            this.occupiedCounter.Text = "000";
            // 
            // labelOccupied
            // 
            this.labelOccupied.AutoSize = true;
            this.labelOccupied.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOccupied.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelOccupied.Location = new System.Drawing.Point(34, 64);
            this.labelOccupied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOccupied.Name = "labelOccupied";
            this.labelOccupied.Size = new System.Drawing.Size(164, 45);
            this.labelOccupied.TabIndex = 0;
            this.labelOccupied.Text = "Occupied";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktop.Controls.Add(this.label7);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(262, 171);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1223, 817);
            this.panelDesktop.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.label7.Location = new System.Drawing.Point(429, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 97);
            this.label7.TabIndex = 0;
            this.label7.Text = "Welcome";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1485, 988);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnSettings;
        private Button button4;
        private Button button3;
        private Button btnStoreData;
        private Button btnParkingLotView;
        private Panel panelLogo;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label availableCounter;
        private Label labelAvailable;
        private Label occupiedCounter;
        private Label labelOccupied;
        private Panel panelDesktop;
        private Label label7;
        private Button btnExit;
        private Label labelTitle;
        private Label labelMinimize;
        private Label labelExit;
        private Label labelMaximize;
    }
}