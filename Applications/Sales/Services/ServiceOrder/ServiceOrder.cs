using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales.Services.ServiceOrder
{
    public partial class ServiceOrder : Utilities.Documents.ListObjects
    {
        public double docnum = 0;
        public ServiceOrder()
        {
            InitializeComponent();
        }
          public ServiceOrder(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
                  
            textBox_CMD.Text = String.Format("select * from ProcessDocs where docType = 22");
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable;
            dataGridView1.Visible = true;
        }
        
          private void button1_Click(object sender, EventArgs e)
          {
             DataTable dt = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
             int docNum = dt.Rows.Count;
             Object temp = dt.Rows[docNum-1][1];
             docnum = Convert.ToDouble(temp);
             new Applications.Sales.Services.ServiceOrder.NewServiceOrder.NewServiceOrder(ident).Show();
          }

          
     

    }
}
