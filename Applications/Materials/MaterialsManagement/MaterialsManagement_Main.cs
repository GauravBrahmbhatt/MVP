using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials.MaterialsManagement
{
    public partial class MaterialsManagement_Main : Applications.Materials.MaterialsManagement.MaterialsManagement_Template
    {
        public MaterialsManagement_Main()
        {
            InitializeComponent();
        }
        public MaterialsManagement_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListObjects ls = new ListObjects();
            ls.Show();
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            ListObjects ls = new ListObjects();
            ls.Show();
        }

        private void btn_deliveries_Click(object sender, EventArgs e)
        {
            new Applications.Materials.MaterialsManagement.Deliveries.Deliveries().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Applications.Materials.MaterialsManagement.Shipments.Shipments().Show();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            new Applications.Materials.MaterialsManagement.Inventory().Show();
        }

        private void MaterialsManagement_Main_Load(object sender, EventArgs e)
        {

        }

    }
}
