using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Employees
{
    public partial class Employees_Template : HAWK_Template_2
    {
        public Employees_Template()
        {
            InitializeComponent();
        }
        protected override void SaveIdent(IdentityObject _ident)
        {
            base.SaveIdent(_ident);
            label_UserID.Text = _ident.UserID;
            label_UserName.Text = _ident.UserName;
        }

        protected override  void button_ListObjects_Click(object sender, EventArgs e)
        {
            this.Close();
            UtilityFunctions.Employees.Employees_List2 app = new UtilityFunctions.Employees.Employees_List2(base.ident);
            app.Show();
        }

        protected override  void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            this.Close();
            DisplayEmployee app = new DisplayEmployee(base.ident);
            app.Show();
        }
    }
}
