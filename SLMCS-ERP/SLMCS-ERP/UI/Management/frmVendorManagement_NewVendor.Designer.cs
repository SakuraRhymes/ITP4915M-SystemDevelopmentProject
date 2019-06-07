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
            this.label12 = new System.Windows.Forms.Label();
            this.lblVendorPhoneNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(65, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubmit.Location = new System.Drawing.Point(194, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtVendorPhoneNo
            // 
            this.txtVendorPhoneNo.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVendorPhoneNo.Location = new System.Drawing.Point(155, 119);
            this.txtVendorPhoneNo.MaxLength = 11;
            this.txtVendorPhoneNo.Name = "txtVendorPhoneNo";
            this.txtVendorPhoneNo.Size = new System.Drawing.Size(176, 23);
            this.txtVendorPhoneNo.TabIndex = 27;
            // 
            // txtVendorAddress
            // 
            this.txtVendorAddress.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVendorAddress.Location = new System.Drawing.Point(153, 166);
            this.txtVendorAddress.MaxLength = 80;
            this.txtVendorAddress.Name = "txtVendorAddress";
            this.txtVendorAddress.Size = new System.Drawing.Size(192, 80);
            this.txtVendorAddress.TabIndex = 33;
            this.txtVendorAddress.Text = "";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtVendorName.Location = new System.Drawing.Point(155, 71);
            this.txtVendorName.MaxLength = 50;
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(176, 23);
            this.txtVendorName.TabIndex = 29;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVendorID.Location = new System.Drawing.Point(153, 25);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.ReadOnly = true;
            this.txtVendorID.Size = new System.Drawing.Size(176, 23);
            this.txtVendorID.TabIndex = 35;
            // 
            // ckVendorAvailable
            // 
            this.ckVendorAvailable.AutoSize = true;
            this.ckVendorAvailable.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckVendorAvailable.Location = new System.Drawing.Point(153, 264);
            this.ckVendorAvailable.Name = "ckVendorAvailable";
            this.ckVendorAvailable.Size = new System.Drawing.Size(15, 14);
            this.ckVendorAvailable.TabIndex = 36;
            this.ckVendorAvailable.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(81, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Available :";
            // 
            // lblVendorPhoneNo
            // 
            this.lblVendorPhoneNo.AutoSize = true;
            this.lblVendorPhoneNo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVendorPhoneNo.Location = new System.Drawing.Point(27, 121);
            this.lblVendorPhoneNo.Name = "lblVendorPhoneNo";
            this.lblVendorPhoneNo.Size = new System.Drawing.Size(120, 17);
            this.lblVendorPhoneNo.TabIndex = 40;
            this.lblVendorPhoneNo.Text = "Vendor Phone No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(51, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Vendor Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(37, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Vendor Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(72, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Vendor ID :";
            // 
            // frmVendorManagement_NewVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 374);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblVendorPhoneNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVendorPhoneNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}