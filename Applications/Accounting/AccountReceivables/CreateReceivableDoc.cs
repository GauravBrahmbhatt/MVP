using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class CreateReceivableDoc : ListObjects
    {
        public CreateReceivableDoc()
        {
            InitializeComponent();
        }

        public CreateReceivableDoc(IdentityObject ident)
        {
            this.components = null;
            this.InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public CreateReceivableDoc(IdentityObject ident, string tableName, string docType, string docNum)
        {
            this.components = null;
            this.InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            base.textBox_DocNum.Text = docNum;
            base.textBox_DocType.Text = docType;
            base.textBox_TableName.Text = tableName;
            //this.button_ResetCommand_Click(this, null);
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            base.textBox_DocType.Text = "58";
            //base.textBox_Comment.Text = "Receivable Document for customer";
            //base.textBox_TextValue1.Text = DateTime.Now.ToShortDateString();
            //base.textBox_TextValue2.Text = DateTime.Now.ToShortDateString();
            int num = base.dataGridView1.Rows.Count - 1;
            double num2 = 0.0;
            for (int i = 0; i < num; i++)
            {
                base.dataGridView1.Rows[i].Cells[1].Value = "58";
                double num4 = Convert.ToDouble(base.dataGridView1.Rows[i].Cells[5].Value);
                double num5 = Convert.ToDouble(base.dataGridView1.Rows[i].Cells[6].Value);
                num2 += num4 * num5;
            }
            //base.textBox_ExpectedAmount.Text = num2.ToString();
            //base.textBox_ActualAmount.Text = (num2 * 1.0825).ToString();
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            Accounting.AccountReceivables.ListObjects lstObj = new AccountReceivables.ListObjects();
            lstObj.Show();
        }

        private void button_DisplaySelected_Click(object sender, EventArgs e)
        {
            base.Close();
            Accounting.AccountReceivables.DisplaySelectedObject displayObj = new DisplaySelectedObject();
            displayObj.Show();
        }

      

        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            base.textBox_DocType.Text = "58";

            //base.textBox_Comment.Text = "Receivable Document for customer";
            //base.textBox_TextValue1.Text = DateTime.Now.ToShortDateString();
            //base.textBox_TextValue2.Text = DateTime.Now.ToShortDateString();
            int num = base.dataGridView1.Rows.Count - 1;
            double num2 = 0.0;
            for (int i = 0; i < num; i++)
            {
                base.dataGridView1.Rows[i].Cells[1].Value = "58";
                double num4 = Convert.ToDouble(base.dataGridView1.Rows[i].Cells[5].Value);
                //double num5 = Convert.ToDouble(base.dataGridView1.Rows[i].Cells[6].Value);
                num2 += num4;
            }
            //base.textBox_ExpectedAmount.Text = num2.ToString();
            //base.textBox_ActualAmount.Text = (num2 * 1.0825).ToString();
        }


    }
}
