using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsReports
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject()
        {
            InitializeComponent();
        }

        public DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public DisplaySelectedObject(IdentityObject ident, string tableName, string docType, string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
            textBox_DocType.Text = docType;
            textBox_TableName.Text = tableName;
            button_ResetCommand_Click(this, null);
        }
    }
}
