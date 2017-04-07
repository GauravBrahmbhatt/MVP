using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Utilities;

namespace UtilityFunctions
{
    public partial class ImportDataFromExcel : HAWK_Template_2
    {
        private static string ExcelConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        string filePath;

        public ImportDataFromExcel()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void ThreadMethod()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                string extension = Path.GetExtension(filePath);
                string conString = "";
                string sheetName = "";
                switch (extension)
                {
                    //case ".xls":
                    //    conString = string.Format(Excel03ConString, filePath, "YES");
                    //    break;
                    case ".xlsx":
                        conString = string.Format(ExcelConString, filePath, "YES");
                        break;
                }

                OleDbConnection con = new OleDbConnection(conString);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                con.Open();
                DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                sheetName = dtExcelSchema.Rows[0]["Table_Name"].ToString();
                con.Close();

                con.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter();
                cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                // con.Open();
                oda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                oda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(ThreadMethod));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        Dictionary<Type, OleDbType> GetSQLTypeConversionMap()
        {
            var result = new Dictionary<Type, OleDbType>();
            result.Add(typeof(string), OleDbType.VarChar);
            result.Add(typeof(Int16), OleDbType.Double);
            result.Add(typeof(Int32), OleDbType.Double);
            result.Add(typeof(decimal), OleDbType.Double);
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string fileName = Path.GetFileNameWithoutExtension(filePath);
            DataTable dt = new DataTable(fileName);

            // add the columns to the datatable            
            if (dataGridView1.Columns != null)
            {
                Type type;

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (i < 6)
                    {
                        type = typeof(Int32);
                    }
                    else if (i >= 8 && i < 10)
                    {
                        type = typeof(decimal);
                    }
                    else
                    {
                        type = typeof(string);
                    }
                    dt.Columns.Add(dataGridView1.Columns[i].HeaderText, type);
                }
            }

            //  add each of the data rows to the table
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;
                DataRow dr = dt.NewRow();
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dr[i] = (row.Cells[i].Value == null ? DBNull.Value : row.Cells[i].Value);
                }
                dt.Rows.Add(dr);
            }

            string cmdString = String.Format("select table_name from test.tables where UPPER(table_name) = {0}", fileName);
            int retCount = Utilities.DataBaseUtility.Execute(ident, cmdString);

            // if does not exist
            if (retCount != 0)
            {
                cmdString = null;
                string cmdStmt = null;
                OleDbType sqlDataType;
                //string dataType;
                var result = GetSQLTypeConversionMap();
                // selecting each column of the datatable to create a table in the database
                foreach (DataColumn dc in dt.Columns)
                {
                    if (dc.DataType == typeof(string))
                    {
                        sqlDataType = result[typeof(string)];

                    }
                    else if (dc.DataType == typeof(Int16))
                    {
                        sqlDataType = result[typeof(Int16)];

                    }
                    else
                    {
                        sqlDataType = result[typeof(decimal)];
                    }
                    cmdStmt = cmdStmt + dc.ColumnName + " " + sqlDataType.ToString() + ",";

                }

                cmdString = String.Format("CREATE TABLE " + dt.TableName + " (" + cmdStmt.TrimEnd(',') + ")");

                retCount = Utilities.DataBaseUtility.Execute(ident, cmdString);

                //copying the data from datatable to Access database table
                OleDbConnection con;
                con = Utilities.DataBaseUtility.GetConnectionObject();
                //String _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= PACS.accdb";
                using (con)
                {
                    var adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = new OleDbCommand("SELECT * FROM " + dt.TableName + "", con);

                    var cbr = new OleDbCommandBuilder(adapter);

                    //cbr.GetDeleteCommand();
                    cbr.GetInsertCommand();
                    //cbr.GetUpdateCommand();

                    try
                    {
                        con.Open();
                        adapter.Update(dt);
                    }
                    catch (OleDbException ex)
                    {
                        //MessageBox.Show(ex.Message, "OledbException Error");
                        MessageBox.Show("The table is not GenDoc compatible. Please contact Infrastructure Team.");
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "Exception Error");
                    }
                }
            }
        }
    }
}
