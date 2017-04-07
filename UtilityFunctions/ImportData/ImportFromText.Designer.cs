namespace UtilityFunctions
{
    partial class ImportFromText
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
            this.button_FindFile = new System.Windows.Forms.Button();
            this.button_Convert = new System.Windows.Forms.Button();
            this.textBox_CSV_Data = new System.Windows.Forms.TextBox();
            this.button_SaveData = new System.Windows.Forms.Button();
            this.comboBox_Data = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Size = new System.Drawing.Size(466, 45);
            this.textBox_CMD.Text = "  app_Data\\ Update_Payables.txt";
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Text = "Update_Payables.txt";
            // 
            // textBox_ExternalRef
            // 
            this.textBox_ExternalRef.Location = new System.Drawing.Point(49, 746);
            this.textBox_ExternalRef.Size = new System.Drawing.Size(20, 20);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(26, 745);
            this.comboBox1.Size = new System.Drawing.Size(17, 21);
            // 
            // label_3
            // 
            this.label_3.Text = "   File Path";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.Text = "Conversion";
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(839, 197);
            this.button_Display.Size = new System.Drawing.Size(118, 63);
            this.button_Display.Text = "Display Data";
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(1142, 145);
            this.button_Reset.Size = new System.Drawing.Size(63, 41);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(274, 28);
            this.label_SubName.Text = "Import Data from Text File";
            // 
            // button_FindFile
            // 
            this.button_FindFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FindFile.Location = new System.Drawing.Point(685, 197);
            this.button_FindFile.Name = "button_FindFile";
            this.button_FindFile.Size = new System.Drawing.Size(123, 58);
            this.button_FindFile.TabIndex = 19;
            this.button_FindFile.Text = "Find Text File";
            this.button_FindFile.UseVisualStyleBackColor = true;
            this.button_FindFile.Click += new System.EventHandler(this.button_FindFile_Click);
            // 
            // button_Convert
            // 
            this.button_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Convert.Location = new System.Drawing.Point(979, 198);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(105, 58);
            this.button_Convert.TabIndex = 20;
            this.button_Convert.Text = "Convert Data";
            this.button_Convert.UseVisualStyleBackColor = true;
            // 
            // textBox_CSV_Data
            // 
            this.textBox_CSV_Data.Location = new System.Drawing.Point(228, 291);
            this.textBox_CSV_Data.Multiline = true;
            this.textBox_CSV_Data.Name = "textBox_CSV_Data";
            this.textBox_CSV_Data.Size = new System.Drawing.Size(953, 207);
            this.textBox_CSV_Data.TabIndex = 21;
            // 
            // button_SaveData
            // 
            this.button_SaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveData.Location = new System.Drawing.Point(1109, 197);
            this.button_SaveData.Name = "button_SaveData";
            this.button_SaveData.Size = new System.Drawing.Size(96, 58);
            this.button_SaveData.TabIndex = 22;
            this.button_SaveData.Text = "  Save    Data";
            this.button_SaveData.UseVisualStyleBackColor = true;
            // 
            // comboBox_Data
            // 
            this.comboBox_Data.FormattingEnabled = true;
            this.comboBox_Data.Location = new System.Drawing.Point(233, 527);
            this.comboBox_Data.Name = "comboBox_Data";
            this.comboBox_Data.Size = new System.Drawing.Size(946, 21);
            this.comboBox_Data.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 574);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 174);
            this.dataGridView1.TabIndex = 24;
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(293, 192);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(339, 20);
            this.textBox_FilePath.TabIndex = 25;
            this.textBox_FilePath.Text = "App_data";
            // 
            // ImportFromText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1233, 788);
            this.Controls.Add(this.textBox_FilePath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Data);
            this.Controls.Add(this.button_SaveData);
            this.Controls.Add(this.textBox_CSV_Data);
            this.Controls.Add(this.button_Convert);
            this.Controls.Add(this.button_FindFile);
            this.Name = "ImportFromText";
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
            this.Controls.SetChildIndex(this.button_FindFile, 0);
            this.Controls.SetChildIndex(this.button_Convert, 0);
            this.Controls.SetChildIndex(this.textBox_CSV_Data, 0);
            this.Controls.SetChildIndex(this.button_SaveData, 0);
            this.Controls.SetChildIndex(this.comboBox_Data, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.textBox_FilePath, 0);
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

        private System.Windows.Forms.Button button_FindFile;
        private System.Windows.Forms.Button button_Convert;
        private System.Windows.Forms.TextBox textBox_CSV_Data;
        private System.Windows.Forms.Button button_SaveData;
        private System.Windows.Forms.ComboBox comboBox_Data;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_FilePath;
    }
}
