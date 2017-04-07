using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Jobs
{
    public partial class Jobs_Template : HAWK_Template_2
    {
        public Jobs_Template()
        {
            InitializeComponent();
        }
        public Jobs_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
