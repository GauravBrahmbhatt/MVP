using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations.Employee.ViewPending
{
    public partial class ViewPendingServices : HAWK_Template_2
    {
        public ViewPendingServices()
        {
            InitializeComponent();
        }
        public ViewPendingServices(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
            dataGridView2.DataSource = dTable;
        }
    }
}
