using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsPayable
{
    public partial class DisplayEmployee : Utilities.Employees.DisplayEmployee
    {
        public DisplayEmployee()
        {
            InitializeComponent();
        }

        public DisplayEmployee(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }



    }
}
