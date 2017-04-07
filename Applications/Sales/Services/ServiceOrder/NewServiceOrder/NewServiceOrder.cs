using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales.Services.ServiceOrder.NewServiceOrder
{
    public partial class NewServiceOrder : Utilities.Documents.ChangeDocument
    {
        ServiceOrder serObj = new ServiceOrder();
        
        public NewServiceOrder()
        {
            InitializeComponent();
            
        }
        public NewServiceOrder(IdentityObject ident)
        {
            InitializeComponent();
            textBox_DocNum.Text = serObj.docnum.ToString();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
