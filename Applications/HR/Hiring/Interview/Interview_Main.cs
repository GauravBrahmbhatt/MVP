using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Interview
{
    public partial class Interview_Main : HR.Hiring.Interview.Interview_Template
    {
        public Interview_Main()
        {
            InitializeComponent();
        }
        public Interview_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
