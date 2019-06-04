namespace SLMCS_ERP
{
    partial class frmInventoryStockRecord
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gpbCondition = new System.Windows.Forms.GroupBox();
            this.cboProductUnit = new System.Windows.Forms.ComboBox();
            this.lblProductUnit = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.cboProductPrice = new System.Windows.Forms.ComboBox();
            this.cboStockQuantity = new System.Windows.Forms.ComboBox();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.dgvStockRecord = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbProductDetail = new System.Windows.Forms.GroupBox();
            this.lblDProductTypeData = new System.Windows.Forms.Label();
            this.txtDDangerLevel = new System.Windows.Forms.TextBox();
            this.lblDDangerLevel = new System.Windows.Forms.Label();
            this.lblDProductIDData = new System.Windows.Forms.Label();
            this.rtbDProductDesc = new System.Windows.Forms.RichTextBox();
            this.cboDProductUnit = new System.Windows.Forms.ComboBox();
            this.txtDReorderLevel = new System.Windows.Forms.TextBox();
            this.txtDActualQty = new System.Windows.Forms.TextBox();
            this.txtDProductPrice = new System.Windows.Forms.TextBox();
            this.txtDProductName = new System.Windows.Forms.TextBox();
            this.lblDReorderLevel = new System.Windows.Forms.Label();
            this.lblDActualQty = new System.Windows.Forms.Label();
            this.lblDProductPrice = new System.Windows.Forms.Label();
            this.lblDProductUnit = new System.Windows.Forms.Label();
            this.lblDProductDesc = new System.Windows.Forms.Label();
            this.lblDProductType = new System.Windows.Forms.Label();
            this.lblDProdcutName = new System.Windows.Forms.Label();
            this.lblDProductID = new System.Windows.Forms.Label();
            this.gpbCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRecord)).BeginInit();
            this.gpbProductDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(32, 29);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(62, 12);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID :";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(20, 62);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 12);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Product Type :";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(13, 94);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(83, 12);
            this.lblStockQuantity.TabIndex = 2;
            this.lblStockQuantity.Text = "Stock Quantity : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(481, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // gpbCondition
            // 
            this.gpbCondition.Controls.Add(this.cboProductUnit);
            this.gpbCondition.Controls.Add(this.lblProductUnit);
            this.gpbCondition.Controls.Add(this.txtVendorID);
            this.gpbCondition.Controls.Add(this.lblVendorID);
            this.gpbCondition.Controls.Add(this.txtProductPrice);
            this.gpbCondition.Controls.Add(this.txtStockQuantity);
            this.gpbCondition.Controls.Add(this.txtProductName);
            this.gpbCondition.Controls.Add(this.txtProductID);
            this.gpbCondition.Controls.Add(this.cboProductPrice);
            this.gpbCondition.Controls.Add(this.cboStockQuantity);
            this.gpbCondition.Controls.Add(this.cboProductType);
            this.gpbCondition.Controls.Add(this.lblProductPrice);
            this.gpbCondition.Controls.Add(this.lblProductName);
            this.gpbCondition.Controls.Add(this.btnSearch);
            this.gpbCondition.Controls.Add(this.lblStockQuantity);
            this.gpbCondition.Controls.Add(this.lblProductID);
            this.gpbCondition.Controls.Add(this.lblProductType);
            this.gpbCondition.Location = new System.Drawing.Point(12, 12);
            this.gpbCondition.Name = "gpbCondition";
            this.gpbCondition.Size = new System.Drawing.Size(517, 182);
            this.gpbCondition.TabIndex = 4;
            this.gpbCondition.TabStop = false;
            this.gpbCondition.Text = "Condition";
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Items.AddRange(new object[] {
            "piece",
            "item",
            "set"});
            this.cboProductUnit.Location = new System.Drawing.Point(368, 59);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(135, 20);
            this.cboProductUnit.TabIndex = 16;
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(292, 62);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(70, 12);
            this.lblProductUnit.TabIndex = 15;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(368, 91);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(135, 22);
            this.txtVendorID.TabIndex = 14;
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(301, 94);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(61, 12);
            this.lblVendorID.TabIndex = 13;
            this.lblVendorID.Text = "Vendor ID :";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(186, 119);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 12;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new System.Drawing.Point(186, 91);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtStockQuantity.TabIndex = 11;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(368, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(135, 22);
            this.txtProductName.TabIndex = 10;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(100, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(131, 22);
            this.txtProductID.TabIndex = 9;
            // 
            // cboProductPrice
            // 
            this.cboProductPrice.FormattingEnabled = true;
            this.cboProductPrice.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<=",
            "="});
            this.cboProductPrice.Location = new System.Drawing.Point(100, 119);
            this.cboProductPrice.Name = "cboProductPrice";
            this.cboProductPrice.Size = new System.Drawing.Size(68, 20);
            this.cboProductPrice.TabIndex = 8;
            // 
            // cboStockQuantity
            // 
            this.cboStockQuantity.FormattingEnabled = true;
            this.cboStockQuantity.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<=",
            "="});
            this.cboStockQuantity.Location = new System.Drawing.Point(100, 91);
            this.cboStockQuantity.Name = "cboStockQuantity";
            this.cboStockQuantity.Size = new System.Drawing.Size(68, 20);
            this.cboStockQuantity.TabIndex = 7;
            // 
            // cboProductType
            // 
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Items.AddRange(new object[] {
            "Sheet Metal",
            "Major Assemblies",
            "Light Components",
            "Accessories"});
            this.cboProductType.Location = new System.Drawing.Point(100, 59);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(131, 20);
            this.cboProductType.TabIndex = 6;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(20, 123);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(73, 12);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Product Price :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(285, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(77, 12);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name :";
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(141, 194);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(81, 23);
            this.btnNewProduct.TabIndex = 5;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.BtnNewProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(242, 195);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(81, 23);
            this.btnEditProduct.TabIndex = 6;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(348, 195);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(81, 23);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // dgvStockRecord
            // 
            this.dgvStockRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRecord.Location = new System.Drawing.Point(12, 224);
            this.dgvStockRecord.Name = "dgvStockRecord";
            this.dgvStockRecord.RowTemplate.Height = 24;
            this.dgvStockRecord.Size = new System.Drawing.Size(517, 331);
            this.dgvStockRecord.TabIndex = 8;
            this.dgvStockRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockRecord_CellClick);
            this.dgvStockRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockRecord_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product List";
            // 
            // gpbProductDetail
            // 
            this.gpbProductDetail.Controls.Add(this.lblDProductTypeData);
            this.gpbProductDetail.Controls.Add(this.txtDDangerLevel);
            this.gpbProductDetail.Controls.Add(this.lblDDangerLevel);
            this.gpbProductDetail.Controls.Add(this.lblDProductIDData);
            this.gpbProductDetail.Controls.Add(this.rtbDProductDesc);
            this.gpbProductDetail.Controls.Add(this.cboDProductUnit);
            this.gpbProductDetail.Controls.Add(this.txtDReorderLevel);
            this.gpbProductDetail.Controls.Add(this.txtDActualQty);
            this.gpbProductDetail.Controls.Add(this.txtDProductPrice);
            this.gpbProductDetail.Controls.Add(this.txtDProductName);
            this.gpbProductDetail.Controls.Add(this.lblDReorderLevel);
            this.gpbProductDetail.Controls.Add(this.lblDActualQty);
            this.gpbProductDetail.Controls.Add(this.lblDProductPrice);
            this.gpbProductDetail.Controls.Add(this.lblDProductUnit);
            this.gpbProductDetail.Controls.Add(this.lblDProductDesc);
            this.gpbProductDetail.Controls.Add(this.lblDProductType);
            this.gpbProductDetail.Controls.Add(this.lblDProdcutName);
            this.gpbProductDetail.Controls.Add(this.lblDProductID);
            this.gpbProductDetail.Location = new System.Drawing.Point(554, 85);
            this.gpbProductDetail.Name = "gpbProductDetail";
            this.gpbProductDetail.Size = new System.Drawing.Size(344, 390);
            this.gpbProductDetail.TabIndex = 10;
            this.gpbProductDetail.TabStop = false;
            this.gpbProductDetail.Text = "Product Detail";
            // 
            // lblDProductTypeData
            // 
            this.lblDProductTypeData.AutoSize = true;
            this.lblDProductTypeData.Location = new System.Drawing.Point(115, 80);
            this.lblDProductTypeData.Name = "lblDProductTypeData";
            this.lblDProductTypeData.Size = new System.Drawing.Size(45, 12);
            this.lblDProductTypeData.TabIndex = 41;
            this.lblDProductTypeData.Text = "XXXXX";
            // 
            // txtDDangerLevel
            // 
            this.txtDDangerLevel.Location = new System.Drawing.Point(115, 343);
            this.txtDDangerLevel.Name = "txtDDangerLevel";
            this.txtDDangerLevel.Size = new System.Drawing.Size(100, 22);
            this.txtDDangerLevel.TabIndex = 40;
            // 
            // lblDDangerLevel
            // 
            this.lblDDangerLevel.AutoSize = true;
            this.lblDDangerLevel.Location = new System.Drawing.Point(31, 346);
            this.lblDDangerLevel.Name = "lblDDangerLevel";
            this.lblDDangerLevel.Size = new System.Drawing.Size(77, 12);
            this.lblDDangerLevel.TabIndex = 39;
            this.lblDDangerLevel.Text = "Danger Level  :";
            // 
            // lblDProductIDData
            // 
            this.lblDProductIDData.AutoSize = true;
            this.lblDProductIDData.Location = new System.Drawing.Point(115, 48);
            this.lblDProductIDData.Name = "lblDProductIDData";
            this.lblDProductIDData.Size = new System.Drawing.Size(45, 12);
            this.lblDProductIDData.TabIndex = 38;
            this.lblDProductIDData.Text = "XXXXX";
            // 
            // rtbDProductDesc
            // 
            this.rtbDProductDesc.Location = new System.Drawing.Point(115, 140);
            this.rtbDProductDesc.Name = "rtbDProductDesc";
            this.rtbDProductDesc.Size = new System.Drawing.Size(219, 65);
            this.rtbDProductDesc.TabIndex = 37;
            this.rtbDProductDesc.Text = "";
            // 
            // cboDProductUnit
            // 
            this.cboDProductUnit.FormattingEnabled = true;
            this.cboDProductUnit.Items.AddRange(new object[] {
            "piece",
            "item",
            "set"});
            this.cboDProductUnit.Location = new System.Drawing.Point(115, 219);
            this.cboDProductUnit.Name = "cboDProductUnit";
            this.cboDProductUnit.Size = new System.Drawing.Size(100, 20);
            this.cboDProductUnit.TabIndex = 36;
            // 
            // txtDReorderLevel
            // 
            this.txtDReorderLevel.Location = new System.Drawing.Point(115, 312);
            this.txtDReorderLevel.Name = "txtDReorderLevel";
            this.txtDReorderLevel.Size = new System.Drawing.Size(100, 22);
            this.txtDReorderLevel.TabIndex = 35;
            // 
            // txtDActualQty
            // 
            this.txtDActualQty.Location = new System.Drawing.Point(115, 281);
            this.txtDActualQty.Name = "txtDActualQty";
            this.txtDActualQty.Size = new System.Drawing.Size(100, 22);
            this.txtDActualQty.TabIndex = 34;
            // 
            // txtDProductPrice
            // 
            this.txtDProductPrice.Location = new System.Drawing.Point(115, 251);
            this.txtDProductPrice.Name = "txtDProductPrice";
            this.txtDProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtDProductPrice.TabIndex = 33;
            // 
            // txtDProductName
            // 
            this.txtDProductName.Location = new System.Drawing.Point(115, 107);
            this.txtDProductName.Name = "txtDProductName";
            this.txtDProductName.Size = new System.Drawing.Size(219, 22);
            this.txtDProductName.TabIndex = 32;
            // 
            // lblDReorderLevel
            // 
            this.lblDReorderLevel.AutoSize = true;
            this.lblDReorderLevel.Location = new System.Drawing.Point(31, 315);
            this.lblDReorderLevel.Name = "lblDReorderLevel";
            this.lblDReorderLevel.Size = new System.Drawing.Size(78, 12);
            this.lblDReorderLevel.TabIndex = 31;
            this.lblDReorderLevel.Text = "Reorder Level :";
            // 
            // lblDActualQty
            // 
            this.lblDActualQty.AutoSize = true;
            this.lblDActualQty.Location = new System.Drawing.Point(25, 284);
            this.lblDActualQty.Name = "lblDActualQty";
            this.lblDActualQty.Size = new System.Drawing.Size(84, 12);
            this.lblDActualQty.TabIndex = 30;
            this.lblDActualQty.Text = "Actual Quantity :";
            // 
            // lblDProductPrice
            // 
            this.lblDProductPrice.AutoSize = true;
            this.lblDProductPrice.Location = new System.Drawing.Point(36, 254);
            this.lblDProductPrice.Name = "lblDProductPrice";
            this.lblDProductPrice.Size = new System.Drawing.Size(73, 12);
            this.lblDProductPrice.TabIndex = 29;
            this.lblDProductPrice.Text = "Product Price :";
            // 
            // lblDProductUnit
            // 
            this.lblDProductUnit.AutoSize = true;
            this.lblDProductUnit.Location = new System.Drawing.Point(39, 222);
            this.lblDProductUnit.Name = "lblDProductUnit";
            this.lblDProductUnit.Size = new System.Drawing.Size(70, 12);
            this.lblDProductUnit.TabIndex = 28;
            this.lblDProductUnit.Text = "Product Unit :";
            // 
            // lblDProductDesc
            // 
            this.lblDProductDesc.AutoSize = true;
            this.lblDProductDesc.Location = new System.Drawing.Point(6, 140);
            this.lblDProductDesc.Name = "lblDProductDesc";
            this.lblDProductDesc.Size = new System.Drawing.Size(103, 12);
            this.lblDProductDesc.TabIndex = 27;
            this.lblDProductDesc.Text = "Product Description :";
            // 
            // lblDProductType
            // 
            this.lblDProductType.AutoSize = true;
            this.lblDProductType.Location = new System.Drawing.Point(35, 80);
            this.lblDProductType.Name = "lblDProductType";
            this.lblDProductType.Size = new System.Drawing.Size(74, 12);
            this.lblDProductType.TabIndex = 26;
            this.lblDProductType.Text = "Product Type :";
            // 
            // lblDProdcutName
            // 
            this.lblDProdcutName.AutoSize = true;
            this.lblDProdcutName.Location = new System.Drawing.Point(32, 110);
            this.lblDProdcutName.Name = "lblDProdcutName";
            this.lblDProdcutName.Size = new System.Drawing.Size(77, 12);
            this.lblDProdcutName.TabIndex = 25;
            this.lblDProdcutName.Text = "Product Name :";
            // 
            // lblDProductID
            // 
            this.lblDProductID.AutoSize = true;
            this.lblDProductID.Location = new System.Drawing.Point(47, 48);
            this.lblDProductID.Name = "lblDProductID";
            this.lblDProductID.Size = new System.Drawing.Size(62, 12);
            this.lblDProductID.TabIndex = 24;
            this.lblDProductID.Text = "Product ID :";
            // 
            // frmInventoryStockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 567);
            this.Controls.Add(this.gpbProductDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStockRecord);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.gpbCondition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryStockRecord";
            this.Text = "frmInventoryStockRecord";
            this.Load += new System.EventHandler(this.FrmInventoryStockRecord_Load);
            this.gpbCondition.ResumeLayout(false);
            this.gpbCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRecord)).EndInit();
            this.gpbProductDetail.ResumeLayout(false);
            this.gpbProductDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gpbCondition;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.ComboBox cboProductPrice;
        private System.Windows.Forms.ComboBox cboStockQuantity;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridView dgvStockRecord;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbProductDetail;
        private System.Windows.Forms.Label lblDProductTypeData;
        private System.Windows.Forms.TextBox txtDDangerLevel;
        private System.Windows.Forms.Label lblDDangerLevel;
        private System.Windows.Forms.Label lblDProductIDData;
        private System.Windows.Forms.RichTextBox rtbDProductDesc;
        private System.Windows.Forms.ComboBox cboDProductUnit;
        private System.Windows.Forms.TextBox txtDReorderLevel;
        private System.Windows.Forms.TextBox txtDActualQty;
        private System.Windows.Forms.TextBox txtDProductPrice;
        private System.Windows.Forms.TextBox txtDProductName;
        private System.Windows.Forms.Label lblDReorderLevel;
        private System.Windows.Forms.Label lblDActualQty;
        private System.Windows.Forms.Label lblDProductPrice;
        private System.Windows.Forms.Label lblDProductUnit;
        private System.Windows.Forms.Label lblDProductDesc;
        private System.Windows.Forms.Label lblDProductType;
        private System.Windows.Forms.Label lblDProdcutName;
        private System.Windows.Forms.Label lblDProductID;
    }
}