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
    public partial class StocksForm : Form
    {
        int stockID;
        public StocksForm()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            stockDataGridView.DataSource = StockQ.DisplayStocks();
        }

        //check if any TextBox is Empty
        bool checIsEmpty()
        {
            if (locationTextBox.Text == "" || phoneTextBox.Text == "")
                return true;
            else
                return false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (checIsEmpty())
                MessageBox.Show("You Must Enter All Fields");
            else
            {
                StockQ.Add(locationTextBox.Text, phoneTextBox.Text);
                stockDataGridView.DataSource = null;
                stockDataGridView.DataSource = StockQ.DisplayStocks();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(stockDataGridView.SelectedRows.Count>0)
            {
                StockQ.Update(stockID,locationTextBox.Text,phoneTextBox.Text);
                stockDataGridView.DataSource = null;
                stockDataGridView.DataSource = StockQ.DisplayStocks();
            }
            else
            {
                MessageBox.Show("Please select any row!");
            }
        }

        private void stockDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            stockDataGridView.ClearSelection();
        }

        private void stockDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (stockDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = stockDataGridView.CurrentRow.Index;
                stockID = int.Parse(stockDataGridView.Rows[selectedIndex].Cells[0].Value.ToString());
                locationTextBox.Text = stockDataGridView.Rows[selectedIndex].Cells[1].Value.ToString();
                phoneTextBox.Text = stockDataGridView.Rows[selectedIndex].Cells[2].Value.ToString();
            }
        }
    }
}
