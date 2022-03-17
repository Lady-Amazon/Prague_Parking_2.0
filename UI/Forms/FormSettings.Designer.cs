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
            this.SuspendLayout();
            // 
            // btnSavesetting
            // 
            this.btnSavesetting.Location = new System.Drawing.Point(271, 278);
            this.btnSavesetting.Name = "btnSavesetting";
            this.btnSavesetting.Size = new System.Drawing.Size(210, 29);
            this.btnSavesetting.TabIndex = 0;
            this.btnSavesetting.Text = "Save Settings";
            this.btnSavesetting.UseVisualStyleBackColor = true;
            this.btnSavesetting.Click += new System.EventHandler(this.btnSavesetting_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSavesetting);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSavesetting;
    }
}