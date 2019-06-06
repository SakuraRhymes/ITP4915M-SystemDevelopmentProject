namespace SLMCS_ERP.UI.Management
{
    partial class frmDealerManagement_NewDealer
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
            this.lblDealerInvoiceAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDealerPhoneNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDealerShippingAddress = new System.Windows.Forms.RichTextBox();
            this.txtDealerInvoiceAddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(194, 361);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(277, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblDealerInvoiceAddress
            // 
            this.lblDealerInvoiceAddress.AutoSize = true;
            this.lblDealerInvoiceAddress.Location = new System.Drawing.Point(20, 171);
            this.lblDealerInvoiceAddress.Name = "lblDealerInvoiceAddress";
            this.lblDealerInvoiceAddress.Size = new System.Drawing.Size(116, 12);
            this.lblDealerInvoiceAddress.TabIndex = 17;
            this.lblDealerInvoiceAddress.Text = "Dealer Invoice Address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 27;
            // 
            // txtDealerPhoneNo
            // 
            this.txtDealerPhoneNo.AutoSize = true;
            this.txtDealerPhoneNo.Location = new System.Drawing.Point(46, 125);
            this.txtDealerPhoneNo.Name = "txtDealerPhoneNo";
            this.txtDealerPhoneNo.Size = new System.Drawing.Size(90, 12);
            this.txtDealerPhoneNo.TabIndex = 26;
            this.txtDealerPhoneNo.Text = "Dealer Phone No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "Dealer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "Dealer Shipping Address:";
            // 
            // txtDealerShippingAddress
            // 
            this.txtDealerShippingAddress.Location = new System.Drawing.Point(151, 268);
            this.txtDealerShippingAddress.Name = "txtDealerShippingAddress";
            this.txtDealerShippingAddress.Size = new System.Drawing.Size(133, 70);
            this.txtDealerShippingAddress.TabIndex = 32;
            this.txtDealerShippingAddress.Text = "";
            // 
            // txtDealerInvoiceAddress
            // 
            this.txtDealerInvoiceAddress.Location = new System.Drawing.Point(151, 171);
            this.txtDealerInvoiceAddress.Name = "txtDealerInvoiceAddress";
            this.txtDealerInvoiceAddress.Size = new System.Drawing.Size(133, 70);
            this.txtDealerInvoiceAddress.TabIndex = 33;
            this.txtDealerInvoiceAddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "Dealer ID:";
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(151, 73);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(106, 22);
            this.txtDealerName.TabIndex = 29;
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(151, 32);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.ReadOnly = true;
            this.txtDealerID.Size = new System.Drawing.Size(106, 22);
            this.txtDealerID.TabIndex = 35;
            // 
            // frmDealerManagement_NewDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 415);
            this.Controls.Add(this.txtDealerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDealerInvoiceAddress);
            this.Controls.Add(this.txtDealerShippingAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDealerPhoneNo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDealerInvoiceAddress);
            this.Name = "frmDealerManagement_NewDealer";
            this.Text = "New Dealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDealerInvoiceAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtDealerPhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDealerShippingAddress;
        private System.Windows.Forms.RichTextBox txtDealerInvoiceAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.TextBox txtDealerID;
    }
}