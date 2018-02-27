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
    public partial class NewPurchaseForm2 : Form
    {
        public NewPurchaseForm2()
        {
            InitializeComponent();
            //allProductGridView.DataSource = PurchaseInvoice.fillProduct();
            //TypeCombo.SelectedIndex = 0;
            //fillSuppCmb();
            //fillStockCmb();
            invoiceNumNumericUpDown.Maximum = int.MaxValue;
        }
        int proNnum = 0;
        private void fillSuppCmb()
        {
            List<string> itemlist = PurchaseInvoice.fillSupplier();
            foreach (var item in itemlist)
            {
                supplierCmb.Items.Add(item);
            }
            supplierCmb.SelectedIndex = 0;
        }

        private void fillEmps()
        {
            List<string> empNames = PurchaseInvoice.fillEmps();
            foreach (var item in empNames)
            {
                employeeComboBox.Items.Add(item);
            }
            employeeComboBox.SelectedIndex = 0;
        }

        private void fillStockCmb()
        {
            List<string> itemList = PurchaseInvoice.fillStock();
            foreach (var item in itemList)
            {
                stockCmb.Items.Add(item);
            }
            stockCmb.SelectedIndex = 0;
        }

        void productSelected(DataGridViewRow row)
        {
            int n = selectedProductGridView.Rows.Add();
            selectedProductGridView.Rows[n].Cells[0].Value = row.Cells[1].Value;
            selectedProductGridView.Rows[n].Cells[1].Value = row.Cells[2].Value;
            selectedProductGridView.Rows[n].Cells[2].Value = 1;
            selectedProductGridView.Rows[n].Cells[3].Value = "";
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

        //bool validateVoiceNum()
        //{

        //    //return (InvoiceNumText.Text == "");
        //    return (invoiceNumNumericUpDown.Value >= 0);
        //}


        /// <summary>
        /// /////////////////
        /// </summary>
        /// <returns></returns>



        bool validateVoiceNum2(int invNum)
        {
            return PurchaseInvoice.IsAddedBefor(invNum);
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
            return !(PaidAmountUpDownNumeric.Text == PaidAmountUpDownNumeric.Minimum.ToString()) ;
        }

        int CalcRemainAmount(double totalPrice, int paid)
        {
            return ((int)totalPrice - paid);
        }

        /// <summary>
        /// ////////////////////
        /// </summary>
        /// <returns></returns>














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

        private void allProductGridView_DoubleClick(object sender, EventArgs e)
        {
            int ind = 0, qty = 0;
            List<string> prodNameList = new List<string>();
            List<int> qtyList = new List<int>();
            if (isAddedBefore(allProductGridView.SelectedRows[0].Cells[1].Value.ToString()))
            {
                ind = getIndex(allProductGridView.SelectedRows[0].Cells[1].Value.ToString());
                qty = int.Parse(selectedProductGridView.Rows[ind].Cells[2].Value.ToString());
                selectedProductGridView.Rows[ind].Cells[2].Value = (++qty).ToString();
                prodNameList = getProdList();
                qtyList = getQtyList();
                TotalPriceTxt.Text = PurchaseInvoice.getTotalPrice(prodNameList, qtyList).ToString();
            }
            else
            {
                productSelected(allProductGridView.SelectedRows[0]);
                prodNameList = getProdList();
                qtyList = getQtyList();
                TotalPriceTxt.Text = PurchaseInvoice.getTotalPrice(prodNameList, qtyList).ToString();
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
            List<string> prodNameList = new List<string>();
            List<int> qtyList = new List<int>();
            prodNameList = getProdList();
            qtyList = getQtyList();
            TotalPriceTxt.Text = PurchaseInvoice.getTotalPrice(prodNameList, qtyList).ToString();
            
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
            //    //InvoiceNumText.Focus();
            //    //InvoiceNumText.BackColor = Color.LightGreen;

            //    invoiceNumNumericUpDown.Focus();
            //    generalstatus = false;
            /*}else*/ if (validateVoiceNum2(int.Parse(invoiceNumNumericUpDown.Value.ToString()))) //else if(validateVoiceNum2(int.Parse(InvoiceNumText.Text)))
            {
                MessageBox.Show("Invoice number already existed");
                //InvoiceNumText.Focus();
                invoiceNumNumericUpDown.Focus();
                generalstatus = false;
            }
            ////////////////////////////////////////////////////////////////
            if (isEmptyExpDate())
            {
                MessageBox.Show("Must enter expiration date for alla products !");
                generalstatus = false;
            }
            if(!validaPaidType(paytype))
            {
                MessageBox.Show("Must enter Paid Amount");
                generalstatus = false;
            }
            if (generalstatus)
            {
                string orderType = TypeCombo.SelectedItem.ToString();
                //int invoiceNum = int.Parse(InvoiceNumText.Text);
                int invoiceNum = int.Parse(invoiceNumNumericUpDown.Value.ToString());
                DateTime recive = RecieveDatePicker.Value;
                DateTime issud = IssuedDatePicker.Value;
                string suppName = supplierCmb.SelectedItem.ToString();
                string stocLocation = stockCmb.SelectedItem.ToString();

                List<string> prodNameList = new List<string>();
                List<int> qtyList = new List<int>();
                prodNameList = getProdList();
                qtyList = getQtyList();
                Task t1, t2;
                double price = PurchaseInvoice.getTotalPrice(prodNameList, qtyList);

                int paidAmount = (int)PaidAmountUpDownNumeric.Value;
                int RemainAmount = CalcRemainAmount(price, paidAmount);


                string proName = "";
                string compName = "";
                int productId = 0;
                int quntity = 0;
                DateTime expirDate;
                int supplier_Id = PurchaseInvoice.getSuppId(suppName);
                int stock_Id = PurchaseInvoice.getStockId(stocLocation);
                string EmpName = employeeComboBox.SelectedItem.ToString();





                if(TypeCombo.SelectedItem.ToString() == "Cash")
                {
                    t1 = Task.Run(() => PurchaseInvoice.MakeOrder("Purchase", EmpName, supplier_Id, invoiceNum, recive, issud, orderType, proNnum, (int)price, (int)price, 0));
                    t1.Wait();
                }
                else
                {
                    t1 = Task.Run(() => PurchaseInvoice.MakeOrder("Purchase", EmpName, supplier_Id, invoiceNum, recive, issud, orderType, proNnum, (int)price, paidAmount, RemainAmount));
                    t1.Wait();
                }




                
                int purchaseOrderId = PurchaseInvoice.getPurchaseId(invoiceNum);
                for (int i = 0; i < selectedProductGridView.Rows.Count; i++)
                {
                    proName = selectedProductGridView.Rows[i].Cells[0].Value.ToString();
                    compName = selectedProductGridView.Rows[i].Cells[1].Value.ToString();
                    productId = PurchaseInvoice.getprodid(proName, compName);
                    quntity = int.Parse(selectedProductGridView.Rows[i].Cells[2].Value.ToString());
                    expirDate = DateTime.Parse(selectedProductGridView.Rows[i].Cells[3].Value.ToString());
                    try
                    {
                        t2 = Task.Run(() => PurchaseInvoice.MakeOrderDetails(purchaseOrderId, productId, quntity, expirDate, stock_Id));
                        t2.Wait();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                MessageBox.Show("Invoice Added Ok");
            }
        }

        private void NewPurchaseForm2_Load(object sender, EventArgs e)
        {
            allProductGridView.DataSource = PurchaseInvoice.fillProduct();
            //allProductGridView.Columns[5].Visible = false;
            allProductGridView.Columns[6].Visible = false;
            allProductGridView.Columns[7].Visible = false;
            allProductGridView.Columns[8].Visible = false;
            allProductGridView.Columns[9].Visible = false;

            TypeCombo.SelectedIndex = 0;
            fillSuppCmb();
            fillStockCmb();
            fillEmps();
        }
        int prodqty = 0;
        private void SetQtyBtn_Click(object sender, EventArgs e)
        {
            //string prodName = selectedProductGridView.SelectedRows[0].Cells[0].Value.ToString();
            //int qty = PurchaseInvoice.getProdStockQty(prodName);
            if (selectedProductGridView.Rows.Count > 0)
            {
                QuantityUpDown.Minimum = 1;

                prodqty = (int)QuantityUpDown.Value;
                selectedProductGridView.SelectedRows[0].Cells[2].Value = prodqty.ToString();
                List<string> prodNameList = new List<string>();
                List<int> qtyList = new List<int>();
                prodNameList = getProdList();
                qtyList = getQtyList();

                double totalPrice = PurchaseInvoice.getTotalPrice(prodNameList, qtyList);
                TotalPriceTxt.Text = totalPrice.ToString();
                QuantityUpDown.Value = 1;
                prodqty = 0;
            }
        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCombo.SelectedIndex == 0)
            {
                PaidAmountUpDownNumeric.Enabled = false;
                RemainAmountTxtBox.Enabled = false;
            }
            else
            {
                PaidAmountUpDownNumeric.Enabled = true;
                RemainAmountTxtBox.Enabled = true;
                int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
                int paid = (int)(PaidAmountUpDownNumeric.Value);
                RemainAmountTxtBox.Text = CalcRemainAmount(totalPrice, paid).ToString();
            }
        }

        //private void PaidAmountUpDownNumeric_ValueChanged(object sender, EventArgs e)
        //{
        //    int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
        //    int paid = (int)(PaidAmountUpDownNumeric.Value);
        //    RemainAmountTxtBox.Text = CalcRemainAmount(totalPrice, paid).ToString();
        //}

        private void TotalPriceTxt_TextChanged(object sender, EventArgs e)
        {
            if (TypeCombo.SelectedItem.ToString() != "Cash")
            {
                int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
                int paid = (int)(PaidAmountUpDownNumeric.Value);
                RemainAmountTxtBox.Text = CalcRemainAmount(totalPrice, paid).ToString();
            }
        }

        private void PaidAmountBtn_Click(object sender, EventArgs e)
        {
            PaidAmountUpDownNumeric.Maximum = int.Parse(TotalPriceTxt.Text.ToString());
            int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
            int paid = (int)(PaidAmountUpDownNumeric.Value);
            RemainAmountTxtBox.Text = CalcRemainAmount(totalPrice, paid).ToString();
        }

        private void PaidAmountUpDownNumeric_Leave(object sender, EventArgs e)
        {
            PaidAmountUpDownNumeric.Maximum = int.Parse(TotalPriceTxt.Text.ToString());
            int totalPrice = int.Parse(TotalPriceTxt.Text.ToString());
            int paid = (int)(PaidAmountUpDownNumeric.Value);
            RemainAmountTxtBox.Text = CalcRemainAmount(totalPrice, paid).ToString();
        }

        private void searchByNametxt_TextChanged(object sender, EventArgs e)
        {
            string n = searchByNametxt.Text;
            allProductGridView.DataSource= PurchaseInvoice.Filter(x => x.Name.Contains(n));
        }

        private void searchByCompanyTxat_TextChanged(object sender, EventArgs e)
        {
            string companyName = searchByCompanyTxat.Text;
            allProductGridView.DataSource =  PurchaseInvoice.Filter(p => p.Company.Contains(companyName));
        }

        private void selectedProductGridView_DoubleClick(object sender, EventArgs e)
        {
            if (selectedProductGridView.Rows.Count > 0)
            {
                selectedProductGridView.Rows.Remove(selectedProductGridView.SelectedRows[0]);
                List<string> prodNameList = getProdList();
                List<int> qtyList = getQtyList();
                double totalPrice = PurchaseInvoice.getTotalPrice(prodNameList, qtyList);
                TotalPriceTxt.Text = totalPrice.ToString();
                productCountTxt.Text = updateProductNumTxt2().ToString();
            }
        }
    }
}
