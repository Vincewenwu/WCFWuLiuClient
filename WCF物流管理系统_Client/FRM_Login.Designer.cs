namespace WCF物流管理系统_Client
{
    partial class FRM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYanZhengMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MiMa = new System.Windows.Forms.TextBox();
            this.cbo_YongHuMing = new System.Windows.Forms.ComboBox();
            this.btn_QvXiao = new System.Windows.Forms.Button();
            this.btn_DengLu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYanZhengMa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_MiMa);
            this.groupBox1.Controls.Add(this.cbo_YongHuMing);
            this.groupBox1.Controls.Add(this.btn_QvXiao);
            this.groupBox1.Controls.Add(this.btn_DengLu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(-1, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(288, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "右键查看验证码代码";
            // 
            // txtYanZhengMa
            // 
            this.txtYanZhengMa.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYanZhengMa.Location = new System.Drawing.Point(99, 100);
            this.txtYanZhengMa.Name = "txtYanZhengMa";
            this.txtYanZhengMa.Size = new System.Drawing.Size(193, 26);
            this.txtYanZhengMa.TabIndex = 7;
            this.txtYanZhengMa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYanZhengMa_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(34, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "验证码:";
            // 
            // txt_MiMa
            // 
            this.txt_MiMa.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_MiMa.Location = new System.Drawing.Point(99, 59);
            this.txt_MiMa.Name = "txt_MiMa";
            this.txt_MiMa.PasswordChar = '*';
            this.txt_MiMa.Size = new System.Drawing.Size(271, 26);
            this.txt_MiMa.TabIndex = 5;
            // 
            // cbo_YongHuMing
            // 
            this.cbo_YongHuMing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_YongHuMing.FormattingEnabled = true;
            this.cbo_YongHuMing.Location = new System.Drawing.Point(99, 23);
            this.cbo_YongHuMing.Name = "cbo_YongHuMing";
            this.cbo_YongHuMing.Size = new System.Drawing.Size(271, 24);
            this.cbo_YongHuMing.TabIndex = 4;
            // 
            // btn_QvXiao
            // 
            this.btn_QvXiao.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_QvXiao.Location = new System.Drawing.Point(235, 132);
            this.btn_QvXiao.Name = "btn_QvXiao";
            this.btn_QvXiao.Size = new System.Drawing.Size(135, 51);
            this.btn_QvXiao.TabIndex = 3;
            this.btn_QvXiao.Text = "取消(&C)";
            this.btn_QvXiao.UseVisualStyleBackColor = true;
            this.btn_QvXiao.Click += new System.EventHandler(this.btn_QvXiao_Click);
            // 
            // btn_DengLu
            // 
            this.btn_DengLu.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DengLu.Location = new System.Drawing.Point(99, 132);
            this.btn_DengLu.Name = "btn_DengLu";
            this.btn_DengLu.Size = new System.Drawing.Size(135, 51);
            this.btn_DengLu.TabIndex = 2;
            this.btn_DengLu.Text = "登录(&O)";
            this.btn_DengLu.UseVisualStyleBackColor = true;
            this.btn_DengLu.Click += new System.EventHandler(this.btn_DengLu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(34, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "密   码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(298, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 26);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WCF物流管理系统_Client.Properties.Resources.tms4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 58);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(400, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 291);
            this.Name = "FRM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物流管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Login_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MiMa;
        private System.Windows.Forms.ComboBox cbo_YongHuMing;
        private System.Windows.Forms.Button btn_QvXiao;
        private System.Windows.Forms.Button btn_DengLu;
        private System.Windows.Forms.TextBox txtYanZhengMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}