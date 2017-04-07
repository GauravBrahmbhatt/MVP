namespace Applications.Applications.Sales
{
    partial class CreateSalesOrder
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
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_Suppliers = new System.Windows.Forms.ComboBox();
            this.comboBox_Material = new System.Windows.Forms.ComboBox();
            this.label_Suppliers = new System.Windows.Forms.Label();
            this.label_Product = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_StartProcess = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ProcessID
            // 
            this.textBox_ProcessID.Location = new System.Drawing.Point(170, 112);
            this.textBox_ProcessID.Size = new System.Drawing.Size(161, 22);
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Size = new System.Drawing.Size(161, 22);
            // 
            // textBox_IntAgent
            // 
            this.textBox_IntAgent.Location = new System.Drawing.Point(172, 50);
            this.textBox_IntAgent.Size = new System.Drawing.Size(159, 22);
            // 
            // textBox_ExtAgent
            // 
            this.textBox_ExtAgent.Size = new System.Drawing.Size(160, 22);
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(444, 582);
            this.textBox_Comment.Size = new System.Drawing.Size(162, 22);
            // 
            // textBox_Status
            // 
            this.textBox_Status.Size = new System.Drawing.Size(159, 22);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Size = new System.Drawing.Size(161, 22);
            // 
            // button_GetDoc
            // 
            this.button_GetDoc.Location = new System.Drawing.Point(993, 853);
            this.button_GetDoc.Visible = false;
            // 
            // textBox_TextValue2
            // 
            this.textBox_TextValue2.Location = new System.Drawing.Point(169, 181);
            this.textBox_TextValue2.Size = new System.Drawing.Size(162, 22);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(18, 181);
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.Text = "Date ending";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 213);
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.Text = "Expected Amount";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 248);
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.Text = "Actual Amount";
            // 
            // textBox_ExpectedAmount
            // 
            this.textBox_ExpectedAmount.Location = new System.Drawing.Point(169, 213);
            this.textBox_ExpectedAmount.Size = new System.Drawing.Size(162, 22);
            // 
            // textBox_ActualAmount
            // 
            this.textBox_ActualAmount.Location = new System.Drawing.Point(169, 245);
            this.textBox_ActualAmount.Size = new System.Drawing.Size(162, 22);
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Size = new System.Drawing.Size(634, 47);
            // 
            // button_ValidateData
            // 
            this.button_ValidateData.Location = new System.Drawing.Point(655, 197);
            this.button_ValidateData.Size = new System.Drawing.Size(179, 83);
            this.button_ValidateData.Text = "Validate Order";
            // 
            // listBox_DataStrings
            // 
            this.listBox_DataStrings.ItemHeight = 16;
            this.listBox_DataStrings.Size = new System.Drawing.Size(634, 84);
            // 
            // textBox_DataStrings
            // 
            this.textBox_DataStrings.Location = new System.Drawing.Point(271, 853);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 143);
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.Text = "Date starting";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox_TextValue1
            // 
            this.textBox_TextValue1.Location = new System.Drawing.Point(169, 145);
            this.textBox_TextValue1.Size = new System.Drawing.Size(162, 22);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Size = new System.Drawing.Size(162, 22);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(1056, 198);
            this.button_Save.Size = new System.Drawing.Size(234, 83);
            this.button_Save.Text = "Save Sales Order";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(1328, 872);
            this.comboBox1.Size = new System.Drawing.Size(131, 24);
            this.comboBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1335, 923);
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(345, 277);
            // 
            // button_ResetCommand
            // 
            this.button_ResetCommand.Location = new System.Drawing.Point(1168, 904);
            this.button_ResetCommand.Visible = false;
            // 
            // button_ResetLabels
            // 
            this.button_ResetLabels.Location = new System.Drawing.Point(1168, 853);
            this.button_ResetLabels.Size = new System.Drawing.Size(129, 43);
            this.button_ResetLabels.Visible = false;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(842, 199);
            this.button_Delete.Size = new System.Drawing.Size(206, 81);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(1325, 851);
            this.label18.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 112);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.Text = "Sales Rep";
            // 
            // label_ExtAgent
            // 
            this.label_ExtAgent.Location = new System.Drawing.Point(18, 19);
            this.label_ExtAgent.Size = new System.Drawing.Size(68, 17);
            this.label_ExtAgent.Text = "Customer";
            // 
            // button_Transaction
            // 
            this.button_Transaction.Location = new System.Drawing.Point(784, 853);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(230, 37);
            this.label_SubName.Text = "Create Sales Order";
            // 
            // pictureBox_RightLogo
            // 
            this.pictureBox_RightLogo.Location = new System.Drawing.Point(296, 0);
            this.pictureBox_RightLogo.Size = new System.Drawing.Size(1163, 160);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(895, 546);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(179, 67);
            this.button_Add.TabIndex = 49;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Suppliers
            // 
            this.comboBox_Suppliers.FormattingEnabled = true;
            this.comboBox_Suppliers.Location = new System.Drawing.Point(872, 929);
            this.comboBox_Suppliers.Name = "comboBox_Suppliers";
            this.comboBox_Suppliers.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Suppliers.TabIndex = 50;
            this.comboBox_Suppliers.Visible = false;
            // 
            // comboBox_Material
            // 
            this.comboBox_Material.FormattingEnabled = true;
            this.comboBox_Material.Location = new System.Drawing.Point(655, 480);
            this.comboBox_Material.Name = "comboBox_Material";
            this.comboBox_Material.Size = new System.Drawing.Size(419, 24);
            this.comboBox_Material.TabIndex = 51;
            this.comboBox_Material.SelectedIndexChanged += new System.EventHandler(this.comboBox_Material_SelectedIndexChanged);
            // 
            // label_Suppliers
            // 
            this.label_Suppliers.AutoSize = true;
            this.label_Suppliers.Location = new System.Drawing.Point(783, 932);
            this.label_Suppliers.Name = "label_Suppliers";
            this.label_Suppliers.Size = new System.Drawing.Size(67, 17);
            this.label_Suppliers.TabIndex = 52;
            this.label_Suppliers.Text = "Suppliers";
            this.label_Suppliers.Click += new System.EventHandler(this.label_Suppliers_Click);
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Location = new System.Drawing.Point(653, 458);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(58, 17);
            this.label_Product.TabIndex = 53;
            this.label_Product.Text = "Material";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(653, 512);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(40, 17);
            this.label_Price.TabIndex = 54;
            this.label_Price.Text = "Price";
            this.label_Price.Click += new System.EventHandler(this.label_Price_Click);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(655, 535);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 22);
            this.textBox_Price.TabIndex = 55;
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(653, 568);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(61, 17);
            this.label_Quantity.TabIndex = 56;
            this.label_Quantity.Text = "Quantity";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(655, 591);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(100, 22);
            this.textBox_Quantity.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1306, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 102);
            this.label1.TabIndex = 58;
            this.label1.Text = "Step 1: Enter header (left section)\r\nStep 2: Select Material, Price, Quantity and" +
    " Add\r\nStep 3: Validate Order\r\nStep 4: Delete OLD Document\r\nStep 5: Save New Sale" +
    "s Order\r\nStep 6: Post Sale Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_StartProcess
            // 
            this.button_StartProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartProcess.Location = new System.Drawing.Point(1297, 197);
            this.button_StartProcess.Name = "button_StartProcess";
            this.button_StartProcess.Size = new System.Drawing.Size(206, 83);
            this.button_StartProcess.TabIndex = 59;
            this.button_StartProcess.Text = "Post Sales Order";
            this.button_StartProcess.UseVisualStyleBackColor = true;
            this.button_StartProcess.Click += new System.EventHandler(this.button_StartProcess_Click);
            // 
            // CreateSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1760, 958);
            this.Controls.Add(this.button_StartProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Product);
            this.Controls.Add(this.label_Suppliers);
            this.Controls.Add(this.comboBox_Material);
            this.Controls.Add(this.comboBox_Suppliers);
            this.Controls.Add(this.button_Add);
            this.Name = "CreateSalesOrder";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_GetDoc, 0);
            this.Controls.SetChildIndex(this.textBox_Cmd, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button_Save, 0);
            this.Controls.SetChildIndex(this.button_Delete, 0);
            this.Controls.SetChildIndex(this.button_ValidateData, 0);
            this.Controls.SetChildIndex(this.listBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.textBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.button_ResetCommand, 0);
            this.Controls.SetChildIndex(this.button_ResetLabels, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button_Transaction, 0);
            this.Controls.SetChildIndex(this.button_Add, 0);
            this.Controls.SetChildIndex(this.comboBox_Suppliers, 0);
            this.Controls.SetChildIndex(this.comboBox_Material, 0);
            this.Controls.SetChildIndex(this.label_Suppliers, 0);
            this.Controls.SetChildIndex(this.label_Product, 0);
            this.Controls.SetChildIndex(this.label_Price, 0);
            this.Controls.SetChildIndex(this.textBox_Price, 0);
            this.Controls.SetChildIndex(this.label_Quantity, 0);
            this.Controls.SetChildIndex(this.textBox_Quantity, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button_StartProcess, 0);
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

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBox_Suppliers;
        private System.Windows.Forms.ComboBox comboBox_Material;
        private System.Windows.Forms.Label label_Suppliers;
        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_StartProcess;
    }
}
