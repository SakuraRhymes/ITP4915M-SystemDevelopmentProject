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
            this.lblOrderDetail = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInwardGoodsOrder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrderRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReceivedOrderRecord
            // 
            this.dgvReceivedOrderRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivedOrderRecord.Location = new System.Drawing.Point(12, 63);
            this.dgvReceivedOrderRecord.Name = "dgvReceivedOrderRecord";
            this.dgvReceivedOrderRecord.RowTemplate.Height = 24;
            this.dgvReceivedOrderRecord.Size = new System.Drawing.Size(267, 421);
            this.dgvReceivedOrderRecord.TabIndex = 0;
            this.dgvReceivedOrderRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReceivedOrderRecord_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(267, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(6, 248);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(610, 189);
            this.dgvOrderDetail.TabIndex = 2;
            // 
            // lblOrderDetail
            // 
            this.lblOrderDetail.AutoSize = true;
            this.lblOrderDetail.Location = new System.Drawing.Point(6, 233);
            this.lblOrderDetail.Name = "lblOrderDetail";
            this.lblOrderDetail.Size = new System.Drawing.Size(62, 12);
            this.lblOrderDetail.TabIndex = 3;
            this.lblOrderDetail.Text = "Order Line :";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(396, 443);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(192, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblInwardGoodsOrder
            // 
            this.lblInwardGoodsOrder.AutoSize = true;
            this.lblInwardGoodsOrder.Location = new System.Drawing.Point(14, 38);
            this.lblInwardGoodsOrder.Name = "lblInwardGoodsOrder";
            this.lblInwardGoodsOrder.Size = new System.Drawing.Size(121, 12);
            this.lblInwardGoodsOrder.TabIndex = 6;
            this.lblInwardGoodsOrder.Text = "Received Order Record :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOrderDetail);
            this.groupBox1.Controls.Add(this.dgvOrderDetail);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Location = new System.Drawing.Point(306, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 472);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received Order Detail";
            // 
            // frmInventoryInwardGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInwardGoodsOrder);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceivedOrderRecord;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label lblOrderDetail;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInwardGoodsOrder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}