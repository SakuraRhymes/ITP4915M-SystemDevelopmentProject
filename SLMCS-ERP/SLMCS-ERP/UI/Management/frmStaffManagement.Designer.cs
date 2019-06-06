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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblStaffInvoiceAddress = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStaffShippingAddress = new System.Windows.Forms.Label();
            this.lblStaffPhoneNo = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffPhoneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Location = new System.Drawing.Point(472, 295);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(75, 23);
            this.btnNewStaff.TabIndex = 3;
            this.btnNewStaff.Text = "New Staff";
            this.btnNewStaff.UseVisualStyleBackColor = true;
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.AllowUserToAddRows = false;
            this.dgvStaffList.AllowUserToResizeColumns = false;
            this.dgvStaffList.AllowUserToResizeRows = false;
            this.dgvStaffList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffList.Location = new System.Drawing.Point(0, 21);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.ReadOnly = true;
            this.dgvStaffList.RowTemplate.Height = 24;
            this.dgvStaffList.Size = new System.Drawing.Size(646, 261);
            this.dgvStaffList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNewStaff);
            this.groupBox3.Controls.Add(this.btnEditStaff);
            this.groupBox3.Controls.Add(this.dgvStaffList);
            this.groupBox3.Location = new System.Drawing.Point(18, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 325);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Staff List";
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Location = new System.Drawing.Point(565, 295);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(75, 23);
            this.btnEditStaff.TabIndex = 1;
            this.btnEditStaff.Text = "Edit Staff";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            // 
            // lblStaffStatus
            // 
            this.lblStaffStatus.AutoSize = true;
            this.lblStaffStatus.Location = new System.Drawing.Point(136, 388);
            this.lblStaffStatus.Name = "lblStaffStatus";
            this.lblStaffStatus.Size = new System.Drawing.Size(17, 12);
            this.lblStaffStatus.TabIndex = 22;
            this.lblStaffStatus.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(110, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(8, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "Staff Status";
            // 
            // lblStaffInvoiceAddress
            // 
            this.lblStaffInvoiceAddress.Location = new System.Drawing.Point(136, 213);
            this.lblStaffInvoiceAddress.Name = "lblStaffInvoiceAddress";
            this.lblStaffInvoiceAddress.Size = new System.Drawing.Size(136, 59);
            this.lblStaffInvoiceAddress.TabIndex = 19;
            this.lblStaffInvoiceAddress.Text = "---";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStaffStatus);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblStaffInvoiceAddress);
            this.groupBox2.Controls.Add(this.lblStaffShippingAddress);
            this.groupBox2.Controls.Add(this.lblStaffPhoneNo);
            this.groupBox2.Controls.Add(this.lblStaffName);
            this.groupBox2.Controls.Add(this.lblStaffID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(676, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 474);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff Detail";
            // 
            // lblStaffShippingAddress
            // 
            this.lblStaffShippingAddress.Location = new System.Drawing.Point(136, 311);
            this.lblStaffShippingAddress.Name = "lblStaffShippingAddress";
            this.lblStaffShippingAddress.Size = new System.Drawing.Size(136, 55);
            this.lblStaffShippingAddress.TabIndex = 18;
            this.lblStaffShippingAddress.Text = "---";
            // 
            // lblStaffPhoneNo
            // 
            this.lblStaffPhoneNo.AutoSize = true;
            this.lblStaffPhoneNo.Location = new System.Drawing.Point(136, 157);
            this.lblStaffPhoneNo.Name = "lblStaffPhoneNo";
            this.lblStaffPhoneNo.Size = new System.Drawing.Size(17, 12);
            this.lblStaffPhoneNo.TabIndex = 17;
            this.lblStaffPhoneNo.Text = "---";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(136, 102);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(17, 12);
            this.lblStaffName.TabIndex = 16;
            this.lblStaffName.Text = "---";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(136, 45);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(17, 12);
            this.lblStaffID.TabIndex = 15;
            this.lblStaffID.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(110, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(8, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(110, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(8, 12);
            this.label19.TabIndex = 12;
            this.label19.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(110, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(8, 12);
            this.label18.TabIndex = 11;
            this.label18.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(110, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(8, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(110, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(8, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "Shipping Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Invoice Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(558, 111);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(82, 25);
            this.btnSearchStaff.TabIndex = 9;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.btnSearchStaff);
            this.groupBox1.Controls.Add(this.txtStaffPhoneNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 142);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(156, 63);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(136, 22);
            this.txtStaffName.TabIndex = 8;
            // 
            // txtStaffPhoneNo
            // 
            this.txtStaffPhoneNo.Location = new System.Drawing.Point(156, 99);
            this.txtStaffPhoneNo.Name = "txtStaffPhoneNo";
            this.txtStaffPhoneNo.Size = new System.Drawing.Size(136, 22);
            this.txtStaffPhoneNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID ";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(156, 27);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(136, 22);
            this.txtStaffID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Name ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(8, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(8, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9F);
            this.label5.Location = new System.Drawing.Point(26, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "StaffPhoneNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(8, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // frmStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaffManagement";
            this.Text = "frmStaffManagement";
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblStaffInvoiceAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStaffShippingAddress;
        private System.Windows.Forms.Label lblStaffPhoneNo;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffPhoneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}