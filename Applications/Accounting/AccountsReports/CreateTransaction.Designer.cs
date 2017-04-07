namespace Applications.Applications.Accounting.AccountsReports
{
    partial class CreateTransaction
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
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ValidateData
            // 
            this.button_ValidateData.Click += new System.EventHandler(this.button_ValidateData_Click_1);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Text = "Transactions";
            // 
            // button_Save
            // 
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button_ResetCommand
            // 
            
            // 
            // button_Transaction
            // 
            this.button_Transaction.Click += new System.EventHandler(this.button_Transaction_Click);
            // 
            // CreateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1101, 677);
            this.Name = "CreateTransaction";
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
    }
}
