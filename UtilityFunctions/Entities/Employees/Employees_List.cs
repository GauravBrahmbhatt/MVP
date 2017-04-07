using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Employees
{
    public partial class Employees_List : Utilities.Employees.Employees_Template
    {
        List<string> _employeeIDs;
        public Employees_List(IdentityObject identObject)
        {
            InitializeComponent();
             base.SaveIdent(identObject);
             _employeeIDs = Utilities.DataBaseUtility.GetList(" select EmplID, LastName from employees");
             for (int i = 1; i < _employeeIDs.Count; i++)
                 comboBox1.Items.Add(_employeeIDs[i]  + " : ");
        }

        private void ResetCommand()
        {
            string part1 = "select * from employees ";
            string part2 = "";
            string part3 = "";
            if (comboBox1.SelectedIndex > 0)
                part2 = " where DeptID = " + comboBox1.SelectedIndex.ToString();
            if (comboBox2.SelectedIndex > 0)
            {
                if (comboBox1.SelectedIndex > 0)
                    part3 = " and Role = '" + comboBox2.SelectedItem.ToString() +"'";
                else part3 = " where Role =  '" + comboBox2.SelectedItem.ToString() + "'";
            }
            textBox_CMD.Text = part1 + part2 + part3;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Supplier.Text = comboBox1.SelectedIndex.ToString();
            ResetCommand();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Status.Text = comboBox2.SelectedItem.ToString();
            ResetCommand();
   
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayEmployee pds = new DisplayEmployee( base.ident , dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            pds.Show();
  
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
               DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
               dataGridView1.DataSource = dtable ;
        }

           
    }
}
