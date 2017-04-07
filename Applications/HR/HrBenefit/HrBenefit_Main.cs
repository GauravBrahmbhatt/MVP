using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class HrBenefit_Main : Applications.HR.HrBenefit.HrBenefit_Template
    {
        public HrBenefit_Main()
        {
            InitializeComponent();
        }
        public HrBenefit_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
