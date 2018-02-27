using stock.busniess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock.forms
{
    public partial class purchaseInvoiceReport : Form
    {
        public purchaseInvoiceReport()
        {
            InitializeComponent();
            lastDayRadio.Checked = true;
            invoiceGV.DataSource = Reports.purchaseReport();
            totalAmountTxtBox.Text = Reports.getTotalAmount(getAmountToList()).ToString();
            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
            lastDayRadio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            lastWeekRadio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            lastMonthRadio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            lastYearRadio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton )
            {
                RadioButton radioButton = (RadioButton)sender;
                //Code to use radioButton's properties to do something useful.
                if (radioButton.Checked == true)
                {
                    switch (radioButton.Name)
                    {
                        case "lastDayRadio":
                            invoiceGV.DataSource = Reports.selectedReport(1);
                            totalAmountTxtBox.Text = Reports.getTotalAmount(getAmountToList()).ToString();
                            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
                            break;
                        case "lastWeekRadio":
                            invoiceGV.DataSource = Reports.selectedReport(6);
                            totalAmountTxtBox.Text = Reports.getTotalAmount(getAmountToList()).ToString();
                            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
                            break;
                        case "lastMonthRadio":
                            invoiceGV.DataSource = Reports.selectedReport(30);
                            totalAmountTxtBox.Text = Reports.getTotalAmount(getAmountToList()).ToString();
                            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
                            break;
                        case "lastYearRadio":
                            invoiceGV.DataSource = Reports.selectedReport(365);
                            totalAmountTxtBox.Text = Reports.getTotalAmount(getAmountToList()).ToString();
                            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
                            break;
                    }
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            invoiceGV.DataSource = Reports.purchaseReport();
            totalAmountTxtBox.Text = Reports.getTotalAmount(getAmountToList()).ToString();
            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
        }

        private void BetweenBtn_Click(object sender, EventArgs e)
        {
            DateTime fromTime = FromDateDTB.Value;
            DateTime ToTime = ToDateDTB.Value;
            invoiceGV.DataSource = Reports.Interval(fromTime, ToTime);
            totalAmountTxtBox.Text = Reports.getTotalAmount(getAmountToList()).ToString();
            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime fromTime = FromDateDTB.Value;
            DateTime ToTime = ToDateDTB.Value;
            string str = suppNameTxt.Text;
            if (IntervalSearchBX.Checked)
            {
                invoiceGV.DataSource = Reports.BySuppNameInterval(str, fromTime, ToTime);
            }
            else
            {
                invoiceGV.DataSource = Reports.PurchaseBySuppName(str);
            }
            totalAmountTxtBox.Text = Reports.getTotalAmount(getAmountToList()).ToString();
            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
        }

        private List<int> getAmountToList()
        {
            List<int> mylist = new List<int>();
            for (int i = 0; i < invoiceGV.Rows.Count; i++)
            {
                mylist.Add(int.Parse(invoiceGV.Rows[i].Cells[6].Value.ToString()));
            }
            return mylist;
        }

        private int getInvoiceCount()
        {
            return invoiceGV.Rows.Count;
        }

        private void FromDateDTB_ValueChanged(object sender, EventArgs e)
        {
            suppNameTxt.Text = "";
            suppNameTxt.Focus();
        }

        private void ToDateDTB_ValueChanged(object sender, EventArgs e)
        {
            suppNameTxt.Text = "";
            suppNameTxt.Focus();
        }

        private void invoiceGV_DoubleClick(object sender, EventArgs e)
        {

            int Id = int.Parse(invoiceGV.SelectedRows[0].Cells[0].Value.ToString());
            PurchaseDetailesForm obj = new PurchaseDetailesForm(Id);
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.ShowDialog();
        }




    }
}
