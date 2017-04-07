namespace Applications.Applications.Payroll
{
    partial class NetPay_SalariedEmpl
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
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Text = "select * from NetPay where DocType = 43 and Emp_ID=104";
            // 
            // button_Display
            // 
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(132, 44);
            this.label_SubName.Text = "Net Pay";
            // 
            // pictureBox_LeftLogo
            // 
            this.pictureBox_LeftLogo.Size = new System.Drawing.Size(239, 203);
            // 
            // NetPay_SalariedEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1828, 1000);
            this.Name = "NetPay_SalariedEmpl";
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
