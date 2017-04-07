namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class FormatDisplay
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
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_RawData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Size = new System.Drawing.Size(414, 60);
            // 
            // button_DisplayDoc
            // 
            this.button_DisplayDoc.Click += new System.EventHandler(this.button_DisplayDoc_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comments,
            this.Quantity,
            this.Rate,
            this.TotalValue});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(502, 519);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(433, 146);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Description";
            this.Comments.Name = "Comments";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // TotalValue
            // 
            this.TotalValue.HeaderText = "Total Value";
            this.TotalValue.Name = "TotalValue";
            // 
            // button_RawData
            // 
            this.button_RawData.Location = new System.Drawing.Point(941, 174);
            this.button_RawData.Name = "button_RawData";
            this.button_RawData.Size = new System.Drawing.Size(75, 59);
            this.button_RawData.TabIndex = 43;
            this.button_RawData.Text = "Display Formatted Data";
            this.button_RawData.UseVisualStyleBackColor = true;
            this.button_RawData.Click += new System.EventHandler(this.button_RawData_Click);
            // 
            // FormatDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 677);
            this.Controls.Add(this.button_RawData);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormatDisplay";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.label_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label_DocNumber, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_DisplayDoc, 0);
            this.Controls.SetChildIndex(this.textBox_Cmd, 0);
            this.Controls.SetChildIndex(this.textBox_ExtAgent, 0);
            this.Controls.SetChildIndex(this.textBox_IntAgent, 0);
            this.Controls.SetChildIndex(this.textBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.button_ResetLabels, 0);
            this.Controls.SetChildIndex(this.button_ResetCommand, 0);
            this.Controls.SetChildIndex(this.button_ChangeDoc, 0);
            this.Controls.SetChildIndex(this.label_ExtAgent, 0);
            this.Controls.SetChildIndex(this.label_IntAgent, 0);
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

        protected System.Windows.Forms.DataGridView dataGridView2;
        protected System.Windows.Forms.Button button_RawData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;

    }
}
