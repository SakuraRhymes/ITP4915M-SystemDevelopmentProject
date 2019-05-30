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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderList)).BeginInit();

            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.btnGenerateForDID = new System.Windows.Forms.Button();
            this.btnGenerateForDIC = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(16, 493);
            this.dgvOrderDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(1172, 154);
            this.dgvOrderDetail.TabIndex = 0;

            this.txtOrderID.Location = new System.Drawing.Point(127, 55);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(246, 25);
            this.txtOrderID.TabIndex = 2;

            this.txtStaffID.Location = new System.Drawing.Point(493, 55);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(246, 25);
            this.txtStaffID.TabIndex = 4;

            this.btnSearchOrder.Location = new System.Drawing.Point(1066, 132);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(122, 42);
            this.btnSearchOrder.TabIndex = 5;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.Search_Click);

            this.txtOrderDate.Location = new System.Drawing.Point(863, 55);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(246, 25);
            this.txtOrderDate.TabIndex = 7;

            this.btnGenerateForDID.Location = new System.Drawing.Point(927, 654);
            this.btnGenerateForDID.Name = "btnGenerateForDID";
            this.btnGenerateForDID.Size = new System.Drawing.Size(122, 42);
            this.btnGenerateForDID.TabIndex = 8;
            this.btnGenerateForDID.Text = "Generate For DID";
            this.btnGenerateForDID.UseVisualStyleBackColor = true;

            this.dgvSalesOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrderList.Location = new System.Drawing.Point(12, 145);
            this.dgvSalesOrderList.Name = "dgvSalesOrderList";
            this.dgvSalesOrderList.ReadOnly = true;
            this.dgvSalesOrderList.RowTemplate.Height = 24;
            this.dgvSalesOrderList.Size = new System.Drawing.Size(879, 123);
            this.dgvSalesOrderList.TabIndex = 10;
            this.btnGenerateForDIC.Location = new System.Drawing.Point(1066, 654);
            this.btnGenerateForDIC.Name = "btnGenerateForDIC";
            this.btnGenerateForDIC.Size = new System.Drawing.Size(122, 42);
            this.btnGenerateForDIC.TabIndex = 9;
            this.btnGenerateForDIC.Text = "Generate For DIC";
            this.btnGenerateForDIC.UseVisualStyleBackColor = true;

            this.btnRefresh.Location = new System.Drawing.Point(918, 132);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 42);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refrsh";
            this.btnRefresh.UseVisualStyleBackColor = true;

            this.btnConfirm.Location = new System.Drawing.Point(1066, 342);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 42);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.dgvSalesOrderList);

            this.ClientSize = new System.Drawing.Size(1381, 708);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGenerateForDIC);
            this.Controls.Add(this.btnGenerateForDID);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.dgvOrderDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDispatchingList";
            this.Text = "frmDispatchingList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderList)).EndInit();

            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDispatchingList";
            this.Text = "frmDispatchingList";
            this.Load += new System.EventHandler(this.FrmDispatchingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetail;

        private System.Windows.Forms.DataGridView dgvSalesOrderList;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Button btnGenerateForDID;
        private System.Windows.Forms.Button btnGenerateForDIC;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConfirm;
    }
}