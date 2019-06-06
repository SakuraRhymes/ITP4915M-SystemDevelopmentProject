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
            this.cboProductStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.dgvStockRecord = new System.Windows.Forms.DataGridView();
            this.gpbProductDetail = new System.Windows.Forms.GroupBox();
            this.lblDVendorIDData = new System.Windows.Forms.Label();
            this.vedorid = new System.Windows.Forms.Label();
            this.lblDProductStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDangerLevel = new System.Windows.Forms.Button();
            this.btnReorderLevel = new System.Windows.Forms.Button();
            this.lblDDangerLevelData = new System.Windows.Forms.Label();
            this.lblDReorderLevelData = new System.Windows.Forms.Label();
            this.lblDActualQtyData = new System.Windows.Forms.Label();
            this.lblDProductPriceData = new System.Windows.Forms.Label();
            this.lblDProductUnitData = new System.Windows.Forms.Label();
            this.lblDProductNameData = new System.Windows.Forms.Label();
            this.lblDProductDescData = new System.Windows.Forms.Label();
            this.lblDProductTypeData = new System.Windows.Forms.Label();
            this.lblDangerLevel = new System.Windows.Forms.Label();
            this.lblDProductIDData = new System.Windows.Forms.Label();
            this.lvlReorderLevel = new System.Windows.Forms.Label();
            this.lblActualQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblDProductType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRecord)).BeginInit();
            this.gpbProductDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(35, 29);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(73, 16);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID :";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(20, 65);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(89, 16);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Product Type :";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(13, 100);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(99, 16);
            this.lblStockQuantity.TabIndex = 2;
            this.lblStockQuantity.Text = "Stock Quantity : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(16, 189);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(552, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // gpbCondition
            // 
            this.gpbCondition.Controls.Add(this.cboProductStatus);
            this.gpbCondition.Controls.Add(this.label5);
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
            this.gpbCondition.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbCondition.Location = new System.Drawing.Point(12, 12);
            this.gpbCondition.Name = "gpbCondition";
            this.gpbCondition.Size = new System.Drawing.Size(584, 235);
            this.gpbCondition.TabIndex = 4;
            this.gpbCondition.TabStop = false;
            this.gpbCondition.Text = "Search Condition";
            // 
            // cboProductStatus
            // 
            this.cboProductStatus.FormattingEnabled = true;
            this.cboProductStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cboProductStatus.Location = new System.Drawing.Point(412, 132);
            this.cboProductStatus.Name = "cboProductStatus";
            this.cboProductStatus.Size = new System.Drawing.Size(156, 24);
            this.cboProductStatus.TabIndex = 18;
            this.cboProductStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboProductStatus_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Product Status :";
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Items.AddRange(new object[] {
            "piece",
            "item",
            "set"});
            this.cboProductUnit.Location = new System.Drawing.Point(412, 62);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(156, 24);
            this.cboProductUnit.TabIndex = 16;
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(324, 66);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(84, 16);
            this.lblProductUnit.TabIndex = 15;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(412, 97);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(156, 23);
            this.txtVendorID.TabIndex = 14;
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(337, 100);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(71, 16);
            this.lblVendorID.TabIndex = 13;
            this.lblVendorID.Text = "Vendor ID :";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(198, 133);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 23);
            this.txtProductPrice.TabIndex = 12;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductPrice_KeyPress);
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new System.Drawing.Point(198, 97);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtStockQuantity.TabIndex = 11;
            this.txtStockQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockQuantity_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(412, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(156, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProductName_KeyDown);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(112, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(186, 23);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProductID_KeyDown);
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
            this.cboProductPrice.Location = new System.Drawing.Point(112, 133);
            this.cboProductPrice.Name = "cboProductPrice";
            this.cboProductPrice.Size = new System.Drawing.Size(80, 24);
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
            this.cboStockQuantity.Location = new System.Drawing.Point(112, 97);
            this.cboStockQuantity.Name = "cboStockQuantity";
            this.cboStockQuantity.Size = new System.Drawing.Size(80, 24);
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
            this.cboProductType.Location = new System.Drawing.Point(112, 62);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(186, 24);
            this.cboProductType.TabIndex = 6;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(20, 137);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(88, 16);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Product Price :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(313, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 16);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name :";
            // 
            // dgvStockRecord
            // 
            this.dgvStockRecord.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStockRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRecord.Location = new System.Drawing.Point(12, 253);
            this.dgvStockRecord.Name = "dgvStockRecord";
            this.dgvStockRecord.RowTemplate.Height = 24;
            this.dgvStockRecord.Size = new System.Drawing.Size(584, 277);
            this.dgvStockRecord.TabIndex = 8;
            this.dgvStockRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockRecord_CellClick);
            // 
            // gpbProductDetail
            // 
            this.gpbProductDetail.Controls.Add(this.lblDVendorIDData);
            this.gpbProductDetail.Controls.Add(this.vedorid);
            this.gpbProductDetail.Controls.Add(this.lblDProductStatus);
            this.gpbProductDetail.Controls.Add(this.label6);
            this.gpbProductDetail.Controls.Add(this.btnDangerLevel);
            this.gpbProductDetail.Controls.Add(this.btnReorderLevel);
            this.gpbProductDetail.Controls.Add(this.lblDDangerLevelData);
            this.gpbProductDetail.Controls.Add(this.lblDReorderLevelData);
            this.gpbProductDetail.Controls.Add(this.lblDActualQtyData);
            this.gpbProductDetail.Controls.Add(this.lblDProductPriceData);
            this.gpbProductDetail.Controls.Add(this.lblDProductUnitData);
            this.gpbProductDetail.Controls.Add(this.lblDProductNameData);
            this.gpbProductDetail.Controls.Add(this.lblDProductDescData);
            this.gpbProductDetail.Controls.Add(this.lblDProductTypeData);
            this.gpbProductDetail.Controls.Add(this.lblDangerLevel);
            this.gpbProductDetail.Controls.Add(this.lblDProductIDData);
            this.gpbProductDetail.Controls.Add(this.lvlReorderLevel);
            this.gpbProductDetail.Controls.Add(this.lblActualQty);
            this.gpbProductDetail.Controls.Add(this.label1);
            this.gpbProductDetail.Controls.Add(this.label2);
            this.gpbProductDetail.Controls.Add(this.lblProductDesc);
            this.gpbProductDetail.Controls.Add(this.lblDProductType);
            this.gpbProductDetail.Controls.Add(this.label3);
            this.gpbProductDetail.Controls.Add(this.label4);
            this.gpbProductDetail.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbProductDetail.Location = new System.Drawing.Point(602, 12);
            this.gpbProductDetail.Name = "gpbProductDetail";
            this.gpbProductDetail.Size = new System.Drawing.Size(414, 518);
            this.gpbProductDetail.TabIndex = 9;
            this.gpbProductDetail.TabStop = false;
            this.gpbProductDetail.Text = "Product Detail";
            // 
            // lblDVendorIDData
            // 
            this.lblDVendorIDData.AutoSize = true;
            this.lblDVendorIDData.Location = new System.Drawing.Point(128, 131);
            this.lblDVendorIDData.Name = "lblDVendorIDData";
            this.lblDVendorIDData.Size = new System.Drawing.Size(48, 16);
            this.lblDVendorIDData.TabIndex = 55;
            this.lblDVendorIDData.Text = "XXXXX";
            // 
            // vedorid
            // 
            this.vedorid.AutoSize = true;
            this.vedorid.Location = new System.Drawing.Point(48, 131);
            this.vedorid.Name = "vedorid";
            this.vedorid.Size = new System.Drawing.Size(71, 16);
            this.vedorid.TabIndex = 54;
            this.vedorid.Text = "Vendor ID :";
            // 
            // lblDProductStatus
            // 
            this.lblDProductStatus.AutoSize = true;
            this.lblDProductStatus.Location = new System.Drawing.Point(331, 237);
            this.lblDProductStatus.Name = "lblDProductStatus";
            this.lblDProductStatus.Size = new System.Drawing.Size(50, 16);
            this.lblDProductStatus.TabIndex = 53;
            this.lblDProductStatus.Text = "label11";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Product Status :";
            // 
            // btnDangerLevel
            // 
            this.btnDangerLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDangerLevel.Location = new System.Drawing.Point(221, 368);
            this.btnDangerLevel.Name = "btnDangerLevel";
            this.btnDangerLevel.Size = new System.Drawing.Size(150, 30);
            this.btnDangerLevel.TabIndex = 51;
            this.btnDangerLevel.Text = "Set Danger Level";
            this.btnDangerLevel.UseVisualStyleBackColor = true;
            this.btnDangerLevel.Click += new System.EventHandler(this.BtnDangerLevel_Click);
            // 
            // btnReorderLevel
            // 
            this.btnReorderLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReorderLevel.Location = new System.Drawing.Point(33, 368);
            this.btnReorderLevel.Name = "btnReorderLevel";
            this.btnReorderLevel.Size = new System.Drawing.Size(150, 30);
            this.btnReorderLevel.TabIndex = 17;
            this.btnReorderLevel.Text = "Set Reorder Level";
            this.btnReorderLevel.UseVisualStyleBackColor = true;
            this.btnReorderLevel.Click += new System.EventHandler(this.BtnReorderLevel_Click);
            // 
            // lblDDangerLevelData
            // 
            this.lblDDangerLevelData.AutoSize = true;
            this.lblDDangerLevelData.Location = new System.Drawing.Point(128, 308);
            this.lblDDangerLevelData.Name = "lblDDangerLevelData";
            this.lblDDangerLevelData.Size = new System.Drawing.Size(50, 16);
            this.lblDDangerLevelData.TabIndex = 48;
            this.lblDDangerLevelData.Text = "label11";
            // 
            // lblDReorderLevelData
            // 
            this.lblDReorderLevelData.AutoSize = true;
            this.lblDReorderLevelData.Location = new System.Drawing.Point(128, 272);
            this.lblDReorderLevelData.Name = "lblDReorderLevelData";
            this.lblDReorderLevelData.Size = new System.Drawing.Size(50, 16);
            this.lblDReorderLevelData.TabIndex = 47;
            this.lblDReorderLevelData.Text = "label10";
            // 
            // lblDActualQtyData
            // 
            this.lblDActualQtyData.AutoSize = true;
            this.lblDActualQtyData.Location = new System.Drawing.Point(128, 237);
            this.lblDActualQtyData.Name = "lblDActualQtyData";
            this.lblDActualQtyData.Size = new System.Drawing.Size(43, 16);
            this.lblDActualQtyData.TabIndex = 46;
            this.lblDActualQtyData.Text = "label9";
            // 
            // lblDProductPriceData
            // 
            this.lblDProductPriceData.AutoSize = true;
            this.lblDProductPriceData.Location = new System.Drawing.Point(331, 201);
            this.lblDProductPriceData.Name = "lblDProductPriceData";
            this.lblDProductPriceData.Size = new System.Drawing.Size(43, 16);
            this.lblDProductPriceData.TabIndex = 45;
            this.lblDProductPriceData.Text = "label8";
            // 
            // lblDProductUnitData
            // 
            this.lblDProductUnitData.AutoSize = true;
            this.lblDProductUnitData.Location = new System.Drawing.Point(128, 201);
            this.lblDProductUnitData.Name = "lblDProductUnitData";
            this.lblDProductUnitData.Size = new System.Drawing.Size(43, 16);
            this.lblDProductUnitData.TabIndex = 44;
            this.lblDProductUnitData.Text = "label7";
            // 
            // lblDProductNameData
            // 
            this.lblDProductNameData.AutoSize = true;
            this.lblDProductNameData.Location = new System.Drawing.Point(127, 99);
            this.lblDProductNameData.Name = "lblDProductNameData";
            this.lblDProductNameData.Size = new System.Drawing.Size(43, 16);
            this.lblDProductNameData.TabIndex = 43;
            this.lblDProductNameData.Text = "label6";
            // 
            // lblDProductDescData
            // 
            this.lblDProductDescData.Location = new System.Drawing.Point(237, 62);
            this.lblDProductDescData.Name = "lblDProductDescData";
            this.lblDProductDescData.Size = new System.Drawing.Size(167, 86);
            this.lblDProductDescData.TabIndex = 42;
            this.lblDProductDescData.Text = "label5";
            // 
            // lblDProductTypeData
            // 
            this.lblDProductTypeData.AutoSize = true;
            this.lblDProductTypeData.Location = new System.Drawing.Point(127, 66);
            this.lblDProductTypeData.Name = "lblDProductTypeData";
            this.lblDProductTypeData.Size = new System.Drawing.Size(48, 16);
            this.lblDProductTypeData.TabIndex = 41;
            this.lblDProductTypeData.Text = "XXXXX";
            // 
            // lblDangerLevel
            // 
            this.lblDangerLevel.AutoSize = true;
            this.lblDangerLevel.Location = new System.Drawing.Point(28, 308);
            this.lblDangerLevel.Name = "lblDangerLevel";
            this.lblDangerLevel.Size = new System.Drawing.Size(91, 16);
            this.lblDangerLevel.TabIndex = 39;
            this.lblDangerLevel.Text = "Danger Level  :";
            // 
            // lblDProductIDData
            // 
            this.lblDProductIDData.AutoSize = true;
            this.lblDProductIDData.Location = new System.Drawing.Point(127, 37);
            this.lblDProductIDData.Name = "lblDProductIDData";
            this.lblDProductIDData.Size = new System.Drawing.Size(48, 16);
            this.lblDProductIDData.TabIndex = 38;
            this.lblDProductIDData.Text = "XXXXX";
            // 
            // lvlReorderLevel
            // 
            this.lvlReorderLevel.AutoSize = true;
            this.lvlReorderLevel.Location = new System.Drawing.Point(27, 272);
            this.lvlReorderLevel.Name = "lvlReorderLevel";
            this.lvlReorderLevel.Size = new System.Drawing.Size(92, 16);
            this.lvlReorderLevel.TabIndex = 31;
            this.lvlReorderLevel.Text = "Reorder Level :";
            // 
            // lblActualQty
            // 
            this.lblActualQty.AutoSize = true;
            this.lblActualQty.Location = new System.Drawing.Point(19, 237);
            this.lblActualQty.Name = "lblActualQty";
            this.lblActualQty.Size = new System.Drawing.Size(100, 16);
            this.lblActualQty.TabIndex = 30;
            this.lblActualQty.Text = "Actual Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Product Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Product Unit :";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(237, 34);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(125, 16);
            this.lblProductDesc.TabIndex = 27;
            this.lblProductDesc.Text = "Product Description :";
            // 
            // lblDProductType
            // 
            this.lblDProductType.AutoSize = true;
            this.lblDProductType.Location = new System.Drawing.Point(30, 66);
            this.lblDProductType.Name = "lblDProductType";
            this.lblDProductType.Size = new System.Drawing.Size(89, 16);
            this.lblDProductType.TabIndex = 26;
            this.lblDProductType.Text = "Product Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Product ID :";
            // 
            // frmInventoryStockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.gpbProductDetail);
            this.Controls.Add(this.dgvStockRecord);
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
        private System.Windows.Forms.DataGridView dgvStockRecord;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.GroupBox gpbProductDetail;
        private System.Windows.Forms.Label lblDProductTypeData;
        private System.Windows.Forms.Label lblDangerLevel;
        private System.Windows.Forms.Label lblDProductIDData;
        private System.Windows.Forms.Label lvlReorderLevel;
        private System.Windows.Forms.Label lblActualQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblDProductType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDDangerLevelData;
        private System.Windows.Forms.Label lblDReorderLevelData;
        private System.Windows.Forms.Label lblDActualQtyData;
        private System.Windows.Forms.Label lblDProductPriceData;
        private System.Windows.Forms.Label lblDProductUnitData;
        private System.Windows.Forms.Label lblDProductNameData;
        private System.Windows.Forms.Label lblDProductDescData;
        private System.Windows.Forms.Button btnDangerLevel;
        private System.Windows.Forms.Button btnReorderLevel;
        private System.Windows.Forms.Label lblDProductStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDVendorIDData;
        private System.Windows.Forms.Label vedorid;
        private System.Windows.Forms.ComboBox cboProductStatus;
        private System.Windows.Forms.Label label5;
    }
}