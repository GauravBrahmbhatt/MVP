using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Skills
{
    public partial class Skills_DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public Skills_DisplaySelectedObject()
        {
            InitializeComponent();
        }
        public Skills_DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        public Skills_DisplaySelectedObject(IdentityObject ident, string tableName, string docType, string docNum)
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
