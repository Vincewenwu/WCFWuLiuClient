namespace WCF物流管理系统_Client.报表统计
{
    partial class FRM_ErWeiMaMain
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
            this.btnDanHao = new System.Windows.Forms.Button();
            this.btnWangDian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDanHao
            // 
            this.btnDanHao.Location = new System.Drawing.Point(71, 21);
            this.btnDanHao.Name = "btnDanHao";
            this.btnDanHao.Size = new System.Drawing.Size(141, 55);
            this.btnDanHao.TabIndex = 0;
            this.btnDanHao.Text = "单号";
            this.btnDanHao.UseVisualStyleBackColor = true;
            this.btnDanHao.Click += new System.EventHandler(this.btnDanHao_Click);
            // 
            // btnWangDian
            // 
            this.btnWangDian.Location = new System.Drawing.Point(71, 100);
            this.btnWangDian.Name = "btnWangDian";
            this.btnWangDian.Size = new System.Drawing.Size(141, 55);
            this.btnWangDian.TabIndex = 1;
            this.btnWangDian.Text = "网点";
            this.btnWangDian.UseVisualStyleBackColor = true;
            this.btnWangDian.Click += new System.EventHandler(this.btnWangDian_Click);
            // 
            // FRM_ErWeiMaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 186);
            this.Controls.Add(this.btnWangDian);
            this.Controls.Add(this.btnDanHao);
            this.Name = "FRM_ErWeiMaMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择类别";
            this.Load += new System.EventHandler(this.FRM_ErWeiMaMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDanHao;
        private System.Windows.Forms.Button btnWangDian;
    }
}