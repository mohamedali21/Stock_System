namespace Stock_System.Forms
{
    partial class Emp_SalesReports
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
            this.empsComboBox = new System.Windows.Forms.ComboBox();
            this.formPanel = new System.Windows.Forms.Panel();
            this.nIdlabel = new System.Windows.Forms.Label();
            this.intervalCheckBox = new System.Windows.Forms.CheckBox();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.intervalPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.formPanel.SuspendLayout();
            this.intervalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empsComboBox
            // 
            this.empsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empsComboBox.FormattingEnabled = true;
            this.empsComboBox.Location = new System.Drawing.Point(11, 56);
            this.empsComboBox.Name = "empsComboBox";
            this.empsComboBox.Size = new System.Drawing.Size(188, 21);
            this.empsComboBox.TabIndex = 0;
            this.empsComboBox.SelectedIndexChanged += new System.EventHandler(this.empsComboBox_SelectedIndexChanged);
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.nIdlabel);
            this.formPanel.Controls.Add(this.intervalCheckBox);
            this.formPanel.Controls.Add(this.empsComboBox);
            this.formPanel.Controls.Add(this.yearRadioButton);
            this.formPanel.Controls.Add(this.monthRadioButton);
            this.formPanel.Controls.Add(this.weekRadioButton);
            this.formPanel.Location = new System.Drawing.Point(12, 12);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(357, 115);
            this.formPanel.TabIndex = 2;
            // 
            // nIdlabel
            // 
            this.nIdlabel.AutoSize = true;
            this.nIdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nIdlabel.Location = new System.Drawing.Point(205, 59);
            this.nIdlabel.Name = "nIdlabel";
            this.nIdlabel.Size = new System.Drawing.Size(67, 13);
            this.nIdlabel.TabIndex = 9;
            this.nIdlabel.Text = "sadsadasd";
            // 
            // intervalCheckBox
            // 
            this.intervalCheckBox.AutoSize = true;
            this.intervalCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalCheckBox.Location = new System.Drawing.Point(11, 95);
            this.intervalCheckBox.Name = "intervalCheckBox";
            this.intervalCheckBox.Size = new System.Drawing.Size(113, 17);
            this.intervalCheckBox.TabIndex = 8;
            this.intervalCheckBox.Text = "Search Interval";
            this.intervalCheckBox.UseVisualStyleBackColor = true;
            this.intervalCheckBox.CheckedChanged += new System.EventHandler(this.intervalCheckBox_CheckedChanged);
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearRadioButton.Location = new System.Drawing.Point(189, 22);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(79, 17);
            this.yearRadioButton.TabIndex = 7;
            this.yearRadioButton.TabStop = true;
            this.yearRadioButton.Text = "Last Year";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            this.yearRadioButton.CheckedChanged += new System.EventHandler(this.yearRadioButton_CheckedChanged);
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRadioButton.Location = new System.Drawing.Point(95, 22);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(88, 17);
            this.monthRadioButton.TabIndex = 6;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Last Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRadioButton.Location = new System.Drawing.Point(11, 22);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(86, 17);
            this.weekRadioButton.TabIndex = 5;
            this.weekRadioButton.TabStop = true;
            this.weekRadioButton.Text = "Last Week";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            this.weekRadioButton.CheckedChanged += new System.EventHandler(this.weekRadioButton_CheckedChanged);
            // 
            // intervalPanel
            // 
            this.intervalPanel.Controls.Add(this.label1);
            this.intervalPanel.Controls.Add(this.fromDateTimePicker);
            this.intervalPanel.Controls.Add(this.label2);
            this.intervalPanel.Controls.Add(this.searchButton);
            this.intervalPanel.Controls.Add(this.toDateTimePicker);
            this.intervalPanel.Location = new System.Drawing.Point(511, 12);
            this.intervalPanel.Name = "intervalPanel";
            this.intervalPanel.Size = new System.Drawing.Size(255, 115);
            this.intervalPanel.TabIndex = 9;
            this.intervalPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(71, 9);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.fromDateTimePicker.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(3, 64);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(250, 39);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(70, 35);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.toDateTimePicker.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(802, 347);
            this.dataGridView1.TabIndex = 10;
            // 
            // Emp_SalesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.intervalPanel);
            this.Controls.Add(this.formPanel);
            this.Name = "Emp_SalesReports";
            this.Text = "Emp_SalesReports";
            this.Load += new System.EventHandler(this.Emp_SalesReports_Load);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.intervalPanel.ResumeLayout(false);
            this.intervalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox empsComboBox;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.CheckBox intervalCheckBox;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.Panel intervalPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nIdlabel;
    }
}