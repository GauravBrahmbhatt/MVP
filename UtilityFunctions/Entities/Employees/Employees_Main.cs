using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Employees
{
    public partial class Employees_Main : Employees_Template
    {
     //   IdentityObject _ident;
     //   List<string> _employeeIDs;
        public Employees_Main(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent( identObject);
            UtilityFunctions.Employees.Employees_List2 pds = new UtilityFunctions.Employees.Employees_List2(base.ident); pds.Show();
  
        }
            
    }
}
