using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UtilityFunctions.Materials
{
    public partial class DisplaySelectedMaterial : Utilities.DisplayEntity2
    {
        DataTable _materialValues;
        public DisplaySelectedMaterial()
        {
            InitializeComponent();
        }
        public DisplaySelectedMaterial(IdentityObject _ident, string _materialID)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            _materialValues = Utilities.DataBaseUtility.GetTable(" select * from materials");
            for (int i = 0; i < _materialValues.Rows.Count; i++)
            {
                //      comboBox1.Items.Add(_productNames[i][0] + " :  " + _productNames[i][1]);
                comboBox1.Items.Add(_materialValues.Rows[i][0].ToString() + " :  "
                    + _materialValues.Rows[i][2].ToString() + "  " + _materialValues.Rows[i][3].ToString());
            }
            textBox0.Text = _materialID;
         //   int materialIndex = Int32.Parse(_materialID);
            textBox_CMD.Text = String.Format("select * from materials where DocNum = {0}", _materialID);
            button_DisplayEntity_Click(this, null);
        }

        private void button_DisplayEntity_Click(object sender, EventArgs e)
        {
                 string cmdStr = String.Format(" select * from materials where docNum = {0}", textBox0.Text);
                 DataTable _productValues = Utilities.DataBaseUtility.GetTable(cmdStr);  //  textBox_CMD.Text);
                 if (_productValues.Rows.Count < 1) return;
                textBox2.Text = _productValues.Rows[0][2].ToString();
                textBox3.Text = _productValues.Rows[0][3].ToString();
                textBox4.Text = _productValues.Rows[0][4].ToString();
                textBox5.Text = _productValues.Rows[0][5].ToString();
                textBox6.Text = _productValues.Rows[0][6].ToString();
                textBox7.Text  = _productValues.Rows[0][7].ToString();
                textBox8.Text  = _productValues.Rows[0][8].ToString();
                textBox10.Text = _productValues.Rows[0][10].ToString();
                panel3.Visible = true;
        }

        protected /*override */ void button_Edit_Click(object sender, EventArgs e)
        {
            new NewApplication.NewApplication_Main().Show(); return;
        }
    }
}
