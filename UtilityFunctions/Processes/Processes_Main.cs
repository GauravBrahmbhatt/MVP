using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UtilityFunctions.Processes
{
    public partial class Processes_Main : Utilities.Process_Template
    {
        public Processes_Main()
        {
            InitializeComponent();

        }
        public Processes_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);

        }
    }
}
