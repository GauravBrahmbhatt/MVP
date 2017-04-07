namespace Applications.Applications.HR.HrBenefit
{
    partial class HrBenefit_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrBenefit_Employee));
            this.button_view_all = new System.Windows.Forms.Button();
            this.button_view_my_own = new System.Windows.Forms.Button();
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
            this.label_SubName.Size = new System.Drawing.Size(260, 28);
            this.label_SubName.Text = "HR Benefits for Employee";
            // 
            // button_view_all
            // 
            this.button_view_all.BackColor = System.Drawing.Color.Chocolate;
            this.button_view_all.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_view_all.FlatAppearance.BorderSize = 2;
            this.button_view_all.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_view_all.ForeColor = System.Drawing.Color.Black;
            this.button_view_all.Location = new System.Drawing.Point(901, 237);
            this.button_view_all.Name = "button_view_all";
            this.button_view_all.Size = new System.Drawing.Size(203, 108);
            this.button_view_all.TabIndex = 2;
            this.button_view_all.Text = "View and Select Benefit";
            this.button_view_all.UseVisualStyleBackColor = false;
            this.button_view_all.Click += new System.EventHandler(this.button_view_all_Click);
            // 
            // button_view_my_own
            // 
            this.button_view_my_own.BackColor = System.Drawing.Color.Chocolate;
            this.button_view_my_own.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_view_my_own.ForeColor = System.Drawing.Color.Black;
            this.button_view_my_own.Location = new System.Drawing.Point(901, 452);
            this.button_view_my_own.Name = "button_view_my_own";
            this.button_view_my_own.Size = new System.Drawing.Size(203, 108);
            this.button_view_my_own.TabIndex = 3;
            this.button_view_my_own.Text = "View my own benefit(s)";
            this.button_view_my_own.UseVisualStyleBackColor = false;
            this.button_view_my_own.Click += new System.EventHandler(this.button_view_my_own_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(167, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(701, 323);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // HrBenefit_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_view_my_own);
            this.Controls.Add(this.button_view_all);
            this.Name = "HrBenefit_Employee";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button_view_all, 0);
            this.Controls.SetChildIndex(this.button_view_my_own, 0);
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

        private System.Windows.Forms.Button button_view_all;
        private System.Windows.Forms.Button button_view_my_own;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
