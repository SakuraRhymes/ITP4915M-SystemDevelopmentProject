namespace SLMCS_ERP.UI.Sales
{
    partial class frmBrowseProduct
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.cboCondition = new System.Windows.Forms.ComboBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.dgvSearchRecord = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddProduct.Location = new System.Drawing.Point(698, 274);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(179, 30);
            this.btnAddProduct.TabIndex = 23;
            this.btnAddProduct.Text = "Add Product To Order";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(403, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 27);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search Product";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCondition.Location = new System.Drawing.Point(243, 16);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(151, 23);
            this.txtCondition.TabIndex = 21;
            // 
            // cboCondition
            // 
            this.cboCondition.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCondition.FormattingEnabled = true;
            this.cboCondition.Items.AddRange(new object[] {
            "ProductID",
            "ProductName",
            "ProductType",
            "ProductUnit",
            "VendorID"});
            this.cboCondition.Location = new System.Drawing.Point(128, 16);
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(109, 24);
            this.cboCondition.TabIndex = 20;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStockQuantity.Location = new System.Drawing.Point(17, 19);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(114, 16);
            this.lblStockQuantity.TabIndex = 19;
            this.lblStockQuantity.Text = "Search Condition : ";
            // 
            // dgvSearchRecord
            // 
            this.dgvSearchRecord.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSearchRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchRecord.Location = new System.Drawing.Point(12, 51);
            this.dgvSearchRecord.Name = "dgvSearchRecord";
            this.dgvSearchRecord.RowTemplate.Height = 24;
            this.dgvSearchRecord.Size = new System.Drawing.Size(867, 207);
            this.dgvSearchRecord.TabIndex = 18;
            this.dgvSearchRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchRecord_CellClick);
            this.dgvSearchRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchRecord_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(586, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 30);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmBrowseProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 408);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.cboCondition);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.dgvSearchRecord);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBrowseProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.ComboBox cboCondition;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.DataGridView dgvSearchRecord;
        private System.Windows.Forms.Button btnClose;
    }
}