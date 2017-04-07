using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

   public partial class HAWK_Template_3 : HAWK_Template_2 
    {
        public HAWK_Template_3()
        {
            InitializeComponent();
            base.SaveIdent(new IdentityObject());
        //    Load_External_Refs();
        //    Load_Internal_Refs();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
                string part1 = "select * from  " + textBox_TableName.Text;
                string part2 = "";
                string part3 = "";
                if (textBox_ExternalRef.Text != "")
                    part2 = " where ExtRef = " + textBox_ExternalRef.Text;
                if (textBox_InternalRef.Text != "")
                {
                    if (textBox_ExternalRef.Text != "")
                        part3 = " and IntRef =  " + textBox_InternalRef.Text;
                    else part3 = " where IntRef =  " + textBox_InternalRef.Text; 
                }
                textBox_CMD.Text = part1 + part2 + part3;
      
        }
        protected void Load_External_Refs()
        {
            List<string> extRefs = new List<string>();
            if (textBox_TableName.Text == "")
                MessageBox.Show("enter name in tablebox and click 'Reset command' button");
            List<string> targets = Utilities.DataBaseUtility.GetList("Select * from " + textBox_TableName.Text);
            for (int i = 1; i < targets.Count; i++)
            {
                string[] fields = targets[i].Split(',');
                int indx = findTarget(extRefs, fields[2]);
                if (indx == -1)
                {
                    extRefs.Add(fields[2]);
                }
            }
            for (int i = 0; i < extRefs.Count; i++)
            {
                comboBox1.Items.Add(extRefs[i]);
            }
        }
        protected void Load_Internal_Refs()
        {
            List<string> intRefs = new List<string>();
            if (textBox_TableName.Text == "")
                MessageBox.Show("enter name in tablebox and click 'Reset command' button");
            List<string> targets = Utilities.DataBaseUtility.GetList("Select * from " + textBox_TableName.Text);
            for (int i = 1; i < targets.Count; i++)
            {
                string[] fields = targets[i].Split(',');
                int indx = findTarget(intRefs, fields[3]);
                if (indx == -1)
                {
                    intRefs.Add(fields[3]);
                }
            }
            for (int i = 0; i < intRefs.Count; i++)
            {
                comboBox2.Items.Add(intRefs[i]);
            }
        }
        protected int findTarget(List<string> targetList, string target)
         {
             int response = -1;
             for (int i=0; i< targetList.Count;i++)
                 if (targetList[i] == target)
                     response = i;
             return response;
         }
         protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            Utilities.Documents.DisplaySelectedObject app = new 
                Utilities.Documents.DisplaySelectedObject(base.ident,textBox_TableName.Text,"*","*"); app.Show();
        }

         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {
             textBox_ExternalRef.Text = comboBox1.SelectedItem.ToString();
         }

         private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
         {
             textBox_InternalRef.Text = comboBox2.SelectedItem.ToString();
         }
            
    }
