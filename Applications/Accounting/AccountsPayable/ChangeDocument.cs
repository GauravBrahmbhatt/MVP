using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsPayable
{
    public partial class ChangeDocument : Utilities.Documents.ChangeDocument
    {
        public ChangeDocument()
        {
            InitializeComponent();
        }

        public ChangeDocument(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
