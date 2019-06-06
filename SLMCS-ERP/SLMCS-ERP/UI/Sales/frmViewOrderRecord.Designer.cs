namespace SLMCS_ERP.UI.Sales
{
    partial class frmViewOrderRecord
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
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnConfirmPlaceOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblDealerAddress = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblDealerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderEditDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblOrderDispatchDate = new System.Windows.Forms.Label();
            this.lblOrderCompletedDate = new System.Windows.Forms.Label();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.AllowUserToAddRows = false;
            this.dgvOrderItem.AllowUserToDeleteRows = false;
            this.dgvOrderItem.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(20, 255);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowTemplate.Height = 23;
            this.dgvOrderItem.Size = new System.Drawing.Size(879, 218);
            this.dgvOrderItem.TabIndex = 27;
            this.dgvOrderItem.TabStop = false;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Enabled = false;
            this.btnCancelOrder.Location = new System.Drawing.Point(550, 498);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(101, 23);
            this.btnCancelOrder.TabIndex = 26;
            this.btnCancelOrder.TabStop = false;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);
            // 
            // btnConfirmPlaceOrder
            // 
            this.btnConfirmPlaceOrder.Enabled = false;
            this.btnConfirmPlaceOrder.Location = new System.Drawing.Point(20, 503);
            this.btnConfirmPlaceOrder.Name = "btnConfirmPlaceOrder";
            this.btnConfirmPlaceOrder.Size = new System.Drawing.Size(134, 23);
            this.btnConfirmPlaceOrder.TabIndex = 21;
            this.btnConfirmPlaceOrder.Text = "Confirm Place Order";
            this.btnConfirmPlaceOrder.UseVisualStyleBackColor = true;
            this.btnConfirmPlaceOrder.Click += new System.EventHandler(this.BtnConfirmPlaceOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(803, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(422, 109);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(11, 12);
            this.lblTotalAmount.TabIndex = 25;
            this.lblTotalAmount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total Amount :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStaffID);
            this.groupBox1.Controls.Add(this.lblOrderCompletedDate);
            this.groupBox1.Controls.Add(this.lblOrderEditDate);
            this.groupBox1.Controls.Add(this.lblOrderDispatchDate);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.lblOrderDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblOrderStatus);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Controls.Add(this.lblDealerAddress);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblDealerID);
            this.groupBox1.Controls.Add(this.lblDealerName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl11);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 189);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(136, 144);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(66, 12);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Not available";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(743, 32);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(66, 12);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Not available";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(422, 32);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(66, 12);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "Not available";
            // 
            // lblDealerAddress
            // 
            this.lblDealerAddress.AutoSize = true;
            this.lblDealerAddress.Location = new System.Drawing.Point(136, 108);
            this.lblDealerAddress.MaximumSize = new System.Drawing.Size(170, 0);
            this.lblDealerAddress.Name = "lblDealerAddress";
            this.lblDealerAddress.Size = new System.Drawing.Size(66, 12);
            this.lblDealerAddress.TabIndex = 2;
            this.lblDealerAddress.Text = "Not available";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dealer Address :";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(136, 68);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(66, 12);
            this.lblDealerName.TabIndex = 2;
            this.lblDealerName.Text = "Not available";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dealer Name :";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(27, 32);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(56, 12);
            this.lbl11.TabIndex = 2;
            this.lbl11.Text = "Dealer ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Staff ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order Date :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(326, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Order ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Status :";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(422, 68);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(66, 12);
            this.lblOrderStatus.TabIndex = 4;
            this.lblOrderStatus.Text = "Not available";
            // 
            // lblDealerID
            // 
            this.lblDealerID.AutoSize = true;
            this.lblDealerID.Location = new System.Drawing.Point(136, 32);
            this.lblDealerID.Name = "lblDealerID";
            this.lblDealerID.Size = new System.Drawing.Size(66, 12);
            this.lblDealerID.TabIndex = 2;
            this.lblDealerID.Text = "Not available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order Edit Date :";
            // 
            // lblOrderEditDate
            // 
            this.lblOrderEditDate.AutoSize = true;
            this.lblOrderEditDate.Location = new System.Drawing.Point(743, 70);
            this.lblOrderEditDate.Name = "lblOrderEditDate";
            this.lblOrderEditDate.Size = new System.Drawing.Size(66, 12);
            this.lblOrderEditDate.TabIndex = 4;
            this.lblOrderEditDate.Text = "Not available";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "Order Dispatch Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "Order Completed Date :";
            // 
            // lblOrderDispatchDate
            // 
            this.lblOrderDispatchDate.AutoSize = true;
            this.lblOrderDispatchDate.Location = new System.Drawing.Point(743, 107);
            this.lblOrderDispatchDate.Name = "lblOrderDispatchDate";
            this.lblOrderDispatchDate.Size = new System.Drawing.Size(66, 12);
            this.lblOrderDispatchDate.TabIndex = 4;
            this.lblOrderDispatchDate.Text = "Not available";
            // 
            // lblOrderCompletedDate
            // 
            this.lblOrderCompletedDate.AutoSize = true;
            this.lblOrderCompletedDate.Location = new System.Drawing.Point(743, 145);
            this.lblOrderCompletedDate.Name = "lblOrderCompletedDate";
            this.lblOrderCompletedDate.Size = new System.Drawing.Size(66, 12);
            this.lblOrderCompletedDate.TabIndex = 4;
            this.lblOrderCompletedDate.Text = "Not available";
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Enabled = false;
            this.btnCompleteOrder.Location = new System.Drawing.Point(674, 498);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(110, 23);
            this.btnCompleteOrder.TabIndex = 29;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.BtnCompleteOrder_Click);
            // 
            // frmViewOrderRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.dgvOrderItem);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnConfirmPlaceOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewOrderRecord";
            this.Text = "frmViewOrderRecord";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnConfirmPlaceOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblDealerAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDealerID;
        private System.Windows.Forms.Label lblOrderCompletedDate;
        private System.Windows.Forms.Label lblOrderEditDate;
        private System.Windows.Forms.Label lblOrderDispatchDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCompleteOrder;
    }
}