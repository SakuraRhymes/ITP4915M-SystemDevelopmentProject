namespace SLMCS_ERP
{
    partial class frmInventoryAddReorderProduct
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
            this.lblProductIDData = new System.Windows.Forms.Label();
            this.rtbProductDesc = new System.Windows.Forms.RichTextBox();
            this.cboProductUnit = new System.Windows.Forms.ComboBox();
            this.txtReorderQuantity = new System.Windows.Forms.TextBox();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductTypeData
            // 
            this.lblProductTypeData.AutoSize = true;
            this.lblProductTypeData.Location = new System.Drawing.Point(267, 84);
            this.lblProductTypeData.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductTypeData.Name = "lblProductTypeData";
            this.lblProductTypeData.Size = new System.Drawing.Size(90, 24);
            this.lblProductTypeData.TabIndex = 41;
            this.lblProductTypeData.Text = "XXXXX";
            // 
            // lblProductIDData
            // 
            this.lblProductIDData.AutoSize = true;
            this.lblProductIDData.Location = new System.Drawing.Point(267, 32);
            this.lblProductIDData.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductIDData.Name = "lblProductIDData";
            this.lblProductIDData.Size = new System.Drawing.Size(90, 24);
            this.lblProductIDData.TabIndex = 38;
            this.lblProductIDData.Text = "XXXXX";
            // 
            // rtbProductDesc
            // 
            this.rtbProductDesc.Location = new System.Drawing.Point(267, 180);
            this.rtbProductDesc.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rtbProductDesc.Name = "rtbProductDesc";
            this.rtbProductDesc.Size = new System.Drawing.Size(470, 126);
            this.rtbProductDesc.TabIndex = 37;
            this.rtbProductDesc.Text = "";
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Items.AddRange(new object[] {
            "piece",
            "item",
            "set"});
            this.cboProductUnit.Location = new System.Drawing.Point(267, 330);
            this.cboProductUnit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(212, 32);
            this.cboProductUnit.TabIndex = 36;
            // 
            // txtReorderQuantity
            // 
            this.txtReorderQuantity.Location = new System.Drawing.Point(271, 503);
            this.txtReorderQuantity.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtReorderQuantity.Name = "txtReorderQuantity";
            this.txtReorderQuantity.Size = new System.Drawing.Size(212, 36);
            this.txtReorderQuantity.TabIndex = 35;
            // 
            // txtActualQty
            // 
            this.txtActualQty.Location = new System.Drawing.Point(267, 438);
            this.txtActualQty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtActualQty.Name = "txtActualQty";
            this.txtActualQty.Size = new System.Drawing.Size(212, 36);
            this.txtActualQty.TabIndex = 34;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(267, 386);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(212, 36);
            this.txtProductPrice.TabIndex = 33;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(267, 124);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(470, 36);
            this.txtProductName.TabIndex = 32;
            // 
            // lvlReorderLevel
            // 
            this.lvlReorderLevel.AutoSize = true;
            this.lvlReorderLevel.Location = new System.Drawing.Point(55, 506);
            this.lvlReorderLevel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lvlReorderLevel.Name = "lvlReorderLevel";
            this.lvlReorderLevel.Size = new System.Drawing.Size(178, 24);
            this.lvlReorderLevel.TabIndex = 31;
            this.lvlReorderLevel.Text = "Reorder Quantity :";
            // 
            // lblActualQty
            // 
            this.lblActualQty.AutoSize = true;
            this.lblActualQty.Location = new System.Drawing.Point(72, 444);
            this.lblActualQty.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblActualQty.Name = "lblActualQty";
            this.lblActualQty.Size = new System.Drawing.Size(164, 24);
            this.lblActualQty.TabIndex = 30;
            this.lblActualQty.Text = "Actual Quantity :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(96, 392);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(145, 24);
            this.lblProductPrice.TabIndex = 29;
            this.lblProductPrice.Text = "Product Price :";
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(103, 336);
            this.lblProductUnit.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(137, 24);
            this.lblProductUnit.TabIndex = 28;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(31, 180);
            this.lblProductDesc.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(202, 24);
            this.lblProductDesc.TabIndex = 27;
            this.lblProductDesc.Text = "Product Description :";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(94, 84);
            this.lblProductType.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(144, 24);
            this.lblProductType.TabIndex = 26;
            this.lblProductType.Text = "Product Type :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(87, 130);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(152, 24);
            this.lblProductName.TabIndex = 25;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(120, 32);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(122, 24);
            this.lblProductID.TabIndex = 24;
            this.lblProductID.Text = "Product ID :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 612);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 46);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 612);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 46);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // frmInventoryAddReorderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 682);
            this.Controls.Add(this.lblProductTypeData);
            this.Controls.Add(this.lblProductIDData);
            this.Controls.Add(this.rtbProductDesc);
            this.Controls.Add(this.cboProductUnit);
            this.Controls.Add(this.txtReorderQuantity);
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
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmInventoryAddReorderProduct";
            this.Text = "frmInventoryAddReorderProduct";
            this.Load += new System.EventHandler(this.FrmInventoryAddReorderProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductTypeData;
        private System.Windows.Forms.Label lblProductIDData;
        private System.Windows.Forms.RichTextBox rtbProductDesc;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.TextBox txtReorderQuantity;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}