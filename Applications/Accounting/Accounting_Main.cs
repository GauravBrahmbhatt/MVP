using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  Applications.Applications. Accounting
{
    public partial class Accounting_Main : Accounting_Template 
    {
        public Accounting_Main(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(ident);
        }
        public Accounting_Main()
        {
            InitializeComponent();
            IdentityObject _ident = new IdentityObject();
            base.SaveIdent(_ident);
        }
      
        

        private void button_Receivable_Click(object sender, EventArgs e)
        {
            new Applications.Accounting.AccountReceivables.List_AccReceivables(ident).Show();//   AccountsReceivable.AccountsReceivable_Main(base.ident).Show();
           // new Applications.Accounting.NewApp(ident).Show();
        }

        private void button_Payable_Click(object sender, EventArgs e)
        {
             new AccountsPayable.AccountsPayable_Main(base.ident ).Show();
            //new Applications.Accounting.NewApp(ident).Show();
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
           // if (base.ident.ActionLevel > 5)
           if (6 > 5)
           {
             //  MessageBox.Show("this report is under construction"); return;
              new  Applications.Accounting.AccountsReports.AccountsReports_Main (base.ident).Show();
             //  new Applications.Accounting.NewApp(ident).Show();
            }
            else
            {

                MessageBox.Show("User name is not authorize to see the report");

            }

        }

        
        private void button_Transactions_Click(object sender, EventArgs e)
        {
            new Accounting.AccountsReports.AccountsReports_Main(ident).Show();
        }

        private void button_IntervalReports_Click(object sender, EventArgs e)
        {
             //    new IntervalReport().Show();
            new Applications.Accounting.NewApp(ident).Show();
      
        }

        private void button_PayableDocs_Click(object sender, EventArgs e)
        {
            // new AccountsPayable.PayableDocuments_Main(base.ident ).Show();
            new Applications.Accounting.NewApp(ident).Show();
          
        }

        private void button_ReceivableDocs_Click(object sender, EventArgs e)
        {
          //  new AccountsReceivable.Acc_Receivable_Main(base.ident).show(); 
            new Applications.Accounting.NewApp(ident).Show();
                 
        }

        private void button_SalesOrders_Click(object sender, EventArgs e)
        {
           // new AccountsReceivable.ListObjects(ident,"21").Show();
            new Applications.Accounting.NewApp(ident).Show();
      
        }

        private void button_ShippingDocs_Click(object sender, EventArgs e)
        {
           //  new Materials.Shipments.ListObjects(ident).Show();
            new Applications.Accounting.NewApp(ident).Show();
      
        }

        private void button_Deliveries_Click(object sender, EventArgs e)
        {
           // new Accounting.Transactions.ListObjects(ident, "ProcessDocs", "13").Show();
            new Applications.Accounting.NewApp(ident).Show();
      
        }
  
    }
}
