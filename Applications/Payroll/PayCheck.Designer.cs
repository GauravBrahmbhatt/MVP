namespace Applications.Applications.Payroll
{
    partial class PayCheck
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.heading2 = new System.Windows.Forms.Label();
            this.heading1 = new System.Windows.Forms.Label();
            this.heading3 = new System.Windows.Forms.Label();
            this.heading4 = new System.Windows.Forms.Label();
            this.heading5 = new System.Windows.Forms.Label();
            this.heading6 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.Label();
            this.value3 = new System.Windows.Forms.Label();
            this.value4 = new System.Windows.Forms.Label();
            this.value5 = new System.Windows.Forms.Label();
            this.value6 = new System.Windows.Forms.Label();
            this.employeesAdmin = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(202, 28);
            this.label_SubName.Text = "Pay Slip Generation";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(178, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 108);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Pay Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "hello";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(599, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 709);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // heading2
            // 
            this.heading2.AutoSize = true;
            this.heading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading2.Location = new System.Drawing.Point(208, 481);
            this.heading2.Name = "heading2";
            this.heading2.Size = new System.Drawing.Size(141, 17);
            this.heading2.TabIndex = 12;
            this.heading2.Text = "Hourly Pay Rate : ";
            this.heading2.Visible = false;
            // 
            // heading1
            // 
            this.heading1.AutoSize = true;
            this.heading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading1.Location = new System.Drawing.Point(208, 445);
            this.heading1.Name = "heading1";
            this.heading1.Size = new System.Drawing.Size(113, 17);
            this.heading1.TabIndex = 14;
            this.heading1.Text = "Employee ID : ";
            this.heading1.Visible = false;
            // 
            // heading3
            // 
            this.heading3.AutoSize = true;
            this.heading3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading3.Location = new System.Drawing.Point(208, 519);
            this.heading3.Name = "heading3";
            this.heading3.Size = new System.Drawing.Size(211, 17);
            this.heading3.TabIndex = 15;
            this.heading3.Text = "Overtime Hourly Pay Rate : ";
            this.heading3.Visible = false;
            // 
            // heading4
            // 
            this.heading4.AutoSize = true;
            this.heading4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading4.Location = new System.Drawing.Point(208, 554);
            this.heading4.Name = "heading4";
            this.heading4.Size = new System.Drawing.Size(172, 17);
            this.heading4.TabIndex = 16;
            this.heading4.Text = "No of Regular Hours : ";
            this.heading4.Visible = false;
            // 
            // heading5
            // 
            this.heading5.AutoSize = true;
            this.heading5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading5.Location = new System.Drawing.Point(208, 589);
            this.heading5.Name = "heading5";
            this.heading5.Size = new System.Drawing.Size(180, 17);
            this.heading5.TabIndex = 17;
            this.heading5.Text = "No of Overtime Hours : ";
            this.heading5.Visible = false;
            // 
            // heading6
            // 
            this.heading6.AutoSize = true;
            this.heading6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading6.Location = new System.Drawing.Point(208, 627);
            this.heading6.Name = "heading6";
            this.heading6.Size = new System.Drawing.Size(103, 17);
            this.heading6.TabIndex = 18;
            this.heading6.Text = "Gross Pay  : ";
            this.heading6.Visible = false;
            // 
            // value1
            // 
            this.value1.AutoSize = true;
            this.value1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1.Location = new System.Drawing.Point(444, 445);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(115, 19);
            this.value1.TabIndex = 19;
            this.value1.Text = "Employee ID : ";
            this.value1.Visible = false;
            this.value1.Click += new System.EventHandler(this.label8_Click);
            // 
            // value2
            // 
            this.value2.AutoSize = true;
            this.value2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2.Location = new System.Drawing.Point(444, 481);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(115, 19);
            this.value2.TabIndex = 20;
            this.value2.Text = "Employee ID : ";
            this.value2.Visible = false;
            // 
            // value3
            // 
            this.value3.AutoSize = true;
            this.value3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value3.Location = new System.Drawing.Point(444, 519);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(115, 19);
            this.value3.TabIndex = 21;
            this.value3.Text = "Employee ID : ";
            this.value3.Visible = false;
            // 
            // value4
            // 
            this.value4.AutoSize = true;
            this.value4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value4.Location = new System.Drawing.Point(444, 554);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(115, 19);
            this.value4.TabIndex = 22;
            this.value4.Text = "Employee ID : ";
            this.value4.Visible = false;
            // 
            // value5
            // 
            this.value5.AutoSize = true;
            this.value5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value5.Location = new System.Drawing.Point(444, 589);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(115, 19);
            this.value5.TabIndex = 23;
            this.value5.Text = "Employee ID : ";
            this.value5.Visible = false;
            // 
            // value6
            // 
            this.value6.AutoSize = true;
            this.value6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value6.Location = new System.Drawing.Point(444, 627);
            this.value6.Name = "value6";
            this.value6.Size = new System.Drawing.Size(115, 19);
            this.value6.TabIndex = 24;
            this.value6.Text = "Employee ID : ";
            this.value6.Visible = false;
            // 
            // employeesAdmin
            // 
            this.employeesAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.employeesAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeesAdmin.FormattingEnabled = true;
            this.employeesAdmin.Location = new System.Drawing.Point(427, 346);
            this.employeesAdmin.Name = "employeesAdmin";
            this.employeesAdmin.Size = new System.Drawing.Size(147, 21);
            this.employeesAdmin.TabIndex = 25;
            this.employeesAdmin.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Applications.Properties.Resources.paycheck;
            this.pictureBox3.Location = new System.Drawing.Point(599, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(348, 526);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // PayCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(959, 663);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.employeesAdmin);
            this.Controls.Add(this.value6);
            this.Controls.Add(this.value5);
            this.Controls.Add(this.value4);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.heading6);
            this.Controls.Add(this.heading5);
            this.Controls.Add(this.heading4);
            this.Controls.Add(this.heading3);
            this.Controls.Add(this.heading1);
            this.Controls.Add(this.heading2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "PayCheck";
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.heading2, 0);
            this.Controls.SetChildIndex(this.heading1, 0);
            this.Controls.SetChildIndex(this.heading3, 0);
            this.Controls.SetChildIndex(this.heading4, 0);
            this.Controls.SetChildIndex(this.heading5, 0);
            this.Controls.SetChildIndex(this.heading6, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.value1, 0);
            this.Controls.SetChildIndex(this.value2, 0);
            this.Controls.SetChildIndex(this.value3, 0);
            this.Controls.SetChildIndex(this.value4, 0);
            this.Controls.SetChildIndex(this.value5, 0);
            this.Controls.SetChildIndex(this.value6, 0);
            this.Controls.SetChildIndex(this.employeesAdmin, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label heading2;
        private System.Windows.Forms.Label heading1;
        private System.Windows.Forms.Label heading3;
        private System.Windows.Forms.Label heading4;
        private System.Windows.Forms.Label heading5;
        private System.Windows.Forms.Label heading6;
        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Label value3;
        private System.Windows.Forms.Label value4;
        private System.Windows.Forms.Label value5;
        private System.Windows.Forms.Label value6;
        private System.Windows.Forms.ComboBox employeesAdmin;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}