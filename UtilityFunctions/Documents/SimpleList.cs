using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UtilityFunctions.Documents
{
    public partial class SimpleList : HAWK_Template_2
    {
        public SimpleList()
        {
            InitializeComponent();
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_Command.Text);
            dataGridView1.DataSource = dTable;
        }
    }
}
