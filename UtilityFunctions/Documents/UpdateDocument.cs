using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Documents
{
    public partial class UpdateDocument :  HAWK_Template_3
    {
        string cmdStr;  // = comboBox_TableName.SelectedItem.ToString();
        string[] fields;  // = CmdStr.Split(' ');
        int cmdIndx;
        List<string> datalist;  // = Utilities.DataBaseUtility.GetList(newCmdStr);
        DataTable dtable;       // = Utilities.DataBaseUtility.GetTable(newCmdStr);
                      
        public UpdateDocument()
        {
            InitializeComponent();
            textBox_Command.Text   = "Select * from Acc_Payable_Update";
            textBox_CommandIndx.Text  = "1";
            textBox_TableName.Text = "Acc_Payable_Update";
        }
        public UpdateDocument(IdentityObject _ident, string _tableName, string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            textBox_DataStrings.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text  = _docType ;
            textBox_TableName.Text = _tableName ;
            textBox_Command.Text = "select * from " + _tableName ;
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
                dataGridView2.Visible = true;
              
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
            textBox_Command.Text = cmdStr;

        }

        protected void button_DisplayDoc_Click(object sender, EventArgs e)
        {
            //try
            //{
                //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                List<string> _records = Utilities.DataBaseUtility.GetList(textBox_Command.Text);
                if (_records.Count < 2)
                {
                    MessageBox.Show(" didn't find records for " + textBox_Command.Text);
                    return;
                }
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

        private void comboBox_TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmdStr = comboBox_TableName.SelectedItem.ToString();
            //fields = cmdStr.Split(' ');
            //cmdIndx  = Int32.Parse( fields[0]);
            //textBox_CommandIndx.Text = fields[0];
            //textBox_TableName.Text = fields[1];
            //int charIndex = cmdStr.IndexOf(";");
            //textBox_CMD.Text = cmdStr.Substring(charIndex + 1);
            //button_ResetCommand_Click(this, null);
            LoadUpdateCommands();
        }
        protected virtual void LoadUpdateCommands()
        {   //   Download a table of queries
            //   DataTable queryTable = new DataTable();
            List<string> queryList = Utilities.DataBaseUtility.GetList("select * from Acc_Payable_Update");
            int numReturned = queryList.Count - 1;
            comboBox3.Items.Clear();
          //  comboBox3.Items.Add("  Acc_Payable_Update");
            for (int i = 1; i < numReturned; i++)
            {
               string[] fields = queryList[i].Split(',');
                comboBox3.Items.Add(fields[1]);

            }
        }
        private void button_Display_Click(object sender, EventArgs e)
        {
            List<string> _records = Utilities.DataBaseUtility.GetList(textBox_Command.Text);
            if (_records.Count < 2)
            {
                MessageBox.Show(" didn't find records for " + textBox_Command.Text);
                return;
            }
           // LoadDetailRecords(textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);
               DataTable dtable1 = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
               dataGridView1.DataSource = dtable1;
        }

        private void button_Execute_Click(object sender, EventArgs e)
        {
            string cmdStr = Compress(textBox_Command.Text);
             fields = cmdStr.Split(' ');
            string cmdObject = fields[0].Trim();
            switch (cmdObject)
            {
                case "select":
                case "Select":
                    {
                        int fromIndx = cmdStr.IndexOf("from");
                        string newCmdStr = "select * from " + cmdStr.Substring(fromIndx + 4);
                        datalist = Utilities.DataBaseUtility.GetList(newCmdStr);
                        dtable = Utilities.DataBaseUtility.GetTable(newCmdStr);
                        textBox_Response.Text = (datalist.Count - 1).ToString() + "  records were read";
                        switch (fields[1].Trim())
                        {
                                case "data1":
                                case "DataGrid1":
                                {
                                  //  datalist = Utilities.DataBaseUtility.GetList(textBox_Command.Text);
                                  //  dtable = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
                                    dataGridView_1.DataSource = dtable;
                                    break;
                                }
                                case "data2":
                                case "DataGrid2":
                                {
                                    dataGridView_2.DataSource = dtable;
                                    break;
                                }
                                case "data3":
                                case "DataGrid3":
                                {
                                   dataGridView_3.DataSource = dtable;
                                    break;
                                }
                        }
                        break;
                    }     //  end of case "select"

                case "display":
                case "Display":
                {
                    switch (fields[3].Trim())
                    {
                        case "data1":
                        case "DataGrid1":
                        {
                            //    datalist = Utilities.DataBaseUtility.GetList(textBox_Command.Text);
                            //    dtable = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
                                dataGridView_1.DataSource = dtable;
                                break;
                        }
                        case "data2":
                        case "DataGrid2":
                        {
                                dataGridView_2.DataSource = dtable;
                                break;
                        }
                        case "data3":
                        case "dataGrid3":
                        {
                            dataGridView_3.DataSource = dtable;
                            break;
                        }
                        case "data0":
                        case "dataGrid0":
                        {
                            dataGridView_0.DataSource = dtable;
                            break;
                        }
                    }
                    break;
                }
            }
        }

        //protected virtual string Compress(string targetStr)
        //{    // (1) Download a table of queries
            //  string cleanString = targetStr.Substring(2).Trim();
            //  char[] array_C = new char[] (cleanString);
            //  while (cleanString.IndexOf("  ") > -1)
            //    cleanString.Replace("  ", "^");
            //
            //   for (int i = 2; i < targetStr.Length; i++)
            //            {
            //                string lastChar = targetStr[i];
            //
            //                int indx = targetStr.Trim().IndexOf(" ", 2);
            //                StringBuilder builder = new StringBuilder();
            //                builder.Append(targetStr.Substring(2, indx).Trim());
            //                int startindx = indx + 1;
            //                indx = targetStr.Trim().IndexOf(" ", startindx);
            //                builder.Append(" " + targetStr.Substring(startindx, indx).Trim());
            //            }
            //
            //     return cleanString.Trim();
            // }
        protected virtual string Compress(string targetStr)
        {
            //   removes adjacent blanks from a string and returns a “clean” string

            string cleanString = string.Join(" ", targetStr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            return cleanString.Trim();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Command.Text = comboBox3.SelectedItem.ToString();
        }

        private void button_Next_Cmd_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex < comboBox3.Items.Count - 1)    comboBox3.SelectedIndex++;
        }        
   }
    
}
