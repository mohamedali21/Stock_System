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
    public partial class SupplierForm : Form
    {
        Stock_SystemEntities context = new Stock_SystemEntities();
        int indexSelected,supID;
        public SupplierForm()
        {
            InitializeComponent();
            DisplaySuppliers();
            rateNumericUpDown.Value = 5;
            
        }
        
        private void DisplaySuppliers()
        {
            listView1.Items.Clear();
            var suppliers = SupplierQ.DisplayAll();
            foreach (var item in suppliers)
            {
                fillRowOfListView(item.Id, item.Name, item.phone, item.Address, item.Rate);
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
            supID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            indexSelected = listView1.SelectedIndices[0];
            nameTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            phoneTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            addressTextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            if (listView1.SelectedItems[0].SubItems[4].Text == null)
                rateNumericUpDown.Value = Decimal.Round(0, 2);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to update this item ??",
                                    "Confirm Update!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                SupplierQ.Update(supID, nameTextBox.Text, phoneTextBox.Text, addressTextBox.Text, rateNumericUpDown.Value);
                DisplaySuppliers();
            }
        }
        
        private void addbutton_Click(object sender, EventArgs e)
        {
            if (checIsEmpty())
            {
                MessageBox.Show("You must enter all fields!");
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
                    SupplierQ.Add(nameTextBox.Text, phoneTextBox.Text, addressTextBox.Text, rateNumericUpDown.Value);
                    DisplaySuppliers();
                }
            }
                
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to update this item ??",
                                   "Confirm Delete!!",
                                   MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if(SupplierQ.CheckPreDeal(supID))
                {
                    MessageBox.Show("You can't remove this supplier because he has invoices in Purchase Oders");
                }else
                {
                    SupplierQ.Delete(supID);
                    DisplaySuppliers();
                }
            }
        }
        
        

        private void FormHeading_Click(object sender, EventArgs e)
        {
            searchComboBox.SelectedItem="Name";
        }
        private void filter(Func<Supplier, bool> del)
        {
            listView1.Items.Clear();
            var query = SupplierQ.filter(del);
            foreach (var item in query)
            {
                fillRowOfListView(item.Id, item.Name, item.phone, item.Address, item.Rate);
            }

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            
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
                    filter(e1 => e1.phone.Contains(searchTextBox.Text));
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            searchComboBox.SelectedIndex = 0;
        }
        bool checIsEmpty()
        {
            if (nameTextBox.Text == "" || phoneTextBox.Text == ""|| addressTextBox.Text == "")
                return true;
            else
                return false;
        }
    }
}
