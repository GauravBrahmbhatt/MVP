namespace UtilityFunctions
{
    partial class ListEntities
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
            this.textBox_CMD = new System.Windows.Forms.TextBox();
            this.button_Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_TableName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(136, 28);
            this.label_SubName.Text = "List Entities";
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Location = new System.Drawing.Point(346, 209);
            this.textBox_CMD.Name = "textBox_CMD";
            this.textBox_CMD.Size = new System.Drawing.Size(263, 20);
            this.textBox_CMD.TabIndex = 0;
            this.textBox_CMD.Text = "select  * from Employees";
            // 
            // button_Display
            // 
            this.button_Display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Display.Location = new System.Drawing.Point(705, 175);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(95, 54);
            this.button_Display.TabIndex = 0;
            this.button_Display.Text = "Display";
            this.button_Display.UseVisualStyleBackColor = false;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(188, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(509, 175);
            this.textBox_TableName.Name = "textBox_TableName";
            this.textBox_TableName.Size = new System.Drawing.Size(100, 20);
            this.textBox_TableName.TabIndex = 0;
            this.textBox_TableName.Text = "Employees";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0,  Select Entity Type",
            "1,  Customer_Applicants",
            "2,  Customers",
            "3,  Employees",
            "4,  Applicants_Jobs",
            "5,  Suppliers",
            "6,  Materials",
            "7,  Services"});
            this.comboBox1.Location = new System.Drawing.Point(346, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Entity Type";
            // 
            // ListEntities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1168, 650);
            this.Controls.Add(this.textBox_CMD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.textBox_TableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ListEntities";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //private System.Windows.Forms.Label label3;
        //protected System.Windows.Forms.TextBox textBox_CMD;
        //protected System.Windows.Forms.DataGridView dataGridView1;
        //protected System.Windows.Forms.TextBox textBox_TableName;
        //protected System.Windows.Forms.ComboBox comboBox_TableName;
        //protected System.Windows.Forms.Button button_Display;
    
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Display;
        protected System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.TextBox textBox_TableName;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.TextBox textBox_CMD;
    }
}
