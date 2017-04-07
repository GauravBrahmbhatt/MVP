using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Employees
{
    public partial class CreateEmployee : Employees_Template
    {
        public CreateEmployee()
        {
            InitializeComponent();
        }
        public CreateEmployee(IdentityObject _ident)
        {
            InitializeComponent();
        }
    }
}
