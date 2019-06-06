namespace SLMCS_ERP
{
    partial class frmSales
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
            this.panelLeftNavigate = new System.Windows.Forms.Panel();
            this.btnSalesOrderRecords = new System.Windows.Forms.Button();
            this.btnNewSalesOrder = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelLeftNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftNavigate
            // 
            this.panelLeftNavigate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftNavigate.BackgroundImage = global::SLMCS_ERP.Properties.Resources.bg_color;
            this.panelLeftNavigate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeftNavigate.Controls.Add(this.btnSalesOrderRecords);
            this.panelLeftNavigate.Controls.Add(this.btnNewSalesOrder);
            this.panelLeftNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavigate.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavigate.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeftNavigate.Name = "panelLeftNavigate";
            this.panelLeftNavigate.Size = new System.Drawing.Size(150, 566);
            this.panelLeftNavigate.TabIndex = 0;
            // 
            // btnSalesOrderRecords
            // 
            this.btnSalesOrderRecords.BackColor = System.Drawing.Color.White;
            this.btnSalesOrderRecords.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSalesOrderRecords.Location = new System.Drawing.Point(14, 84);
            this.btnSalesOrderRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesOrderRecords.Name = "btnSalesOrderRecords";
            this.btnSalesOrderRecords.Size = new System.Drawing.Size(120, 45);
            this.btnSalesOrderRecords.TabIndex = 1;
            this.btnSalesOrderRecords.Text = "Sales Order Records";
            this.btnSalesOrderRecords.UseVisualStyleBackColor = false;
            this.btnSalesOrderRecords.Click += new System.EventHandler(this.BtnSalesOrderRecords_Click);
            // 
            // btnNewSalesOrder
            // 
            this.btnNewSalesOrder.BackColor = System.Drawing.Color.White;
            this.btnNewSalesOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewSalesOrder.Location = new System.Drawing.Point(14, 19);
            this.btnNewSalesOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewSalesOrder.Name = "btnNewSalesOrder";
            this.btnNewSalesOrder.Size = new System.Drawing.Size(120, 45);
            this.btnNewSalesOrder.TabIndex = 0;
            this.btnNewSalesOrder.Text = "New Sales Order";
            this.btnNewSalesOrder.UseVisualStyleBackColor = false;
            this.btnNewSalesOrder.Click += new System.EventHandler(this.BtnNewSalesOrder_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(150, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1036, 566);
            this.panelContent.TabIndex = 6;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContent_Paint);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 566);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeftNavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSales";
            this.Text = "Home";
            this.panelLeftNavigate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalesOrderRecords;
        private System.Windows.Forms.Button btnNewSalesOrder;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLeftNavigate;
    }
}