using System.Windows.Forms;

namespace Stock_System
{
    partial class EmpAttendanceForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeInRadioButton = new System.Windows.Forms.RadioButton();
            this.timeOutRadioButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nIdTextBox = new System.Windows.Forms.TextBox();
            this.nIdPanel = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.nIdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(75, 35);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(46, 17);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "label4";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(164, 35);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(89, 17);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Login-Time";
            // 
            // timeInRadioButton
            // 
            this.timeInRadioButton.AutoSize = true;
            this.timeInRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInRadioButton.Location = new System.Drawing.Point(30, 80);
            this.timeInRadioButton.Name = "timeInRadioButton";
            this.timeInRadioButton.Size = new System.Drawing.Size(87, 17);
            this.timeInRadioButton.TabIndex = 15;
            this.timeInRadioButton.TabStop = true;
            this.timeInRadioButton.Text = "Login-Time";
            this.timeInRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeOutRadioButton
            // 
            this.timeOutRadioButton.AutoSize = true;
            this.timeOutRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutRadioButton.Location = new System.Drawing.Point(123, 80);
            this.timeOutRadioButton.Name = "timeOutRadioButton";
            this.timeOutRadioButton.Size = new System.Drawing.Size(95, 17);
            this.timeOutRadioButton.TabIndex = 16;
            this.timeOutRadioButton.TabStop = true;
            this.timeOutRadioButton.Text = "Logout-Time";
            this.timeOutRadioButton.UseVisualStyleBackColor = true;
            this.timeOutRadioButton.CheckedChanged += new System.EventHandler(this.timeOutRadioButton_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 132);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 244);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLabel.Location = new System.Drawing.Point(375, 35);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(0, 15);
            this.empNameLabel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // nIdTextBox
            // 
            this.nIdTextBox.Enabled = false;
            this.nIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nIdTextBox.Location = new System.Drawing.Point(48, 3);
            this.nIdTextBox.Name = "nIdTextBox";
            this.nIdTextBox.Size = new System.Drawing.Size(190, 23);
            this.nIdTextBox.TabIndex = 20;
            // 
            // nIdPanel
            // 
            this.nIdPanel.Controls.Add(this.submitButton);
            this.nIdPanel.Controls.Add(this.label1);
            this.nIdPanel.Controls.Add(this.nIdTextBox);
            this.nIdPanel.Location = new System.Drawing.Point(352, 35);
            this.nIdPanel.Name = "nIdPanel";
            this.nIdPanel.Size = new System.Drawing.Size(241, 68);
            this.nIdPanel.TabIndex = 21;
            this.nIdPanel.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(6, 39);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 22;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm:ss";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(269, 35);
            this.timePicker.Name = "timePicker";
            this.timePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(77, 20);
            this.timePicker.TabIndex = 22;
            // 
            // EmpAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 396);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.nIdPanel);
            this.Controls.Add(this.empNameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.timeOutRadioButton);
            this.Controls.Add(this.timeInRadioButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label3);
            this.Name = "EmpAttendanceForm";
            this.Text = "EmpAttendanceForm";
            this.Load += new System.EventHandler(this.EmpAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.nIdPanel.ResumeLayout(false);
            this.nIdPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.RadioButton timeInRadioButton;
        private System.Windows.Forms.RadioButton timeOutRadioButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nIdTextBox;
        private System.Windows.Forms.Panel nIdPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}