using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class ReceivePayment : Utilities.Documents.ChangeDocument
    {
        public ReceivePayment()
        {
            InitializeComponent();
        }

        public ReceivePayment(IdentityObject ident)
        {
            this.components = null;
            this.InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public ReceivePayment(IdentityObject ident, string tableName, string docType, string docNum)
        {
            this.components = null;
            this.InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            base.textBox_DocNum.Text = docNum;
            base.textBox_DocType.Text = docType;
            base.textBox_TableName.Text = tableName;
            this.button_ResetCommand_Click(this, null);
            this.button_DisplaySelectedObject_Click(this, null);
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            base.textBox_DocType.Text = "49";
            base.textBox_Comment.Text = "Receive Payment from customer";
            base.textBox_TextValue1.Text = DateTime.Now.ToShortDateString();
            base.textBox_TextValue2.Text = DateTime.Now.ToShortDateString();
            //this.button_Convert.Visible = false;
            DataTable table = new DataTable();
            base.dataGridView1.DataSource = table;
        }

        private void button_Transaction_Click(object sender, EventArgs e)
        {
            new CreateReceivableDoc(base.ident, "processDocs", "58", base.textBox_DocNum.Text).Show();
        }
    }
}
