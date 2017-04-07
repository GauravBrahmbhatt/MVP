namespace Utilities.Documents
{
    partial class UpdateDocument

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
            this.textBox_Command = new System.Windows.Forms.TextBox();
            this.button_ExeCommand = new System.Windows.Forms.Button();
            this.textBox_CommandIndx = new System.Windows.Forms.TextBox();
            this.dataGridView_0 = new System.Windows.Forms.DataGridView();
            this.dataGridView_1 = new System.Windows.Forms.DataGridView();
            this.dataGridView_2 = new System.Windows.Forms.DataGridView();
            this.dataGridView_3 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox_Response = new System.Windows.Forms.TextBox();
            this.textBox_Before = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView_4 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.button_Next_Cmd = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Location = new System.Drawing.Point(1193, 810);
            this.textBox_CMD.Size = new System.Drawing.Size(10, 10);
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.Items.AddRange(new object[] {
            "1  Acc_Payable  ;  select * from Acc_payable",
            "2  Acc_Receivable  ;  select * from Acc_Receivable",
            "3  Inventory  ;  select * from Inventory"});
            this.comboBox_TableName.SelectedIndexChanged += new System.EventHandler(this.comboBox_TableName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1179, 822);
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.Text = ".";
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(1195, 839);
            this.button_Reset.Size = new System.Drawing.Size(10, 10);
            // 
            // label_SubName
            // 
            this.label_SubName.Location = new System.Drawing.Point(437, 75);
            this.label_SubName.Size = new System.Drawing.Size(276, 28);
            this.label_SubName.Text = " Update Account Document";
            // 
            // textBox_Command
            // 
            this.textBox_Command.Location = new System.Drawing.Point(690, 157);
            this.textBox_Command.Multiline = true;
            this.textBox_Command.Name = "textBox_Command";
            this.textBox_Command.Size = new System.Drawing.Size(428, 31);
            this.textBox_Command.TabIndex = 19;
            // 
            // button_ExeCommand
            // 
            this.button_ExeCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExeCommand.Location = new System.Drawing.Point(954, 198);
            this.button_ExeCommand.Name = "button_ExeCommand";
            this.button_ExeCommand.Size = new System.Drawing.Size(102, 53);
            this.button_ExeCommand.TabIndex = 20;
            this.button_ExeCommand.Text = "Execute Command";
            this.button_ExeCommand.UseVisualStyleBackColor = true;
            this.button_ExeCommand.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // textBox_CommandIndx
            // 
            this.textBox_CommandIndx.Location = new System.Drawing.Point(649, 165);
            this.textBox_CommandIndx.Name = "textBox_CommandIndx";
            this.textBox_CommandIndx.Size = new System.Drawing.Size(28, 20);
            this.textBox_CommandIndx.TabIndex = 21;
            // 
            // dataGridView_0
            // 
            this.dataGridView_0.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_0.Location = new System.Drawing.Point(207, 285);
            this.dataGridView_0.Name = "dataGridView_0";
            this.dataGridView_0.Size = new System.Drawing.Size(848, 164);
            this.dataGridView_0.TabIndex = 22;
            // 
            // dataGridView_1
            // 
            this.dataGridView_1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_1.Location = new System.Drawing.Point(1237, 822);
            this.dataGridView_1.Name = "dataGridView_1";
            this.dataGridView_1.Size = new System.Drawing.Size(10, 13);
            this.dataGridView_1.TabIndex = 23;
            // 
            // dataGridView_2
            // 
            this.dataGridView_2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_2.Location = new System.Drawing.Point(209, 520);
            this.dataGridView_2.Name = "dataGridView_2";
            this.dataGridView_2.Size = new System.Drawing.Size(808, 90);
            this.dataGridView_2.TabIndex = 24;
            // 
            // dataGridView_3
            // 
            this.dataGridView_3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_3.Location = new System.Drawing.Point(209, 616);
            this.dataGridView_3.Name = "dataGridView_3";
            this.dataGridView_3.Size = new System.Drawing.Size(808, 93);
            this.dataGridView_3.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(214, 255);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(462, 21);
            this.comboBox3.TabIndex = 26;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox_Response
            // 
            this.textBox_Response.Location = new System.Drawing.Point(886, 255);
            this.textBox_Response.Name = "textBox_Response";
            this.textBox_Response.Size = new System.Drawing.Size(167, 20);
            this.textBox_Response.TabIndex = 27;
            // 
            // textBox_Before
            // 
            this.textBox_Before.Location = new System.Drawing.Point(205, 475);
            this.textBox_Before.Name = "textBox_Before";
            this.textBox_Before.Size = new System.Drawing.Size(840, 20);
            this.textBox_Before.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 724);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(840, 20);
            this.textBox1.TabIndex = 29;
            // 
            // dataGridView_4
            // 
            this.dataGridView_4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_4.Location = new System.Drawing.Point(213, 762);
            this.dataGridView_4.Name = "dataGridView_4";
            this.dataGridView_4.Size = new System.Drawing.Size(834, 103);
            this.dataGridView_4.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Account";
            // 
            // textBox_Account
            // 
            this.textBox_Account.Location = new System.Drawing.Point(763, 256);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(86, 20);
            this.textBox_Account.TabIndex = 32;
            // 
            // button_Next_Cmd
            // 
            this.button_Next_Cmd.Location = new System.Drawing.Point(829, 199);
            this.button_Next_Cmd.Name = "button_Next_Cmd";
            this.button_Next_Cmd.Size = new System.Drawing.Size(100, 50);
            this.button_Next_Cmd.TabIndex = 33;
            this.button_Next_Cmd.Text = "Next Command";
            this.button_Next_Cmd.UseVisualStyleBackColor = true;
            this.button_Next_Cmd.Click += new System.EventHandler(this.button_Next_Cmd_Click);
            // 
            // UpdateDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1306, 934);
            this.Controls.Add(this.button_Next_Cmd);
            this.Controls.Add(this.textBox_Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_Before);
            this.Controls.Add(this.textBox_Response);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dataGridView_3);
            this.Controls.Add(this.dataGridView_2);
            this.Controls.Add(this.dataGridView_1);
            this.Controls.Add(this.dataGridView_0);
            this.Controls.Add(this.textBox_CommandIndx);
            this.Controls.Add(this.button_ExeCommand);
            this.Controls.Add(this.textBox_Command);
            this.Name = "UpdateDocument";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.comboBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.label_3, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox_ExternalRef, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.textBox_InternalRef, 0);
            this.Controls.SetChildIndex(this.button_Reset, 0);
            this.Controls.SetChildIndex(this.textBox_Command, 0);
            this.Controls.SetChildIndex(this.button_ExeCommand, 0);
            this.Controls.SetChildIndex(this.textBox_CommandIndx, 0);
            this.Controls.SetChildIndex(this.dataGridView_0, 0);
            this.Controls.SetChildIndex(this.dataGridView_1, 0);
            this.Controls.SetChildIndex(this.dataGridView_2, 0);
            this.Controls.SetChildIndex(this.dataGridView_3, 0);
            this.Controls.SetChildIndex(this.comboBox3, 0);
            this.Controls.SetChildIndex(this.textBox_Response, 0);
            this.Controls.SetChildIndex(this.textBox_Before, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView_4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox_Account, 0);
            this.Controls.SetChildIndex(this.button_Next_Cmd, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label_description;
        protected System.Windows.Forms.Button button_RawData;
        protected System.Windows.Forms.Button button_ResetCommand;
        protected System.Windows.Forms.Button button_DisplayDoc;
        protected System.Windows.Forms.DataGridView dataGridView2;
        protected System.Windows.Forms.TextBox textBox_Description;
       // protected System.Windows.Forms.TextBox textBox_Cmd;
        protected System.Windows.Forms.TextBox textBox_DataStrings;
        protected System.Windows.Forms.TextBox textBox_DocNum;
        protected System.Windows.Forms.TextBox textBox_DocType;
        protected System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.DataGridView dataGridView0;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.TextBox textBox_CmdIndex;
        private System.Windows.Forms.TextBox textBox_Command;
        private System.Windows.Forms.Button button_ExeCommand;
        private System.Windows.Forms.TextBox textBox_CommandIndx;
        private System.Windows.Forms.DataGridView dataGridView_0;
        private System.Windows.Forms.DataGridView dataGridView_1;
        private System.Windows.Forms.DataGridView dataGridView_2;
        private System.Windows.Forms.DataGridView dataGridView_3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox_Response;
        private System.Windows.Forms.TextBox textBox_Before;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView_4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.Button button_Next_Cmd;
        //protected System.Windows.Forms.Label label2;
        //protected System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Est_Value;
    }
}
