namespace SLMCS_ERP.UI.Sales
{
    partial class frmNewSalesOrder
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
            this.btnCancelPlaceOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.lblDealerAddress = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnReserveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.AllowUserToAddRows = false;
            this.dgvOrderItem.AllowUserToDeleteRows = false;
            this.dgvOrderItem.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderItem.Location = new System.Drawing.Point(20, 263);
            this.dgvOrderItem.MultiSelect = false;
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowTemplate.Height = 23;
            this.dgvOrderItem.Size = new System.Drawing.Size(879, 235);
            this.dgvOrderItem.TabIndex = 18;
            this.dgvOrderItem.TabStop = false;
            // 
            // btnCancelPlaceOrder
            // 
            this.btnCancelPlaceOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelPlaceOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelPlaceOrder.Location = new System.Drawing.Point(20, 516);
            this.btnCancelPlaceOrder.Name = "btnCancelPlaceOrder";
            this.btnCancelPlaceOrder.Size = new System.Drawing.Size(110, 30);
            this.btnCancelPlaceOrder.TabIndex = 6;
            this.btnCancelPlaceOrder.TabStop = false;
            this.btnCancelPlaceOrder.Text = "Cancel";
            this.btnCancelPlaceOrder.UseVisualStyleBackColor = false;
            this.btnCancelPlaceOrder.Click += new System.EventHandler(this.BtnCancelPlaceOrder_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlaceOrder.Enabled = false;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlaceOrder.Location = new System.Drawing.Point(789, 516);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(110, 30);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalAmount.Location = new System.Drawing.Point(624, 226);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(16, 17);
            this.lblTotalAmount.TabIndex = 15;
            this.lblTotalAmount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(486, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Order Amount :";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddItem.Location = new System.Drawing.Point(720, 220);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(179, 30);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Product To Order";
            this.btnAddItem.UseCompatibleTextRendering = true;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStaffID);
            this.groupBox1.Controls.Add(this.lblOrderDate);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Controls.Add(this.txtDealerID);
            this.groupBox1.Controls.Add(this.lblDealerAddress);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblDealerName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 195);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Order Detail";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(462, 114);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(84, 16);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Not available";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(463, 74);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(84, 16);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Not available";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(464, 34);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(84, 16);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "Not available";
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(151, 31);
            this.txtDealerID.MaxLength = 8;
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(138, 23);
            this.txtDealerID.TabIndex = 0;
            this.txtDealerID.TextChanged += new System.EventHandler(this.TxtDealerID_TextChanged);
            // 
            // lblDealerAddress
            // 
            this.lblDealerAddress.Location = new System.Drawing.Point(149, 114);
            this.lblDealerAddress.Name = "lblDealerAddress";
            this.lblDealerAddress.Size = new System.Drawing.Size(188, 62);
            this.lblDealerAddress.TabIndex = 2;
            this.lblDealerAddress.Text = "Not available";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dealer Address :";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(149, 74);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(84, 16);
            this.lblDealerName.TabIndex = 2;
            this.lblDealerName.Text = "Not available";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dealer Name :";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(73, 34);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(66, 16);
            this.lbl11.TabIndex = 2;
            this.lbl11.Text = "Dealer ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Staff ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order Date :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(380, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 16);
            this.lbl1.TabIndex = 99;
            this.lbl1.Text = "Order ID :";
            // 
            // btnReserveOrder
            // 
            this.btnReserveOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnReserveOrder.Enabled = false;
            this.btnReserveOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReserveOrder.Location = new System.Drawing.Point(666, 516);
            this.btnReserveOrder.Name = "btnReserveOrder";
            this.btnReserveOrder.Size = new System.Drawing.Size(110, 30);
            this.btnReserveOrder.TabIndex = 5;
            this.btnReserveOrder.Text = "Reserve Order";
            this.btnReserveOrder.UseVisualStyleBackColor = false;
            this.btnReserveOrder.Click += new System.EventHandler(this.BtnReserveOrder_Click);
            // 
            // frmNewSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.dgvOrderItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnCancelPlaceOrder);
            this.Controls.Add(this.btnReserveOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewSalesOrder";
            this.Text = "frmNewSalesOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelPlaceOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lblDealerAddress;
        private System.Windows.Forms.Label lblDealerName;
        internal System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.Button btnReserveOrder;
    }
}