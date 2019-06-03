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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteProdcut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchRecord
            // 
            this.dgvSearchRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchRecord.Location = new System.Drawing.Point(11, 36);
            this.dgvSearchRecord.Name = "dgvSearchRecord";
            this.dgvSearchRecord.RowTemplate.Height = 24;
            this.dgvSearchRecord.Size = new System.Drawing.Size(813, 207);
            this.dgvSearchRecord.TabIndex = 0;
            this.dgvSearchRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchRecord_CellDoubleClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(713, 494);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(615, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDangerLevel
            // 
            this.btnDangerLevel.Location = new System.Drawing.Point(651, 6);
            this.btnDangerLevel.Name = "btnDangerLevel";
            this.btnDangerLevel.Size = new System.Drawing.Size(173, 23);
            this.btnDangerLevel.TabIndex = 4;
            this.btnDangerLevel.Text = "Show All Danger Level Product";
            this.btnDangerLevel.UseVisualStyleBackColor = true;
            this.btnDangerLevel.Click += new System.EventHandler(this.BtnDangerLevel_Click);
            // 
            // btnReorderLevel
            // 
            this.btnReorderLevel.Location = new System.Drawing.Point(466, 7);
            this.btnReorderLevel.Name = "btnReorderLevel";
            this.btnReorderLevel.Size = new System.Drawing.Size(179, 23);
            this.btnReorderLevel.TabIndex = 5;
            this.btnReorderLevel.Text = "Show All Reorder Level Product";
            this.btnReorderLevel.UseVisualStyleBackColor = true;
            this.btnReorderLevel.Click += new System.EventHandler(this.BtnReorderLevel_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(192, 7);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(151, 22);
            this.txtCondition.TabIndex = 14;
            // 
            // cboCondition
            // 
            this.cboCondition.FormattingEnabled = true;
            this.cboCondition.Items.AddRange(new object[] {
            "ProductID",
            "ProductName",
            "ProductType",
            "ProductUnit"});
            this.cboCondition.Location = new System.Drawing.Point(77, 7);
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(109, 20);
            this.cboCondition.TabIndex = 13;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(10, 12);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(61, 12);
            this.lblStockQuantity.TabIndex = 12;
            this.lblStockQuantity.Text = "Condition : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(349, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvReorderOrder
            // 
            this.dgvReorderOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReorderOrder.Location = new System.Drawing.Point(12, 291);
            this.dgvReorderOrder.Name = "dgvReorderOrder";
            this.dgvReorderOrder.RowTemplate.Height = 24;
            this.dgvReorderOrder.Size = new System.Drawing.Size(812, 197);
            this.dgvReorderOrder.TabIndex = 16;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(713, 262);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(84, 23);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reorder Order :";
            // 
            // btnDeleteProdcut
            // 
            this.btnDeleteProdcut.Location = new System.Drawing.Point(597, 262);
            this.btnDeleteProdcut.Name = "btnDeleteProdcut";
            this.btnDeleteProdcut.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteProdcut.TabIndex = 20;
            this.btnDeleteProdcut.Text = "Delete Product";
            this.btnDeleteProdcut.UseVisualStyleBackColor = true;
            // 
            // frmInventoryReorderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 529);
            this.Controls.Add(this.btnDeleteProdcut);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteProdcut;
    }
}