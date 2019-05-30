namespace SLMCS_ERP
{
    partial class frmDispatchingList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.staffIdLabel = new System.Windows.Forms.Label();
            this.staffIdTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSalesOrderList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(879, 123);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderId
            // 
            this.orderId.AutoSize = true;
            this.orderId.Location = new System.Drawing.Point(33, 52);
            this.orderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(48, 12);
            this.orderId.TabIndex = 1;
            this.orderId.Text = "Order Id:";
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(95, 44);
            this.orderIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(186, 22);
            this.orderIdTextBox.TabIndex = 2;
            // 
            // staffIdLabel
            // 
            this.staffIdLabel.AutoSize = true;
            this.staffIdLabel.Location = new System.Drawing.Point(308, 52);
            this.staffIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffIdLabel.Name = "staffIdLabel";
            this.staffIdLabel.Size = new System.Drawing.Size(43, 12);
            this.staffIdLabel.TabIndex = 3;
            this.staffIdLabel.Text = "Staff Id:";
            // 
            // staffIdTextBox
            // 
            this.staffIdTextBox.Location = new System.Drawing.Point(370, 44);
            this.staffIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.staffIdTextBox.Name = "staffIdTextBox";
            this.staffIdTextBox.Size = new System.Drawing.Size(186, 22);
            this.staffIdTextBox.TabIndex = 4;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(800, 106);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(92, 34);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(635, 44);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(186, 22);
            this.dateTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 523);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate For DID";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(800, 523);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate For DIC";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvSalesOrderList
            // 
            this.dgvSalesOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrderList.Location = new System.Drawing.Point(12, 145);
            this.dgvSalesOrderList.Name = "dgvSalesOrderList";
            this.dgvSalesOrderList.ReadOnly = true;
            this.dgvSalesOrderList.RowTemplate.Height = 24;
            this.dgvSalesOrderList.Size = new System.Drawing.Size(879, 123);
            this.dgvSalesOrderList.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Order Detail:";
            // 
            // frmDispatchingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSalesOrderList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.staffIdTextBox);
            this.Controls.Add(this.staffIdLabel);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDispatchingList";
            this.Text = "frmDispatchingList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label orderId;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.Label staffIdLabel;
        private System.Windows.Forms.TextBox staffIdTextBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvSalesOrderList;
        private System.Windows.Forms.Label label2;
    }
}