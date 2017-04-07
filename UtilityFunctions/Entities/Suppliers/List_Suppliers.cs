using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UtilityFunctions.Suppliers
{
    public partial class List_Suppliers : UtilityFunctions.ListEntities
    {
        public List_Suppliers()
        {
            InitializeComponent();
        }
        public List_Suppliers(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            comboBox1.SelectedIndex = 3;
        }
    }
}
