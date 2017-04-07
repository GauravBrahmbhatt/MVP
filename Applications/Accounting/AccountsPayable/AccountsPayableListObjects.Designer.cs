namespace Applications.Applications.Accounting.AccountsPayable
{
    partial class AccountsPayableListObjects
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
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.SelectedIndexChanged += new System.EventHandler(this.comboBox_TableName_SelectedIndexChanged_1);
            // 
            // button_Display
            // 
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // label_SubName
            // 
            this.label_SubName.Location = new System.Drawing.Point(422, 87);
            this.label_SubName.Size = new System.Drawing.Size(377, 28);
            this.label_SubName.Text = " Accounts Payable Display Documents";
            // 
            // AccountsPayableListObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1219, 741);
            this.Name = "AccountsPayableListObjects";
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
