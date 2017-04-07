using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Applications
{
    public partial class Applications_Main : HR.Hiring.Applications.Applications_Template
    {
        public Applications_Main()
        {
            InitializeComponent();
        }
        public Applications_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
