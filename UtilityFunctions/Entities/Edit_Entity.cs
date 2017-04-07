using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UtilityFunctions.Entities
{
    public partial class Edit_Entity : Utilities.DisplayEntity2
    {
        List<string> dataStringsList = new List<string>();
        public Edit_Entity()
        {
            InitializeComponent();
        }
            public Edit_Entity(IdentityObject _ident, string tablename, string entityID, string docType)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_TableName.Text = tablename;
            textBox0.Text = entityID;
            textBox_EntityType.Text = docType;
      //      FillEntityList();
        }

            private void button_Validate_Click(object sender, EventArgs e)
            {
               // String dataString;
                StringBuilder dataString1 = new StringBuilder();
                dataString1.Append(textBox0.Text + " ,");
                dataString1.Append(/*textBox_EntityType.Text +*/ "3 , '");
                dataString1.Append(textBox2.Text + "' , '");
                dataString1.Append(textBox3.Text + "' , '");
                dataString1.Append(textBox4.Text + "' , '");
                dataString1.Append(textBox5.Text + "' , '");
                dataString1.Append(textBox6.Text + "' , '");
                dataString1.Append(textBox7.Text + "' , '");
                dataString1.Append(textBox8.Text + "' , '");
                dataString1.Append(textBox9.Text + "' , '");
                dataString1.Append(textBox10.Text + "' , '");
                dataString1.Append(textBox11.Text + "' , '");
                dataString1.Append(textBox12.Text + "' , '");
                dataString1.Append(textBox_13.Text + "' , '");
                dataString1.Append(textBox14.Text + "' , '");
                dataString1.Append(textBox15.Text + "' , '");
                dataString1.Append(textBox_Comment.Text + "'");
                dataStringsList.Add(dataString1.ToString());
                textBox_DataItems.Text = dataString1.ToString();
                //if (dataGridView1.Rows.Count < 1) return;
                ////  else add the details
                //dataString1.Append("\r\n");
                //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                //{
                //    StringBuilder dataString2 = new StringBuilder();
                //    for (int col = 0; col < 7; col++)
                //    { 
                //        string cellValue = dataGridView1.Rows[i].Cells[col].Value.ToString(); 
                //        dataString2.Append(cellValue + " , "); 
                //    }
                //    string lastCellValue = dataGridView1.Rows[i].Cells[7].Value.ToString();
                //    dataString2.Append("'" + lastCellValue + "'");

                //    dataStringsList.Add(dataString2.ToString());
                //    dataString2.Append( "\r\n");
                //    dataString1.Append(dataString2.ToString());
               // }
              //  textBox_DataStrings.Text = dataString1.ToString();
        
            }
            
            private void button_Save_Click(object sender, EventArgs e)
            {
                DialogResult dr = MessageBox.Show("are you sure that you want to save ?", "Verify Operation",
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    MessageBox.Show(" Operation Cancelled by user ");
                    return;
                }
                int retCode = 0;
                //  DocNum = inDocNum;
               // DocNum = Int32.Parse(inDocNum);
               // DocType = Int32.Parse(inDocType);
                string cmdString = String.Format("insert into {0} Values ({1})", textBox_TableName.Text.Trim(), dataStringsList[0]);    //where DocNum = {1} and DocType = {2}", _tableName, inDocNum, inDocType);
                string retMessage = Utilities.DataBaseUtility.Execute(cmdString, ident);
            }

            private void button_Delete_Click(object sender, EventArgs e)
            {
                DialogResult dr = MessageBox.Show("are you sure that you want to delete ?", "Delete called", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    MessageBox.Show(" Operation Cancelled by user ");
                    return;
                }
                if (dr == DialogResult.Yes)
                {  //          Utilities.DataBaseUtility.DeleteEntity(base.ident, textBox_TableName.Text, textBox0.Text, textBox_EntityType.Text);
                    string cmdString = String.Format("delete from {0} where  DocNum = {1} and DocType = {2}", textBox_TableName.Text, textBox0.Text, textBox_EntityType.Text);
                    string retMessage = Utilities.DataBaseUtility.Execute(cmdString, ident);
                }
            }

     

      

      
            //int lastrow = dataGridView1.Rows.Count - 1;
            //for (int i = 0; i < lastrow; i++)
            //{
            //    StringBuilder dataString2 = new StringBuilder();
            //    dataString2.Append(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //    for (int j = 1; j < 7; j++)
            //        dataString2.Append(" ," + (dataGridView1.Rows[i].Cells[j]).Value.ToString());
            //        dataString2.Append(" ,'" + (dataGridView1.Rows[i].Cells[7]).Value.ToString() + "'");
            //    listBox_DataStrings.Items.Add(dataString2.ToString());
            //    datastrings.Add(dataString1.ToString());
          
            //}
            //GenDoc testObject = new GenDoc(datastrings);
            //int returnValue = testObject.CheckValues(datastrings);
            //string[] fieldNames = {"DocNumber","DocType","ExternalRef","InternalRef","Status","DocRef",
            //                       "TextValue1","TextValue2","NumValue1","NumValue2","Comment"}; 
            //if (returnValue > 0)
            //{
            //    int indx =  returnValue;
            //    string[] fields = datastrings[0].Split(',');
            //    string errorMessage = string.Format(" Error in {0}. \r\n \r\n Error in field {1}. \r\n Value {2} is not valid", textBox_TableName.Text, fieldNames[indx], fields[indx]);
            //    MessageBox.Show(errorMessage);
            //}
        //for (int i = 1; i < dataStringsList.Count; i++)
        //{
        //    string cmdString2 = String.Format("insert into {0}_Details  Values ({1})", textBox_TableName.Text.Trim(), dataStringsList[i]); 
        //    string retMessage2 = Utilities.DataBaseUtility.Execute(cmdString2, ident);
        //}
        //}
        //   (response == "yes") 
        //  string _tableName = textBox_TableName.Text;
        //  List<string> myData = new List<string>();
        //for (int i = 0; i < listBox_DataStrings.Items.Count; i++)
        //    myData.Add(listBox_DataStrings.Items[i].ToString());
        //int myDataCount = myData.Count;
        //int retcode = myDoc.SaveDocument(base.ident, _tableName, textBox0.Text, textBox_EntityType.Text, textBox_DataStrings.Text );
        // string retMessage = myDoc.SaveDocument(base.ident, textBox_TableName.Text, textBox_DocumentID.Text, textBox_DocType.Text, myData);
        

    }
}
