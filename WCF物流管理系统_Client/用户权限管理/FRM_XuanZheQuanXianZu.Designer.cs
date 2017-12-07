namespace WCF物流管理系统_Client.用户权限管理
{
    partial class FRM_XuanZheQuanXianZu
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
            this.cboQuanXianZu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQueDing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboQuanXianZu
            // 
            this.cboQuanXianZu.FormattingEnabled = true;
            this.cboQuanXianZu.Location = new System.Drawing.Point(73, 21);
            this.cboQuanXianZu.Name = "cboQuanXianZu";
            this.cboQuanXianZu.Size = new System.Drawing.Size(194, 20);
            this.cboQuanXianZu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "权限组：";
            // 
            // btnQueDing
            // 
            this.btnQueDing.Location = new System.Drawing.Point(85, 59);
            this.btnQueDing.Name = "btnQueDing";
            this.btnQueDing.Size = new System.Drawing.Size(113, 53);
            this.btnQueDing.TabIndex = 2;
            this.btnQueDing.Text = "确定";
            this.btnQueDing.UseVisualStyleBackColor = true;
            this.btnQueDing.Click += new System.EventHandler(this.btnQueDing_Click);
            // 
            // FRM_XuanZheQuanXianZu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.btnQueDing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboQuanXianZu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_XuanZheQuanXianZu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择权限组";
            this.Load += new System.EventHandler(this.FRM_XuanZheQuanXianZu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQuanXianZu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQueDing;
    }
}