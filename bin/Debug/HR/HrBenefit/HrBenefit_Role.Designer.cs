namespace Applications.Applications.HR.HrBenefit
{
    partial class HrBenefit_Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrBenefit_Role));
            this.HR_Admin_Benefit_Button = new System.Windows.Forms.Button();
            this.Employee_Benefit_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(240, 28);
            this.label_SubName.Text = " HR Benefits - Team 1D";
            // 
            // HR_Admin_Benefit_Button
            // 
            this.HR_Admin_Benefit_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.HR_Admin_Benefit_Button.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HR_Admin_Benefit_Button.ForeColor = System.Drawing.Color.White;
            this.HR_Admin_Benefit_Button.Location = new System.Drawing.Point(651, 428);
            this.HR_Admin_Benefit_Button.Name = "HR_Admin_Benefit_Button";
            this.HR_Admin_Benefit_Button.Size = new System.Drawing.Size(191, 89);
            this.HR_Admin_Benefit_Button.TabIndex = 2;
            this.HR_Admin_Benefit_Button.Text = "HR Administrator";
            this.HR_Admin_Benefit_Button.UseVisualStyleBackColor = false;
            this.HR_Admin_Benefit_Button.Click += new System.EventHandler(this.HR_Admin_Benefit_Button_Click);
            // 
            // Employee_Benefit_Button
            // 
            this.Employee_Benefit_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Employee_Benefit_Button.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Employee_Benefit_Button.ForeColor = System.Drawing.Color.White;
            this.Employee_Benefit_Button.Location = new System.Drawing.Point(651, 277);
            this.Employee_Benefit_Button.Name = "Employee_Benefit_Button";
            this.Employee_Benefit_Button.Size = new System.Drawing.Size(191, 89);
            this.Employee_Benefit_Button.TabIndex = 3;
            this.Employee_Benefit_Button.Text = "Employee";
            this.Employee_Benefit_Button.UseVisualStyleBackColor = false;
            this.Employee_Benefit_Button.Click += new System.EventHandler(this.Employee_Benefit_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(159, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 243);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // HrBenefit_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1178, 679);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Employee_Benefit_Button);
            this.Controls.Add(this.HR_Admin_Benefit_Button);
            this.Name = "HrBenefit_Role";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.HR_Admin_Benefit_Button, 0);
            this.Controls.SetChildIndex(this.Employee_Benefit_Button, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HR_Admin_Benefit_Button;
        private System.Windows.Forms.Button Employee_Benefit_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
