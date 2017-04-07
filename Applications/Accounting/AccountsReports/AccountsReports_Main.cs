using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsReports
{
    public partial class AccountsReports_Main : Applications.Accounting.AccountsReports.AccountsReport_Template
    {
        public AccountsReports_Main()
        {
            InitializeComponent();
        }

        public AccountsReports_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            CreateTransaction CT = new CreateTransaction();
            CT.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTransaction dtr = new DisplayTransaction();
            dtr.Show();
        }

        private void button_CrystalReport_Click_Click(object sender, EventArgs e)
        {
            AccountsReports.CrystalReport1 rept = new AccountsReports.CrystalReport1();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();

        }
    }
}
