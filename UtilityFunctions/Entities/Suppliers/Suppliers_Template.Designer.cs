namespace Utilities
{
    partial class Suppliers_Template
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
            this.button_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 
            // button_Edit
            // 
            this.button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.Location = new System.Drawing.Point(14, 357);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(131, 54);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Edit / Update Supplier";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // Suppliers_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Name = "Suppliers_Template";
            this.Text = "PurchaseOrders - Template";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Edit;
    }
}
