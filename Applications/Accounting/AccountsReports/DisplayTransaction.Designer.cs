namespace Applications.Applications.Accounting.AccountsReports
{
    partial class DisplayTransaction
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
            this.textBox_DocType = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.textBox_StatusDate = new System.Windows.Forms.TextBox();
            this.textBox_CreditAmount = new System.Windows.Forms.TextBox();
            this.textBox_TrDate = new System.Windows.Forms.TextBox();
            this.textBox_DebitAmount = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_DocNum = new System.Windows.Forms.TextBox();
            this.comboBox_SelectedTrans = new System.Windows.Forms.ComboBox();
            this.textBox_Display = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_table = new System.Windows.Forms.TextBox();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Text = "Transactions";
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.SelectedIndexChanged += new System.EventHandler(this.comboBox_TableName_SelectedIndexChanged);
            this.comboBox_TableName.Click += new System.EventHandler(this.comboBox_TableName_SelectedIndexChanged);
            // 
            // button_Display
            // 
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(85, 28);
            this.label_SubName.Text = "Reports";
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Location = new System.Drawing.Point(309, 299);
            this.textBox_DocType.Name = "textBox_DocType";
            this.textBox_DocType.Size = new System.Drawing.Size(100, 20);
            this.textBox_DocType.TabIndex = 19;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(547, 299);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(100, 20);
            this.textBox_Status.TabIndex = 20;
            // 
            // textBox_StatusDate
            // 
            this.textBox_StatusDate.Location = new System.Drawing.Point(547, 346);
            this.textBox_StatusDate.Name = "textBox_StatusDate";
            this.textBox_StatusDate.Size = new System.Drawing.Size(100, 20);
            this.textBox_StatusDate.TabIndex = 21;
            // 
            // textBox_CreditAmount
            // 
            this.textBox_CreditAmount.Location = new System.Drawing.Point(547, 397);
            this.textBox_CreditAmount.Name = "textBox_CreditAmount";
            this.textBox_CreditAmount.Size = new System.Drawing.Size(100, 20);
            this.textBox_CreditAmount.TabIndex = 22;
            // 
            // textBox_TrDate
            // 
            this.textBox_TrDate.Location = new System.Drawing.Point(309, 355);
            this.textBox_TrDate.Name = "textBox_TrDate";
            this.textBox_TrDate.Size = new System.Drawing.Size(100, 20);
            this.textBox_TrDate.TabIndex = 23;
            // 
            // textBox_DebitAmount
            // 
            this.textBox_DebitAmount.Location = new System.Drawing.Point(309, 397);
            this.textBox_DebitAmount.Name = "textBox_DebitAmount";
            this.textBox_DebitAmount.Size = new System.Drawing.Size(100, 20);
            this.textBox_DebitAmount.TabIndex = 24;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(309, 456);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(338, 20);
            this.textBox_Description.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Internal Ref.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Transaction Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Debit Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Transaction Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Status Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Credit Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 34;
            this.button1.Text = "Reset Command";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 44);
            this.button2.TabIndex = 35;
            this.button2.Text = "Display Raw Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 49);
            this.button3.TabIndex = 36;
            this.button3.Text = "Display Single Transaction";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(864, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 49);
            this.button4.TabIndex = 37;
            this.button4.Text = "Display Multiple Transactions";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(206, 505);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(938, 132);
            this.listBox1.TabIndex = 38;
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Location = new System.Drawing.Point(248, 266);
            this.textBox_DocNum.Name = "textBox_DocNum";
            this.textBox_DocNum.Size = new System.Drawing.Size(100, 20);
            this.textBox_DocNum.TabIndex = 39;
            this.textBox_DocNum.Visible = false;
            // 
            // comboBox_SelectedTrans
            // 
            this.comboBox_SelectedTrans.FormattingEnabled = true;
            this.comboBox_SelectedTrans.Location = new System.Drawing.Point(514, 265);
            this.comboBox_SelectedTrans.Name = "comboBox_SelectedTrans";
            this.comboBox_SelectedTrans.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SelectedTrans.TabIndex = 40;
            this.comboBox_SelectedTrans.Visible = false;
            // 
            // textBox_Display
            // 
            this.textBox_Display.Location = new System.Drawing.Point(378, 266);
            this.textBox_Display.Name = "textBox_Display";
            this.textBox_Display.Size = new System.Drawing.Size(100, 20);
            this.textBox_Display.TabIndex = 41;
            this.textBox_Display.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1016, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(78, 124);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.Visible = false;
            // 
            // txt_table
            // 
            this.txt_table.Location = new System.Drawing.Point(690, 265);
            this.txt_table.Name = "txt_table";
            this.txt_table.Size = new System.Drawing.Size(100, 20);
            this.txt_table.TabIndex = 43;
            this.txt_table.Text = "Transactions";
            this.txt_table.Visible = false;
            // 
            // DisplayTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1168, 650);
            this.Controls.Add(this.txt_table);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Display);
            this.Controls.Add(this.comboBox_SelectedTrans);
            this.Controls.Add(this.textBox_DocNum);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_DebitAmount);
            this.Controls.Add(this.textBox_TrDate);
            this.Controls.Add(this.textBox_CreditAmount);
            this.Controls.Add(this.textBox_StatusDate);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.textBox_DocType);
            this.Name = "DisplayTransaction";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.comboBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.label_3, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox_ExternalRef, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.textBox_InternalRef, 0);
            this.Controls.SetChildIndex(this.button_Reset, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_Status, 0);
            this.Controls.SetChildIndex(this.textBox_StatusDate, 0);
            this.Controls.SetChildIndex(this.textBox_CreditAmount, 0);
            this.Controls.SetChildIndex(this.textBox_TrDate, 0);
            this.Controls.SetChildIndex(this.textBox_DebitAmount, 0);
            this.Controls.SetChildIndex(this.textBox_Description, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.comboBox_SelectedTrans, 0);
            this.Controls.SetChildIndex(this.textBox_Display, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txt_table, 0);
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

        private System.Windows.Forms.TextBox textBox_DocType;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.TextBox textBox_StatusDate;
        private System.Windows.Forms.TextBox textBox_CreditAmount;
        private System.Windows.Forms.TextBox textBox_TrDate;
        private System.Windows.Forms.TextBox textBox_DebitAmount;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_DocNum;
        private System.Windows.Forms.ComboBox comboBox_SelectedTrans;
        private System.Windows.Forms.TextBox textBox_Display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_table;
    }
}
