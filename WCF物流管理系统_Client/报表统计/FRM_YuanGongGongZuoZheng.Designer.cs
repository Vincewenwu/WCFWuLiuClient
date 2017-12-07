namespace WCF物流管理系统_Client.报表统计
{
    partial class FRM_YuanGongGongZuoZheng
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnShangChuan = new System.Windows.Forms.Button();
            this.txtShangChuan = new System.Windows.Forms.TextBox();
            this.btnLiuLan = new System.Windows.Forms.Button();
            this.btnDaYin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnShangChuan
            // 
            this.btnShangChuan.Location = new System.Drawing.Point(158, 57);
            this.btnShangChuan.Name = "btnShangChuan";
            this.btnShangChuan.Size = new System.Drawing.Size(75, 23);
            this.btnShangChuan.TabIndex = 5;
            this.btnShangChuan.Text = "上传";
            this.btnShangChuan.UseVisualStyleBackColor = true;
            this.btnShangChuan.Click += new System.EventHandler(this.btnShangChuan_Click);
            // 
            // txtShangChuan
            // 
            this.txtShangChuan.Location = new System.Drawing.Point(32, 30);
            this.txtShangChuan.Name = "txtShangChuan";
            this.txtShangChuan.Size = new System.Drawing.Size(100, 21);
            this.txtShangChuan.TabIndex = 7;
            // 
            // btnLiuLan
            // 
            this.btnLiuLan.Location = new System.Drawing.Point(158, 27);
            this.btnLiuLan.Name = "btnLiuLan";
            this.btnLiuLan.Size = new System.Drawing.Size(75, 23);
            this.btnLiuLan.TabIndex = 6;
            this.btnLiuLan.Text = "浏览";
            this.btnLiuLan.UseVisualStyleBackColor = true;
            this.btnLiuLan.Click += new System.EventHandler(this.btnLiuLan_Click);
            // 
            // btnDaYin
            // 
            this.btnDaYin.Location = new System.Drawing.Point(158, 86);
            this.btnDaYin.Name = "btnDaYin";
            this.btnDaYin.Size = new System.Drawing.Size(75, 23);
            this.btnDaYin.TabIndex = 8;
            this.btnDaYin.Text = "打印";
            this.btnDaYin.UseVisualStyleBackColor = true;
            this.btnDaYin.Click += new System.EventHandler(this.btnDaYin_Click);
            // 
            // FRM_YuanGongGongZuoZheng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 130);
            this.Controls.Add(this.btnDaYin);
            this.Controls.Add(this.btnShangChuan);
            this.Controls.Add(this.txtShangChuan);
            this.Controls.Add(this.btnLiuLan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_YuanGongGongZuoZheng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工作证";
            this.Load += new System.EventHandler(this.FRM_YuanGongGongZuoZheng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnShangChuan;
        private System.Windows.Forms.TextBox txtShangChuan;
        private System.Windows.Forms.Button btnLiuLan;
        private System.Windows.Forms.Button btnDaYin;
    }
}