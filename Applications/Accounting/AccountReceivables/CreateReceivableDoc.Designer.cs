namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class CreateReceivableDoc
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
            this.btn_Transaction = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(671, 203);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(1013, 203);
            this.button_Reset.Size = new System.Drawing.Size(81, 43);
            this.button_Reset.Text = "Reset";
            // 
            // button_List
            // 
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // button_DisplaySelected
            // 
            this.button_DisplaySelected.Click += new System.EventHandler(this.button_DisplaySelected_Click);
            // 
            // btn_Transaction
            // 
            this.btn_Transaction.AutoSize = true;
            this.btn_Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Transaction.Location = new System.Drawing.Point(815, 202);
            this.btn_Transaction.Name = "btn_Transaction";
            this.btn_Transaction.Size = new System.Drawing.Size(180, 43);
            this.btn_Transaction.TabIndex = 15;
            this.btn_Transaction.Text = "Create Receivable Doc";
            this.btn_Transaction.UseVisualStyleBackColor = true;
            this.btn_Transaction.Click += new System.EventHandler(this.btn_Transaction_Click);
            // 
            // CreateReceivableDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1101, 677);
            this.Controls.Add(this.btn_Transaction);
            this.Name = "CreateReceivableDoc";
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
            this.Controls.SetChildIndex(this.btn_Transaction, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Transaction;
    }
}
