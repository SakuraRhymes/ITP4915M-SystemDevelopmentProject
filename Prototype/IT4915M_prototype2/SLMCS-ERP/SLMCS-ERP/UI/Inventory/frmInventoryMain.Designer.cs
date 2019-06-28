namespace SLMCS_ERP
{
    partial class frmInventoryMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInwardGoodsRecord = new System.Windows.Forms.Button();
            this.btnReorderProduct = new System.Windows.Forms.Button();
            this.btnInwardGoods = new System.Windows.Forms.Button();
            this.btnStockRecord = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BackgroundImage = global::SLMCS_ERP.Properties.Resources.bg_color;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnInwardGoodsRecord);
            this.panel1.Controls.Add(this.btnReorderProduct);
            this.panel1.Controls.Add(this.btnInwardGoods);
            this.panel1.Controls.Add(this.btnStockRecord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 566);
            this.panel1.TabIndex = 0;
            // 
            // btnInwardGoodsRecord
            // 
            this.btnInwardGoodsRecord.BackColor = System.Drawing.Color.White;
            this.btnInwardGoodsRecord.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInwardGoodsRecord.Location = new System.Drawing.Point(14, 222);
            this.btnInwardGoodsRecord.Name = "btnInwardGoodsRecord";
            this.btnInwardGoodsRecord.Size = new System.Drawing.Size(120, 45);
            this.btnInwardGoodsRecord.TabIndex = 3;
            this.btnInwardGoodsRecord.Text = "Inward Goods Record";
            this.btnInwardGoodsRecord.UseVisualStyleBackColor = false;
            this.btnInwardGoodsRecord.Click += new System.EventHandler(this.BtnInwardGoodsRecord_Click);
            // 
            // btnReorderProduct
            // 
            this.btnReorderProduct.BackColor = System.Drawing.Color.White;
            this.btnReorderProduct.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReorderProduct.Location = new System.Drawing.Point(14, 89);
            this.btnReorderProduct.Name = "btnReorderProduct";
            this.btnReorderProduct.Size = new System.Drawing.Size(120, 45);
            this.btnReorderProduct.TabIndex = 2;
            this.btnReorderProduct.Text = "Reorder Product";
            this.btnReorderProduct.UseVisualStyleBackColor = false;
            this.btnReorderProduct.Click += new System.EventHandler(this.BtnReorderProduct_Click);
            // 
            // btnInwardGoods
            // 
            this.btnInwardGoods.BackColor = System.Drawing.Color.White;
            this.btnInwardGoods.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInwardGoods.Location = new System.Drawing.Point(14, 154);
            this.btnInwardGoods.Name = "btnInwardGoods";
            this.btnInwardGoods.Size = new System.Drawing.Size(120, 45);
            this.btnInwardGoods.TabIndex = 1;
            this.btnInwardGoods.Text = "Inward Goods";
            this.btnInwardGoods.UseVisualStyleBackColor = false;
            this.btnInwardGoods.Click += new System.EventHandler(this.BtnInwardGoods_Click);
            // 
            // btnStockRecord
            // 
            this.btnStockRecord.BackColor = System.Drawing.Color.White;
            this.btnStockRecord.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStockRecord.Location = new System.Drawing.Point(14, 21);
            this.btnStockRecord.Name = "btnStockRecord";
            this.btnStockRecord.Size = new System.Drawing.Size(120, 45);
            this.btnStockRecord.TabIndex = 0;
            this.btnStockRecord.Text = "Stock Record";
            this.btnStockRecord.UseVisualStyleBackColor = false;
            this.btnStockRecord.Click += new System.EventHandler(this.BtnStockRecord_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(150, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1036, 566);
            this.panelContent.TabIndex = 1;
            // 
            // frmInventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 566);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryMain";
            this.Text = "frmInventoryMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnStockRecord;
        private System.Windows.Forms.Button btnInwardGoods;
        private System.Windows.Forms.Button btnReorderProduct;
        private System.Windows.Forms.Button btnInwardGoodsRecord;
    }
}