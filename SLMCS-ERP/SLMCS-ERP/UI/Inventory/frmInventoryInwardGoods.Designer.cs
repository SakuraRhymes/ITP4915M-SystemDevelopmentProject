namespace SLMCS_ERP
{
    partial class frmInventoryInwardGoods
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
            this.dgvReceivedOrderRecord = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrderRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReceivedOrderRecord
            // 
            this.dgvReceivedOrderRecord.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReceivedOrderRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivedOrderRecord.Location = new System.Drawing.Point(12, 63);
            this.dgvReceivedOrderRecord.Name = "dgvReceivedOrderRecord";
            this.dgvReceivedOrderRecord.RowTemplate.Height = 24;
            this.dgvReceivedOrderRecord.Size = new System.Drawing.Size(457, 460);
            this.dgvReceivedOrderRecord.TabIndex = 77;
            this.dgvReceivedOrderRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReceivedOrderRecord_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(457, 36);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh Received Order Record";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(6, 154);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(516, 307);
            this.dgvOrderDetail.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(335, 469);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(186, 30);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm Received Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDCompletedDateData);
            this.groupBox1.Controls.Add(this.lblDStaffIDData);
            this.groupBox1.Controls.Add(this.lblDEditDateData);
            this.groupBox1.Controls.Add(this.lblDOrderDateData);
            this.groupBox1.Controls.Add(this.lblDReceivedDateData);
            this.groupBox1.Controls.Add(this.lblDReorderOrderIDData);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvOrderDetail);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(484, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 511);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received Order Detail";
            // 
            // lblDCompletedDateData
            // 
            this.lblDCompletedDateData.AutoSize = true;
            this.lblDCompletedDateData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDCompletedDateData.Location = new System.Drawing.Point(393, 113);
            this.lblDCompletedDateData.Name = "lblDCompletedDateData";
            this.lblDCompletedDateData.Size = new System.Drawing.Size(91, 16);
            this.lblDCompletedDateData.TabIndex = 46;
            this.lblDCompletedDateData.Text = "complete date";
            // 
            // lblDStaffIDData
            // 
            this.lblDStaffIDData.AutoSize = true;
            this.lblDStaffIDData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDStaffIDData.Location = new System.Drawing.Point(393, 46);
            this.lblDStaffIDData.Name = "lblDStaffIDData";
            this.lblDStaffIDData.Size = new System.Drawing.Size(46, 16);
            this.lblDStaffIDData.TabIndex = 45;
            this.lblDStaffIDData.Text = "staff id";
            // 
            // lblDEditDateData
            // 
            this.lblDEditDateData.AutoSize = true;
            this.lblDEditDateData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDEditDateData.Location = new System.Drawing.Point(393, 79);
            this.lblDEditDateData.Name = "lblDEditDateData";
            this.lblDEditDateData.Size = new System.Drawing.Size(59, 16);
            this.lblDEditDateData.TabIndex = 44;
            this.lblDEditDateData.Text = "Edit date";
            // 
            // lblDOrderDateData
            // 
            this.lblDOrderDateData.AutoSize = true;
            this.lblDOrderDateData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDOrderDateData.Location = new System.Drawing.Point(146, 79);
            this.lblDOrderDateData.Name = "lblDOrderDateData";
            this.lblDOrderDateData.Size = new System.Drawing.Size(77, 16);
            this.lblDOrderDateData.TabIndex = 43;
            this.lblDOrderDateData.Text = "Order Date :";
            // 
            // lblDReceivedDateData
            // 
            this.lblDReceivedDateData.AutoSize = true;
            this.lblDReceivedDateData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDReceivedDateData.Location = new System.Drawing.Point(146, 114);
            this.lblDReceivedDateData.Name = "lblDReceivedDateData";
            this.lblDReceivedDateData.Size = new System.Drawing.Size(93, 16);
            this.lblDReceivedDateData.TabIndex = 42;
            this.lblDReceivedDateData.Text = "Received Date ";
            // 
            // lblDReorderOrderIDData
            // 
            this.lblDReorderOrderIDData.AutoSize = true;
            this.lblDReorderOrderIDData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDReorderOrderIDData.Location = new System.Drawing.Point(146, 46);
            this.lblDReorderOrderIDData.Name = "lblDReorderOrderIDData";
            this.lblDReorderOrderIDData.Size = new System.Drawing.Size(108, 16);
            this.lblDReorderOrderIDData.TabIndex = 41;
            this.lblDReorderOrderIDData.Text = "Reorder Order ID ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(321, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Edit Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(69, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Order Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(332, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Staff ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(279, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Completed Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(35, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Reorder Order ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(51, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Received Date :";
            // 
            // frmInventoryInwardGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvReceivedOrderRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryInwardGoods";
            this.Text = "frmInventoryInwardGoods";
            this.Load += new System.EventHandler(this.FrmInventoryInwardGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrderRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceivedOrderRecord;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDCompletedDateData;
        private System.Windows.Forms.Label lblDStaffIDData;
        private System.Windows.Forms.Label lblDEditDateData;
        private System.Windows.Forms.Label lblDOrderDateData;
        private System.Windows.Forms.Label lblDReceivedDateData;
        private System.Windows.Forms.Label lblDReorderOrderIDData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}