using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Applications
{
    public partial class Applications_DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        List<String> _Applications;
        DataTable _ApplicationValues;
        public Applications_DisplaySelectedObject()
        {
            InitializeComponent();
        }
        public Applications_DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            LoadApplications();
        }
        public Applications_DisplaySelectedObject(IdentityObject ident, string tableName, string docType, string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
            textBox_DocType.Text = docType;
            textBox_TableName.Text = tableName;
            button_ResetCommand_Click(this, null);
            LoadApplications();
        }
        private void LoadApplications()
        {

            _Applications = Utilities.DataBaseUtility.GetList("select * from Applications", ',');
            for (int i = 1; i < _Applications.Count; i++)
            {
                string[] _items = _Applications[i].Split(',');
                comboBox1.Items.Add(_items[0].Trim() + " :  " + _items[3].Trim());
                //  comboBox1.Items.Add(_employeeValues[i]);
            }
        }

        private void button_DisplayDoc_Click(object sender, EventArgs e)
        {
            _ApplicationValues = Utilities.DataBaseUtility.GetTable("select * from Applications_details where DocNum = " + textBox_DocNum.Text);
            dataGridView1.DataSource = _ApplicationValues;


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox_DocNum.Text = (comboBox1.SelectedItem).ToString().Substring(0, 3).TrimEnd();

        }

        private void button_ChangeDoc_Click(object sender, EventArgs e)
        {

        }

    }
}
