namespace SLMCS_ERP
{
    partial class frmInventoryReorderProduct
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
            this.dgvSearchRecord = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDangerLevel = new System.Windows.Forms.Button();
            this.btnReorderLevel = new System.Windows.Forms.Button();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.cboCondition = new System.Windows.Forms.ComboBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvReorderOrder = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblReorderOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchRecord
            // 
            this.dgvSearchRecord.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSearchRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchRecord.Location = new System.Drawing.Point(20, 53);
            this.dgvSearchRecord.Name = "dgvSearchRecord";
            this.dgvSearchRecord.RowTemplate.Height = 24;
            this.dgvSearchRecord.Size = new System.Drawing.Size(867, 224);
            this.dgvSearchRecord.TabIndex = 0;
            this.dgvSearchRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchRecord_CellClick);
            this.dgvSearchRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchRecord_CellDoubleClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(723, 572);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(159, 33);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Place Reorder Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(583, 572);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDangerLevel
            // 
            this.btnDangerLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDangerLevel.Location = new System.Drawing.Point(714, 12);
            this.btnDangerLevel.Name = "btnDangerLevel";
            this.btnDangerLevel.Size = new System.Drawing.Size(170, 29);
            this.btnDangerLevel.TabIndex = 4;
            this.btnDangerLevel.Text = "Show All Danger Level Product";
            this.btnDangerLevel.UseVisualStyleBackColor = true;
            this.btnDangerLevel.Click += new System.EventHandler(this.BtnDangerLevel_Click);
            // 
            // btnReorderLevel
            // 
            this.btnReorderLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReorderLevel.Location = new System.Drawing.Point(523, 12);
            this.btnReorderLevel.Name = "btnReorderLevel";
            this.btnReorderLevel.Size = new System.Drawing.Size(170, 29);
            this.btnReorderLevel.TabIndex = 5;
            this.btnReorderLevel.Text = "Show All Reorder Level Product";
            this.btnReorderLevel.UseVisualStyleBackColor = true;
            this.btnReorderLevel.Click += new System.EventHandler(this.BtnReorderLevel_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCondition.Location = new System.Drawing.Point(210, 13);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(151, 23);
            this.txtCondition.TabIndex = 14;
            this.txtCondition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCondition_KeyDown);
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
            this.cboCondition.Location = new System.Drawing.Point(95, 13);
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(109, 24);
            this.cboCondition.TabIndex = 13;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStockQuantity.Location = new System.Drawing.Point(25, 18);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(73, 16);
            this.lblStockQuantity.TabIndex = 12;
            this.lblStockQuantity.Text = "Condition : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(370, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 29);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvReorderOrder
            // 
            this.dgvReorderOrder.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReorderOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReorderOrder.Location = new System.Drawing.Point(19, 347);
            this.dgvReorderOrder.Name = "dgvReorderOrder";
            this.dgvReorderOrder.RowTemplate.Height = 24;
            this.dgvReorderOrder.Size = new System.Drawing.Size(866, 213);
            this.dgvReorderOrder.TabIndex = 16;
            this.dgvReorderOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReorderOrder_CellClick);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddProduct.Location = new System.Drawing.Point(706, 295);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(179, 33);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "Add Product To Reorder";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // lblReorderOrderID
            // 
            this.lblReorderOrderID.AutoSize = true;
            this.lblReorderOrderID.Font = new System.Drawing.Font("Microsoft JhengHei", 11F);
            this.lblReorderOrderID.Location = new System.Drawing.Point(19, 324);
            this.lblReorderOrderID.Name = "lblReorderOrderID";
            this.lblReorderOrderID.Size = new System.Drawing.Size(119, 19);
            this.lblReorderOrderID.TabIndex = 19;
            this.lblReorderOrderID.Text = "Reorder Order :";
            // 
            // frmInventoryReorderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 613);
            this.Controls.Add(this.lblReorderOrderID);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvReorderOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.cboCondition);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.btnReorderLevel);
            this.Controls.Add(this.btnDangerLevel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvSearchRecord);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryReorderProduct";
            this.Text = "frmInventoryReorderProduct";
            this.Load += new System.EventHandler(this.FrmInventoryReorderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchRecord;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDangerLevel;
        private System.Windows.Forms.Button btnReorderLevel;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.ComboBox cboCondition;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvReorderOrder;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblReorderOrderID;
    }
}