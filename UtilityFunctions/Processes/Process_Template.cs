using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    public partial class Process_Template : HAWK_Template_2 
    {
        public Process_Template()
        {
            InitializeComponent();
        }
     //   protected IdentityObject ident;
        public  void button_ListALL_Click(object sender, EventArgs e)
        {
            this.Close();
            //Infrastructure.Transactions_List  tal = new Infrastructure.Transactions_List (ident );      tal.Show();
   
        }

        public void button_DisplaySpecific_Click(object sender, EventArgs e)
        {
            this.Close();
            Utilities.Processes.DisplayProcess dstra = new Utilities.Processes.DisplayProcess(ident); dstra.Show();
   
        }

        public  void button_Multiple_Click(object sender, EventArgs e)
        {
            this.Close();
          //  Utilities.BeginNewProcess bnp = new Utilities.BeginNewProcess(ident);        bnp.Show();
   
        }

        public  void button_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
          //  CreateTransaction ctr = new CreateTransaction (ident );        ctr.Show();
  
        }

        //public  void button_Return_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void button_Search_Click(object sender, EventArgs e)
        //{
        //    new Infrastructure.Search_Database(ident).Show();
        //}
    }
}
