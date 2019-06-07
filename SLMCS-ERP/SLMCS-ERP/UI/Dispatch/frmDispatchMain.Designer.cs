namespace SLMCS_ERP
{
    partial class frmDispatch
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
            this.panelLeftNavigate = new System.Windows.Forms.Panel();
            this.btnGoodsReceivedRecord = new System.Windows.Forms.Button();
            this.btnDispatchedRecord = new System.Windows.Forms.Button();
            this.btnGoodsRecevie = new System.Windows.Forms.Button();
            this.btnDispatchOrder = new System.Windows.Forms.Button();
            this.panelLeftNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(150, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1036, 566);
            this.panelContent.TabIndex = 0;
            // 
            // panelLeftNavigate
            // 
            this.panelLeftNavigate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftNavigate.BackgroundImage = global::SLMCS_ERP.Properties.Resources.bg_color;
            this.panelLeftNavigate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeftNavigate.Controls.Add(this.btnGoodsReceivedRecord);
            this.panelLeftNavigate.Controls.Add(this.btnDispatchedRecord);
            this.panelLeftNavigate.Controls.Add(this.btnGoodsRecevie);
            this.panelLeftNavigate.Controls.Add(this.btnDispatchOrder);
            this.panelLeftNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavigate.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavigate.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeftNavigate.Name = "panelLeftNavigate";
            this.panelLeftNavigate.Size = new System.Drawing.Size(150, 566);
            this.panelLeftNavigate.TabIndex = 1;
            // 
            // btnGoodsReceivedRecord
            // 
            this.btnGoodsReceivedRecord.BackColor = System.Drawing.Color.White;
            this.btnGoodsReceivedRecord.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoodsReceivedRecord.Location = new System.Drawing.Point(14, 247);
            this.btnGoodsReceivedRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoodsReceivedRecord.Name = "btnGoodsReceivedRecord";
            this.btnGoodsReceivedRecord.Size = new System.Drawing.Size(120, 50);
            this.btnGoodsReceivedRecord.TabIndex = 3;
            this.btnGoodsReceivedRecord.Text = "Goods Received Record";
            this.btnGoodsReceivedRecord.UseVisualStyleBackColor = false;
            this.btnGoodsReceivedRecord.Click += new System.EventHandler(this.BtnGoodsReceivedRecord_Click);
            // 
            // btnDispatchedRecord
            // 
            this.btnDispatchedRecord.BackColor = System.Drawing.Color.White;
            this.btnDispatchedRecord.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDispatchedRecord.Location = new System.Drawing.Point(14, 97);
            this.btnDispatchedRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispatchedRecord.Name = "btnDispatchedRecord";
            this.btnDispatchedRecord.Size = new System.Drawing.Size(120, 50);
            this.btnDispatchedRecord.TabIndex = 2;
            this.btnDispatchedRecord.Text = "Dispatched Order Record";
            this.btnDispatchedRecord.UseVisualStyleBackColor = false;
            this.btnDispatchedRecord.Click += new System.EventHandler(this.BtnDispatchedRecord_Click);
            // 
            // btnGoodsRecevie
            // 
            this.btnGoodsRecevie.BackColor = System.Drawing.Color.White;
            this.btnGoodsRecevie.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoodsRecevie.Location = new System.Drawing.Point(14, 174);
            this.btnGoodsRecevie.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoodsRecevie.Name = "btnGoodsRecevie";
            this.btnGoodsRecevie.Size = new System.Drawing.Size(120, 50);
            this.btnGoodsRecevie.TabIndex = 1;
            this.btnGoodsRecevie.Text = "Goods Receive";
            this.btnGoodsRecevie.UseVisualStyleBackColor = false;
            this.btnGoodsRecevie.Click += new System.EventHandler(this.BtnGoodsRecevie_Click);
            // 
            // btnDispatchOrder
            // 
            this.btnDispatchOrder.BackColor = System.Drawing.Color.White;
            this.btnDispatchOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDispatchOrder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDispatchOrder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDispatchOrder.Location = new System.Drawing.Point(14, 21);
            this.btnDispatchOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispatchOrder.Name = "btnDispatchOrder";
            this.btnDispatchOrder.Size = new System.Drawing.Size(120, 50);
            this.btnDispatchOrder.TabIndex = 0;
            this.btnDispatchOrder.Text = "Dispatch Order";
            this.btnDispatchOrder.UseVisualStyleBackColor = false;
            this.btnDispatchOrder.Click += new System.EventHandler(this.BtnDispatchOrder_Click);
            // 
            // frmDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1186, 566);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeftNavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDispatch";
            this.Text = "frmDispatchMain";
            this.panelLeftNavigate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLeftNavigate;
        private System.Windows.Forms.Button btnDispatchOrder;
        private System.Windows.Forms.Button btnGoodsRecevie;
        private System.Windows.Forms.Button btnDispatchedRecord;
        private System.Windows.Forms.Button btnGoodsReceivedRecord;
    }
}