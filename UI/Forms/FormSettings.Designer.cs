namespace UI
{
    partial class FormSettings
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
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChangeFeeCar = new System.Windows.Forms.TextBox();
            this.txtChangeFeeMc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblChangeSizeLot = new System.Windows.Forms.Label();
            this.lblChangeSpotSize = new System.Windows.Forms.Label();
            this.txtChangeLotSize = new System.Windows.Forms.TextBox();
            this.txtChangeSpotSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.btnSaveSettings.Location = new System.Drawing.Point(900, 570);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(178, 66);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSavesetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(21, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter new parking fee for Cars:";
            // 
            // txtChangeFeeCar
            // 
            this.txtChangeFeeCar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtChangeFeeCar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangeFeeCar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtChangeFeeCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtChangeFeeCar.Location = new System.Drawing.Point(384, 238);
            this.txtChangeFeeCar.Name = "txtChangeFeeCar";
            this.txtChangeFeeCar.Size = new System.Drawing.Size(57, 32);
            this.txtChangeFeeCar.TabIndex = 2;
            // 
            // txtChangeFeeMc
            // 
            this.txtChangeFeeMc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtChangeFeeMc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangeFeeMc.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtChangeFeeMc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtChangeFeeMc.Location = new System.Drawing.Point(384, 301);
            this.txtChangeFeeMc.Name = "txtChangeFeeMc";
            this.txtChangeFeeMc.Size = new System.Drawing.Size(57, 32);
            this.txtChangeFeeMc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(21, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter new parking fee for Mc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.label3.Location = new System.Drawing.Point(265, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "SETTINGS";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.textBox1.Location = new System.Drawing.Point(21, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 75);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Here you can change parkingfees and add parkingspots";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // lblChangeSizeLot
            // 
            this.lblChangeSizeLot.AutoSize = true;
            this.lblChangeSizeLot.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChangeSizeLot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblChangeSizeLot.Location = new System.Drawing.Point(21, 424);
            this.lblChangeSizeLot.Name = "lblChangeSizeLot";
            this.lblChangeSizeLot.Size = new System.Drawing.Size(386, 31);
            this.lblChangeSizeLot.TabIndex = 7;
            this.lblChangeSizeLot.Text = "Change the size of the parking lot: ";
            // 
            // lblChangeSpotSize
            // 
            this.lblChangeSpotSize.AutoSize = true;
            this.lblChangeSpotSize.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChangeSpotSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.lblChangeSpotSize.Location = new System.Drawing.Point(21, 506);
            this.lblChangeSpotSize.Name = "lblChangeSpotSize";
            this.lblChangeSpotSize.Size = new System.Drawing.Size(397, 31);
            this.lblChangeSpotSize.TabIndex = 8;
            this.lblChangeSpotSize.Text = "Change the size of the parkingspot :";
            // 
            // txtChangeLotSize
            // 
            this.txtChangeLotSize.BackColor = System.Drawing.Color.Gainsboro;
            this.txtChangeLotSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangeLotSize.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtChangeLotSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtChangeLotSize.Location = new System.Drawing.Point(413, 424);
            this.txtChangeLotSize.Multiline = true;
            this.txtChangeLotSize.Name = "txtChangeLotSize";
            this.txtChangeLotSize.Size = new System.Drawing.Size(96, 31);
            this.txtChangeLotSize.TabIndex = 11;
            // 
            // txtChangeSpotSize
            // 
            this.txtChangeSpotSize.BackColor = System.Drawing.Color.Gainsboro;
            this.txtChangeSpotSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangeSpotSize.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtChangeSpotSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(129)))));
            this.txtChangeSpotSize.Location = new System.Drawing.Point(424, 503);
            this.txtChangeSpotSize.Multiline = true;
            this.txtChangeSpotSize.Name = "txtChangeSpotSize";
            this.txtChangeSpotSize.Size = new System.Drawing.Size(96, 34);
            this.txtChangeSpotSize.TabIndex = 10;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1154, 711);
            this.Controls.Add(this.txtChangeSpotSize);
            this.Controls.Add(this.txtChangeLotSize);
            this.Controls.Add(this.lblChangeSpotSize);
            this.Controls.Add(this.lblChangeSizeLot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChangeFeeMc);
            this.Controls.Add(this.txtChangeFeeCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "SETTINGS";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSaveSettings;
        private Label label1;
        private TextBox txtChangeFeeCar;
        private TextBox txtChangeFeeMc;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label lblChangeSizeLot;
        private Label lblChangeSpotSize;
        private TextBox txtChangeLotSize;
        private TextBox txtChangeSpotSize;
    }
}