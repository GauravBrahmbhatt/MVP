using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.HR
{
    public partial class HR_Main : Applications.HR.HR_Template
    {
        public HR_Main()
        {
            InitializeComponent();
        }
        public HR_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Applications.HR.Hiring.Hiring_Main(ident).Show();
        }

        private void button_Benefits_Click(object sender, EventArgs e)
        {
            new Applications.HR.HrBenefit.HrBenefit_Main(ident).Show();
        }
    }
}
