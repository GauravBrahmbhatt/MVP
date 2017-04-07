using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Interview
{
    public partial class Interview_DisplaySelectedObjects : Utilities.Documents.DisplaySelectedObject
    {
        public Interview_DisplaySelectedObjects()
        {
            InitializeComponent();
        }
        public Interview_DisplaySelectedObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        public Interview_DisplaySelectedObjects(IdentityObject ident, string tableName, string docType, string docNum)
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
