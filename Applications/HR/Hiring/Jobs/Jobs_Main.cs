using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Jobs
{
    public partial class Jobs_Main : HR.Hiring.Jobs.Jobs_Template
    {
        public Jobs_Main()
        {
            InitializeComponent();
        }
        public Jobs_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
