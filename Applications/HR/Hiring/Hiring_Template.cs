using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring
{
    public partial class Hiring_Template : HAWK_Template_2
    {
        public Hiring_Template()
        {
            InitializeComponent();
        }

        public Hiring_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        //view applications
        private void button2_Click(object sender, EventArgs e)
        {
            //new HR.Hiring.ListObject(base.ident, "1").Show();
            new Hiring.Applications.Applications_ListObjects(ident).Show();
        }
        //view Jobs
        private void button1_Click(object sender, EventArgs e)
        {
            new Hiring.Jobs.Jobs_ListObjects(ident).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Hiring.Interview.Interview_ListObjects(ident).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Hiring.Skills.Skills_ListObjects(ident).Show();
        }
    }
}
