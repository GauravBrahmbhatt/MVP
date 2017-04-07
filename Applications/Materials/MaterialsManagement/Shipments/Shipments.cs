using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials.MaterialsManagement.Shipments
{
    public partial class Shipments : Applications.Materials.MaterialsManagement.ListObjects
    {
        public Shipments()
        {
            InitializeComponent();
        }
         public Shipments(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            base.DisplayIdent(identObject);
        }

         private void button_Display_Click_1(object sender, EventArgs e)
         {
             if (textBox_CMD.Text == "" || textBox_CMD.Text == null)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please select table name from Dropdown List.";
                comboBox_TableName.Focus();

            }
            else
            {
                DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
                dataGridView1.DataSource = dTable;
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Results of " + comboBox_TableName.Text + "Table";
            }
         }

         private void rd_Shipped_CheckedChanged(object sender, EventArgs e)
         {
             if (rd_Shipped.Checked == true)
             {
                 textBox_CMD.Text = "Select * from ProcessDocs where DocType = 14";
                 DataTable dtable = Utilities.DataBaseUtility.GetTable("Select * from ProcessDocs where DocType = 14");
                 dataGridView1.DataSource = dtable;
                 dataGridView1.Visible = true;
                 lblMessage.Text = "Details of Shipped Orders!";
             }
         }

         private void rd_Unshipped_CheckedChanged(object sender, EventArgs e)
         {
             if (rd_Unshipped.Checked == true)
             {
                 textBox_CMD.Text = "SELECT * FROM ProcessDocs WHERE doctype = 21 and DocNum not in(SELECT DocNum FROM ProcessDocs WHERE DocType=14 group by docnum)";
                 DataTable dtable = Utilities.DataBaseUtility.GetTable("SELECT * FROM ProcessDocs WHERE doctype = 21 and DocNum not in(SELECT DocNum FROM ProcessDocs WHERE DocType=14 group by docnum)");
                 dataGridView1.DataSource = dtable;
                 dataGridView1.Visible = true;
                 lblMessage.Text = "Details of UnShipped Orders!";
             }
         }


    }
}
