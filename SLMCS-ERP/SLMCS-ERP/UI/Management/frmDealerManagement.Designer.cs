namespace SLMCS_ERP.UI.Management
{
    partial class frmDealerManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.txtDealerPhoneNo = new System.Windows.Forms.TextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.btnSearchDealer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDealerStatus = new System.Windows.Forms.Label();
            this.btnEditDealer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDealerInvoiceAddress = new System.Windows.Forms.Label();
            this.lblDealerShippingAddress = new System.Windows.Forms.Label();
            this.lblDealerPhoneNo = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.lblDealerID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDealerList = new System.Windows.Forms.DataGridView();
            this.btnNewDealer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealerList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dealer Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(333, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number :";
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(118, 29);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(164, 23);
            this.txtDealerID.TabIndex = 6;
            // 
            // txtDealerPhoneNo
            // 
            this.txtDealerPhoneNo.Location = new System.Drawing.Point(439, 29);
            this.txtDealerPhoneNo.Name = "txtDealerPhoneNo";
            this.txtDealerPhoneNo.Size = new System.Drawing.Size(164, 23);
            this.txtDealerPhoneNo.TabIndex = 7;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(119, 79);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(164, 23);
            this.txtDealerName.TabIndex = 8;
            // 
            // btnSearchDealer
            // 
            this.btnSearchDealer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchDealer.Location = new System.Drawing.Point(336, 82);
            this.btnSearchDealer.Name = "btnSearchDealer";
            this.btnSearchDealer.Size = new System.Drawing.Size(267, 25);
            this.btnSearchDealer.TabIndex = 9;
            this.btnSearchDealer.Text = "Search";
            this.btnSearchDealer.UseVisualStyleBackColor = true;
            this.btnSearchDealer.Click += new System.EventHandler(this.BtnSearchDealer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDealerName);
            this.groupBox1.Controls.Add(this.btnSearchDealer);
            this.groupBox1.Controls.Add(this.txtDealerPhoneNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDealerID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(18, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 142);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Condition";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDealerStatus);
            this.groupBox2.Controls.Add(this.btnEditDealer);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblDealerInvoiceAddress);
            this.groupBox2.Controls.Add(this.lblDealerShippingAddress);
            this.groupBox2.Controls.Add(this.lblDealerPhoneNo);
            this.groupBox2.Controls.Add(this.lblDealerName);
            this.groupBox2.Controls.Add(this.lblDealerID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(676, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 510);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dealer Detail";
            // 
            // lblDealerStatus
            // 
            this.lblDealerStatus.AutoSize = true;
            this.lblDealerStatus.Location = new System.Drawing.Point(155, 355);
            this.lblDealerStatus.Name = "lblDealerStatus";
            this.lblDealerStatus.Size = new System.Drawing.Size(23, 16);
            this.lblDealerStatus.TabIndex = 22;
            this.lblDealerStatus.Text = "---";
            // 
            // btnEditDealer
            // 
            this.btnEditDealer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditDealer.Location = new System.Drawing.Point(98, 412);
            this.btnEditDealer.Name = "btnEditDealer";
            this.btnEditDealer.Size = new System.Drawing.Size(148, 30);
            this.btnEditDealer.TabIndex = 1;
            this.btnEditDealer.Text = "Edit Dealer Info";
            this.btnEditDealer.UseVisualStyleBackColor = true;
            this.btnEditDealer.Click += new System.EventHandler(this.BtnEditDealer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Status :";
            // 
            // lblDealerInvoiceAddress
            // 
            this.lblDealerInvoiceAddress.Location = new System.Drawing.Point(155, 269);
            this.lblDealerInvoiceAddress.Name = "lblDealerInvoiceAddress";
            this.lblDealerInvoiceAddress.Size = new System.Drawing.Size(136, 59);
            this.lblDealerInvoiceAddress.TabIndex = 19;
            this.lblDealerInvoiceAddress.Text = "---";
            // 
            // lblDealerShippingAddress
            // 
            this.lblDealerShippingAddress.Location = new System.Drawing.Point(155, 189);
            this.lblDealerShippingAddress.Name = "lblDealerShippingAddress";
            this.lblDealerShippingAddress.Size = new System.Drawing.Size(136, 55);
            this.lblDealerShippingAddress.TabIndex = 18;
            this.lblDealerShippingAddress.Text = "---";
            // 
            // lblDealerPhoneNo
            // 
            this.lblDealerPhoneNo.AutoSize = true;
            this.lblDealerPhoneNo.Location = new System.Drawing.Point(155, 140);
            this.lblDealerPhoneNo.Name = "lblDealerPhoneNo";
            this.lblDealerPhoneNo.Size = new System.Drawing.Size(23, 16);
            this.lblDealerPhoneNo.TabIndex = 17;
            this.lblDealerPhoneNo.Text = "---";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(155, 92);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(23, 16);
            this.lblDealerName.TabIndex = 16;
            this.lblDealerName.Text = "---";
            // 
            // lblDealerID
            // 
            this.lblDealerID.AutoSize = true;
            this.lblDealerID.Location = new System.Drawing.Point(155, 45);
            this.lblDealerID.Name = "lblDealerID";
            this.lblDealerID.Size = new System.Drawing.Size(23, 16);
            this.lblDealerID.TabIndex = 15;
            this.lblDealerID.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Phone Number :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Shipping Address :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Invoice Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dealer Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dealer ID :";
            // 
            // dgvDealerList
            // 
            this.dgvDealerList.AllowUserToAddRows = false;
            this.dgvDealerList.AllowUserToResizeColumns = false;
            this.dgvDealerList.AllowUserToResizeRows = false;
            this.dgvDealerList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDealerList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDealerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDealerList.Location = new System.Drawing.Point(0, 21);
            this.dgvDealerList.Name = "dgvDealerList";
            this.dgvDealerList.ReadOnly = true;
            this.dgvDealerList.RowTemplate.Height = 24;
            this.dgvDealerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDealerList.Size = new System.Drawing.Size(646, 288);
            this.dgvDealerList.TabIndex = 0;
            this.dgvDealerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDealerList_CellClick);
            this.dgvDealerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDealerList_CellDoubleClick);
            // 
            // btnNewDealer
            // 
            this.btnNewDealer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewDealer.Location = new System.Drawing.Point(490, 318);
            this.btnNewDealer.Name = "btnNewDealer";
            this.btnNewDealer.Size = new System.Drawing.Size(148, 30);
            this.btnNewDealer.TabIndex = 3;
            this.btnNewDealer.Text = "New Dealer Entry";
            this.btnNewDealer.UseVisualStyleBackColor = true;
            this.btnNewDealer.Click += new System.EventHandler(this.BtnNewDealer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNewDealer);
            this.groupBox3.Controls.Add(this.dgvDealerList);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(18, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 361);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dealer List";
            // 
            // frmDealerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDealerManagement";
            this.Text = "frmDealerManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealerList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.TextBox txtDealerPhoneNo;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Button btnSearchDealer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDealerInvoiceAddress;
        private System.Windows.Forms.Label lblDealerShippingAddress;
        private System.Windows.Forms.Label lblDealerPhoneNo;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Label lblDealerID;
        private System.Windows.Forms.Label lblDealerStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEditDealer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDealerList;
        private System.Windows.Forms.Button btnNewDealer;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}