using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Utilities;

namespace UtilityFunctions
{
    public partial class ImportData_Main : HAWK_Template_2
    {

        public ImportData_Main()
        {
            InitializeComponent();
        }
        public ImportData_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_GeneralText_Click(object sender, EventArgs e)
        {
            new  UtilityFunctions.ImportFromText(ident).Show();
        }

        private void button_ImportDocument_Click(object sender, EventArgs e)
        {
            new NewApplication.NewApplication_Main(ident).Show();
  
        }

        private void button_ImportEntity_Click(object sender, EventArgs e)
        {
            new NewApplication.NewApplication_Main(ident).Show();
  
        }

        private void button_ImportFromSpreadsheet_Click(object sender, EventArgs e)
        {
          //  new NewApplication.NewApplication_Main(ident).Show();
            new UtilityFunctions.ImportDataFromExcel().Show();
  
        }


    }
}
