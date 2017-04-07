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
    public partial class Customer_List : Customers_Template   
    {
        //  IdentityObject ident;  defined in HACS_Template2  
        public Customer_List(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable;
            dataGridView1.Visible = true;
        }
        private void ResetCommand()
        {
            string part1 = "select * from Customers ";
            string part2 = "";
            string part3 = "";
            if (comboBox1.SelectedIndex > 0)
                part2 = " where City = '" + textBox_Customer.Text.Trim() +"'";
            textBox_CMD.Text = part1 + part2 + part3;
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Customer.Text = comboBox1.SelectedItem.ToString();
            ResetCommand();
        }

        private void button_DisplayCustomer_Click(object sender, EventArgs e)
        {
            DisplayCustomer form3 = new DisplayCustomer(ident);
            form3.Show();
    
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
         //   CreateCustomer form4 = new CreateCustomer();            form4.Show();
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayCustomer pds = new DisplayCustomer(ident, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            pds.Show();
  
        }


    }
}
