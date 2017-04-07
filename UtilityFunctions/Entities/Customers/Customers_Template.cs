using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    public partial class Customers_Template : HAWK_Template_2 
    {
       // IdentityObject ident;  base.ident
        public Customers_Template()
        {
            InitializeComponent();
        }

        private void button_ListALL_Click(object sender, EventArgs e)
        {
     
        }

        private void button_DisplaySpecific_Click(object sender, EventArgs e)
        {
            this.Close();
            DisplayCustomer dsa = new DisplayCustomer(ident);
            dsa.Show();  
        }

        private void button_CreateNew_Click(object sender, EventArgs e)
        {
            this.Close();
            //CreateCustomer cna = new CreateCustomer();         cna.Show();
  
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
         //   UpdateSupplier   es = new UpdateSupplier  ();
         //   es.Show();
  
        }

        //private void button_Return_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer_List cal = new Customer_List(ident);
            cal.Show();
   
        }

        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            this.Close();
            DisplayCustomer dsa = new DisplayCustomer(ident);
            dsa.Show();
   
        }

        //protected override void button_Create_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    CreateCustomer cna = new CreateCustomer();
        //    cna.Show();
   
        //}

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DisplayCustomer dsa = new DisplayCustomer(ident);
            dsa.Show();
   
        }

        //private void button_Create_Click_1(object sender, EventArgs e)
        //{
        //    this.Close();
        //    CreateCustomer cna = new CreateCustomer();
        //    cna.Show();
   
        //}

        //private void button_ListItems_Click_1(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Customer_List cal = new Customer_List(ident);
        //    cal.Show();
   
        //}

    }
}
