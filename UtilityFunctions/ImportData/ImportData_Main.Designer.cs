namespace UtilityFunctions
{
    partial class ImportData_Main
    {
         //<summary>
         //Required designer variable.
         //</summary>
        private System.ComponentModel.IContainer components = null;

         //<summary>
         //Clean up any resources being used.
         //</summary>
         //<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.button_GeneralText = new System.Windows.Forms.Button();
            this.button_ImportDocument = new System.Windows.Forms.Button();
            this.button_ImportEntity = new System.Windows.Forms.Button();
            this.button_ImportFromSpreadsheet = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(266, 28);
            this.label_SubName.Text = "Importing Data from Files";
            // 
            // button_GeneralText
            // 
            this.button_GeneralText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GeneralText.Location = new System.Drawing.Point(369, 243);
            this.button_GeneralText.Name = "button_GeneralText";
            this.button_GeneralText.Size = new System.Drawing.Size(168, 115);
            this.button_GeneralText.TabIndex = 2;
            this.button_GeneralText.Text = "       Data in              general text      CSV format";
            this.button_GeneralText.UseVisualStyleBackColor = true;
            this.button_GeneralText.Click += new System.EventHandler(this.button_GeneralText_Click);
            // 
            // button_ImportDocument
            // 
            this.button_ImportDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ImportDocument.Location = new System.Drawing.Point(682, 243);
            this.button_ImportDocument.Name = "button_ImportDocument";
            this.button_ImportDocument.Size = new System.Drawing.Size(168, 115);
            this.button_ImportDocument.TabIndex = 3;
            this.button_ImportDocument.Text = "Data in GenDocs        (Document)        CSV format";
            this.button_ImportDocument.UseVisualStyleBackColor = true;
            this.button_ImportDocument.Click += new System.EventHandler(this.button_ImportDocument_Click);
            // 
            // button_ImportEntity
            // 
            this.button_ImportEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ImportEntity.Location = new System.Drawing.Point(369, 410);
            this.button_ImportEntity.Name = "button_ImportEntity";
            this.button_ImportEntity.Size = new System.Drawing.Size(168, 115);
            this.button_ImportEntity.TabIndex = 4;
            this.button_ImportEntity.Text = "Data in GenDocs        (Entity)        CSV format";
            this.button_ImportEntity.UseVisualStyleBackColor = true;
            this.button_ImportEntity.Click += new System.EventHandler(this.button_ImportEntity_Click);
            // 
            // button_ImportFromSpreadsheet
            // 
            this.button_ImportFromSpreadsheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ImportFromSpreadsheet.Location = new System.Drawing.Point(682, 410);
            this.button_ImportFromSpreadsheet.Name = "button_ImportFromSpreadsheet";
            this.button_ImportFromSpreadsheet.Size = new System.Drawing.Size(186, 115);
            this.button_ImportFromSpreadsheet.TabIndex = 5;
            this.button_ImportFromSpreadsheet.Text = "          Data in        Excel Spreadsheet        format";
            this.button_ImportFromSpreadsheet.UseVisualStyleBackColor = true;
            this.button_ImportFromSpreadsheet.Click += new System.EventHandler(this.button_ImportFromSpreadsheet_Click);
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 733);
            this.Controls.Add(this.button_ImportFromSpreadsheet);
            this.Controls.Add(this.button_ImportEntity);
            this.Controls.Add(this.button_ImportDocument);
            this.Controls.Add(this.button_GeneralText);
            this.Name = "ImportData";
            this.Controls.SetChildIndex(this.button_GeneralText, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button_ImportDocument, 0);
            this.Controls.SetChildIndex(this.button_ImportEntity, 0);
            this.Controls.SetChildIndex(this.button_ImportFromSpreadsheet, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

       }

        #endregion

        private System.Windows.Forms.Button button_GeneralText;
        private System.Windows.Forms.Button button_ImportDocument;
        private System.Windows.Forms.Button button_ImportEntity;
        private System.Windows.Forms.Button button_ImportFromSpreadsheet;
    }
}
