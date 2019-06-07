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
            this.txtVendorPhoneNo = new System.Windows.Forms.TextBox();
            this.txtVendorAddress = new System.Windows.Forms.RichTextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.ckVendorAvailable = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVendorPhoneNo = new System.Windows.Forms.Label();
            this.lblVendorInvoiceAddress = new System.Windows.Forms.Label();
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
            // txtVendorPhoneNo
            // 
            this.txtVendorPhoneNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVendorPhoneNo.Location = new System.Drawing.Point(155, 170);
            this.txtVendorPhoneNo.Name = "txtVendorPhoneNo";
            this.txtVendorPhoneNo.Size = new System.Drawing.Size(168, 23);
            this.txtVendorPhoneNo.TabIndex = 27;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(8, 12);
            this.label13.TabIndex = 64;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(135, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(8, 12);
            this.label14.TabIndex = 63;
            this.label14.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(135, 237);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(8, 12);
            this.label19.TabIndex = 62;
            this.label19.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(135, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(8, 12);
            this.label18.TabIndex = 61;
            this.label18.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(135, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(8, 12);
            this.label17.TabIndex = 60;
            this.label17.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Available ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Vendor ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Vendor Name";
            // 
            // lblVendorPhoneNo
            // 
            this.lblVendorPhoneNo.AutoSize = true;
            this.lblVendorPhoneNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblVendorPhoneNo.Location = new System.Drawing.Point(24, 173);
            this.lblVendorPhoneNo.Name = "lblVendorPhoneNo";
            this.lblVendorPhoneNo.Size = new System.Drawing.Size(110, 16);
            this.lblVendorPhoneNo.TabIndex = 56;
            this.lblVendorPhoneNo.Text = "Vendor Phone No";
            // 
            // lblVendorInvoiceAddress
            // 
            this.lblVendorInvoiceAddress.AutoSize = true;
            this.lblVendorInvoiceAddress.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblVendorInvoiceAddress.Location = new System.Drawing.Point(24, 235);
            this.lblVendorInvoiceAddress.Name = "lblVendorInvoiceAddress";
            this.lblVendorInvoiceAddress.Size = new System.Drawing.Size(98, 16);
            this.lblVendorInvoiceAddress.TabIndex = 55;
            this.lblVendorInvoiceAddress.Text = "Vendor Address";
            // 
            // frmVendorManagement_NewVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 415);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVendorPhoneNo);
            this.Controls.Add(this.lblVendorInvoiceAddress);
            this.Controls.Add(this.ckVendorAvailable);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.txtVendorAddress);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorPhoneNo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
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
        private System.Windows.Forms.TextBox txtVendorPhoneNo;
        private System.Windows.Forms.RichTextBox txtVendorAddress;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.CheckBox ckVendorAvailable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVendorPhoneNo;
        private System.Windows.Forms.Label lblVendorInvoiceAddress;
    }
}