    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.panel_TopPanel = new System.Windows.Forms.Panel();
            this.label_CompanyName = new System.Windows.Forms.Label();
            this.pictureBox_RightLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox_LeftLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TopPanel
            // 
            this.panel_TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel_TopPanel.Controls.Add(this.label_CompanyName);
            this.panel_TopPanel.Controls.Add(this.pictureBox_RightLogo);
            this.panel_TopPanel.Controls.Add(this.pictureBox_LeftLogo);
            this.panel_TopPanel.Location = new System.Drawing.Point(0, 0);
            this.panel_TopPanel.Name = "panel_TopPanel";
            this.panel_TopPanel.Size = new System.Drawing.Size(1180, 134);
            this.panel_TopPanel.TabIndex = 0;
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CompanyName.ForeColor = System.Drawing.Color.Navy;
            this.label_CompanyName.Location = new System.Drawing.Point(330, 6);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(317, 57);
            this.label_CompanyName.TabIndex = 55;
            this.label_CompanyName.Text = "HAWK Systems";
            // 
            // pictureBox_RightLogo
            // 
            this.pictureBox_RightLogo.Location = new System.Drawing.Point(1035, 2);
            this.pictureBox_RightLogo.Name = "pictureBox_RightLogo";
            this.pictureBox_RightLogo.Size = new System.Drawing.Size(145, 130);
            this.pictureBox_RightLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_RightLogo.TabIndex = 54;
            this.pictureBox_RightLogo.TabStop = false;
            // 
            // pictureBox_LeftLogo
            // 
            this.pictureBox_LeftLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_LeftLogo.ErrorImage")));
            this.pictureBox_LeftLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LeftLogo.Image")));
            this.pictureBox_LeftLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_LeftLogo.InitialImage")));
            this.pictureBox_LeftLogo.Location = new System.Drawing.Point(2, 2);
            this.pictureBox_LeftLogo.Name = "pictureBox_LeftLogo";
            this.pictureBox_LeftLogo.Size = new System.Drawing.Size(166, 120);
            this.pictureBox_LeftLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LeftLogo.TabIndex = 53;
            this.pictureBox_LeftLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1179, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1193, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_TopPanel);
            this.Name = "Form0";
            this.Text = "HAWK Form 0";
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel_TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.PictureBox pictureBox_RightLogo;
        protected System.Windows.Forms.PictureBox pictureBox_LeftLogo;
        private System.Windows.Forms.Label label_CompanyName;
    }
