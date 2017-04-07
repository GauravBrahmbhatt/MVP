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
    public partial class Materials_List : Products_Template 
    {
        List<string> _supplierNames;
        public Materials_List()
        {
            InitializeComponent();
            _supplierNames = Utilities.DataBaseUtility.GetList(" select Name from suppliers");
            for (int i = 1; i < 8; i++)
                   comboBox1.Items.Add(i.ToString() + " :  " + _supplierNames[i]);
        }
        public Materials_List(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            _supplierNames = Utilities.DataBaseUtility.GetList(" select Name from suppliers");
            for (int i = 1; i < 8; i++)
                comboBox1.Items.Add(i.ToString() + " :  " + _supplierNames[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable ;
            dataGridView1.Visible = true;
        }
        private void ResetCommand()
        {
            string part1 = "select * from Products ";
            string part2 = "";
            string part3 = "";
            if (comboBox1.SelectedIndex > 0)
                part2 = " where supplier = " + comboBox1.SelectedIndex.ToString();
            if (comboBox2.SelectedIndex > 0)
            {
                if (comboBox1.SelectedIndex > 0)
                    part3 = " and Category = '" + comboBox2.SelectedItem.ToString() + "'";
                else part3 = " where Category =  '" + comboBox2.SelectedItem.ToString() +"'";
            }
            textBox_CMD.Text = part1 + part2 + part3;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Supplier.Text = comboBox1.SelectedItem.ToString();
            ResetCommand();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Status.Text = comboBox2.SelectedItem.ToString();
            ResetCommand();
   
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    PurchaseOrderDisplay app2 = new PurchaseOrderDisplay();
        //    app2.Show();
        //}
        private void button4_Click(object sender, EventArgs e)
        {
           // if ((_ident.Role != "sales") && (_ident.Role != "manager"))
            {
                MessageBox.Show("Only authorized managers and sales employees can create sales orders", "improper credentials");
                return;
            }
            //Create Sales Order
            //CreateSalesOrder form1 = new CreateSalesOrder(false, 0);
            //form1.Show();
        }
       
        private void button6_Click_1(object sender, EventArgs e)
        {
            //UpdateSalesOrder form1 = new UpdateSalesOrder();
            //form1.Show();
        }

        private void buttonSpecificProduct_Click(object sender, EventArgs e)
        {
            Utilities.Materials.DisplayProduct app2 = new Utilities.Materials.DisplayProduct(ident);
            app2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //   DisplaySelectedMaterial pds = 
                new Utilities.Materials.DisplayProduct (ident, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
            
        }

       
    }
}
