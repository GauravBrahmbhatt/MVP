using Applications.UtilityFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Infrastructure
{
    public partial class Infrastructure_Main : HAWK_Template_1 
    {
     
        public Infrastructure_Main(IdentityObject _ident_Object)
        {
            InitializeComponent();
            base.SaveIdent(_ident_Object);
            base.DisplayIdent(_ident_Object);
        }


        private void button_Transactions_Click(object sender, EventArgs e)
        {
          //  Accounting.Transactions.  Transactions_List app4 = new Infrastructure.Transactions_List(base.ident );   app4.Show();
        }

        private void button_Entitiess_Click(object sender, EventArgs e)
        {
            EntitiesPanel.Visible = true;
            // new UtilityFunctions.ListEntities(base.ident).Show();
        }


        private void buttonCustomers_Click(object sender, EventArgs e)
        {
         //   Utilities.Customer_List app = new Utilities.Customer_List(base.ident);        app.Show();
            new UtilityFunctions.ListEntities(base.ident, "2").Show();
  
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {

            //  UtilityFunctions.Employees.Employees_List2 el = new UtilityFunctions.Employees.Employees_List2(base.ident); el.Show();
            new UtilityFunctions.ListEntities(base.ident, "3").Show();
        }

        private void buttonApplicants_Click(object sender, EventArgs e)
        {
            new UtilityFunctions.ListEntities(base.ident, "4").Show();

        }

        private void button_Suppliers_Click(object sender, EventArgs e)
        {
          //  UtilityFunctions.Suppliers.List_Suppliers app = new UtilityFunctions.Suppliers.List_Suppliers(base.ident); app.Show();
            new UtilityFunctions.ListEntities(base.ident, "5").Show();
        }

        private void buttonMaterials_Click(object sender, EventArgs e)
        {
            new UtilityFunctions.ListEntities(base.ident, "6").Show();
            //Utilities.Products.Products_Main app = new Utilities.Products.Products_Main(base.ident); app.Show();
        }
        private void button_Services_Click(object sender, EventArgs e)
        {
            new UtilityFunctions.ListEntities(base.ident, "7").Show();

        }

        private void button_Documents_Click(object sender, EventArgs e)
        {
           Utilities.Documents.Documents_Main  disp2 = new Utilities.Documents.Documents_Main  (base.ident);// disp2.ShowDialog();
        }

        private void button_Processes_Click(object sender, EventArgs e)
        {
            Utilities.Processes.Process_List app = new Utilities.Processes.Process_List(base.ident); app.Show();
        }

        private void button_Charts_Click(object sender, EventArgs e)
        {
            new Chart_Template(ident).Show();
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            new UtilityFunctions.ImportData_Main(ident).Show();
        }

        private void button_UpdateAccounts_Click(object sender, EventArgs e)
        {
            new   Utilities.Documents.UpdateDocument ().Show();
        }
  
    
   
    }
}
