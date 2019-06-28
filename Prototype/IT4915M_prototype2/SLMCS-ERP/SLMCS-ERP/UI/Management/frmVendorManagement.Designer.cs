namespace SLMCS_ERP.UI.Management
{
    partial class frmVendorManagement
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
            this.btnNewVendor = new System.Windows.Forms.Button();
            this.dgvVendorList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditVendor = new System.Windows.Forms.Button();
            this.btnSearchVendor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorPhoneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblVendorPhoneNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVendorStatus = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorAddress = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewVendor
            // 
            this.btnNewVendor.Location = new System.Drawing.Point(486, 308);
            this.btnNewVendor.Name = "btnNewVendor";
            this.btnNewVendor.Size = new System.Drawing.Size(148, 30);
            this.btnNewVendor.TabIndex = 3;
            this.btnNewVendor.Text = "New Vendor Entry";
            this.btnNewVendor.UseVisualStyleBackColor = true;
            this.btnNewVendor.Click += new System.EventHandler(this.BtnNewVendor_Click);
            // 
            // dgvVendorList
            // 
            this.dgvVendorList.AllowUserToAddRows = false;
            this.dgvVendorList.AllowUserToResizeColumns = false;
            this.dgvVendorList.AllowUserToResizeRows = false;
            this.dgvVendorList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVendorList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvVendorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVendorList.Location = new System.Drawing.Point(0, 21);
            this.dgvVendorList.Name = "dgvVendorList";
            this.dgvVendorList.ReadOnly = true;
            this.dgvVendorList.RowTemplate.Height = 24;
            this.dgvVendorList.Size = new System.Drawing.Size(646, 276);
            this.dgvVendorList.TabIndex = 0;
            this.dgvVendorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendorList_CellClick);
            this.dgvVendorList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendorList_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNewVendor);
            this.groupBox3.Controls.Add(this.dgvVendorList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(18, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 352);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendor List";
            // 
            // btnEditVendor
            // 
            this.btnEditVendor.Location = new System.Drawing.Point(97, 385);
            this.btnEditVendor.Name = "btnEditVendor";
            this.btnEditVendor.Size = new System.Drawing.Size(148, 30);
            this.btnEditVendor.TabIndex = 1;
            this.btnEditVendor.Text = "Edit Vendor Info";
            this.btnEditVendor.UseVisualStyleBackColor = true;
            this.btnEditVendor.Click += new System.EventHandler(this.BtnEditVendor_Click);
            // 
            // btnSearchVendor
            // 
            this.btnSearchVendor.Location = new System.Drawing.Point(351, 84);
            this.btnSearchVendor.Name = "btnSearchVendor";
            this.btnSearchVendor.Size = new System.Drawing.Size(251, 25);
            this.btnSearchVendor.TabIndex = 9;
            this.btnSearchVendor.Text = "Search";
            this.btnSearchVendor.UseVisualStyleBackColor = true;
            this.btnSearchVendor.Click += new System.EventHandler(this.BtnSearchVendor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVendorName);
            this.groupBox1.Controls.Add(this.btnSearchVendor);
            this.groupBox1.Controls.Add(this.txtVendorPhoneNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVendorID);
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
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(132, 84);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(161, 23);
            this.txtVendorName.TabIndex = 8;
            // 
            // txtVendorPhoneNo
            // 
            this.txtVendorPhoneNo.Location = new System.Drawing.Point(464, 35);
            this.txtVendorPhoneNo.Name = "txtVendorPhoneNo";
            this.txtVendorPhoneNo.Size = new System.Drawing.Size(138, 23);
            this.txtVendorPhoneNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor ID :";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(132, 35);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(161, 23);
            this.txtVendorID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendor Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(348, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vendor Phone No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vendor ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Vendor Address :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Vendor Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Vendor Phone No :";
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(158, 50);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(23, 17);
            this.lblVendorID.TabIndex = 15;
            this.lblVendorID.Text = "---";
            // 
            // lblVendorPhoneNo
            // 
            this.lblVendorPhoneNo.AutoSize = true;
            this.lblVendorPhoneNo.Location = new System.Drawing.Point(158, 164);
            this.lblVendorPhoneNo.Name = "lblVendorPhoneNo";
            this.lblVendorPhoneNo.Size = new System.Drawing.Size(23, 17);
            this.lblVendorPhoneNo.TabIndex = 17;
            this.lblVendorPhoneNo.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(94, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Status :";
            // 
            // lblVendorStatus
            // 
            this.lblVendorStatus.AutoSize = true;
            this.lblVendorStatus.Location = new System.Drawing.Point(158, 301);
            this.lblVendorStatus.Name = "lblVendorStatus";
            this.lblVendorStatus.Size = new System.Drawing.Size(23, 17);
            this.lblVendorStatus.TabIndex = 22;
            this.lblVendorStatus.Text = "---";
            // 
            // lblVendorName
            // 
            this.lblVendorName.Location = new System.Drawing.Point(158, 106);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(158, 36);
            this.lblVendorName.TabIndex = 23;
            this.lblVendorName.Text = "---";
            // 
            // lblVendorAddress
            // 
            this.lblVendorAddress.Location = new System.Drawing.Point(158, 220);
            this.lblVendorAddress.Name = "lblVendorAddress";
            this.lblVendorAddress.Size = new System.Drawing.Size(158, 67);
            this.lblVendorAddress.TabIndex = 25;
            this.lblVendorAddress.Text = "---";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVendorAddress);
            this.groupBox2.Controls.Add(this.btnEditVendor);
            this.groupBox2.Controls.Add(this.lblVendorName);
            this.groupBox2.Controls.Add(this.lblVendorStatus);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblVendorPhoneNo);
            this.groupBox2.Controls.Add(this.lblVendorID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(676, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 501);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendor Detail";
            // 
            // frmVendorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendorManagement";
            this.Text = "frmVendorManagement";
            this.Load += new System.EventHandler(this.FrmVendorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewVendor;
        private System.Windows.Forms.DataGridView dgvVendorList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditVendor;
        private System.Windows.Forms.Button btnSearchVendor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVendorPhoneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblVendorPhoneNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVendorStatus;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorAddress;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}