namespace SLMCS_ERP
{
    partial class frmGoodsReceivedHistory
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
            this.lblDStaffIDData = new System.Windows.Forms.Label();
            this.lblDEditDateData = new System.Windows.Forms.Label();
            this.lblDOrderDateData = new System.Windows.Forms.Label();
            this.lblDReceivedDateData = new System.Windows.Forms.Label();
            this.lblDReorderOrderIDData = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvReceivedOrderLine = new System.Windows.Forms.DataGridView();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblReorderOrderID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGoodsReceivedList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOrderDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDateFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrderLine)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsReceivedList)).BeginInit();
            this.SuspendLayout();
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
            this.lblDEditDateData.Location = new System.Drawing.Point(366, 60);
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
            // lblDReceivedDateData
            // 
            this.lblDReceivedDateData.AutoSize = true;
            this.lblDReceivedDateData.Location = new System.Drawing.Point(141, 89);
            this.lblDReceivedDateData.Name = "lblDReceivedDateData";
            this.lblDReceivedDateData.Size = new System.Drawing.Size(93, 16);
            this.lblDReceivedDateData.TabIndex = 30;
            this.lblDReceivedDateData.Text = "Received Date ";
            // 
            // lblDReorderOrderIDData
            // 
            this.lblDReorderOrderIDData.AutoSize = true;
            this.lblDReorderOrderIDData.Location = new System.Drawing.Point(141, 32);
            this.lblDReorderOrderIDData.Name = "lblDReorderOrderIDData";
            this.lblDReorderOrderIDData.Size = new System.Drawing.Size(108, 16);
            this.lblDReorderOrderIDData.TabIndex = 29;
            this.lblDReorderOrderIDData.Text = "Reorder Order ID ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 60);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Reorder Order ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Received Date :";
            // 
            // dgvReceivedOrderLine
            // 
            this.dgvReceivedOrderLine.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReceivedOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivedOrderLine.Location = new System.Drawing.Point(9, 122);
            this.dgvReceivedOrderLine.Name = "dgvReceivedOrderLine";
            this.dgvReceivedOrderLine.RowTemplate.Height = 24;
            this.dgvReceivedOrderLine.Size = new System.Drawing.Size(478, 400);
            this.dgvReceivedOrderLine.TabIndex = 8;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(136, 66);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(133, 23);
            this.txtStaffID.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(287, 184);
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
            this.label4.Location = new System.Drawing.Point(72, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Staff ID :";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(136, 32);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(133, 23);
            this.txtOrderID.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(17, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(260, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblReorderOrderID
            // 
            this.lblReorderOrderID.AutoSize = true;
            this.lblReorderOrderID.Location = new System.Drawing.Point(65, 35);
            this.lblReorderOrderID.Name = "lblReorderOrderID";
            this.lblReorderOrderID.Size = new System.Drawing.Size(62, 16);
            this.lblReorderOrderID.TabIndex = 0;
            this.lblReorderOrderID.Text = "Order ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDStaffIDData);
            this.groupBox2.Controls.Add(this.lblDEditDateData);
            this.groupBox2.Controls.Add(this.lblDOrderDateData);
            this.groupBox2.Controls.Add(this.lblDReceivedDateData);
            this.groupBox2.Controls.Add(this.lblDReorderOrderIDData);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvReceivedOrderLine);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(496, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 530);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received Order Detail";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 231);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Condition";
            // 
            // dgvGoodsReceivedList
            // 
            this.dgvGoodsReceivedList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGoodsReceivedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsReceivedList.Location = new System.Drawing.Point(10, 249);
            this.dgvGoodsReceivedList.Name = "dgvGoodsReceivedList";
            this.dgvGoodsReceivedList.RowTemplate.Height = 24;
            this.dgvGoodsReceivedList.Size = new System.Drawing.Size(464, 293);
            this.dgvGoodsReceivedList.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(275, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "-";
            // 
            // dtpOrderDateTo
            // 
            this.dtpOrderDateTo.Location = new System.Drawing.Point(297, 100);
            this.dtpOrderDateTo.Name = "dtpOrderDateTo";
            this.dtpOrderDateTo.Size = new System.Drawing.Size(134, 23);
            this.dtpOrderDateTo.TabIndex = 29;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(50, 105);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(77, 16);
            this.lblOrderDate.TabIndex = 28;
            this.lblOrderDate.Text = "Order Date :";
            // 
            // dtpOrderDateFrom
            // 
            this.dtpOrderDateFrom.Location = new System.Drawing.Point(136, 100);
            this.dtpOrderDateFrom.Name = "dtpOrderDateFrom";
            this.dtpOrderDateFrom.Size = new System.Drawing.Size(133, 23);
            this.dtpOrderDateFrom.TabIndex = 27;
            // 
            // frmGoodsReceivedHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGoodsReceivedList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGoodsReceivedHistory";
            this.Text = "frmGoodsReceivedHistory";
            this.Load += new System.EventHandler(this.FrmGoodsReceivedHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrderLine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsReceivedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDStaffIDData;
        private System.Windows.Forms.Label lblDEditDateData;
        private System.Windows.Forms.Label lblDOrderDateData;
        private System.Windows.Forms.Label lblDReceivedDateData;
        private System.Windows.Forms.Label lblDReorderOrderIDData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvReceivedOrderLine;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblReorderOrderID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGoodsReceivedList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOrderDateTo;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDateFrom;
    }
}