using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales
{
    public partial class CreateSalesQuote : Utilities.Documents.ChangeDocument
    {
        int nextProcessID = 0;
        string listPrice = "";
        double expectedPrice =0;
        double actualPrice = 0;
        public CreateSalesQuote()
        {
            InitializeComponent();
        }
        public CreateSalesQuote(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public CreateSalesQuote(IdentityObject ident, string tableName, string docType, string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
            textBox_DocType.Text = docType;
            textBox_TableName.Text = tableName;
            textBox_IntAgent.Text = ident.UserID;
            textBox_Status.Text = "2";
            textBox_TextValue1.Text = DateTime.Now.ToShortDateString().Substring(0,9);
            textBox_TextValue2.Text = DateTime.Now.ToShortDateString().Substring(0,9);
            textBox_ExpectedAmount.Text = "0";
            textBox_ActualAmount.Text = "0";
            textBox_ExtAgent.Text = "0";
            button_ResetCommand_Click(this, null);

            //find next processID
            nextProcessID = Sales_Main.GetNextNumber("ProcessDocs", 0, "");
            textBox_ProcessID.Text = nextProcessID.ToString();

            List<string> materials = Utilities.DataBaseUtility.GetList("select Comments from Materials order by Comments", ',');
            for (int i = 0; i < materials.Count; i++)
            {
                this.comboBox_Material.Items.Add(materials[i]);
            }
            Bind();
            
        }
        public void Bind()
        {
            DataTable dt = new DataTable();
            string cmd = String.Format("Select * from SalesQuotes_Details where DocNum = {0} and DocType = {1}", textBox_DocNum.Text, textBox_DocType.Text);
            dt = Utilities.DataBaseUtility.GetTable(cmd);
            this.dataGridView1.Visible = true;
            this.dataGridView1.DataSource = dt;
        }            

        private void comboBox_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlSelectedPrice = String.Format("Select Price from Materials where Comments = '{0}'", comboBox_Material.Text);
            List<string> mPriceSelected = Utilities.DataBaseUtility.GetList(sqlSelectedPrice, ',');
            textBox_Price.Text = mPriceSelected[1];
            listPrice = mPriceSelected[1];
        }

        private void textBox_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p = comboBox_Material.Text;

            string sqlSelectMaterial = String.Format("Select DocNum from Materials where Comments = '{0}'", p);
            List<string> mDocNumSelected = Utilities.DataBaseUtility.GetList(sqlSelectMaterial, ',');
            string idSelected = mDocNumSelected[1];
         

            string sql = String.Format("insert into SalesQuotes_Details values ({0}, {1}, {2}, 0, {3}, {4}, {5}, '{6}')", textBox_DocNum.Text, textBox_DocType.Text, idSelected, listPrice, textBox_Quantity.Text, textBox_Price.Text,comboBox_Material.Text);

            string update = Utilities.DataBaseUtility.Execute(sql, ident);
            Bind();
            expectedPrice += Convert.ToDouble(listPrice) * Convert.ToInt32(textBox_Quantity.Text);
            actualPrice += Convert.ToDouble(textBox_Price.Text) * Convert.ToInt32(textBox_Quantity.Text);
            textBox_ExpectedAmount.Text = expectedPrice.ToString();
            textBox_ActualAmount.Text = actualPrice.ToString();
        }

        private void button_Save_Click_1(object sender, EventArgs e)
        {

        }

        private void button_PostSalesQuote_Click(object sender, EventArgs e)
        {
            string comment = "Sales Quote for customer " + textBox_ExtAgent.Text;

            string sql = String.Format("insert into ProcessDocs values ({0}, {1}, {2},{3}, {4}, {5},'{6}','{7}',{8},{9},'{10}')",
                textBox_ProcessID.Text, textBox_DocType.Text, textBox_ExtAgent.Text, textBox_IntAgent.Text,
                textBox_Status.Text, textBox_ProcessID.Text, textBox_TextValue1.Text, textBox_TextValue2.Text,
                textBox_ExpectedAmount.Text, textBox_ActualAmount.Text, comment);

            string update = Utilities.DataBaseUtility.Execute(sql, ident);
            //

            DataTable quoteLines = new DataTable();
            string cmd = String.Format("Select * from SalesQuotes_Details where DocNum = {0} and DocType = {1}", textBox_DocNum.Text, textBox_DocType.Text);
            quoteLines = Utilities.DataBaseUtility.GetTable(cmd);

            foreach (DataRow row in quoteLines.Rows)
            {
                string materialID = row[2].ToString();
                //string index2 = row[3].ToString();
                //string listPrice = row[4].ToString();
                string quantity = row[5].ToString();
                string price = row[6].ToString();
                //string comment = row[7].ToString();               

                
                sql = String.Format("insert into ProcessDocs_Details values ({0}, {1}, {2},{3}, {4}, {5},'{6}','{7}')",
           textBox_ProcessID.Text, textBox_DocType.Text, materialID, textBox_Status.Text,
            textBox_ProcessID.Text, quantity, price, comment);
                update = Utilities.DataBaseUtility.Execute(sql, ident);

            }


            //
            MessageBox.Show("Sales Quote posted!");
        }
    }
}
