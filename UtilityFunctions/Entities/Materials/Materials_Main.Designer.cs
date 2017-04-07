namespace Utilities.Products
{
    partial class Products_Main
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
            this._panel2_LeftControlPanel.Controls.SetChildIndex(this.button_SearchData, 0);
        //    this._panel2_LeftControlPanel.Controls.SetChildIndex(this.button_ChangeObject, 0);
        //    this._panel2_LeftControlPanel.Controls.SetChildIndex(this.button_ListObjects, 0);
        //    this._panel2_LeftControlPanel.Controls.SetChildIndex(this.button_DisplaySelectedObject, 0);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(102, 28);
            this.label_SubName.Text = " Products";
            // 
            // Products_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Name = "Products_Main";
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
