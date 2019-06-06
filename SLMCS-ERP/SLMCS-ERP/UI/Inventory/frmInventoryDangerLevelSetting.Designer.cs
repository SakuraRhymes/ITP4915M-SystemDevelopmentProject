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
            this.lblDangerLevel = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.lblDangerLevel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 414);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danger Level Setting";
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
            // lblProdcutIDData
            // 
            this.lblProdcutIDData.AutoSize = true;
            this.lblProdcutIDData.Location = new System.Drawing.Point(286, 78);
            this.lblProdcutIDData.Name = "lblProdcutIDData";
            this.lblProdcutIDData.Size = new System.Drawing.Size(64, 24);
            this.lblProdcutIDData.TabIndex = 1;
            this.lblProdcutIDData.Text = "label2";
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
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(108, 140);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(152, 24);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name :";
            // 
            // txtDangerLevel
            // 
            this.txtDangerLevel.Location = new System.Drawing.Point(290, 201);
            this.txtDangerLevel.Name = "txtDangerLevel";
            this.txtDangerLevel.Size = new System.Drawing.Size(100, 36);
            this.txtDangerLevel.TabIndex = 5;
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
            // lblDangerLevel
            // 
            this.lblDangerLevel.AutoSize = true;
            this.lblDangerLevel.Location = new System.Drawing.Point(108, 201);
            this.lblDangerLevel.Name = "lblDangerLevel";
            this.lblDangerLevel.Size = new System.Drawing.Size(145, 24);
            this.lblDangerLevel.TabIndex = 4;
            this.lblDangerLevel.Text = "Danger Level :";
            // 
            // frmInventoryDangerLevelSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 436);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInventoryDangerLevelSetting";
            this.Text = "frmInventoryDangerLevelSetting";
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
        private System.Windows.Forms.Label lblDangerLevel;
    }
}