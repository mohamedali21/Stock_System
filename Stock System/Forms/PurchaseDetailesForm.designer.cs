namespace stock.forms
{
    partial class PurchaseDetailesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DetailsGV = new System.Windows.Forms.DataGridView();
            this.PurchaseOrderIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductNumberTxt = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PaidTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RemainTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsGV
            // 
            this.DetailsGV.AllowUserToAddRows = false;
            this.DetailsGV.AllowUserToDeleteRows = false;
            this.DetailsGV.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DetailsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DetailsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetailsGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.DetailsGV.Location = new System.Drawing.Point(12, 64);
            this.DetailsGV.MultiSelect = false;
            this.DetailsGV.Name = "DetailsGV";
            this.DetailsGV.ReadOnly = true;
            this.DetailsGV.RowHeadersVisible = false;
            this.DetailsGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DetailsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetailsGV.Size = new System.Drawing.Size(857, 343);
            this.DetailsGV.TabIndex = 0;
            // 
            // PurchaseOrderIdTxt
            // 
            this.PurchaseOrderIdTxt.Location = new System.Drawing.Point(94, 12);
            this.PurchaseOrderIdTxt.Name = "PurchaseOrderIdTxt";
            this.PurchaseOrderIdTxt.ReadOnly = true;
            this.PurchaseOrderIdTxt.Size = new System.Drawing.Size(170, 20);
            this.PurchaseOrderIdTxt.TabIndex = 1;
            this.PurchaseOrderIdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Amount";
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(346, 15);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.ReadOnly = true;
            this.QuantityTxt.Size = new System.Drawing.Size(170, 20);
            this.QuantityTxt.TabIndex = 5;
            this.QuantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prod Number";
            // 
            // ProductNumberTxt
            // 
            this.ProductNumberTxt.Location = new System.Drawing.Point(346, 41);
            this.ProductNumberTxt.Name = "ProductNumberTxt";
            this.ProductNumberTxt.ReadOnly = true;
            this.ProductNumberTxt.Size = new System.Drawing.Size(170, 20);
            this.ProductNumberTxt.TabIndex = 7;
            this.ProductNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(755, 19);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 39);
            this.returnBtn.TabIndex = 9;
            this.returnBtn.Text = "Add Rrturn";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Paid";
            // 
            // PaidTxtBox
            // 
            this.PaidTxtBox.Location = new System.Drawing.Point(598, 15);
            this.PaidTxtBox.Name = "PaidTxtBox";
            this.PaidTxtBox.ReadOnly = true;
            this.PaidTxtBox.Size = new System.Drawing.Size(134, 20);
            this.PaidTxtBox.TabIndex = 26;
            this.PaidTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Remained";
            // 
            // RemainTxtBox
            // 
            this.RemainTxtBox.Location = new System.Drawing.Point(598, 40);
            this.RemainTxtBox.Name = "RemainTxtBox";
            this.RemainTxtBox.ReadOnly = true;
            this.RemainTxtBox.Size = new System.Drawing.Size(134, 20);
            this.RemainTxtBox.TabIndex = 24;
            this.RemainTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PurchaseDetailesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 419);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PaidTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RemainTxtBox);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductNumberTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchaseOrderIdTxt);
            this.Controls.Add(this.DetailsGV);
            this.Name = "PurchaseDetailesForm";
            this.Text = "PurchaseDetailesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DetailsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetailsGV;
        private System.Windows.Forms.TextBox PurchaseOrderIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductNumberTxt;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PaidTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RemainTxtBox;
    }
}