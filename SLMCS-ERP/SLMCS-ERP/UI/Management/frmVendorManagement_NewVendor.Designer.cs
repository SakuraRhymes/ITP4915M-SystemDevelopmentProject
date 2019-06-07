namespace SLMCS_ERP.UI.Management
{
    partial class frmVendorManagement_NewVendor
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblVendorInvoiceAddress = new System.Windows.Forms.Label();
            this.txtVendorPhoneNo = new System.Windows.Forms.TextBox();
            this.lblVendorPhoneNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendorAddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.ckVendorAvailable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(138, 364);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubmit.Location = new System.Drawing.Point(254, 364);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblVendorInvoiceAddress
            // 
            this.lblVendorInvoiceAddress.AutoSize = true;
            this.lblVendorInvoiceAddress.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblVendorInvoiceAddress.Location = new System.Drawing.Point(49, 237);
            this.lblVendorInvoiceAddress.Name = "lblVendorInvoiceAddress";
            this.lblVendorInvoiceAddress.Size = new System.Drawing.Size(104, 16);
            this.lblVendorInvoiceAddress.TabIndex = 17;
            this.lblVendorInvoiceAddress.Text = "Vendor Address :";
            // 
            // txtVendorPhoneNo
            // 
            this.txtVendorPhoneNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVendorPhoneNo.Location = new System.Drawing.Point(155, 170);
            this.txtVendorPhoneNo.Name = "txtVendorPhoneNo";
            this.txtVendorPhoneNo.Size = new System.Drawing.Size(168, 23);
            this.txtVendorPhoneNo.TabIndex = 27;
            // 
            // lblVendorPhoneNo
            // 
            this.lblVendorPhoneNo.AutoSize = true;
            this.lblVendorPhoneNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblVendorPhoneNo.Location = new System.Drawing.Point(37, 171);
            this.lblVendorPhoneNo.Name = "lblVendorPhoneNo";
            this.lblVendorPhoneNo.Size = new System.Drawing.Size(116, 16);
            this.lblVendorPhoneNo.TabIndex = 26;
            this.lblVendorPhoneNo.Text = "Vendor Phone No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(59, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Vendor Name :";
            // 
            // txtVendorAddress
            // 
            this.txtVendorAddress.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVendorAddress.Location = new System.Drawing.Point(155, 234);
            this.txtVendorAddress.Name = "txtVendorAddress";
            this.txtVendorAddress.Size = new System.Drawing.Size(168, 70);
            this.txtVendorAddress.TabIndex = 33;
            this.txtVendorAddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Vendor ID :";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVendorName.Location = new System.Drawing.Point(155, 103);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(168, 23);
            this.txtVendorName.TabIndex = 29;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVendorID.Location = new System.Drawing.Point(155, 36);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.ReadOnly = true;
            this.txtVendorID.Size = new System.Drawing.Size(168, 23);
            this.txtVendorID.TabIndex = 35;
            // 
            // ckVendorAvailable
            // 
            this.ckVendorAvailable.AutoSize = true;
            this.ckVendorAvailable.Location = new System.Drawing.Point(155, 328);
            this.ckVendorAvailable.Name = "ckVendorAvailable";
            this.ckVendorAvailable.Size = new System.Drawing.Size(15, 14);
            this.ckVendorAvailable.TabIndex = 36;
            this.ckVendorAvailable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(80, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Available  :";
            // 
            // frmVendorManagement_NewVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckVendorAvailable);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVendorAddress);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVendorPhoneNo);
            this.Controls.Add(this.lblVendorPhoneNo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblVendorInvoiceAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVendorManagement_NewVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Vendor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblVendorInvoiceAddress;
        private System.Windows.Forms.TextBox txtVendorPhoneNo;
        private System.Windows.Forms.Label lblVendorPhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtVendorAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.CheckBox ckVendorAvailable;
        private System.Windows.Forms.Label label3;
    }
}