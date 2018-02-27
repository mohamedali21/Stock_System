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
using Stock_System;

namespace stock.forms
{
    public partial class PurchaseDetailesForm : Form
    {
        public PurchaseDetailesForm(int Id)
        {
            InitializeComponent();
            fillGV(Id);
        }

        private void fillGV(int Id)
        {
            List<Object> detailsList = PurchaseInvoice.getInvoiceDetails(Id);
            DetailsGV.DataSource = detailsList;
            DetailsGV.Columns[0].Visible = false;
            DetailsGV.Columns[3].Visible = false;
            DetailsGV.Columns[6].Visible = false;
            DetailsGV.Columns[7].Visible = false;
            //DetailsGV.Columns[8].Visible = false;


            //string SupplierName = DetailsGV.Rows[0].Cells[3].Value.ToString();
            string prodId = DetailsGV.Rows[0].Cells[0].Value.ToString();

            PurchaseOrderIdTxt.Text = prodId;
            //SupplierNameTxt.Text = SupplierName;
            ProductNumberTxt.Text = getProdNum().ToString();
            QuantityTxt.Text = DetailsGV.Rows[0].Cells[5].Value.ToString();
            PaidTxtBox.Text = DetailsGV.Rows[0].Cells[6].Value.ToString();
            RemainTxtBox.Text = DetailsGV.Rows[0].Cells[7].Value.ToString();
        }

        private int getProdNum()
        {
            int qty = 0;
            for (int i = 0; i < DetailsGV.Rows.Count; i++)
            {
                qty += int.Parse(DetailsGV.Rows[i].Cells[2].Value.ToString());
            }
            return qty;
        }

        private int getPrice()
        {
            int price = 0;
            for (int i = 0; i < DetailsGV.Rows.Count; i++)
            {
                price += int.Parse(DetailsGV.Rows[i].Cells[4].Value.ToString());
            }
            return price;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ReturnedPurshaseDetailsForm frm = new ReturnedPurshaseDetailsForm(int.Parse(PurchaseOrderIdTxt.Text));
            frm.ShowDialog();
        }
    }
}
