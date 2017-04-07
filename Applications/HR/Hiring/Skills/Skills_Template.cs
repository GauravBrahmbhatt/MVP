using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Skills
{
    public partial class Skills_Template : HAWK_Template_2
    {
        public Skills_Template()
        {
            InitializeComponent();
        }
        public Skills_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
