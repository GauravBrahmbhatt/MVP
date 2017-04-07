namespace Utilities.Employees
//namespace Infrastructure
{
    partial class Employees_List
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.textBox_CMD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_Display = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TopPanel
            // 
            this.panel_TopPanel.BackColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "any department",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(289, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.Location = new System.Drawing.Point(481, 158);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(150, 20);
            this.textBox_Supplier.TabIndex = 4;
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Location = new System.Drawing.Point(652, 155);
            this.textBox_CMD.Multiline = true;
            this.textBox_CMD.Name = "textBox_CMD";
            this.textBox_CMD.Size = new System.Drawing.Size(254, 104);
            this.textBox_CMD.TabIndex = 5;
            this.textBox_CMD.Text = "select * from Employees";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 244);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(483, 194);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(150, 20);
            this.textBox_Status.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "any role",
            "Sales",
            "Agent",
            "Supervisor",
            "Manager",
            "Executive"});
            this.comboBox2.Location = new System.Drawing.Point(291, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button_Display
            // 
            this.button_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Display.Location = new System.Drawing.Point(489, 224);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(103, 38);
            this.button_Display.TabIndex = 11;
            this.button_Display.Text = "Display";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // Employees_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 650);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_CMD);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "Employees_List";
            this.Text = "List of Employees";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox_Supplier, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.textBox_Status, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.TextBox textBox_CMD;
      //  private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button_Display;
      //  private System.Windows.Forms.Label label3;
    }
}

