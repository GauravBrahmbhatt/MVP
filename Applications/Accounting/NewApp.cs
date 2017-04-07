using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting
{
    public partial class NewApp : NewApplication.NewApplication_Main
    {
        public NewApp()
        {
            InitializeComponent();
        }
        public NewApp(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent (ident);
        }
    }
}
