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
namespace Utilities.Customers
{
    public partial class ApplicantionForm : HAWK_Template_2    
    {
        List<String> _EmployeeNames;
        DataTable _employeeValues;

        public ApplicantionForm()
        {
            InitializeComponent();
            panel3.Visible = true;
        }
        public  ApplicantionForm (IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            LoadEmployees();
            comboBox1.SelectedIndex = 1;
            panel3.Visible = true;
        }
 
        public  ApplicantionForm (IdentityObject _ident,string indx)
        {
            InitializeComponent();
            panel3.Visible = true;
            base.SaveIdent(_ident);
            LoadEmployees();
            textBox_AppID.Text = indx;
            panel3.Visible = true;
            button_Display_Click(this, null);

        }

        private void LoadEmployees()
        {
            comboBox1.Items.Clear();
            _EmployeeNames = Utilities.DataBaseUtility.GetList(" select * from Job_Applicants", ',');
         //   dataGridView1.DataSource = _employeeValues;
            for (int i = 1; i < _EmployeeNames.Count; i++)
            {
                string[] _items = _EmployeeNames[i].Split(',');
                comboBox1.Items.Add(_items[0].Trim() + " :  " + _items[2].Trim());
                //   comboBox1.Items.Add(_employeeValues[i]);
            }
    
        }

    
        private void ResetBoxes()
        {
            textBox_FirstName.Text = "";
            textBox_LastName.Text = "";
            textBox_Address.Text = "";
            textBox_Address2.Text = "";
            textBox_City.Text = "";
            textBox_State.Text = "";
            textBox_ZipCode.Text = "";
        //    txtCountry.Text = "";
        //    txtAmountDue.Text = "";
       
        }
            private void button_Display_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            string appStr = "select * from Job_Applicants where DocNum = " + textBox_AppID.Text;
            _employeeValues = Utilities.DataBaseUtility.GetTable(appStr);
            //    dataGridView1.DataSource = _employeeValues;
            textBox_FirstName.Text = _employeeValues.Rows[0][2].ToString();
            textBox_LastName.Text = _employeeValues.Rows[0][3].ToString();
            //textBox_Role.Text = _employeeValues.Rows[0][3].ToString();
            //textBox_Department.Text = _employeeValues.Rows[0][4].ToString();
            //textBox_AdmLevel.Text = _employeeValues.Rows[0][5].ToString();
            textBox_Address.Text = _employeeValues.Rows[0][4].ToString();
            textBox_Address2.Text = _employeeValues.Rows[0][5].ToString();
            textBox_City.Text = _employeeValues.Rows[0][6].ToString();
            textBox_State.Text = _employeeValues.Rows[0][7].ToString();
            textBox_ZipCode.Text = _employeeValues.Rows[0][8].ToString();
            //textBox_Country.Text = "USA";
            textBox_Phone2.Text = _employeeValues.Rows[0][10].ToString();
           // textBox_Phone2.Text = _employeeValues.Rows[0][11].ToString();
            textBox_Email.Text = _employeeValues.Rows[0][12].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_AppID.Text = (comboBox1.SelectedItem).ToString().Substring(0,3).TrimEnd();
            ResetBoxes();
            panel3.Visible = false;
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
           int applicantID = 1 + Utilities.DataBaseUtility.GetLastNumber("Customers", 0, 0, 999);
           DialogResult dr = MessageBox.Show("are you sure that you want to save ?", "Verify Operation",
                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
           if (dr == DialogResult.No)
           {
               MessageBox.Show(" Operation Cancelled by user ");
               return;
           }
           //   (response == "yes") 
           string _tableName = "Customers";
           Utilities.DataBaseUtility.DeleteDocument(base.ident, "Customers", textBox_AppID.Text, "4");
           string cmdString = String.Format("insert into {0} Values ({1})", _tableName.Trim(), textBox_Data.Text);    //where DocNum = {1} and DocType = {2}", _tableName, inDocNum, inDocType);
           string retMessage = Utilities.DataBaseUtility.Execute(cmdString, ident);

        }

        private void button_ChangeObject_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button_Validate_Click(object sender, EventArgs e)
        {
            List<string> datastrings = new List<string>();
            StringBuilder dataString1 = new StringBuilder();
            textBox_DocNum.Text = (1 + Utilities.DataBaseUtility.GetLastNumber("customers",0,0,199) ).ToString();   
          //  textBox_Phone.Text = textBox_Phone2.Text;
          //  textBox_Email2.Text = textBox_Email.Text; 
            dataString1.Append(textBox_DocNum.Text + " ,"); //  DocNum
            dataString1.Append(" 4 , ");                  //textBox_DocType.Text
            dataString1.Append("'" + textBox_FirstName.Text  + "' ,");
            dataString1.Append("'" + textBox_LastName.Text  + "' ,");
            dataString1.Append("'" + textBox_Address.Text + "' ,");
            dataString1.Append("'" + textBox_Address2.Text + "' ,");
            dataString1.Append("'" + textBox_City.Text + "' ,");
            dataString1.Append("'" + textBox_State.Text + "' ,");
            dataString1.Append("'" + textBox_ZipCode.Text + "' ,");
            dataString1.Append("'USA' ,");
            dataString1.Append("'" + textBox_Phone.Text + "' ,");
            dataString1.Append("'" + textBox_Phone2.Text + "' ,");
            dataString1.Append("'" + textBox_Email.Text + "' ,");
            dataString1.Append( "' ', ");
            dataString1.Append("' ', ");
            dataString1.Append("' ', ");
            textBox_Comment.Text =  textBox_FirstName.Text + " " + textBox_LastName.Text;  
            dataString1.Append("'" + textBox_Comment.Text + "'");
         //   Applicant newApplicant = new Applicant(dataString1.ToString());
            textBox_Data.Text = dataString1.ToString();
          
        }

        private void button_DisplaySelected_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

            
    }
}
