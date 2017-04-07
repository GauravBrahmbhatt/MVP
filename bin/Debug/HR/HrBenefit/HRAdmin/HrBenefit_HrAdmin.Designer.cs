namespace Applications.Applications.HR.HrBenefit
{
    partial class HrBenefit_HrAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrBenefit_HrAdmin));
            this.button_HrAdmin_Manage_Benefits = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label_SubName.Size = new System.Drawing.Size(238, 28);
            this.label_SubName.Text = " HR Admin for Benefits";
            // 
            // button_HrAdmin_Manage_Benefits
            // 
            this.button_HrAdmin_Manage_Benefits.BackColor = System.Drawing.Color.OliveDrab;
            this.button_HrAdmin_Manage_Benefits.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HrAdmin_Manage_Benefits.ForeColor = System.Drawing.Color.Black;
            this.button_HrAdmin_Manage_Benefits.Location = new System.Drawing.Point(229, 377);
            this.button_HrAdmin_Manage_Benefits.Name = "button_HrAdmin_Manage_Benefits";
            this.button_HrAdmin_Manage_Benefits.Size = new System.Drawing.Size(182, 86);
            this.button_HrAdmin_Manage_Benefits.TabIndex = 2;
            this.button_HrAdmin_Manage_Benefits.Text = "Manage Benefits";
            this.button_HrAdmin_Manage_Benefits.UseVisualStyleBackColor = false;
            this.button_HrAdmin_Manage_Benefits.Click += new System.EventHandler(this.button_HrAdmin_Manage_Benefits_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(465, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 86);
            this.button1.TabIndex = 3;
            this.button1.Text = "Review Request from Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(779, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 249);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // HrBenefit_HrAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_HrAdmin_Manage_Benefits);
            this.Name = "HrBenefit_HrAdmin";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button_HrAdmin_Manage_Benefits, 0);
            this.Controls.SetChildIndex(this.button1, 0);
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

        private System.Windows.Forms.Button button_HrAdmin_Manage_Benefits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
