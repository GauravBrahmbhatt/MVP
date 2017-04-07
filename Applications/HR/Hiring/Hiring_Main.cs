using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring
{
    public partial class Hiring_Main : HR.Hiring.Hiring_Template
    {
        public Hiring_Main()
        {
            InitializeComponent();
        }
        public Hiring_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

    }
}
