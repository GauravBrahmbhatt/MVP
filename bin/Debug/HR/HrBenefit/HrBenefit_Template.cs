using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class HrBenefit_Template : HAWK_Template_2
    {
        public HrBenefit_Template()
        {
            InitializeComponent();
           
        }
        public HrBenefit_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void HR_Benefits_Button_Click(object sender, EventArgs e)
        {
            new Applications.HR.HrBenefit.HrBenefit_Role(base.ident).Show();
        }
    }
}
