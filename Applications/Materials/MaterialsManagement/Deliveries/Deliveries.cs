using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials.MaterialsManagement.Deliveries
{
    public partial class Deliveries : Applications.Materials.MaterialsManagement.ListObjects
    {
        public Deliveries()
        {
            InitializeComponent();
        }
        public Deliveries(IdentityObject identObject)
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

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void rd_Delivered_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Delivered.Checked == true)
            {
                textBox_CMD.Text = "Select * from ProcessDocs Where doctype = 11 and DocNum not in(Select DocNum From ProcessDocs Where DocType = 13 Group by docnum)";
                DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
                dataGridView1.DataSource = dtable;
                lblMessage.Text = "Details of Delivered Orders";
            }
        }

        private void rd_Undelivered_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Undelivered.Checked == true)
            {
                textBox_CMD.Text = "Select * from ProcessDocs Where doctype = 13";
                DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
                dataGridView1.DataSource = dtable;
                lblMessage.Text = "Details of Undelivered Orders";
            }
        }
    }
}
