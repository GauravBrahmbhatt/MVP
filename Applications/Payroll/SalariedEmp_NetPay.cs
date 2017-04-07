using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Applications.Applications.Payroll
{
    public partial class NetPay_SalariedEmpl : Utilities.Documents.ListObjects
    {
        public NetPay_SalariedEmpl()
        {
            InitializeComponent();
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            String query = "Select Deduction_Amt, Comment from Deductions_Details where Emp_ID=104";
            char Delim=',';

            List<String> details = new List<String>();

            details = DataBaseUtility.GetList(query, Delim);

            for (int i = 0; i < details.Count; i++)
            { 
                
            }
            
        }
    }
}
