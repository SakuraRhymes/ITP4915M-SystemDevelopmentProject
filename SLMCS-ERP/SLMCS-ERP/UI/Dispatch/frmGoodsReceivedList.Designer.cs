namespace SLMCS_ERP.UI.Dispatch
{
    partial class frmGoodsReceivedList
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
            this.OrderId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderId
            // 
            this.OrderId.AutoSize = true;
            this.OrderId.Location = new System.Drawing.Point(103, 129);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(63, 15);
            this.OrderId.TabIndex = 0;
            this.OrderId.Text = "Order ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 25);
            this.textBox1.TabIndex = 1;
            // 
            // staffId
            // 
            this.staffId.AutoSize = true;
            this.staffId.Location = new System.Drawing.Point(108, 187);
            this.staffId.Name = "staffId";
            this.staffId.Size = new System.Drawing.Size(58, 15);
            this.staffId.TabIndex = 2;
            this.staffId.Text = "Staff ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 25);
            this.textBox2.TabIndex = 3;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(108, 236);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(37, 15);
            this.date.TabIndex = 4;
            this.date.Text = "Date:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(252, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 25);
            this.textBox3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 224);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(1077, 321);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(122, 42);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // frmGoodsReceivedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 708);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.staffId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OrderId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGoodsReceivedList";
            this.Text = "frmGoodsReceivedList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label staffId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
    }
}