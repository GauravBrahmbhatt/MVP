namespace Utilities.Documents
{
    partial class DisplayCompressedFormat
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
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_RawData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_Description);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(436, 149);
            this.panel1.Visible = false;
            this.panel1.Controls.SetChildIndex(this.textBox_TextValue1, 0);
            this.panel1.Controls.SetChildIndex(this.textBox_Status, 0);
            this.panel1.Controls.SetChildIndex(this.textBox_ProcessID, 0);
            this.panel1.Controls.SetChildIndex(this.textBox_IntAgent, 0);
            this.panel1.Controls.SetChildIndex(this.textBox_ExtAgent, 0);
            this.panel1.Controls.SetChildIndex(this.textBox_TextValue2, 0);
            this.panel1.Controls.SetChildIndex(this.textBox_NumValue1, 0);
            this.panel1.Controls.SetChildIndex(this.textBox_NumValue2, 0);
            this.panel1.Controls.SetChildIndex(this.label7, 0);
            this.panel1.Controls.SetChildIndex(this.label_IntAgent, 0);
            this.panel1.Controls.SetChildIndex(this.label_ExtAgent, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.textBox_Description, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Location = new System.Drawing.Point(671, 246);
            this.textBox_Cmd.Size = new System.Drawing.Size(239, 62);
            this.textBox_Cmd.Text = " select * from  ";
            // 
            // label_ProcNum
            // 
            this.label_ProcNum.Size = new System.Drawing.Size(37, 13);
            this.label_ProcNum.Text = "Status";
            // 
            // textBox_ProcessID
            // 
            this.textBox_ProcessID.Location = new System.Drawing.Point(128, 90);
            // 
            // textBox_TextValue1
            // 
            this.textBox_TextValue1.Location = new System.Drawing.Point(325, 6);
            // 
            // label_TextValue1
            // 
            this.label_TextValue1.Location = new System.Drawing.Point(244, 13);
            this.label_TextValue1.Size = new System.Drawing.Size(67, 13);
            this.label_TextValue1.Text = "Text Value 1";
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(127, 63);
            // 
            // label7
            // 
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.Text = "Process ID";
            // 
            // textBox_TextValue2
            // 
            this.textBox_TextValue2.Location = new System.Drawing.Point(328, 36);
            // 
            // textBox_NumValue1
            // 
            this.textBox_NumValue1.Location = new System.Drawing.Point(326, 62);
            // 
            // textBox_NumValue2
            // 
            this.textBox_NumValue2.Location = new System.Drawing.Point(328, 91);
            // 
            // button_DisplayDoc
            // 
            this.button_DisplayDoc.Click += new System.EventHandler(this.button_DisplayDoc_Click);
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(345, 405);
            this.textBox_Comment.Size = new System.Drawing.Size(290, 20);
            // 
            // textBox_DataStrings
            // 
            this.textBox_DataStrings.Location = new System.Drawing.Point(687, 402);
            this.textBox_DataStrings.Size = new System.Drawing.Size(359, 164);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(259, 408);
            // 
            // label_UserID
            // 
            this.label_UserID.Location = new System.Drawing.Point(891, 102);
            // 
            // label_UserPre
            // 
            this.label_UserPre.Location = new System.Drawing.Point(853, 102);
            // 
            // label_UserName
            // 
            this.label_UserName.Location = new System.Drawing.Point(937, 102);
            // 
            // label_Connector
            // 
            this.label_Connector.Location = new System.Drawing.Point(922, 102);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(199, 28);
            this.label_SubName.Text = "Selected Documents";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Quantity,
            this.Rate,
            this.Est_Value});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(186, 402);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(487, 252);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Description
            // 
            this.Description.FillWeight = 175F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 175;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 80F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Rate
            // 
            this.Rate.FillWeight = 80F;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Width = 80;
            // 
            // Est_Value
            // 
            this.Est_Value.HeaderText = "Est. Value";
            this.Est_Value.Name = "Est_Value";
            // 
            // button_RawData
            // 
            this.button_RawData.Location = new System.Drawing.Point(826, 323);
            this.button_RawData.Name = "button_RawData";
            this.button_RawData.Size = new System.Drawing.Size(84, 42);
            this.button_RawData.TabIndex = 43;
            this.button_RawData.Text = "Display / Hide Raw Data";
            this.button_RawData.UseVisualStyleBackColor = true;
            this.button_RawData.Click += new System.EventHandler(this.button_RawData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Text Value 2";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(131, 119);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(289, 20);
            this.textBox_Description.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quoted Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Actual Value";
            // 
            // DisplayCompressedFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1058, 677);
            this.Controls.Add(this.button_RawData);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DisplayCompressedFormat";
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label_DocType, 0);
            this.Controls.SetChildIndex(this.label_DocNumber, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1_TableName, 0);
            this.Controls.SetChildIndex(this.button_ChangeDoc, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_DisplayDoc, 0);
            this.Controls.SetChildIndex(this.textBox_Cmd, 0);
            this.Controls.SetChildIndex(this.textBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
         //   this.Controls.SetChildIndex(this.button_LoadSelectionList, 0);
            this.Controls.SetChildIndex(this.button_ResetCommand, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.button_RawData, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

        protected System.Windows.Forms.Label label_description;
        protected System.Windows.Forms.Label label_TextValue1;
        protected System.Windows.Forms.Label label_ProcNum;
        protected System.Windows.Forms.Button button_RawData;
        protected System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox textBox_Description;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Est_Value;
    }
}
