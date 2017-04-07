using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsReports
{
    public partial class DisplayTransaction : HAWK_Template_3
    {
        List<String> _transactionNames;
        List<string> _transactionValues;
        List<string> _transactionDetailValues;
        DataTable _actionValues;
        string displayCmdStr;
        string[] dataStrings;
        string[] dataValues;
        static int count = 0;
        public DisplayTransaction()
        {
            InitializeComponent();
        }

        public DisplayTransaction(IdentityObject _ident)
        {
            InitializeComponent();
            IdentityObject ident = _ident;
            LoadTransactions();
        }

        public DisplayTransaction(IdentityObject _ident, string indx)
        {
            InitializeComponent();
            IdentityObject ident = _ident;
            LoadTransactions(indx);
            //textBox_ID.Text = indx;
            button_RetrieveData_Click(this, null);
            button_Display_Click(this, null);
        }
        public DisplayTransaction(IdentityObject _ident, string dataStrings, int num)
        {
            InitializeComponent();
            IdentityObject ident = _ident;
            LoadTransactions();
            textBox_Display.Text = dataStrings;
            textBox_Display.Visible = true;
            // DisplayListDetails();

        }

        private void LoadTransactions()
        {
            comboBox_SelectedTrans.Items.Clear();
            _transactionNames = Utilities.DataBaseUtility.GetList(" select * from Transactions order by docnum");
            //      dataGridView1.DataSource = _actionValues;
            for (int i = 1; i < _transactionNames.Count; i++)
            {
                string[] items = _transactionNames[i].Split(',');
                comboBox_SelectedTrans.Items.Add(items[0].Trim() + " ,  " + items[1].Trim() + " ,  " + items[10]);

            }
            comboBox_SelectedTrans.SelectedIndex = 0;
        }

        private void LoadTransactions(string _target)
        {
            comboBox_SelectedTrans.Items.Clear();
            int indx = 0;
            _transactionNames = Utilities.DataBaseUtility.GetList(" select * from transactions");
            int _count = _transactionNames.Count;
            if (_count > 2)
            {
                MessageBox.Show(" more than 2 transaction records");
            }
            //      dataGridView1.DataSource = _actionValues;
            for (int i = 1; i < _transactionNames.Count; i++)
            {
                string[] items = _transactionNames[i].Split(',');
                comboBox_SelectedTrans.Items.Add(items[0].Trim() + " ,  " + items[1]);
                if (items[0].Trim() == _target.Trim()) indx = i;
            }
            //_transactionNames = Utilities.DataBaseUtility.GetList(" select * from processDocs where doctype = 41 and sequence = 0");
            ////      dataGridView1.DataSource = _actionValues;
            //for (int i = 1; i < _transactionNames.Count; i++)
            //{
            //    string[] items = _transactionNames[i].Split(',');
            //    comboBox_SelectedTrans.Items.Add(items[0].Trim() + " :   " + items[1]);
            //    if (items[0].Trim() == _target.Trim()) indx = i;
            //}
            comboBox_SelectedTrans.SelectedIndex = indx - 1;
        }

        //private void ResetBoxes()
        //{
        //    textBox_ActionType.Text = "";
        //    //   textBox_Index1.Text = "";
        //    textBox_DocNum.Text = "";
        //    textBox_TrDate.Text = "";
        //    textBox_Status.Text = "";
        //    //    txtZIP.Text = "";
        //    //    txtCountry.Text = "";
        //    //  txtAmountDue.Text = "";

        //}
        private void button_Display_Click(object sender, EventArgs e)
        {
            //  try  {
            button_RetrieveData_Click(this, null);
            if (_transactionValues.Count < 2) return;
            if (_transactionValues.Count > 2) return;
            _transactionValues = new List<string>();
            string bigstring = textBox_Display.Text;
            bigstring.Replace('\r', '\0');
            dataStrings = bigstring.Split('\n');
            _transactionValues.Add(dataStrings[0]);
            dataGridView1.Rows.Clear();
            for (int i = 1; i < dataStrings.Length - 1; i++)
            {
                if (dataStrings[i].Length < 5) continue;
                _transactionValues.Add(dataStrings[i]);
            }
            string[] _actionValues = _transactionValues[0].Split(',');
            textBox_DocNum.Text = _actionValues[0].ToString();
            textBox_DocType.Text = _actionValues[1].ToString();
            textBox_ExternalRef.Text = _actionValues[2].ToString();
            textBox_InternalRef.Text = _actionValues[3].ToString();
            textBox_Status.Text = _actionValues[4].ToString();
            //   TextBox_ProcID.Text = _actionValues[5].ToString();
            textBox_TrDate.Text = _actionValues[6].ToString();
            textBox_StatusDate.Text = _actionValues[7].ToString();
            textBox_DebitAmount.Text = _actionValues[8].ToString();
            textBox_CreditAmount.Text = _actionValues[9].ToString();
            textBox_Description.Text = _actionValues[10].ToString();

            DisplaySpecificTransactionInfo(_transactionValues[0]);
            DisplayHeadings();
            button_DisplayList_Click(this, null);
            TableDisplay();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(" error in displaying transaction " + textBox_DocNum.Text + " :  " + ex.Message);
            //    return;
            //}
        }

        //private void comboBox_SelectedTrans_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //  //  textBox_ID.Text = (comboBox_SelectedTrans.SelectedItem).ToString().Substring(0, 4).TrimEnd();
        //  //  textBox_ProcID.Text = comboBox_SelectedTrans.SelectedIndex.ToString();
        //    ResetBoxes();
        //    listBox1.Items.Clear();
        //  //  dataGridView1.Visible = false;
        //}


        private void button_DisplayList_Click(object sender, EventArgs e)
        {
            List<TransactionItem> _alist2 = new List<TransactionItem>();
            string displayDetailStr = String.Format("select * from transactions_Details where doctype = {0} and DocNum = {1} order by index2 desc",
                                                                                           textBox_DocType.Text, textBox_DocNum.Text);
            //         Int32.Parse(textBox_ID.Text));  //  processID desc
            List<string> _alist3 = Utilities.DataBaseUtility.GetList(displayDetailStr);
            // DataTable dtable = Utilities.DataBaseUtility.GetTable(displayCmdStr); // textBox_Display.Text = cmdStr + "\r\n";
            // dataGridView2.DataSource = dtable;
            //if ( dtable.Rows.Count < 1) return;
            //  _alist3 = Utilities.DataBaseUtility.GetList(displayCmdStr, ',');  //  _transactionValues;  //
            for (int i = 1; i < _alist3.Count; i++)
            {
                String[] t_strings = _alist3[i].Split(',');
                //   textBox_Display.Text += _alist3[i] + "\r\n";
                TransactionItem t_item = new TransactionItem(t_strings);
                _alist2.Add(t_item);
            }
            //loadDetailInfo();
            DisplayListDetails();
        }
        private void DisplayListDetails()
        {
            List<TransactionItem> _alist2 = new List<TransactionItem>();
            string bigstring = textBox_Display.Text;
            bigstring.Replace('\r', '\0');
            string[] _alist3 = bigstring.Split('\n');
            for (int i = 1; i < _alist3.Length - 1; i++)
            {
                if (_alist3[i].Length < 5) continue;
                String[] t_strings = _alist3[i].Split(',');
                //  textBox_Display.Text += _alist3[i] + "\r\n";
                TransactionItem t_item = new TransactionItem(t_strings);
                _alist2.Add(t_item);
            }
            double[] totals = new double[10];
            //    if (comboBox_SelectedTrans.SelectedIndex < 0)
            //        comboBox_SelectedTrans.SelectedIndex = 1;
            //  DisplaySpecificEmployeeInfo(comboBox_SelectedTrans.SelectedIndex);
            //DisplayHeadings();

            foreach (TransactionItem t_item in _alist2)
            {
                int typeIndex = t_item.RecordType;
                if (t_item.RecordType < 0) typeIndex = 2;
                listBox1.Items.Add(t_item.ToString(typeIndex));
                totals[typeIndex] += t_item.Total;
            }
            listBox1.Items.Add(String.Format("{0,56} {1,14}        {2,14}", "  ", "-------", "-------"));
            listBox1.Items.Add(String.Format("{0,56} {1,14:C}      {2,16:C}", "  ", totals[1], totals[2]));
            listBox1.Items.Add("  "); listBox1.Items.Add("  "); listBox1.Items.Add("  ");

        }
        //private void loadDetailInfo()
        //{
        //    string   cmdStr = "select * from TransactionItems where trans_ID = " + textBox_ID.Text;
        //    DataTable dTable = Utilities.DataBaseUtility.GetTable(cmdStr);
        //  //  dataGridView1.DataSource = dTable;
        //  //  dataGridView1.Visible = true;
        //}
        private void DisplayHeadings()
        {

            listBox1.Items.Add(String.Format("{0,-10} {1,-8}{2,1}{3,-35}          {4,-12}          {5,-13}",
                                              "Account", "Detail", " ", " Account Names ", "Debit", "Credit"));
            //                                  0      1          2       3            4               5
            listBox1.Items.Add(String.Format("{0,-10}{1,-8}{2,1}{3,-30}            {4,-12}           {5,-13}",
                                "------   ", "------", "  ",
                                                                    //               0                 1                 2             3            
                                                                    "-------------------", "---------", "---------"));
            //                                                                 4                              5        
        }
        private void DisplaySpecificTransactionInfo(string _transactionStr)
        {
            string[] items = _transactionStr.Split(',');
            string indexstr = items[0].Trim() + " / " + items[1]; // _alist2(selectedIndex).Trans_ID;  //  textBox1.Text;   
            string descripto = textBox_Description.Text;  // items[7];// "description";//alist1[selectedIndex].Description;
            string datestr = items[6];// _alist1[selectedIndex].TransDate.ToShortDateString();
            listBox1.Items.Add(" ");
            listBox1.Items.Add(String.Format("{0} Transaction {1}   {2}", datestr, indexstr.Trim(), descripto));
            listBox1.Items.Add("");
        }
        //dgvPurchaseOrder.Rows.Add(_poItem.ProductID.ToString(), _name,
        //                         String.Format("{0,12}", _poItem.Quantity),
        //                         string.Format("{0,12:C}", _poItem.Price),
        //                         "", //discount goes here
        //                         string.Format("{0,16:C}", _itemTotalCost));

        private void button_Table_Click(object sender, EventArgs e)
        {
            // listBox1.Visible = !listBox1.Visible;
            // dataGridView1.Visible = !dataGridView1.Visible;
            new Utilities.Documents.ChangeDocument(ident, textBox_DocType.Text, textBox_DocNum.Text, "Transactions").Show();
        }

        private void TableDisplay()
        {
            string[] dataValues;
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            string bigstring = textBox_Display.Text;
            bigstring.Replace('\r', '\0');
            dataStrings = bigstring.Split('\n');
            for (int i = 1; i < dataStrings.Length - 1; i++)
            {
                dataGridView1.Rows.Add();
                dataValues = dataStrings[i].Split(',');
                dataGridView1.Rows[i - 1].Cells[0].Value = String.Format("{0,12}", Int32.Parse(dataValues[3]));
                dataGridView1.Rows[i - 1].Cells[1].Value = String.Format("{0,12}", Int32.Parse(dataValues[2]));
                dataGridView1.Rows[i - 1].Cells[2].Value = (dataValues[7]);
                dataGridView1.Rows[i - 1].Cells[3].Value = (dataValues[3]);
                dataGridView1.Rows[i - 1].Cells[4].Value = (dataValues[6]);
                dataGridView1.Rows[i - 1].Cells[5].Value = (dataValues[7]);
                int debitValue = Int32.Parse(dataValues[4]);
                double dispValue = 0.0;  // Double.Parse(dataValues[5]) * Double.Parse(dataValues[6]);
                if (debitValue < 0.00)
                {
                    //  dispValue *= -1.0;
                    dataGridView1.Rows[i - 1].Cells[7].Value = String.Format("{0,15:C}", dispValue);
                }
                else
                {
                    dataGridView1.Rows[i - 1].Cells[6].Value = String.Format("{0,15:C}", dispValue);

                }
            }
        }

        private void button_RawData_Click(object sender, EventArgs e)
        {
            textBox_Display.Visible = !textBox_Display.Visible;
        }



        Double ColumnSum(int colIndex)
        {
            int lastrow = dataGridView1.Rows.Count - 1;
            double _sum = 0.00;
            Double _cellValue = 0;
            for (int i = 0; i < lastrow; i++)
            {
                if (dataGridView1.Rows[i].Cells[colIndex].Value != null)
                    try
                    {
                        _cellValue = Double.Parse(dataGridView1.Rows[i].Cells[colIndex].Value.ToString());
                    }
                    catch (Exception) { }
                _sum += _cellValue;
                _cellValue = 0.00;
            }
            return _sum;
        }

        private void button_DisplayMultipleTransactions_Click(object sender, EventArgs e)
        {
            button_Display_Click(this, null);
            //  DisplayMultipleTransactions mult = new DisplayMultipleTransactions(base.ident); mult.Show(); 
        }
        private void button_RetrieveData_Click(object sender, EventArgs e)
        {
            displayCmdStr = textBox_CMD.Text;
            _transactionValues = Utilities.DataBaseUtility.GetList(displayCmdStr, ',');
            if (_transactionValues.Count < 2)
            {
                MessageBox.Show(displayCmdStr + "  Not Found");
                return;
            }
            if (_transactionValues.Count > 2)
            {
                int lastItem = _transactionValues.Count - 1;
                comboBox_SelectedTrans.Items.Clear();
                for (int i = 1; i <= lastItem; i++)
                {
                    string[] trstr = _transactionValues[i].Split(',');
                    string itemStr = String.Format("{0} , {1} , {2}", trstr[0], trstr[1], trstr[10]);
                    comboBox_SelectedTrans.Items.Add(itemStr);
                }
                MessageBox.Show("multiple transactions selected - use drop-down list to select individual transactions");
                return;
            }
            //  exactly 1 transaction selection
            textBox_Display.Text = _transactionValues[1] + "\r\n";
            //textBox_ActionType.Text = fields[
            string part2 = " order by index2 desc";   //  for Transactions
            if ((textBox_TableName.Text.Trim() == "processDocs") || (textBox_TableName.Text.Trim() == "ProcessDocs"))
                part2 = "Order by ListPrice Desc";

            string cmdStr = String.Format("select * from {0}_Details where DocNum = {1} and DocType = {2} {3}",
                   textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text, part2);
            _transactionDetailValues = Utilities.DataBaseUtility.GetList(cmdStr, ',');
            ////  dataGridView1.DataSource = _actionValues;
            if (_transactionDetailValues.Count < 2)
            {
                MessageBox.Show(cmdStr + "  Not Found");
                return;
            }
            for (int i = 1; i < _transactionDetailValues.Count; i++)
            {
                textBox_Display.Text += _transactionDetailValues[i] + "\r\n";
            }

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    new Accounting.Transactions.EditTransaction(base.ident).Show();
        //}



        private void comboBox_SelectedTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = comboBox_SelectedTrans.SelectedItem.ToString().Split(',');
            textBox_DocNum.Text = fields[0].Trim();
            textBox_DocType.Text = fields[1].Trim();
            button_Reset_Click(this, null);
        }

        protected void button_Reset_Click(object sender, EventArgs e)
        {
            int terms = 0;
            string connector1 = "";
            string connector2 = "";
            string connector3 = "";
            string part0 = "select * from " + textBox_TableName.Text;
            string part1 = "";
            if (textBox_DocNum.Text.Length > 2)
            {
                connector1 = " where ";
                part1 = " DocNum = " + textBox_DocNum.Text.Trim();
                terms++;
            }

            string part2 = "";
            if (textBox_DocType.Text.Length > 2)
            {
                connector2 = " where ";
                part2 = " DocType = " + textBox_DocType.Text.Trim();
                if (++terms > 1) connector2 = " and ";
            }
            string part3 = "";
            if (textBox_ExternalRef.Text.Length > 0)
            {
                connector3 = " where ";
                part3 = " ExtRef = " + textBox_ExternalRef.Text.Trim();
                if (++terms > 1) connector3 = " and ";
            }
            textBox_CMD.Text = part0 + connector1 + part1 + connector2 + part2;// +connector3 + part3;
        }

        private void button_DisplaySingle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button_Display_Click(this, null);
        }

        private void comboBox_TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmdStr = string.Format("select DocNum, DocType, Description from  Transactions");
            DataTable dt = new DataTable();
            //dt = Utilities.DataBaseUtility.GetTable(cmdStr);
            List<string> st = Utilities.DataBaseUtility.GetList(cmdStr);
            

            foreach (string s1 in st)
            {
                string[] items = s1.Split(',');
                comboBox_TableName.Items.Add(items[0] + " , " + items[1] + " , " + items[2]);
            }
            if (count > 0)
            {
                
                string[] items1 = comboBox_TableName.Text.Split(',');
                textBox_CMD.Text = String.Format("Select * from {0} where DocNum = {1} and DocType = {2}", txt_table.Text, items1[0], items1[1]);
                //button_RetrieveData_Click(this, null);
            }
            count++;
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            List<string> st = Utilities.DataBaseUtility.GetList(textBox_CMD.Text);
            
            for(int i = 1; i < st.Count; i ++)
            {
                    string[] items = st[i].Split(',');
                    textBox_DocNum.Text = items[0];
                    textBox_ExternalRef.Text = items[1];
                    textBox_InternalRef.Text = items[2];
                    textBox_DocType.Text = items[3];
                    textBox_Status.Text = items[4];
                    textBox_TrDate.Text = items[6];
                    textBox_StatusDate.Text = items[7];
                    textBox_DebitAmount.Text = items[8];
                    textBox_CreditAmount.Text = items[9];
                    textBox_Description.Text = items[10];

                listBox1.Items.Add(textBox_Description);
                
            }
            string header = string.Format("Account Number \t Details \t Account Names \t\t\t Debits \t\t\t\t Credits");
            listBox1.Items.Add(header);
            listBox1.Items.Add("==========================================================================================================");
            string query = textBox_CMD.Text.Replace("Transactions", "Transactions_Details");
            //string query = "Select * from TRANSACTIONS_DETAILS where DocNum = '" + textBox_DocNum.Text.Trim() + "' and DocType = '" + textBox_DocType.Text.Trim() + "'";
            List<string> newSt = Utilities.DataBaseUtility.GetList(query);
            decimal creditTotal = 0.0m;
            decimal debitTotal = 0.0m;
            for (int i = 1; i < newSt.Count; i ++)
            {
                string debit = "";
                string credit = "";
                
                string[] items = newSt[i].Split(',');
                string docNum = items[0];
                string account_number = items[3];
                string details = items[2];
                string account_names = items[7];
                
                if(Convert.ToInt32(items[4]) < 0)
                {
                    debitTotal +=  (Convert.ToDecimal(items[5]) * Convert.ToDecimal(items[6]));
                    debit = (Convert.ToDecimal(items[5]) * Convert.ToDecimal(items[6])).ToString();
                }
                else if(Convert.ToInt32(items[4]) > 0)
                {
                    creditTotal += (Convert.ToDecimal(items[5]) * Convert.ToDecimal(items[6]));
                    credit = (Convert.ToDecimal(items[5]) * Convert.ToDecimal(items[6])).ToString();
                }
                string listText = string.Format("{0} \t {1} \t {2} \t\t\t ${3} \t\t\t\t ${4}", account_number, details, account_names, debit, credit);
                listBox1.Items.Add(listText);

            }
            listBox1.Items.Add("\t\t\t\t\t============================================================");
            string totals = string.Format(" \t \t \t\t\t \t\t ${0} \t\t\t\t ${1}", creditTotal, debitTotal);
            listBox1.Items.Add(totals);
            listBox1.Items.Add("\n");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button_Display_Click_1(this, null);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Display_Click_1(this, null);
        }





        //private void button_Change_Click(object sender, EventArgs e)
        //{
        //    new LocalBikes.Accounting.Transactions.CreateTransaction(ident, textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text).Show();

        //}


    }
}
