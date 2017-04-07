namespace Applications.Applications.Materials.MaterialsManagement.Deliveries
{
    partial class Deliveries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deliveries));
            this.lblMessage = new System.Windows.Forms.Label();
            this.rd_Delivered = new System.Windows.Forms.RadioButton();
            this.rd_Undelivered = new System.Windows.Forms.RadioButton();
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
            this.button_Display.Size = new System.Drawing.Size(167, 44);
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // comboBox_DocType
            // 
            this.comboBox_DocType.Size = new System.Drawing.Size(327, 24);
            // 
            // button_Reset
            // 
            this.button_Reset.Size = new System.Drawing.Size(105, 42);
            // 
            // pictureBox_LeftLogo
            // 
            this.pictureBox_LeftLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LeftLogo.Image")));
            this.pictureBox_LeftLogo.Size = new System.Drawing.Size(228, 162);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(440, 299);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(344, 26);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // rd_Delivered
            // 
            this.rd_Delivered.AutoSize = true;
            this.rd_Delivered.Location = new System.Drawing.Point(992, 304);
            this.rd_Delivered.Name = "rd_Delivered";
            this.rd_Delivered.Size = new System.Drawing.Size(89, 21);
            this.rd_Delivered.TabIndex = 18;
            this.rd_Delivered.TabStop = true;
            this.rd_Delivered.Text = "Delivered";
            this.rd_Delivered.UseVisualStyleBackColor = true;
            this.rd_Delivered.CheckedChanged += new System.EventHandler(this.rd_Delivered_CheckedChanged);
            // 
            // rd_Undelivered
            // 
            this.rd_Undelivered.AutoSize = true;
            this.rd_Undelivered.Location = new System.Drawing.Point(1243, 304);
            this.rd_Undelivered.Name = "rd_Undelivered";
            this.rd_Undelivered.Size = new System.Drawing.Size(105, 21);
            this.rd_Undelivered.TabIndex = 19;
            this.rd_Undelivered.TabStop = true;
            this.rd_Undelivered.Text = "Undelivered";
            this.rd_Undelivered.UseVisualStyleBackColor = true;
            this.rd_Undelivered.CheckedChanged += new System.EventHandler(this.rd_Undelivered_CheckedChanged);
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1625, 970);
            this.Controls.Add(this.rd_Undelivered);
            this.Controls.Add(this.rd_Delivered);
            this.Controls.Add(this.lblMessage);
            this.Name = "Deliveries";
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
            this.Controls.SetChildIndex(this.rd_Delivered, 0);
            this.Controls.SetChildIndex(this.rd_Undelivered, 0);
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
        private System.Windows.Forms.RadioButton rd_Delivered;
        private System.Windows.Forms.RadioButton rd_Undelivered;
    }
}
