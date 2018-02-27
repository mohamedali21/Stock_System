namespace stock.forms
{
    partial class SalesDetailesForm
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductNumberTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PurchaseOrderIdTxt = new System.Windows.Forms.TextBox();
            this.DetailsGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.AfterDiscountTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DiscountTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(666, 18);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 39);
            this.returnBtn.TabIndex = 19;
            this.returnBtn.Text = "Add Rrturn";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Prod Number";
            // 
            // ProductNumberTxt
            // 
            this.ProductNumberTxt.Location = new System.Drawing.Point(310, 41);
            this.ProductNumberTxt.Name = "ProductNumberTxt";
            this.ProductNumberTxt.ReadOnly = true;
            this.ProductNumberTxt.Size = new System.Drawing.Size(134, 20);
            this.ProductNumberTxt.TabIndex = 17;
            this.ProductNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Amount";
            // 
            // TotalPriceTxtBox
            // 
            this.TotalPriceTxtBox.Location = new System.Drawing.Point(310, 15);
            this.TotalPriceTxtBox.Name = "TotalPriceTxtBox";
            this.TotalPriceTxtBox.ReadOnly = true;
            this.TotalPriceTxtBox.Size = new System.Drawing.Size(134, 20);
            this.TotalPriceTxtBox.TabIndex = 15;
            this.TotalPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Supplier Name";
            // 
            // CustomerNameTxt
            // 
            this.CustomerNameTxt.Location = new System.Drawing.Point(94, 38);
            this.CustomerNameTxt.Name = "CustomerNameTxt";
            this.CustomerNameTxt.ReadOnly = true;
            this.CustomerNameTxt.Size = new System.Drawing.Size(134, 20);
            this.CustomerNameTxt.TabIndex = 13;
            this.CustomerNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Purchase ID";
            // 
            // PurchaseOrderIdTxt
            // 
            this.PurchaseOrderIdTxt.Location = new System.Drawing.Point(94, 12);
            this.PurchaseOrderIdTxt.Name = "PurchaseOrderIdTxt";
            this.PurchaseOrderIdTxt.ReadOnly = true;
            this.PurchaseOrderIdTxt.Size = new System.Drawing.Size(134, 20);
            this.PurchaseOrderIdTxt.TabIndex = 11;
            this.PurchaseOrderIdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetailsGV
            // 
            this.DetailsGV.AllowUserToAddRows = false;
            this.DetailsGV.AllowUserToDeleteRows = false;
            this.DetailsGV.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DetailsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DetailsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetailsGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetailsGV.Location = new System.Drawing.Point(12, 64);
            this.DetailsGV.MultiSelect = false;
            this.DetailsGV.Name = "DetailsGV";
            this.DetailsGV.ReadOnly = true;
            this.DetailsGV.RowHeadersVisible = false;
            this.DetailsGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DetailsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetailsGV.Size = new System.Drawing.Size(728, 343);
            this.DetailsGV.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "After Discount";
            // 
            // AfterDiscountTxtBox
            // 
            this.AfterDiscountTxtBox.Location = new System.Drawing.Point(526, 15);
            this.AfterDiscountTxtBox.Name = "AfterDiscountTxtBox";
            this.AfterDiscountTxtBox.ReadOnly = true;
            this.AfterDiscountTxtBox.Size = new System.Drawing.Size(134, 20);
            this.AfterDiscountTxtBox.TabIndex = 22;
            this.AfterDiscountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Discount";
            // 
            // DiscountTxtBox
            // 
            this.DiscountTxtBox.Location = new System.Drawing.Point(526, 40);
            this.DiscountTxtBox.Name = "DiscountTxtBox";
            this.DiscountTxtBox.ReadOnly = true;
            this.DiscountTxtBox.Size = new System.Drawing.Size(134, 20);
            this.DiscountTxtBox.TabIndex = 20;
            this.DiscountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesDetailesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 419);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AfterDiscountTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiscountTxtBox);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductNumberTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalPriceTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchaseOrderIdTxt);
            this.Controls.Add(this.DetailsGV);
            this.Name = "SalesDetailesForm";
            this.Text = "SalesDetailesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DetailsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductNumberTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalPriceTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PurchaseOrderIdTxt;
        private System.Windows.Forms.DataGridView DetailsGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AfterDiscountTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DiscountTxtBox;
    }
}