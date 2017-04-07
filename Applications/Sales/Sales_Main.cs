using Applications.Applications.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales
{
    public partial class Sales_Main : Applications.Sales.Sales_Template
    {
        public Sales_Main()
        {
            InitializeComponent();
        }
        public Sales_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_Services_Click(object sender, EventArgs e)
        {

        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            new Applications.Sales.ListObjects(ident).Show();
        }

        public static int GetNextNumber(string tableName, int _column, string oldTarget)
        {
            int nextNumber = -1;
            string target = "";
            if (oldTarget != "")
                try
                {
                    int lastnumber = Int32.Parse(oldTarget);
                    if (lastnumber > -1) return lastnumber + 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Non-numeric target in TextBox  : " + oldTarget);
                    return -1;
                }
            try
            {

                List<string> _list = Utilities.DataBaseUtility.GetList("select max(DocNum) from " + tableName);

                //for(int i=0; i<_list.Count; i++){

                //}                
                int lastrow = _list.Count - 1;
                string[] lastrowStr = _list[lastrow].Split(',');
                target = lastrowStr[_column];
                nextNumber = Int32.Parse(target) + 1;

                return nextNumber;
            }
            catch (Exception)
            {
                MessageBox.Show("Non-numeric target in table index  : " + target);
                return -1;
            }
        }
    }
    
}
