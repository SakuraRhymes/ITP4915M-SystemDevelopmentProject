namespace SLMCS_ERP
{
    partial class frmInventoryMain
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
            this.btnInwardGood = new System.Windows.Forms.Button();
            this.btnStockRecord = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnInwardGood);
            this.panel1.Controls.Add(this.btnStockRecord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 566);
            this.panel1.TabIndex = 0;
            // 
            // btnInwardGood
            // 
            this.btnInwardGood.Location = new System.Drawing.Point(24, 163);
            this.btnInwardGood.Name = "btnInwardGood";
            this.btnInwardGood.Size = new System.Drawing.Size(97, 43);
            this.btnInwardGood.TabIndex = 1;
            this.btnInwardGood.Text = "Inward Goods";
            this.btnInwardGood.UseVisualStyleBackColor = true;
            // 
            // btnStockRecord
            // 
            this.btnStockRecord.Location = new System.Drawing.Point(24, 27);
            this.btnStockRecord.Name = "btnStockRecord";
            this.btnStockRecord.Size = new System.Drawing.Size(97, 43);
            this.btnStockRecord.TabIndex = 0;
            this.btnStockRecord.Text = "Stock Record";
            this.btnStockRecord.UseVisualStyleBackColor = true;
            this.btnStockRecord.Click += new System.EventHandler(this.BtnStockRecord_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(150, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1036, 566);
            this.panelContent.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reorder Product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmInventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 566);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryMain";
            this.Text = "frmInventoryMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnStockRecord;
        private System.Windows.Forms.Button btnInwardGood;
        private System.Windows.Forms.Button button1;
    }
}