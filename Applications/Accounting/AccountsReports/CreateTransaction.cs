using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsReports
{

    
    public partial class CreateTransaction : Utilities.Documents.ChangeDocument
    {

        DataTable dtable;
        string lastrowStr;
        string newrowStr;
        public CreateTransaction()
        {
            InitializeComponent();
        }

        public CreateTransaction(IdentityObject _ident, string tableName, string docNumStr, string docTypeStr)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_TableName.Text = tableName;
            textBox_DocNum.Text = docNumStr;
            textBox_DocType.Text = docTypeStr;
            button_ResetCommand_Click(this, null);
            button_GetDocument_Click(this, null);
            string cmdStr = string.Format("select * from  {0}_Details where docNum = {1}  and doctype = {2}",
                                               textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);
            dtable = Utilities.DataBaseUtility.GetTable(cmdStr);
            button_Transaction_Click(this, null);
            
        }

        public CreateTransaction(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            //   LoadBBasicDocInfo();

        }

        public void Convert_to_Transaction()
        {
        }

        private void button_Transaction_Click(object sender, EventArgs e)
        {
            textBox_TableName.Text = "Transactions";
            textBox_IntAgent.Text = ident.UserID.ToString();
            textBox_TextValue1.Text = DateTime.Now.ToShortDateString();
            newrowStr = "";
            switch (textBox_DocType.Text.Trim())
            {

                case "13":

                    textBox_DocType.Text = "513";
                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        dtable.Rows[i][0] = textBox_DocNum.Text;
                        dtable.Rows[i][1] = textBox_DocType.Text;
                        dtable.Rows[i][3] = "130";
                        dtable.Rows[i][4] = "1";
                        string mat_Str = Utilities.DataBaseUtility.GetCommonObject("Materials", dtable.Rows[i][2].ToString());
                        Utilities.Product thisProduct = new Utilities.Product(mat_Str);
                        string detailStr = "Inventory - " + thisProduct.Description;
                        if (detailStr.Length > 33) detailStr = detailStr.Substring(0, 33);
                        dtable.Rows[i][7] = detailStr;
                        //  cells 2,5,6 & 7  should be OOK
                    }
                    lastrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, '{7}{8}'", textBox_DocNum.Text, textBox_DocType.Text,
                                          textBox_ExtAgent.Text, "211", "-1", "1", textBox_ActualAmount.Text,
                                                        " Acc Payable - vendor ", textBox_ExtAgent.Text);
                    string[] lastRow = new string[] { textBox_DocNum.Text, textBox_DocType.Text,
                                          textBox_ExtAgent.Text, "211", "-1", "1", textBox_ActualAmount.Text,
                                                        " Acc Payable - vendor "};
                    dtable.Rows.Add(lastRow);
                    dataGridView1.DataSource = dtable;
                    ValidateData();
                    //listBox_DataStrings.Items.Add(lastrowStr);  //.ToString());
                    //datastrings.Add(dataString1.ToString());
                    //textBox_DataStrings.Text += "\r\n" + lastrowStr;
                    break;

                case "14":
                    //    case "514":
                    textBox_DocType.Text = "514";
                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        dtable.Rows[i][0] = textBox_DocNum.Text;
                        dtable.Rows[i][1] = textBox_DocType.Text;
                        dtable.Rows[i][3] = "130";
                        dtable.Rows[i][4] = "-1";
                        string mat_Str = Utilities.DataBaseUtility.GetCommonObject("Materials", dtable.Rows[i][2].ToString());
                        Utilities.Product thisProduct = new Utilities.Product(mat_Str);
                        string detailStr = "Inventory - " + thisProduct.Description;
                        if (detailStr.Length > 33) detailStr = detailStr.Substring(0, 33);
                        dtable.Rows[i][7] = detailStr;
                        //  cells 2,5,6 & 7  should be OOK
                    }
                    dataGridView1.DataSource = dtable;

                    lastrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6},'{7}{8}'", textBox_DocNum.Text, textBox_DocType.Text,
                                          textBox_ExtAgent.Text, "120", "1", "1", textBox_ActualAmount.Text,
                                                        " Cost of Goods Sold to  ", textBox_ExtAgent.Text);
                    lastRow = new string[] { textBox_DocNum.Text, textBox_DocType.Text,
                                          textBox_ExtAgent.Text, "120", "1", "1", textBox_ActualAmount.Text,
                                                        " Cost of Goods Sold "};
                    dtable.Rows.Add(lastRow);
                    dataGridView1.DataSource = dtable;
                    ValidateData();
                    // listBox_DataStrings.Items.Add(lastrowStr);  //.ToString());
                    // datastrings.Add(dataString1.ToString());
                    // textBox_DataStrings.Text += "\r\n" + lastrowStr;
                    break;

                case "21":
                case "521":
                    textBox_DocType.Text = "521";
                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        dtable.Rows[i][0] = textBox_DocNum.Text;
                        dtable.Rows[i][1] = textBox_DocType.Text;
                        dtable.Rows[i][3] = "510";
                        dtable.Rows[i][4] = "-1";
                        string mat_Str = Utilities.DataBaseUtility.GetCommonObject("Materials", dtable.Rows[i][2].ToString());
                        Utilities.Product thisProduct = new Utilities.Product(mat_Str);
                        dtable.Rows[i][7] = "Sales - " + thisProduct.Description;
                        //  cells 2,5,6 & 7  should be OOK
                    }
                    dataGridView1.DataSource = dtable;

                    lastrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6},'{7}{8}'", textBox_DocNum.Text, textBox_DocType.Text,
                                          textBox_ExtAgent.Text, "120", "1", "1", textBox_ActualAmount.Text,
                                                        " Acct. Receivable - Cust ", textBox_ExtAgent.Text);
                    ValidateData();
                    break;
                case "46":
                case "513":
                    textBox_DocType.Text = "546";
                    textBox_Comment.Text = "Pay invoice received from vendor " + textBox_ExtAgent.Text;

                    newrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6},'{7}{8}'", textBox_DocNum.Text, textBox_DocType.Text,
                                         textBox_ExtAgent.Text, "211", "1", "1", textBox_ActualAmount.Text,
                                                       " Acct. Payable - ", textBox_ExtAgent.Text);
                    string[] newRow = new string[] { textBox_DocNum.Text, textBox_DocType.Text,
                                          textBox_ExtAgent.Text, "211", "1", "1", textBox_ActualAmount.Text,
                                                        " Acc Payable - vendor " + textBox_ExtAgent.Text};
                    lastrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6},'{7}'", textBox_DocNum.Text, textBox_DocType.Text,
                                                          "0", "100", "-1", "1", textBox_ActualAmount.Text, "Cash");
                    string[] lastRowdata = new string[] { textBox_DocNum.Text, textBox_DocType.Text,
                                                            "0", "100", "-1", "1", textBox_ActualAmount.Text, "Cash"};

                    dtable.Rows.Clear();
                    dtable.Rows.Add(newRow);
                    dtable.Rows.Add(lastRowdata);
                    dataGridView1.DataSource = dtable;
                    ValidateData();

                    break;
                case "48":
                    String cmdStr = String.Format(" select * from ProcessDocs_Details where docType = 21 and docnum = {0}", textBox_DocNum.Text);
                    DataTable dtable_48 = Utilities.DataBaseUtility.GetTable(cmdStr);
                    textBox_DocType.Text = "548";
                    textBox_Comment.Text = " invoice for Customer " + textBox_ExtAgent.Text;
                    for (int i = 0; i < dtable_48.Rows.Count; i++)
                    {
                        dtable_48.Rows[i][0] = textBox_DocNum.Text;
                        dtable_48.Rows[i][1] = textBox_DocType.Text;
                        dtable_48.Rows[i][3] = "510";
                        dtable_48.Rows[i][4] = "-1";
                        string mat_Str = Utilities.DataBaseUtility.GetCommonObject("Materials", dtable.Rows[i][2].ToString());
                        Utilities.Product thisProduct = new Utilities.Product(mat_Str);
                        dtable_48.Rows[i][6] = thisProduct.ListPrice.ToString();
                        dtable_48.Rows[i][7] = "Sales - " + thisProduct.Description;
                        //  cells 2,5,6 & 7  should be OOK
                    }
                    dataGridView1.DataSource = dtable_48;

                    double expAmount = Double.Parse(textBox_ExpectedAmount.Text);
                    double actualAmount = Double.Parse(textBox_ActualAmount.Text);
                    double diff = expAmount - actualAmount;
                    if (diff > 0.01)
                    {
                        newrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6},'{7}'", textBox_DocNum.Text, textBox_DocType.Text,
                                textBox_ExtAgent.Text, "515", "1", "1", diff.ToString(), " Sales Discount");

                        string[] newRow_48 = new string[] { textBox_DocNum.Text, textBox_DocType.Text,
                                textBox_ExtAgent.Text, "515", "1", "1", diff.ToString()," Sales Discount"};
                        dtable_48.Rows.Add(newRow_48);
                    }

                    lastrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6},'{7}'", textBox_DocNum.Text, textBox_DocType.Text,
                                     textBox_ExtAgent.Text, "120", "1", "1", textBox_ActualAmount.Text,
                                                   " Acct. Receivable - Cust ", textBox_ExtAgent.Text);

                    string[] lastRowdata_48 = new string[] { textBox_DocNum.Text, textBox_DocType.Text,
                                           textBox_ExtAgent.Text, "120", "1", "1", textBox_ActualAmount.Text,
                                            " Acct. Receivable - Cust " + textBox_ExtAgent.Text};

                    dtable_48.Rows.Add(lastRowdata_48);
                    dataGridView1.DataSource = dtable_48;
                    ValidateData();
                    break;

                case "49":
                case "549":
                    textBox_DocType.Text = "549";

                    newrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6},'{7}'", textBox_DocNum.Text, textBox_DocType.Text,
                                          "100", "100", "1", "1", textBox_ActualAmount.Text, "Cash");

                    string[] newRow_49 = new string[] { textBox_DocNum.Text, textBox_DocType.Text,
                                          textBox_ExtAgent.Text, "120", "-1", "1", textBox_ActualAmount.Text,
                                                        " Acc Rec - Cust " + textBox_ExtAgent.Text};
                    lastrowStr = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6},'{7}{8}'", textBox_DocNum.Text, textBox_DocType.Text,
                                         textBox_ExtAgent.Text, "210", "-1", "1", textBox_ActualAmount.Text,
                                                       " Acct. Receivable - Cust ", textBox_ExtAgent.Text);
                    string[] lastRowdata_49 = new string[] { textBox_DocNum.Text, textBox_DocType.Text,
                                                            "0", "100", "1", "1", textBox_ActualAmount.Text, "Cash"};

                    dtable.Rows.Clear();
                    dtable.Rows.Add(newRow_49);
                    dtable.Rows.Add(lastRowdata_49);
                    dataGridView1.DataSource = dtable;
                    ValidateData();
                    break;

            }
        }

        public void ValidateData()
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
            dataString1.Append(textBox_ExpectedAmount.Text + " ,");
            dataString1.Append(textBox_ActualAmount.Text + " ,");
            dataString1.Append("'" + textBox_Comment.Text + "'");
            listBox_DataStrings.Items.Add(dataString1.ToString());
            textBox_DataStrings.Text = dataString1.ToString();
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
                datastrings.Add(dataString2.ToString());

            }
            //GenDoc testObject = new GenDoc(datastrings);
            //int returnValue = 0;  // testObject.CheckValues(datastrings);
            //string[] fieldNames = {"DocNumber","DocType","ExternalRef","InternalRef","Status","DocRef",
            //                       "TextValue1","TextValue2","NumValue1","NumValue2","Comment"};
            //if (returnValue > 0)
            //{
            //    int indx = returnValue;
            //    string[] fields = datastrings[0].Split(',');
            //    string errorMessage = string.Format(" Error in {0}. \r\n \r\n Error in field {1}. \r\n Value {2} is not valid", textBox_TableName.Text, fieldNames[indx], fields[indx]);
            //    MessageBox.Show(errorMessage);
            //}
            //if (newrowStr.Length > 2)
            //{
            //    listBox_DataStrings.Items.Add(newrowStr);
            //    textBox_DataStrings.Text += "\r\n" + newrowStr;
            //}
            //listBox_DataStrings.Items.Add(lastrowStr);  //.ToString());
            //int listCount = listBox_DataStrings.Items.Count;
            //datastrings.Add(lastrowStr);
            //textBox_DataStrings.Text += "\r\n" + lastrowStr;
        }

        private void button_Save_Click_1(object sender, EventArgs e)
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
            GenDoc myDoc = new GenDoc(myData);
            int retcode = myDoc.SaveDocument(base.ident, _tableName, textBox_DocNum.Text, textBox_DocType.Text, myData);
            // string retMessage = myDoc.SaveDocument(base.ident, textBox_TableName.Text, textBox_DocumentID.Text, textBox_DocType.Text, myData);
        }

        private void button_ValidateData_Click_1(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cmdStr = string.Format("select DocNum, DocType, Description from  Transactions");
            DataTable dt = new DataTable();
            dt = Utilities.DataBaseUtility.GetTable(cmdStr);
            List<string> st = Utilities.DataBaseUtility.GetList(cmdStr);

            string s = Utilities.DataBaseUtility.Execute(cmdStr, ident);
            Utilities.DataBaseUtility ud = new Utilities.DataBaseUtility();
            
            foreach(string s1 in st)
            {
                string[] items = s1.Split(',');
                comboBox1.Items.Add(items[0] + " , " + items[1] + " , " + items[2]);
                //comboBox1.Items.Add(s1);
            }

        }

      
    }
}
