namespace Applications.Applications.Accounting.AccountsPayable
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ChangeDoc
            // 
            this.button_ChangeDoc.Click += new System.EventHandler(this.button_ChangeDoc_Click);
            // 
            // label_SubName
            // 
            this.label_SubName.Location = new System.Drawing.Point(370, 77);
            this.label_SubName.Size = new System.Drawing.Size(267, 28);
            this.label_SubName.Text = " Accounts Payable  Details";
            this.label_SubName.Click += new System.EventHandler(this.label_SubName_Click);
            // 
            // pictureBox_RightLogo
            // 
            this.pictureBox_RightLogo.Location = new System.Drawing.Point(177, 1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 59);
            this.button1.TabIndex = 42;
            this.button1.Text = "Display Semi Formatted";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplaySelectedObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 677);
            this.Controls.Add(this.button1);
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
            this.Controls.SetChildIndex(this.button1, 0);
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

        private System.Windows.Forms.Button button1;
    }
}
