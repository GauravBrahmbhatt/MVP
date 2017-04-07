namespace Applications.Applications.Sales
{
    partial class DisplaySelectedObject
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
            this.button_PostSalesOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Location = new System.Drawing.Point(469, 283);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Location = new System.Drawing.Point(469, 241);
            this.textBox_DocNum.Size = new System.Drawing.Size(129, 22);
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Location = new System.Drawing.Point(660, 288);
            this.textBox_Cmd.Size = new System.Drawing.Size(579, 60);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(469, 207);
            // 
            // textBox_IntAgent
            // 
            this.textBox_IntAgent.Location = new System.Drawing.Point(467, 364);
            // 
            // textBox_ExtAgent
            // 
            this.textBox_ExtAgent.Location = new System.Drawing.Point(467, 320);
            // 
            // textBox_TextValue2
            // 
            this.textBox_TextValue2.Location = new System.Drawing.Point(163, 113);
            this.textBox_TextValue2.Size = new System.Drawing.Size(129, 22);
            // 
            // label_IntAgent
            // 
            this.label_IntAgent.Size = new System.Drawing.Size(73, 17);
            this.label_IntAgent.Text = "Sales Rep";
            // 
            // label_ExtAgent
            // 
            this.label_ExtAgent.Size = new System.Drawing.Size(68, 17);
            this.label_ExtAgent.Text = "Customer";
            // 
            // button_DisplayDoc
            // 
            this.button_DisplayDoc.Location = new System.Drawing.Point(660, 206);
            this.button_DisplayDoc.Size = new System.Drawing.Size(185, 73);
            this.button_DisplayDoc.Click += new System.EventHandler(this.button_DisplayDoc_Click);
            // 
            // button_ResetLabels
            // 
            this.button_ResetLabels.Location = new System.Drawing.Point(660, 356);
            this.button_ResetLabels.Size = new System.Drawing.Size(185, 31);
            // 
            // button_ResetCommand
            // 
            this.button_ResetCommand.Location = new System.Drawing.Point(853, 356);
            this.button_ResetCommand.Size = new System.Drawing.Size(189, 31);
            // 
            // button_ChangeDoc
            // 
            this.button_ChangeDoc.Location = new System.Drawing.Point(853, 205);
            this.button_ChangeDoc.Size = new System.Drawing.Size(189, 75);
            this.button_ChangeDoc.Click += new System.EventHandler(this.button_ChangeDoc_Click);
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(467, 585);
            this.textBox_Comment.Size = new System.Drawing.Size(495, 22);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(469, 175);
            this.comboBox1.Size = new System.Drawing.Size(573, 24);
            // 
            // textBox_DataStrings
            // 
            this.textBox_DataStrings.Location = new System.Drawing.Point(1054, 400);
            this.textBox_DataStrings.Size = new System.Drawing.Size(341, 114);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1049, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 73);
            this.button1.TabIndex = 42;
            this.button1.Text = "Convert to Sales Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_PostSalesOrder
            // 
            this.button_PostSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PostSalesOrder.Location = new System.Drawing.Point(1054, 521);
            this.button_PostSalesOrder.Name = "button_PostSalesOrder";
            this.button_PostSalesOrder.Size = new System.Drawing.Size(237, 50);
            this.button_PostSalesOrder.TabIndex = 43;
            this.button_PostSalesOrder.Text = "Post Sales Order";
            this.button_PostSalesOrder.UseVisualStyleBackColor = true;
            this.button_PostSalesOrder.Visible = false;
            this.button_PostSalesOrder.Click += new System.EventHandler(this.button_PostSalesOrder_Click);
            // 
            // DisplaySelectedObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1419, 833);
            this.Controls.Add(this.button_PostSalesOrder);
            this.Controls.Add(this.button1);
            this.Name = "DisplaySelectedObject";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.label_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label_DocNumber, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_DisplayDoc, 0);
            this.Controls.SetChildIndex(this.textBox_Cmd, 0);
            this.Controls.SetChildIndex(this.textBox_ExtAgent, 0);
            this.Controls.SetChildIndex(this.textBox_IntAgent, 0);
            this.Controls.SetChildIndex(this.textBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.button_ResetLabels, 0);
            this.Controls.SetChildIndex(this.button_ResetCommand, 0);
            this.Controls.SetChildIndex(this.button_ChangeDoc, 0);
            this.Controls.SetChildIndex(this.label_ExtAgent, 0);
            this.Controls.SetChildIndex(this.label_IntAgent, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button_PostSalesOrder, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_PostSalesOrder;

    }
}
