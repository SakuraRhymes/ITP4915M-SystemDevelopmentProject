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
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(20, 306);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.RowTemplate.Height = 23;
            this.dgvOrderItem.Size = new System.Drawing.Size(879, 179);
            this.dgvOrderItem.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(684, 505);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Cancel";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(803, 505);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Confirm";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Amount :";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(333, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Delete Selected Item";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(333, 53);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(179, 23);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
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
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 142);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Not available";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(429, 69);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(66, 12);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Not available";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(431, 29);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(66, 12);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "Not available";
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(132, 26);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(129, 22);
            this.txtDealerID.TabIndex = 3;
            // 
            // lblDealerAddress
            // 
            this.lblDealerAddress.AutoSize = true;
            this.lblDealerAddress.Location = new System.Drawing.Point(130, 109);
            this.lblDealerAddress.Name = "lblDealerAddress";
            this.lblDealerAddress.Size = new System.Drawing.Size(66, 12);
            this.lblDealerAddress.TabIndex = 2;
            this.lblDealerAddress.Text = "Not available";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dealer Address :";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(130, 67);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(66, 12);
            this.lblDealerName.TabIndex = 2;
            this.lblDealerName.Text = "Not available";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dealer Name :";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(21, 33);
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
            this.label5.Location = new System.Drawing.Point(334, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Staff ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order Date :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(334, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Order ID :";
            // 
            // txtSearchForProduct
            // 
            this.txtSearchForProduct.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchForProduct.Location = new System.Drawing.Point(132, 20);
            this.txtSearchForProduct.Name = "txtSearchForProduct";
            this.txtSearchForProduct.Size = new System.Drawing.Size(129, 22);
            this.txtSearchForProduct.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSearchForProduct);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(20, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 128);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(431, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "Not available";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(331, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "Availability :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "Not available";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "Product Desc :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "Not available";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "Product Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "Product ID :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 12);
            this.label17.TabIndex = 2;
            // 
            // frmNewSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.dgvOrderItem);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lblDealerAddress;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.TextBox txtSearchForProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
    }
}