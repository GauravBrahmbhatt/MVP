using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    public partial class Suppliers_Template : HAWK_Template_2   
    {
        public Suppliers_Template()
        {
            InitializeComponent();
        }

        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            this.Close();
            UtilityFunctions.Suppliers.List_Suppliers sl = new UtilityFunctions.Suppliers.List_Suppliers(base.ident ); sl.Show();
            //MessageBox.Show(" Suppliers_List was called");
          

        }

        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            this.Close();
            DisplaySupplier sd = new DisplaySupplier(); sd.Show();
   
           //MessageBox.Show("Display Supplier was called");
        
        }

        //protected override  void button_Create_Click(object sender, EventArgs e)
        //{
        //   // this.Close();
        //   // AddSupplier crs = new AddSupplier(); crs.Show();
   
        //   MessageBox.Show("Create Supplier was called");
           
        //}

        private void button_Edit_Click(object sender, EventArgs e)
        {
           // this.Close();
           // UpdateSupplier es = new UpdateSupplier(); es.Show();
            MessageBox.Show("Edit Supplier was called");
          
  
        }

   
        //protected void button_ListItems_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Suppliers_List sl = new Suppliers_List();
        //   // MessageBox.Show(" Suppliers_List was called");
        //      sl.Show();
    
        //}

        //protected  void button_Display_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    DisplaySupplier sd = new DisplaySupplier();
        // //   MessageBox.Show("Display Supplier was called");
        //    sd.Show();
    
        //}

        //protected void button_Create_Click_1(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Create Supplier was called");
        //}
    }
}
