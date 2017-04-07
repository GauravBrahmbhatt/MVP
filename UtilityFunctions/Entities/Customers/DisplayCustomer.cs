using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public partial class DisplayCustomer : DisplayEntity2 
    {
        List<String> _entityNames;
        DataTable _entityValues;
        public DisplayCustomer()
        {
            InitializeComponent();
            _entityNames = Utilities.DataBaseUtility.GetList(" select Name from customers");
            for (int i = 1; i < 8; i++)
            {
                comboBox1.Items.Add(i.ToString() + " :  " + _entityNames[i]);
            }
        }
        public DisplayCustomer(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            _entityNames = Utilities.DataBaseUtility.GetList(" select Name from customers");
            for (int i = 1; i < 8; i++)
            {
                comboBox1.Items.Add(i.ToString() + " :  " + _entityNames[i]);
            }
        }
        public DisplayCustomer(IdentityObject _ident,string customerID)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            _entityNames = Utilities.DataBaseUtility.GetList(" select LastName from customers");
            for (int i = 1; i < _entityNames.Count ; i++)
            {
                comboBox1.Items.Add(i.ToString() + " :  " + _entityNames[i]);
            }
            textBox0.Text = customerID;
            comboBox2.SelectedIndex = 2;
            button1_Click(this, null);
        }



        private void ResetBoxes()
        {
            //txtName.Text = "";
            //txtAddr.Text = "";
            //txtAddr2.Text = "";
            //txtCity.Text = "";
            //txtState.Text = "";
            //txtZIP.Text = "";
            //txtCountry.Text = "";
            //txtAmountDue.Text = "";
            //txtPhone.Text = "";
            //txtURL.Text = "";
            //txtName.Text = "";
        }
            private void button1_Click(object sender, EventArgs e)
        {
           string cmd = String.Format("select * from {1} where DocNum = {0}" , textBox0.Text,textBox_DocType.Text);
           textBox_CMD.Text = cmd;
           textBox_TableName.Text = "Customers";
                _entityValues = Utilities.DataBaseUtility.GetTable(cmd);
         //   dataGridView1.DataSource = _supplierValues;
            //txtName.Text = _entityValues.Rows[0][1].ToString();
            //txtAddr.Text = _entityValues.Rows[0][2].ToString();
            //txtAddr2.Text = _entityValues.Rows[0][3].ToString();
            //txtCity.Text = _entityValues.Rows[0][4].ToString();
            //txtState.Text = _entityValues.Rows[0][5].ToString();
            //txtZIP.Text = _entityValues.Rows[0][6].ToString();
            //txtCountry.Text = _supplierValues.Rows[0][7].ToString();
            //txtPhone.Text = _supplierValues.Rows[0][9].ToString();
            //txtURL.Text = _supplierValues.Rows[0][10].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox0.Text = (comboBox1.SelectedIndex +1).ToString();
            ResetBoxes();
        }


    }
}
