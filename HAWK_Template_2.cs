using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


    public partial class HAWK_Template_2 : HAWK_Template_1 
    {

     
        public HAWK_Template_2()
        {
            InitializeComponent();
            if (ident == null) ident = new IdentityObject();
            label_UserID.Text = ident.UserID;
            label_UserName.Text = ident.UserName;
        }

     
        protected override  void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            Utilities.Documents.DisplaySelectedObject  dispObj = new Utilities.Documents.DisplaySelectedObject (base.ident); dispObj.Show();
        }

        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            Utilities.Documents.ListObjects listObj = new Utilities.Documents.ListObjects(base.ident); listObj.Show();
        }

        protected override  void button_ChangeObject_Click(object sender, EventArgs e)
        {
              Utilities.Documents.ChangeDocument changeDoc = new Utilities.Documents.ChangeDocument (base.ident); changeDoc.Show();
        }  
        
         
    }

