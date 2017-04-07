namespace Applications.Applications.Accounting.AccountsReports
{
    partial class AccountsReports_Main
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
            this.btnReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_CrystalReport_Click = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(235, 28);
            this.label_SubName.Text = "Accounts Reports Main";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(485, 277);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(202, 119);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display Transacations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_CrystalReport_Click
            // 
            this.button_CrystalReport_Click.Location = new System.Drawing.Point(784, 199);
            this.button_CrystalReport_Click.Name = "button_CrystalReport_Click";
            this.button_CrystalReport_Click.Size = new System.Drawing.Size(142, 57);
            this.button_CrystalReport_Click.TabIndex = 4;
            this.button_CrystalReport_Click.Text = "Crystal Reports";
            this.button_CrystalReport_Click.UseVisualStyleBackColor = true;
            this.button_CrystalReport_Click.Click += new System.EventHandler(this.button_CrystalReport_Click_Click);
            // 
            // AccountsReports_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 733);
            this.Controls.Add(this.button_CrystalReport_Click);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReports);
            this.Name = "AccountsReports_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.btnReports, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button_CrystalReport_Click, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_CrystalReport_Click;
    }
}
