namespace SLMCS_ERP.UI.Management
{
    partial class frmProductManagement_NewProduct
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
            this.btnSearchVendor = new System.Windows.Forms.Button();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblProductUnit = new System.Windows.Forms.Label();
            this.cboProductUnit = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.rtbProductDescription = new System.Windows.Forms.RichTextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchVendor
            // 
            this.btnSearchVendor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchVendor.Location = new System.Drawing.Point(328, 18);
            this.btnSearchVendor.Name = "btnSearchVendor";
            this.btnSearchVendor.Size = new System.Drawing.Size(90, 25);
            this.btnSearchVendor.TabIndex = 28;
            this.btnSearchVendor.Text = "Search";
            this.btnSearchVendor.UseVisualStyleBackColor = true;
            this.btnSearchVendor.Click += new System.EventHandler(this.BtnSearchVendor_Click);
            // 
            // txtVendorID
            // 
            this.txtVendorID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorID.Location = new System.Drawing.Point(156, 19);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.ReadOnly = true;
            this.txtVendorID.Size = new System.Drawing.Size(156, 23);
            this.txtVendorID.TabIndex = 14;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.Location = new System.Drawing.Point(76, 22);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(71, 16);
            this.lblVendor.TabIndex = 27;
            this.lblVendor.Text = "Vendor ID :";
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductUnit.Location = new System.Drawing.Point(63, 132);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(84, 16);
            this.lblProductUnit.TabIndex = 26;
            this.lblProductUnit.Text = "Product Unit :";
            // 
            // cboProductUnit
            // 
            this.cboProductUnit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductUnit.FormattingEnabled = true;
            this.cboProductUnit.Items.AddRange(new object[] {
            "piece",
            "set",
            "item"});
            this.cboProductUnit.Location = new System.Drawing.Point(156, 129);
            this.cboProductUnit.Name = "cboProductUnit";
            this.cboProductUnit.Size = new System.Drawing.Size(116, 24);
            this.cboProductUnit.TabIndex = 20;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(222, 323);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubmit.Location = new System.Drawing.Point(328, 323);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 25);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(156, 278);
            this.txtProductPrice.MaxLength = 10;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(116, 23);
            this.txtProductPrice.TabIndex = 23;
            // 
            // rtbProductDescription
            // 
            this.rtbProductDescription.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbProductDescription.Location = new System.Drawing.Point(156, 163);
            this.rtbProductDescription.MaxLength = 100;
            this.rtbProductDescription.Name = "rtbProductDescription";
            this.rtbProductDescription.Size = new System.Drawing.Size(262, 104);
            this.rtbProductDescription.TabIndex = 22;
            this.rtbProductDescription.Text = "";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(156, 92);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(156, 23);
            this.txtProductName.TabIndex = 18;
            // 
            // cboProductType
            // 
            this.cboProductType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Items.AddRange(new object[] {
            "Sheet Metal",
            "Major Assemblies",
            "Light Components",
            "Accessories"});
            this.cboProductType.Location = new System.Drawing.Point(156, 56);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(156, 24);
            this.cboProductType.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Product Price :";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(22, 163);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(125, 16);
            this.lblProductDescription.TabIndex = 19;
            this.lblProductDescription.Text = "Product Description :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(51, 95);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 16);
            this.lblProductName.TabIndex = 17;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(58, 59);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(89, 16);
            this.lblProductType.TabIndex = 15;
            this.lblProductType.Text = "Product Type :";
            // 
            // frmProductManagement_NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 369);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProductManagement_NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchVendor;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.ComboBox cboProductUnit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.RichTextBox rtbProductDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductType;
    }
}