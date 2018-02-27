using Stock_System.Bussiness_Layer;
using System;
using System.Windows.Forms;
namespace Stock_System
{
    public partial class ReturnedSalesDetailsForm : Form
    {
        public event EventHandler returenedChanged;
        int index, selectedIndex, selectedIndexOfReturnedList, invoiceID, returnedOrderID, returnedProdID=-1, prodID=-1;
        public ReturnedSalesDetailsForm(int invoiceID)
        {
            this.invoiceID = invoiceID;
            InitializeComponent();
        }

        private void invoiceItemsDdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            invoiceItemsDdataGridView.ClearSelection();
        }

        private void returnedItemsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            returnedItemsDataGridView.ClearSelection();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (returnedItemsDataGridView.Rows.Count > 0)
            {
                selectedIndexOfReturnedList = returnedItemsDataGridView.CurrentRow.Index;
                returnedProdID = int.Parse(returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[0].Value.ToString());
                prodNameTextBox.Text = returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[1].Value.ToString();
                quantityNumericUpDown.Maximum = decimal.Parse(invoiceItemsDdataGridView.Rows[selectedIndexOfReturnedList].Cells[2].Value.ToString());
                quantityNumericUpDown.Value = decimal.Parse(returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[2].Value.ToString());
                descTextBox.Text = returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[4].Value.ToString();
            }
        }
        void DisplayReturendItems()
        {
            returnedItemsDataGridView.DataSource = null;
            returnedItemsDataGridView.DataSource = ReturnedSalesQ.DisplayAllRetrunedItems(invoiceID);
            totalAmountTextBox.Text = getTotalAmount().ToString();
        }

        private void ReturnedSalesDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReturnedSalesQ.IsEmpty(invoiceID))
            {
                ReturnedSalesQ.Delete(invoiceID);
            }
            else
            {
                ReturnedSalesQ.UpdateReturnedChequeDate(invoiceID, dateTimePicker1.Value.Date);
            }
            if (returenedChanged != null)
                returenedChanged(this, e);

        }

        private void ReturnedSalesForm_Load(object sender, EventArgs e)
        {
            ReturnedSalesQ.AddReurnedInvoice(invoiceID);
            returnedOrderID = ReturnedSalesQ.lastReturnedOrder().Id;
            Sales_Order SO = ReturnedSalesQ.SOrder(invoiceID);
            invoiceDateTextBox.Text = SO.Date.Date.ToString();
            invoiceNoTextBox.Text = SO.Id.ToString();
            invoiceItemsDdataGridView.DataSource = ReturnedSalesQ.DisplayInvoice(invoiceID);
            DisplayReturendItems();
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
                        ReturnedSalesQ.DeleteReturnedItem(returnedProdID, invoiceID, int.Parse(returnedItemsDataGridView.Rows[selectedIndexOfReturnedList].Cells[2].Value.ToString()));
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
                    ReturnedSalesQ.UpdateItem(returnedProdID, invoiceID, (int)quantityNumericUpDown.Value, descTextBox.Text);
                    DisplayReturendItems();
                }
            }
            else
            {
                MessageBox.Show("Must select item from returned List");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            index = int.Parse(invoiceItemsDdataGridView.CurrentRow.Index.ToString());
            selectedIndex = invoiceItemsDdataGridView.CurrentRow.Index;
            prodID = int.Parse(invoiceItemsDdataGridView.Rows[selectedIndex].Cells[0].Value.ToString());
            prodNameTextBox.Text = invoiceItemsDdataGridView.Rows[selectedIndex].Cells[1].Value.ToString();
            quantityNumericUpDown.Maximum=decimal.Parse(invoiceItemsDdataGridView.Rows[selectedIndex].Cells[2].Value.ToString());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(invoiceItemsDdataGridView.SelectedRows.Count>0)
            {
                if (prodID != -1)
                    if (!ReturnedSalesQ.ReturnedItemCheck(prodID, invoiceID))
                    {
                        ReturnedSalesQ.AddReturnedItem(prodID, invoiceID, (int)quantityNumericUpDown.Value, double.Parse(invoiceItemsDdataGridView.Rows[selectedIndex].Cells[3].Value.ToString()) * (int)quantityNumericUpDown.Value, descTextBox.Text);
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
