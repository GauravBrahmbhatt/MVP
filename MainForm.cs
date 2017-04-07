using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Collections.Generic;
using System.Data;

  public partial class MainForm : HAWK_Template_1 
  {
        Boolean authorized = true;  //  This will change when security is updated
       // public IdentityObject ident;
        string _password;
        public MainForm()
        {
            InitializeComponent();
            ident = new IdentityObject("000", "guest", "guest",0,0);
          
         }
        private void button_Accounting_Click(object sender, EventArgs e)
        {
           // new NewApplication.NewApplication_Main(base.ident).Show();
               new Applications.Applications. Accounting.Accounting_Main(base.ident).Show();
        }

        private void button_HR_Click(object sender, EventArgs e)
        {
        // new Applications.Applications.HR.HrBenefit.HrBenefit_Main(ident).Show();//     HR_Main(ident).Show();
        //  new NewApplication.NewApplication_Main(base.ident).Show();
        new Applications.Applications.HR.HrBenefit.HrBenefit_Main (ident).Show();
        }

        private void button_Materials_Click(object sender, EventArgs e)
        {
            {
                new Applications.Applications.Materials.Materials_Main(base.ident ).ShowDialog();
                //new NewApplication.NewApplication_Main(base.ident).Show();
            }
        }




        private void button_Marketing_Click(object sender, EventArgs e)
        {
             new Applications.Applications.Sales.Sales_Main(ident).Show();  
            //new NewApplication.NewApplication_Main(base.ident).Show();

        }

        private void button_Operations_Click(object sender, EventArgs e)
        {
              new Applications.Applications.Operations.Operations_Main(base.ident).Show();
            //  new NewApplication.NewApplication_Main(base.ident).Show();

        }


        private void button_Payroll_Click(object sender, EventArgs e)
        {
        //new Applications.
               new Applications.Applications.  Payroll.Payroll_Main(ident).Show();
            //new NewApplication.NewApplication_Main(base.ident).Show();

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SearchDataSources_Click(object sender, EventArgs e)
        {
            Infrastructure.Search_Database app1 = new Infrastructure.Search_Database(ident); app1.Show();

        }

     
        private void button_Utilities_Click(object sender, EventArgs e)
        {
            Infrastructure.Infrastructure_Main app4 = new Infrastructure.Infrastructure_Main(ident); 
            app4.Show();
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            _password = textBox_Password.Text;
            if ((_password.IndexOf(@"\") == 3)
              ||(_password.IndexOf(@"/") == 3))
            {
                string _userID = _password.Substring(0, 3);
                string _role = _password.Substring(4);
                List<string> _emplStr = Utilities.DataBaseUtility.GetList("select * from employees where DocNum = " + _userID);
                Utilities.Employee _empl = new Utilities.Employee(_emplStr[1]);
                ident.UserID = _userID;
                ident.UserName = _empl.LastName;
                ident.Role = _empl.Role;
                ident.Role = _empl.Role;
                ident.ActionLevel = Int32.Parse(_empl.AdmLevel);
                ident.Dept = Int32.Parse(_empl.DeptID);
                List<string> _dept = Utilities.DataBaseUtility.GetList("select * from departments");
                int deptID = Int32.Parse(_empl.DeptID);
                if (deptID > 0) textBox_Dept.Text = _dept[deptID + 1].Substring(4);
                textBox_Role.Text = _empl.Role;
                textBox_UserID.Text = _empl.LastName;
                base.SaveIdent(ident);
                base.DisplayIdent(ident);

            }           
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
    
   

