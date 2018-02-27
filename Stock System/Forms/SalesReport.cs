using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stock.busniess;

namespace stock.forms
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            lastDayRadio.Checked = true;
            invoiceGV.DataSource = Reports.SalesReport();
            totalAmountTxtBox.Text = Reports.getTotalSales(getAmountToList()).ToString();
            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();

            lastDayRadio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            lastWeekRadio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            lastMonthRadio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            lastYearRadio.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                //Code to use radioButton's properties to do something useful.
                if (radioButton.Checked == true)
                {
                    switch (radioButton.Name)
                    {
                        case "lastDayRadio":
                            invoiceGV.DataSource = Reports.selectedSalesReport(1);
                            totalAmountTxtBox.Text = Reports.getTotalSales(getAmountToList()).ToString();
                            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
                            break;
                        case "lastWeekRadio":
                            invoiceGV.DataSource = Reports.selectedSalesReport(6);
                            totalAmountTxtBox.Text = Reports.getTotalSales(getAmountToList()).ToString();
                            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
                            break;
                        case "lastMonthRadio":
                            invoiceGV.DataSource = Reports.selectedSalesReport(30);
                            totalAmountTxtBox.Text = Reports.getTotalSales(getAmountToList()).ToString();
                            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
                            break;
                        case "lastYearRadio":
                            invoiceGV.DataSource = Reports.selectedSalesReport(365);
                            totalAmountTxtBox.Text = Reports.getTotalSales(getAmountToList()).ToString();
                            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
                            break;
                    }
                }
            }
        }


        private List<float> getAmountToList()
        {
            List<float> mylist = new List<float>();
            for (int i = 0; i < invoiceGV.Rows.Count; i++)
            {
                mylist.Add(float.Parse(invoiceGV.Rows[i].Cells[6].Value.ToString()));
            }
            return mylist;
        }

        private int getInvoiceCount()
        {
            return invoiceGV.Rows.Count;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            invoiceGV.DataSource = Reports.SalesReport();
            totalAmountTxtBox.Text = Reports.getTotalSales(getAmountToList()).ToString();
            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
        }

        private void BetweenBtn_Click(object sender, EventArgs e)
        {
            DateTime fromTime = FromDateDTB.Value;
            DateTime ToTime = ToDateDTB.Value;
            invoiceGV.DataSource = Reports.Interval(fromTime, ToTime);
            totalAmountTxtBox.Text = Reports.getTotalSales(getAmountToList()).ToString();
            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
        }

        private void suppNameTxt_TextChanged(object sender, EventArgs e)
        {
            DateTime fromTime = FromDateDTB.Value;
            DateTime ToTime = ToDateDTB.Value;
            string str = suppNameTxt.Text;
            if (IntervalSearchBX.Checked)
            {
                invoiceGV.DataSource = Reports.ByCustNameInterval(str, fromTime, ToTime);
            }
            else
            {
                invoiceGV.DataSource = Reports.SalesByCustName(str);
            }
            totalAmountTxtBox.Text = Reports.getTotalSales(getAmountToList()).ToString();
            InvoiceCountTxtBox.Text = getInvoiceCount().ToString();
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
        /// <summary>
        /// ////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invoiceGV_DoubleClick(object sender, EventArgs e)
        {
            int Id = int.Parse(invoiceGV.SelectedRows[0].Cells[0].Value.ToString());
            SalesDetailesForm obj = new SalesDetailesForm(Id);
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.ShowDialog();
        }

        
    }
}
