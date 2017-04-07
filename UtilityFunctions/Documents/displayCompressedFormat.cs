using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Documents
{
    public partial class DisplayCompressedFormat : DisplaySelectedObject
    {
        public DisplayCompressedFormat()
        {
            InitializeComponent();
        }
        public DisplayCompressedFormat(IdentityObject _ident, string _tableName, string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            textBox_DataStrings.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text  = _docType ;
            textBox_TableName.Text = _tableName ;
            textBox_Cmd.Text = "select * from " + _tableName ;
           // LoadBBasicDocInfo();
            button_ResetCommand_Click(this, null);
        
        }
           protected /*override*/  void LoadBBasicDocInfo()
           {
               string cmd = " select * from  " + textBox_TableName.Text;
              List<string>   _documentValues = Utilities.DataBaseUtility.GetList(cmd);
               for (int i = 1; i < _documentValues.Count; i++)
               {
                   string[] fields = _documentValues[i].Split(',');
                   comboBox1.Items.Add(fields[0] + " , " + fields[10] );
               }
           }
        protected void LoadDetailRecords(string tablename, string docNumber, string docType)
        {
            string cmdStr2 = String.Format("select * from {0}_Details where docNum = {1} and doctype = {2}",
                                             textBox_TableName.Text.Trim(), docNumber, docType);
            //try
            //{
                List<string> _records = Utilities.DataBaseUtility.GetList(cmdStr2 );
                for (int i = 1; i < _records.Count; i++)
                    textBox_DataStrings.Text += "\r\n" + _records[i];
                if (_records.Count < 2)
                {
                    dataGridView2.Visible = false;
                    return;
                }
                dataGridView2.Visible = true;
                DataTable dTable = Utilities.DataBaseUtility.GetTable(cmdStr2);
                dataGridView2.Rows.Clear();                                 //DataSource = _documentTable;
              //  dataGridView2.Rows.Add();
              //  int current = dataGridView2.Rows.Count;
                int last = dTable.Rows.Count;
                double valueSum = 0;
                for (int i = 0; i < last; i++)
                {
                    dataGridView2.Rows.Add();
                    if (dTable.Rows[i].ItemArray.Length > 7)
                        dataGridView2.Rows[i ].Cells[0].Value = dTable.Rows[i][7];
                    double quant = Double.Parse((dTable.Rows[i][5]).ToString());
                    dataGridView2.Rows[i ].Cells[1].Value = String.Format("{0,12:F2}", quant);
                    double rate = Double.Parse((dTable.Rows[i][6]).ToString());
                    dataGridView2.Rows[i ].Cells[2].Value = String.Format("{0,12:F2}", rate);
                    dataGridView2.Rows[i ].Cells[3].Value = String.Format("{0,14:F2}", quant * rate);
                    valueSum += quant * rate;
                }
                dataGridView2.Rows.Add("", "", "", "===========");
                dataGridView2.Rows.Add("", "", "", String.Format("{0,14:C}", valueSum));
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
            //    panel1.Visible = true;
              
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("  error in reading Gross pay record " + ex.Message);
            //}
        }
        protected /*override*/ void button_ResetCommand_Click(object sender, EventArgs e)
        {
            string _docType = textBox_DocType.Text.Trim();
            string _docNum = textBox_DocNum.Text.Trim();
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

        protected void button_DisplayDoc_Click(object sender, EventArgs e)
        {
            //try
            //{
                //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                List<string> _records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
                if (_records.Count < 2)
                {
                    MessageBox.Show(" didn't find records for " + textBox_Cmd.Text);
                    return;
                }
                    textBox_DataStrings.Text = _records[1];
                string[] _documentValues = _records[1].Split(',');
                dataGridView1.Visible = false;  // DataSource = _documentValues;
                textBox_DocNum.Text = _documentValues[0].ToString();
                int docNumber = Int32.Parse(textBox_DocNum.Text);
                textBox_DocType.Text = _documentValues[1].ToString();
                int docType = Int32.Parse(textBox_DocType.Text);
                textBox_ExtAgent.Text = _documentValues[2].ToString();
                textBox_IntAgent.Text = _documentValues[3].ToString();
                textBox_Status.Text = _documentValues[4].ToString();
                // string tablename = "GenDocs";
                textBox_ProcessID.Text = _documentValues[5].ToString();
                textBox_TextValue1.Text = _documentValues[6].ToString();
                textBox_TextValue2.Text = _documentValues[7].ToString();     //  StatusDate
                textBox_NumValue1.Text = _documentValues[8].ToString();     //  quotedAmount 
                textBox_NumValue2.Text = _documentValues[9].ToString();     //  actualAmount
                textBox_Comment.Text = _documentValues[10].ToString();
                textBox_Description.Text = _documentValues[10].ToString();
                panel1.Visible = true;
                LoadDetailRecords(textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("  error in reading GenDocs " + ex.Message);
            //}    

        }

        private void button_RawData_Click(object sender, EventArgs e)
        {
            textBox_DataStrings.Visible = !textBox_DataStrings.Visible;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = textBox_DocNum.Text;
            string docTypeStr = textBox_DocType.Text;
            string index1 = e.RowIndex.ToString();
            string newtableName = textBox_TableName.Text + "_Details";
         //   DisplayDetailObject dispObj = new DisplayDetailObject(base.ident, newtableName, docTypeStr, docNumStr, index1); dispObj.Show();
   
        }

           
   }
    
}
