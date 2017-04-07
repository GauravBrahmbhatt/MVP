using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class ListObjects : Utilities.Documents.ListObjects
    {

      
        public ListObjects()
        {
            
            InitializeComponent();
            base.SaveIdent(base.ident);
            base.DisplayIdent(base.ident);
            base.textBox_DocType.Text = "58";
            base.textBox_CMD.Text = "select * from processDocs where DocType = 58";
            this.button_Display_Click(this, null);
        }

        public ListObjects(IdentityObject _ident, string docTypeStr)
        {
            //this.components = null;
            this.InitializeComponent();
            base.SaveIdent(base.ident);
            base.DisplayIdent(base.ident);
            base.textBox_DocType.Text = docTypeStr;
        }

        private void button_CreateInvoice_Click(object sender, EventArgs e)
        {
        }

       

        protected override void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = base.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string str2 = base.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            base.textBox_DocType.Text = str2;
            base.textBox_DocNum.Text = str;
            new DisplaySelectedObject(base.ident, base.textBox_TableName.Text, base.textBox_DocType.Text, base.textBox_DocNum.Text).Show();
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            DataTable table = Utilities.DataBaseUtility.GetTable(base.textBox_CMD.Text);
            base.dataGridView1.DataSource = table;
        }

       

       
    }
}
