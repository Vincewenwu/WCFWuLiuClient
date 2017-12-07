namespace WCF物流管理系统_Client.用户权限管理
{
    partial class FRM_YongHuQuanXian_Update
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
            this.btnQuXiao = new System.Windows.Forms.Button();
            this.btnQueDing = new System.Windows.Forms.Button();
            this.cboYuanGong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboQuanXianZu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMiMa = new System.Windows.Forms.TextBox();
            this.txtZhangHao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuXiao
            // 
            this.btnQuXiao.Location = new System.Drawing.Point(232, 109);
            this.btnQuXiao.Name = "btnQuXiao";
            this.btnQuXiao.Size = new System.Drawing.Size(73, 34);
            this.btnQuXiao.TabIndex = 19;
            this.btnQuXiao.Text = "取消";
            this.btnQuXiao.UseVisualStyleBackColor = true;
            // 
            // btnQueDing
            // 
            this.btnQueDing.Location = new System.Drawing.Point(105, 109);
            this.btnQueDing.Name = "btnQueDing";
            this.btnQueDing.Size = new System.Drawing.Size(73, 34);
            this.btnQueDing.TabIndex = 18;
            this.btnQueDing.Text = "确定";
            this.btnQueDing.UseVisualStyleBackColor = true;
            this.btnQueDing.Click += new System.EventHandler(this.btnQueDing_Click);
            // 
            // cboYuanGong
            // 
            this.cboYuanGong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYuanGong.FormattingEnabled = true;
            this.cboYuanGong.Location = new System.Drawing.Point(241, 66);
            this.cboYuanGong.Name = "cboYuanGong";
            this.cboYuanGong.Size = new System.Drawing.Size(139, 20);
            this.cboYuanGong.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "员工：";
            // 
            // cboQuanXianZu
            // 
            this.cboQuanXianZu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuanXianZu.FormattingEnabled = true;
            this.cboQuanXianZu.Location = new System.Drawing.Point(57, 66);
            this.cboQuanXianZu.Name = "cboQuanXianZu";
            this.cboQuanXianZu.Size = new System.Drawing.Size(121, 20);
            this.cboQuanXianZu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "权限组：";
            // 
            // txtMiMa
            // 
            this.txtMiMa.Location = new System.Drawing.Point(241, 12);
            this.txtMiMa.Name = "txtMiMa";
            this.txtMiMa.Size = new System.Drawing.Size(139, 21);
            this.txtMiMa.TabIndex = 13;
            // 
            // txtZhangHao
            // 
            this.txtZhangHao.Location = new System.Drawing.Point(57, 12);
            this.txtZhangHao.Name = "txtZhangHao";
            this.txtZhangHao.Size = new System.Drawing.Size(121, 21);
            this.txtZhangHao.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "账号：";
            // 
            // FRM_YongHuQuanXian_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 149);
            this.Controls.Add(this.btnQuXiao);
            this.Controls.Add(this.btnQueDing);
            this.Controls.Add(this.cboYuanGong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboQuanXianZu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMiMa);
            this.Controls.Add(this.txtZhangHao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_YongHuQuanXian_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改用户";
            this.Load += new System.EventHandler(this.FRM_YongHuQuanXian_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuXiao;
        private System.Windows.Forms.Button btnQueDing;
        private System.Windows.Forms.ComboBox cboYuanGong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboQuanXianZu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiMa;
        private System.Windows.Forms.TextBox txtZhangHao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}