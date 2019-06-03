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
            this.lblProductTypeData.Location = new System.Drawing.Point(123, 42);
            this.lblProductTypeData.Name = "lblProductTypeData";
            this.lblProductTypeData.Size = new System.Drawing.Size(45, 12);
            this.lblProductTypeData.TabIndex = 41;
            this.lblProductTypeData.Text = "XXXXX";
            // 
            // lblProductIDData
            // 
            this.lblProductIDData.AutoSize = true;
            this.lblProductIDData.Location = new System.Drawing.Point(123, 16);
            this.lblProductIDData.Name = "lblProductIDData";
            this.lblProductIDData.Size = new System.Drawing.Size(45, 12);
            this.lblProductIDData.TabIndex = 38;
            this.lblProductIDData.Text = "XXXXX";
            // 
            // rtbProductDesc
            // 
            this.rtbProductDesc.Location = new System.Drawing.Point(123, 90);
            this.rtbProductDesc.Name = "rtbProductDesc";
            this.rtbProductDesc.Size = new System.Drawing.Size(219, 65);
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
            this.cboProductUnit.Location = new System.Drawing.Point(123, 165);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(100, 20);
            this.cboProductUnit.TabIndex = 36;
            // 
            // txtReorderQuantity
            // 
            this.txtReorderQuantity.Location = new System.Drawing.Point(125, 252);
            this.txtReorderQuantity.Name = "txtReorderQuantity";
            this.txtReorderQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtReorderQuantity.TabIndex = 0;
            this.txtReorderQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReorderQuantity_KeyPress);
            // 
            // txtActualQty
            // 
            this.txtActualQty.Location = new System.Drawing.Point(123, 219);
            this.txtActualQty.Name = "txtActualQty";
            this.txtActualQty.Size = new System.Drawing.Size(100, 22);
            this.txtActualQty.TabIndex = 34;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(123, 193);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 33;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(123, 62);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(219, 22);
            this.txtProductName.TabIndex = 32;
            // 
            // lvlReorderLevel
            // 
            this.lvlReorderLevel.AutoSize = true;
            this.lvlReorderLevel.Location = new System.Drawing.Point(25, 253);
            this.lvlReorderLevel.Name = "lvlReorderLevel";
            this.lvlReorderLevel.Size = new System.Drawing.Size(92, 12);
            this.lvlReorderLevel.TabIndex = 31;
            this.lvlReorderLevel.Text = "Reorder Quantity :";
            // 
            // lblActualQty
            // 
            this.lblActualQty.AutoSize = true;
            this.lblActualQty.Location = new System.Drawing.Point(33, 222);
            this.lblActualQty.Name = "lblActualQty";
            this.lblActualQty.Size = new System.Drawing.Size(84, 12);
            this.lblActualQty.TabIndex = 30;
            this.lblActualQty.Text = "Actual Quantity :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(44, 196);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(73, 12);
            this.lblProductPrice.TabIndex = 29;
            this.lblProductPrice.Text = "Product Price :";
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(48, 168);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(70, 12);
            this.lblProductUnit.TabIndex = 28;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(14, 90);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(103, 12);
            this.lblProductDesc.TabIndex = 27;
            this.lblProductDesc.Text = "Product Description :";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(43, 42);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 12);
            this.lblProductType.TabIndex = 26;
            this.lblProductType.Text = "Product Type :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(40, 65);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(77, 12);
            this.lblProductName.TabIndex = 25;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(55, 16);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(62, 12);
            this.lblProductID.TabIndex = 24;
            this.lblProductID.Text = "Product ID :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(267, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // frmInventoryAddReorderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 341);
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
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
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