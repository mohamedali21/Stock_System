using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stock;
using Stock_System;
using Stock_System.Bussiness_Layer;

namespace stock.forms
{
    public partial class NewSalesForm : Form
    {
        public NewSalesForm()
        {
            InitializeComponent();
            allProductGridView.DataSource = SalesInvoice.fillProduct();
            //allProductGridView.Columns[5].Visible = false;
            allProductGridView.Columns[6].Visible = false;
            allProductGridView.Columns[7].Visible = false;
            allProductGridView.Columns[8].Visible = false;
            allProductGridView.Columns[9].Visible = false;
            invoiceNumNumericUpDown.Maximum = int.MaxValue;
            

            TypeCombo.SelectedIndex = 0;
            fillCustomer();
            fillStock();
            fillEmployee();
            //InvoiceNumText.Text = SalesInvoice.getSalesId().ToString();
            invoiceNumNumericUpDown.Value = int.Parse(SalesInvoice.getSalesId().ToString());
        }
        //  variables
        int proNnum = 0;
        Task t1, t2;



        //  functions
        List<Product> fillProduct()
        {
            return Program.context.Products.ToList();
        }

        void fillCustomer()
        {
            List<string> itemlist = SalesInvoice.fillCustomer();
            foreach (var item in itemlist)
            {
                CustomerCmb.Items.Add(item);
            }
            CustomerCmb.SelectedIndex = 0;
        }

        void fillStock()
        {
            List<string> itemList = SalesInvoice.fillStock();
            foreach (var item in itemList)
            {
                stockCmb.Items.Add(item);
            }
            stockCmb.SelectedIndex = 0;
        }

        void fillEmployee()
        {
            List<string> itemList = SalesInvoice.fillEmployee();
            foreach (var item in itemList)
            {
                EmployeeCmbBox.Items.Add(item);
            }
            
            EmployeeCmbBox.SelectedIndex = 0;
        }

        private int updateProductNumTxt()
        {
            proNnum++;
            return proNnum;
        }
        private int updateProductNumTxt2()
        {
            proNnum--;
            return proNnum;
        }
        bool isAddedBefore(string name)
        {
           
            bool flag = false;
            string oldname = "";
            for (int i = 0; i < selectedProductGridView.Rows.Count; i++)
            {
                oldname = selectedProductGridView.Rows[i].Cells[0].Value.ToString();
                if (oldname == name)
                    flag = true;

            }
            return flag;
        }

        int getIndex(string name)
        {
            int ind = 0;
            for (int i = 0; i < selectedProductGridView.Rows.Count; i++)
            {
                if (selectedProductGridView.Rows[i].Cells[0].Value.ToString() == name)
                    ind = i;
            }
            return ind;
        }

        void productSelected(DataGridViewRow row)
        {
            int n = selectedProductGridView.Rows.Add();
            selectedProductGridView.Rows[n].Cells[0].Value = row.Cells[1].Value;
            selectedProductGridView.Rows[n].Cells[1].Value = row.Cells[2].Value;
            selectedProductGridView.Rows[n].Cells[2].Value = 1;
            selectedProductGridView.Rows[n].Cells[3].Value = "";
        }

        //bool validateVoiceNum()
        //{
        //    return (InvoiceNumText.Text == "");
        //}

        bool IsEmptyDiscount()
        {
            return (DiscountTxtBox.Text == "");
        }


        bool isEmptyExpDate()
        {
            bool flag = false;
            string cell3 = "";
            int count = selectedProductGridView.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                cell3 = selectedProductGridView.Rows[i].Cells[3].Value.ToString();
                if (selectedProductGridView.Rows[i].Cells[3].Value.ToString() == "")
                    flag = true;
            }
            return flag;
        }

        ///////////////////////////////////////////////////////////


        bool validateVoiceNum2(int invNum)
        {
            return PurchaseInvoice.IsAddedBefor(invNum);
        }


        List<string> getProdList()
        {
            List<string> prodList = new List<string>();
            for (int i = 0; i < selectedProductGridView.Rows.Count; i++)
            {
                prodList.Add(selectedProductGridView.Rows[i].Cells[0].Value.ToString());
            }
            return prodList;
        }

        List<int> getQtyList()
        {
            List<int> qtylist = new List<int>();
            for (int i = 0; i < selectedProductGridView.Rows.Count; i++)
            {
                qtylist.Add(int.Parse(selectedProductGridView.Rows[i].Cells[2].Value.ToString()));
            }
            return qtylist;
        }

        bool validaPaidType(string paidType)
        {
            bool valid = false;
            if (paidType == "Cash")
                valid = true;
            else
            {
                valid = validRemaining();
            }
            return valid;
        }

