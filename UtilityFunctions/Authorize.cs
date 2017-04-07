using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
namespace Utilities
{
    public class Security
    {

        public static string AuthenticatedRole(string _userID, string _password)
        {
            return _password;
        }
        public static  Boolean Authorize(IdentityObject _ident, string _resource)
        {
            bool _authorized = false;
            if (_ident.Role  == "employee")
                _authorized = true;
            return _authorized;
        }
        /*   if (txtUserID.Text.Trim() == string.Empty)
                {
               //     MessageBox.Show("Please, enter User ID.");
                    return;
                }

                if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please, enter Password.");
                    return;
                }

                using (OleDbConnection connection = new OleDbConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT User_ID, Password, [Type] FROM Login WHERE User_ID=" + txtUserID.Text.Trim() + " AND Password='" + txtPassword.Text + "'";

                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;

                    DataSet dataResult = new DataSet();
                    adapter.Fill(dataResult, "Login");

                    if (dataResult.Tables["Login"].Rows.Count >= 0)
                    {
                        HomeForm frmHome = new HomeForm();
                        frmHome.EmployeeID = txtUserID.Text.Trim();
                        frmHome.FrmLogin = this;
                        frmHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserID/Password.");
                        txtUserID.Focus();
                    }
                }  
            }

            private void LoginForm_Activated(object sender, EventArgs e)
            {
                txtUserID.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUserID.Focus();
            }
           */
    }
}