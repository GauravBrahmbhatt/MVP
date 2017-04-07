namespace Applications.Applications.Sales
{
    partial class ListObjects
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
            this.button_CreateSalesOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Size = new System.Drawing.Size(646, 54);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(755, 185);
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.Location = new System.Drawing.Point(391, 183);
            this.comboBox_TableName.Size = new System.Drawing.Size(324, 24);
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(895, 242);
            this.button_Display.Size = new System.Drawing.Size(197, 49);
            this.button_Display.Text = "Display";
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(269, 226);
            // 
            // comboBox_DocType
            // 
            this.comboBox_DocType.Location = new System.Drawing.Point(391, 219);
            this.comboBox_DocType.Size = new System.Drawing.Size(321, 24);
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Location = new System.Drawing.Point(755, 219);
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(895, 299);
            this.button_Reset.Size = new System.Drawing.Size(165, 35);
            this.button_Reset.Visible = false;
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Location = new System.Drawing.Point(755, 267);
            this.textBox_DocNum.Size = new System.Drawing.Size(103, 22);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(218, 37);
            this.label_SubName.Text = "Sales of Products";
            // 
            // panel_TopPanel
            // 
            this.panel_TopPanel.Size = new System.Drawing.Size(1541, 165);
            // 
            // pictureBox_RightLogo
            // 
            this.pictureBox_RightLogo.Location = new System.Drawing.Point(300, 0);
            this.pictureBox_RightLogo.Size = new System.Drawing.Size(1159, 160);
            // 
            // button_CreateSalesOrder
            // 
            this.button_CreateSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateSalesOrder.Location = new System.Drawing.Point(1099, 240);
            this.button_CreateSalesOrder.Name = "button_CreateSalesOrder";
            this.button_CreateSalesOrder.Size = new System.Drawing.Size(214, 49);
            this.button_CreateSalesOrder.TabIndex = 15;
            this.button_CreateSalesOrder.Text = "Create Sales Order";
            this.button_CreateSalesOrder.UseVisualStyleBackColor = true;
            this.button_CreateSalesOrder.Click += new System.EventHandler(this.button_CreateSalesOrder_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1327, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Create Sales Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1625, 970);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_CreateSalesOrder);
            this.Name = "ListObjects";
            this.Load += new System.EventHandler(this.ListObjects_Load);
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
            this.Controls.SetChildIndex(this.button_CreateSalesOrder, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateSalesOrder;
        private System.Windows.Forms.Button button1;
    }
}
