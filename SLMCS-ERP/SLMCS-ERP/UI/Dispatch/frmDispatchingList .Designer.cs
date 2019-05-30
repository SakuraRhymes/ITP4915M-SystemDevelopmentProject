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
            this.orderId = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.staffId = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.btnGenerateForDID = new System.Windows.Forms.Button();
            this.btnGenerateForDIC = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(16, 493);
            this.dgvOrderDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(1172, 154);
            this.dgvOrderDetail.TabIndex = 0;
            // 
            // orderId
            // 
            this.orderId.AutoSize = true;
            this.orderId.Location = new System.Drawing.Point(44, 65);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(60, 15);
            this.orderId.TabIndex = 1;
            this.orderId.Text = "Order Id:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(127, 55);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(246, 25);
            this.txtOrderID.TabIndex = 2;
            // 
            // staffId
            // 
            this.staffId.AutoSize = true;
            this.staffId.Location = new System.Drawing.Point(410, 65);
            this.staffId.Name = "staffId";
            this.staffId.Size = new System.Drawing.Size(55, 15);
            this.staffId.TabIndex = 3;
            this.staffId.Text = "Staff Id:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(493, 55);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(246, 25);
            this.txtStaffID.TabIndex = 4;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(1066, 132);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(122, 42);
            this.btnSearchOrder.TabIndex = 5;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Date:";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(863, 55);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(246, 25);
            this.txtOrderDate.TabIndex = 7;
            // 
            // btnGenerateForDID
            // 
            this.btnGenerateForDID.Location = new System.Drawing.Point(927, 654);
            this.btnGenerateForDID.Name = "btnGenerateForDID";
            this.btnGenerateForDID.Size = new System.Drawing.Size(122, 42);
            this.btnGenerateForDID.TabIndex = 8;
            this.btnGenerateForDID.Text = "Generate For DID";
            this.btnGenerateForDID.UseVisualStyleBackColor = true;
            // 
            // btnGenerateForDIC
            // 
            this.btnGenerateForDIC.Location = new System.Drawing.Point(1066, 654);
            this.btnGenerateForDIC.Name = "btnGenerateForDIC";
            this.btnGenerateForDIC.Size = new System.Drawing.Size(122, 42);
            this.btnGenerateForDIC.TabIndex = 9;
            this.btnGenerateForDIC.Text = "Generate For DIC";
            this.btnGenerateForDIC.UseVisualStyleBackColor = true;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(16, 181);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.Size = new System.Drawing.Size(1172, 154);
            this.dgvOrderList.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Order Detail:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(918, 132);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 42);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refrsh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(1066, 342);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 42);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // frmDispatchingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 708);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnGenerateForDIC);
            this.Controls.Add(this.btnGenerateForDID);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.staffId);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.dgvOrderDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDispatchingList";
            this.Text = "frmDispatchingList";
            this.Load += new System.EventHandler(this.FrmDispatchingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label orderId;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label staffId;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Button btnGenerateForDID;
        private System.Windows.Forms.Button btnGenerateForDIC;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConfirm;
    }
}