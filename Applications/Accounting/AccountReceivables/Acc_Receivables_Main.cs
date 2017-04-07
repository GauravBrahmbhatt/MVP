using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class Acc_Receivables_Main : Applications.Accounting.AccountReceivables.Acc_Receivable_Template
    {

       
        public Acc_Receivables_Main()
        {
            this.components = null;
            InitializeComponent();
            base.Close();
        }


        public Acc_Receivables_Main(IdentityObject ident)
       {
        
        this.InitializeComponent();
        base.SaveIdent(ident);
        base.DisplayIdent(ident);
        Accounting.AccountReceivables.ListObjects lstObj = new AccountReceivables.ListObjects();
        lstObj.Show();
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            Accounting.AccountReceivables.ListObjects lstObj = new AccountReceivables.ListObjects();
            lstObj.Show();
        }

        private void button_DisplaySelected_Click(object sender, EventArgs e)
        {
            base.Close();
            Accounting.AccountReceivables.DisplaySelectedObject displayObj = new DisplaySelectedObject();
            displayObj.Show();
        }

       

      

    }
}
