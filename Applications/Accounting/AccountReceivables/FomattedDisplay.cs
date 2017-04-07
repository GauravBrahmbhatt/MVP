using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountReceivables
{
    public partial class FomattedDisplay : HAWK_Template_2
    {
        public FomattedDisplay()
        {
            InitializeComponent();
        }

        public FomattedDisplay(IdentityObject ident)
    {
        this.components = null;
        this.InitializeComponent();
        base.label_SubName.Text = "Receivable invoice";
        base.SaveIdent(ident);
        base.DisplayIdent(ident);
    }

        public FomattedDisplay(IdentityObject ident, string tableName, string docType, string docNum)
    {
        this.components = null;
        this.InitializeComponent();
        base.label_SubName.Text = "Receivable invoice";
        base.SaveIdent(ident);
        base.DisplayIdent(ident);
        //this.load_IDs(tableName, docType);
        //this.textBox_DocNum.Text = docNum;
        //this.textBox_DocType.Text = docType;
        //this.textBox_TableName.Text = tableName;
        //this.comboBox_Table.SelectedIndex = 0;
        //this.comboBox_DisplayType.SelectedIndex = 0;
    }
    }
}
