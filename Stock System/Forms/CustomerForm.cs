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
//Mohamed Ali
namespace Stock_System
{
    public partial class CustomerForm : Form
    {
        Stock_SystemEntities context = new Stock_SystemEntities();
        int indexSelected,custID;
        public CustomerForm()
        {
            InitializeComponent();
            DisplayCustomers();
            rateNumericUpDown.Value = 5;
        }
        private void DisplayCustomers()
        {
            listView1.Items.Clear();
            var customers = CustomerQ.DisplayAll();

            foreach (var item in customers)
            {
                fillRowOfListView(item.Id,  item.Name, item.Phone, item.Address,item.Rate);
            }
        }
        private void fillRowOfListView(int id, string name, string phone, string address, string rate)
        {
            ListViewItem item1 = new ListViewItem(id.ToString());
            item1.SubItems.Add(name);
            item1.SubItems.Add(phone);
            item1.SubItems.Add(address);
            item1.SubItems.Add(rate);
            listView1.Items.Add(item1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            custID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            indexSelected = listView1.SelectedIndices[0];
            nameTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            phoneTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            addressTextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            if(listView1.SelectedItems[0].SubItems[4].Text==null)
                rateNumericUpDown.Value= Decimal.Round(0, 2);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to update this Customer ??",
                                    "Confirm Update!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                CustomerQ.Update(custID,nameTextBox.Text, phoneTextBox.Text, addressTextBox.Text, rateNumericUpDown.Value);
                DisplayCustomers();
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (checIsEmpty()) {
                MessageBox.Show("You Must Enter All Fields");
            }
            else
            {
                if (checkPhone())
                    MessageBox.Show("phone number must be 12 number!");
                else if (checkInputsLength())
                {
                    MessageBox.Show("All fields must be less than 50 characters!");
                }
                else
                {
                    CustomerQ.Add(nameTextBox.Text, phoneTextBox.Text, addressTextBox.Text, rateNumericUpDown.Value);
                    DisplayCustomers();
                }
                
            }
            
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to update this Customer ??",
                                   "Confirm Delete!!",
                                   MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (SupplierQ.CheckPreDeal(custID))
                {
                    MessageBox.Show("You can't remove this customer because he has invoices in Sales Oders");
                }
                else
                {
                    SupplierQ.Delete(custID);
                    DisplayCustomers();
                }

            }
        }
        bool checIsEmpty()
        {
            if (nameTextBox.Text == "" || phoneTextBox.Text == "" || addressTextBox.Text == "")
                return true;
            else
                return false;
        }
        bool checkPhone()
        {
            if (phoneTextBox.Text.Length > 12 || phoneTextBox.Text.Length < 12)
                return true;
            else
                return false;
        }
        bool checkInputsLength()
        {
            if (nameTextBox.Text.Length > 50 || addressTextBox.Text.Length > 50)
                return true;
            else
                return false;
        }
        private void filter(Func<Customer, bool> del)
        {
            listView1.Items.Clear();
            var query = CustomerQ.filter(del);
            foreach (var item in query)
            {
                fillRowOfListView(item.Id, item.Name, item.Phone, item.Address, item.Rate);
            }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchComboBox.SelectedIndex >= 0)
            {
                if (searchComboBox.SelectedIndex == 0)
                    filter(e1 => e1.Name.Contains(searchTextBox.Text));
                else if (searchComboBox.SelectedIndex == 1)
                    filter(e1 => e1.Address.Contains(searchTextBox.Text));
                else
                    filter(e1 => e1.Phone.Contains(searchTextBox.Text));
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            searchComboBox.SelectedIndex = 0;
        }

       
    }
 
}
