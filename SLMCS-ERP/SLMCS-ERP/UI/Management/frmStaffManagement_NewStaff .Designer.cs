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
            this.ckAvailable = new System.Windows.Forms.CheckBox();
            this.cbStaffDepartment = new System.Windows.Forms.ComboBox();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStaffID.Location = new System.Drawing.Point(145, 34);
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
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(71, 343);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(192, 343);
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
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(72, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Available :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(36, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 52;
            this.label11.Text = "Staff Phone No :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(55, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Department :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(59, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Staff Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(81, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Staff ID :";
            // 
            // ckAvailable
            // 
            this.ckAvailable.AutoSize = true;
            this.ckAvailable.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckAvailable.Location = new System.Drawing.Point(145, 289);
            this.ckAvailable.Name = "ckAvailable";
            this.ckAvailable.Size = new System.Drawing.Size(15, 14);
            this.ckAvailable.TabIndex = 62;
            this.ckAvailable.UseVisualStyleBackColor = true;
            // 
            // cbStaffDepartment
            // 
            this.cbStaffDepartment.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbStaffDepartment.FormattingEnabled = true;
            this.cbStaffDepartment.Items.AddRange(new object[] {
            "SA",
            "HR",
            "FI",
            "PO",
            "WH"});
            this.cbStaffDepartment.Location = new System.Drawing.Point(145, 236);
            this.cbStaffDepartment.Name = "cbStaffDepartment";
            this.cbStaffDepartment.Size = new System.Drawing.Size(61, 25);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(68, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Password :";
            // 
            // frmStaffManagement_NewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 400);
            this.Controls.Add(this.cbStaffDepartment);
            this.Controls.Add(this.ckAvailable);
            this.Controls.Add(this.txtStaffPassword);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStaffManagement_NewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.CheckBox ckAvailable;
        private System.Windows.Forms.ComboBox cbStaffDepartment;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Label label8;
    }
}