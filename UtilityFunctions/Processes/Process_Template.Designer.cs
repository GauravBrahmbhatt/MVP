namespace Utilities
{
    partial class Process_Template
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
            this.button_Multiple = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(105, 28);
            this.label_SubName.Text = " Processes";
            // 
            // button_ListALL
            // 
            this.button_ListALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ListALL.Location = new System.Drawing.Point(11, 176);
            this.button_ListALL.Name = "button_ListALL";
            this.button_ListALL.Size = new System.Drawing.Size(136, 57);
            this.button_ListALL.TabIndex = 0;
            this.button_ListALL.Text = "   List   Processes";
            this.button_ListALL.UseVisualStyleBackColor = true;
            this.button_ListALL.Click += new System.EventHandler(this.button_ListALL_Click);
            // 
            // button_DisplaySpecific
            // 
            this.button_DisplaySpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DisplaySpecific.Location = new System.Drawing.Point(11, 248);
            this.button_DisplaySpecific.Name = "button_DisplaySpecific";
            this.button_DisplaySpecific.Size = new System.Drawing.Size(133, 53);
            this.button_DisplaySpecific.TabIndex = 1;
            this.button_DisplaySpecific.Text = "Display Specific  Process";
            this.button_DisplaySpecific.UseVisualStyleBackColor = true;
            this.button_DisplaySpecific.Click += new System.EventHandler(this.button_DisplaySpecific_Click);
            // 
            // button_Multiple
            // 
            this.button_Multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Multiple.Location = new System.Drawing.Point(16, 400);
            this.button_Multiple.Name = "button_Multiple";
            this.button_Multiple.Size = new System.Drawing.Size(131, 51);
            this.button_Multiple.TabIndex = 2;
            this.button_Multiple.Text = "Begin a New Process";
            this.button_Multiple.UseVisualStyleBackColor = true;
            this.button_Multiple.Click += new System.EventHandler(this.button_Multiple_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.Location = new System.Drawing.Point(13, 314);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(131, 54);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Create / Edit  Process";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "_________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Processes";
            // 
            // Process_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Name = "Process_Template";
            this.Text = "PurchaseOrders - Template";
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    //    private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Multiple;
        private System.Windows.Forms.Button button_DisplaySpecific;
        private System.Windows.Forms.Button button_ListALL;
      //  private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
