namespace Infrastructure
{

    partial class Search_Database
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_DisplaySelected = new System.Windows.Forms.Button();
            this.label_Response = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_CMD3 = new System.Windows.Forms.TextBox();
            this.comboBox_Query = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label_Ident = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TopPanel
            // 
            this.panel_TopPanel.Controls.Add(this.label4);
            this.panel_TopPanel.Controls.Add(this.label_Ident);
            this.panel_TopPanel.Controls.SetChildIndex(this.pictureBox_LeftLogo, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.pictureBox_RightLogo, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_Ident, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label4, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Utility  Applications";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.button_DisplaySelected);
            this.panel3.Controls.Add(this.label_Response);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.button_Reset);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.textBox_CMD3);
            this.panel3.Controls.Add(this.comboBox_Query);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel3.Location = new System.Drawing.Point(158, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 484);
            this.panel3.TabIndex = 13;
            // 
            // button_DisplaySelected
            // 
            this.button_DisplaySelected.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_DisplaySelected.Location = new System.Drawing.Point(285, 122);
            this.button_DisplaySelected.Name = "button_DisplaySelected";
            this.button_DisplaySelected.Size = new System.Drawing.Size(169, 57);
            this.button_DisplaySelected.TabIndex = 24;
            this.button_DisplaySelected.Text = "Display Selected Records     from   FrontEnd.AccDb";
            this.button_DisplaySelected.UseVisualStyleBackColor = false;
            this.button_DisplaySelected.Click += new System.EventHandler(this.button_DisplaySelected_Click);
            // 
            // label_Response
            // 
            this.label_Response.AutoSize = true;
            this.label_Response.Location = new System.Drawing.Point(490, 171);
            this.label_Response.Name = "label_Response";
            this.label_Response.Size = new System.Drawing.Size(92, 13);
            this.label_Response.TabIndex = 23;
            this.label_Response.Text = "number of records";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(37, 205);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(898, 233);
            this.dataGridView3.TabIndex = 22;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(108, 122);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(87, 25);
            this.button_Reset.TabIndex = 21;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Visible = false;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 25;
            // 
            // textBox_CMD3
            // 
            this.textBox_CMD3.Location = new System.Drawing.Point(482, 87);
            this.textBox_CMD3.Multiline = true;
            this.textBox_CMD3.Name = "textBox_CMD3";
            this.textBox_CMD3.Size = new System.Drawing.Size(402, 70);
            this.textBox_CMD3.TabIndex = 18;
            this.textBox_CMD3.Text = "select * from BasicQueries";
            // 
            // comboBox_Query
            // 
            this.comboBox_Query.FormattingEnabled = true;
            this.comboBox_Query.Location = new System.Drawing.Point(90, 87);
            this.comboBox_Query.Name = "comboBox_Query";
            this.comboBox_Query.Size = new System.Drawing.Size(367, 21);
            this.comboBox_Query.TabIndex = 12;
            this.comboBox_Query.Text = "Select a Table Name here before clicking  Display  button";
            this.comboBox_Query.SelectedIndexChanged += new System.EventHandler(this.comboBox_Query_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(105, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(633, 18);
            this.label22.TabIndex = 11;
            this.label22.Text = "Select a Table Name  from the drop-down list below,  then click the \'Display\' but" +
    "ton";
            // 
            // label_Ident
            // 
            this.label_Ident.AutoSize = true;
            this.label_Ident.Location = new System.Drawing.Point(948, 109);
            this.label_Ident.Name = "label_Ident";
            this.label_Ident.Size = new System.Drawing.Size(31, 13);
            this.label_Ident.TabIndex = 24;
            this.label_Ident.Text = " . . .";
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Return.Location = new System.Drawing.Point(12, 168);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(121, 62);
            this.button_Return.TabIndex = 0;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Display Selected Tables";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "order by DocNum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Search_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 603);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Search_Database";
            this.Text = "Utility Applications";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.button_Return, 0);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     //  private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_CMD3;
        private System.Windows.Forms.Button button_DisplaySelected;
        private System.Windows.Forms.ComboBox comboBox_Query;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label_Response;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Label label_Ident;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}