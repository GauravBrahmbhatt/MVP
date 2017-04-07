using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Documents
{
    public partial class Documents_Main : Utilities.Documents.Document_Template
    {
        public Documents_Main()
        {
            InitializeComponent();
        }
        public Documents_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            Utilities.Documents.ListObjects pds = new Utilities.Documents.ListObjects(base.ident); pds.Show();

        }
    }
}
