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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSalesOrderRecords = new System.Windows.Forms.Button();
            this.btnNewSalesOrder = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelLeftNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftNavigate
            // 
            this.panelLeftNavigate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftNavigate.Controls.Add(this.button4);
            this.panelLeftNavigate.Controls.Add(this.button3);
            this.panelLeftNavigate.Controls.Add(this.btnSalesOrderRecords);
            this.panelLeftNavigate.Controls.Add(this.btnNewSalesOrder);
            this.panelLeftNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavigate.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavigate.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeftNavigate.Name = "panelLeftNavigate";
            this.panelLeftNavigate.Size = new System.Drawing.Size(150, 566);
            this.panelLeftNavigate.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 227);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 157);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSalesOrderRecords
            // 
            this.btnSalesOrderRecords.Location = new System.Drawing.Point(27, 90);
            this.btnSalesOrderRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesOrderRecords.Name = "btnSalesOrderRecords";
            this.btnSalesOrderRecords.Size = new System.Drawing.Size(97, 43);
            this.btnSalesOrderRecords.TabIndex = 0;
            this.btnSalesOrderRecords.Text = "Sales Order Records";
            this.btnSalesOrderRecords.UseVisualStyleBackColor = true;
            this.btnSalesOrderRecords.Click += new System.EventHandler(this.BtnSalesOrderRecords_Click);
            // 
            // btnNewSalesOrder
            // 
            this.btnNewSalesOrder.Location = new System.Drawing.Point(27, 25);
            this.btnNewSalesOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewSalesOrder.Name = "btnNewSalesOrder";
            this.btnNewSalesOrder.Size = new System.Drawing.Size(97, 43);
            this.btnNewSalesOrder.TabIndex = 0;
            this.btnNewSalesOrder.Text = "New Sales Order";
            this.btnNewSalesOrder.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSalesOrderRecords;
        private System.Windows.Forms.Button btnNewSalesOrder;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLeftNavigate;
    }
}