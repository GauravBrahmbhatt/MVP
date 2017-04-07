namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class FormattedDataDisplay
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qunatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbox_DataStrings = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DocNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Location = new System.Drawing.Point(526, 149);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(363, 158);
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.Size = new System.Drawing.Size(14, 21);
            this.comboBox_TableName.Visible = false;
            // 
            // textBox_ExternalRef
            // 
            this.textBox_ExternalRef.Location = new System.Drawing.Point(363, 200);
            // 
            // comboBox1
            // 
            this.comboBox1.Size = new System.Drawing.Size(10, 21);
            this.comboBox1.Visible = false;
            // 
            // textBox_InternalRef
            // 
            this.textBox_InternalRef.Location = new System.Drawing.Point(363, 232);
            this.textBox_InternalRef.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Size = new System.Drawing.Size(10, 21);
            this.comboBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.Visible = false;
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(537, 243);
            this.button_Display.Text = "Display Document";
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(702, 250);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(228, 28);
            this.label_SubName.Text = " Receivable Documents";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comments,
            this.Qunatity,
            this.Rate,
            this.TotalValue});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(204, 361);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 150);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Description";
            this.Comments.Name = "Comments";
            // 
            // Qunatity
            // 
            this.Qunatity.HeaderText = "Quantity";
            this.Qunatity.Name = "Qunatity";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // TotalValue
            // 
            this.TotalValue.HeaderText = "TotalValue";
            this.TotalValue.Name = "TotalValue";
            // 
            // textbox_DataStrings
            // 
            this.textbox_DataStrings.Location = new System.Drawing.Point(702, 361);
            this.textbox_DataStrings.Name = "textbox_DataStrings";
            this.textbox_DataStrings.Size = new System.Drawing.Size(375, 96);
            this.textbox_DataStrings.TabIndex = 20;
            this.textbox_DataStrings.Text = "";
            this.textbox_DataStrings.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Doc Num";
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Location = new System.Drawing.Point(361, 266);
            this.textBox_DocNum.Name = "textBox_DocNum";
            this.textBox_DocNum.Size = new System.Drawing.Size(114, 20);
            this.textBox_DocNum.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(839, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "Show/Hide Raw Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_RawData_Click);
            // 
            // FormattedDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1168, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_DocNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_DataStrings);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormattedDataDisplay";
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
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.textbox_DataStrings, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qunatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
        protected System.Windows.Forms.DataGridView dataGridView2;
        protected System.Windows.Forms.RichTextBox textbox_DataStrings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DocNum;
        private System.Windows.Forms.Button button1;
    }
}
