    partial class HAWK_Template_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HAWK_Template_1));
            this._panel2_LeftControlPanel = new System.Windows.Forms.Panel();
            this.button_SearchData = new System.Windows.Forms.Button();
            this.button_Return = new System.Windows.Forms.Button();
            this.label_UserPre = new System.Windows.Forms.Label();
            this.label_UserID = new System.Windows.Forms.Label();
            this.label_Connector = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_SubName = new System.Windows.Forms.Label();
            this.label_CompanyName = new System.Windows.Forms.Label();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TopPanel
            // 
            this.panel_TopPanel.BackColor = System.Drawing.Color.White;
            this.panel_TopPanel.Controls.Add(this.label_CompanyName);
            this.panel_TopPanel.Controls.Add(this.label_SubName);
            this.panel_TopPanel.Controls.Add(this.label_UserName);
            this.panel_TopPanel.Controls.Add(this.label_Connector);
            this.panel_TopPanel.Controls.Add(this.label_UserID);
            this.panel_TopPanel.Controls.Add(this.label_UserPre);
            this.panel_TopPanel.Controls.SetChildIndex(this.pictureBox_LeftLogo, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.pictureBox_RightLogo, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_UserPre, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_UserID, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_Connector, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_UserName, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_SubName, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_CompanyName, 0);
            // 
            // pictureBox_RightLogo
            // 
            this.pictureBox_RightLogo.Location = new System.Drawing.Point(168, 0);
            this.pictureBox_RightLogo.Size = new System.Drawing.Size(974, 132);
            // 
            // pictureBox_LeftLogo
            // 
            this.pictureBox_LeftLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LeftLogo.Image")));
            this.pictureBox_LeftLogo.Size = new System.Drawing.Size(169, 128);
            // 
            // _panel2_LeftControlPanel
            // 
            this._panel2_LeftControlPanel.Controls.Add(this.button_SearchData);
            this._panel2_LeftControlPanel.Controls.Add(this.button_Return);
            this._panel2_LeftControlPanel.Location = new System.Drawing.Point(1, 136);
            this._panel2_LeftControlPanel.Name = "_panel2_LeftControlPanel";
            this._panel2_LeftControlPanel.Size = new System.Drawing.Size(160, 588);
            this._panel2_LeftControlPanel.TabIndex = 1;
            // 
            // button_SearchData
            // 
            this.button_SearchData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_SearchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchData.Location = new System.Drawing.Point(20, 107);
            this.button_SearchData.Name = "button_SearchData";
            this.button_SearchData.Size = new System.Drawing.Size(112, 63);
            this.button_SearchData.TabIndex = 1;
            this.button_SearchData.Text = "Search Data Sources";
            this.button_SearchData.UseVisualStyleBackColor = false;
            this.button_SearchData.Click += new System.EventHandler(this.button_SearchData_Click);
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Return.Location = new System.Drawing.Point(20, 24);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(112, 69);
            this.button_Return.TabIndex = 0;
            this.button_Return.Text = "Return to Previous Level";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // label_UserPre
            // 
            this.label_UserPre.AutoSize = true;
            this.label_UserPre.BackColor = System.Drawing.Color.White;
            this.label_UserPre.Location = new System.Drawing.Point(762, 102);
            this.label_UserPre.Name = "label_UserPre";
            this.label_UserPre.Size = new System.Drawing.Size(32, 13);
            this.label_UserPre.TabIndex = 5;
            this.label_UserPre.Text = "User ";
            this.label_UserPre.Visible = false;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.BackColor = System.Drawing.Color.White;
            this.label_UserID.Location = new System.Drawing.Point(800, 102);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(19, 13);
            this.label_UserID.TabIndex = 6;
            this.label_UserID.Text = " _ ";
            this.label_UserID.Visible = false;
            // 
            // label_Connector
            // 
            this.label_Connector.AutoSize = true;
            this.label_Connector.Location = new System.Drawing.Point(825, 102);
            this.label_Connector.Name = "label_Connector";
            this.label_Connector.Size = new System.Drawing.Size(10, 13);
            this.label_Connector.TabIndex = 7;
            this.label_Connector.Text = ":";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.White;
            this.label_UserName.Location = new System.Drawing.Point(841, 102);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(34, 13);
            this.label_UserName.TabIndex = 8;
            this.label_UserName.Text = " _ _ _";
            this.label_UserName.Visible = false;
            // 
            // label_SubName
            // 
            this.label_SubName.AutoSize = true;
            this.label_SubName.BackColor = System.Drawing.Color.White;
            this.label_SubName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SubName.Location = new System.Drawing.Point(453, 77);
            this.label_SubName.Name = "label_SubName";
            this.label_SubName.Size = new System.Drawing.Size(37, 28);
            this.label_SubName.TabIndex = 9;
            this.label_SubName.Text = " _ ";
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CompanyName.ForeColor = System.Drawing.Color.Navy;
            this.label_CompanyName.Location = new System.Drawing.Point(417, 9);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(317, 57);
            this.label_CompanyName.TabIndex = 56;
            this.label_CompanyName.Text = "HAWK Systems";
            // 
            // HAWK_Template_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this._panel2_LeftControlPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "HAWK_Template_1";
            this.Text = "HAWK Template 1";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel _panel2_LeftControlPanel;
        protected System.Windows.Forms.Button button_SearchData;
        protected System.Windows.Forms.Button button_Return;
        protected System.Windows.Forms.Label label_UserID;
        protected System.Windows.Forms.Label label_UserPre;
        protected System.Windows.Forms.Label label_UserName;
        protected System.Windows.Forms.Label label_Connector;
        protected System.Windows.Forms.Label label_SubName;
        private System.Windows.Forms.Label label_CompanyName;
    }
