namespace SLMCS_ERP.UI.Management
{
    partial class frmProductManagement_VendorRecord
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
            this.dgvVendorRecord = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendorRecord
            // 
            this.dgvVendorRecord.AllowUserToAddRows = false;
            this.dgvVendorRecord.AllowUserToDeleteRows = false;
            this.dgvVendorRecord.AllowUserToResizeColumns = false;
            this.dgvVendorRecord.AllowUserToResizeRows = false;
            this.dgvVendorRecord.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVendorRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVendorRecord.Location = new System.Drawing.Point(19, 16);
            this.dgvVendorRecord.MultiSelect = false;
            this.dgvVendorRecord.Name = "dgvVendorRecord";
            this.dgvVendorRecord.ReadOnly = true;
            this.dgvVendorRecord.RowTemplate.Height = 24;
            this.dgvVendorRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendorRecord.Size = new System.Drawing.Size(392, 334);
            this.dgvVendorRecord.TabIndex = 5;
            this.dgvVendorRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendorRecord_CellClick);
            this.dgvVendorRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendorRecord_CellDoubleClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelect.Location = new System.Drawing.Point(321, 361);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(90, 25);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(222, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmProductManagement_VendorRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 405);
            this.Controls.Add(this.dgvVendorRecord);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProductManagement_VendorRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Record";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendorRecord;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}