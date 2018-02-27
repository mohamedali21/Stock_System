using Stock_System;
using Stock_System.Forms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EmployeeLogsReport obj = new EmployeeLogsReport();
            //obj.StartPosition = FormStartPosition.CenterScreen;
            //obj.WindowState = FormWindowState.Maximized;
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void newPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPurchaseForm2 obj = new NewPurchaseForm2();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void invoiceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
                  }

        private void newSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSalesForm obj = new NewSalesForm();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void salelsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnedOdersForm obj = new ReturnedOdersForm();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void productReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

       

        private void employeeSalesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void employeeReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Emp_SalesReports obj = new Emp_SalesReports();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewSalesForm obj = new NewSalesForm();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void employeesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_SalesReports obj = new Emp_SalesReports();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void productsReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductReport obj = new ProductReport();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void purchaseReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseInvoiceReport obj = new purchaseInvoiceReport();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();

        }

        private void salesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport obj = new SalesReport();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm obj = new EmployeeForm();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Normal;
            obj.ShowDialog();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpAttendanceForm obj = new EmpAttendanceForm();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Normal;
            obj.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm obj = new SupplierForm();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Normal;
            obj.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm obj = new CustomerForm();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Normal;
            obj.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
             StocksForm obj = new StocksForm();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.WindowState = FormWindowState.Normal;
            obj.ShowDialog();
        }
    }
}