        bool validRemaining()
        {
            return !(PaidNumericUpDown.Text == PaidNumericUpDown.Minimum.ToString());
        }

        int CalcRemainAmount(float afterDiscountPrice, int paid)
        {
            return ((int)afterDiscountPrice - paid);
        }
        ////////////////////////////////////////////////////////
        int getTotalPrice()
        {
            int price = 0;
            int qty = 0;
            string prodName = "";
            double prodPrice = 0;
            for (int i = 0; i < selectedProductGridView.Rows.Count; i++)
            {
                prodName = selectedProductGridView.Rows[i].Cells[0].Value.ToString();
                prodPrice = getProdPrice(prodName);
                qty = int.Parse(selectedProductGridView.Rows[i].Cells[2].Value.ToString());
                price += (int)prodPrice * qty;
            }
            return price;
        }

        double getProdPrice(string name)
        {
            var query =
                (from p in Program.context.Products
                 where p.Name == name
                 select p.SalePrice).First();
            return query;
        }

        float getAfterDiscountPrice(int price, float discount)
        {
            float afterdiscount = 0;
            afterdiscount = price - (discount * price / 100);
            return afterdiscount;

        }

        //  events

        private void allProductGridView_DoubleClick(object sender, EventArgs e)
        {
            int ind = 0, qty = 0;
            float discount = 0; 
            if (IsEmptyDiscount())
            {
                MessageBox.Show("must Enter A discount");
            }
            else
            {
                List<string> prodNameList = new List<string>();
                List<int> qtyList = new List<int>();
                double totalPrice = 0;
                discount = float.Parse(DiscountTxtBox.Text);
                if (isAddedBefore(allProductGridView.SelectedRows[0].Cells[1].Value.ToString()))
                {
                    ind = getIndex(allProductGridView.SelectedRows[0].Cells[1].Value.ToString());
                    qty = int.Parse(selectedProductGridView.Rows[ind].Cells[2].Value.ToString());
                    selectedProductGridView.Rows[ind].Cells[2].Value = (++qty).ToString();

                    prodNameList = getProdList();
                    qtyList = getQtyList();

                    totalPrice = SalesInvoice.getTotalPrice(prodNameList, qtyList);
                    TotalPriceTxt.Text = totalPrice.ToString();
                    AfterDiscountTxtBox.Text = getAfterDiscountPrice((int)totalPrice, discount).ToString();
                }
                else
                {
                    productSelected(allProductGridView.SelectedRows[0]);
                    prodNameList = getProdList();
                    qtyList = getQtyList();
                    totalPrice = SalesInvoice.getTotalPrice(prodNameList, qtyList);
                    TotalPriceTxt.Text = totalPrice.ToString();
                    AfterDiscountTxtBox.Text = getAfterDiscountPrice((int)totalPrice, discount).ToString();
                     
                }
            }
        }

        

