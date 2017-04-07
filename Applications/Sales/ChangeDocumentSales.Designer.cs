namespace Applications.Applications.Sales
{
    partial class ChangeDocumentSales
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
            // button_GetDoc
            // 
            this.button_GetDoc.Location = new System.Drawing.Point(1008, 192);
            this.button_GetDoc.Size = new System.Drawing.Size(163, 73);
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Size = new System.Drawing.Size(515, 47);
            // 
            // listBox_DataStrings
            // 
            this.listBox_DataStrings.ItemHeight = 16;
            this.listBox_DataStrings.Size = new System.Drawing.Size(515, 116);
            // 
            // textBox_DataStrings
            // 
            this.textBox_DataStrings.Size = new System.Drawing.Size(515, 111);
            // 
            // button_Save
            // 
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Size = new System.Drawing.Size(279, 24);
            // 
            // button_ResetCommand
            // 
            this.button_ResetCommand.Location = new System.Drawing.Point(820, 224);
            this.button_ResetCommand.Size = new System.Drawing.Size(169, 41);
            // 
            // button_ResetLabels
            // 
            this.button_ResetLabels.Size = new System.Drawing.Size(156, 43);
            // 
            // button_Delete
            // 
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // ChangeDocumentSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1468, 833);
            this.Name = "ChangeDocumentSales";
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
