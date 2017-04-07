using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Products
{
    public partial class Products_Main : Utilities.Products_Template
    {
        public Products_Main()
        {
            InitializeComponent();
        }
        public Products_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
