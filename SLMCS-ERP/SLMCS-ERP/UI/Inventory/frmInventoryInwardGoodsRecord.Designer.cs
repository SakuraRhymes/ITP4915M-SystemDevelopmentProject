namespace SLMCS_ERP
{
    partial class frmInventoryInwardGoodsRecord
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
            this.dgvInwardGoodsRecord = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReorderOrderID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblReorderOrderID = new System.Windows.Forms.Label();
            this.dgvReorderOrderLine = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDCompletedDateData = new System.Windows.Forms.Label();
            this.lblDStaffIDData = new System.Windows.Forms.Label();
            this.lblDEditDateData = new System.Windows.Forms.Label();
            this.lblDOrderDateData = new System.Windows.Forms.Label();
            this.lblDReceivedDateData = new System.Windows.Forms.Label();
            this.lblDReorderOrderIDData = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInwardGoodsRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderOrderLine)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInwardGoodsRecord
            // 
            this.dgvInwardGoodsRecord.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvInwardGoodsRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInwardGoodsRecord.Location = new System.Drawing.Point(27, 245);
            this.dgvInwardGoodsRecord.Name = "dgvInwardGoodsRecord";
            this.dgvInwardGoodsRecord.RowTemplate.Height = 24;
            this.dgvInwardGoodsRecord.Size = new System.Drawing.Size(464, 293);
            this.dgvInwardGoodsRecord.TabIndex = 0;
            this.dgvInwardGoodsRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInwardGoodsRecord_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReorderOrderID);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblReorderOrderID);
            //this.groupBox1.Controls.Add(this.lblOrderDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(27, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 231);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Condition";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(136, 66);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(140, 23);
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
            // label2
            // 
            //this.label2.AutoSize = true;
            //this.label2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            //this.label2.Location = new System.Drawing.Point(282, 102);
            //this.label2.Name = "label2";
            //this.label2.Size = new System.Drawing.Size(18, 21);
            //this.label2.TabIndex = 21;
            //this.label2.Text = "-";
            // 
            // label3
            // 
            //this.label3.AutoSize = true;
            //this.label3.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            //this.label3.Location = new System.Drawing.Point(282, 137);
            //this.label3.Name = "label3";
            //this.label3.Size = new System.Drawing.Size(18, 21);
            //this.label3.TabIndex = 20;
            //this.label3.Text = "-";
            // 
            // dtpCompletedDateTo
            // 
            //this.dtpCompletedDateTo.Location = new System.Drawing.Point(306, 137);
            //this.dtpCompletedDateTo.Name = "dtpCompletedDateTo";
            //this.dtpCompletedDateTo.Size = new System.Drawing.Size(140, 23);
            //this.dtpCompletedDateTo.TabIndex = 18;
            // 
            // dtpCompletedDateFrom
            // 
            //this.dtpCompletedDateFrom.Location = new System.Drawing.Point(136, 136);
            //this.dtpCompletedDateFrom.Name = "dtpCompletedDateFrom";
            //this.dtpCompletedDateFrom.Size = new System.Drawing.Size(140, 23);
            //this.dtpCompletedDateFrom.TabIndex = 17;
            // 
            // label1
            // 
            //this.label1.AutoSize = true;
            //this.label1.Location = new System.Drawing.Point(19, 142);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(108, 16);
            //this.label1.TabIndex = 16;
            //this.label1.Text = "Completed Date :";
            // 
            // dtpOrderDateTo
            // 
            //this.dtpOrderDateTo.Location = new System.Drawing.Point(306, 101);
            //this.dtpOrderDateTo.Name = "dtpOrderDateTo";
            //this.dtpOrderDateTo.Size = new System.Drawing.Size(140, 23);
            //this.dtpOrderDateTo.TabIndex = 15;
            // 
            // dtpOrderDateFrom
            // 
            //this.dtpOrderDateFrom.Location = new System.Drawing.Point(136, 101);
            //this.dtpOrderDateFrom.Name = "dtpOrderDateFrom";
            //this.dtpOrderDateFrom.Size = new System.Drawing.Size(140, 23);
            //this.dtpOrderDateFrom.TabIndex = 8;
            // 
            // txtReorderOrderID
            // 
            this.txtReorderOrderID.Location = new System.Drawing.Point(136, 32);
            this.txtReorderOrderID.Name = "txtReorderOrderID";
            this.txtReorderOrderID.Size = new System.Drawing.Size(140, 23);
            this.txtReorderOrderID.TabIndex = 9;
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
            this.lblReorderOrderID.Location = new System.Drawing.Point(16, 35);
            this.lblReorderOrderID.Name = "lblReorderOrderID";
            this.lblReorderOrderID.Size = new System.Drawing.Size(111, 16);
            this.lblReorderOrderID.TabIndex = 0;
            this.lblReorderOrderID.Text = "Reorder Order ID :";
            // 
            // lblOrderDate
            // 
            //this.lblOrderDate.AutoSize = true;
            //this.lblOrderDate.Location = new System.Drawing.Point(50, 107);
            //this.lblOrderDate.Name = "lblOrderDate";
            //this.lblOrderDate.Size = new System.Drawing.Size(77, 16);
            //this.lblOrderDate.TabIndex = 1;
            //this.lblOrderDate.Text = "Order Date :";
            // 
            // dgvReorderOrderLine
            // 
            this.dgvReorderOrderLine.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReorderOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReorderOrderLine.Location = new System.Drawing.Point(9, 122);
            this.dgvReorderOrderLine.Name = "dgvReorderOrderLine";
            this.dgvReorderOrderLine.RowTemplate.Height = 24;
            this.dgvReorderOrderLine.Size = new System.Drawing.Size(478, 400);
            this.dgvReorderOrderLine.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDCompletedDateData);
            this.groupBox2.Controls.Add(this.lblDStaffIDData);
            this.groupBox2.Controls.Add(this.lblDEditDateData);
            this.groupBox2.Controls.Add(this.lblDOrderDateData);
            this.groupBox2.Controls.Add(this.lblDReceivedDateData);
            this.groupBox2.Controls.Add(this.lblDReorderOrderIDData);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvReorderOrderLine);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(513, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 530);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inward Goods Record Detail";
            // 
            // lblDCompletedDateData
            // 
            this.lblDCompletedDateData.AutoSize = true;
            this.lblDCompletedDateData.Location = new System.Drawing.Point(366, 88);
            this.lblDCompletedDateData.Name = "lblDCompletedDateData";
            this.lblDCompletedDateData.Size = new System.Drawing.Size(91, 16);
            this.lblDCompletedDateData.TabIndex = 34;
            this.lblDCompletedDateData.Text = "complete date";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Completed Date :";
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
            // frmInventoryInwardGoodsRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInwardGoodsRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryInwardGoodsRecord";
            this.Text = "frmInventoryInwardGoodsRecord";
            this.Load += new System.EventHandler(this.FrmInventoryInwardGoodsRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInwardGoodsRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderOrderLine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInwardGoodsRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReorderOrderID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblReorderOrderID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReorderOrderLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDCompletedDateData;
        private System.Windows.Forms.Label lblDStaffIDData;
        private System.Windows.Forms.Label lblDEditDateData;
        private System.Windows.Forms.Label lblDOrderDateData;
        private System.Windows.Forms.Label lblDReceivedDateData;
        private System.Windows.Forms.Label lblDReorderOrderIDData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}