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
            this.btnSavesetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChangeFeeCar = new System.Windows.Forms.TextBox();
            this.txtChangeFeeMc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSavesetting
            // 
            this.btnSavesetting.Location = new System.Drawing.Point(272, 200);
            this.btnSavesetting.Name = "btnSavesetting";
            this.btnSavesetting.Size = new System.Drawing.Size(210, 29);
            this.btnSavesetting.TabIndex = 0;
            this.btnSavesetting.Text = "Save Settings";
            this.btnSavesetting.UseVisualStyleBackColor = true;
            this.btnSavesetting.Click += new System.EventHandler(this.btnSavesetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter new parking fee for Cars:";
            // 
            // txtChangeFeeCar
            // 
            this.txtChangeFeeCar.Location = new System.Drawing.Point(29, 84);
            this.txtChangeFeeCar.Name = "txtChangeFeeCar";
            this.txtChangeFeeCar.Size = new System.Drawing.Size(125, 27);
            this.txtChangeFeeCar.TabIndex = 2;
            // 
            // txtChangeFeeMc
            // 
            this.txtChangeFeeMc.Location = new System.Drawing.Point(515, 84);
            this.txtChangeFeeMc.Name = "txtChangeFeeMc";
            this.txtChangeFeeMc.Size = new System.Drawing.Size(125, 27);
            this.txtChangeFeeMc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter new parking fee for Mc:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChangeFeeMc);
            this.Controls.Add(this.txtChangeFeeCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavesetting);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSavesetting;
        private Label label1;
        private TextBox txtChangeFeeCar;
        private TextBox txtChangeFeeMc;
        private Label label2;
    }
}