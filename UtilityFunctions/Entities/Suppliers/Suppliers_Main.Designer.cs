namespace Utilities
{
    partial class Suppliers_Main
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
            this.button_ListALL = new System.Windows.Forms.Button();
            this.button_DisplaySpecific = new System.Windows.Forms.Button();
            this.button_CreateNew = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(496, 260);
            this.button_Return.Size = new System.Drawing.Size(131, 56);
            this.button_Return.TabIndex = 4;
            this.button_Return.Text = "Return to  Previous Level";
            this.button_Return.UseVisualStyleBackColor = true;
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(106, 28);
            this.label_SubName.Text = " Suppliers";
            // 
            // button_ListALL
            // 
            this.button_ListALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ListALL.Location = new System.Drawing.Point(323, 207);
            this.button_ListALL.Name = "button_ListALL";
            this.button_ListALL.Size = new System.Drawing.Size(136, 57);
            this.button_ListALL.TabIndex = 0;
            this.button_ListALL.Text = "   List     Suppliers";
            this.button_ListALL.UseVisualStyleBackColor = true;
            this.button_ListALL.Click += new System.EventHandler(this.button_ListALL_Click);
            // 
            // button_DisplaySpecific
            // 
            this.button_DisplaySpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DisplaySpecific.Location = new System.Drawing.Point(662, 207);
            this.button_DisplaySpecific.Name = "button_DisplaySpecific";
            this.button_DisplaySpecific.Size = new System.Drawing.Size(133, 53);
            this.button_DisplaySpecific.TabIndex = 1;
            this.button_DisplaySpecific.Text = "Display Specific Supplier";
            this.button_DisplaySpecific.UseVisualStyleBackColor = true;
            this.button_DisplaySpecific.Click += new System.EventHandler(this.button_DisplaySpecific_Click);
            // 
            // button_CreateNew
            // 
            this.button_CreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateNew.Location = new System.Drawing.Point(323, 318);
            this.button_CreateNew.Name = "button_CreateNew";
            this.button_CreateNew.Size = new System.Drawing.Size(131, 51);
            this.button_CreateNew.TabIndex = 2;
            this.button_CreateNew.Text = "Create New Supplier";
            this.button_CreateNew.UseVisualStyleBackColor = true;
            this.button_CreateNew.Click += new System.EventHandler(this.button_CreateNew_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.Location = new System.Drawing.Point(662, 316);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(131, 54);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Edit / Update Supplier";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // Suppliers_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.button_ListALL);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_DisplaySpecific);
            this.Controls.Add(this.button_CreateNew);
            this.Name = "Suppliers_Main";
            this.Text = "PurchaseOrders - Template";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button_CreateNew, 0);
            this.Controls.SetChildIndex(this.button_DisplaySpecific, 0);
            this.Controls.SetChildIndex(this.button_Edit, 0);
            this.Controls.SetChildIndex(this.button_ListALL, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_CreateNew;
        private System.Windows.Forms.Button button_DisplaySpecific;
        private System.Windows.Forms.Button button_ListALL;
    }
}
