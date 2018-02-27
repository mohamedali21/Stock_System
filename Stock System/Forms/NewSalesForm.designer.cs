﻿namespace stock.forms
{
    partial class NewSalesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.stockCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerCmb = new System.Windows.Forms.ComboBox();
            this.allProductGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.SalesDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalPriceTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productCountTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchByCompanyTxat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchByNametxt = new System.Windows.Forms.TextBox();
            this.productTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.selectedProductGridView = new System.Windows.Forms.DataGridView();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeCmbBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DiscountTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AfterDiscountTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.SetQtyBtn = new System.Windows.Forms.Button();
            this.PaidAmountBtn = new System.Windows.Forms.Button();
            this.PaidNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.RemainAmountTxtBox = new System.Windows.Forms.TextBox();
            this.invoiceNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.allProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceNumNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Stocks";
            // 
            // stockCmb
            // 
            this.stockCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stockCmb.FormattingEnabled = true;
            this.stockCmb.Location = new System.Drawing.Point(430, 36);
            this.stockCmb.Name = "stockCmb";
            this.stockCmb.Size = new System.Drawing.Size(211, 21);
            this.stockCmb.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "customer";
            // 
            // CustomerCmb
            // 
            this.CustomerCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerCmb.FormattingEnabled = true;
            this.CustomerCmb.Location = new System.Drawing.Point(430, 9);
            this.CustomerCmb.Name = "CustomerCmb";
            this.CustomerCmb.Size = new System.Drawing.Size(211, 21);
            this.CustomerCmb.TabIndex = 73;
            // 
            // allProductGridView
            // 
            this.allProductGridView.AllowUserToResizeColumns = false;
            this.allProductGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.allProductGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allProductGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.allProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allProductGridView.Location = new System.Drawing.Point(11, 160);
            this.allProductGridView.MultiSelect = false;
            this.allProductGridView.Name = "allProductGridView";
            this.allProductGridView.ReadOnly = true;
            this.allProductGridView.RowHeadersVisible = false;
            this.allProductGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.allProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allProductGridView.Size = new System.Drawing.Size(586, 325);
            this.allProductGridView.TabIndex = 61;
            this.allProductGridView.DoubleClick += new System.EventHandler(this.allProductGridView_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(647, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 37);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Pay Type";
            // 
            // TypeCombo
            // 
            this.TypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Cash",
            "Due Date"});
            this.TypeCombo.Location = new System.Drawing.Point(430, 67);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(211, 21);
            this.TypeCombo.TabIndex = 58;
            this.TypeCombo.SelectedIndexChanged += new System.EventHandler(this.TypeCombo_SelectedIndexChanged);
            // 
            // SalesDatePicker
            // 
            this.SalesDatePicker.Location = new System.Drawing.Point(121, 33);
            this.SalesDatePicker.Name = "SalesDatePicker";
            this.SalesDatePicker.Size = new System.Drawing.Size(182, 20);
            this.SalesDatePicker.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Sales Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Invoice Number ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Total Price";
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.Location = new System.Drawing.Point(758, 49);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.ReadOnly = true;
            this.TotalPriceTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalPriceTxt.TabIndex = 69;
            this.TotalPriceTxt.Text = "0";
            this.TotalPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalPriceTxt.TextChanged += new System.EventHandler(this.TotalPriceTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Num OF Product";
            // 
            // productCountTxt
            // 
            this.productCountTxt.Location = new System.Drawing.Point(758, 101);
            this.productCountTxt.Name = "productCountTxt";
            this.productCountTxt.ReadOnly = true;
            this.productCountTxt.Size = new System.Drawing.Size(100, 20);
            this.productCountTxt.TabIndex = 67;
            this.productCountTxt.Text = "0";
            this.productCountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Search By Company";
            // 
            // searchByCompanyTxat
            // 
            this.searchByCompanyTxat.Location = new System.Drawing.Point(121, 117);
            this.searchByCompanyTxat.Name = "searchByCompanyTxat";
            this.searchByCompanyTxat.Size = new System.Drawing.Size(182, 20);
            this.searchByCompanyTxat.TabIndex = 65;
            this.searchByCompanyTxat.TextChanged += new System.EventHandler(this.searchByCompanyTxat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Search By Name";
            // 
            // searchByNametxt
            // 
            this.searchByNametxt.Location = new System.Drawing.Point(121, 85);
            this.searchByNametxt.Name = "searchByNametxt";
            this.searchByNametxt.Size = new System.Drawing.Size(182, 20);
            this.searchByNametxt.TabIndex = 63;
            this.searchByNametxt.TextChanged += new System.EventHandler(this.searchByNametxt_TextChanged);
            // 
            // productTimePicker1
            // 
            this.productTimePicker1.Location = new System.Drawing.Point(430, 125);
            this.productTimePicker1.Name = "productTimePicker1";
            this.productTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.productTimePicker1.TabIndex = 71;
            this.productTimePicker1.ValueChanged += new System.EventHandler(this.productTimePicker1_ValueChanged);
            // 
            // selectedProductGridView
            // 
            this.selectedProductGridView.AllowUserToAddRows = false;
            this.selectedProductGridView.AllowUserToDeleteRows = false;
            this.selectedProductGridView.AllowUserToResizeColumns = false;
            this.selectedProductGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.selectedProductGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.selectedProductGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProName,
            this.Company,
            this.Qty,
            this.Exp});
            this.selectedProductGridView.Location = new System.Drawing.Point(603, 160);
            this.selectedProductGridView.MultiSelect = false;
            this.selectedProductGridView.Name = "selectedProductGridView";
            this.selectedProductGridView.RowHeadersVisible = false;
            this.selectedProductGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.selectedProductGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.selectedProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedProductGridView.Size = new System.Drawing.Size(631, 325);
            this.selectedProductGridView.TabIndex = 62;
            this.selectedProductGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedProductGridView_CellEndEdit);
            this.selectedProductGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.selectedProductGridView_RowsAdded);
            this.selectedProductGridView.DoubleClick += new System.EventHandler(this.selectedProductGridView_DoubleClick);
            // 
            // ProName
            // 
            this.ProName.HeaderText = "Name";
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Exp
            // 
            this.Exp.HeaderText = "Exp Date";
            this.Exp.Name = "Exp";
            this.Exp.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Exp Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Employee";
            // 
            // EmployeeCmbBox
            // 
            this.EmployeeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeCmbBox.FormattingEnabled = true;
            this.EmployeeCmbBox.Location = new System.Drawing.Point(430, 98);
            this.EmployeeCmbBox.Name = "EmployeeCmbBox";
            this.EmployeeCmbBox.Size = new System.Drawing.Size(211, 21);
            this.EmployeeCmbBox.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Discount";
            // 
            // DiscountTxtBox
            // 
            this.DiscountTxtBox.Location = new System.Drawing.Point(121, 59);
            this.DiscountTxtBox.Name = "DiscountTxtBox";
            this.DiscountTxtBox.Size = new System.Drawing.Size(182, 20);
            this.DiscountTxtBox.TabIndex = 79;
            this.DiscountTxtBox.Text = "0";
            this.DiscountTxtBox.Leave += new System.EventHandler(this.DiscountTxtBox_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(649, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "After Discount";
            // 
            // AfterDiscountTxtBox
            // 
            this.AfterDiscountTxtBox.Location = new System.Drawing.Point(758, 75);
            this.AfterDiscountTxtBox.Name = "AfterDiscountTxtBox";
            this.AfterDiscountTxtBox.ReadOnly = true;
            this.AfterDiscountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AfterDiscountTxtBox.TabIndex = 81;
            this.AfterDiscountTxtBox.Text = "0";
            this.AfterDiscountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AfterDiscountTxtBox.TextChanged += new System.EventHandler(this.AfterDiscountTxtBox_TextChanged);
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.Location = new System.Drawing.Point(743, 129);
            this.QuantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.Size = new System.Drawing.Size(120, 20);
            this.QuantityUpDown.TabIndex = 83;
            this.QuantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SetQtyBtn
            // 
            this.SetQtyBtn.Location = new System.Drawing.Point(654, 129);
            this.SetQtyBtn.Name = "SetQtyBtn";
            this.SetQtyBtn.Size = new System.Drawing.Size(69, 20);
            this.SetQtyBtn.TabIndex = 84;
            this.SetQtyBtn.Text = "Set Qty";
            this.SetQtyBtn.UseVisualStyleBackColor = true;
            this.SetQtyBtn.Click += new System.EventHandler(this.SetQtyBtn_Click);
            // 
            // PaidAmountBtn
            // 
            this.PaidAmountBtn.Location = new System.Drawing.Point(864, 23);
            this.PaidAmountBtn.Name = "PaidAmountBtn";
            this.PaidAmountBtn.Size = new System.Drawing.Size(69, 20);
            this.PaidAmountBtn.TabIndex = 86;
            this.PaidAmountBtn.Text = "Paid";
            this.PaidAmountBtn.UseVisualStyleBackColor = true;
            this.PaidAmountBtn.Click += new System.EventHandler(this.PaidAmountBtn_Click);
            // 
            // PaidNumericUpDown
            // 
            this.PaidNumericUpDown.Location = new System.Drawing.Point(939, 23);
            this.PaidNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaidNumericUpDown.Name = "PaidNumericUpDown";
            this.PaidNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.PaidNumericUpDown.TabIndex = 85;
            this.PaidNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaidNumericUpDown.Leave += new System.EventHandler(this.PaidNumericUpDown_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(861, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 88;
            this.label14.Text = "Remain";
            // 
            // RemainAmountTxtBox
            // 
            this.RemainAmountTxtBox.Location = new System.Drawing.Point(939, 49);
            this.RemainAmountTxtBox.Name = "RemainAmountTxtBox";
            this.RemainAmountTxtBox.ReadOnly = true;
            this.RemainAmountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.RemainAmountTxtBox.TabIndex = 87;
            this.RemainAmountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // invoiceNumNumericUpDown
            // 
            this.invoiceNumNumericUpDown.Location = new System.Drawing.Point(121, 10);
            this.invoiceNumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.invoiceNumNumericUpDown.Name = "invoiceNumNumericUpDown";
            this.invoiceNumNumericUpDown.Size = new System.Drawing.Size(182, 20);
            this.invoiceNumNumericUpDown.TabIndex = 89;
            this.invoiceNumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NewSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 497);
            this.Controls.Add(this.invoiceNumNumericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.RemainAmountTxtBox);
            this.Controls.Add(this.PaidAmountBtn);
            this.Controls.Add(this.PaidNumericUpDown);
            this.Controls.Add(this.SetQtyBtn);
            this.Controls.Add(this.QuantityUpDown);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AfterDiscountTxtBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DiscountTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeCmbBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.stockCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerCmb);
            this.Controls.Add(this.allProductGridView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.SalesDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalPriceTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productCountTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchByCompanyTxat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchByNametxt);
            this.Controls.Add(this.productTimePicker1);
            this.Controls.Add(this.selectedProductGridView);
            this.Controls.Add(this.label10);
            this.Name = "NewSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.allProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceNumNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox stockCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CustomerCmb;
        private System.Windows.Forms.DataGridView allProductGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.DateTimePicker SalesDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TotalPriceTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox productCountTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchByCompanyTxat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchByNametxt;
        private System.Windows.Forms.DateTimePicker productTimePicker1;
        private System.Windows.Forms.DataGridView selectedProductGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmployeeCmbBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DiscountTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AfterDiscountTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exp;
        private System.Windows.Forms.NumericUpDown QuantityUpDown;
        private System.Windows.Forms.Button SetQtyBtn;
        private System.Windows.Forms.Button PaidAmountBtn;
        private System.Windows.Forms.NumericUpDown PaidNumericUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox RemainAmountTxtBox;
        private System.Windows.Forms.NumericUpDown invoiceNumNumericUpDown;
    }
}