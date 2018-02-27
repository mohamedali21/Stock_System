using Stock_System;
using Stock_System.Bussiness_Layer;
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
    public partial class SalesDetailesForm : Form
    {
        public SalesDetailesForm(int Id)
        {
            InitializeComponent();
            fillGV(Id);
        }

        private void fillGV(int Id)
        {
            List<Object> detailsList = SalesInvoice.getInvoiceDetails(Id);
            DetailsGV.DataSource = detailsList;
            DetailsGV.Columns[0].Visible = false;
            DetailsGV.Columns[6].Visible = false;
            DetailsGV.Columns[7].Visible = false;
            DetailsGV.Columns[8].Visible = false;

            string CustomerName = DetailsGV.Rows[0].Cells[5].Value.ToString();
            string prodId = DetailsGV.Rows[0].Cells[0].Value.ToString();
            string AmountAfterDiscount = DetailsGV.Rows[0].Cells[8].Value.ToString();
            string Discount = DetailsGV.Rows[0].Cells[7].Value.ToString();



            PurchaseOrderIdTxt.Text = prodId;
            CustomerNameTxt.Text = CustomerName;
            TotalPriceTxtBox.Text = getPrice().ToString();
            ProductNumberTxt.Text = getProdNum().ToString();
            AfterDiscountTxtBox.Text = AmountAfterDiscount;
            DiscountTxtBox.Text = Discount;
            
        }

        private int getPrice()
        {
            int price = 0;
            for (int i = 0; i < DetailsGV.Rows.Count; i++)
            {
                price += int.Parse(DetailsGV.Rows[i].Cells[3].Value.ToString())* int.Parse(DetailsGV.Rows[i].Cells[2].Value.ToString());
            }
            return price;
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

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ReturnedSalesDetailsForm frm = new ReturnedSalesDetailsForm(int.Parse(PurchaseOrderIdTxt.Text));
            frm.ShowDialog();
        }
    }
}
