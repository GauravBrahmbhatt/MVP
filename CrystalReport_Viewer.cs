using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    public partial class CrystalReport_Viewer : HAWK_Template_1 
    {
        public CrystalReport_Viewer()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button_DisplaySelectedObject_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer1.DisplayToolbar = true;
        }
    }

