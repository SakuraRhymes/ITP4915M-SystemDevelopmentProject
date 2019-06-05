namespace SLMCS_ERP
{
    partial class frmInventoryReorderLevelSetting
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
            this.lblProdcutID = new System.Windows.Forms.Label();
            this.lblProdcutIDData = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductNameData = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProdcutID
            // 
            this.lblProdcutID.AutoSize = true;
            this.lblProdcutID.Location = new System.Drawing.Point(138, 75);
            this.lblProdcutID.Name = "lblProdcutID";
            this.lblProdcutID.Size = new System.Drawing.Size(122, 24);
            this.lblProdcutID.TabIndex = 0;
            this.lblProdcutID.Text = "Product ID :";
            // 
            // lblProdcutIDData
            // 
            this.lblProdcutIDData.AutoSize = true;
            this.lblProdcutIDData.Location = new System.Drawing.Point(286, 78);
            this.lblProdcutIDData.Name = "lblProdcutIDData";
            this.lblProdcutIDData.Size = new System.Drawing.Size(64, 24);
            this.lblProdcutIDData.TabIndex = 1;
            this.lblProdcutIDData.Text = "label2";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(108, 140);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(152, 24);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblProductNameData
            // 
            this.lblProductNameData.AutoSize = true;
            this.lblProductNameData.Location = new System.Drawing.Point(286, 143);
            this.lblProductNameData.Name = "lblProductNameData";
            this.lblProductNameData.Size = new System.Drawing.Size(64, 24);
            this.lblProductNameData.TabIndex = 3;
            this.lblProductNameData.Text = "label4";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(108, 201);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(152, 24);
            this.lblReorderLevel.TabIndex = 4;
            this.lblReorderLevel.Text = "Reorder Level :";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(290, 201);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(100, 36);
            this.txtReorderLevel.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(112, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 53);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(290, 284);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 53);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProdcutID);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblProdcutIDData);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.txtReorderLevel);
            this.groupBox1.Controls.Add(this.lblProductNameData);
            this.groupBox1.Controls.Add(this.lblReorderLevel);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 414);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reorder Level Setting";
            // 
            // frmInventoryReorderLevelSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInventoryReorderLevelSetting";
            this.Text = "frmInventoryReorderLevelSetting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProdcutID;
        private System.Windows.Forms.Label lblProdcutIDData;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductNameData;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}