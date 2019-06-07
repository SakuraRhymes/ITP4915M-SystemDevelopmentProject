namespace SLMCS_ERP.UI.Management
{
    partial class frmStaffManagement
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
            this.btnNewStaff = new System.Windows.Forms.Button();
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.lblStaffStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStaffPhoneNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStaffPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStaffDepartment = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffPhoneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNewStaff.Location = new System.Drawing.Point(488, 319);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(148, 30);
            this.btnNewStaff.TabIndex = 3;
            this.btnNewStaff.Text = "New Staff Entry";
            this.btnNewStaff.UseVisualStyleBackColor = true;
            this.btnNewStaff.Click += new System.EventHandler(this.BtnNewStaff_Click);
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.AllowUserToAddRows = false;
            this.dgvStaffList.AllowUserToResizeColumns = false;
            this.dgvStaffList.AllowUserToResizeRows = false;
            this.dgvStaffList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStaffList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffList.Location = new System.Drawing.Point(0, 21);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.ReadOnly = true;
            this.dgvStaffList.RowTemplate.Height = 24;
            this.dgvStaffList.Size = new System.Drawing.Size(646, 289);
            this.dgvStaffList.TabIndex = 0;
            this.dgvStaffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStaffList_CellClick);
            this.dgvStaffList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStaffList_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNewStaff);
            this.groupBox3.Controls.Add(this.dgvStaffList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(18, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 361);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Staff List";
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditStaff.Location = new System.Drawing.Point(94, 358);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(148, 30);
            this.btnEditStaff.TabIndex = 1;
            this.btnEditStaff.Text = "Edit Staff Info";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.BtnEditStaff_Click);
            // 
            // lblStaffStatus
            // 
            this.lblStaffStatus.AutoSize = true;
            this.lblStaffStatus.Location = new System.Drawing.Point(152, 266);
            this.lblStaffStatus.Name = "lblStaffStatus";
            this.lblStaffStatus.Size = new System.Drawing.Size(23, 17);
            this.lblStaffStatus.TabIndex = 22;
            this.lblStaffStatus.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Status :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDepartmentID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnEditStaff);
            this.groupBox2.Controls.Add(this.lblStaffName);
            this.groupBox2.Controls.Add(this.lblStaffStatus);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblStaffPhoneNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblStaffPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblStaffID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(676, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 510);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff Detail";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(152, 225);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(23, 17);
            this.lblDepartmentID.TabIndex = 24;
            this.lblDepartmentID.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(53, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Department ID :";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(152, 89);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(23, 17);
            this.lblStaffName.TabIndex = 23;
            this.lblStaffName.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Staff ID :";
            // 
            // lblStaffPhoneNo
            // 
            this.lblStaffPhoneNo.AutoSize = true;
            this.lblStaffPhoneNo.Location = new System.Drawing.Point(152, 136);
            this.lblStaffPhoneNo.Name = "lblStaffPhoneNo";
            this.lblStaffPhoneNo.Size = new System.Drawing.Size(23, 17);
            this.lblStaffPhoneNo.TabIndex = 17;
            this.lblStaffPhoneNo.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Staff Name :";
            // 
            // lblStaffPassword
            // 
            this.lblStaffPassword.AutoSize = true;
            this.lblStaffPassword.Location = new System.Drawing.Point(152, 181);
            this.lblStaffPassword.Name = "lblStaffPassword";
            this.lblStaffPassword.Size = new System.Drawing.Size(23, 17);
            this.lblStaffPassword.TabIndex = 16;
            this.lblStaffPassword.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(51, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Staff Phone No :";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(152, 48);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(23, 17);
            this.lblStaffID.TabIndex = 15;
            this.lblStaffID.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password :";
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchStaff.Location = new System.Drawing.Point(343, 98);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(250, 25);
            this.btnSearchStaff.TabIndex = 9;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.BtnSearchStaff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStaffDepartment);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.btnSearchStaff);
            this.groupBox1.Controls.Add(this.txtStaffPhoneNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(18, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 142);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Condition";
            // 
            // cbStaffDepartment
            // 
            this.cbStaffDepartment.BackColor = System.Drawing.Color.White;
            this.cbStaffDepartment.FormattingEnabled = true;
            this.cbStaffDepartment.Items.AddRange(new object[] {
            "SA",
            "HR",
            "FI",
            "PO",
            "WH",
            " "});
            this.cbStaffDepartment.Location = new System.Drawing.Point(451, 28);
            this.cbStaffDepartment.Name = "cbStaffDepartment";
            this.cbStaffDepartment.Size = new System.Drawing.Size(142, 25);
            this.cbStaffDepartment.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label20.Location = new System.Drawing.Point(340, 31);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 15);
            this.label20.TabIndex = 10;
            this.label20.Text = "Staff Department :";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(132, 64);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(169, 23);
            this.txtStaffName.TabIndex = 8;
            // 
            // txtStaffPhoneNo
            // 
            this.txtStaffPhoneNo.Location = new System.Drawing.Point(132, 100);
            this.txtStaffPhoneNo.Name = "txtStaffPhoneNo";
            this.txtStaffPhoneNo.Size = new System.Drawing.Size(169, 23);
            this.txtStaffPhoneNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID :";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(132, 28);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(169, 23);
            this.txtStaffID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(31, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Staff Phone No :";
            // 
            // frmStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaffManagement";
            this.Text = "frmStaffManagement";
            this.Load += new System.EventHandler(this.FrmStaffManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewStaff;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Label lblStaffStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStaffPhoneNo;
        private System.Windows.Forms.Label lblStaffPassword;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffPhoneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbStaffDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}