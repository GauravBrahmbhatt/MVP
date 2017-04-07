using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UtilityFunctions
{
    public partial class ListEntities : HAWK_Template_2 
    {
        public ListEntities()
        {
            InitializeComponent();
        }
        public ListEntities(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        public ListEntities(IdentityObject ident, string EntityType)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_TableName.Text = EntityType;
            int entityIndex = Int32.Parse(EntityType);
            comboBox1.SelectedIndex = entityIndex;
            //textBox_CMD.Text = "select * from " + EntityType;
            button_Display_Click(this, null);
        }
     
        private void comboBox_TableName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox_TableName.Text = comboBox1.SelectedItem.ToString();
            textBox_CMD.Text = "select * from " + textBox_TableName.Text;
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable;
 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string itemStr = comboBox1.SelectedItem.ToString();
            int indx = itemStr.IndexOf(",");
            textBox_TableName.Text = itemStr.Substring(indx + 1);
            textBox_CMD.Text = String.Format("select * from {0} order by DocNum", textBox_TableName.Text);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //if ((textBox_TableName.Text.Trim() == "materials") || (textBox_TableName.Text.Trim() == "Materials"))
            //{    new UtilityFunctions.Materials.DisplaySelectedMaterial(base.ident, docNumStr).Show();  return;}
            //else
                new Utilities.DisplayEntity2(ident,textBox_TableName.Text,docNumStr,docTypeStr  ).Show();          
        }

         
    }
}
