namespace SLMCS_ERP.UI.Management
{
    partial class frmProductManagement_EditProduct
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
            this.lblProductTypeData = new System.Windows.Forms.Label();
            this.txtDangerLevel = new System.Windows.Forms.TextBox();
            this.lblDangerLevel = new System.Windows.Forms.Label();
            this.lblProductIDData = new System.Windows.Forms.Label();
            this.rtbProductDesc = new System.Windows.Forms.RichTextBox();
            this.cboProductUnit = new System.Windows.Forms.ComboBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtActualQty = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lvlReorderLevel = new System.Windows.Forms.Label();
            this.lblActualQty = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductUnit = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbProductStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblProductTypeData
            // 
            this.lblProductTypeData.AutoSize = true;
            this.lblProductTypeData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductTypeData.Location = new System.Drawing.Point(148, 49);
            this.lblProductTypeData.Name = "lblProductTypeData";
            this.lblProductTypeData.Size = new System.Drawing.Size(48, 16);
            this.lblProductTypeData.TabIndex = 41;
            this.lblProductTypeData.Text = "XXXXX";
            // 
            // txtDangerLevel
            // 
            this.txtDangerLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDangerLevel.Location = new System.Drawing.Point(127, 286);
            this.txtDangerLevel.MaxLength = 10;
            this.txtDangerLevel.Name = "txtDangerLevel";
            this.txtDangerLevel.Size = new System.Drawing.Size(155, 23);
            this.txtDangerLevel.TabIndex = 40;
            // 
            // lblDangerLevel
            // 
            this.lblDangerLevel.AutoSize = true;
            this.lblDangerLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDangerLevel.Location = new System.Drawing.Point(56, 330);
            this.lblDangerLevel.Name = "lblDangerLevel";
            this.lblDangerLevel.Size = new System.Drawing.Size(88, 16);
            this.lblDangerLevel.TabIndex = 39;
            this.lblDangerLevel.Text = "Danger Level :";
            // 
            // lblProductIDData
            // 
            this.lblProductIDData.AutoSize = true;
            this.lblProductIDData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductIDData.Location = new System.Drawing.Point(148, 23);
            this.lblProductIDData.Name = "lblProductIDData";
            this.lblProductIDData.Size = new System.Drawing.Size(48, 16);
            this.lblProductIDData.TabIndex = 38;
            this.lblProductIDData.Text = "XXXXX";
            // 
            // rtbProductDesc
            // 
            this.rtbProductDesc.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbProductDesc.Location = new System.Drawing.Point(127, 101);
            this.rtbProductDesc.MaxLength = 100;
            this.rtbProductDesc.Name = "rtbProductDesc";
            this.rtbProductDesc.Size = new System.Drawing.Size(219, 83);
            this.rtbProductDesc.TabIndex = 37;
            this.rtbProductDesc.Text = "";
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Items.AddRange(new object[] {
            "piece",
            "item",
            "set"});
            this.cboProductUnit.Location = new System.Drawing.Point(148, 198);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(155, 24);
            this.cboProductUnit.TabIndex = 36;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReorderLevel.Location = new System.Drawing.Point(127, 258);
            this.txtReorderLevel.MaxLength = 10;
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(155, 23);
            this.txtReorderLevel.TabIndex = 35;
            // 
            // txtActualQty
            // 
            this.txtActualQty.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtActualQty.Location = new System.Drawing.Point(127, 230);
            this.txtActualQty.MaxLength = 10;
            this.txtActualQty.Name = "txtActualQty";
            this.txtActualQty.Size = new System.Drawing.Size(155, 23);
            this.txtActualQty.TabIndex = 34;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductPrice.Location = new System.Drawing.Point(127, 204);
            this.txtProductPrice.MaxLength = 10;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(155, 23);
            this.txtProductPrice.TabIndex = 33;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductName.Location = new System.Drawing.Point(127, 73);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(219, 23);
            this.txtProductName.TabIndex = 32;
            // 
            // lvlReorderLevel
            // 
            this.lvlReorderLevel.AutoSize = true;
            this.lvlReorderLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvlReorderLevel.Location = new System.Drawing.Point(52, 297);
            this.lvlReorderLevel.Name = "lvlReorderLevel";
            this.lvlReorderLevel.Size = new System.Drawing.Size(92, 16);
            this.lvlReorderLevel.TabIndex = 31;
            this.lvlReorderLevel.Text = "Reorder Level :";
            // 
            // lblActualQty
            // 
            this.lblActualQty.AutoSize = true;
            this.lblActualQty.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblActualQty.Location = new System.Drawing.Point(44, 264);
            this.lblActualQty.Name = "lblActualQty";
            this.lblActualQty.Size = new System.Drawing.Size(100, 16);
            this.lblActualQty.TabIndex = 30;
            this.lblActualQty.Text = "Actual Quantity :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductPrice.Location = new System.Drawing.Point(57, 233);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(88, 16);
            this.lblProductPrice.TabIndex = 29;
            this.lblProductPrice.Text = "Product Price :";
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductUnit.Location = new System.Drawing.Point(61, 201);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(84, 16);
            this.lblProductUnit.TabIndex = 28;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductDesc.Location = new System.Drawing.Point(21, 106);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(125, 16);
            this.lblProductDesc.TabIndex = 27;
            this.lblProductDesc.Text = "Product Description :";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductType.Location = new System.Drawing.Point(57, 49);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(89, 16);
            this.lblProductType.TabIndex = 26;
            this.lblProductType.Text = "Product Type :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductName.Location = new System.Drawing.Point(50, 77);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 16);
            this.lblProductName.TabIndex = 25;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductID.Location = new System.Drawing.Point(72, 23);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(73, 16);
            this.lblProductID.TabIndex = 24;
            this.lblProductID.Text = "Product ID :";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(171, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(280, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 25);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(78, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Available :";
            // 
            // ckbProductStatus
            // 
            this.ckbProductStatus.AutoSize = true;
            this.ckbProductStatus.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbProductStatus.Location = new System.Drawing.Point(148, 360);
            this.ckbProductStatus.Name = "ckbProductStatus";
            this.ckbProductStatus.Size = new System.Drawing.Size(15, 14);
            this.ckbProductStatus.TabIndex = 42;
            this.ckbProductStatus.UseVisualStyleBackColor = true;
            // 
            // frmProductManagement_EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbProductStatus);
            this.Controls.Add(this.lblProductTypeData);
            this.Controls.Add(this.txtDangerLevel);
            this.Controls.Add(this.lblDangerLevel);
            this.Controls.Add(this.lblProductIDData);
            this.Controls.Add(this.rtbProductDesc);
            this.Controls.Add(this.cboProductUnit);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.txtActualQty);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lvlReorderLevel);
            this.Controls.Add(this.lblActualQty);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductUnit);
            this.Controls.Add(this.lblProductDesc);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProductManagement_EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductTypeData;
        private System.Windows.Forms.TextBox txtDangerLevel;
        private System.Windows.Forms.Label lblDangerLevel;
        private System.Windows.Forms.Label lblProductIDData;
        private System.Windows.Forms.RichTextBox rtbProductDesc;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.TextBox txtActualQty;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lvlReorderLevel;
        private System.Windows.Forms.Label lblActualQty;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbProductStatus;
    }
}