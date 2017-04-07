using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales
{
    public partial class ChangeDocumentSales : Utilities.Documents.ChangeDocument
    {
        public ChangeDocumentSales()
        {
            InitializeComponent();
        }
                 
        public ChangeDocumentSales(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void button_Save_Click_1(object sender, EventArgs e)
        {

        }
    }
}
