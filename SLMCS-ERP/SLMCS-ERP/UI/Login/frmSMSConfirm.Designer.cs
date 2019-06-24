namespace SLMCS_ERP.UI.Login
{
    partial class frmSMSConfirm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSMSCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmCode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSMSCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConfirmCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(41, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 214);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(37, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please enter the 6-digit SMS code";
            // 
            // txtSMSCode
            // 
            this.txtSMSCode.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSMSCode.Location = new System.Drawing.Point(145, 91);
            this.txtSMSCode.Name = "txtSMSCode";
            this.txtSMSCode.Size = new System.Drawing.Size(153, 23);
            this.txtSMSCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "SMS Code :";
            // 
            // btnConfirmCode
            // 
            this.btnConfirmCode.BackColor = System.Drawing.Color.White;
            this.btnConfirmCode.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirmCode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfirmCode.Location = new System.Drawing.Point(91, 151);
            this.btnConfirmCode.Name = "btnConfirmCode";
            this.btnConfirmCode.Size = new System.Drawing.Size(146, 32);
            this.btnConfirmCode.TabIndex = 8;
            this.btnConfirmCode.Text = "Confirm Code";
            this.btnConfirmCode.UseVisualStyleBackColor = false;
            this.btnConfirmCode.Click += new System.EventHandler(this.BtnConfirmCode_Click);
            // 
            // frmSMSConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SLMCS_ERP.Properties.Resources.bg_color;
            this.ClientSize = new System.Drawing.Size(423, 256);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSMSConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Confirm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMSCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmCode;
    }
}