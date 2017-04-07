using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsPayable
{
    public partial class Formatted_Display : Utilities.Documents.DisplaySelectedObject
    {
        public Formatted_Display()
        {
            InitializeComponent();
        }

        public Formatted_Display(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
