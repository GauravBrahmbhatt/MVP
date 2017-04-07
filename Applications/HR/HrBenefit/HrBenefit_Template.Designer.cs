namespace Applications.Applications.HR.HrBenefit
{
    partial class HrBenefit_Template
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrBenefit_Template));
            this.HR_Hiring_Button = new System.Windows.Forms.Button();
            this.HR_Benefits_Button = new System.Windows.Forms.Button();
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
            this.label_SubName.Size = new System.Drawing.Size(177, 28);
            this.label_SubName.Text = "Human Resources";
            // 
            // HR_Hiring_Button
            // 
            this.HR_Hiring_Button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR_Hiring_Button.Location = new System.Drawing.Point(427, 528);
            this.HR_Hiring_Button.Name = "HR_Hiring_Button";
            this.HR_Hiring_Button.Size = new System.Drawing.Size(152, 82);
            this.HR_Hiring_Button.TabIndex = 2;
            this.HR_Hiring_Button.Text = "HR Hiring";
            this.HR_Hiring_Button.UseVisualStyleBackColor = true;
            this.HR_Hiring_Button.Click += new System.EventHandler(this.HR_Hiring_Button_Click);
            // 
            // HR_Benefits_Button
            // 
            this.HR_Benefits_Button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR_Benefits_Button.Location = new System.Drawing.Point(676, 528);
            this.HR_Benefits_Button.Name = "HR_Benefits_Button";
            this.HR_Benefits_Button.Size = new System.Drawing.Size(152, 82);
            this.HR_Benefits_Button.TabIndex = 3;
            this.HR_Benefits_Button.Text = "HR Benefits";
            this.HR_Benefits_Button.UseVisualStyleBackColor = true;
            this.HR_Benefits_Button.Click += new System.EventHandler(this.HR_Benefits_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(427, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 273);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // HrBenefit_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.HR_Benefits_Button);
            this.Controls.Add(this.HR_Hiring_Button);
            this.Name = "HrBenefit_Template";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.HR_Hiring_Button, 0);
            this.Controls.SetChildIndex(this.HR_Benefits_Button, 0);
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

        private System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.Button HR_Hiring_Button;
        protected System.Windows.Forms.Button HR_Benefits_Button;
    }
}
