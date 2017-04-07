using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Jobs
{
    public partial class Jobs_ListObjects : Utilities.Documents.ListObjects
    {
        private IdentityObject identityObject;
        private string p;
        public Jobs_ListObjects()
        {
            InitializeComponent();
        }
        public Jobs_ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            loadTable();
        }
        public Jobs_ListObjects(IdentityObject identityObject, string p)
        {
            // TODO: Complete member initialization
            this.identityObject = identityObject;
            this.p = p;
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;
        }
        protected override void dataGridView1_CellContentClick(object sender,
    DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr,
                docNumStr).Show();
        }
        private void loadTable()
        {
            comboBox_TableName.Items.Clear();
            comboBox_TableName.Items.Add("JobDescription");
        }
    }
}
