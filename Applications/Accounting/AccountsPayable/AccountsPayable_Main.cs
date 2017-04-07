using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsPayable
{
    public partial class AccountsPayable_Main : Accounting.AccountsPayable.AccountsPayable_Template
    {
        public AccountsPayable_Main()
        {
            InitializeComponent();
        }
        public AccountsPayable_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AccountsPayable.AccountsPayableListObjects(base.ident).Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AccountsPayable.AccountsPayableListObjects(base.ident).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accounting.AccountsPayable.AcccountPayable_CrystalReport

            rept = new Accounting.AccountsPayable.AcccountPayable_CrystalReport();

            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();

            CR_Form.crystalReportViewer1.ReportSource = rept;

            CR_Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AccountsPayable.DisplayEmployee(base.ident).Show();
        }

       

    }
}
