using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UtilityFunctions.Employees
{
    public partial class Employees_List2 : UtilityFunctions.ListEntities
    {
        public Employees_List2()
        {
            InitializeComponent();
        }
        public Employees_List2(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
