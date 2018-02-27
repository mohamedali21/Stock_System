namespace Stock_System
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Add = new System.Windows.Forms.Button();
            this.nametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companytext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salespricetext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1305, 585);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(838, 15);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 61);
            this.Add.TabIndex = 1;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(58, 22);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(172, 20);
            this.nametext.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "company";
            // 
            // companytext
            // 
            this.companytext.Location = new System.Drawing.Point(307, 20);
            this.companytext.Name = "companytext";
            this.companytext.Size = new System.Drawing.Size(172, 20);
            this.companytext.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(574, 7);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(225, 58);
            this.descriptiontxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // salespricetext
            // 
            this.salespricetext.Location = new System.Drawing.Point(58, 71);
            this.salespricetext.Name = "salespricetext";
            this.salespricetext.Size = new System.Drawing.Size(172, 20);
            this.salespricetext.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "salesprice";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Enabled = false;
            this.quantitytxt.Location = new System.Drawing.Point(308, 70);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(172, 20);
            this.quantitytxt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "quantity";
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(974, 15);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(112, 61);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(574, 71);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(225, 20);
            this.searchtxt.TabIndex = 17;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "search";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1310, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salespricetext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.companytext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Products";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private Stock_SystemDataSet stock_SystemDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        //private Stock_SystemDataSetTableAdapters.ProductTableAdapter productTableAdapter;
       
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companytext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salespricetext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productBindingSource1;
       
    }
}

