namespace Applications.Applications.Materials.MaterialsManagement
{
    partial class Inventory
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
            this.btn_delivery = new System.Windows.Forms.Button();
            this.btn_Shipped = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
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
            this.button_Reset.Size = new System.Drawing.Size(127, 33);
            // 
            // btn_delivery
            // 
            this.btn_delivery.BackColor = System.Drawing.Color.Salmon;
            this.btn_delivery.Location = new System.Drawing.Point(1074, 299);
            this.btn_delivery.Name = "btn_delivery";
            this.btn_delivery.Size = new System.Drawing.Size(157, 36);
            this.btn_delivery.TabIndex = 15;
            this.btn_delivery.Text = "Delivery Update";
            this.btn_delivery.UseVisualStyleBackColor = false;
            this.btn_delivery.Click += new System.EventHandler(this.btn_delivery_Click);
            // 
            // btn_Shipped
            // 
            this.btn_Shipped.BackColor = System.Drawing.Color.Salmon;
            this.btn_Shipped.Location = new System.Drawing.Point(1303, 299);
            this.btn_Shipped.Name = "btn_Shipped";
            this.btn_Shipped.Size = new System.Drawing.Size(156, 36);
            this.btn_Shipped.TabIndex = 16;
            this.btn_Shipped.Text = "Shipment Update";
            this.btn_Shipped.UseVisualStyleBackColor = false;
            this.btn_Shipped.Click += new System.EventHandler(this.btn_Shipped_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(452, 299);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(281, 36);
            this.lblMessage.TabIndex = 17;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1625, 970);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btn_Shipped);
            this.Controls.Add(this.btn_delivery);
            this.Name = "Inventory";
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
            this.Controls.SetChildIndex(this.btn_delivery, 0);
            this.Controls.SetChildIndex(this.btn_Shipped, 0);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delivery;
        private System.Windows.Forms.Button btn_Shipped;
        private System.Windows.Forms.Label lblMessage;
    }
}
