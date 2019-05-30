namespace SLMCS_ERP
{
    partial class frmInventoryVendorRecord
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvVendorRecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(329, 352);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // dgvVendorRecord
            // 
            this.dgvVendorRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorRecord.Location = new System.Drawing.Point(12, 12);
            this.dgvVendorRecord.Name = "dgvVendorRecord";
            this.dgvVendorRecord.RowTemplate.Height = 24;
            this.dgvVendorRecord.Size = new System.Drawing.Size(392, 334);
            this.dgvVendorRecord.TabIndex = 2;
            // 
            // frmInventoryVendorRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 387);
            this.Controls.Add(this.dgvVendorRecord);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmInventoryVendorRecord";
            this.Text = "frmInventoryVendorRecord";
            this.Load += new System.EventHandler(this.FrmInventoryVendorRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvVendorRecord;
    }
}