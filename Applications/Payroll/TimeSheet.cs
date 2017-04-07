using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Applications.Applications.Payroll
{
    public partial class TimeSheet : Utilities.Documents.ListObjects
    {
        public TimeSheet()
        {
            InitializeComponent();
        }


        protected override void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            new Utilities.Documents.DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();

            //this.pictureBox2.Visible = false;
            // new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();
        }

        private void comboBox_DocType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {

        }
    }
}
