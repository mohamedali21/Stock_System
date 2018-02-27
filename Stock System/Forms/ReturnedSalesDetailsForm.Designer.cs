namespace Stock_System
{
    partial class ReturnedSalesDetailsForm
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
            this.invoiceItemsDdataGridView = new System.Windows.Forms.DataGridView();
            this.invioceDatelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceDateTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.returnedDatelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.desclabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.returnedItemsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsDdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnedItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceItemsDdataGridView
            // 
            this.invoiceItemsDdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceItemsDdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceItemsDdataGridView.Location = new System.Drawing.Point(13, 168);
            this.invoiceItemsDdataGridView.MultiSelect = false;
            this.invoiceItemsDdataGridView.Name = "invoiceItemsDdataGridView";
            this.invoiceItemsDdataGridView.ReadOnly = true;
            this.invoiceItemsDdataGridView.RowHeadersVisible = false;
            this.invoiceItemsDdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceItemsDdataGridView.Size = new System.Drawing.Size(465, 283);
            this.invoiceItemsDdataGridView.TabIndex = 0;
            this.invoiceItemsDdataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.invoiceItemsDdataGridView_DataBindingComplete);
            this.invoiceItemsDdataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // invioceDatelabel
            // 
            this.invioceDatelabel.AutoSize = true;
            this.invioceDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invioceDatelabel.Location = new System.Drawing.Point(12, 24);
            this.invioceDatelabel.Name = "invioceDatelabel";
            this.invioceDatelabel.Size = new System.Drawing.Size(80, 13);
            this.invioceDatelabel.TabIndex = 2;
            this.invioceDatelabel.Text = "Invoice Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "InvoiceNo";
            // 
            // invoiceDateTextBox
            // 
            this.invoiceDateTextBox.Enabled = false;
            this.invoiceDateTextBox.Location = new System.Drawing.Point(98, 20);
            this.invoiceDateTextBox.Name = "invoiceDateTextBox";
            this.invoiceDateTextBox.ReadOnly = true;
            this.invoiceDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateTextBox.TabIndex = 4;
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.Enabled = false;
            this.invoiceNoTextBox.Location = new System.Drawing.Point(98, 64);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.ReadOnly = true;
            this.invoiceNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoiceNoTextBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // returnedDatelabel
            // 
            this.returnedDatelabel.AutoSize = true;
            this.returnedDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedDatelabel.Location = new System.Drawing.Point(12, 109);
            this.returnedDatelabel.Name = "returnedDatelabel";
            this.returnedDatelabel.Size = new System.Drawing.Size(91, 13);
            this.returnedDatelabel.TabIndex = 7;
            this.returnedDatelabel.Text = "Date of Return";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(106, 82);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.quantityNumericUpDown.TabIndex = 10;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // desclabel
            // 
            this.desclabel.AutoSize = true;
            this.desclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclabel.Location = new System.Drawing.Point(14, 51);
            this.desclabel.Name = "desclabel";
            this.desclabel.Size = new System.Drawing.Size(71, 13);
            this.desclabel.TabIndex = 11;
            this.desclabel.Text = "Description";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(106, 27);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(223, 49);
            this.descTextBox.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(922, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 44);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(922, 53);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 47);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalAmountTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.prodNameTextBox);
            this.panel1.Controls.Add(this.productNameLabel);
            this.panel1.Controls.Add(this.descTextBox);
            this.panel1.Controls.Add(this.desclabel);
            this.panel1.Controls.Add(this.quantityNumericUpDown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(393, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 149);
            this.panel1.TabIndex = 16;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(106, 113);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTextBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total Amount";
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.Location = new System.Drawing.Point(106, 3);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.ReadOnly = true;
            this.prodNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.prodNameTextBox.TabIndex = 16;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(4, 11);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(87, 13);
            this.productNameLabel.TabIndex = 13;
            this.productNameLabel.Text = "Product Name";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(922, 109);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(111, 46);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // returnedItemsDataGridView
            // 
            this.returnedItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnedItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnedItemsDataGridView.Location = new System.Drawing.Point(484, 168);
            this.returnedItemsDataGridView.MultiSelect = false;
            this.returnedItemsDataGridView.Name = "returnedItemsDataGridView";
            this.returnedItemsDataGridView.ReadOnly = true;
            this.returnedItemsDataGridView.RowHeadersVisible = false;
            this.returnedItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returnedItemsDataGridView.Size = new System.Drawing.Size(558, 283);
            this.returnedItemsDataGridView.TabIndex = 0;
            this.returnedItemsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.returnedItemsDataGridView_DataBindingComplete);
            this.returnedItemsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // ReturnedSalesDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 467);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.returnedItemsDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.returnedDatelabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.invoiceNoTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.invoiceDateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invioceDatelabel);
            this.Controls.Add(this.invoiceItemsDdataGridView);
            this.Name = "ReturnedSalesDetailsForm";
            this.Text = "RetrunedSalesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnedSalesDetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.ReturnedSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsDdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnedItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoiceItemsDdataGridView;
        private System.Windows.Forms.Label invioceDatelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invoiceDateTextBox;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label returnedDatelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label desclabel;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView returnedItemsDataGridView;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label label4;
    }
}