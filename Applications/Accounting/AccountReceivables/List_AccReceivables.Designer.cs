namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class List_AccReceivables
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
            // textBox_CMD
            // 
            this.textBox_CMD.Text = "select * from AccountsReceivable";
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Text = "AccountsReceivable";
            // 
            // button_Display
            // 
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // button_List
            // 
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // button_DisplaySelected
            // 
            this.button_DisplaySelected.Click += new System.EventHandler(this.button_DisplaySelected_Click);
            // 
            // List_AccReceivables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1219, 741);
            this.Name = "List_AccReceivables";
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
