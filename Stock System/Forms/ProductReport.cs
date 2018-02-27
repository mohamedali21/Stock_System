using Stock_System;
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
    public partial class ProductReport : Form
    {
        public ProductReport()
        {
            InitializeComponent();
        }
        Stock_SystemEntities st = new Stock_SystemEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dateTimePicker2.Value;
            DateTime endDate = dateTimePicker1.Value;

            var db = Program.context.prudctReport(beginDate);
            dataGridView1.DataSource = db;

            if (checkbox1.Checked == true)
            {
                var db1 = st.prudctReportWithInterval(beginDate, endDate);
                dataGridView1.DataSource = db1;
            }
            else
            {
                dataGridView1.DataSource = db;
            }

        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox1.Checked == true)
            {
                dateTimePicker1.Enabled = true;
               
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }
    }
}
