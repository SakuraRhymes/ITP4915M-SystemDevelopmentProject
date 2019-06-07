namespace SLMCS_ERP.UI.Management
{
    partial class frmStaffManagement_EditStaff
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
            this.cbStaffDepartment = new System.Windows.Forms.ComboBox();
            this.ckAvailable = new System.Windows.Forms.CheckBox();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffPhoneNo = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbStaffDepartment
            // 
            this.cbStaffDepartment.FormattingEnabled = true;
            this.cbStaffDepartment.Items.AddRange(new object[] {
            "SA",
            "HR",
            "FI",
            "PO",
            "WH"});
            this.cbStaffDepartment.Location = new System.Drawing.Point(167, 267);
            this.cbStaffDepartment.Name = "cbStaffDepartment";
            this.cbStaffDepartment.Size = new System.Drawing.Size(61, 20);
            this.cbStaffDepartment.TabIndex = 85;
            this.cbStaffDepartment.Text = "SA";
            // 
            // ckAvailable
            // 
            this.ckAvailable.AutoSize = true;
            this.ckAvailable.Location = new System.Drawing.Point(167, 325);
            this.ckAvailable.Name = "ckAvailable";
            this.ckAvailable.Size = new System.Drawing.Size(15, 14);
            this.ckAvailable.TabIndex = 84;
            this.ckAvailable.UseVisualStyleBackColor = true;
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffPassword.Location = new System.Drawing.Point(167, 210);
            this.txtStaffPassword.MaxLength = 30;
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(168, 23);
            this.txtStaffPassword.TabIndex = 83;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(8, 12);
            this.label13.TabIndex = 82;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(138, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(8, 12);
            this.label14.TabIndex = 81;
            this.label14.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(138, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(8, 12);
            this.label19.TabIndex = 80;
            this.label19.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(138, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(8, 12);
            this.label18.TabIndex = 79;
            this.label18.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(138, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(8, 12);
            this.label17.TabIndex = 78;
            this.label17.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(138, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(8, 12);
            this.label16.TabIndex = 77;
            this.label16.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 12);
            this.label12.TabIndex = 76;
            this.label12.Text = "Available ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 12);
            this.label11.TabIndex = 75;
            this.label11.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 74;
            this.label10.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 12);
            this.label9.TabIndex = 73;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 12);
            this.label8.TabIndex = 72;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 71;
            this.label7.Text = "ID";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffID.Location = new System.Drawing.Point(167, 45);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(168, 23);
            this.txtStaffID.TabIndex = 70;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffName.Location = new System.Drawing.Point(167, 100);
            this.txtStaffName.MaxLength = 50;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(168, 23);
            this.txtStaffName.TabIndex = 69;
            // 
            // txtStaffPhoneNo
            // 
            this.txtStaffPhoneNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffPhoneNo.Location = new System.Drawing.Point(167, 155);
            this.txtStaffPhoneNo.MaxLength = 11;
            this.txtStaffPhoneNo.Name = "txtStaffPhoneNo";
            this.txtStaffPhoneNo.Size = new System.Drawing.Size(168, 23);
            this.txtStaffPhoneNo.TabIndex = 68;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(119, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubmit.Location = new System.Drawing.Point(235, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 66;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // frmStaffManagement_EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 415);
            this.Controls.Add(this.cbStaffDepartment);
            this.Controls.Add(this.ckAvailable);
            this.Controls.Add(this.txtStaffPassword);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffPhoneNo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmStaffManagement_EditStaff";
            this.Text = "frmStaffManagement_EditStaff";
            this.Load += new System.EventHandler(this.frmStaffManagement_EditStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStaffDepartment;
        private System.Windows.Forms.CheckBox ckAvailable;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffPhoneNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
    }
}