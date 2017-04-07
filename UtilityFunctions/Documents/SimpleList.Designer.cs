namespace UtilityFunctions.Documents
{
    partial class SimpleList
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
            this.button_Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Command
            // 
            this.textBox_Command.Location = new System.Drawing.Point(271, 168);
            this.textBox_Command.Multiline = true;
            this.textBox_Command.Name = "textBox_Command";
            this.textBox_Command.Size = new System.Drawing.Size(208, 34);
            this.textBox_Command.TabIndex = 2;
            this.textBox_Command.Text = "select * from FileName";
            // 
            // button_Display
            // 
            this.button_Display.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Display.Location = new System.Drawing.Point(552, 160);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(134, 51);
            this.button_Display.TabIndex = 3;
            this.button_Display.Text = "Display";
            this.button_Display.UseVisualStyleBackColor = false;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 459);
            this.dataGridView1.TabIndex = 4;
            // 
            // SimpleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.textBox_Command);
            this.Name = "SimpleList";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.textBox_Command, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox textBox_Command;
        protected System.Windows.Forms.Button button_Display;
        protected System.Windows.Forms.DataGridView dataGridView1;
    }
}
