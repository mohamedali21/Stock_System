namespace Stock_System
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.UsercheckBox = new System.Windows.Forms.CheckBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.genderlabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hireDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genderColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salaryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isActiveColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoginGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.passwordTextBox);
            this.LoginGroupBox.Controls.Add(this.userNameTextBox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.UserNameLabel);
            this.LoginGroupBox.Location = new System.Drawing.Point(550, 136);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(284, 89);
            this.LoginGroupBox.TabIndex = 1;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Register";
            this.LoginGroupBox.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(83, 55);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(136, 26);
            this.passwordTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(83, 22);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(136, 26);
            this.userNameTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(7, 63);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(7, 30);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.SalaryNumericUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.isActiveCheckBox);
            this.panel1.Controls.Add(this.UsercheckBox);
            this.panel1.Controls.Add(this.jobTextBox);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.hireDateLabel);
            this.panel1.Controls.Add(this.JobLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.nIdTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.femaleRadioButton);
            this.panel1.Controls.Add(this.maleRadioButton);
            this.panel1.Controls.Add(this.genderlabel);
            this.panel1.Controls.Add(this.addresslabel);
            this.panel1.Controls.Add(this.phonelabel);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 188);
            this.panel1.TabIndex = 2;
            // 
            // SalaryNumericUpDown
            // 
            this.SalaryNumericUpDown.Location = new System.Drawing.Point(317, 142);
            this.SalaryNumericUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.SalaryNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SalaryNumericUpDown.Name = "SalaryNumericUpDown";
            this.SalaryNumericUpDown.Size = new System.Drawing.Size(159, 20);
            this.SalaryNumericUpDown.TabIndex = 18;
            this.SalaryNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Salary";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(122, 159);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(62, 17);
            this.isActiveCheckBox.TabIndex = 16;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsercheckBox
            // 
            this.UsercheckBox.AutoSize = true;
            this.UsercheckBox.Location = new System.Drawing.Point(13, 159);
            this.UsercheckBox.Name = "UsercheckBox";
            this.UsercheckBox.Size = new System.Drawing.Size(96, 17);
            this.UsercheckBox.TabIndex = 15;
            this.UsercheckBox.Text = "System User";
            this.UsercheckBox.UseVisualStyleBackColor = true;
            this.UsercheckBox.CheckedChanged += new System.EventHandler(this.UsercheckBox_CheckedChanged);
            // 
            // jobTextBox
            // 
            this.jobTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTextBox.Location = new System.Drawing.Point(317, 18);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(209, 21);
            this.jobTextBox.TabIndex = 14;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(319, 56);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.AutoSize = true;
            this.hireDateLabel.Location = new System.Drawing.Point(255, 61);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(61, 13);
            this.hireDateLabel.TabIndex = 12;
            this.hireDateLabel.Text = "Hire Date";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(255, 25);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(56, 13);
            this.JobLabel.TabIndex = 11;
            this.JobLabel.Text = "Job Title";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(319, 83);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(210, 51);
            this.addressTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(55, 83);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(174, 21);
            this.phoneTextBox.TabIndex = 9;
            // 
            // nIdTextBox
            // 
            this.nIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nIdTextBox.Location = new System.Drawing.Point(85, 49);
            this.nIdTextBox.Name = "nIdTextBox";
            this.nIdTextBox.Size = new System.Drawing.Size(143, 21);
            this.nIdTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(55, 18);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 21);
            this.nameTextBox.TabIndex = 7;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(122, 124);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(65, 17);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(64, 124);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(52, 17);
            this.maleRadioButton.TabIndex = 5;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(10, 124);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(48, 13);
            this.genderlabel.TabIndex = 4;
            this.genderlabel.Text = "Gender";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.Location = new System.Drawing.Point(255, 100);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(52, 13);
            this.addresslabel.TabIndex = 3;
            this.addresslabel.Text = "Address";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.Location = new System.Drawing.Point(10, 88);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(43, 13);
            this.phonelabel.TabIndex = 2;
            this.phonelabel.Text = "Phone";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(10, 54);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(69, 13);
            this.idlabel.TabIndex = 1;
            this.idlabel.Text = "National Id";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(10, 21);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(39, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.addbutton);
            this.panel2.Location = new System.Drawing.Point(550, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 53);
            this.panel2.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(190, 11);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(81, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(97, 11);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(87, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(3, 11);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(88, 23);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(550, 109);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(219, 23);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Name",
            "Address",
            "Phone",
            "Job Title",
            "National ID"});
            this.searchComboBox.Location = new System.Drawing.Point(775, 111);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(63, 21);
            this.searchComboBox.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdcolumnHeader,
            this.N_IdColumnHeader,
            this.NameColumnHeader,
            this.phoneColumnHeader,
            this.addressColumnHeader,
            this.jobColumnHeader,
            this.hireDateColumnHeader,
            this.genderColumnHeader,
            this.salaryColumnHeader,
            this.isActiveColumnHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 269);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(878, 278);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IdcolumnHeader
            // 
            this.IdcolumnHeader.Text = "Id";
            this.IdcolumnHeader.Width = 42;
            // 
            // N_IdColumnHeader
            // 
            this.N_IdColumnHeader.Text = "National Id";
            this.N_IdColumnHeader.Width = 101;
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "Name";
            this.NameColumnHeader.Width = 110;
            // 
            // phoneColumnHeader
            // 
            this.phoneColumnHeader.Text = "phone";
            this.phoneColumnHeader.Width = 118;
            // 
            // addressColumnHeader
            // 
            this.addressColumnHeader.Text = "Address";
            this.addressColumnHeader.Width = 123;
            // 
            // jobColumnHeader
            // 
            this.jobColumnHeader.Text = "Job Title";
            this.jobColumnHeader.Width = 90;
            // 
            // hireDateColumnHeader
            // 
            this.hireDateColumnHeader.Text = "Hire Date";
            this.hireDateColumnHeader.Width = 105;
            // 
            // genderColumnHeader
            // 
            this.genderColumnHeader.Text = "Gender";
            // 
            // salaryColumnHeader
            // 
            this.salaryColumnHeader.DisplayIndex = 9;
            this.salaryColumnHeader.Text = "Salary";
            // 
            // isActiveColumnHeader
            // 
            this.isActiveColumnHeader.DisplayIndex = 8;
            this.isActiveColumnHeader.Text = "Active";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 559);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.CheckBox UsercheckBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdcolumnHeader;
        private System.Windows.Forms.ColumnHeader N_IdColumnHeader;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader phoneColumnHeader;
        private System.Windows.Forms.ColumnHeader addressColumnHeader;
        private System.Windows.Forms.ColumnHeader jobColumnHeader;
        private System.Windows.Forms.ColumnHeader hireDateColumnHeader;
        private System.Windows.Forms.ColumnHeader genderColumnHeader;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.ColumnHeader isActiveColumnHeader;
        private System.Windows.Forms.NumericUpDown SalaryNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader salaryColumnHeader;
    }
}

