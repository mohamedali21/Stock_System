namespace stock.forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPurchaseToolStripMenuItem,
            this.newSalesToolStripMenuItem,
            this.returnsToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newPurchaseToolStripMenuItem
            // 
            this.newPurchaseToolStripMenuItem.Name = "newPurchaseToolStripMenuItem";
            this.newPurchaseToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.newPurchaseToolStripMenuItem.Text = "New Purchase";
            this.newPurchaseToolStripMenuItem.Click += new System.EventHandler(this.newPurchaseToolStripMenuItem_Click);
            // 
            // newSalesToolStripMenuItem
            // 
            this.newSalesToolStripMenuItem.Name = "newSalesToolStripMenuItem";
            this.newSalesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.newSalesToolStripMenuItem.Text = "New Sales";
            this.newSalesToolStripMenuItem.Click += new System.EventHandler(this.newSalesToolStripMenuItem_Click);
            // 
            // returnsToolStripMenuItem
            // 
            this.returnsToolStripMenuItem.Name = "returnsToolStripMenuItem";
            this.returnsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.returnsToolStripMenuItem.Text = "Returns";
            this.returnsToolStripMenuItem.Click += new System.EventHandler(this.returnsToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesReportsToolStripMenuItem,
            this.productsReportsToolStripMenuItem,
            this.purchaseReportsToolStripMenuItem,
            this.salesReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // employeesReportsToolStripMenuItem
            // 
            this.employeesReportsToolStripMenuItem.Name = "employeesReportsToolStripMenuItem";
            this.employeesReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.employeesReportsToolStripMenuItem.Text = "Employees Reports";
            this.employeesReportsToolStripMenuItem.Click += new System.EventHandler(this.employeesReportsToolStripMenuItem_Click);
            // 
            // productsReportsToolStripMenuItem
            // 
            this.productsReportsToolStripMenuItem.Name = "productsReportsToolStripMenuItem";
            this.productsReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.productsReportsToolStripMenuItem.Text = "Products Reports";
            this.productsReportsToolStripMenuItem.Click += new System.EventHandler(this.productsReportsToolStripMenuItem_Click);
            // 
            // purchaseReportsToolStripMenuItem
            // 
            this.purchaseReportsToolStripMenuItem.Name = "purchaseReportsToolStripMenuItem";
            this.purchaseReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.purchaseReportsToolStripMenuItem.Text = "Purchase Reports";
            this.purchaseReportsToolStripMenuItem.Click += new System.EventHandler(this.purchaseReportsToolStripMenuItem_Click);
            // 
            // salesReportsToolStripMenuItem
            // 
            this.salesReportsToolStripMenuItem.Name = "salesReportsToolStripMenuItem";
            this.salesReportsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.salesReportsToolStripMenuItem.Text = "Sales Reports";
            this.salesReportsToolStripMenuItem.Click += new System.EventHandler(this.salesReportsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.attendanceToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 349);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
    }
}