namespace SLMCS_ERP
{
    partial class frmDispatchingList
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
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.dgvSalesOrderList = new System.Windows.Forms.DataGridView();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnGenerateForDID = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDealerID = new System.Windows.Forms.Label();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerateForDIC = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(19, 28);
            this.dgvOrderDetail.Margin = new System.Windows.Forms.Padding(5);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(1129, 175);
            this.dgvOrderDetail.TabIndex = 0;
            // 
            // dgvSalesOrderList
            // 
            this.dgvSalesOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrderList.Location = new System.Drawing.Point(35, 170);
            this.dgvSalesOrderList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSalesOrderList.Name = "dgvSalesOrderList";
            this.dgvSalesOrderList.ReadOnly = true;
            this.dgvSalesOrderList.RowTemplate.Height = 24;
            this.dgvSalesOrderList.Size = new System.Drawing.Size(1129, 206);
            this.dgvSalesOrderList.TabIndex = 10;
            this.dgvSalesOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalesOrderList_CellContentClick);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(97, 26);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(263, 25);
            this.txtOrderID.TabIndex = 2;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(1041, 76);
            this.btnSearchOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(107, 35);
            this.btnSearchOrder.TabIndex = 5;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnGenerateForDID
            // 
            this.btnGenerateForDID.Location = new System.Drawing.Point(1008, 211);
            this.btnGenerateForDID.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateForDID.Name = "btnGenerateForDID";
            this.btnGenerateForDID.Size = new System.Drawing.Size(140, 38);
            this.btnGenerateForDID.TabIndex = 8;
            this.btnGenerateForDID.Text = "Generate For DID";
            this.btnGenerateForDID.UseVisualStyleBackColor = true;
            this.btnGenerateForDID.Click += new System.EventHandler(this.BtnGenerateForDID_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(909, 76);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 35);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refrsh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(1008, 239);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(140, 38);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Dispatch";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(16, 36);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(63, 15);
            this.lbOrderId.TabIndex = 14;
            this.lbOrderId.Text = "Order ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbDealerID);
            this.groupBox1.Controls.Add(this.lbOrderId);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lbStaffID);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.btnSearchOrder);
            this.groupBox1.Controls.Add(this.txtDealerID);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1172, 121);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 2;
            // 
            // lbDealerID
            // 
            this.lbDealerID.AutoSize = true;
            this.lbDealerID.Location = new System.Drawing.Point(783, 36);
            this.lbDealerID.Name = "lbDealerID";
            this.lbDealerID.Size = new System.Drawing.Size(67, 15);
            this.lbDealerID.TabIndex = 16;
            this.lbDealerID.Text = "Dealer ID:";
            this.lbDealerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.Location = new System.Drawing.Point(395, 36);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(58, 15);
            this.lbStaffID.TabIndex = 15;
            this.lbStaffID.Text = "Staff ID:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(488, 26);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(263, 25);
            this.txtStaffID.TabIndex = 4;
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(884, 26);
            this.txtDealerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(263, 25);
            this.txtDealerID.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerateForDIC);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Location = new System.Drawing.Point(16, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1172, 284);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dispatching Order";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btnGenerateForDIC
            // 
            this.btnGenerateForDIC.Location = new System.Drawing.Point(849, 239);
            this.btnGenerateForDIC.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateForDIC.Name = "btnGenerateForDIC";
            this.btnGenerateForDIC.Size = new System.Drawing.Size(136, 38);
            this.btnGenerateForDIC.TabIndex = 14;
            this.btnGenerateForDIC.Text = "Generate For DIC";
            this.btnGenerateForDIC.UseVisualStyleBackColor = true;
            this.btnGenerateForDIC.Click += new System.EventHandler(this.BtnGenerateForDIC_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvOrderDetail);
            this.groupBox4.Controls.Add(this.btnGenerateForDID);
            this.groupBox4.Location = new System.Drawing.Point(16, 436);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1172, 256);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OrderLine";
            this.groupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // frmDispatchingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 708);
            this.Controls.Add(this.dgvSalesOrderList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDispatchingList";
            this.Text = "frmDispatchingList";
            this.Load += new System.EventHandler(this.FrmDispatchingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetail;

        private System.Windows.Forms.DataGridView dgvSalesOrderList;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Button btnGenerateForDID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDealerID;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGenerateForDIC;
    }
}