        private void productTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (selectedProductGridView.Rows.Count > 0)
            {
                selectedProductGridView.SelectedRows[0].Cells[3].Value = productTimePicker1.Value.ToString();
            }
        }

        private void selectedProductGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            productCountTxt.Text = updateProductNumTxt().ToString();
        }

      

        private void selectedProductGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int price = getTotalPrice();
            List<string> prodNameList = new List<string>();
            List<int> qtyList = new List<int>();
            prodNameList = getProdList();
            qtyList = getQtyList();

            double totalPrice = SalesInvoice.getTotalPrice(prodNameList, qtyList);
            TotalPriceTxt.Text = totalPrice.ToString();
            float disc = float.Parse(DiscountTxtBox.Text);
            AfterDiscountTxtBox.Text = getAfterDiscountPrice((int)totalPrice, disc).ToString();
        }


        int prodqty = 0;
        private void SetQtyBtn_Click(object sender, EventArgs e)
        {
            string prodName = selectedProductGridView.SelectedRows[0].Cells[0].Value.ToString();
            int qty = SalesInvoice.getProdStockQty(prodName);
            QuantityUpDown.Maximum = qty;
            prodqty = (int)QuantityUpDown.Value;
            selectedProductGridView.SelectedRows[0].Cells[2].Value = prodqty.ToString();
            List<string> prodNameList = new List<string>();
            List<int> qtyList = new List<int>();
            prodNameList = getProdList();
            qtyList = getQtyList();

            double totalPrice = SalesInvoice.getTotalPrice(prodNameList, qtyList);
            TotalPriceTxt.Text = totalPrice.ToString();
            float disc = float.Parse(DiscountTxtBox.Text);
            AfterDiscountTxtBox.Text = getAfterDiscountPrice((int)totalPrice, disc).ToString();
            QuantityUpDown.Value = 1;
            prodqty = 0;
        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCombo.SelectedIndex == 0)
            {
                PaidNumericUpDown.Enabled = false;
                RemainAmountTxtBox.Enabled = false;
            }
            else
            {
                PaidNumericUpDown.Enabled = true;
                RemainAmountTxtBox.Enabled = true;
                //int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
                if (selectedProductGridView.Rows.Count > 0)
                {
                    float afterDiscountPrice = int.Parse(AfterDiscountTxtBox.Text);
                    int paid = (int)(PaidNumericUpDown.Value);
                    RemainAmountTxtBox.Text = CalcRemainAmount(afterDiscountPrice, paid).ToString();
                }
            }
        }

        private void TotalPriceTxt_TextChanged(object sender, EventArgs e)
        {
            if (TypeCombo.SelectedItem.ToString() != "Cash")
            {
                //int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
                float afterDiscountPrice = int.Parse(AfterDiscountTxtBox.Text);
                int paid = (int)(PaidNumericUpDown.Value);
                RemainAmountTxtBox.Text = CalcRemainAmount(afterDiscountPrice, paid).ToString();
            }
        }

        private void PaidAmountBtn_Click(object sender, EventArgs e)
        {
            PaidNumericUpDown.Maximum = int.Parse(AfterDiscountTxtBox.Text.ToString());
            //int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
            float afterDiscountPrice = int.Parse(AfterDiscountTxtBox.Text);
            int paid = (int)(PaidNumericUpDown.Value);
            RemainAmountTxtBox.Text = CalcRemainAmount(afterDiscountPrice, paid).ToString();
        }

        private void PaidNumericUpDown_Leave(object sender, EventArgs e)
        {
            PaidNumericUpDown.Maximum = int.Parse(AfterDiscountTxtBox.Text.ToString());
            //int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
            float afterDiscountPrice = int.Parse(AfterDiscountTxtBox.Text);
            int paid = (int)(PaidNumericUpDown.Value);
            RemainAmountTxtBox.Text = CalcRemainAmount(afterDiscountPrice, paid).ToString();
        }

        private void DiscountTxtBox_Leave(object sender, EventArgs e)
        {
            List<string> prodNameList = new List<string>();
            List<int> qtyList = new List<int>();
            prodNameList = getProdList();
            qtyList = getQtyList();
            float discount = 0;
            if (DiscountTxtBox.Text != "")
            {
                discount = float.Parse(DiscountTxtBox.Text.ToString());
            }
            if (selectedProductGridView.Rows.Count > 0)
            {
                int paid = int.Parse(PaidNumericUpDown.Value.ToString());
                double totalPrice = SalesInvoice.getTotalPrice(prodNameList, qtyList);
                //float afterDiscountPrice = int.Parse(AfterDiscountTxtBox.Text);
                float afterDiscountPrice = float.Parse(getAfterDiscountPrice((int)totalPrice, discount).ToString());
                TotalPriceTxt.Text = totalPrice.ToString();
                //AfterDiscountTxtBox.Text = getAfterDiscountPrice((int)totalPrice, discount).ToString();
                AfterDiscountTxtBox.Text = afterDiscountPrice.ToString();
                RemainAmountTxtBox.Text = CalcRemainAmount(afterDiscountPrice, paid).ToString();
            }
        }

        private void AfterDiscountTxtBox_TextChanged(object sender, EventArgs e)
        {
            PaidNumericUpDown.Maximum = (decimal)Math.Floor(double.Parse(AfterDiscountTxtBox.Text.ToString()));
            int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
            float afterDiscountPrice = float.Parse(AfterDiscountTxtBox.Text);
            int paid = (int)(PaidNumericUpDown.Value);
            RemainAmountTxtBox.Text = CalcRemainAmount(afterDiscountPrice, paid).ToString();
        }

        private void searchByNametxt_TextChanged(object sender, EventArgs e)
        {
            string name = searchByNametxt.Text;
            allProductGridView.DataSource = SalesInvoice.Filter(x => x.Name.Contains(name));
        }

        private void searchByCompanyTxat_TextChanged(object sender, EventArgs e)
        {
            string companyName = searchByCompanyTxat.Text;
            allProductGridView.DataSource = SalesInvoice.Filter(x => x.Company.Contains(companyName));
        }

        private void selectedProductGridView_DoubleClick(object sender, EventArgs e)
        {
            if (selectedProductGridView.Rows.Count > 0)
            {
                //DataGridViewRow dr = selectedProductGridView.SelectedRows[0];
                selectedProductGridView.Rows.Remove(selectedProductGridView.SelectedRows[0]);
                List<string> prodNameList = getProdList();
                List<int> qtyList = getQtyList();
                double totalPrice = SalesInvoice.getTotalPrice(prodNameList, qtyList);
                TotalPriceTxt.Text = totalPrice.ToString();
                float discount = float.Parse(DiscountTxtBox.Text);
                AfterDiscountTxtBox.Text = getAfterDiscountPrice((int)totalPrice, discount).ToString();
                productCountTxt.Text = updateProductNumTxt2().ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool generalstatus = true;
            string paytype = TypeCombo.SelectedItem.ToString();
            if (selectedProductGridView.Rows.Count == 0)
            {
                MessageBox.Show("Can not add an empty invoice");
                generalstatus = false;
            }
            //if (validateVoiceNum())
            //{
            //    MessageBox.Show("Must enter invoice Num !");
            //    InvoiceNumText.Focus();
            //    InvoiceNumText.BackColor = Color.LightGreen;
            //    generalstatus = false;
            //}
            if (validateVoiceNum2(int.Parse(invoiceNumNumericUpDown.Value.ToString()))) //else if(validateVoiceNum2(int.Parse(InvoiceNumText.Text)))
            {
                MessageBox.Show("Invoice number already existed");
                //InvoiceNumText.Focus();
                invoiceNumNumericUpDown.Focus();
                generalstatus = false;
            }
            if (isEmptyExpDate())
            {
                MessageBox.Show("Must enter expiration date for alla products !");
                generalstatus = false;
            }
            if (IsEmptyDiscount())
            {
                MessageBox.Show("Must enter discount.... !");
                generalstatus = false;
            }
            if (!validaPaidType(paytype))
            {
                MessageBox.Show("Must enter Paid Amount");
                generalstatus = false;
            }
            if (generalstatus)
            {
                string PaymentType = TypeCombo.SelectedItem.ToString();
                //int invoiceNum = int.Parse(InvoiceNumText.Text);
                int invoiceNum = int.Parse(invoiceNumNumericUpDown.Value.ToString());
                DateTime salesDate =SalesDatePicker.Value;
                string custName = CustomerCmb.SelectedItem.ToString();
                string stocLocation = stockCmb.SelectedItem.ToString();
                string empName = EmployeeCmbBox.SelectedItem.ToString();
                int price = getTotalPrice();


                List<string> prodNameList = new List<string>();
                List<int> qtyList = new List<int>();
                prodNameList = getProdList();
                qtyList = getQtyList();

                double totalPrice = SalesInvoice.getTotalPrice(prodNameList, qtyList);
                float afterDiscountPrice = float.Parse(AfterDiscountTxtBox.Text);
                int paidAmount = (int)PaidNumericUpDown.Value;
                int RemainAmount = CalcRemainAmount(afterDiscountPrice, paidAmount);


                float discount = float.Parse(DiscountTxtBox.Text);
                float priceAfterDisc = getAfterDiscountPrice((int)totalPrice, discount);
                string proName = "";
                string compName = "";
                int productId = 0;
                int quntity = 0;
                DateTime expirDate;

                int Customer_Id = SalesInvoice.getCust_Id(custName);
                int stock_Id = SalesInvoice.getStockId(stocLocation);
                int emp_Id = SalesInvoice.getEmpId(empName);

                if (TypeCombo.SelectedItem.ToString() == "Cash")
                {
                    t1 = Task.Run(() => SalesInvoice.MakeOrder("Sales", emp_Id, custName, empName, salesDate, PaymentType, proNnum, price, discount, priceAfterDisc, price, 0));
                    t1.Wait();
                }
                else
                {
                    t1 = Task.Run(() => SalesInvoice.MakeOrder("Sales", emp_Id, custName, empName, salesDate, PaymentType, proNnum, price, discount, priceAfterDisc, paidAmount, RemainAmount));
                    t1.Wait();
                }


                int SalesOrderID = SalesInvoice.getSalesId()-1;
                for (int i = 0; i < selectedProductGridView.Rows.Count; i++)
                {
                    proName = selectedProductGridView.Rows[i].Cells[0].Value.ToString();
                    compName = selectedProductGridView.Rows[i].Cells[1].Value.ToString();
                    productId = SalesInvoice.getprodid(proName, compName);
                    quntity = int.Parse(selectedProductGridView.Rows[i].Cells[2].Value.ToString());
                    expirDate = DateTime.Parse(selectedProductGridView.Rows[i].Cells[3].Value.ToString());//MessageBox.Show(i + " ==> "+ proName + " ==> " + compName + " ==> " + productId + " ==> " + quntity + " ==> " + expirDate);
                    try
                    {
                        t2 = Task.Run(() => SalesInvoice.MakeSalesDetails(SalesOrderID, productId, quntity, expirDate, stock_Id));
                        //t2.Wait();
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
                MessageBox.Show("OKKKKKKKKKKKKKKKK");
            }
        }
    }
}
