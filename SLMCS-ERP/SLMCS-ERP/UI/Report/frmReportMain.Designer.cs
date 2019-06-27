namespace SLMCS_ERP
{
    partial class frmReportMain
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnProductReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.panelLeftNavigate = new System.Windows.Forms.Panel();
            this.panelLeftNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(150, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1036, 613);
            this.panelContent.TabIndex = 2;
            // 
            // btnProductReport
            // 
            this.btnProductReport.BackColor = System.Drawing.Color.White;
            this.btnProductReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductReport.Location = new System.Drawing.Point(14, 109);
            this.btnProductReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Size = new System.Drawing.Size(120, 54);
            this.btnProductReport.TabIndex = 2;
            this.btnProductReport.Text = "Product Report";
            this.btnProductReport.UseVisualStyleBackColor = false;
            this.btnProductReport.Click += new System.EventHandler(this.BtnProductReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.White;
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSalesReport.Location = new System.Drawing.Point(14, 30);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(120, 54);
            this.btnSalesReport.TabIndex = 1;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.BtnSalesReport_Click);
            // 
            // panelLeftNavigate
            // 
            this.panelLeftNavigate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftNavigate.BackgroundImage = global::SLMCS_ERP.Properties.Resources.bg_color;
            this.panelLeftNavigate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeftNavigate.Controls.Add(this.btnProductReport);
            this.panelLeftNavigate.Controls.Add(this.btnSalesReport);
            this.panelLeftNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavigate.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavigate.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeftNavigate.Name = "panelLeftNavigate";
            this.panelLeftNavigate.Size = new System.Drawing.Size(150, 613);
            this.panelLeftNavigate.TabIndex = 1;
            // 
            // frmReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 613);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeftNavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportMain";
            this.Text = "frmReportMain";
            this.panelLeftNavigate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftNavigate;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnProductReport;
        private System.Windows.Forms.Button btnSalesReport;
    }
}