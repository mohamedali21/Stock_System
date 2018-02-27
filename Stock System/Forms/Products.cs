
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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        bool isEmpty()
        {
            if (nametext.Text == "" || salespricetext.Text == "" || quantitytxt.Text == "" || companytext.Text == "" || descriptiontxt.Text == "")
                return true;
            else
            return false;
        }










        Stock_SystemEntities st = new Stock_SystemEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productBusiness.fillProduct();
        }

        


        private void Add_Click(object sender, EventArgs e)
        {
            if (!isEmpty())
            {
                string naMe = nametext.Text;
                string com = companytext.Text;
                string descri = descriptiontxt.Text;
                float price = float.Parse(salespricetext.Text);
                int quan = int.Parse(quantitytxt.Text);
                //Product p = new Product { Name = naMe, Company = com, Discription = descri, SalePrice = price, Quantity = quan };
                productBusiness.AddProduct(naMe, com, descri, price, quan);
                //st.Products.Add(p);
                //st.SaveChanges();
                MessageBox.Show("done");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productBusiness.fillProduct();
            }
            else
            {
                MessageBox.Show("Enter Product data First ");
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //   MessageBox.Show(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (!isEmpty())
            {
                int prodId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                string name = nametext.Text;
                string companeName = companytext.Text;
                string description = descriptiontxt.Text;
                float salesPrice = float.Parse(salespricetext.Text);
                int quantity = int.Parse(quantitytxt.Text);

                productBusiness.updateProduct(prodId, name, companeName, description, salesPrice, quantity);
                MessageBox.Show("done");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productBusiness.fillProduct();
            }
            else
            {
                MessageBox.Show("Enter Product data First ");
            }
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int n = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var prod = Program.context.Products.Where(p1 => p1.Id == n).First();
            nametext.Text = prod.Name;
            companytext.Text = prod.Company;
            descriptiontxt.Text = prod.Discription;
            salespricetext.Text = prod.SalePrice.ToString();
            quantitytxt.Text = prod.Quantity.ToString();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string str = searchtxt.Text;
            dataGridView1.DataSource = productBusiness.SearchByName(str);
        }
    }
}

