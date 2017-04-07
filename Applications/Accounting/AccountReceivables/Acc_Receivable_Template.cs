using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class Acc_Receivable_Template : HAWK_Template_2
    {
        public Acc_Receivable_Template()
        {
            InitializeComponent();
        }

        public Acc_Receivable_Template(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
        }

        private void button_DisplaySelected_Click(object sender, EventArgs e)
        {
            base.Close();
            Accounting.AccountReceivables.DisplaySelectedObject displayObj = new DisplaySelectedObject();
            displayObj.Show();
           
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            Accounting.AccountReceivables.ListObjects lstObj = new AccountReceivables.ListObjects();
            lstObj.Show();
        }

  
    }
}
