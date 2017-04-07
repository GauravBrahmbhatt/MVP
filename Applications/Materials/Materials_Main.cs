using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials
{
    public partial class Materials_Main : Applications.Materials.Materials_Template
    {
        public Materials_Main()
        {
            InitializeComponent();
        }
        public Materials_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            new Applications.Materials.MaterialsManagement.MaterialsManagement_Main(ident).Show();
        }

     }
}
