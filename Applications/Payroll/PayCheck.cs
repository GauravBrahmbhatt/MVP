using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using iTextSharp;

using System.IO;
using iTextSharp.text;

namespace Applications.Applications.Payroll
{
    public partial class PayCheck : Utilities.Documents.Documents_Main
    {
        public PayCheck(String value)
        {

            InitializeComponent();
            List<string> queryList = Utilities.DataBaseUtility.GetList("select distinct start_date,end_date from Timesheets");

            var roleQuery = "SELECT * FROM employees where docnum=109";

            var rolevalue = Utilities.DataBaseUtility.GetList(roleQuery);
            String[] rolesValue = rolevalue[1].Split(',');

            String role = rolesValue[14];
            List<Int32> employeeList = new List<Int32>();

            if (role.Equals("Supervisor  "))
            {
                employeesAdmin.Visible = true;

                for (int i = 101; i < 111; i++)
                {
                    employeeList.Add(i);  
                }


                employeesAdmin.DataSource = employeeList;    
            }
            
            queryList[0] = "Select Date Combination";
            for (var i = 1; i <= queryList.Count - 1; i++)
            {
                var arrayelement= queryList[i].Split(',');
                queryList[i] = arrayelement[0] + " To " + arrayelement[1];
            }
            listBox1.DataSource = queryList;

            if (value.Equals("payslip"))
            { 
            button1.Text = "Download PaySlip";
            
            }
            else if (value.Equals("grosspay"))
            {
                button1.Text = "View Gross Pay";

            }
            else if (value.Equals("netpay"))
            {
                button1.Text = "View Net Pay";

            }
            //listBox1.DataBindings();
        }


        public PayCheck()
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            var datecombination =listBox1.SelectedValue.ToString();
            datecombination =  datecombination.Replace("To", ",");
            var arrayelement = datecombination.Split(',');
            List<string> queryList = Utilities.DataBaseUtility.GetList("select distinct start_date,end_date from Timesheets");
            //var stringvalue = String.Format("select e.FirstName,e.LastName,e.Role,g.gross_amt,n.netpay_amt,n.deduction_amt from ((employees e join netpay n on e.DocNum=n.Emp_id) join grosspay g on e.docnum=g.emp_id) where e.docNum=104 and n.paystartdate='{0}' and n.payenddate='{1}'", arrayelement[0].Substring(0, arrayelement[0].Length - 15).Trim(), arrayelement[1].Substring(0, arrayelement[0].Length - 14).Trim());
            int employeeID = 0;
            try
            {

                 employeeID = Convert.ToInt32(employeesAdmin.Text);
            }
            catch (Exception ex)
            {
                employeeID = 104;
            }

            if (employeeID < 111 && employeeID > 100)
            {

            }
            else
            {
                employeeID = 104;
            }


            //var stringvalue = "SELECT e.FirstName,e.LastName,e.Role,n.netpay_amt,n.deduction_amt from employees e inner join netpay n on e.DocNum=n.Emp_id";
            var stringvalue = "SELECT * FROM ([employees] AS [e] INNER JOIN [grosspay] AS [g] ON [e].[DocNum] = [g].[emp_id]) INNER JOIN [NETPAY] AS [N] ON [N].[emp_id]=[e].[DocNum] where [e].docNum="+employeeID;
            //var stringvalue = String.Format("SELECT EMPLOYEES.FirstName, EMPLOYEES.Role, EMPLOYEES.gross_amt, EMPLOYEES.Role, NetPay.NetPay_Amt, NetPay.Benefits_Amt, NetPay.Deductions_Amt, GrossPay.GrossPay, GrossPay.PayStartDate, GrossPay.PayEndDateFROM EMPLOYEES, NetPay, GrossPay;");
            var value = Utilities.DataBaseUtility.GetList(stringvalue);
            String[] finalValue = value[1].Split(',');

