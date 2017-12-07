namespace WCF物流管理系统_Client.报表统计
{
    partial class FRM_ErWeiMaDanHao
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
            this.btnShengCheng = new System.Windows.Forms.Button();
            this.lblShuliang = new System.Windows.Forms.Label();
            this.nudShengChengShuLiang = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudShengChengShuLiang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShengCheng
            // 
            this.btnShengCheng.Location = new System.Drawing.Point(287, 23);
            this.btnShengCheng.Name = "btnShengCheng";
            this.btnShengCheng.Size = new System.Drawing.Size(83, 25);
            this.btnShengCheng.TabIndex = 0;
            this.btnShengCheng.Text = "生成";
            this.btnShengCheng.UseVisualStyleBackColor = true;
            this.btnShengCheng.Click += new System.EventHandler(this.btnShengCheng_Click);
            // 
            // lblShuliang
            // 
            this.lblShuliang.AutoSize = true;
            this.lblShuliang.Location = new System.Drawing.Point(53, 29);
            this.lblShuliang.Name = "lblShuliang";
            this.lblShuliang.Size = new System.Drawing.Size(75, 15);
            this.lblShuliang.TabIndex = 3;
            this.lblShuliang.Text = "生成数量:";
            // 
            // nudShengChengShuLiang
            // 
            this.nudShengChengShuLiang.Location = new System.Drawing.Point(148, 23);
            this.nudShengChengShuLiang.Name = "nudShengChengShuLiang";
            this.nudShengChengShuLiang.Size = new System.Drawing.Size(120, 25);
            this.nudShengChengShuLiang.TabIndex = 4;
            // 
            // FRM_ErWeiMaDanHao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 103);
            this.Controls.Add(this.nudShengChengShuLiang);
            this.Controls.Add(this.lblShuliang);
            this.Controls.Add(this.btnShengCheng);
            this.Name = "FRM_ErWeiMaDanHao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成二维码";
            ((System.ComponentModel.ISupportInitialize)(this.nudShengChengShuLiang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShengCheng;
        private System.Windows.Forms.Label lblShuliang;
        private System.Windows.Forms.NumericUpDown nudShengChengShuLiang;
    }
}