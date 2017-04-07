using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Payroll
{
    public partial class Payroll_Template : HAWK_Template_2
    {
        public Payroll_Template()
        {
            InitializeComponent();
        }
       public Payroll_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
