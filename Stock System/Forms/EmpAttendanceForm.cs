using Stock_System.Bussiness_Layer;
using System;
using System.Windows.Forms;

namespace Stock_System
{
    public partial class EmpAttendanceForm : Form
    {
       
        public EmpAttendanceForm()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            DisplayEmps();
        }
        void DisplayEmps()
        {
            timePicker.Value =DateTime.Now;
            
            dataGridView1.DataSource = EmpAttendanceQ.DispalyAll();
        }

        private void timeOutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (timeOutRadioButton.Checked == true)
            {
                timeLabel.Text = "Logout-Time ";   
            }
            else
                timeLabel.Text = "Login-Time ";
        }
        int id,index;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            nIdPanel.Visible = true;
            id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            index = int.Parse(dataGridView1.CurrentRow.Index.ToString());
            nIdTextBox.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
        }

        private void EmpAttendanceForm_Load(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Selected = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (timeInRadioButton.Checked==true)
            {
                EmpAttendanceQ.TimeRegisteration(timePicker.Value.TimeOfDay,id,"login");
            }
            else
            {
                EmpAttendanceQ.TimeRegisteration(timePicker.Value.TimeOfDay, id, "logout");
            }
            dataGridView1.DataSource = null;
            DisplayEmps();
           
            dataGridView1.CurrentCell.Selected = false;
            
        }
    }
}
