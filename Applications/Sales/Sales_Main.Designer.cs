namespace Applications.Applications.Sales
{
    partial class Sales_Main
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
            this.button_SalesOrders = new System.Windows.Forms.Button();
            this.button_SalesQuotes = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_RightLogo
            // 
            this.pictureBox_RightLogo.Location = new System.Drawing.Point(300, 0);
            this.pictureBox_RightLogo.Size = new System.Drawing.Size(1159, 160);
            // 
            // button_SalesOrders
            // 
            this.button_SalesOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SalesOrders.Location = new System.Drawing.Point(497, 362);
            this.button_SalesOrders.Name = "button_SalesOrders";
            this.button_SalesOrders.Size = new System.Drawing.Size(198, 91);
            this.button_SalesOrders.TabIndex = 2;
            this.button_SalesOrders.Text = "Products";
            this.button_SalesOrders.UseVisualStyleBackColor = true;
            this.button_SalesOrders.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // button_SalesQuotes
            // 
            this.button_SalesQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SalesQuotes.Location = new System.Drawing.Point(929, 362);
            this.button_SalesQuotes.Name = "button_SalesQuotes";
            this.button_SalesQuotes.Size = new System.Drawing.Size(197, 91);
            this.button_SalesQuotes.TabIndex = 57;
            this.button_SalesQuotes.Text = "Services";
            this.button_SalesQuotes.UseVisualStyleBackColor = true;
            this.button_SalesQuotes.Click += new System.EventHandler(this.button_Services_Click);
            // 
            // Sales_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1571, 906);
            this.Controls.Add(this.button_SalesQuotes);
            this.Controls.Add(this.button_SalesOrders);
            this.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Name = "Sales_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button_SalesOrders, 0);
            this.Controls.SetChildIndex(this.button_SalesQuotes, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SalesOrders;
        private System.Windows.Forms.Button button_SalesQuotes;

    }
}
