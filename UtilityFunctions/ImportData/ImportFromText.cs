using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Threading;
using System.Configuration;

namespace UtilityFunctions
{
    public partial class ImportFromText : HAWK_Template_3
    {
        string filepath;
        List<String> _list;
        public ImportFromText()
        {
            InitializeComponent();
        }
        public ImportFromText(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_FindFile_Click(object sender, EventArgs e)
        {
            //Thread newThread = new Thread(ThreadStart.Start);
            //newThread.SetApartmentState(ApartmentState.STA);
            //newThread.Start();
           // try         {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                  string   fullFilePath = openFileDialog1.FileName;
                    int indx = fullFilePath.LastIndexOf("\\") ;
                    textBox_FilePath.Text = fullFilePath.Substring(0,indx + 1);
                    textBox_TableName.Text = fullFilePath.Substring( indx + 1);
                    textBox_CMD.Text = textBox_FilePath.Text + textBox_TableName.Text;
                }
          //  }               catch { }
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            filepath = textBox_CMD.Text;
            _list = new List<string>();
             comboBox_Data.Items.Clear();
            try
            {
                System.IO.FileStream infile = new System.IO.FileStream(filepath, System.IO.FileMode.Open);
                System.IO.StreamReader reader = new System.IO.StreamReader(infile);
                string inputstr = reader.ReadLine();
                while (inputstr != null)
                {
                    _list.Add(inputstr);
                    comboBox_Data.Items.Add(inputstr);
                    inputstr = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            System.Text.StringBuilder strBldr = new StringBuilder();
            foreach (string _record in _list)
            {
                strBldr.Append(_record.ToString());
                strBldr.Append("\r\n");
            }
            textBox_CSV_Data.Text = strBldr.ToString();

        }

        //public class DynamicRecordList
        //{
        //    private static List<string> _list;

        //    public List<string> Select()
        //    {
        //        return _list;
        //    }
        //    public DynamicRecordList()
        //    {
        //        _list = new List<String>();
        //    }

        //    public void Initialize(string bigstring)
        //    {
        //        string[] records;
        //        // if (delim == '\n')
        //        records = bigstring.Split(new char[] { '\n' });
        //        _list = new List<String>();
        //        foreach (string _record in records)
        //            _list.Add(_record);
        //    }
        //    public void Initialize(string filename, string path)
        //    {
        //        DeSerialize(filename, path);
        //    }
        //    public virtual void DeSerialize(string filename, string filepath)
        //    {
        //            }
        //    public void Serialize(string filename, string path)
        //    {
        //        System.IO.FileStream outfile = new System.IO.FileStream(path + filename, System.IO.FileMode.Create);
        //        System.IO.StreamWriter writer = new System.IO.StreamWriter(outfile);
        //        writer.Write(this.ToString());
        //        writer.Close();
        //    }
        //    public void Append(String _record)
        //    {
        //        _list.Add(_record);
        //    }
        //    public int Delete(string target)
        //    {
        //        int number_deleted = 0;
        //        foreach (string _record in _list)
        //        {
        //            if (_record == target)
        //            {
        //                _list.Remove(_record);
        //                number_deleted += 1;
        //                break;
        //            }
        //        } return number_deleted;
        //    }

        //    public int Count()
        //    {
        //        return _list.Count;
        //    }
        //    public int Insert(int start, int length, string keyStr, string record)
        //    {
        //        int number_found = 0;
        //        foreach (string _record in _list)
        //        {
        //            string target = _record.Substring(start, length);
        //            if (keyStr == target)
        //                number_found += 1;
        //        }
        //        if (number_found == 0)
        //        {
        //            _list.Add(record);
        //            return 1;
        //        }
        //        return 0;
        //    }
        //    public int Delete(int start, int length, string keyStr, string mode)
        //    {
        //        int number_deleted = 0;
        //        foreach (string _record in _list)
        //        {
        //            string target = _record.Substring(start, length);
        //            if (keyStr == target)
        //            {
        //                _list.Remove(_record);
        //                number_deleted += 1;
        //                if (mode == "first") break;
        //            }
        //        } return number_deleted;
        //    }
        //}
    }
}
