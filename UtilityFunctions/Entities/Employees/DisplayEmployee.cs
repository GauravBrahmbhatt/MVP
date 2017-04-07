using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb ;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Utilities.Employees
{
    public partial class DisplayEmployee : Employees_Template    
    {
        List<String> _EmployeeNames;
        DataTable _employeeValues;

        public DisplayEmployee()
        {
            InitializeComponent();
        }
        public  DisplayEmployee (IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            LoadEmployees();
            comboBox1.SelectedIndex = 1;
        }
 
        public  DisplayEmployee (IdentityObject _ident,string indx)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            LoadEmployees();
            textBox0.Text = indx;
            button1_Click(this, null);

        }

        private void LoadEmployees()
        {
            comboBox1.Items.Clear();
            _EmployeeNames = Utilities.DataBaseUtility.GetList(" select * from Employees", ',');
            dataGridView1.DataSource = _employeeValues;
            for (int i = 1; i < _EmployeeNames.Count; i++)
            {
                string[] _items = _EmployeeNames[i].Split(',');
                comboBox1.Items.Add(_items[0].Trim() + " :  " + _items[2].Trim());
                //   comboBox1.Items.Add(_employeeValues[i]);
            }
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBoxes()
        {
            textBox_FirstName.Text = "";
            txtAddr.Text = "";
            txtAddr2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZIP.Text = "";
        //    txtCountry.Text = "";
        //    txtAmountDue.Text = "";
       
        }
            private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            _employeeValues = Utilities.DataBaseUtility.GetTable("select * from Employees where DocNum = " + textBox0.Text);
            dataGridView1.DataSource = _employeeValues;
            textBox_FirstName.Text = _employeeValues.Rows[0][1].ToString();
            textBox_LastName.Text = _employeeValues.Rows[0][2].ToString();
            textBox_Role.Text = _employeeValues.Rows[0][3].ToString();
            textBox_Department.Text = _employeeValues.Rows[0][4].ToString();
            textBox_AdmLevel.Text = _employeeValues.Rows[0][5].ToString();
            txtAddr.Text = _employeeValues.Rows[0][6].ToString();
            txtAddr2.Text = _employeeValues.Rows[0][7].ToString();
            txtCity.Text = _employeeValues.Rows[0][8].ToString();
            txtState.Text = _employeeValues.Rows[0][9].ToString();
            txtZIP.Text = _employeeValues.Rows[0][10].ToString();
            textBox_Phone.Text = _employeeValues.Rows[0][11].ToString();
            textBox_Email.Text = _employeeValues.Rows[0][12].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox0.Text = (comboBox1.SelectedItem).ToString().Substring(0,3).TrimEnd();
            ResetBoxes();
            panel3.Visible = false;
        }

      
    }
}
