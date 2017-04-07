using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Applications.UtilityFunctions
{
    public partial class Chart_Template : HAWK_Template_2
    {
        //List of reports - can be expanded
        List<string> reportsList = new List<string>(){
                                                       "1.Project Cost by Month", 
                                                       "2.Project Cost by Task", 
                                                       "3.Project Progress by Month", 
                                                       "4.Project Progress by Task" 
                                                      };


        public Chart_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            LoadChartTypes();
            LoadReports();
        }

        //Menthod to be used by application teams.
        private void GetChartData(List<string> queryList, string chartTitle, string legendX, string legendY, string labelFormat)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[0].Name = "Estimated " + legendY;
            this.chart1.Series[1].Name = "Actual " + legendY;
            chart1.Titles.Add(chartTitle);
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = labelFormat;
            chart1.ChartAreas[0].Axes[0].Title = legendX;
            chart1.ChartAreas[0].Axes[1].Title = legendY;

            // List<string> queryList = Utilities.DataBaseUtility.GetList("select * from Service_Order WHERE numvalue1 <> 0");
            //List<string> queryList = Utilities.DataBaseUtility.GetList("select e.DocType, e.Current, a.Current from ProjectsActualByMonth a, ProjectsEstByMonth e WHERE e.DocNum = a.DocNum AND e.DocType = a.DocType");
            //List<string> queryList = Utilities.DataBaseUtility.GetList("SELECT [e.DocType], [e.Current], [a.Current] FROM [ProjectsEstByMonth] AS [e] INNER JOIN [ProjectsActualByMonth] AS [a] ON e.[DocType] = a.[DocType] AND e.[DocNum] = a.[DocNum]");
            queryList.RemoveAt(0);
            queryList.RemoveAt(0);

            foreach (var value in queryList)
            {
                string[] fields = value.Split(',');
                this.chart1.Series[0].Points.AddXY(fields[0].ToString(), fields[1].ToString());
                this.chart1.Series[1].Points.AddXY(fields[0].ToString(), fields[2].ToString());
            }
        }

        //Event handler to fetch and pass arguments to GetChartData() 
        public virtual void cbx_Reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChartType.Visible = true;
            chart1.Titles.Clear();
            List<string> queryList = null;
            string chartTitle = cbo_Reports.SelectedItem.ToString();
            string legendX = null;
            string legendY = null;
            string labelFormat = null;
            switch (cbo_Reports.SelectedItem.ToString().Substring(0, 1))
            {
                case "1":
                    queryList = Utilities.DataBaseUtility.GetList("SELECT [e.DocType], [e.Current], [a.Current] FROM [ProjectsEstByMonth] AS [e] INNER JOIN [ProjectsActualByMonth] AS [a] ON e.[DocType] = a.[DocType] AND e.[DocNum] = a.[DocNum]");
                    legendY = "Cost";
                    legendX = "Month";
                    labelFormat = "C";
                    break;

                case "2":
                    queryList = Utilities.DataBaseUtility.GetList("SELECT [e.DocType], [e.Cost], [a.Cost] FROM [ProjectsEstByTask] AS [e] INNER JOIN [ProjectsActualByTask] AS [a] ON e.[DocType] = a.[DocType] AND e.[DocNum] = a.[DocNum]");
                    legendY = "Cost";
                    legendX = "Task";
                    labelFormat = "C";
                    break;

                case "3":
                    queryList = Utilities.DataBaseUtility.GetList("SELECT [e.DocType], [e.added], [a.added] FROM [ProjectsEstByMonth] AS [e] INNER JOIN [ProjectsActualByMonth] AS [a] ON e.[DocType] = a.[DocType] AND e.[DocNum] = a.[DocNum]");
                    legendY = "Percent";
                    legendX = "Month";
                    break;

                case "4":
                    queryList = Utilities.DataBaseUtility.GetList("SELECT [e.DocType], [e.duration], [a.duration] FROM [ProjectsEstByTask] AS [e] INNER JOIN [ProjectsActualByTask] AS [a] ON e.[DocType] = a.[DocType] AND e.[DocNum] = a.[DocNum]");
                    legendY = "Duration";
                    legendX = "Task";
                    break;
            }

            GetChartData(queryList, chartTitle, legendX, legendY, labelFormat);

        }



        //Populate combobox of reports
        public virtual void LoadReports()
        {
            foreach (var value in reportsList)
            {
                cbo_Reports.Items.Add(value.ToString());
            }
            
        }

        //Populate combobox of chart types
        private void LoadChartTypes()
        {

            foreach (var value in System.Enum.GetValues(typeof(SeriesChartType)))
            {
                cboChartType.Items.Add(value.ToString());
            }

            cboChartType.Visible = false;
        }



        //Event handler to change chart types
        private void cboChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboChartType.Items.Clear();
            //  GetChartData();
            this.chart1.Series[0].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cboChartType.SelectedItem.ToString(), true);
            this.chart1.Series[1].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cboChartType.SelectedItem.ToString(), true);
        }




    }
}
