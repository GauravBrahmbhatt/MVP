using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations.Admin
{
    public partial class Admin_Main : HAWK_Template_2
    {
        public Admin_Main()
        {
            InitializeComponent();
        }
        public Admin_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Applications.Operations.Admin.ChangeData.ChangeData(ident).Show();
        }
    }
}
