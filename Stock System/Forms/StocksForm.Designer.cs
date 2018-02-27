namespace Stock_System
{
    partial class StocksForm
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
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.lcationLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(74, 13);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(173, 20);
            this.locationTextBox.TabIndex = 0;
            // 
            // lcationLabel
            // 
            this.lcationLabel.AutoSize = true;
            this.lcationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcationLabel.Location = new System.Drawing.Point(12, 16);
            this.lcationLabel.Name = "lcationLabel";
            this.lcationLabel.Size = new System.Drawing.Size(56, 13);
            this.lcationLabel.TabIndex = 1;
            this.lcationLabel.Text = "Location";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(15, 46);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(43, 13);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(74, 43);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(173, 20);
            this.phoneTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(264, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 50);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(400, 13);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(114, 50);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Location = new System.Drawing.Point(15, 69);
            this.stockDataGridView.MultiSelect = false;
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(499, 269);
            this.stockDataGridView.TabIndex = 7;
            this.stockDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.stockDataGridView_DataBindingComplete);
            this.stockDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stockDataGridView_MouseClick);
            // 
            // StocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 350);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lcationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Name = "StocksForm";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label lcationLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView stockDataGridView;
    }
}