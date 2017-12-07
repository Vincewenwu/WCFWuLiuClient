namespace WCF物流管理系统_Client.用户权限管理
{
    partial class FRM_YongHuQuanXian
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.员工姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属权限组 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属权限组ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsYongHu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量赋予用户权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInserYongHu = new System.Windows.Forms.Button();
            this.btnUpdateYongHu = new System.Windows.Forms.Button();
            this.btnYongHu_Del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.cmsYongHu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_User);
            this.groupBox1.Location = new System.Drawing.Point(3, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户：";
            // 
            // dgv_User
            // 
            this.dgv_User.AllowUserToAddRows = false;
            this.dgv_User.AllowUserToDeleteRows = false;
            this.dgv_User.AllowUserToResizeColumns = false;
            this.dgv_User.AllowUserToResizeRows = false;
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.员工姓名,
            this.账号,
            this.密码,
            this.所属权限组,
            this.用户ID,
            this.所属权限组ID,
            this.员工ID});
            this.dgv_User.ContextMenuStrip = this.cmsYongHu;
            this.dgv_User.Location = new System.Drawing.Point(6, 20);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.ReadOnly = true;
            this.dgv_User.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_User.RowTemplate.Height = 23;
            this.dgv_User.Size = new System.Drawing.Size(558, 315);
            this.dgv_User.TabIndex = 0;
            // 
            // 员工姓名
            // 
            this.员工姓名.DataPropertyName = "员工姓名";
            this.员工姓名.HeaderText = "员工姓名";
            this.员工姓名.Name = "员工姓名";
            this.员工姓名.ReadOnly = true;
            // 
            // 账号
            // 
            this.账号.DataPropertyName = "账号";
            this.账号.HeaderText = "账号";
            this.账号.Name = "账号";
            this.账号.ReadOnly = true;
            // 
            // 密码
            // 
            this.密码.DataPropertyName = "密码";
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            this.密码.ReadOnly = true;
            // 
            // 所属权限组
            // 
            this.所属权限组.DataPropertyName = "权限组名称";
            this.所属权限组.HeaderText = "所属权限组";
            this.所属权限组.Name = "所属权限组";
            this.所属权限组.ReadOnly = true;
            // 
            // 用户ID
            // 
            this.用户ID.DataPropertyName = "用户ID";
            this.用户ID.HeaderText = "用户ID";
            this.用户ID.Name = "用户ID";
            this.用户ID.ReadOnly = true;
            this.用户ID.Visible = false;
            // 
            // 所属权限组ID
            // 
            this.所属权限组ID.DataPropertyName = "权限组ID";
            this.所属权限组ID.HeaderText = "所属权限组ID";
            this.所属权限组ID.Name = "所属权限组ID";
            this.所属权限组ID.ReadOnly = true;
            this.所属权限组ID.Visible = false;
            // 
            // 员工ID
            // 
            this.员工ID.DataPropertyName = "员工ID";
            this.员工ID.HeaderText = "员工ID";
            this.员工ID.Name = "员工ID";
            this.员工ID.ReadOnly = true;
            this.员工ID.Visible = false;
            // 
            // cmsYongHu
            // 
            this.cmsYongHu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除用户ToolStripMenuItem,
            this.批量赋予用户权限ToolStripMenuItem});
            this.cmsYongHu.Name = "cmsYongHu";
            this.cmsYongHu.Size = new System.Drawing.Size(173, 48);
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            this.删除用户ToolStripMenuItem.Click += new System.EventHandler(this.删除用户ToolStripMenuItem_Click);
            // 
            // 批量赋予用户权限ToolStripMenuItem
            // 
            this.批量赋予用户权限ToolStripMenuItem.Name = "批量赋予用户权限ToolStripMenuItem";
            this.批量赋予用户权限ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.批量赋予用户权限ToolStripMenuItem.Text = "批量赋予用户权限";
            this.批量赋予用户权限ToolStripMenuItem.Click += new System.EventHandler(this.批量赋予用户权限ToolStripMenuItem_Click);
            // 
            // btnInserYongHu
            // 
            this.btnInserYongHu.Location = new System.Drawing.Point(2, 7);
            this.btnInserYongHu.Name = "btnInserYongHu";
            this.btnInserYongHu.Size = new System.Drawing.Size(63, 32);
            this.btnInserYongHu.TabIndex = 2;
            this.btnInserYongHu.Text = "添加用户";
            this.btnInserYongHu.UseVisualStyleBackColor = true;
            this.btnInserYongHu.Click += new System.EventHandler(this.btnInserYongHu_Click);
            // 
            // btnUpdateYongHu
            // 
            this.btnUpdateYongHu.Location = new System.Drawing.Point(71, 7);
            this.btnUpdateYongHu.Name = "btnUpdateYongHu";
            this.btnUpdateYongHu.Size = new System.Drawing.Size(63, 32);
            this.btnUpdateYongHu.TabIndex = 3;
            this.btnUpdateYongHu.Text = "修改用户";
            this.btnUpdateYongHu.UseVisualStyleBackColor = true;
            this.btnUpdateYongHu.Click += new System.EventHandler(this.btnUpdateYongHu_Click);
            // 
            // btnYongHu_Del
            // 
            this.btnYongHu_Del.Location = new System.Drawing.Point(140, 7);
            this.btnYongHu_Del.Name = "btnYongHu_Del";
            this.btnYongHu_Del.Size = new System.Drawing.Size(63, 32);
            this.btnYongHu_Del.TabIndex = 4;
            this.btnYongHu_Del.Text = "删除用户";
            this.btnYongHu_Del.UseVisualStyleBackColor = true;
            this.btnYongHu_Del.Click += new System.EventHandler(this.btnYongHu_Del_Click);
            // 
            // FRM_YongHuQuanXian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 387);
            this.Controls.Add(this.btnYongHu_Del);
            this.Controls.Add(this.btnUpdateYongHu);
            this.Controls.Add(this.btnInserYongHu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_YongHuQuanXian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户权限管理";
            this.Load += new System.EventHandler(this.FRM_YongHuQuanXian_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.cmsYongHu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.Button btnInserYongHu;
        private System.Windows.Forms.Button btnUpdateYongHu;
        private System.Windows.Forms.Button btnYongHu_Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属权限组;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属权限组ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工ID;
        private System.Windows.Forms.ContextMenuStrip cmsYongHu;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量赋予用户权限ToolStripMenuItem;
    }
}