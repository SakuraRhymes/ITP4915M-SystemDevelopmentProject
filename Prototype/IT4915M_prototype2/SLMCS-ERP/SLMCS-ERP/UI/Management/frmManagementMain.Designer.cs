namespace SLMCS_ERP.UI.Management
{
    partial class frmManagementMain
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
            this.btnVendorManagement = new System.Windows.Forms.Button();
            this.btnDealerManagement = new System.Windows.Forms.Button();
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BackgroundImage = global::SLMCS_ERP.Properties.Resources.bg_color;
            this.panel1.Controls.Add(this.btnVendorManagement);
            this.panel1.Controls.Add(this.btnDealerManagement);
            this.panel1.Controls.Add(this.btnStaffManagement);
            this.panel1.Controls.Add(this.btnProductManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 566);
            this.panel1.TabIndex = 0;
            // 
            // btnVendorManagement
            // 
            this.btnVendorManagement.BackColor = System.Drawing.Color.White;
            this.btnVendorManagement.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVendorManagement.Location = new System.Drawing.Point(12, 215);
            this.btnVendorManagement.Name = "btnVendorManagement";
            this.btnVendorManagement.Size = new System.Drawing.Size(120, 45);
            this.btnVendorManagement.TabIndex = 4;
            this.btnVendorManagement.Text = "Vendor Management";
            this.btnVendorManagement.UseVisualStyleBackColor = false;
            this.btnVendorManagement.Click += new System.EventHandler(this.BtnVendorManagement_Click);
            // 
            // btnDealerManagement
            // 
            this.btnDealerManagement.BackColor = System.Drawing.Color.White;
            this.btnDealerManagement.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDealerManagement.Location = new System.Drawing.Point(12, 147);
            this.btnDealerManagement.Name = "btnDealerManagement";
            this.btnDealerManagement.Size = new System.Drawing.Size(120, 45);
            this.btnDealerManagement.TabIndex = 3;
            this.btnDealerManagement.Text = "Dealer Management";
            this.btnDealerManagement.UseVisualStyleBackColor = false;
            this.btnDealerManagement.Click += new System.EventHandler(this.BtnDealerManagement_Click);
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.BackColor = System.Drawing.Color.White;
            this.btnStaffManagement.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStaffManagement.Location = new System.Drawing.Point(12, 81);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(120, 45);
            this.btnStaffManagement.TabIndex = 2;
            this.btnStaffManagement.Text = "Staff Management";
            this.btnStaffManagement.UseVisualStyleBackColor = false;
            this.btnStaffManagement.Click += new System.EventHandler(this.BtnStaffManagement_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackColor = System.Drawing.Color.White;
            this.btnProductManagement.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductManagement.Location = new System.Drawing.Point(12, 17);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(120, 45);
            this.btnProductManagement.TabIndex = 1;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = false;
            this.btnProductManagement.Click += new System.EventHandler(this.BtnProductManagement_Click);
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
            // frmManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 566);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagementMain";
            this.Text = "frmManagementMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnVendorManagement;
        private System.Windows.Forms.Button btnDealerManagement;
        private System.Windows.Forms.Button btnStaffManagement;
    }
}