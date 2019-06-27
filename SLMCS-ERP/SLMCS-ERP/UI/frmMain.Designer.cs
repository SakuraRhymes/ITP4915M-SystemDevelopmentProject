namespace SLMCS_ERP
{
    partial class frmMain
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
            this.penalTopNavigation = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelSystemName = new System.Windows.Forms.Label();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.penalTopNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // penalTopNavigation
            // 
            this.penalTopNavigation.BackColor = System.Drawing.Color.White;
            this.penalTopNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penalTopNavigation.Controls.Add(this.label4);
            this.penalTopNavigation.Controls.Add(this.label2);
            this.penalTopNavigation.Controls.Add(this.lblStaffName);
            this.penalTopNavigation.Controls.Add(this.lblStaffID);
            this.penalTopNavigation.Controls.Add(this.btnLogout);
            this.penalTopNavigation.Controls.Add(this.labelSystemName);
            this.penalTopNavigation.Controls.Add(this.btnManagement);
            this.penalTopNavigation.Controls.Add(this.btnDispatch);
            this.penalTopNavigation.Controls.Add(this.btnInventory);
            this.penalTopNavigation.Controls.Add(this.btnReport);
            this.penalTopNavigation.Controls.Add(this.btnSales);
            this.penalTopNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.penalTopNavigation.Location = new System.Drawing.Point(0, 0);
            this.penalTopNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.penalTopNavigation.Name = "penalTopNavigation";
            this.penalTopNavigation.Size = new System.Drawing.Size(1186, 126);
            this.penalTopNavigation.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1019, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Staff Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1019, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Staff ID:";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStaffName.Location = new System.Drawing.Point(1097, 53);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(43, 16);
            this.lblStaffName.TabIndex = 3;
            this.lblStaffName.Text = "label1";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStaffID.Location = new System.Drawing.Point(1097, 22);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(43, 16);
            this.lblStaffID.TabIndex = 3;
            this.lblStaffID.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Location = new System.Drawing.Point(1027, 85);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 27);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // labelSystemName
            // 
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.BackColor = System.Drawing.Color.White;
            this.labelSystemName.Font = new System.Drawing.Font("Microsoft JhengHei", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSystemName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSystemName.Location = new System.Drawing.Point(11, 21);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(456, 32);
            this.labelSystemName.TabIndex = 1;
            this.labelSystemName.Text = "Welcome To The SLMCS ERP System";
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.White;
            this.btnManagement.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnManagement.Location = new System.Drawing.Point(453, 79);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(140, 33);
            this.btnManagement.TabIndex = 3;
            this.btnManagement.Text = "Data Management";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.BtnUserManagement_Click);
            // 
            // btnDispatch
            // 
            this.btnDispatch.BackColor = System.Drawing.Color.White;
            this.btnDispatch.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDispatch.Location = new System.Drawing.Point(307, 79);
            this.btnDispatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(140, 33);
            this.btnDispatch.TabIndex = 2;
            this.btnDispatch.Text = "Dispatch";
            this.btnDispatch.UseVisualStyleBackColor = false;
            this.btnDispatch.Click += new System.EventHandler(this.BtnDispatch_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInventory.Location = new System.Drawing.Point(162, 79);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(140, 33);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(597, 79);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(140, 33);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.White;
            this.btnSales.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSales.Location = new System.Drawing.Point(17, 79);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(140, 33);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 126);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1186, 613);
            this.panelContent.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 739);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.penalTopNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SLMCS ERP System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.penalTopNavigation.ResumeLayout(false);
            this.penalTopNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel penalTopNavigation;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnDispatch;
        private System.Windows.Forms.Label labelSystemName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStaffName;
    }
}