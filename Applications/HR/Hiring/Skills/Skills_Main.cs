using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Skills
{
    public partial class Skills_Main : HR.Hiring.Skills.Skills_Template
    {
        public Skills_Main()
        {
            InitializeComponent();
        }

        public Skills_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
