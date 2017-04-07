using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales
{
    public partial class Sales_Template : HAWK_Template_2
    {
        public Sales_Template()
        {
            InitializeComponent();
        }
       public Sales_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
