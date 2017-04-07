using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class HrBenefit_Role : HAWK_Template_2
    {
        public HrBenefit_Role()
        {
            InitializeComponent();
        }

     
        public HrBenefit_Role(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        //--patty
        private void HR_Admin_Benefit_Button_Click(object sender, EventArgs e)
        {
            new Applications.HR.HrBenefit.HrBenefit_HrAdmin(base.ident).Show();
        }

        private void Employee_Benefit_Button_Click(object sender, EventArgs e)
        {
            new Applications.HR.HrBenefit.HrBenefit_Employee(base.ident).Show();

          
        }

        //--patty
    }
}
