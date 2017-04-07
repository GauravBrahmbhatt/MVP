using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales.Services
{
    public partial class Services : HAWK_Template_2
    {
        public Services()
        {
            InitializeComponent();
        }
          public Services(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        private void label_SubName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Applications.Sales.Services.ServiceOrder.ServiceOrder(ident).Show();

        }

       
    }
}
