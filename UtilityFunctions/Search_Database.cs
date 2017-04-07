using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb ;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace  Infrastructure
{
    public partial class Search_Database : Form0 
    {
        string  cmdStr;
        List<String> queryList;
      //  IdentityObject ident;

        public Search_Database(IdentityObject _ident)
        {
            InitializeComponent();
            if (_ident != null)    label_Ident.Text = _ident.UserID.ToString() + " : " + _ident.UserName;
            LoadBasicQueries();
        }

        public void LoadBasicQueries()
        {    // (1) Download a table of queries
            textBox_CMD3.Text = "";
         //   DataTable queryTable = new DataTable();
            queryList = Utilities.DataBaseUtility.GetList("select * from BasicQueries");
            int numReturned = queryList.Count - 1;
            comboBox_Query.Items.Clear();
            for (int i = 1; i < numReturned;i++ )
            {
                string[] fields = queryList[i].Split(',');
                comboBox_Query.Items.Add(fields[0] );
        
            }
        }

    


        private void comboBox_Query_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = queryList[ comboBox_Query.SelectedIndex + 1].Split(',');
            
            textBox_CMD3.Text = fields[2];
            label_Response.Text = "";
            dataGridView3.Visible = false;

        }


        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_CMD3.Text = "";
            label_Response.Text = "";
            LoadBasicQueries();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_DisplaySelected_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            cmdStr = textBox_CMD3.Text;
            if (checkBox1.Checked) cmdStr = textBox_CMD3.Text + " order by DocNum";
            dTable = Utilities.DataBaseUtility.GetTable(cmdStr);
            if (dTable == null) return;
            int numReturned = dTable.Rows.Count;
            label_Response.Text = numReturned.ToString() + "  rows were found";
            dataGridView3.DataSource = dTable;
            dataGridView3.Visible = true;

        }

    }
}