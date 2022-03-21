namespace UI
{
    partial class FormPrices
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelPriceList = new System.Windows.Forms.Label();
            this.labelCarFee = new System.Windows.Forms.Label();
            this.labelChargeCar = new System.Windows.Forms.Label();
            this.labelMcFee = new System.Windows.Forms.Label();
            this.labelChargeMc = new System.Windows.Forms.Label();
            this.panelCount = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelPriceList
            // 
            this.labelPriceList.AutoSize = true;
            this.labelPriceList.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPriceList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.labelPriceList.Location = new System.Drawing.Point(212, 20);
            this.labelPriceList.Name = "labelPriceList";
            this.labelPriceList.Size = new System.Drawing.Size(233, 51);
            this.labelPriceList.TabIndex = 0;
            this.labelPriceList.Text = "PRICE LIST";
            // 
            // labelCarFee
            // 
            this.labelCarFee.AutoSize = true;
            this.labelCarFee.BackColor = System.Drawing.Color.DarkCyan;
            this.labelCarFee.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCarFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.labelCarFee.Location = new System.Drawing.Point(317, 112);
            this.labelCarFee.Name = "labelCarFee";
            this.labelCarFee.Size = new System.Drawing.Size(128, 32);
            this.labelCarFee.TabIndex = 1;
            this.labelCarFee.Text = "CAR FEE :";
            // 
            // labelChargeCar
            // 
            this.labelChargeCar.AutoSize = true;
            this.labelChargeCar.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChargeCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.labelChargeCar.Location = new System.Drawing.Point(463, 112);
            this.labelChargeCar.Name = "labelChargeCar";
            this.labelChargeCar.Size = new System.Drawing.Size(0, 32);
            this.labelChargeCar.TabIndex = 2;
            // 
            // labelMcFee
            // 
            this.labelMcFee.AutoSize = true;
            this.labelMcFee.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMcFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.labelMcFee.Location = new System.Drawing.Point(317, 174);
            this.labelMcFee.Name = "labelMcFee";
            this.labelMcFee.Size = new System.Drawing.Size(116, 32);
            this.labelMcFee.TabIndex = 3;
            this.labelMcFee.Text = "MC FEE :";
            // 
            // labelChargeMc
            // 
            this.labelChargeMc.AutoSize = true;
            this.labelChargeMc.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChargeMc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.labelChargeMc.Location = new System.Drawing.Point(463, 174);
            this.labelChargeMc.Name = "labelChargeMc";
            this.labelChargeMc.Size = new System.Drawing.Size(0, 32);
            this.labelChargeMc.TabIndex = 4;
            // 
            // panelCount
            // 
            this.panelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.panelCount.Controls.Add(this.btnExit);
            this.panelCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCount.Location = new System.Drawing.Point(0, 0);
            this.panelCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCount.Name = "panelCount";
            this.panelCount.Size = new System.Drawing.Size(184, 350);
            this.panelCount.TabIndex = 26;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(0, 285);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(184, 65);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // FormPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(621, 350);
            this.Controls.Add(this.panelCount);
            this.Controls.Add(this.labelChargeMc);
            this.Controls.Add(this.labelMcFee);
            this.Controls.Add(this.labelChargeCar);
            this.Controls.Add(this.labelCarFee);
            this.Controls.Add(this.labelPriceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrices";
            this.Text = "PRICES";
            this.Load += new System.EventHandler(this.FormPrices_Load);
            this.panelCount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Label labelPriceList;
        private Label labelCarFee;
        private Label labelChargeCar;
        private Label labelMcFee;
        private Label labelChargeMc;
        private Panel panelCount;
        private Button btnExit;
    }
}