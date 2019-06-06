namespace SLMCS_ERP.UI.Dispatch
{
    partial class frmGoodsReceivedList
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
            this.vendorId = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.dgvGoodsRecevieList = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
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
            this.OrderId.Location = new System.Drawing.Point(5, 45);
            this.OrderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(50, 12);
            this.OrderId.TabIndex = 0;
            this.OrderId.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(63, 37);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(200, 22);
            this.txtOrderID.TabIndex = 1;
            // 
            // staffId
            // 
            this.staffId.AutoSize = true;
            this.staffId.Location = new System.Drawing.Point(287, 45);
            this.staffId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffId.Name = "staffId";
            this.staffId.Size = new System.Drawing.Size(45, 12);
            this.staffId.TabIndex = 2;
            this.staffId.Text = "Staff ID:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(355, 37);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(200, 22);
            this.txtStaffID.TabIndex = 3;
            // 
            // vendorId
            // 
            this.vendorId.AutoSize = true;
            this.vendorId.Location = new System.Drawing.Point(580, 45);
            this.vendorId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vendorId.Name = "vendorId";
            this.vendorId.Size = new System.Drawing.Size(58, 12);
            this.vendorId.TabIndex = 4;
            this.vendorId.Text = "Vendor ID:";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(675, 37);
            this.txtVendorID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(200, 22);
            this.txtVendorID.TabIndex = 5;
            // 
            // dgvGoodsRecevieList
            // 
            this.dgvGoodsRecevieList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoodsRecevieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsRecevieList.Location = new System.Drawing.Point(7, 16);
            this.dgvGoodsRecevieList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGoodsRecevieList.Name = "dgvGoodsRecevieList";
            this.dgvGoodsRecevieList.ReadOnly = true;
            this.dgvGoodsRecevieList.RowTemplate.Height = 27;
            this.dgvGoodsRecevieList.Size = new System.Drawing.Size(866, 211);
            this.dgvGoodsRecevieList.TabIndex = 10;
            this.dgvGoodsRecevieList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGoodsRecevieList_CellClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(782, 232);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 34);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(782, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 34);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.OrderId);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.staffId);
            this.groupBox1.Controls.Add(this.txtVendorID);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.vendorId);
            this.groupBox1.Location = new System.Drawing.Point(20, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 113);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(675, 74);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 34);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Controls.Add(this.dgvGoodsRecevieList);
            this.groupBox2.Location = new System.Drawing.Point(20, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 271);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Goods Recevied List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            // 
            // frmGoodsReceivedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGoodsReceivedList";
            this.Text = "frmGoodsReceivedList";
            this.Load += new System.EventHandler(this.FrmGoodsReceivedList_Load);
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
        private System.Windows.Forms.Label vendorId;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.DataGridView dgvGoodsRecevieList;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}