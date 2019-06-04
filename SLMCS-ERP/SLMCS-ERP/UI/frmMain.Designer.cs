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
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelSystemName = new System.Windows.Forms.Label();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.penalTopNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // penalTopNavigation
            // 
            this.penalTopNavigation.BackColor = System.Drawing.SystemColors.Control;
            this.penalTopNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penalTopNavigation.Controls.Add(this.btnLogout);
            this.penalTopNavigation.Controls.Add(this.labelSystemName);
            this.penalTopNavigation.Controls.Add(this.btnManagement);
            this.penalTopNavigation.Controls.Add(this.btnDispatch);
            this.penalTopNavigation.Controls.Add(this.btnInventory);
            this.penalTopNavigation.Controls.Add(this.btnHome);
            this.penalTopNavigation.Controls.Add(this.btnSales);
            this.penalTopNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.penalTopNavigation.Location = new System.Drawing.Point(0, 0);
            this.penalTopNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.penalTopNavigation.Name = "penalTopNavigation";
            this.penalTopNavigation.Size = new System.Drawing.Size(1186, 116);
            this.penalTopNavigation.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1082, 24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // labelSystemName
            // 
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSystemName.Location = new System.Drawing.Point(11, 24);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(211, 25);
            this.labelSystemName.TabIndex = 1;
            this.labelSystemName.Text = "SLMCS ERP System";
            // 
            // btnManagement
            // 
            this.btnManagement.Location = new System.Drawing.Point(538, 76);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(117, 29);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.BtnUserManagement_Click);
            // 
            // btnDispatch
            // 
            this.btnDispatch.Location = new System.Drawing.Point(400, 77);
            this.btnDispatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(90, 29);
            this.btnDispatch.TabIndex = 0;
            this.btnDispatch.Text = "Dispatch";
            this.btnDispatch.UseVisualStyleBackColor = true;
            this.btnDispatch.Click += new System.EventHandler(this.BtnDispatch_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(269, 76);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(90, 29);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(11, 76);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 29);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(138, 77);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(90, 29);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 116);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1186, 566);
            this.panelContent.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.penalTopNavigation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Home Page";
            this.penalTopNavigation.ResumeLayout(false);
            this.penalTopNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel penalTopNavigation;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnDispatch;
        private System.Windows.Forms.Label labelSystemName;
        private System.Windows.Forms.Button btnLogout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}