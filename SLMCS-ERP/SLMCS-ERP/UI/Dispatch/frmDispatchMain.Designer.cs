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
            this.btnGoodsReceivedHistory = new System.Windows.Forms.Button();
            this.btnDispatchedHistory = new System.Windows.Forms.Button();
            this.btnGoodsRecevie = new System.Windows.Forms.Button();
            this.btnDispatchOrder = new System.Windows.Forms.Button();
            this.panelLeftNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(150, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1036, 566);
            this.panelContent.TabIndex = 0;
            // 
            // panelLeftNavigate
            // 
            this.panelLeftNavigate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftNavigate.Controls.Add(this.btnGoodsReceivedHistory);
            this.panelLeftNavigate.Controls.Add(this.btnDispatchedHistory);
            this.panelLeftNavigate.Controls.Add(this.btnGoodsRecevie);
            this.panelLeftNavigate.Controls.Add(this.btnDispatchOrder);
            this.panelLeftNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavigate.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavigate.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeftNavigate.Name = "panelLeftNavigate";
            this.panelLeftNavigate.Size = new System.Drawing.Size(150, 566);
            this.panelLeftNavigate.TabIndex = 1;
            // 
            // btnGoodsReceivedHistory
            // 
            this.btnGoodsReceivedHistory.Location = new System.Drawing.Point(27, 251);
            this.btnGoodsReceivedHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoodsReceivedHistory.Name = "btnGoodsReceivedHistory";
            this.btnGoodsReceivedHistory.Size = new System.Drawing.Size(97, 43);
            this.btnGoodsReceivedHistory.TabIndex = 3;
            this.btnGoodsReceivedHistory.Text = "Goods Received History";
            this.btnGoodsReceivedHistory.UseVisualStyleBackColor = true;
            this.btnGoodsReceivedHistory.Click += new System.EventHandler(this.BtnGoodsReceivedHistory_Click);
            // 
            // btnDispatchedHistory
            // 
            this.btnDispatchedHistory.Location = new System.Drawing.Point(27, 99);
            this.btnDispatchedHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispatchedHistory.Name = "btnDispatchedHistory";
            this.btnDispatchedHistory.Size = new System.Drawing.Size(97, 43);
            this.btnDispatchedHistory.TabIndex = 2;
            this.btnDispatchedHistory.Text = "Dispatched History";
            this.btnDispatchedHistory.UseVisualStyleBackColor = true;
            this.btnDispatchedHistory.Click += new System.EventHandler(this.BtnDispatchedHistory_Click);
            // 
            // btnGoodsRecevie
            // 
            this.btnGoodsRecevie.Location = new System.Drawing.Point(27, 180);
            this.btnGoodsRecevie.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoodsRecevie.Name = "btnGoodsRecevie";
            this.btnGoodsRecevie.Size = new System.Drawing.Size(97, 43);
            this.btnGoodsRecevie.TabIndex = 1;
            this.btnGoodsRecevie.Text = "Goods Receive";
            this.btnGoodsRecevie.UseVisualStyleBackColor = true;
            this.btnGoodsRecevie.Click += new System.EventHandler(this.BtnGoodsRecevie_Click);
            // 
            // btnDispatchOrder
            // 
            this.btnDispatchOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDispatchOrder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDispatchOrder.Location = new System.Drawing.Point(27, 25);
            this.btnDispatchOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispatchOrder.Name = "btnDispatchOrder";
            this.btnDispatchOrder.Size = new System.Drawing.Size(97, 43);
            this.btnDispatchOrder.TabIndex = 0;
            this.btnDispatchOrder.Text = "Dispatch Order";
            this.btnDispatchOrder.UseVisualStyleBackColor = true;
            this.btnDispatchOrder.Click += new System.EventHandler(this.DispatchingList_Click);
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
        private System.Windows.Forms.Button btnDispatchedHistory;
        private System.Windows.Forms.Button btnGoodsReceivedHistory;
    }
}