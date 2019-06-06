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
            this.txtSearchForProduct = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProductAvailability = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOrderQunatity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnReserveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.AllowUserToAddRows = false;
            this.dgvOrderItem.AllowUserToDeleteRows = false;
            this.dgvOrderItem.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderItem.Location = new System.Drawing.Point(20, 306);
            this.dgvOrderItem.MultiSelect = false;
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowTemplate.Height = 23;
            this.dgvOrderItem.Size = new System.Drawing.Size(879, 179);
            this.dgvOrderItem.TabIndex = 18;
            this.dgvOrderItem.TabStop = false;
            // 
            // btnCancelPlaceOrder
            // 
            this.btnCancelPlaceOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelPlaceOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelPlaceOrder.Location = new System.Drawing.Point(20, 503);
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
            this.btnPlaceOrder.Location = new System.Drawing.Point(789, 503);
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
            this.lblTotalAmount.Location = new System.Drawing.Point(559, 511);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(16, 17);
            this.lblTotalAmount.TabIndex = 15;
            this.lblTotalAmount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(463, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Amount :";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddItem.Location = new System.Drawing.Point(557, 21);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(179, 30);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item To Order";
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
            this.groupBox1.Size = new System.Drawing.Size(879, 158);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(429, 109);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(84, 16);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Not available";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(430, 69);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(84, 16);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Not available";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(431, 29);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(84, 16);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "Not available";
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(132, 26);
            this.txtDealerID.MaxLength = 8;
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(129, 23);
            this.txtDealerID.TabIndex = 0;
            this.txtDealerID.TextChanged += new System.EventHandler(this.TxtDealerID_TextChanged);
            // 
            // lblDealerAddress
            // 
            this.lblDealerAddress.AutoSize = true;
            this.lblDealerAddress.Location = new System.Drawing.Point(130, 109);
            this.lblDealerAddress.MaximumSize = new System.Drawing.Size(170, 0);
            this.lblDealerAddress.Name = "lblDealerAddress";
            this.lblDealerAddress.Size = new System.Drawing.Size(84, 16);
            this.lblDealerAddress.TabIndex = 2;
            this.lblDealerAddress.Text = "Not available";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dealer Address :";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(130, 69);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(84, 16);
            this.lblDealerName.TabIndex = 2;
            this.lblDealerName.Text = "Not available";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dealer Name :";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(21, 33);
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
            this.label5.Location = new System.Drawing.Point(334, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Staff ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order Date :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(334, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 16);
            this.lbl1.TabIndex = 99;
            this.lbl1.Text = "Order ID :";
            // 
            // txtSearchForProduct
            // 
            this.txtSearchForProduct.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchForProduct.Location = new System.Drawing.Point(133, 25);
            this.txtSearchForProduct.MaxLength = 6;
            this.txtSearchForProduct.Name = "txtSearchForProduct";
            this.txtSearchForProduct.Size = new System.Drawing.Size(129, 23);
            this.txtSearchForProduct.TabIndex = 1;
            this.txtSearchForProduct.TextChanged += new System.EventHandler(this.TxtSearchForProduct_TextChanged);
            this.txtSearchForProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchForProduct_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProductAvailability);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtOrderQunatity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSearchForProduct);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(20, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 112);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // lblProductAvailability
            // 
            this.lblProductAvailability.AutoSize = true;
            this.lblProductAvailability.Location = new System.Drawing.Point(432, 68);
            this.lblProductAvailability.Name = "lblProductAvailability";
            this.lblProductAvailability.Size = new System.Drawing.Size(84, 16);
            this.lblProductAvailability.TabIndex = 26;
            this.lblProductAvailability.Text = "Not available";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Availability :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(432, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 16);
            this.lblProductName.TabIndex = 22;
            this.lblProductName.Text = "Not available";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Product Name :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Quantity :";
            // 
            // txtOrderQunatity
            // 
            this.txtOrderQunatity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOrderQunatity.Location = new System.Drawing.Point(133, 64);
            this.txtOrderQunatity.Name = "txtOrderQunatity";
            this.txtOrderQunatity.Size = new System.Drawing.Size(129, 23);
            this.txtOrderQunatity.TabIndex = 2;
            this.txtOrderQunatity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOrderQunatity_KeyPress);
            this.txtOrderQunatity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtOrderQunatity_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Product ID :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 2;
            // 
            // btnReserveOrder
            // 
            this.btnReserveOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnReserveOrder.Enabled = false;
            this.btnReserveOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReserveOrder.Location = new System.Drawing.Point(666, 503);
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
            this.Controls.Add(this.btnCancelPlaceOrder);
            this.Controls.Add(this.btnReserveOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewSalesOrder";
            this.Text = "frmNewSalesOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSearchForProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProductAvailability;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOrderQunatity;
        internal System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.Button btnReserveOrder;
    }
}