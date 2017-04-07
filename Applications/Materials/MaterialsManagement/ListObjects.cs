using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials.MaterialsManagement
{
    public partial class ListObjects : Utilities.Documents.ListObjects
    {
        public ListObjects()
        {
            InitializeComponent();
        }
        public ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

    }
}