            if (button1.Text.Equals("Download PaySlip"))
            {
                String path = System.AppDomain.CurrentDomain.BaseDirectory;
                String fileName = "payslip.pdf";
                FileStream fs = new FileStream(System.AppDomain.CurrentDomain.BaseDirectory + fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                doc.Open();
                String spacing = "                                                                                         ";
                String imagepath = Directory.GetCurrentDirectory();

                imagepath = imagepath.Replace("\\bin\\Debug", "\\Images\\HawkLogo.bmp");
                //  + "\\Images\\HawkLogo.bmp";
                iTextSharp.text.Image gif = iTextSharp.text.Image.GetInstance(imagepath);



                doc.Add(new Paragraph("-------------------------------------PAYSLIP - METRO VIDEO PHOTO -------------------------------------              "));
                doc.Add(gif);
                doc.Add(new Paragraph(spacing + "Employee ID : " + finalValue[0]));
                doc.Add(new Paragraph(spacing + "First Name : " + finalValue[2]));
                doc.Add(new Paragraph(spacing + "Last Name : " + finalValue[3]));
                doc.Add(new Paragraph(spacing + "Email ID : " + finalValue[12]));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Pay Period:"));
                doc.Add(new Paragraph("Start Date : " + finalValue[23]));
                doc.Add(new Paragraph("--------------------------------------------"));
                doc.Add(new Paragraph("End Date : " + finalValue[24]));
                doc.Add(new Paragraph("---------------------------"));
                doc.Add(new Paragraph("Total Overtime Pay : " + finalValue[25]));
                doc.Add(new Paragraph("---------------------------------------------"));
                doc.Add(new Paragraph("Gross Pay : " + finalValue[26]));
                doc.Add(new Paragraph("--------------------------------------------"));
                doc.Add(new Paragraph("Benefit Amount : " + finalValue[31]));
                doc.Add(new Paragraph("--------------------------------------------"));
                doc.Add(new Paragraph("Deduction Amount : " + finalValue[32]));
                doc.Add(new Paragraph("--------------------------------------------"));
                doc.Add(new Paragraph("Final Pay (Net Pay) : " + finalValue[36]));



                doc.Close();
                string FileLocation = System.AppDomain.CurrentDomain.BaseDirectory + fileName;
                //string WatermarkLocation = "C:\\Users\\Prithiviraj\\Desktop\\PDF Document\\Myimage.png";
                String WatermarkLocation = Directory.GetCurrentDirectory();

                WatermarkLocation = WatermarkLocation.Replace("\\bin\\Debug", "\\Images\\bgconfidential.png");

                Document document = new Document();
                iTextSharp.text.pdf.PdfReader pdfReader = new iTextSharp.text.pdf.PdfReader(FileLocation);
                iTextSharp.text.pdf.PdfStamper stamp = new iTextSharp.text.pdf.PdfStamper(pdfReader, new FileStream(FileLocation.Replace(".pdf", "_"+finalValue[0]+".pdf"), FileMode.Create));

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(WatermarkLocation);
                img.SetAbsolutePosition(0, 5); // set the position in the document where you want the watermark to appear (0,0 = bottom left corner of the page)

                iTextSharp.text.pdf.PdfContentByte waterMark;
                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    waterMark = stamp.GetUnderContent(page);
                    waterMark.AddImage(img);
                }
                stamp.FormFlattening = true;
                stamp.Close();
                label1.Visible = true;
                label1.Text = "Your file (payslip.pdf) is succssfully downloaded";

            }

            else if (button1.Text.Equals("View Gross Pay"))
            {
                label1.Visible = true;
                label1.Text = "Gross Pay";

                heading1.Visible = true;
                heading2.Visible = true;
                heading3.Visible = true;
                heading4.Visible = true;
                heading5.Visible = true;
                heading6.Visible = true;

                value1.Visible = true;
                value2.Visible = true;
                value3.Visible = true;
                value4.Visible = true;
                value5.Visible = true;
                value6.Visible = true;


                heading1.Text = "Employee ID: ";
                heading2.Text = "Regular Hourly Pay Rate: ";
                heading3.Text = "Overtime Hourly Pay Rate: ";
                heading4.Text = "Num of Regular Hours: ";
                heading5.Text = "Num of overtime Hours: ";
                heading6.Text = "Gross Pay: ";

                int regHours = Convert.ToInt32(finalValue[22]) / Convert.ToInt32(finalValue[20]);
                int overTimeHours = Convert.ToInt32(finalValue[25]) / Convert.ToInt32(finalValue[21]);

                value1.Text = finalValue[0];
                value2.Text = "$"+finalValue[20];
                value3.Text = "$"+finalValue[21];
                value4.Text = regHours.ToString();
                value5.Text = overTimeHours.ToString();
                value6.Text = "$" + finalValue[26];
                
                    
                
            }
            else if (button1.Text.Equals("View Net Pay"))
            {
                label1.Visible = true;
                label1.Text = "Net Pay";

                heading1.Visible = true;
                heading2.Visible = true;
                heading3.Visible = true;
                heading4.Visible = true;
                heading5.Visible = true;
              //  heading6.Visible = true;

                value1.Visible = true;
                value2.Visible = true;
                value3.Visible = true;
                value4.Visible = true;
                value5.Visible = true;
             //   value6.Visible = true;


                heading1.Text = "Employee ID: ";
                heading2.Text = "Gross Pay: ";
                heading3.Text = "Total Benefits: ";
                heading4.Text = "Total Deductions: ";
                heading5.Text = "Net Pay: ";
              //  heading6.Text = "Gross Pay: ";

                value1.Text = finalValue[0];
                value2.Text = "$" + finalValue[26];
                value3.Text = "$" + finalValue[31];
                value4.Text = "$" + finalValue[32];
                value5.Text = "$" + finalValue[36];
               // value6.Text = finalValue[26];


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
