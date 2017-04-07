namespace Applications.Applications.Materials.MaterialsManagement.Shipments
{
    partial class Shipments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shipments));
            this.lblMessage = new System.Windows.Forms.Label();
            this.rd_Shipped = new System.Windows.Forms.RadioButton();
            this.rd_Unshipped = new System.Windows.Forms.RadioButton();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.Size = new System.Drawing.Size(324, 24);
            // 
            // button_Display
            // 
            this.button_Display.BackColor = System.Drawing.Color.Olive;
            this.button_Display.Size = new System.Drawing.Size(167, 46);
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // comboBox_DocType
            // 
            this.comboBox_DocType.Size = new System.Drawing.Size(327, 24);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_Reset.Location = new System.Drawing.Point(1149, 249);
            this.button_Reset.Size = new System.Drawing.Size(114, 42);
            // 
            // pictureBox_LeftLogo
            // 
            this.pictureBox_LeftLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LeftLogo.Image")));
            this.pictureBox_LeftLogo.Size = new System.Drawing.Size(228, 194);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(402, 297);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(339, 29);
            this.lblMessage.TabIndex = 17;
            // 
            // rd_Shipped
            // 
            this.rd_Shipped.AutoSize = true;
            this.rd_Shipped.Location = new System.Drawing.Point(757, 305);
            this.rd_Shipped.Name = "rd_Shipped";
            this.rd_Shipped.Size = new System.Drawing.Size(81, 21);
            this.rd_Shipped.TabIndex = 18;
            this.rd_Shipped.TabStop = true;
            this.rd_Shipped.Text = "Shipped";
            this.rd_Shipped.UseVisualStyleBackColor = true;
            this.rd_Shipped.CheckedChanged += new System.EventHandler(this.rd_Shipped_CheckedChanged);
            // 
            // rd_Unshipped
            // 
            this.rd_Unshipped.AutoSize = true;
            this.rd_Unshipped.Location = new System.Drawing.Point(972, 305);
            this.rd_Unshipped.Name = "rd_Unshipped";
            this.rd_Unshipped.Size = new System.Drawing.Size(97, 21);
            this.rd_Unshipped.TabIndex = 19;
            this.rd_Unshipped.TabStop = true;
            this.rd_Unshipped.Text = "Unshipped";
            this.rd_Unshipped.UseVisualStyleBackColor = true;
            this.rd_Unshipped.CheckedChanged += new System.EventHandler(this.rd_Unshipped_CheckedChanged);
            // 
            // Shipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1625, 970);
            this.Controls.Add(this.rd_Unshipped);
            this.Controls.Add(this.rd_Shipped);
            this.Controls.Add(this.lblMessage);
            this.Name = "Shipments";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.comboBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_Reset, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.rd_Shipped, 0);
            this.Controls.SetChildIndex(this.rd_Unshipped, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RadioButton rd_Shipped;
        private System.Windows.Forms.RadioButton rd_Unshipped;
    }
}
