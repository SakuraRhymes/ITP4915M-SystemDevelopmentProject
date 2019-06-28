namespace SLMCS_ERP.UI.Dispatch
{
    partial class frmDispatchedRecord
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
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblDStaffIDData = new System.Windows.Forms.Label();
            this.lblDEditDateData = new System.Windows.Forms.Label();
            this.lblDOrderDateData = new System.Windows.Forms.Label();
            this.lblDDispatchedDateData = new System.Windows.Forms.Label();
            this.lblReorderOrderID = new System.Windows.Forms.Label();
            this.lblDSalesOrderIDData = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDispatchedDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDispatchedDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOrderDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDispatchedOrderLine = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDDealerIDData = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDispatchedList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatchedOrderLine)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatchedList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(136, 60);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(133, 23);
            this.txtStaffID.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(287, 193);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Staff ID :";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(136, 26);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(133, 23);
            this.txtOrderID.TabIndex = 9;
            // 
            // lblDStaffIDData
            // 
            this.lblDStaffIDData.AutoSize = true;
            this.lblDStaffIDData.Location = new System.Drawing.Point(366, 32);
            this.lblDStaffIDData.Name = "lblDStaffIDData";
            this.lblDStaffIDData.Size = new System.Drawing.Size(46, 16);
            this.lblDStaffIDData.TabIndex = 33;
            this.lblDStaffIDData.Text = "staff id";
            // 
            // lblDEditDateData
            // 
            this.lblDEditDateData.AutoSize = true;
            this.lblDEditDateData.Location = new System.Drawing.Point(366, 89);
            this.lblDEditDateData.Name = "lblDEditDateData";
            this.lblDEditDateData.Size = new System.Drawing.Size(59, 16);
            this.lblDEditDateData.TabIndex = 32;
            this.lblDEditDateData.Text = "Edit date";
            // 
            // lblDOrderDateData
            // 
            this.lblDOrderDateData.AutoSize = true;
            this.lblDOrderDateData.Location = new System.Drawing.Point(141, 60);
            this.lblDOrderDateData.Name = "lblDOrderDateData";
            this.lblDOrderDateData.Size = new System.Drawing.Size(77, 16);
            this.lblDOrderDateData.TabIndex = 31;
            this.lblDOrderDateData.Text = "Order Date :";
            // 
            // lblDDispatchedDateData
            // 
            this.lblDDispatchedDateData.AutoSize = true;
            this.lblDDispatchedDateData.Location = new System.Drawing.Point(141, 89);
            this.lblDDispatchedDateData.Name = "lblDDispatchedDateData";
            this.lblDDispatchedDateData.Size = new System.Drawing.Size(105, 16);
            this.lblDDispatchedDateData.TabIndex = 30;
            this.lblDDispatchedDateData.Text = "Dispatched Date ";
            // 
            // lblReorderOrderID
            // 
            this.lblReorderOrderID.AutoSize = true;
            this.lblReorderOrderID.Location = new System.Drawing.Point(65, 29);
            this.lblReorderOrderID.Name = "lblReorderOrderID";
            this.lblReorderOrderID.Size = new System.Drawing.Size(62, 16);
            this.lblReorderOrderID.TabIndex = 0;
            this.lblReorderOrderID.Text = "Order ID :";
            // 
            // lblDSalesOrderIDData
            // 
            this.lblDSalesOrderIDData.AutoSize = true;
            this.lblDSalesOrderIDData.Location = new System.Drawing.Point(141, 32);
            this.lblDSalesOrderIDData.Name = "lblDSalesOrderIDData";
            this.lblDSalesOrderIDData.Size = new System.Drawing.Size(91, 16);
            this.lblDSalesOrderIDData.TabIndex = 29;
            this.lblDSalesOrderIDData.Text = "Sales Order ID ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Edit Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Order Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Staff ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(275, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "-";
            // 
            // dtpDispatchedDateTo
            // 
            this.dtpDispatchedDateTo.Location = new System.Drawing.Point(297, 157);
            this.dtpDispatchedDateTo.Name = "dtpDispatchedDateTo";
            this.dtpDispatchedDateTo.Size = new System.Drawing.Size(134, 23);
            this.dtpDispatchedDateTo.TabIndex = 33;
            this.dtpDispatchedDateTo.ValueChanged += new System.EventHandler(this.DtpDispatchedDateTo_ValueChanged);
            // 
            // dtpDispatchedDateFrom
            // 
            this.dtpDispatchedDateFrom.Location = new System.Drawing.Point(136, 157);
            this.dtpDispatchedDateFrom.Name = "dtpDispatchedDateFrom";
            this.dtpDispatchedDateFrom.Size = new System.Drawing.Size(133, 23);
            this.dtpDispatchedDateFrom.TabIndex = 31;
            this.dtpDispatchedDateFrom.ValueChanged += new System.EventHandler(this.DtpDispatchedDateFrom_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(17, 193);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(260, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sales Order ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDealerID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDispatchedDateTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDispatchedDateFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpOrderDateTo);
            this.groupBox1.Controls.Add(this.lblOrderDate);
            this.groupBox1.Controls.Add(this.dtpOrderDateFrom);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblReorderOrderID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 231);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Condition";
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(136, 93);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(133, 23);
            this.txtDealerID.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Dealer ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Dispatched Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(275, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "-";
            // 
            // dtpOrderDateTo
            // 
            this.dtpOrderDateTo.Location = new System.Drawing.Point(297, 125);
            this.dtpOrderDateTo.Name = "dtpOrderDateTo";
            this.dtpOrderDateTo.Size = new System.Drawing.Size(134, 23);
            this.dtpOrderDateTo.TabIndex = 29;
            this.dtpOrderDateTo.ValueChanged += new System.EventHandler(this.DtpOrderDateTo_ValueChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(50, 130);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(77, 16);
            this.lblOrderDate.TabIndex = 28;
            this.lblOrderDate.Text = "Order Date :";
            // 
            // dtpOrderDateFrom
            // 
            this.dtpOrderDateFrom.Location = new System.Drawing.Point(136, 125);
            this.dtpOrderDateFrom.Name = "dtpOrderDateFrom";
            this.dtpOrderDateFrom.Size = new System.Drawing.Size(133, 23);
            this.dtpOrderDateFrom.TabIndex = 27;
            this.dtpOrderDateFrom.ValueChanged += new System.EventHandler(this.DtpOrderDateFrom_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Dispatched Date :";
            // 
            // dgvDispatchedOrderLine
            // 
            this.dgvDispatchedOrderLine.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDispatchedOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispatchedOrderLine.Location = new System.Drawing.Point(9, 122);
            this.dgvDispatchedOrderLine.Name = "dgvDispatchedOrderLine";
            this.dgvDispatchedOrderLine.RowTemplate.Height = 24;
            this.dgvDispatchedOrderLine.Size = new System.Drawing.Size(478, 400);
            this.dgvDispatchedOrderLine.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDDealerIDData);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblDStaffIDData);
            this.groupBox2.Controls.Add(this.lblDEditDateData);
            this.groupBox2.Controls.Add(this.lblDOrderDateData);
            this.groupBox2.Controls.Add(this.lblDDispatchedDateData);
            this.groupBox2.Controls.Add(this.lblDSalesOrderIDData);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvDispatchedOrderLine);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 530);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dispatched Order Detail";
            // 
            // lblDDealerIDData
            // 
            this.lblDDealerIDData.AutoSize = true;
            this.lblDDealerIDData.Location = new System.Drawing.Point(366, 60);
            this.lblDDealerIDData.Name = "lblDDealerIDData";
            this.lblDDealerIDData.Size = new System.Drawing.Size(58, 16);
            this.lblDDealerIDData.TabIndex = 35;
            this.lblDDealerIDData.Text = "dealer id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Dealer ID :";
            // 
            // dgvDispatchedList
            // 
            this.dgvDispatchedList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDispatchedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispatchedList.Location = new System.Drawing.Point(12, 249);
            this.dgvDispatchedList.Name = "dgvDispatchedList";
            this.dgvDispatchedList.RowTemplate.Height = 24;
            this.dgvDispatchedList.Size = new System.Drawing.Size(464, 293);
            this.dgvDispatchedList.TabIndex = 16;
            this.dgvDispatchedList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDispatchedList_CellClick);
            // 
            // frmDispatchedRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDispatchedList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDispatchedRecord";
            this.Text = "frmDispatchedRecord";
            this.Load += new System.EventHandler(this.FrmDispatchedRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatchedOrderLine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatchedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblDStaffIDData;
        private System.Windows.Forms.Label lblDEditDateData;
        private System.Windows.Forms.Label lblDOrderDateData;
        private System.Windows.Forms.Label lblDDispatchedDateData;
        private System.Windows.Forms.Label lblReorderOrderID;
        private System.Windows.Forms.Label lblDSalesOrderIDData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDispatchedDateTo;
        private System.Windows.Forms.DateTimePicker dtpDispatchedDateFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOrderDateTo;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDateFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDispatchedOrderLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDispatchedList;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDDealerIDData;
        private System.Windows.Forms.Label label12;
    }
}