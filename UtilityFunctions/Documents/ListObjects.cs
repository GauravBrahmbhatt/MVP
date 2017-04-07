using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Documents
{
    public partial class ListObjects : Document_Template
    {
       List<string> _documentIDs;
        public ListObjects()
        {
            InitializeComponent();
            base.SaveIdent(new IdentityObject());
            base.DisplayIdent(new IdentityObject());
            //   loadCmd1 = " select docNum, docType, comments from GenDocs";
            LoadTableNames();
            LoadDocumentTypes();
        }
        public ListObjects(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            base.DisplayIdent(identObject);
            //  loadCmd1 = " select docType, description from DocumentTypes";
            LoadTableNames();
            LoadDocumentTypes();
            comboBox_DocType.SelectedIndex = 0;
            comboBox_DocNum.SelectedIndex = 0;
        }
        public ListObjects(IdentityObject identObject, string tablename, string docType)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            base.DisplayIdent(identObject);
            //  loadCmd1 = " select docType, description from DocumentTypes";
            LoadTableNames();
            LoadDocumentTypes();
            textBox_TableName.Text = tablename;
            textBox_DocType.Text = docType;
            textBox_CMD.Text = String.Format("select * from {0} where docType = {1}",tablename,docType);
        }

        protected virtual void button_Display_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable;
            dataGridView1.Visible = true;
        }

        protected virtual void ResetCommand()
        {
            string part1 = "select * from " + textBox_TableName.Text;
            string part2 = "";
            string part3 = "";
            if (comboBox_DocType.SelectedIndex > 0)
                part2 = " where docType = " + textBox_DocType.Text;
            if (comboBox_DocNum.SelectedIndex > 0)
            {
                if (comboBox_DocType.SelectedIndex > 0)
                    part3 = " and DocNum =  " + textBox_DocNum.Text; // comboBox_DocNum.SelectedItem.ToString();
                else part3 = " where DocNum =  " + textBox_DocNum.Text; //comboBox_DocNum.SelectedItem.ToString();
            }
            textBox_CMD.Text = part1 + part2 + part3;
        }

        //protected virtual void LoadComboBox1(string loadCmd1,string target)
        //{
        //   _documentIDs = Utilities.DataBaseUtility.GetList( loadCmd1 );
        //   for (int i = 1; i < _documentIDs.Count; i++)
        //   {
        //       string[] fields =  _documentIDs[i].Split(',');
        //       comboBox_DocType.Items.Add(fields[0] + " ,  " +fields[1]);
        //       if (fields[0].Trim() == target.Trim())  return;
        //   }
      
          //List<string> _documentIdValues = Utilities.DataBaseUtility.GetList(" select DocNum, DocType, comments from GenDocs");
          // for (int i = 1; i < _documentIdValues.Count; i++)
          // {
          //     string[] 
          //     comboBox1.Items.Add(_documentValues.Rows[i][0].ToString() + " , " + _documentValues.Rows[i][1].ToString()
          //                      + " , " + _documentValues.Rows[i][2].ToString());
          // }
       // }
           

        protected virtual void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] items = comboBox_DocType.SelectedItem.ToString().Split(',');
            textBox_DocType.Text = items[0].Trim();
            textBox_TableName.Text = items[0].Trim();
            // ResetCommand();
        }
        protected virtual void LoadTableNames()
        {    // (1) Download a table of queries
             //   DataTable queryTable = new DataTable();
            List<string> queryList = Utilities.DataBaseUtility.GetList("select * from BasicQueries order by TableName");
            int numReturned = queryList.Count - 1;
            comboBox_TableName.Items.Clear();
            comboBox_TableName.Items.Add("ProcessDocs");
            for (int i = 1; i <= numReturned; i++)
            {
                string[] fields = queryList[i].Split(',');
                comboBox_TableName.Items.Add(fields[0]);

            }
        }
        protected virtual  void LoadDocumentTypes()
        {    // (1) Download a List of DocTypes
            textBox_CMD.Text = "";
            //   DataTable queryTable = new DataTable();
            List<string> queryList = Utilities.DataBaseUtility.GetList("select * from DocumentTypes");
            int numReturned = queryList.Count - 1;
            comboBox_DocType.Items.Clear();
            comboBox_DocType.Items.Add(" 0 , no type selected"); 
            for (int i = 1; i < numReturned; i++)
            {
                string[] fields = queryList[i].Split(',');
                comboBox_DocType.Items.Add(fields[0] + "  ,  " + fields[1] + "  ,  " + fields[2]);

            }
        }

        protected virtual void comboBox_TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = comboBox_TableName.SelectedItem.ToString().Split(',');
            textBox_TableName.Text = fields[0].Trim();

            textBox_CMD.Text = String.Format("select * from {0} ", textBox_TableName.Text);
            //   ResetCommand();

        }
        protected virtual void comboBox_DocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = comboBox_DocType.SelectedItem.ToString().Split(',');
            textBox_DocType.Text = fields[0].Trim();
          //  if (comboBox_DocType.SelectedIndex > 0)  textBox_TableName.Text = fields[1].Trim();
            textBox_CMD.Text = String.Format("select * from {0} where DocType = {1}", textBox_TableName.Text, textBox_DocType.Text);
            //   ResetCommand();

        }

        protected virtual void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();
        
        }

        protected virtual void button_Reset_Click(object sender, EventArgs e)
        {
            ResetCommand();
        }

       
    }
}
