using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations.Employee.ViewAllServices
{
    public partial class ViewAllServices : HAWK_Template_2
    {
        public ViewAllServices()
        {
            InitializeComponent();
        }

        public ViewAllServices(IdentityObject ident)
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
