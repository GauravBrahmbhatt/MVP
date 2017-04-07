using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Processes
{
    public partial class DisplayProcess : HAWK_Template_2  
    {
      //  List<String> _productNames;
        DataTable _processValues;
        int processID;
        public DisplayProcess(IdentityObject _ident)
        {
            InitializeComponent();
            base.ident = _ident;
            _processValues = Utilities.DataBaseUtility.GetTable(" select procID, comment from Processes");
            for (int i = 0; i < _processValues.Rows.Count ; i++)
            {
                //      comboBox1.Items.Add(_productNames[i][0] + " :  " + _productNames[i][1]);
                comboBox1.Items.Add(_processValues.Rows[i][0].ToString() + " :  " + _processValues.Rows[i][1].ToString());
            }
        }
        public DisplayProcess(IdentityObject _ident, string _productID)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            _processValues = Utilities.DataBaseUtility.GetTable(" select DocNum, comment from Processes");
            for (int i = 0; i < _processValues.Rows.Count ; i++)
            {
                //      comboBox1.Items.Add(_productNames[i][0] + " :  " + _productNames[i][1]);
                comboBox1.Items.Add(_processValues.Rows[i][0].ToString() + " :  " + _processValues.Rows[i][1].ToString());
            }
            textBox_ProcessID.Text = _productID;
            button1_Click(this, null);
        }

        private void OLD_button1_Click(object sender, EventArgs e)
        {

            Utilities.DataBaseUtility ins = new Utilities.DataBaseUtility();
            DataTable id = new DataTable();
            int idnum;
           // string _supplierValues;

            //Handles generating a +1 value of the highest ID number in the table. This is to get around the AutoNumber feature missing from the table.
            id = Utilities.DataBaseUtility.GetTable("Select MAX([SupplierID]) from Suppliers");
            idnum = Convert.ToInt32(id.Rows[0][0]) + 1;

            string  _OLD_supplierValues = "('"+idnum.ToString()+"','"+textBox_DocNumber.Text+ "','"+textBox_ProcType.Text+"','"+textBox_Employee.Text+"','"+textBox_Department.Text+"','"+textBox_StartDate.Text+"','"+textBox_Comment.Text+"','"+textBox_Status.Text;

           // txtResultTxt.Text = _supplierValues;

           // txtSQL.Text = "INSERT INTO Suppliers ([SupplierID],[Name],[Address],[Address2],[City],[Region],[Country],[PostalCode],[Phone],[WebAddress]) VALUES " + _supplierValues;

            //Turn on the code below when ready to submit to database.
            //ins.Insert("INSERT INTO Suppliers ([SupplierID],[Name],[Address],[Address2],[City],[Region],[Country],[PostalCode],[Phone],[WebAddress]) VALUES " + values);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBoxes()
        {
            textBox_DocNumber.Text = "";
            textBox_ProcType.Text = "";
            textBox_Employee.Text = "";
            textBox_Department.Text = "";
            textBox_StartDate.Text = "";
            textBox_Status.Text = "";
            textBox_Comment.Text = "";
        
        }
            private void button1_Click(object sender, EventArgs e)
        {
            processID = Int32.Parse(textBox_ProcessID.Text);
            _processValues = Utilities.DataBaseUtility.GetTable("select * from processes where DocNum = " + processID);
            if (_processValues.Rows.Count < 1)
            {
                MessageBox.Show("did not find this process"); return;
            }
            textBox_ProcType.Text = _processValues.Rows[0][1].ToString();
            textBox_Department.Text = _processValues.Rows[0][2].ToString();
            textBox_Employee.Text = _processValues.Rows[0][3].ToString();
            textBox_Status.Text = _processValues.Rows[0][4].ToString();
            textBox_DocNumber.Text = _processValues.Rows[0][5].ToString();
            int docNumber = Int32.Parse(textBox_DocNumber.Text);
            textBox_StartDate.Text = _processValues.Rows[0][6].ToString();
            textBox_StatusDate.Text = _processValues.Rows[0][7].ToString();     //  StatusDate
            textBox_Index1.Text = _processValues.Rows[0][8].ToString();     //  quotedAmount 
            textBox_Index2.Text = _processValues.Rows[0][9].ToString();     //  actualAmount textBox_Status.Text = _processValues.Rows[0][6].ToString();
            textBox_Comment.Text = _processValues.Rows[0][10].ToString();
            DisplaySubProcesses(docNumber); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_ProcessID.Text = (comboBox1.SelectedItem).ToString().Substring(0,3);
            ResetBoxes();
        }

        private void  DisplaySubProcesses(int _docNumber)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable("select * from processDocs where DocNum = " + _docNumber );
            dataGridView1.DataSource = dtable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pStr2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string pStr4 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            int pType = Int32.Parse(pStr2);
            switch (pType)
            {
                case 11:
                 //   Purchases.PurchaseOrderDisplay disp11 = new Purchases.PurchaseOrderDisplay(pStr4);  disp11.Show();
                 //  Purchases.DisplayPurchaseOrder disp11 = new Purchases.DisplayPurchaseOrder(base.ident,pStr4);  disp11.Show();
                 //   Utilities.Documents.DisplaySelectedObject disp11 = new Utilities.Documents.DisplaySelectedObject(base.ident,pStr2,pStr4 );  disp11.Show();
                    break;
                case 12:
                 //   Deliveries.DisplayDelivery disp12 = new Deliveries.DisplayDelivery(base.ident, pStr4);  disp12.Show();
                    Utilities.Documents.DisplaySelectedObject disp12 = new Utilities.Documents.DisplaySelectedObject(base.ident,"ProcessDocs",pStr2,pStr4 );  disp12.Show();
                    break;
                case 13:
                    // Accounting.AccountsPayable.DisplayPayableDocument   disp13 = new Accounting.AccountsPayable.DisplayPayableDocument (base.ident, pStr4);  disp13.Show();
                   //  Deliveries.DisplayDelivery disp13 = new Deliveries.DisplayDelivery(base.ident, pStr4);  disp13.Show();
                       Utilities.Documents.DisplaySelectedObject disp13 = new Utilities.Documents.DisplaySelectedObject(base.ident,"ProcessDocs",pStr2,pStr4 );  disp13.Show();
                 break;
                case 14:
                case 15:
                      // Utilities.Documents.DisplaySelectedObject disp14 = new Utilities.Documents.DisplaySelectedObject(base.ident,pStr2,pStr4 );  disp14.Show();
                   //    Accounting.DisplayTransaction disp = new  Accounting.DisplayTransaction(base.ident, pStr4);    disp.Show();
                    break;
                case 21:
                  //  Invoices.SalesOrderDisplay disp21 = new Invoices.SalesOrderDisplay(pStr4, base.ident);  disp21.Show();
                    Utilities.Documents.DisplaySelectedObject disp21 = new Utilities.Documents.DisplaySelectedObject(base.ident,"ProcessDocs",pStr2,pStr4 );  disp21.Show();
                    break;
                case 22:
                    Utilities.Documents.DisplaySelectedObject disp22 = new Utilities.Documents.DisplaySelectedObject(base.ident, "ProcessDocs", pStr2,pStr4 ); disp22.Show();
                    break;
                case 23:
                 //   Invoices.InvoiceDisplay disp23 = new Invoices.InvoiceDisplay(pStr4);  disp23.Show();
                    Utilities.Documents.DisplaySelectedObject disp23 = new Utilities.Documents.DisplaySelectedObject(base.ident,"ProcessDocs", pStr2,pStr4 ); disp23.Show();
                    break;
                case 24:
                case 25:
                case 26:
                   // Accounting.DisplayTransaction disp2 = new  Accounting.DisplayTransaction(base.ident, pStr4);     disp2.Show();
                    //Utilities.Documents.DisplaySelectedObject disp24 = new Utilities.Documents.DisplaySelectedObject(base.ident, pStr2,pStr4 ); disp24.Show();
                    break;
            }
        }

    }
}
