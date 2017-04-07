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
    public partial class ChangeDocument : HAWK_Template_2
    {
        GenDoc myDoc;
        protected DataTable _documentValues;
        List<String> _documentList;
     //   int _documentNum, _documentType;
        public ChangeDocument(IdentityObject _ident, string cmd, string tableName)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_Cmd.Text = cmd;
            textBox_TableName.Text = tableName;
            LoadBBasicDocInfo();
        }
        public ChangeDocument(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            LoadBBasicDocInfo();

        }
        public ChangeDocument()
        {
            InitializeComponent();
            //     LoadSelectionInfo();
            //     LoadBBasicDocInfo();
        }
        public void LoadBBasicDocInfo()
        {
            string cmd = String.Format(textBox_Cmd.Text);
            _documentList = Utilities.DataBaseUtility.GetList(cmd);
            for (int i = 1; i < _documentList.Count; i++)
            {
                string[] items = _documentList[i].Split(',');
                comboBox1.Items.Add(items[0] + " , " + items[1] + " , " + items[2]);
            }
        }
        public ChangeDocument(IdentityObject _ident, string _docType, string _docNum, string tablename)
        {
            InitializeComponent();
            base.ident = _ident;
            //   LoadSelectionInfo(_docType, _docNum, tablename );
            textBox_TableName.Text = tablename;
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_DataStrings.Visible = true;
            LoadBBasicDocInfo();
            button_GetDocument_Click(this, null);
        }
        public ChangeDocument(IdentityObject _ident, string _cmd, string tablename, string _docNum, string _docType)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_Cmd.Text = _cmd;
            textBox_TableName.Text = tablename;
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_DataStrings.Visible = true;
            //   LoadSelectionInfo(_docType, _docNum, tablename );
            LoadBBasicDocInfo();
            //  button_GetDocument_Click(this, null);
        }

        protected void LoadSelectionInfo()
        {
            LoadSelectionInfo("0", "0");
        }
        protected void LoadSelectionInfo(string _docType, string _docNum)
        {
            try
            {
                string part1 = " select DocNum, DocType, comments from   " + textBox_TableName.Text;
                string part2 = "";
                string part3 = "";

                if ((_docType != "*") && (_docType != "0")) part2 = " where DocType = " + _docType;
                if ((_docNum != "*"))
                {
                    part3 = " and DocNum = " + _docNum;
                }
                string cmdStr = part1 + part2 + part3;
                textBox_Cmd.Text = cmdStr;
                _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                for (int i = 1; i < _documentValues.Rows.Count; i++)
                {
                    comboBox1.Items.Add(_documentValues.Rows[i][0].ToString() + " , " + _documentValues.Rows[i][1].ToString()
                                     + " , " + _documentValues.Rows[i][2].ToString());
                }
                textBox_DocNum.Text = _docNum;
                textBox_DocType.Text = _docType;
                button_GetDocument_Click(this, null);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(" cant read file :  " + textBox_TableName.Text + "   " + ex1.Message);
            }
        }

        private void ResetBoxes()
        {
            // textBox_DocNumber.Text = "";
            // textBox_DocType.Text = "";
            textBox_IntAgent.Text = "";
            textBox_ExtAgent.Text = "";
            textBox_TextValue1.Text = "";
            textBox_TextValue2.Text = "";
            textBox_Status.Text = "";
            textBox_Comment.Text = "";

        }
        protected virtual void button_GetDocument_Click(object sender, EventArgs e)
        {
            button_GetDocument(textBox_Cmd.Text);
        }
        protected virtual void GetDocument(IdentityObject _ident, string tablename, string _docType, string _docNum)
        {
            string cmd = string.Format(" select * from {0} where DocType = {1} and DocNum = {2} ", tablename, _docType, _docNum);
            textBox_TableName.Text = tablename;
            textBox_DocType.Text = _docType;
            textBox_DocNum.Text = _docNum;
            button_GetDocument(cmd);
        }
        protected virtual void button_GetDocument(string cmdStr)
        {
            try
            {
                //_documentNum = Int32.Parse(textBox_DocNum.Text);
                //_documentType = Int32.Parse(textBox_DocType.Text);
                panel1.Visible = true;

                //    List<string> myData = Utilities.DataBaseUtility.GetDocumentData(textBox_TableName.Text, _documentType, _documentNum);
                List<string> myData = Utilities.DataBaseUtility.GetDocumentData(cmdStr);// textBox_Cmd.Text);
                if (myData.Count < 2)
                {
                    MessageBox.Show("can't find document for : " + cmdStr);
                }
                myData.RemoveAt(0);
                myDoc = new GenDoc(myData);
                //  string cmdStr = "select * from GenDocs " +
                //           String.Format("where docNum = {0} and docType = {1}", _documentID, _documentType);
                textBox_DataStrings.Text = myData[0];

                //List<string> _records = Utilities.DataBaseUtility.GetList(cmdStr);
                listBox_DataStrings.Items.Clear();
                listBox_DataStrings.Items.Add(myData[0]);
                string[] fields = myData[0].Split(',');
                textBox_ProcessID.Text = fields[0].ToString();
                int docNumber = Int32.Parse(textBox_ProcessID.Text);
                textBox_DocType.Text = fields[1].ToString();
                textBox_ExtAgent.Text = fields[2].ToString();
                textBox_IntAgent.Text = fields[3].ToString();
                textBox_Status.Text = fields[4].ToString();
                //   textBox_TableName.Text = 
                textBox_ProcessID.Text = fields[5].ToString();
                textBox_TextValue1.Text = fields[6].ToString();
                textBox_TextValue2.Text = fields[7].ToString();     //  StatusDate
                textBox_QuotedAmount.Text = fields[8].ToString();     //  quotedAmount 
                textBox_ActualAmount.Text = fields[9].ToString();     //  actualAmount
                textBox_Comment.Text = fields[10].ToString();
                string cmdStr2 = String.Format("select * from {0}_Details where docNum = {1} and doctype = {2}",
                           textBox_TableName.Text.Trim(), textBox_DocNum.Text, textBox_DocType.Text);
                _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr2);
                dataGridView1.DataSource = _documentValues;
                myData = Utilities.DataBaseUtility.GetList(cmdStr2);
                if (myData.Count < 3) return;
                for (int i = 1; i < myData.Count; i++)
                {
                    textBox_DataStrings.Text += "\r\n" + myData[i];
                    listBox_DataStrings.Items.Add(myData[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading GenDocs " + ex.Message);
            }
        }

        protected virtual void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = comboBox1.SelectedItem.ToString().Split(',');
            textBox_DocNum.Text = fields[0];
            textBox_DocType.Text = fields[1];
            panel1.Visible = false;
            //  ResetBoxes();

            string cmdStr = String.Format("select * from {0} where docNum = {1} and DocType = {2}",
                                 textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);
            textBox_Cmd.Text = cmdStr;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pStr2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string pStr4 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int pType = Int32.Parse(pStr2);
        }

        private void button_DisplayRawData_Click(object sender, EventArgs e)
        {
            listBox_DataStrings.Visible = true;

        }

        private void button_HideRawData_Click(object sender, EventArgs e)
        {
            listBox_DataStrings.Visible = false;

        }

        protected virtual void button_Save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure that you want to save ?", "Verify Operation",
                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                MessageBox.Show(" Operation Cancelled by user ");
                return;
            }
            //   (response == "yes") 
            string _tableName = textBox_TableName.Text;
            List<string> myData = new List<string>();
            for (int i = 0; i < listBox_DataStrings.Items.Count; i++)
                myData.Add(listBox_DataStrings.Items[i].ToString());
            int myDataCount = myData.Count;
            myDoc = new GenDoc(myData);
            int retcode = myDoc.SaveDocument(base.ident, _tableName, textBox_DocNum.Text, textBox_DocType.Text, myData);
            // string retMessage = myDoc.SaveDocument(base.ident, textBox_TableName.Text, textBox_DocumentID.Text, textBox_DocType.Text, myData);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure that you want to delete ?");
            if (dr == DialogResult.No)
            {
                MessageBox.Show(" Operation Cancelled by user ");
                return;
            }
            //  if (response == "yes")
            Utilities.DataBaseUtility.DeleteDocument(base.ident, textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);

        }

        //private void button_AddDetailItem_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("are you sure that you want to delete ?");
        //    //  if (response == "yes")
        //    //   Utilities.DataBaseUtility.DeleteDocument(textBox_DocumentID.Text, textBox_DocType);

        //}

        protected override void button_ChangeObject_Click(object sender, EventArgs e)
        {
            Utilities.Documents.ChangeDocument app = new ChangeDocument(base.ident); app.Show();
        }

        protected virtual void button_ValidateData_Click(object sender, EventArgs e)
        {
            List<string> datastrings = new List<string>();
            listBox_DataStrings.Items.Clear();
            StringBuilder dataString1 = new StringBuilder();
            dataString1.Append(textBox_DocNum.Text + " ,");
            dataString1.Append(textBox_DocType.Text + " ,");
            dataString1.Append(textBox_ExtAgent.Text + " ,");
            dataString1.Append(textBox_IntAgent.Text + " ,");
            dataString1.Append(textBox_Status.Text + " ,");
            dataString1.Append(textBox_ProcessID.Text + " ,");
            dataString1.Append("'" + textBox_TextValue1.Text + "' ,");
            dataString1.Append("'" + textBox_TextValue2.Text + "' ,");
            dataString1.Append(textBox_QuotedAmount.Text + " ,");
            dataString1.Append(textBox_ActualAmount.Text + " ,");
            dataString1.Append("'" + textBox_Comment.Text + "'");
            listBox_DataStrings.Items.Add(dataString1.ToString());
            datastrings.Add(dataString1.ToString());
            int lastrow = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < lastrow; i++)
            {
                StringBuilder dataString2 = new StringBuilder();
                dataString2.Append(dataGridView1.Rows[i].Cells[0].Value.ToString());
                for (int j = 1; j < 7; j++)
                    dataString2.Append(" ," + (dataGridView1.Rows[i].Cells[j]).Value.ToString());
                dataString2.Append(" ,'" + (dataGridView1.Rows[i].Cells[7]).Value.ToString() + "'");
                listBox_DataStrings.Items.Add(dataString2.ToString());
                datastrings.Add(dataString1.ToString());

            }
            GenDoc testObject = new GenDoc(datastrings);
            int returnValue = 0;  // testObject.CheckValues(datastrings);
            string[] fieldNames = {"DocNumber","DocType","ExternalRef","InternalRef","Status","DocRef",
                                   "TextValue1","TextValue2","NumValue1","NumValue2","Comment"};
            if (returnValue > 0)
            {
                int indx = returnValue;
                string[] fields = datastrings[0].Split(',');
                string errorMessage = string.Format(" Error in {0}. \r\n \r\n Error in field {1}. \r\n Value {2} is not valid", textBox_TableName.Text, fieldNames[indx], fields[indx]);
                MessageBox.Show(errorMessage);
            }
        }

        protected virtual void button_ResetCommand_Click(object sender, EventArgs e)
        {
            string _docType = textBox_DocType.Text;
            string _docNum = textBox_DocNum.Text;
            string part1 = " select * from  " + textBox_TableName.Text; ;
            string part2 = "";
            string part3 = "";

            if ((_docType != "*") && (_docType != " ") && (_docType != ""))
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

        private void button_LoadOptions_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            _documentList = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
            for (int i = 1; i < _documentList.Count; i++)
            {
                string[] fields = _documentList[i].Split(',');
                comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + textBox_TableName.Text + " , " + fields[10]);
            }
        }

    }
}
