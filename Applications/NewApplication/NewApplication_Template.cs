using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewApplication
{
    public partial class NewApplication_Template : HAWK_Template_2
    {
        public NewApplication_Template()
        {
            InitializeComponent();
        }
        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            //  this.Close();
            //  ListObjects listObjs = new ListObjects(base.ident); listObjs.Show();

        }
        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            // this.Close();
            //  DisplaySelectedObject dispObj = new DisplaySelectedObject(base.ident); dispObj.Show();

        }
    }
}
