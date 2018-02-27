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

namespace Stock_System
{
    public partial class ReturnedPurshaseDetailsForm : Form
    {
        public event EventHandler returnedChanged;
        int selectedIndex,returnedOrderID, invoiceID, selectedIndexOfReturnedList, returnedProdID = -1, prodID = -1;
        public ReturnedPurshaseDetailsForm(int invoiceID)
        {
            this.invoiceID = invoiceID;
            InitializeComponent();
        }
        void DisplayReturendItems()
        {
            returnedItemsDataGridView.DataSource = null;
            returnedItemsDataGridView.DataSource = ReturnedPurchaseQ.DisplayAllRetrunedItems(invoiceID);
            totalAmountTextBox.Text = getTotalAmount().ToString();
        }
        private void ReturnedSalesForm_Load(object sender, EventArgs e)
        {
            ReturnedPurchaseQ.AddReurnedInvoice(invoiceID);
            Purchase_Order PO = ReturnedPurchaseQ.POrder(invoiceID);
            issueDateTextBox.Text = PO.IssuedDate.Date.ToString();
            receiveDateTextBox.Text = PO.RecivedDate.Date.ToString();
            invoiceNoTextBox.Text = PO.InvoiceNo.ToString();
            returnedOrderID = ReturnedPurchaseQ.lastReturnedOrder().Id;
            invoiceItemsDdataGridView.DataSource = ReturnedPurchaseQ.DisplayInvoice(invoiceID);
            DisplayReturendItems();
        }

        private void invoiceItemsDdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            invoiceItemsDdataGridView.ClearSelection();
        }

        private void returnedItemsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            returnedItemsDataGridView.ClearSelection();
        }

        private void invoiceItemsDdataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            selectedIndex = invoiceItemsDdataGridView.CurrentRow.Index;
            prodID = int.Parse(invoiceItemsDdataGridView.Rows[selectedIndex].Cells[0].Value.ToString());
            prodNameTextBox.Text = invoiceItemsDdataGridView.Rows[selectedIndex].Cells[1].Value.ToString();
            quantityNumericUpDown.Maximum = decimal.Parse(invoiceItemsDdataGridView.Rows[selectedIndex].Cells[2].Value.ToString());

        }
       
        private void ReturnedPurshaseDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReturnedPurchaseQ.IsEmpty(invoiceID))
            {
                ReturnedPurchaseQ.Delete(invoiceID);
            }
            else
            {
                ReturnedPurchaseQ.UpdateReturnedChequeDate(invoiceID, dateTimePicker1.Value.Date);
            }
            if (returnedChanged!=null)
            returnedChanged(this, e);
        }

        private void returnedItemsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            selectedIndexOfReturnedList = returnedItemsDataGridView.CurrentRow.Index;
            returnedProdID = int.Parse(returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[0].Value.ToString());
            prodNameTextBox.Text = returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[1].Value.ToString();
            quantityNumericUpDown.Maximum = decimal.Parse(invoiceItemsDdataGridView.Rows[selectedIndexOfReturnedList].Cells[2].Value.ToString());
            quantityNumericUpDown.Value = decimal.Parse(returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[2].Value.ToString());
            descTextBox.Text = returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[4].Value.ToString();

        }

        

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (returnedItemsDataGridView.SelectedRows.Count > 0)
            {
                if (returnedProdID != -1)
                {
                    var confirmResult = MessageBox.Show("Are you sure to Reomve this item ??",
                                       "Confirm Remove!!",
                                       MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        ReturnedPurchaseQ.DeleteReturnedItem(returnedProdID, invoiceID, int.Parse(returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[2].Value.ToString()));
                        DisplayReturendItems();
                    }
                }
            }
            else
            {
                MessageBox.Show("Must select item you want to remove from returned List");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (returnedItemsDataGridView.SelectedRows.Count > 0)
            {
                if (returnedProdID != -1 && returnedItemsDataGridView.Rows.Count > 0)
                {
                    ReturnedPurchaseQ.UpdateItem(returnedProdID, invoiceID, (int)quantityNumericUpDown.Value, descTextBox.Text);
                    DisplayReturendItems();
                }
            }
            else
            {
                MessageBox.Show("Must select item from returned List");
            }
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            if (invoiceItemsDdataGridView.SelectedRows.Count > 0)
            {
                if (prodID != -1)
                    if (!ReturnedPurchaseQ.ReturnedItemCheck(prodID, invoiceID))
                    {
                        ReturnedPurchaseQ.AddReturnedItem(prodID, invoiceID, (int)quantityNumericUpDown.Value, double.Parse(invoiceItemsDdataGridView.Rows[selectedIndex].Cells[3].Value.ToString()) * (int)quantityNumericUpDown.Value, descTextBox.Text);
                        DisplayReturendItems();
                    }
                    else
                    {
                        MessageBox.Show("Item is already added you can update it!");
                    }
            }
            else
            {
                MessageBox.Show("Must select Item from invoice list");
            }
        }
            private double getTotalAmount()
            {
                double totalAmount = 0;
                for (int i = 0; i < returnedItemsDataGridView.Rows.Count; i++)
                {
                    totalAmount += double.Parse(returnedItemsDataGridView.Rows[i].Cells[3].Value.ToString());
                }
                return totalAmount;
            }
    
    }
}
