namespace Utilities.Employees
{
    partial class CreateEmployee
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
            this.label_CantDo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            this.panel_TopPanel.SuspendLayout();
         //   this.panel_LeftControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CantDo
            // 
            this.label_CantDo.AutoSize = true;
            this.label_CantDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CantDo.Location = new System.Drawing.Point(191, 211);
            this.label_CantDo.Name = "label_CantDo";
            this.label_CantDo.Size = new System.Drawing.Size(600, 24);
            this.label_CantDo.TabIndex = 2;
            this.label_CantDo.Text = "Create Employee can not be accessed  with current credentials";
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.label_CantDo);
            this.Name = "CreateEmployee";
            this.Text = "Create Employee";
            this.Controls.SetChildIndex(this.label_CantDo, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
         //   this.Controls.SetChildIndex(this.panel_LeftControlPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
          //  this.panel_LeftControlPanel.ResumeLayout(false);
          //  this.panel_LeftControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CantDo;
    }
}
