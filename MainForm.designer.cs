    partial class MainForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.button_Payroll = new System.Windows.Forms.Button();
            this.button_Materials = new System.Windows.Forms.Button();
            this.button_Marketing = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_Dept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Role = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_ClientTraining = new System.Windows.Forms.Button();
            this.button_HR = new System.Windows.Forms.Button();
            this.button_SearchDataSources = new System.Windows.Forms.Button();
            this.button_Accounting = new System.Windows.Forms.Button();
            this.button_Utilities = new System.Windows.Forms.Button();
            this.radioButton_Access = new System.Windows.Forms.RadioButton();
            this.radioButton_MS_SQL = new System.Windows.Forms.RadioButton();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel2_LeftControlPanel
            // 
            this._panel2_LeftControlPanel.Controls.Add(this.radioButton_MS_SQL);
            this._panel2_LeftControlPanel.Controls.Add(this.radioButton_Access);
            this._panel2_LeftControlPanel.Controls.Add(this.button_SearchDataSources);
            this._panel2_LeftControlPanel.Size = new System.Drawing.Size(190, 588);
            this._panel2_LeftControlPanel.Controls.SetChildIndex(this.button_SearchDataSources, 0);
            this._panel2_LeftControlPanel.Controls.SetChildIndex(this.button_SearchData, 0);
            this._panel2_LeftControlPanel.Controls.SetChildIndex(this.button_Return, 0);
            this._panel2_LeftControlPanel.Controls.SetChildIndex(this.radioButton_Access, 0);
            this._panel2_LeftControlPanel.Controls.SetChildIndex(this.radioButton_MS_SQL, 0);
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.button_Return.Size = new System.Drawing.Size(144, 58);
            this.button_Return.Text = "EXIT";
            // 
            // label_SubName
            // 
            this.label_SubName.Location = new System.Drawing.Point(472, 76);
            this.label_SubName.Size = new System.Drawing.Size(189, 28);
            this.label_SubName.Text = "Main Switchboard";
            // 
            // panel_TopPanel
            // 
            this.panel_TopPanel.Size = new System.Drawing.Size(1180, 122);
            // 
            // pictureBox_LeftLogo
            // 
            this.pictureBox_LeftLogo.Size = new System.Drawing.Size(176, 128);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Copyright   HAWK Systems --  2014";
            // 
            // button_Payroll
            // 
            this.button_Payroll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Payroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Payroll.Location = new System.Drawing.Point(227, 295);
            this.button_Payroll.Name = "button_Payroll";
            this.button_Payroll.Size = new System.Drawing.Size(146, 69);
            this.button_Payroll.TabIndex = 15;
            this.button_Payroll.Text = "Payroll";
            this.button_Payroll.UseVisualStyleBackColor = false;
            this.button_Payroll.Click += new System.EventHandler(this.button_Payroll_Click);
            // 
            // button_Materials
            // 
            this.button_Materials.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Materials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Materials.Location = new System.Drawing.Point(227, 176);
            this.button_Materials.Name = "button_Materials";
            this.button_Materials.Size = new System.Drawing.Size(146, 69);
            this.button_Materials.TabIndex = 17;
            this.button_Materials.Text = "Materials Management";
            this.button_Materials.UseVisualStyleBackColor = false;
            this.button_Materials.Click += new System.EventHandler(this.button_Materials_Click);
            // 
            // button_Marketing
            // 
            this.button_Marketing.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Marketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Marketing.Location = new System.Drawing.Point(477, 176);
            this.button_Marketing.Name = "button_Marketing";
            this.button_Marketing.Size = new System.Drawing.Size(146, 69);
            this.button_Marketing.TabIndex = 18;
            this.button_Marketing.Text = " Marketing   and Sales";
            this.button_Marketing.UseVisualStyleBackColor = false;
            this.button_Marketing.Click += new System.EventHandler(this.button_Marketing_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.textBox_Dept);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox_Role);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.button_Login);
            this.groupBox4.Controls.Add(this.textBox_Password);
            this.groupBox4.Controls.Add(this.textBox_UserID);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(6, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 190);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Login";
            // 
            // textBox_Dept
            // 
            this.textBox_Dept.Location = new System.Drawing.Point(66, 156);
            this.textBox_Dept.Name = "textBox_Dept";
            this.textBox_Dept.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dept.TabIndex = 6;
            this.textBox_Dept.Text = "none";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dept.";
            // 
            // textBox_Role
            // 
            this.textBox_Role.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Role.Location = new System.Drawing.Point(66, 128);
            this.textBox_Role.Name = "textBox_Role";
            this.textBox_Role.ReadOnly = true;
            this.textBox_Role.Size = new System.Drawing.Size(100, 20);
            this.textBox_Role.TabIndex = 4;
            this.textBox_Role.Text = "guest";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Role";
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(50, 79);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(117, 43);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Login to Version 4.3";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(66, 53);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.Text = "000\\guest";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(66, 21);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserID.TabIndex = 0;
            this.textBox_UserID.Text = "guest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "User ID";
            // 
            // button_ClientTraining
            // 
            this.button_ClientTraining.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ClientTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClientTraining.Location = new System.Drawing.Point(711, 176);
            this.button_ClientTraining.Name = "button_ClientTraining";
            this.button_ClientTraining.Size = new System.Drawing.Size(146, 69);
            this.button_ClientTraining.TabIndex = 19;
            this.button_ClientTraining.Text = "Operations";
            this.button_ClientTraining.UseVisualStyleBackColor = false;
            this.button_ClientTraining.Click += new System.EventHandler(this.button_Operations_Click);
            // 
            // button_HR
            // 
            this.button_HR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_HR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HR.Location = new System.Drawing.Point(711, 295);
            this.button_HR.Name = "button_HR";
            this.button_HR.Size = new System.Drawing.Size(146, 65);
            this.button_HR.TabIndex = 20;
            this.button_HR.Text = "Human Resources";
            this.button_HR.UseVisualStyleBackColor = false;
            this.button_HR.Click += new System.EventHandler(this.button_HR_Click);
            // 
            // button_SearchDataSources
            // 
            this.button_SearchDataSources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.button_SearchDataSources.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchDataSources.Location = new System.Drawing.Point(32, 318);
            this.button_SearchDataSources.Name = "button_SearchDataSources";
            this.button_SearchDataSources.Size = new System.Drawing.Size(132, 53);
            this.button_SearchDataSources.TabIndex = 5;
            this.button_SearchDataSources.Text = "Search Data Sources";
            this.button_SearchDataSources.UseVisualStyleBackColor = false;
            this.button_SearchDataSources.Click += new System.EventHandler(this.button_SearchDataSources_Click);
            // 
            // button_Accounting
            // 
            this.button_Accounting.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Accounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Accounting.Location = new System.Drawing.Point(477, 295);
            this.button_Accounting.Name = "button_Accounting";
            this.button_Accounting.Size = new System.Drawing.Size(146, 69);
            this.button_Accounting.TabIndex = 21;
            this.button_Accounting.Text = "Accounting and Finance";
            this.button_Accounting.UseVisualStyleBackColor = false;
            this.button_Accounting.Click += new System.EventHandler(this.button_Accounting_Click);
            // 
            // button_Utilities
            // 
            this.button_Utilities.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Utilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Utilities.Location = new System.Drawing.Point(477, 425);
            this.button_Utilities.Name = "button_Utilities";
            this.button_Utilities.Size = new System.Drawing.Size(146, 82);
            this.button_Utilities.TabIndex = 22;
            this.button_Utilities.Text = "Infrastructure /  Utilities";
            this.button_Utilities.UseVisualStyleBackColor = false;
            this.button_Utilities.Click += new System.EventHandler(this.button_Utilities_Click);
            // 
            // radioButton_Access
            // 
            this.radioButton_Access.AutoSize = true;
            this.radioButton_Access.Checked = true;
            this.radioButton_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Access.Location = new System.Drawing.Point(31, 397);
            this.radioButton_Access.Name = "radioButton_Access";
            this.radioButton_Access.Size = new System.Drawing.Size(134, 19);
            this.radioButton_Access.TabIndex = 6;
            this.radioButton_Access.TabStop = true;
            this.radioButton_Access.Text = "Access Database";
            this.radioButton_Access.UseVisualStyleBackColor = true;
            // 
            // radioButton_MS_SQL
            // 
            this.radioButton_MS_SQL.AutoSize = true;
            this.radioButton_MS_SQL.Enabled = false;
            this.radioButton_MS_SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_MS_SQL.Location = new System.Drawing.Point(32, 431);
            this.radioButton_MS_SQL.Name = "radioButton_MS_SQL";
            this.radioButton_MS_SQL.Size = new System.Drawing.Size(129, 17);
            this.radioButton_MS_SQL.TabIndex = 7;
            this.radioButton_MS_SQL.Text = "MS SQL Database";
            this.radioButton_MS_SQL.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 640);
            this.Controls.Add(this.button_Utilities);
            this.Controls.Add(this.button_Accounting);
            this.Controls.Add(this.button_HR);
            this.Controls.Add(this.button_ClientTraining);
            this.Controls.Add(this.button_Marketing);
            this.Controls.Add(this.button_Materials);
            this.Controls.Add(this.button_Payroll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HAWK 3.1 Main Page";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.button_Payroll, 0);
            this.Controls.SetChildIndex(this.button_Materials, 0);
            this.Controls.SetChildIndex(this.button_Marketing, 0);
            this.Controls.SetChildIndex(this.button_ClientTraining, 0);
            this.Controls.SetChildIndex(this.button_HR, 0);
            this.Controls.SetChildIndex(this.button_Accounting, 0);
            this.Controls.SetChildIndex(this.button_Utilities, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this._panel2_LeftControlPanel.PerformLayout();
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label4;
      //  private System.Windows.Forms.GroupBox groupBox2;
      //  private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Payroll;
        private System.Windows.Forms.Button button_Materials;
        private System.Windows.Forms.Button button_Marketing;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_Dept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_ClientTraining;
        private System.Windows.Forms.Button button_HR;
        private System.Windows.Forms.Button button_SearchDataSources;
        private System.Windows.Forms.Button button_Accounting;
        private System.Windows.Forms.Button button_Utilities;
        public System.Windows.Forms.RadioButton radioButton_MS_SQL;
        public System.Windows.Forms.RadioButton radioButton_Access;

    }
