using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials.MaterialsManagement
{
    public partial class Inventory : Applications.Materials.MaterialsManagement.ListObjects
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            var count = 0;
            List<string> delivery = Utilities.DataBaseUtility.GetDocumentData("select * from Deliveries_Details");
            foreach (var x in delivery)
            {

                var details = x.Split(',');
                if (count >= 1)
                {
                    string cmd = "Update Inventories set Quantity = Quantity + " + details[5] + " where Material_ID = " + details[2];
                    string message = Utilities.DataBaseUtility.Execute(cmd, ident);
                }
                count++;
            }
            lblMessage.Text = "Successfully updated in the Inventory after Deliveries!";
        }

        private void btn_Shipped_Click(object sender, EventArgs e)
        {
            var count = 0;
            List<string> shipment = Utilities.DataBaseUtility.GetDocumentData("select * from Shipments_Details");
            foreach (var x in shipment)
            {

                var details = x.Split(',');
                if (count >= 1)
                {
                    string cmd = "Update Inventories set Quantity = Quantity - " + details[5] + " where Material_ID = " + details[2];
                    string message = Utilities.DataBaseUtility.Execute(cmd, ident);
                }
                count++;
            }
            lblMessage.Text = "Successfully updated in the Inventory after Shipments!";
        }
    }
}
