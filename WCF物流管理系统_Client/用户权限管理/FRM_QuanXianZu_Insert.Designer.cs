namespace WCF物流管理系统_Client.用户权限管理
{
    partial class FRM_QuanXianZu_Insert
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
            this.txtQuanXianZuMingCheng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMoKuai = new System.Windows.Forms.DataGridView();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.模块名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模块代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模块ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作类型名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作类型ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChaXunMoKuai = new System.Windows.Forms.TextBox();
            this.btnChaXunMoKuai = new System.Windows.Forms.Button();
            this.btnQueDing = new System.Windows.Forms.Button();
            this.btnQuXiao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoKuai)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuanXianZuMingCheng
            // 
            this.txtQuanXianZuMingCheng.Location = new System.Drawing.Point(87, 12);
            this.txtQuanXianZuMingCheng.Name = "txtQuanXianZuMingCheng";
            this.txtQuanXianZuMingCheng.Size = new System.Drawing.Size(169, 21);
            this.txtQuanXianZuMingCheng.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "权限组名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMoKuai);
            this.groupBox1.Controls.Add(this.txtChaXunMoKuai);
            this.groupBox1.Controls.Add(this.btnChaXunMoKuai);
            this.groupBox1.Location = new System.Drawing.Point(2, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作模块：";
            // 
            // dgvMoKuai
            // 
            this.dgvMoKuai.AllowUserToAddRows = false;
            this.dgvMoKuai.AllowUserToDeleteRows = false;
            this.dgvMoKuai.AllowUserToResizeColumns = false;
            this.dgvMoKuai.AllowUserToResizeRows = false;
            this.dgvMoKuai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoKuai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择,
            this.模块名称,
            this.模块代码,
            this.模块ID,
            this.操作类型名称,
            this.操作类型ID});
            this.dgvMoKuai.Location = new System.Drawing.Point(6, 46);
            this.dgvMoKuai.MultiSelect = false;
            this.dgvMoKuai.Name = "dgvMoKuai";
            this.dgvMoKuai.RowTemplate.Height = 23;
            this.dgvMoKuai.Size = new System.Drawing.Size(503, 373);
            this.dgvMoKuai.TabIndex = 4;
            // 
            // 选择
            // 
            this.选择.DataPropertyName = "选择";
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.Width = 50;
            // 
            // 模块名称
            // 
            this.模块名称.DataPropertyName = "模块名称";
            this.模块名称.HeaderText = "模块名称";
            this.模块名称.Name = "模块名称";
            this.模块名称.Width = 150;
            // 
            // 模块代码
            // 
            this.模块代码.DataPropertyName = "模块代码";
            this.模块代码.HeaderText = "模块代码";
            this.模块代码.Name = "模块代码";
            this.模块代码.Width = 150;
            // 
            // 模块ID
            // 
            this.模块ID.DataPropertyName = "模块ID";
            this.模块ID.HeaderText = "模块ID";
            this.模块ID.Name = "模块ID";
            this.模块ID.Visible = false;
            // 
            // 操作类型名称
            // 
            this.操作类型名称.DataPropertyName = "操作类型名称";
            this.操作类型名称.HeaderText = "操作类型名称";
            this.操作类型名称.Name = "操作类型名称";
            // 
            // 操作类型ID
            // 
            this.操作类型ID.DataPropertyName = "操作类型ID";
            this.操作类型ID.HeaderText = "操作类型ID";
            this.操作类型ID.Name = "操作类型ID";
            this.操作类型ID.Visible = false;
            // 
            // txtChaXunMoKuai
            // 
            this.txtChaXunMoKuai.Location = new System.Drawing.Point(6, 22);
            this.txtChaXunMoKuai.Name = "txtChaXunMoKuai";
            this.txtChaXunMoKuai.Size = new System.Drawing.Size(169, 21);
            this.txtChaXunMoKuai.TabIndex = 3;
            // 
            // btnChaXunMoKuai
            // 
            this.btnChaXunMoKuai.Location = new System.Drawing.Point(182, 20);
            this.btnChaXunMoKuai.Name = "btnChaXunMoKuai";
            this.btnChaXunMoKuai.Size = new System.Drawing.Size(75, 23);
            this.btnChaXunMoKuai.TabIndex = 1;
            this.btnChaXunMoKuai.Text = "查询模块";
            this.btnChaXunMoKuai.UseVisualStyleBackColor = true;
            this.btnChaXunMoKuai.Click += new System.EventHandler(this.btnChaXunMoKuai_Click);
            // 
            // btnQueDing
            // 
            this.btnQueDing.Location = new System.Drawing.Point(351, 470);
            this.btnQueDing.Name = "btnQueDing";
            this.btnQueDing.Size = new System.Drawing.Size(80, 39);
            this.btnQueDing.TabIndex = 3;
            this.btnQueDing.Text = "确定";
            this.btnQueDing.UseVisualStyleBackColor = true;
            this.btnQueDing.Click += new System.EventHandler(this.btnQueDing_Click);
            // 
            // btnQuXiao
            // 
            this.btnQuXiao.Location = new System.Drawing.Point(437, 470);
            this.btnQuXiao.Name = "btnQuXiao";
            this.btnQuXiao.Size = new System.Drawing.Size(80, 39);
            this.btnQuXiao.TabIndex = 4;
            this.btnQuXiao.Text = "取消";
            this.btnQuXiao.UseVisualStyleBackColor = true;
            // 
            // FRM_QuanXianZu_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 512);
            this.Controls.Add(this.btnQuXiao);
            this.Controls.Add(this.btnQueDing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuanXianZuMingCheng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_QuanXianZu_Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加权限组";
            this.Load += new System.EventHandler(this.FRM_QuanXianZu_Insert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoKuai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuanXianZuMingCheng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChaXunMoKuai;
        private System.Windows.Forms.Button btnChaXunMoKuai;
        private System.Windows.Forms.DataGridView dgvMoKuai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模块名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模块代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模块ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作类型名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作类型ID;
        private System.Windows.Forms.Button btnQueDing;
        private System.Windows.Forms.Button btnQuXiao;
    }
}