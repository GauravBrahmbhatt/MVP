using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    public partial class Products_Template : HAWK_Template_2
    {
        public Products_Template(IdentityObject _ident)
        {
            InitializeComponent();
            dateLbl.Text = DateTime.Now.ToString();
            base.SaveIdent(_ident);

        }
        public Products_Template()
        {
            InitializeComponent();
            dateLbl.Text = DateTime.Now.ToString();

        }
             protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            this.Close();
            Materials_List _prodList = new Materials_List(base.ident);
            _prodList.Show();

        }

    
        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            this.Close();
            Utilities.Materials.DisplayProduct mdp = new Utilities.Materials.DisplayProduct(ident);
            mdp.Show();
 
        }

  
    

        //private void button_LowInventory_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Materials.LowMaterials_List mcp = new LowMaterials_List(ident);
        //    mcp.Show();
  
        //}
       

    }
}
