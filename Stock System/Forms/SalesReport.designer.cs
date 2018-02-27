namespace stock.forms
{
    partial class SalesReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.InvoiceCountTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalAmountTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDateDTB = new System.Windows.Forms.DateTimePicker();
            this.FromDateDTB = new System.Windows.Forms.DateTimePicker();
            this.IntervalSearchBX = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.suppNameTxt = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BetweenBtn = new System.Windows.Forms.Button();
            this.lastYearRadio = new System.Windows.Forms.RadioButton();
            this.lastMonthRadio = new System.Windows.Forms.RadioButton();
            this.lastWeekRadio = new System.Windows.Forms.RadioButton();
            this.lastDayRadio = new System.Windows.Forms.RadioButton();
            this.invoiceGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "#Invoices";
            // 
            // InvoiceCountTxtBox
            // 
            this.InvoiceCountTxtBox.Location = new System.Drawing.Point(533, 42);
            this.InvoiceCountTxtBox.Name = "InvoiceCountTxtBox";
            this.InvoiceCountTxtBox.ReadOnly = true;
            this.InvoiceCountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.InvoiceCountTxtBox.TabIndex = 40;
            this.InvoiceCountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Total Amount";
            // 
            // totalAmountTxtBox
            // 
            this.totalAmountTxtBox.Location = new System.Drawing.Point(533, 11);
            this.totalAmountTxtBox.Name = "totalAmountTxtBox";
            this.totalAmountTxtBox.ReadOnly = true;
            this.totalAmountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTxtBox.TabIndex = 38;
            this.totalAmountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "From Dart";
            // 
            // ToDateDTB
            // 
            this.ToDateDTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateDTB.Location = new System.Drawing.Point(285, 95);
            this.ToDateDTB.Name = "ToDateDTB";
            this.ToDateDTB.Size = new System.Drawing.Size(166, 20);
            this.ToDateDTB.TabIndex = 35;
            this.ToDateDTB.ValueChanged += new System.EventHandler(this.ToDateDTB_ValueChanged);
            // 
            // FromDateDTB
            // 
            this.FromDateDTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateDTB.Location = new System.Drawing.Point(285, 69);
            this.FromDateDTB.Name = "FromDateDTB";
            this.FromDateDTB.Size = new System.Drawing.Size(166, 20);
            this.FromDateDTB.TabIndex = 34;
            this.FromDateDTB.ValueChanged += new System.EventHandler(this.FromDateDTB_ValueChanged);
            // 
            // IntervalSearchBX
            // 
            this.IntervalSearchBX.AutoSize = true;
            this.IntervalSearchBX.Location = new System.Drawing.Point(195, 42);
            this.IntervalSearchBX.Name = "IntervalSearchBX";
            this.IntervalSearchBX.Size = new System.Drawing.Size(92, 17);
            this.IntervalSearchBX.TabIndex = 33;
            this.IntervalSearchBX.Text = "Name-Interval";
            this.IntervalSearchBX.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Supplier Name";
            // 
            // suppNameTxt
            // 
            this.suppNameTxt.Location = new System.Drawing.Point(285, 16);
            this.suppNameTxt.Name = "suppNameTxt";
            this.suppNameTxt.Size = new System.Drawing.Size(158, 20);
            this.suppNameTxt.TabIndex = 31;
            this.suppNameTxt.TextChanged += new System.EventHandler(this.suppNameTxt_TextChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(533, 68);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 43);
            this.ResetBtn.TabIndex = 30;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BetweenBtn
            // 
            this.BetweenBtn.Location = new System.Drawing.Point(614, 68);
            this.BetweenBtn.Name = "BetweenBtn";
            this.BetweenBtn.Size = new System.Drawing.Size(75, 43);
            this.BetweenBtn.TabIndex = 29;
            this.BetweenBtn.Text = "Interval Search";
            this.BetweenBtn.UseVisualStyleBackColor = true;
            this.BetweenBtn.Click += new System.EventHandler(this.BetweenBtn_Click);
            // 
            // lastYearRadio
            // 
            this.lastYearRadio.AutoSize = true;
            this.lastYearRadio.Location = new System.Drawing.Point(100, 37);
            this.lastYearRadio.Name = "lastYearRadio";
            this.lastYearRadio.Size = new System.Drawing.Size(70, 17);
            this.lastYearRadio.TabIndex = 28;
            this.lastYearRadio.TabStop = true;
            this.lastYearRadio.Text = "Last Year";
            this.lastYearRadio.UseVisualStyleBackColor = true;
            // 
            // lastMonthRadio
            // 
            this.lastMonthRadio.AutoSize = true;
            this.lastMonthRadio.Location = new System.Drawing.Point(12, 37);
            this.lastMonthRadio.Name = "lastMonthRadio";
            this.lastMonthRadio.Size = new System.Drawing.Size(78, 17);
            this.lastMonthRadio.TabIndex = 27;
            this.lastMonthRadio.TabStop = true;
            this.lastMonthRadio.Text = "Last Month";
            this.lastMonthRadio.UseVisualStyleBackColor = true;
            // 
            // lastWeekRadio
            // 
            this.lastWeekRadio.AutoSize = true;
            this.lastWeekRadio.Location = new System.Drawing.Point(100, 14);
            this.lastWeekRadio.Name = "lastWeekRadio";
            this.lastWeekRadio.Size = new System.Drawing.Size(77, 17);
            this.lastWeekRadio.TabIndex = 26;
            this.lastWeekRadio.TabStop = true;
            this.lastWeekRadio.Text = "Last Week";
            this.lastWeekRadio.UseVisualStyleBackColor = true;
            // 
            // lastDayRadio
            // 
            this.lastDayRadio.AutoSize = true;
            this.lastDayRadio.Location = new System.Drawing.Point(12, 14);
            this.lastDayRadio.Name = "lastDayRadio";
            this.lastDayRadio.Size = new System.Drawing.Size(57, 17);
            this.lastDayRadio.TabIndex = 25;
            this.lastDayRadio.TabStop = true;
            this.lastDayRadio.Text = "ToDay";
            this.lastDayRadio.UseVisualStyleBackColor = true;
            // 
            // invoiceGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invoiceGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.invoiceGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceGV.Location = new System.Drawing.Point(12, 119);
            this.invoiceGV.MultiSelect = false;
            this.invoiceGV.Name = "invoiceGV";
            this.invoiceGV.ReadOnly = true;
            this.invoiceGV.RowHeadersVisible = false;
            this.invoiceGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.invoiceGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceGV.Size = new System.Drawing.Size(841, 319);
            this.invoiceGV.TabIndex = 24;
            this.invoiceGV.DoubleClick += new System.EventHandler(this.invoiceGV_DoubleClick);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InvoiceCountTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalAmountTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDateDTB);
            this.Controls.Add(this.FromDateDTB);
            this.Controls.Add(this.IntervalSearchBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.suppNameTxt);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.BetweenBtn);
            this.Controls.Add(this.lastYearRadio);
            this.Controls.Add(this.lastMonthRadio);
            this.Controls.Add(this.lastWeekRadio);
            this.Controls.Add(this.lastDayRadio);
            this.Controls.Add(this.invoiceGV);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InvoiceCountTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalAmountTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ToDateDTB;
        private System.Windows.Forms.DateTimePicker FromDateDTB;
        private System.Windows.Forms.CheckBox IntervalSearchBX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox suppNameTxt;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button BetweenBtn;
        private System.Windows.Forms.RadioButton lastYearRadio;
        private System.Windows.Forms.RadioButton lastMonthRadio;
        private System.Windows.Forms.RadioButton lastWeekRadio;
        private System.Windows.Forms.RadioButton lastDayRadio;
        private System.Windows.Forms.DataGridView invoiceGV;
    }
}