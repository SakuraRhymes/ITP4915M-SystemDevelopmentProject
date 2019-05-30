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
            this.dispatchHistory = new System.Windows.Forms.Button();
            this.btnGoodsRecevie = new System.Windows.Forms.Button();
            this.btnDispatchOrder = new System.Windows.Forms.Button();
            this.panelLeftNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1381, 708);
            this.panelContent.TabIndex = 0;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContent_Paint);
            // 
            // panelLeftNavigate
            // 
            this.panelLeftNavigate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftNavigate.Controls.Add(this.dispatchHistory);
            this.panelLeftNavigate.Controls.Add(this.btnGoodsRecevie);
            this.panelLeftNavigate.Controls.Add(this.btnDispatchOrder);
            this.panelLeftNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavigate.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavigate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeftNavigate.Name = "panelLeftNavigate";
            this.panelLeftNavigate.Size = new System.Drawing.Size(200, 708);
            this.panelLeftNavigate.TabIndex = 1;
            // 
            // dispatchHistory
            // 
            this.dispatchHistory.Location = new System.Drawing.Point(36, 259);
            this.dispatchHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dispatchHistory.Name = "dispatchHistory";
            this.dispatchHistory.Size = new System.Drawing.Size(129, 54);
            this.dispatchHistory.TabIndex = 2;
            this.dispatchHistory.Text = "Dispatched History";
            this.dispatchHistory.UseVisualStyleBackColor = true;
            this.dispatchHistory.Click += new System.EventHandler(this.DispatchHistory_Click);
            // 
            // btnGoodsRecevie
            // 
            this.btnGoodsRecevie.Location = new System.Drawing.Point(36, 149);
            this.btnGoodsRecevie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoodsRecevie.Name = "btnGoodsRecevie";
            this.btnGoodsRecevie.Size = new System.Drawing.Size(129, 54);
            this.btnGoodsRecevie.TabIndex = 1;
            this.btnGoodsRecevie.Text = "Goods Receive";
            this.btnGoodsRecevie.UseVisualStyleBackColor = true;
            this.btnGoodsRecevie.Click += new System.EventHandler(this.GoodsReceviedList_Click);
            // 
            // btnDispatchOrder
            // 
            this.btnDispatchOrder.Location = new System.Drawing.Point(36, 31);
            this.btnDispatchOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDispatchOrder.Name = "btnDispatchOrder";
            this.btnDispatchOrder.Size = new System.Drawing.Size(129, 54);
            this.btnDispatchOrder.TabIndex = 0;
            this.btnDispatchOrder.Text = "Dispatch Order";
            this.btnDispatchOrder.UseVisualStyleBackColor = true;
            this.btnDispatchOrder.Click += new System.EventHandler(this.DispatchingList_Click);
            // 
            // frmDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1581, 708);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeftNavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button dispatchHistory;
    }
}