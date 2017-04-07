using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    public partial class Suppliers_Main : HAWK_Template_2 
    {
        public Suppliers_Main(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
        }

        private void button_ListALL_Click(object sender, EventArgs e)
        {
            this.Close();
            UtilityFunctions.Suppliers.List_Suppliers sl = new UtilityFunctions.Suppliers.List_Suppliers(base.ident);
            //  MessageBox.Show(" Suppliers_List was called");
             sl.Show();
   
        }

        private void button_DisplaySpecific_Click(object sender, EventArgs e)
        {
            this.Close();
            DisplaySupplier sd = new DisplaySupplier();
            //MessageBox.Show("Display Supplier was called");
             sd.Show();
   
        }

        private void button_CreateNew_Click(object sender, EventArgs e)
        {
           // this.Close();
           // AddSupplier crs = new AddSupplier(); crs.Show();
             MessageBox.Show("Create Supplier was called");
             
   
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
           // this.Close();
           // UpdateSupplier es = new UpdateSupplier(); es.Show();
            MessageBox.Show("Edit Supplier was called");
           
  
        }

        //private void button_Return_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //protected override void button_ListItems_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Suppliers_List sl = new Suppliers_List();
        //   // MessageBox.Show(" Suppliers_List was called");
        //      sl.Show();
    
        //}

        //protected override  void button_Display_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    DisplaySupplier sd = new DisplaySupplier();
        // //   MessageBox.Show("Display Supplier was called");
        //    sd.Show();
    
        //}

        //protected override void button_Create_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Create Supplier was called");
        //}
    }
}
