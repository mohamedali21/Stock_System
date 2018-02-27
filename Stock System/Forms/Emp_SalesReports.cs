using Stock_System.busniess;
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

namespace Stock_System.Forms
{
    public partial class Emp_SalesReports : Form
    {
        public Emp_SalesReports()
        {
            InitializeComponent();
        }
        void Display(List<Emp_Sales_Reports> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=list;
        }
        private void Emp_SalesReports_Load(object sender, EventArgs e)
        {
            //weekRadioButton.Checked = true;
            empsComboBox.DisplayMember = "Name";
            empsComboBox.ValueMember = "N_Id";
            empsComboBox.DataSource = EmpSalesReportQ.Emps();
            Display(EmpSalesReportQ.Display(empsComboBox.SelectedValue.ToString(), DateTime.Now.Date.AddDays(-7), DateTime.Now.Date).ToList());
        }

        private void intervalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (intervalCheckBox.Checked)
                intervalPanel.Visible = true;
            else
                intervalPanel.Visible = false;
        }

        private void empsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empsComboBox.SelectedIndex > -1)
            {
                if (intervalCheckBox.Checked)
                {
                    
                }
                else
                {
                    nIdlabel.Text = "National Id: " + empsComboBox.SelectedValue.ToString();
                    Display(EmpSalesReportQ.Display(empsComboBox.SelectedValue.ToString(), DateTime.Now.Date.AddDays(-7), DateTime.Now.Date).ToList());
                }
            }
        }

        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (weekRadioButton.Checked)
            {
                Display(EmpSalesReportQ.Display(empsComboBox.SelectedValue.ToString(), DateTime.Now.Date.AddDays(-7), DateTime.Now.Date).ToList());
            }
        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthRadioButton.Checked)
            {
                Display(EmpSalesReportQ.Display(empsComboBox.SelectedValue.ToString(), DateTime.Now.Date.AddMonths(-1), DateTime.Now.Date).ToList());
            }
        }

        private void yearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yearRadioButton.Checked)
            {
                Display(EmpSalesReportQ.Display(empsComboBox.SelectedValue.ToString(), DateTime.Now.Date.AddYears(-1), DateTime.Now.Date).ToList());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var fromDate = fromDateTimePicker.Value.Date;
            var toDate = toDateTimePicker.Value.Date;
            if (fromDate == toDate)
            {
                MessageBox.Show("You should search in Interval, the dates are the same!");
            }
            else if (fromDate > toDate)
            {
                MessageBox.Show("\"From Date\" should be before \"To Date\"");
            }
            else
            {
                Display(EmpSalesReportQ.Display(empsComboBox.SelectedValue.ToString(), fromDateTimePicker.Value.Date, toDateTimePicker.Value.Date).ToList());
            }
}
    }
}
