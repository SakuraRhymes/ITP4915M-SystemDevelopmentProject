namespace SLMCS_ERP
{
    partial class frmGoodsReceiveList
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
            this.OrderId = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.staffId = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgvGoodsRecevieList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpOrderDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpOrderDateFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsRecevieList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderId
            // 
            this.OrderId.AutoSize = true;
            this.OrderId.Location = new System.Drawing.Point(41, 33);
            this.OrderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(67, 17);
            this.OrderId.TabIndex = 0;
            this.OrderId.Text = "Order ID :";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(111, 29);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(141, 23);
            this.txtOrderID.TabIndex = 1;
            // 
            // staffId
            // 
            this.staffId.AutoSize = true;
            this.staffId.Location = new System.Drawing.Point(50, 84);
            this.staffId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffId.Name = "staffId";
            this.staffId.Size = new System.Drawing.Size(58, 17);
            this.staffId.TabIndex = 2;
            this.staffId.Text = "Staff ID :";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(111, 80);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(142, 23);
            this.txtStaffID.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(840, 348);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(141, 34);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm Receive";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // dgvGoodsRecevieList
            // 
            this.dgvGoodsRecevieList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoodsRecevieList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGoodsRecevieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsRecevieList.Location = new System.Drawing.Point(7, 18);
            this.dgvGoodsRecevieList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGoodsRecevieList.Name = "dgvGoodsRecevieList";
            this.dgvGoodsRecevieList.ReadOnly = true;
            this.dgvGoodsRecevieList.RowTemplate.Height = 27;
            this.dgvGoodsRecevieList.Size = new System.Drawing.Size(974, 324);
            this.dgvGoodsRecevieList.TabIndex = 10;
            this.dgvGoodsRecevieList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGoodsRecevieList_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(346, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 31);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dtpOrderDateTo);
            this.groupBox1.Controls.Add(this.lblOrderDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpOrderDateFrom);
            this.groupBox1.Controls.Add(this.OrderId);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.staffId);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 122);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Condition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(554, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "-";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(541, 77);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 31);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dtpOrderDateTo
            // 
            this.dtpOrderDateTo.Location = new System.Drawing.Point(578, 29);
            this.dtpOrderDateTo.Name = "dtpOrderDateTo";
            this.dtpOrderDateTo.Size = new System.Drawing.Size(134, 23);
            this.dtpOrderDateTo.TabIndex = 25;
            this.dtpOrderDateTo.ValueChanged += new System.EventHandler(this.DtpOrderDateTo_ValueChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(330, 31);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(81, 17);
            this.lblOrderDate.TabIndex = 24;
            this.lblOrderDate.Text = "Order Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 2;
            // 
            // dtpOrderDateFrom
            // 
            this.dtpOrderDateFrom.Location = new System.Drawing.Point(414, 28);
            this.dtpOrderDateFrom.Name = "dtpOrderDateFrom";
            this.dtpOrderDateFrom.Size = new System.Drawing.Size(133, 23);
            this.dtpOrderDateFrom.TabIndex = 23;
            this.dtpOrderDateFrom.ValueChanged += new System.EventHandler(this.DtpOrderDateFrom_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Controls.Add(this.dgvGoodsRecevieList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 391);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Goods Recevie List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // frmGoodsReceiveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGoodsReceiveList";
            this.Text = "frmGoodsReceiveList";
            this.Load += new System.EventHandler(this.FrmGoodsReceiveList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsRecevieList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OrderId;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label staffId;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgvGoodsRecevieList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOrderDateTo;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDateFrom;
    }
}