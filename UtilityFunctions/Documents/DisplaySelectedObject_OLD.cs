using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Documents
{
    public partial class DisplaySelectedObject : Document_Template  
    {
        List<String>  _documentValues;
        int DocumentID, DocumentType;
        string cmdStr;
        public DisplaySelectedObject(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent( _ident);
            LoadBBasicDocInfo();
            
        }
        public DisplaySelectedObject()
        {
            InitializeComponent();
            LoadSelectionInfo();
   //         LoadBBasicDocInfo();
        }
       public virtual void LoadBBasicDocInfo()
        {
            string cmd = " select DocNum, DocType, TableName, comments from ProcessDocs";
            _documentValues = Utilities.DataBaseUtility.GetList(cmd);
            for (int i = 1; i < _documentValues.Count; i++)
            {
                string[] fields = _documentValues[i].Split(',');
                comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + fields[2] + " , " + fields[3]);
            }
        }
        public void LoadBBasicDocInfo_SpecificType(string _tableName, string _type)
        {
            string cmd = String.Format(" select * from {0}  where DocType = {1}",_tableName,  _type) ;
            comboBox1.Items.Clear();
            _documentValues = Utilities.DataBaseUtility.GetList(cmd );
            for (int i = 1; i < _documentValues.Count; i++)
            {
                string[] fields = _documentValues[i].Split(',');
               if ( fields.Length == 11)
                   comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + _tableName + " , " + fields[10]);
               else   comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + _tableName + " , " + fields[2]);
            }
        }
        public   DisplaySelectedObject(IdentityObject _ident, string _tableName, string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_TableName.Text = _tableName;
            LoadSelectionInfo(_tableName, _docType,_docNum);
            string cmd = string.Format("select * from {0} where DocNum = {1} and DocType = {2}", _tableName,  _docType,  _docNum);
            button_LoadSelectionList_Click(this, null);
        }

        protected void LoadSelectionInfo()
        {
            LoadSelectionInfo("ProcessDocs", "*", "*");
        }
         protected void LoadSelectionInfo(string _tableName, string _docType, string _docNum)
         {try
            {
                textBox_DocNum.Text = _docNum;
                textBox_DocType.Text = _docType ;
                textBox_TableName.Text = _tableName;
                 button_ResetCommand_Click(this, null);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(" cant read 'GenDocs' table; " + ex1.Message);
            }
        }
     
        private void ResetBoxes()
        {
             textBox_IntAgent.Text = "";
            textBox_ExtAgent.Text = "";
            textBox_TextValue1.Text = "";
            textBox_TextValue2.Text = "";
            textBox_Status.Text = "";
            textBox_Comment.Text = "";
        
        }
        protected void button_LoadSelectionList_Click(object sender, EventArgs e)
        {
          //  LoadSelectionInfo(textBox_TableName.Text, textBox_DocType.Text, textBox_DocNum.Text);
            comboBox1.Items.Clear();
            _documentValues = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
            for (int i = 1; i < _documentValues.Count; i++)
            {
                string[] fields = _documentValues[i].Split(',');
                int indx = 10;
                if (fields.Length < 11) indx = 7;
                if (fields.Length < 8) indx = 2;
                comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + textBox_TableName.Text + " , " + fields[indx]);
            }
            
        }

        protected void button_Display_Click(object sender, EventArgs e)
        {
            List<string> _records = new List<string>();
            try
            {
              //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
              _records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading table : " + textBox_TableName.Text, ex.Message);
                return;
            }
                if (_records.Count < 2)
                {
                    MessageBox.Show("  error in reading table : " + textBox_TableName.Text);
                    return;
                } _records.RemoveAt(0);
                panel1.Visible = true;
                textBox_DataStrings.Text = _records[0];
                string[] _documentValues = _records[0].Split(',');
                 textBox_DocNum.Text = _documentValues[0].ToString();
                int docNumber = Int32.Parse(textBox_DocNum.Text);
                textBox_DocType.Text = _documentValues[1].ToString();
                int docType = Int32.Parse(textBox_DocType.Text);
                textBox_ExtAgent.Text = _documentValues[2].ToString();
                textBox_IntAgent.Text = _documentValues[3].ToString();
                textBox_Status.Text = _documentValues[4].ToString();
                textBox_ProcessID.Text = _documentValues[5].ToString();
                textBox_TextValue1.Text = _documentValues[6].ToString();
                textBox_TextValue2.Text = _documentValues[7].ToString();     //  StatusDate
                textBox_NumValue1.Text = _documentValues[8].ToString();     //  quotedAmount 
                textBox_NumValue2.Text = _documentValues[9].ToString();     //  actualAmount
                textBox_Comment.Text = _documentValues[10].ToString();
                string cmdStr2 = String.Format("select * from {0}_Details where docNum = {1} and doctype = {2}",
                                             textBox_TableName.Text.Trim(), docNumber, docType);
                _records = new List<string>();
                try
                {
                    //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                    //_records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
                    _records = Utilities.DataBaseUtility.GetList(cmdStr2);
                }
                catch (Exception )  {  }

                if (_records.Count < 2) return;
                for (int i = 1; i < _records.Count; i++)
                {
                    DocDetailItem _detail = new DocDetailItem(_records[i]);
                    textBox_DataStrings.Text += "\r\n" + _records[i];  // _detail.ToString();
                }
                DataTable _documentTable = Utilities.DataBaseUtility.GetTable(cmdStr2);
                dataGridView1.DataSource = _documentTable;
                dataGridView1.Visible = true;
                panel1.Visible = true;
        }

        protected void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = comboBox1.SelectedItem.ToString().Split(',');
            textBox_DocNum.Text = fields[0];
            textBox_DocType.Text = fields[1];
            textBox_TableName.Text = fields[2];
            panel1.Visible = false;
            DocumentID = Int32.Parse(textBox_DocNum.Text);
            DocumentType = Int32.Parse(textBox_DocType.Text);
            string cmdStr =  String.Format("select * from  {0} where docNum = {1} and doctype = {2}",
                                                textBox_TableName.Text, DocumentID,      DocumentType);
            textBox_Cmd.Text = cmdStr;
            ResetBoxes();
        }

        //private void  DisplayDocuments(int _docNumber)
        //{
        //    DataTable dtable = Utilities.DataBaseUtility.GetTable("select * from GenDocs where docNum = " + DocumentID);
        //    dataGridView1.DataSource = dtable;
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pStr2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string pStr4 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int pType = Int32.Parse(pStr2);
        }

        private void button_DisplayRawData_Click(object sender, EventArgs e)
        {
            textBox_DataStrings.Visible = true;

        }

        private void button_HideRawData_Click(object sender, EventArgs e)
        {
            textBox_DataStrings.Visible = false ;

        }

        //private void button_ChangeObject_Click_1(object sender, EventArgs e)
        //{
        //    Utilities.GenDoc newDoc = new Utilities.GenDoc();
        //    Utilities.Documents.ChangeDocument chDoc = new Utilities.Documents.ChangeDocument(base.ident); chDoc.Show();
        //}

        //private void button_ChangeDocument_Click(object sender, EventArgs e)
        //{
        //    Utilities.Documents.ChangeDocument chDoc = new Utilities.Documents.ChangeDocument(base.ident); chDoc.Show();
        //}

        protected void button_ResetCommand_Click(object sender, EventArgs e)
        {
            string _docType = textBox_DocType.Text.Trim();
            string _docNum = textBox_DocNum.Text.Trim();
            string part1 = " select * from  " + textBox_TableName.Text; ;
            string part2 = "";
            string part3 = "";

            if ((_docType != "*") && (_docType != " ") && (_docType != "") && (_docType != "0"))
                part2 = " where DocType = " + _docType;
            if ((_docNum != "*") && (_docNum != " ") && (_docNum != ""))
            {
                if (part2 == "")
                    part3 = " where DocNum = " + _docNum;
                else part3 = " and DocNum = " + _docNum;
            }
            string cmdStr = part1 + part2 + part3;
            textBox_Cmd.Text = cmdStr;
               
        }

        private void button_ChangeDoc_Click(object sender, EventArgs e)
        {
            ChangeDocument app = new ChangeDocument(base.ident, textBox_Cmd.Text, textBox_TableName.Text,textBox_DocNum.Text, textBox_DocType.Text ); app.Show();
        }

     

      
    }
}
