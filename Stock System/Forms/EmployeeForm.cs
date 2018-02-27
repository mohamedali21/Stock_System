using Stock_System.Bussiness_Layer;
using System;
using System.Windows.Forms;

namespace Stock_System
{
    public partial class EmployeeForm : Form
    {
        Stock_SystemEntities context = new Stock_SystemEntities();
        int indexSelected,id;
        public EmployeeForm()
        {
            InitializeComponent();
            DisplayEmployess();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if(checIsEmpty())
            {
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
                else if(checkNId())
                {
                    MessageBox.Show("National Id number must be 14 number!");
                }
                else
                {
                    addEmp();
                    clearControls();
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
        bool checkNId()
        {
            if (nIdTextBox.Text.Length > 14 || nIdTextBox.Text.Length > 14)
                return true;
            else
                return false;
        }
        private void clearControls()
        {
            nIdTextBox.Text = null;
            nameTextBox.Text = null;
            phoneTextBox.Text = null;
            addressTextBox.Text = null;
            jobTextBox.Text = null;
            dateTimePicker.Value = DateTime.Now;
            if (UsercheckBox.Checked)
            {
                userNameTextBox.Text = null;
                passwordTextBox.Text = null;
            }
        }
        private void addEmp()
        {
            string gender,isActive;
            if (maleRadioButton.Checked)
                gender = "M";
            else
                gender = "F";
            if (isActiveCheckBox.Checked)
                isActive = "Yes";
            else
                isActive = "No";
            if (UsercheckBox.Checked)
            {
                if (userNameTextBox.Text != null && passwordTextBox.Text != null)
                {
                    if (EmployeeQ.checkUsername(userNameTextBox.Text))
                    {
                        MessageBox.Show("Username already Exist!");
                    }
                    else
                    {
                        EmployeeQ.Add(nIdTextBox.Text,
                            nameTextBox.Text,
                            phoneTextBox.Text,
                            addressTextBox.Text,
                             jobTextBox.Text,
                              dateTimePicker.Value.Date,
                              gender,
                              (double)SalaryNumericUpDown.Value,
                              isActive,
                              userNameTextBox.Text,
                              passwordTextBox.Text);
                    }
                }
            }else
            {
                EmployeeQ.Add(nIdTextBox.Text,
                        nameTextBox.Text,
                        phoneTextBox.Text,
                        addressTextBox.Text,
                         jobTextBox.Text,
                          dateTimePicker.Value.Date,
                          gender,
                          (double)SalaryNumericUpDown.Value,
                          isActive);
            }
            DisplayEmployess();
        }
        private void UsercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UsercheckBox.Checked)
                LoginGroupBox.Visible = true;
            else
                LoginGroupBox.Visible = false;
        }
        
        private void DisplayEmployess()
        {
            listView1.Items.Clear();
            var emps = EmployeeQ.DisplayAll();
            foreach (var item in emps)
            {
                fillRowOfListView(item.Id, item.N_Id, item.Name, item.phone, item.Address, item.JobTitle, item.HireDate, item.Gender,item.Salary.ToString(),item.Active);
            }
        }
        private void fillRowOfListView(int id, string nId, string name, string phone, string address, string jobTltle, DateTime hireDate, string gender,string salary,string isActive)
        {
            ListViewItem item1 = new ListViewItem(id.ToString());
            item1.SubItems.Add(nId);
            item1.SubItems.Add(name);
            item1.SubItems.Add(phone);
            item1.SubItems.Add(address);
            item1.SubItems.Add(jobTltle);
            item1.SubItems.Add(hireDate.ToString());
            item1.SubItems.Add(gender);
            item1.SubItems.Add(salary);
            item1.SubItems.Add(isActive);
            listView1.Items.Add(item1);

        }
        bool checIsEmpty()
        {
            if (nameTextBox.Text == "" || nIdTextBox.Text == "" || jobTextBox.Text == "" || phoneTextBox.Text == "" || addressTextBox.Text == "")
                return true;
            else
                return false;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (listView1.SelectedItems.Count == 0)
                return;
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            indexSelected = listView1.SelectedIndices[0];
            nIdTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            nameTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            phoneTextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            addressTextBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
            jobTextBox.Text = listView1.SelectedItems[0].SubItems[5].Text;
            dateTimePicker.Text = listView1.SelectedItems[0].SubItems[6].Text;
            if (listView1.SelectedItems[0].SubItems[7].Text == "M")
                maleRadioButton.Checked = true;
            else
                femaleRadioButton.Checked = true;
            if (listView1.SelectedItems[0].SubItems[9].Text == "Yes")
            {
                isActiveCheckBox.Checked = true;
            }
            else
                isActiveCheckBox.Checked = false;
            var user = EmployeeQ.IsUser(id);
            if(user!=null)
            {
                UsercheckBox.Checked = true;
                userNameTextBox.Text = user.UserName;
                passwordTextBox.Text = user.Password;   
            }
            else
            {
                UsercheckBox.Checked = false;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to update this item ??",
                                     "Confirm Update!!",
                                     MessageBoxButtons.YesNo);
            string gender,isActive;
            if (maleRadioButton.Checked)
                gender = "M";
            else
                gender = "F";
            if (isActiveCheckBox.Checked)
                isActive = "Yes";
            else
                isActive = "No";
        
            if (confirmResult == DialogResult.Yes)
            {
                    
                if (UsercheckBox.Checked)
                {
                    if (userNameTextBox.Text != null && passwordTextBox.Text != null)
                    {
                            EmployeeQ.AccountUpdate(id, userNameTextBox.Text, passwordTextBox.Text);
                    }
                }
                else
                {
                    EmployeeQ.RemoveAccount(id);
                }
                EmployeeQ.Update(id,nIdTextBox.Text,nameTextBox.Text,phoneTextBox.Text,addressTextBox.Text,jobTextBox.Text,dateTimePicker.Value.Date, gender,(double)SalaryNumericUpDown.Value, isActive);
                DisplayEmployess();
            }
            
        }


       

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                context.Delete_Employee(id);
                DisplayEmployess();
            }
            else
            {
                // If 'No', do something here.
            }
        }
       
        private void filter(Func<Employee, bool> del)
        {
            listView1.Items.Clear();
            var query = EmployeeQ.filter(del);
            foreach (var item in query)
            {
                fillRowOfListView(item.Id, item.N_Id,item.Name, 
                    item.phone, item.Address, item.JobTitle,item.HireDate,item.Gender,item.Salary.ToString(),item.Active);
            }

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchComboBox.SelectedIndex >= 0)
            {
                if (searchComboBox.SelectedIndex == 0)
                    filter(e1 => e1.Name.Contains(searchTextBox.Text));
                else if (searchComboBox.SelectedIndex == 1)
                    filter(e1 => e1.Address.Contains(searchTextBox.Text));
                else if(searchComboBox.SelectedIndex == 2)
                    filter(e1 => e1.phone.Contains(searchTextBox.Text));
                else if (searchComboBox.SelectedIndex == 3)
                    filter(e1 => e1.N_Id.Contains(searchTextBox.Text));
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
                else if (searchComboBox.SelectedIndex == 2)
                    filter(e1 => e1.phone.Contains(searchTextBox.Text));
                else if(searchComboBox.SelectedIndex==3)
                    filter(e1 => e1.JobTitle.Contains(searchTextBox.Text));
                else
                    filter(e1 => e1.N_Id.Contains(searchTextBox.Text));
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            searchComboBox.SelectedIndex = 0;
            isActiveCheckBox.Checked = true;
        }
    }
}

