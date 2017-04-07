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
    public partial class DisplayEntity2 :  HAWK_Template_2 
    {   
       // public string customerEmailAddress;
       // DataTable dtable;
        List<string> _entity;
        List<string> _entityList;

        public DisplayEntity2()
        {
            InitializeComponent();
        }

        public DisplayEntity2(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            FillEntityList();
        }
        public DisplayEntity2(IdentityObject _ident, string entityID)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            textBox0.Text = entityID;
            FillEntityList();
        }
        public DisplayEntity2(IdentityObject _ident, string tablename, string entityID, string docType)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_TableName.Text = tablename;
            textBox0.Text = entityID;
            textBox_EntityType.Text = docType;
            textBox_CMD.Text = "select * from " + textBox_TableName.Text;
            int docTypeIndex = Int32.Parse(docType);
        //    if (docTypeIndex == 6) 
         //         { new Materials.DisplayProduct(_ident, entityID).Show(); }
         //   else 
            FillEntityList();
        }

        private void FillEntityList()
        {
            comboBox1.Items.Clear();
            string _cmd =  textBox_TableName.Text;
            _entityList = Utilities.DataBaseUtility.GetList(_cmd);
            for (int i = 1; i < _entityList.Count; i++)
            {
                string[] _items = _entityList[i].Split(',');
                comboBox1.Items.Add(_items[0].Trim() + "  :  " + _items[2].Trim() + " " + _items[3].Trim());
            }
        }

        protected void button_DisplayEntity_Click(object sender, EventArgs e)
        {
            //dtable = Utilities.DataBaseUtility.GetTable("select * from Customers where CustomerID = "  + textBox1.Text);
            //dataGridView1.DataSource = dtable;
            panel3.Visible = true;
            string cmdStr = String.Format("select * from {0} where DocNum = {1}", textBox_TableName.Text, textBox0.Text);
            textBox_CMD.Text = cmdStr;
            _entity = Utilities.DataBaseUtility.GetList(cmdStr);
            FillTextBoxes();
        //    FillGridView();
        }
      
        protected void FillTextBoxes()
        {
            string _cmd = String.Format("select * from {0} where DocNum = {1}", textBox_TableName.Text,textBox0.Text);
            _entityList = Utilities.DataBaseUtility.GetList(_cmd);
            if (_entityList.Count <2) 
                return;
            string[] _items = _entityList[1].ToString().Split(',');
            textBox_DocType.Text = _items[1];
            textBox2.Text = _items[2];
            textBox3.Text = _items[3];
            textBox4.Text = _items[4];
            textBox5.Text = _items[5];
            textBox6.Text = _items[6];
            textBox7.Text = _items[7];
            textBox8.Text = _items[8];
            textBox9.Text = _items[9];
            textBox10.Text = _items[10];
            textBox11.Text = _items[11];
            textBox12.Text = _items[12];
            textBox_13.Text = _items[13];
            textBox14.Text = _items[14];
            textBox15.Text = _items[15];
            textBox_Comment.Text = _items[16];
        }

            

        private void button_Edit_Click(object sender, EventArgs e)
        {
            new UtilityFunctions.Entities.Edit_Entity(ident, textBox_TableName.Text, textBox0.Text, textBox_EntityType.Text).Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Visible = false;
            textBox0.Text = comboBox1.SelectedItem.ToString().Substring(0, 3).Trim();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = comboBox2.SelectedItem.ToString();
            textBox_TableName.Text = tableName.Substring(4).Trim();
            //  textBox_TableName1.Text = comboBox1.SelectedItem.ToString();
            textBox_CMD.Text = "select * from " + textBox_TableName.Text;
            FillEntityList();
  
        }

        private void button_ResetLabels_Click(object sender, EventArgs e)
        {
            string _cmd = String.Format("select * from {0} where DocNum = {1}", textBox_TableName.Text, textBox0.Text);
            _entityList = Utilities.DataBaseUtility.GetList(_cmd);
            if (_entityList.Count < 2)
                return;
            string[] _items = _entityList[0].ToString().Split(',');
            label_0.Text = _items[0];
            label_1.Text = _items[1];
            label_2.Text = _items[2];
            label_3.Text = _items[3];
            label_4.Text = _items[4];
            label_5.Text = _items[5];
            label_6.Text = _items[6];
         //   if (_items[7].Length > 9) label_7.Text = _items[7].Substring(0,8);  else
            label_7.Text = _items[7];
            label_8.Text = _items[8];
         //   if (_items[9].Length > 9) label_9.Text = _items[9].Substring(0, 8);  else
            label_9.Text = _items[9];
            label_10.Text = _items[10];
            label_11.Text = _items[11];
            label_12.Text = _items[12];
            label_13.Text = _items[13];
            label_14.Text = _items[14];
            label_15.Text = _items[15];
            label_16.Text = _items[16];
        }


    }
}
