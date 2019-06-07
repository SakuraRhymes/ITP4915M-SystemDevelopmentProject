namespace SLMCS_ERP.UI.Management
{
    partial class frmStaffManagement_NewStaff
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
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffPhoneNo = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ckAvailable = new System.Windows.Forms.CheckBox();
            this.cbStaffDepartment = new System.Windows.Forms.ComboBox();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffID.Location = new System.Drawing.Point(167, 32);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(168, 23);
            this.txtStaffID.TabIndex = 47;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffName.Location = new System.Drawing.Point(167, 87);
            this.txtStaffName.MaxLength = 50;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(168, 23);
            this.txtStaffName.TabIndex = 42;
            // 
            // txtStaffPhoneNo
            // 
            this.txtStaffPhoneNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffPhoneNo.Location = new System.Drawing.Point(167, 142);
            this.txtStaffPhoneNo.MaxLength = 11;
            this.txtStaffPhoneNo.Name = "txtStaffPhoneNo";
            this.txtStaffPhoneNo.Size = new System.Drawing.Size(168, 23);
            this.txtStaffPhoneNo.TabIndex = 40;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(95, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubmit.Location = new System.Drawing.Point(211, 356);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 37;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 12);
            this.label12.TabIndex = 53;
            this.label12.Text = "Available ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 12);
            this.label11.TabIndex = 52;
            this.label11.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 51;
            this.label10.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 12);
            this.label9.TabIndex = 50;
            this.label9.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 48;
            this.label7.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(8, 12);
            this.label13.TabIndex = 59;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(138, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(8, 12);
            this.label14.TabIndex = 58;
            this.label14.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(138, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(8, 12);
            this.label18.TabIndex = 56;
            this.label18.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(138, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(8, 12);
            this.label17.TabIndex = 55;
            this.label17.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(138, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(8, 12);
            this.label16.TabIndex = 54;
            this.label16.Text = ":";
            // 
            // ckAvailable
            // 
            this.ckAvailable.AutoSize = true;
            this.ckAvailable.Location = new System.Drawing.Point(167, 312);
            this.ckAvailable.Name = "ckAvailable";
            this.ckAvailable.Size = new System.Drawing.Size(15, 14);
            this.ckAvailable.TabIndex = 62;
            this.ckAvailable.UseVisualStyleBackColor = true;
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
            this.cbStaffDepartment.Location = new System.Drawing.Point(167, 254);
            this.cbStaffDepartment.Name = "cbStaffDepartment";
            this.cbStaffDepartment.Size = new System.Drawing.Size(61, 20);
            this.cbStaffDepartment.TabIndex = 65;
            this.cbStaffDepartment.Text = "SA";
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffPassword.Location = new System.Drawing.Point(167, 197);
            this.txtStaffPassword.MaxLength = 7;
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(168, 23);
            this.txtStaffPassword.TabIndex = 61;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(138, 202);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(8, 12);
            this.label19.TabIndex = 57;
            this.label19.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 12);
            this.label8.TabIndex = 49;
            this.label8.Text = "Password";
            // 
            // frmStaffManagement_NewStaff
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
            this.Name = "frmStaffManagement_NewStaff";
            this.Text = "New Staff";
            this.Load += new System.EventHandler(this.frmStaffManagement_NewStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffPhoneNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox ckAvailable;
        private System.Windows.Forms.ComboBox cbStaffDepartment;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
    }
}