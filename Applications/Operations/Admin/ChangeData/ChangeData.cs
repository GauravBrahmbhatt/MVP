using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations.Admin.ChangeData
{
    public partial class ChangeData : Utilities.Documents.ListObjects
    {
        public ChangeData()
        {
            InitializeComponent();
        }
        public ChangeData(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
