namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class DisplaySelectedObject
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
            this.btnDisplayFormatted = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DocType
            // 
            this.label_DocType.Location = new System.Drawing.Point(225, 229);
            this.label_DocType.Size = new System.Drawing.Size(54, 13);
            this.label_DocType.Text = "Doc Type";
            // 
            // label_DocNumber
            // 
            this.label_DocNumber.Location = new System.Drawing.Point(225, 202);
            this.label_DocNumber.Size = new System.Drawing.Size(67, 13);
            this.label_DocNumber.Text = "Doc Number";
            // 
            // label1_TableName
            // 
            this.label1_TableName.Location = new System.Drawing.Point(225, 174);
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Size = new System.Drawing.Size(95, 20);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Size = new System.Drawing.Size(96, 20);
            // 
            // label5
            // 
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.Text = "Total Amount";
            // 
            // textBox_TextValue1
            // 
            this.textBox_TextValue1.Location = new System.Drawing.Point(117, 56);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.Text = "Last Paid Date";
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(117, 19);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 22);
            // 
            // textBox_TextValue2
            // 
            this.textBox_TextValue2.Location = new System.Drawing.Point(117, 94);
            this.textBox_TextValue2.Size = new System.Drawing.Size(96, 20);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 97);
            this.label7.Text = "Last Status Date";
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.Text = "Last Paid Amount";
            // 
            // label9
            // 
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.Text = "Current Balance";
            // 
            // label_IntAgent
            // 
            this.label_IntAgent.Location = new System.Drawing.Point(225, 297);
            this.label_IntAgent.Size = new System.Drawing.Size(67, 13);
            this.label_IntAgent.Text = "Employee ID";
            // 
            // label_ExtAgent
            // 
            this.label_ExtAgent.Location = new System.Drawing.Point(225, 262);
            this.label_ExtAgent.Size = new System.Drawing.Size(65, 13);
            this.label_ExtAgent.Text = "Customer ID";
            // 
            // label16
            // 
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.Text = "Comments";
            // 
            // btnDisplayFormatted
            // 
            this.btnDisplayFormatted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayFormatted.Location = new System.Drawing.Point(938, 174);
            this.btnDisplayFormatted.Name = "btnDisplayFormatted";
            this.btnDisplayFormatted.Size = new System.Drawing.Size(107, 59);
            this.btnDisplayFormatted.TabIndex = 42;
            this.btnDisplayFormatted.Text = "Display Formatted Document";
            this.btnDisplayFormatted.UseVisualStyleBackColor = true;
            this.btnDisplayFormatted.Click += new System.EventHandler(this.btnDisplayFormatted_Click);
            // 
            // DisplaySelectedObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 677);
            this.Controls.Add(this.btnDisplayFormatted);
            this.Name = "DisplaySelectedObject";
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
            this.Controls.SetChildIndex(this.btnDisplayFormatted, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayFormatted;
    }
}
