using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Payroll
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_DisplayDoc_Click(object sender, EventArgs e)
        {

        }

        private void button_DisplaySelected_Click(IdentityObject ident,string tableName,string docType,string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
            textBox_TableName.Text = tableName;
            button_ResetCommand_Click(this, null);


        }
    }
}
