using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Processes
{
    public partial class Process_List : Utilities.Process_Template
    {
        public Process_List(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            //_transactionIDs = Utilities.DataBaseUtility.GetList(" select transID from Transactions");
            //for (int i = 1; i < _transactionIDs.Count; i++)
            //    comboBox1.Items.Add(i.ToString() + " :  " + _transactionIDs[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable ;
        }
        private void ResetCommand()
        {
            string part1 = "select * from Processes ";
            string part2 = "";
            string part3 = "";
            if (comboBox1.SelectedIndex > 0)
                part2 = " where Type = " + comboBox1.SelectedIndex.ToString();
            if (comboBox2.SelectedIndex > 0)
            {
                if (comboBox1.SelectedIndex > 0)
                    part3 = " and status = " + comboBox2.SelectedItem.ToString() ;
                else part3 = " where status =  " + comboBox2.SelectedItem.ToString() ;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayProcess pds = new DisplayProcess(base.ident,dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            pds.Show();
  
        }

       
    }
}
