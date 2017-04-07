using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewApplication
{
    public partial class NewApplication_Main : NewApplication_Template
    {
        public NewApplication_Main()
        {
            InitializeComponent();
        }
        public NewApplication_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
