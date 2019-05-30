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
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.cboProductUnit = new System.Windows.Forms.ComboBox();
            this.rtbProductDesc = new System.Windows.Forms.RichTextBox();
            this.lblProductIDData = new System.Windows.Forms.Label();
            this.txtDangerLevel = new System.Windows.Forms.TextBox();
            this.lblDangerLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(574, 618);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 46);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(399, 618);
            this.btnReset.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 46);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(115, 38);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(122, 24);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(82, 136);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(152, 24);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(89, 90);
            this.lblProductType.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(144, 24);
            this.lblProductType.TabIndex = 4;
            this.lblProductType.Text = "Product Type :";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(26, 186);
            this.lblProductDesc.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(202, 24);
            this.lblProductDesc.TabIndex = 5;
            this.lblProductDesc.Text = "Product Description :";
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(98, 342);
            this.lblProductUnit.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(137, 24);
            this.lblProductUnit.TabIndex = 6;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(91, 398);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(145, 24);
            this.lblProductPrice.TabIndex = 7;
            this.lblProductPrice.Text = "Product Price :";
            // 
            // lblActualQty
            // 
            this.lblActualQty.AutoSize = true;
            this.lblActualQty.Location = new System.Drawing.Point(67, 450);
            this.lblActualQty.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblActualQty.Name = "lblActualQty";
            this.lblActualQty.Size = new System.Drawing.Size(164, 24);
            this.lblActualQty.TabIndex = 8;
            this.lblActualQty.Text = "Actual Quantity :";
            // 
            // lvlReorderLevel
            // 
            this.lvlReorderLevel.AutoSize = true;
            this.lvlReorderLevel.Location = new System.Drawing.Point(80, 506);
            this.lvlReorderLevel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lvlReorderLevel.Name = "lvlReorderLevel";
            this.lvlReorderLevel.Size = new System.Drawing.Size(152, 24);
            this.lvlReorderLevel.TabIndex = 9;
            this.lvlReorderLevel.Text = "Reorder Level :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(262, 130);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(470, 36);
            this.txtProductName.TabIndex = 11;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(262, 392);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(212, 36);
            this.txtProductPrice.TabIndex = 12;
            // 
            // txtActualQty
            // 
            this.txtActualQty.Location = new System.Drawing.Point(262, 444);
            this.txtActualQty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtActualQty.Name = "txtActualQty";
            this.txtActualQty.Size = new System.Drawing.Size(212, 36);
            this.txtActualQty.TabIndex = 13;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(262, 500);
            this.txtReorderLevel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(212, 36);
            this.txtReorderLevel.TabIndex = 14;
            // 
            // cboProductType
            // 
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Items.AddRange(new object[] {
            "piece",
            "item",
            "set"});
            this.cboProductType.Location = new System.Drawing.Point(262, 84);
            this.cboProductType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(212, 32);
            this.cboProductType.TabIndex = 15;
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Location = new System.Drawing.Point(262, 336);
            this.cboProductUnit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(212, 32);
            this.cboProductUnit.TabIndex = 16;
            // 
            // rtbProductDesc
            // 
            this.rtbProductDesc.Location = new System.Drawing.Point(262, 186);
            this.rtbProductDesc.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rtbProductDesc.Name = "rtbProductDesc";
            this.rtbProductDesc.Size = new System.Drawing.Size(470, 126);
            this.rtbProductDesc.TabIndex = 17;
            this.rtbProductDesc.Text = "";
            // 
            // lblProductIDData
            // 
            this.lblProductIDData.AutoSize = true;
            this.lblProductIDData.Location = new System.Drawing.Point(262, 38);
            this.lblProductIDData.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductIDData.Name = "lblProductIDData";
            this.lblProductIDData.Size = new System.Drawing.Size(90, 24);
            this.lblProductIDData.TabIndex = 18;
            this.lblProductIDData.Text = "XXXXX";
            // 
            // txtDangerLevel
            // 
            this.txtDangerLevel.Location = new System.Drawing.Point(262, 556);
            this.txtDangerLevel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDangerLevel.Name = "txtDangerLevel";
            this.txtDangerLevel.Size = new System.Drawing.Size(212, 36);
            this.txtDangerLevel.TabIndex = 20;
            // 
            // lblDangerLevel
            // 
            this.lblDangerLevel.AutoSize = true;
            this.lblDangerLevel.Location = new System.Drawing.Point(80, 562);
            this.lblDangerLevel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDangerLevel.Name = "lblDangerLevel";
            this.lblDangerLevel.Size = new System.Drawing.Size(151, 24);
            this.lblDangerLevel.TabIndex = 19;
            this.lblDangerLevel.Text = "Danger Level  :";
            // 
            // frmInventoryEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 688);
            this.Controls.Add(this.txtDangerLevel);
            this.Controls.Add(this.lblDangerLevel);
            this.Controls.Add(this.lblProductIDData);
            this.Controls.Add(this.rtbProductDesc);
            this.Controls.Add(this.cboProductUnit);
            this.Controls.Add(this.cboProductType);
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
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.RichTextBox rtbProductDesc;
        private System.Windows.Forms.Label lblProductIDData;
        private System.Windows.Forms.TextBox txtDangerLevel;
        private System.Windows.Forms.Label lblDangerLevel;
    }
}