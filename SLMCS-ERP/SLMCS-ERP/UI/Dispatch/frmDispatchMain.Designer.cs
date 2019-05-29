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
            this.DispatchingList = new System.Windows.Forms.Button();
            this.GoodsReceviedList = new System.Windows.Forms.Button();
            this.panelLeftNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1381, 708);
            this.panelContent.TabIndex = 0;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContent_Paint);
            // 
            // panelLeftNavigate
            // 
            this.panelLeftNavigate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftNavigate.Controls.Add(this.GoodsReceviedList);
            this.panelLeftNavigate.Controls.Add(this.DispatchingList);
            this.panelLeftNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavigate.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavigate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeftNavigate.Name = "panelLeftNavigate";
            this.panelLeftNavigate.Size = new System.Drawing.Size(200, 708);
            this.panelLeftNavigate.TabIndex = 1;
            // 
            // DispatchingList
            // 
            this.DispatchingList.Location = new System.Drawing.Point(36, 31);
            this.DispatchingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DispatchingList.Name = "DispatchingList";
            this.DispatchingList.Size = new System.Drawing.Size(129, 54);
            this.DispatchingList.TabIndex = 0;
            this.DispatchingList.Text = "Dispatching List";
            this.DispatchingList.UseVisualStyleBackColor = true;
            this.DispatchingList.Click += new System.EventHandler(this.DispatchingList_Click);
            // 
            // GoodsReceviedList
            // 
            this.GoodsReceviedList.Location = new System.Drawing.Point(36, 154);
            this.GoodsReceviedList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoodsReceviedList.Name = "GoodsReceviedList";
            this.GoodsReceviedList.Size = new System.Drawing.Size(129, 54);
            this.GoodsReceviedList.TabIndex = 1;
            this.GoodsReceviedList.Text = "Goods Received List";
            this.GoodsReceviedList.UseVisualStyleBackColor = true;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDispatch";
            this.Text = "frmDispatchMain";
            this.panelLeftNavigate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLeftNavigate;
        private System.Windows.Forms.Button DispatchingList;
        private System.Windows.Forms.Button GoodsReceviedList;
    }
}