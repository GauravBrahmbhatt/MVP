using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class HrBenefit_Employee : HAWK_Template_2
    {
        public HrBenefit_Employee()
        {
            InitializeComponent();
        }

        public HrBenefit_Employee(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_view_all_Click(object sender, EventArgs e)
        {
            Applications.HR.HrBenefit.ListObjects List_Benefits = new Applications.HR.HrBenefit.ListObjects(base.ident, "Benefits", "61","emp");
            List_Benefits.Show();
        }

        private void button_view_my_own_Click(object sender, EventArgs e)
        {
            Applications.HR.HrBenefit.ListObjects List_Benefits_emp = new Applications.HR.HrBenefit.ListObjects(base.ident, "EmployeeBenefits", "65", "emp");
            List_Benefits_emp.Show();
        }
    }
}
