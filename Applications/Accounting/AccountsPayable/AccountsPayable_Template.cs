using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsPayable
{
    public partial class AccountsPayable_Template : HAWK_Template_2
    {
        public AccountsPayable_Template()
        {
            InitializeComponent();
        }

        public AccountsPayable_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
