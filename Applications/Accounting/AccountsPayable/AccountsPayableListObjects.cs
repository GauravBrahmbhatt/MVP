using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsPayable
{
    public partial class AccountsPayableListObjects : Utilities.Documents.ListObjects
    {
        public AccountsPayableListObjects()
        {
            InitializeComponent();
        }
        public AccountsPayableListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;

        }
        protected override void dataGridView1_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr,
                docNumStr).Show();
        }

        private void comboBox_TableName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }     



    }
}
