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
    public partial class ReturnedOdersForm : Form
    {
        bool RSalesForm=true;
        public ReturnedOdersForm()
        {
            InitializeComponent();

        }

        private void ReturnedSalesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReturnedSalesQ.DisplayAllReturnedOrders();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int selectedIndexOfReturned = dataGridView1.CurrentRow.Index;
                int id = int.Parse(dataGridView1.Rows[selectedIndexOfReturned].Cells[1].Value.ToString());
                if(RSalesForm)
                {
                    ReturnedSalesDetailsForm frm2 = new ReturnedSalesDetailsForm(id);
                    frm2.returenedChanged += returnedSalesRadioButton_CheckedChanged;
                    frm2.StartPosition = FormStartPosition.CenterScreen;
                    frm2.ShowDialog();
                }
                else
                {
                    ReturnedPurshaseDetailsForm frm2 = new ReturnedPurshaseDetailsForm(id);
                    frm2.returnedChanged += returnedSalesRadioButton_CheckedChanged;
                    frm2.StartPosition = FormStartPosition.CenterScreen;
                    frm2.ShowDialog();
                }
            }
        }

        private void returnedSalesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (returnedSalesRadioButton.Checked == true)
            {
                RSalesForm = true;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ReturnedSalesQ.DisplayAllReturnedOrders();
            }
            else
            {
                RSalesForm = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ReturnedPurchaseQ.DisplayAllReturnedOrders();
            }
        }
    }
}
