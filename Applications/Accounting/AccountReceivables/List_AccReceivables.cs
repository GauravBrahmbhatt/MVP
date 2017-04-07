using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{

    public partial class List_AccReceivables : Utilities.Documents.ListObjects
    {
      
        public List_AccReceivables()
        {
            this.components = null;
            InitializeComponent();
        }


        public List_AccReceivables(IdentityObject ident)
    {
        this.components = null;
        this.InitializeComponent();
        base.SaveIdent(ident);
        base.DisplayIdent(ident);
        base.textBox_DocType.Text = "59";
        base.textBox_CMD.Text = "select * from AccountsReceivable";
        button_Display_Click_1(this,null);
        
    }



        private void button_List_Click(object sender, EventArgs e)
        {
            Accounting.AccountReceivables.ListObjects lstObj = new AccountReceivables.ListObjects();
            lstObj.Show();
        }

        private void button_DisplaySelected_Click(object sender, EventArgs e)
        {
            Accounting.AccountReceivables.DisplaySelectedObject displayObj = new DisplaySelectedObject();
            displayObj.Show();
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable;
            dataGridView1.Visible = true;
            
        }

        protected override void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();

        }


    }
}
