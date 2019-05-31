namespace SLMCS_ERP
{
    partial class frmInventoryEditProduct
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProductUnit = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblActualQty = new System.Windows.Forms.Label();
            this.lvlReorderLevel = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtActualQty = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.cboProductUnit = new System.Windows.Forms.ComboBox();
            this.rtbProductDesc = new System.Windows.Forms.RichTextBox();
            this.lblProductIDData = new System.Windows.Forms.Label();
            this.txtDangerLevel = new System.Windows.Forms.TextBox();
            this.lblDangerLevel = new System.Windows.Forms.Label();
            this.lblProductTypeData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(265, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(184, 309);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(53, 19);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(62, 12);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(38, 68);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(77, 12);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(41, 45);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 12);
            this.lblProductType.TabIndex = 4;
            this.lblProductType.Text = "Product Type :";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(12, 93);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(103, 12);
            this.lblProductDesc.TabIndex = 5;
            this.lblProductDesc.Text = "Product Description :";
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(45, 171);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(70, 12);
            this.lblProductUnit.TabIndex = 6;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(42, 199);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(73, 12);
            this.lblProductPrice.TabIndex = 7;
            this.lblProductPrice.Text = "Product Price :";
            // 
            // lblActualQty
            // 
            this.lblActualQty.AutoSize = true;
            this.lblActualQty.Location = new System.Drawing.Point(31, 225);
            this.lblActualQty.Name = "lblActualQty";
            this.lblActualQty.Size = new System.Drawing.Size(84, 12);
            this.lblActualQty.TabIndex = 8;
            this.lblActualQty.Text = "Actual Quantity :";
            // 
            // lvlReorderLevel
            // 
            this.lvlReorderLevel.AutoSize = true;
            this.lvlReorderLevel.Location = new System.Drawing.Point(37, 253);
            this.lvlReorderLevel.Name = "lvlReorderLevel";
            this.lvlReorderLevel.Size = new System.Drawing.Size(78, 12);
            this.lvlReorderLevel.TabIndex = 9;
            this.lvlReorderLevel.Text = "Reorder Level :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(121, 65);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(219, 22);
            this.txtProductName.TabIndex = 11;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(121, 196);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 12;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductPrice_KeyPress);
            // 
            // txtActualQty
            // 
            this.txtActualQty.Location = new System.Drawing.Point(121, 222);
            this.txtActualQty.Name = "txtActualQty";
            this.txtActualQty.Size = new System.Drawing.Size(100, 22);
            this.txtActualQty.TabIndex = 13;
            this.txtActualQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtActualQty_KeyPress);
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(121, 250);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(100, 22);
            this.txtReorderLevel.TabIndex = 14;
            this.txtReorderLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReorderLevel_KeyPress);
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Items.AddRange(new object[] {
            "piece",
            "item",
            "set"});
            this.cboProductUnit.Location = new System.Drawing.Point(121, 168);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(100, 20);
            this.cboProductUnit.TabIndex = 16;
            // 
            // rtbProductDesc
            // 
            this.rtbProductDesc.Location = new System.Drawing.Point(121, 93);
            this.rtbProductDesc.Name = "rtbProductDesc";
            this.rtbProductDesc.Size = new System.Drawing.Size(219, 65);
            this.rtbProductDesc.TabIndex = 17;
            this.rtbProductDesc.Text = "";
            // 
            // lblProductIDData
            // 
            this.lblProductIDData.AutoSize = true;
            this.lblProductIDData.Location = new System.Drawing.Point(121, 19);
            this.lblProductIDData.Name = "lblProductIDData";
            this.lblProductIDData.Size = new System.Drawing.Size(45, 12);
            this.lblProductIDData.TabIndex = 18;
            this.lblProductIDData.Text = "XXXXX";
            // 
            // txtDangerLevel
            // 
            this.txtDangerLevel.Location = new System.Drawing.Point(121, 278);
            this.txtDangerLevel.Name = "txtDangerLevel";
            this.txtDangerLevel.Size = new System.Drawing.Size(100, 22);
            this.txtDangerLevel.TabIndex = 20;
            this.txtDangerLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDangerLevel_KeyPress);
            // 
            // lblDangerLevel
            // 
            this.lblDangerLevel.AutoSize = true;
            this.lblDangerLevel.Location = new System.Drawing.Point(37, 281);
            this.lblDangerLevel.Name = "lblDangerLevel";
            this.lblDangerLevel.Size = new System.Drawing.Size(77, 12);
            this.lblDangerLevel.TabIndex = 19;
            this.lblDangerLevel.Text = "Danger Level  :";
            // 
            // lblProductTypeData
            // 
            this.lblProductTypeData.AutoSize = true;
            this.lblProductTypeData.Location = new System.Drawing.Point(121, 45);
            this.lblProductTypeData.Name = "lblProductTypeData";
            this.lblProductTypeData.Size = new System.Drawing.Size(45, 12);
            this.lblProductTypeData.TabIndex = 21;
            this.lblProductTypeData.Text = "XXXXX";
            // 
            // frmInventoryEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 344);
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
            this.Name = "frmInventoryEditProduct";
            this.Text = "frmInventoryEditProduct";
            this.Load += new System.EventHandler(this.FrmInventoryEditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblActualQty;
        private System.Windows.Forms.Label lvlReorderLevel;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtActualQty;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.RichTextBox rtbProductDesc;
        private System.Windows.Forms.Label lblProductIDData;
        private System.Windows.Forms.TextBox txtDangerLevel;
        private System.Windows.Forms.Label lblDangerLevel;
        private System.Windows.Forms.Label lblProductTypeData;
    }
}