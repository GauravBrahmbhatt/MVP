using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    public partial class HAWK_Template_1 : Form0
    {
        protected IdentityObject ident;

        public HAWK_Template_1()
        {
            InitializeComponent();

        }
        public HAWK_Template_1(IdentityObject ident)
        {
            InitializeComponent();
            SaveIdent(ident);
            DisplayIdent(ident);
        }

        protected virtual void button_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected virtual void SaveIdent(IdentityObject _ident)
        {

            ident = _ident;
        }
        protected virtual void DisplayIdent(IdentityObject _ident)
        {

            label_UserID.Text = ident.UserID;
            label_UserName.Text = ident.UserName;
        }

        protected virtual void SetSubLabel(string newValue)
        {
            label_SubName.Text = newValue;
        }

     
        protected virtual void button_Search_Click(object sender, EventArgs e)
        {
            Infrastructure.Search_Database app1 = new Infrastructure.Search_Database(ident); app1.Show();
        }
        protected virtual void button_SearchData_Click(object sender, EventArgs e)
        {
            Infrastructure.Search_Database app1 = new Infrastructure.Search_Database(ident); app1.Show();
    
        }

        protected virtual void button_ListObjects_Click(object sender, EventArgs e)
        {
            MessageBox.Show("must replace template call with overriding call");
        }

        protected virtual void button_ChangeObject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("must replace template call with overriding call");
        }

        protected virtual  void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("must replace template call with overriding call");
     
        }
      
    }
