using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations.Employee
{
    public partial class Employee_Main : HAWK_Template_2
    {
        public Employee_Main()
        {
            InitializeComponent();
        }
        public Employee_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Applications.Operations.Employee.ViewAllServices.ViewAllServices(ident).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Applications.Operations.Employee.ViewCompleted.ViewCompletedServices(ident).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Applications.Operations.Employee.ViewPending.ViewPendingServices(ident).Show();
        }
    }
}
