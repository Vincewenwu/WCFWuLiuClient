namespace WCF物流管理系统_Client
{
    partial class FRM_Info
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
            this.txtBoxContent = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.btnQuXiao = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxContent
            // 
            this.txtBoxContent.Enabled = false;
            this.txtBoxContent.Location = new System.Drawing.Point(1, 1);
            this.txtBoxContent.Multiline = true;
            this.txtBoxContent.Name = "txtBoxContent";
            this.txtBoxContent.Size = new System.Drawing.Size(452, 322);
            this.txtBoxContent.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(1, 326);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(101, 33);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Enabled = false;
            this.btnSaveChange.Location = new System.Drawing.Point(122, 326);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(101, 33);
            this.btnSaveChange.TabIndex = 2;
            this.btnSaveChange.Text = "保存修改";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // btnQuXiao
            // 
            this.btnQuXiao.Enabled = false;
            this.btnQuXiao.Location = new System.Drawing.Point(238, 326);
            this.btnQuXiao.Name = "btnQuXiao";
            this.btnQuXiao.Size = new System.Drawing.Size(101, 33);
            this.btnQuXiao.TabIndex = 3;
            this.btnQuXiao.Text = "取消";
            this.btnQuXiao.UseVisualStyleBackColor = true;
            this.btnQuXiao.Click += new System.EventHandler(this.btnQuXiao_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRM_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnQuXiao);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtBoxContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息";
            this.Load += new System.EventHandler(this.FRM_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxContent;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Button btnQuXiao;
        private System.Windows.Forms.Button btnClose;
    }
}