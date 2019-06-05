namespace SLMCS_ERP
{
    partial class frmInventoryNewProduct
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
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.rtbProductDescription = new System.Windows.Forms.RichTextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboProductUnit = new System.Windows.Forms.ComboBox();
            this.lblProductUnit = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.btnSearchVendor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(51, 48);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 12);
            this.lblProductType.TabIndex = 0;
            this.lblProductType.Text = "Product Type :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(48, 84);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(77, 12);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(22, 152);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(103, 12);
            this.lblProductDescription.TabIndex = 2;
            this.lblProductDescription.Text = "Product Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price :";
            // 
            // cboProductType
            // 
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Items.AddRange(new object[] {
            "Sheet Metal",
            "Major Assemblies",
            "Light Components",
            "Accessories"});
            this.cboProductType.Location = new System.Drawing.Point(131, 45);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(156, 20);
            this.cboProductType.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(131, 81);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(156, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // rtbProductDescription
            // 
            this.rtbProductDescription.Location = new System.Drawing.Point(131, 152);
            this.rtbProductDescription.Name = "rtbProductDescription";
            this.rtbProductDescription.Size = new System.Drawing.Size(229, 85);
            this.rtbProductDescription.TabIndex = 4;
            this.rtbProductDescription.Text = "";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(131, 250);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(78, 22);
            this.txtProductPrice.TabIndex = 5;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductPrice_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(285, 280);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(202, 280);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Items.AddRange(new object[] {
            "piece",
            "set",
            "item"});
            this.cboProductUnit.Location = new System.Drawing.Point(131, 118);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(78, 20);
            this.cboProductUnit.TabIndex = 3;
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(55, 121);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(70, 12);
            this.lblProductUnit.TabIndex = 11;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(64, 11);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(61, 12);
            this.lblVendor.TabIndex = 12;
            this.lblVendor.Text = "Vendor ID :";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(131, 8);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(100, 22);
            this.txtVendorID.TabIndex = 0;
            // 
            // btnSearchVendor
            // 
            this.btnSearchVendor.Location = new System.Drawing.Point(237, 8);
            this.btnSearchVendor.Name = "btnSearchVendor";
            this.btnSearchVendor.Size = new System.Drawing.Size(50, 23);
            this.btnSearchVendor.TabIndex = 13;
            this.btnSearchVendor.Text = "Search";
            this.btnSearchVendor.UseVisualStyleBackColor = true;
            this.btnSearchVendor.Click += new System.EventHandler(this.BtnSearchVendor_Click);
            // 
            // frmInventoryNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 312);
            this.Controls.Add(this.btnSearchVendor);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblProductUnit);
            this.Controls.Add(this.cboProductUnit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.rtbProductDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.cboProductType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductType);
            this.Name = "frmInventoryNewProduct";
            this.Text = "New Product";
            this.Load += new System.EventHandler(this.FrmInventoryNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.RichTextBox rtbProductDescription;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Button btnSearchVendor;
    }
}