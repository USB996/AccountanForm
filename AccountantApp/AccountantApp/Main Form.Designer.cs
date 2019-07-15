namespace AccountantApp
{
    partial class Main_Form
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
            this.accountant_Data = new System.Windows.Forms.DataGridView();
            this.Date_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_clmn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Price_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellprc_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountant_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // accountant_Data
            // 
            this.accountant_Data.AllowUserToOrderColumns = true;
            this.accountant_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountant_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_clmn,
            this.Product_clmn,
            this.Price_clmn,
            this.Size_clmn,
            this.Percentage_clmn,
            this.sellprc_clmn,
            this.Profit_clmn});
            this.accountant_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountant_Data.Location = new System.Drawing.Point(0, 0);
            this.accountant_Data.Name = "accountant_Data";
            this.accountant_Data.Size = new System.Drawing.Size(744, 647);
            this.accountant_Data.TabIndex = 0;
            this.accountant_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountant_Data_CellContentClick);
            // 
            // Date_clmn
            // 
            this.Date_clmn.HeaderText = "Date/Time";
            this.Date_clmn.Name = "Date_clmn";
            this.Date_clmn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Product_clmn
            // 
            this.Product_clmn.HeaderText = "Product";
            this.Product_clmn.Name = "Product_clmn";
            this.Product_clmn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product_clmn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Price_clmn
            // 
            this.Price_clmn.HeaderText = "Price";
            this.Price_clmn.Name = "Price_clmn";
            // 
            // Size_clmn
            // 
            this.Size_clmn.HeaderText = "Size";
            this.Size_clmn.Name = "Size_clmn";
            // 
            // Percentage_clmn
            // 
            this.Percentage_clmn.HeaderText = "Percentage";
            this.Percentage_clmn.Name = "Percentage_clmn";
            // 
            // sellprc_clmn
            // 
            this.sellprc_clmn.HeaderText = "sell-Price";
            this.sellprc_clmn.Name = "sellprc_clmn";
            // 
            // Profit_clmn
            // 
            this.Profit_clmn.HeaderText = "Profit";
            this.Profit_clmn.Name = "Profit_clmn";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 647);
            this.Controls.Add(this.accountant_Data);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            ((System.ComponentModel.ISupportInitialize)(this.accountant_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountant_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_clmn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellprc_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit_clmn;
    }
}