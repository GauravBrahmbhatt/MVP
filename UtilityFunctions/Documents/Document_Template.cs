using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Documents
{
    public partial class Document_Template : HAWK_Template_2
    {
        public Document_Template()
        {
            InitializeComponent();
        }
       // protected IdentityObject ident;
        // protected virtual void button_ListObjects_Click(object sender, EventArgs e)
        protected override   void button_ListObjects_Click(object sender, EventArgs e)
        {
          //  this.Close();
            ListObjects  tal = new ListObjects (base.ident );      tal.Show();
   
        }
        protected override  void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
           // this.Close();
            DisplaySelectedObject  dstra = new DisplaySelectedObject(base.ident);    dstra.Show();
   
        }
        protected override void button_ChangeObject_Click(object sender, EventArgs e)
        {
            ChangeDocument app = new ChangeDocument(base.ident); app.Show();
        }
   }
}
