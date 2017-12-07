namespace WCF物流管理系统_Client.用户权限管理
{
    partial class FRM_QuanXianZu
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
            this.btnInsertQuanXianZu = new System.Windows.Forms.Button();
            this.btnEditQuanXianZu = new System.Windows.Forms.Button();
            this.btnQuanXianZu_Delete = new System.Windows.Forms.Button();
            this.dgvAuthGroup = new System.Windows.Forms.DataGridView();
            this.权限组名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.权限组ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMoKuai = new System.Windows.Forms.DataGridView();
            this.模块名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模块代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模块ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作类型名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作类型ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthGroup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoKuai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertQuanXianZu
            // 
            this.btnInsertQuanXianZu.Location = new System.Drawing.Point(2, 7);
            this.btnInsertQuanXianZu.Name = "btnInsertQuanXianZu";
            this.btnInsertQuanXianZu.Size = new System.Drawing.Size(96, 44);
            this.btnInsertQuanXianZu.TabIndex = 0;
            this.btnInsertQuanXianZu.Text = "添加权限组";
            this.btnInsertQuanXianZu.UseVisualStyleBackColor = true;
            this.btnInsertQuanXianZu.Click += new System.EventHandler(this.btnInsertQuanXianZu_Click);
            // 
            // btnEditQuanXianZu
            // 
            this.btnEditQuanXianZu.Location = new System.Drawing.Point(104, 7);
            this.btnEditQuanXianZu.Name = "btnEditQuanXianZu";
            this.btnEditQuanXianZu.Size = new System.Drawing.Size(96, 44);
            this.btnEditQuanXianZu.TabIndex = 1;
            this.btnEditQuanXianZu.Text = "修改权限组";
            this.btnEditQuanXianZu.UseVisualStyleBackColor = true;
            this.btnEditQuanXianZu.Click += new System.EventHandler(this.btnEditQuanXianZu_Click);
            // 
            // btnQuanXianZu_Delete
            // 
            this.btnQuanXianZu_Delete.Location = new System.Drawing.Point(206, 7);
            this.btnQuanXianZu_Delete.Name = "btnQuanXianZu_Delete";
            this.btnQuanXianZu_Delete.Size = new System.Drawing.Size(96, 44);
            this.btnQuanXianZu_Delete.TabIndex = 2;
            this.btnQuanXianZu_Delete.Text = "删除权限组";
            this.btnQuanXianZu_Delete.UseVisualStyleBackColor = true;
            this.btnQuanXianZu_Delete.Click += new System.EventHandler(this.btnQuanXianZu_Delete_Click);
            // 
            // dgvAuthGroup
            // 
            this.dgvAuthGroup.AllowUserToAddRows = false;
            this.dgvAuthGroup.AllowUserToDeleteRows = false;
            this.dgvAuthGroup.AllowUserToResizeColumns = false;
            this.dgvAuthGroup.AllowUserToResizeRows = false;
            this.dgvAuthGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.权限组名称,
            this.权限组ID});
            this.dgvAuthGroup.Location = new System.Drawing.Point(6, 18);
            this.dgvAuthGroup.MultiSelect = false;
            this.dgvAuthGroup.Name = "dgvAuthGroup";
            this.dgvAuthGroup.ReadOnly = true;
            this.dgvAuthGroup.RowTemplate.Height = 23;
            this.dgvAuthGroup.Size = new System.Drawing.Size(284, 414);
            this.dgvAuthGroup.TabIndex = 3;
            this.dgvAuthGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthGroup_CellClick);
            // 
            // 权限组名称
            // 
            this.权限组名称.DataPropertyName = "权限组名称";
            this.权限组名称.HeaderText = "权限组名称";
            this.权限组名称.Name = "权限组名称";
            this.权限组名称.ReadOnly = true;
            this.权限组名称.Width = 200;
            // 
            // 权限组ID
            // 
            this.权限组ID.DataPropertyName = "权限组ID";
            this.权限组ID.HeaderText = "权限组ID";
            this.权限组ID.Name = "权限组ID";
            this.权限组ID.ReadOnly = true;
            this.权限组ID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAuthGroup);
            this.groupBox1.Location = new System.Drawing.Point(5, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 437);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权限组：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMoKuai);
            this.groupBox2.Location = new System.Drawing.Point(308, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 437);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模块：";
            // 
            // dgvMoKuai
            // 
            this.dgvMoKuai.AllowUserToAddRows = false;
            this.dgvMoKuai.AllowUserToDeleteRows = false;
            this.dgvMoKuai.AllowUserToResizeColumns = false;
            this.dgvMoKuai.AllowUserToResizeRows = false;
            this.dgvMoKuai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoKuai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.模块名称,
            this.模块代码,
            this.模块ID,
            this.操作类型名称,
            this.操作类型ID});
            this.dgvMoKuai.Location = new System.Drawing.Point(6, 18);
            this.dgvMoKuai.MultiSelect = false;
            this.dgvMoKuai.Name = "dgvMoKuai";
            this.dgvMoKuai.ReadOnly = true;
            this.dgvMoKuai.RowTemplate.Height = 23;
            this.dgvMoKuai.Size = new System.Drawing.Size(469, 414);
            this.dgvMoKuai.TabIndex = 3;
            // 
            // 模块名称
            // 
            this.模块名称.DataPropertyName = "模块名称";
            this.模块名称.HeaderText = "模块名称";
            this.模块名称.Name = "模块名称";
            this.模块名称.ReadOnly = true;
            this.模块名称.Width = 150;
            // 
            // 模块代码
            // 
            this.模块代码.DataPropertyName = "模块代码";
            this.模块代码.HeaderText = "模块代码";
            this.模块代码.Name = "模块代码";
            this.模块代码.ReadOnly = true;
            this.模块代码.Width = 150;
            // 
            // 模块ID
            // 
            this.模块ID.DataPropertyName = "模块ID";
            this.模块ID.HeaderText = "模块ID";
            this.模块ID.Name = "模块ID";
            this.模块ID.ReadOnly = true;
            this.模块ID.Visible = false;
            // 
            // 操作类型名称
            // 
            this.操作类型名称.DataPropertyName = "操作类型名称";
            this.操作类型名称.HeaderText = "操作类型名称";
            this.操作类型名称.Name = "操作类型名称";
            this.操作类型名称.ReadOnly = true;
            // 
            // 操作类型ID
            // 
            this.操作类型ID.DataPropertyName = "操作类型ID";
            this.操作类型ID.HeaderText = "操作类型ID";
            this.操作类型ID.Name = "操作类型ID";
            this.操作类型ID.ReadOnly = true;
            this.操作类型ID.Visible = false;
            // 
            // FRM_QuanXianZu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuanXianZu_Delete);
            this.Controls.Add(this.btnEditQuanXianZu);
            this.Controls.Add(this.btnInsertQuanXianZu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_QuanXianZu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "权限组";
            this.Load += new System.EventHandler(this.FRM_QuanXianZu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthGroup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoKuai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertQuanXianZu;
        private System.Windows.Forms.Button btnEditQuanXianZu;
        private System.Windows.Forms.Button btnQuanXianZu_Delete;
        private System.Windows.Forms.DataGridView dgvAuthGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMoKuai;
        private System.Windows.Forms.DataGridViewTextBoxColumn 权限组名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 权限组ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模块名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模块代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模块ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作类型名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作类型ID;
    }
}