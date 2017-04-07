using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class ListObjects : Utilities.Documents.ListObjects
    {
        string position;
        public ListObjects()
        {
            InitializeComponent();
        }
        public ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        //--patty
        //--setting query
        public ListObjects(IdentityObject identObject, string tablename, string docType,string _position)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            base.DisplayIdent(identObject);
            /*
            LoadTableNames();
            LoadDocumentTypes();
            */           
            textBox_TableName.Text = tablename;
            textBox_DocType.Text = docType;
          //  comboBox_DocNum.SelectedIndex = 0;
            textBox_CMD.Text = String.Format("select * from {0} where docType = {1}", tablename, docType);

            position = _position;
        }

        public ListObjects(IdentityObject identObject, string tablename, string docType, int status, string _position)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            base.DisplayIdent(identObject);
            /*
            LoadTableNames();
            LoadDocumentTypes();
            */
            textBox_TableName.Text = tablename;
            textBox_DocType.Text = docType;
            //  comboBox_DocNum.SelectedIndex = 0;
            textBox_CMD.Text = String.Format("select * from {0} where docType = {1} and reqStatus={2}", tablename, docType, status);

            position = _position;
        }

        //--click reset button to reset query
        private void button_Reset_Click_1(object sender, EventArgs e)
        {
            ResetCommand();
        }


        //--patty


        private void button_Display_Click_1(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;
        }

        protected override void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            String docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (position == "emp")
            {
                new DisplaySelectedObject_emp(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();

            }
            else
            {
                new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();
            }
           
           // Applications.HR.HrBenefit.DisplaySelectedObject Display_Benefits_details = new Applications.HR.HrBenefit.DisplaySelectedObject(base.ident, "Benefits_details", "61", docNumStr);
            //Display_Benefits_details.Show();
        }

      
    }
}
