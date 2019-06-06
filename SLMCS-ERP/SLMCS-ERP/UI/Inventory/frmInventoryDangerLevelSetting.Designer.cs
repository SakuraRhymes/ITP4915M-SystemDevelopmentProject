namespace SLMCS_ERP
{
    partial class frmInventoryDangerLevelSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProdcutID = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblProdcutIDData = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtDangerLevel = new System.Windows.Forms.TextBox();
            this.lblProductNameData = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProdcutID);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblProdcutIDData);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.txtDangerLevel);
            this.groupBox1.Controls.Add(this.lblProductNameData);
            this.groupBox1.Controls.Add(this.lblReorderLevel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(244, 207);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danger Level Setting";
            // 
            // lblProdcutID
            // 
            this.lblProdcutID.AutoSize = true;
            this.lblProdcutID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProdcutID.Location = new System.Drawing.Point(49, 37);
            this.lblProdcutID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProdcutID.Name = "lblProdcutID";
            this.lblProdcutID.Size = new System.Drawing.Size(73, 16);
            this.lblProdcutID.TabIndex = 5;
            this.lblProdcutID.Text = "Product ID :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubmit.Location = new System.Drawing.Point(139, 161);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblProdcutIDData
            // 
            this.lblProdcutIDData.AutoSize = true;
            this.lblProdcutIDData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProdcutIDData.Location = new System.Drawing.Point(134, 38);
            this.lblProdcutIDData.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProdcutIDData.Name = "lblProdcutIDData";
            this.lblProdcutIDData.Size = new System.Drawing.Size(43, 16);
            this.lblProdcutIDData.TabIndex = 8;
            this.lblProdcutIDData.Text = "label2";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(26, 161);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductName.Location = new System.Drawing.Point(27, 72);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 16);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Product Name :";
            // 
            // txtDangerLevel
            // 
            this.txtDangerLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDangerLevel.Location = new System.Drawing.Point(136, 104);
            this.txtDangerLevel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtDangerLevel.Name = "txtDangerLevel";
            this.txtDangerLevel.Size = new System.Drawing.Size(58, 23);
            this.txtDangerLevel.TabIndex = 6;
            // 
            // lblProductNameData
            // 
            this.lblProductNameData.AutoSize = true;
            this.lblProductNameData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductNameData.Location = new System.Drawing.Point(134, 74);
            this.lblProductNameData.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductNameData.Name = "lblProductNameData";
            this.lblProductNameData.Size = new System.Drawing.Size(43, 16);
            this.lblProductNameData.TabIndex = 11;
            this.lblProductNameData.Text = "label4";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReorderLevel.Location = new System.Drawing.Point(31, 107);
            this.lblReorderLevel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(92, 16);
            this.lblReorderLevel.TabIndex = 12;
            this.lblReorderLevel.Text = "Reorder Level :";
            // 
            // frmInventoryDangerLevelSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 231);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmInventoryDangerLevelSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProdcutID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblProdcutIDData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtDangerLevel;
        private System.Windows.Forms.Label lblProductNameData;
        private System.Windows.Forms.Label lblReorderLevel;
    }
}