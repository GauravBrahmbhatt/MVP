using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    public partial class Suppliers_List : Suppliers_Template 
    {
        public Suppliers_List()
        {
            InitializeComponent();
        }
        public Suppliers_List(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent( identObject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable ;
            dataGridView1.Visible = true;
        }
        private void ResetCommand()
        {
            string part1 = "select * from Suppliers ";
            string part2 = "";
            string part3 = "";
       
            textBox_CMD.Text = part1 + part2 + part3;
        }

       

  

      
        private void button3_Click(object sender, EventArgs e)
        {
            DisplaySupplier app2 = new DisplaySupplier();
            app2.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ( (base.ident.Role != "manager"))
            {
                MessageBox.Show("Only authorized managers and can create new suppliers", "improper credentials");
                return;
            }
            //Create Sales Order
            //CreateSalesOrder form1 = new CreateSalesOrder(false, 0);
            //form1.Show();
        }
       
        //private void button6_Click_1(object sender, EventArgs e)
        //{
        //    UpdateSupplier form4 = new UpdateSupplier();
        //    form4.Show();
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySupplier pds = new DisplaySupplier(base.ident, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            pds.Show();
        }

       
    }
}
