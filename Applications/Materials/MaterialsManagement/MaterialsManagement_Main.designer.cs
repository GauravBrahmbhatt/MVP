namespace Applications.Applications.Materials.MaterialsManagement
{
    partial class MaterialsManagement_Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.btn_Suppliers = new System.Windows.Forms.Button();
            this.btn_deliveries = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(393, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "Purchase Orders";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.Salmon;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(725, 245);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(145, 86);
            this.Inventory.TabIndex = 3;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.BackColor = System.Drawing.Color.Salmon;
            this.btn_Suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.Location = new System.Drawing.Point(1026, 245);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.Size = new System.Drawing.Size(171, 86);
            this.btn_Suppliers.TabIndex = 4;
            this.btn_Suppliers.Text = "Suppliers";
            this.btn_Suppliers.UseVisualStyleBackColor = false;
            this.btn_Suppliers.Click += new System.EventHandler(this.btn_Suppliers_Click);
            // 
            // btn_deliveries
            // 
            this.btn_deliveries.BackColor = System.Drawing.Color.Salmon;
            this.btn_deliveries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliveries.Location = new System.Drawing.Point(568, 433);
            this.btn_deliveries.Name = "btn_deliveries";
            this.btn_deliveries.Size = new System.Drawing.Size(172, 78);
            this.btn_deliveries.TabIndex = 5;
            this.btn_deliveries.Text = "Deliveries";
            this.btn_deliveries.UseVisualStyleBackColor = false;
            this.btn_deliveries.Click += new System.EventHandler(this.btn_deliveries_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Salmon;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(902, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 78);
            this.button5.TabIndex = 6;
            this.button5.Text = "Shipments";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MaterialsManagement_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1571, 906);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_deliveries);
            this.Controls.Add(this.btn_Suppliers);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.button1);
            this.Name = "MaterialsManagement_Main";
            this.Load += new System.EventHandler(this.MaterialsManagement_Main_Load);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.Inventory, 0);
            this.Controls.SetChildIndex(this.btn_Suppliers, 0);
            this.Controls.SetChildIndex(this.btn_deliveries, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button btn_Suppliers;
        private System.Windows.Forms.Button btn_deliveries;
        private System.Windows.Forms.Button button5;
    }
}
