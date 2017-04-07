namespace Applications.UtilityFunctions
{
    partial class Chart_Template
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.cboChartType = new System.Windows.Forms.ComboBox();
            this.cbo_Reports = new System.Windows.Forms.ComboBox();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(183, 28);
            this.label_SubName.Text = "Charting Analysis";
            // 
            // chart1
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(177, 243);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(989, 478);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            // 
            // cboChartType
            // 
            this.cboChartType.FormattingEnabled = true;
            this.cboChartType.Location = new System.Drawing.Point(371, 160);
            this.cboChartType.Name = "cboChartType";
            this.cboChartType.Size = new System.Drawing.Size(119, 21);
            this.cboChartType.TabIndex = 4;
            this.cboChartType.Text = "Select Chart Type";
            this.cboChartType.SelectedIndexChanged += new System.EventHandler(this.cboChartType_SelectedIndexChanged);
            // 
            // cbo_Reports
            // 
            this.cbo_Reports.FormattingEnabled = true;
            this.cbo_Reports.Location = new System.Drawing.Point(564, 160);
            this.cbo_Reports.Name = "cbo_Reports";
            this.cbo_Reports.Size = new System.Drawing.Size(225, 21);
            this.cbo_Reports.TabIndex = 6;
            this.cbo_Reports.Text = "Select a Report";
            this.cbo_Reports.SelectedIndexChanged += new System.EventHandler(this.cbx_Reports_SelectedIndexChanged);
            // 
            // Chart_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 733);
            this.Controls.Add(this.cbo_Reports);
            this.Controls.Add(this.cboChartType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Chart_Template";
            this.Controls.SetChildIndex(this.chart1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.cboChartType, 0);
            this.Controls.SetChildIndex(this.cbo_Reports, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboChartType;
        private System.Windows.Forms.ComboBox cbo_Reports;
    }
}
