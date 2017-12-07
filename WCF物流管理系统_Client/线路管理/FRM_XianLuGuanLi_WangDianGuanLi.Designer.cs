namespace WCF物流管理系统_Client.线路管理
{
    partial class FRM_XianLuGuanLi_WangDianGuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_XianLuGuanLi_WangDianGuanLi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbXinZeng_Insert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXiuGai_Update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShanChu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkYiTingYong = new System.Windows.Forms.RadioButton();
            this.btnChaXunWangDianXinXi = new System.Windows.Forms.Button();
            this.txtWangDianMingCheng = new System.Windows.Forms.TextBox();
            this.rbtWangDianMingCheng = new System.Windows.Forms.RadioButton();
            this.dgvWangDianXinXi = new System.Windows.Forms.DataGridView();
            this.网点名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.网点ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXiangLinWangDianXinXi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.距离 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWangDianXinXi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXiangLinWangDianXinXi)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbXinZeng_Insert,
            this.toolStripSeparator3,
            this.tsbXiuGai_Update,
            this.toolStripSeparator1,
            this.tsbShanChu,
            this.toolStripSeparator4,
            this.toolStripButton5,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbXinZeng_Insert
            // 
            this.tsbXinZeng_Insert.Image = ((System.Drawing.Image)(resources.GetObject("tsbXinZeng_Insert.Image")));
            this.tsbXinZeng_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXinZeng_Insert.Name = "tsbXinZeng_Insert";
            this.tsbXinZeng_Insert.Size = new System.Drawing.Size(76, 22);
            this.tsbXinZeng_Insert.Text = "新增网点";
            this.tsbXinZeng_Insert.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbXiuGai_Update
            // 
            this.tsbXiuGai_Update.Image = ((System.Drawing.Image)(resources.GetObject("tsbXiuGai_Update.Image")));
            this.tsbXiuGai_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXiuGai_Update.Name = "tsbXiuGai_Update";
            this.tsbXiuGai_Update.Size = new System.Drawing.Size(76, 22);
            this.tsbXiuGai_Update.Text = "修改网点";
            this.tsbXiuGai_Update.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbShanChu
            // 
            this.tsbShanChu.Image = ((System.Drawing.Image)(resources.GetObject("tsbShanChu.Image")));
            this.tsbShanChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShanChu.Name = "tsbShanChu";
            this.tsbShanChu.Size = new System.Drawing.Size(52, 22);
            this.tsbShanChu.Text = "停用";
            this.tsbShanChu.Click += new System.EventHandler(this.tsbShanChu_Delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton5.Text = "返回";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(317, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 60;
            this.label1.Text = "网点管理";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkYiTingYong);
            this.panel1.Controls.Add(this.btnChaXunWangDianXinXi);
            this.panel1.Controls.Add(this.txtWangDianMingCheng);
            this.panel1.Controls.Add(this.rbtWangDianMingCheng);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 32);
            this.panel1.TabIndex = 61;
            // 
            // chkYiTingYong
            // 
            this.chkYiTingYong.AutoSize = true;
            this.chkYiTingYong.Location = new System.Drawing.Point(321, 7);
            this.chkYiTingYong.Name = "chkYiTingYong";
            this.chkYiTingYong.Size = new System.Drawing.Size(59, 16);
            this.chkYiTingYong.TabIndex = 34;
            this.chkYiTingYong.TabStop = true;
            this.chkYiTingYong.Text = "已停用";
            this.chkYiTingYong.UseVisualStyleBackColor = true;
            // 
            // btnChaXunWangDianXinXi
            // 
            this.btnChaXunWangDianXinXi.Location = new System.Drawing.Point(401, 3);
            this.btnChaXunWangDianXinXi.Name = "btnChaXunWangDianXinXi";
            this.btnChaXunWangDianXinXi.Size = new System.Drawing.Size(75, 23);
            this.btnChaXunWangDianXinXi.TabIndex = 29;
            this.btnChaXunWangDianXinXi.Text = "查询";
            this.btnChaXunWangDianXinXi.UseVisualStyleBackColor = true;
            this.btnChaXunWangDianXinXi.Click += new System.EventHandler(this.btnChaXunWangDianXinXi_Click);
            // 
            // txtWangDianMingCheng
            // 
            this.txtWangDianMingCheng.Location = new System.Drawing.Point(88, 5);
            this.txtWangDianMingCheng.Name = "txtWangDianMingCheng";
            this.txtWangDianMingCheng.Size = new System.Drawing.Size(210, 21);
            this.txtWangDianMingCheng.TabIndex = 28;
            this.txtWangDianMingCheng.TextChanged += new System.EventHandler(this.txtWangDianMingCheng_TextChanged);
            // 
            // rbtWangDianMingCheng
            // 
            this.rbtWangDianMingCheng.AutoSize = true;
            this.rbtWangDianMingCheng.Location = new System.Drawing.Point(11, 7);
            this.rbtWangDianMingCheng.Name = "rbtWangDianMingCheng";
            this.rbtWangDianMingCheng.Size = new System.Drawing.Size(83, 16);
            this.rbtWangDianMingCheng.TabIndex = 26;
            this.rbtWangDianMingCheng.TabStop = true;
            this.rbtWangDianMingCheng.Text = "网点名称：";
            this.rbtWangDianMingCheng.UseVisualStyleBackColor = true;
            // 
            // dgvWangDianXinXi
            // 
            this.dgvWangDianXinXi.AllowUserToAddRows = false;
            this.dgvWangDianXinXi.AllowUserToDeleteRows = false;
            this.dgvWangDianXinXi.AllowUserToResizeColumns = false;
            this.dgvWangDianXinXi.AllowUserToResizeRows = false;
            this.dgvWangDianXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWangDianXinXi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.网点名称,
            this.网点ID});
            this.dgvWangDianXinXi.Location = new System.Drawing.Point(0, 94);
            this.dgvWangDianXinXi.MultiSelect = false;
            this.dgvWangDianXinXi.Name = "dgvWangDianXinXi";
            this.dgvWangDianXinXi.ReadOnly = true;
            this.dgvWangDianXinXi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvWangDianXinXi.RowTemplate.Height = 23;
            this.dgvWangDianXinXi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWangDianXinXi.Size = new System.Drawing.Size(381, 449);
            this.dgvWangDianXinXi.TabIndex = 62;
            this.dgvWangDianXinXi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWangDianXinXi_CellClick);
            this.dgvWangDianXinXi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWangDianXinXi_CellFormatting);
            // 
            // 网点名称
            // 
            this.网点名称.DataPropertyName = "网点名称";
            this.网点名称.HeaderText = "网点名称";
            this.网点名称.Name = "网点名称";
            this.网点名称.ReadOnly = true;
            this.网点名称.Width = 300;
            // 
            // 网点ID
            // 
            this.网点ID.DataPropertyName = "网点ID";
            this.网点ID.HeaderText = "网点ID";
            this.网点ID.Name = "网点ID";
            this.网点ID.ReadOnly = true;
            this.网点ID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(387, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 440);
            this.label2.TabIndex = 64;
            this.label2.Text = ">\r\n>\r\n>\r\n可\r\n到\r\n达\r\n网\r\n点\r\n列\r\n表\r\n（\r\n以\r\n自\r\n己\r\n为\r\n出\r\n发\r\n点\r\n）\r\n>\r\n>\r\n>";
            // 
            // dgvXiangLinWangDianXinXi
            // 
            this.dgvXiangLinWangDianXinXi.AllowUserToAddRows = false;
            this.dgvXiangLinWangDianXinXi.AllowUserToDeleteRows = false;
            this.dgvXiangLinWangDianXinXi.AllowUserToResizeColumns = false;
            this.dgvXiangLinWangDianXinXi.AllowUserToResizeRows = false;
            this.dgvXiangLinWangDianXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXiangLinWangDianXinXi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.距离});
            this.dgvXiangLinWangDianXinXi.Location = new System.Drawing.Point(425, 94);
            this.dgvXiangLinWangDianXinXi.MultiSelect = false;
            this.dgvXiangLinWangDianXinXi.Name = "dgvXiangLinWangDianXinXi";
            this.dgvXiangLinWangDianXinXi.ReadOnly = true;
            this.dgvXiangLinWangDianXinXi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvXiangLinWangDianXinXi.RowTemplate.Height = 23;
            this.dgvXiangLinWangDianXinXi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXiangLinWangDianXinXi.Size = new System.Drawing.Size(381, 449);
            this.dgvXiangLinWangDianXinXi.TabIndex = 65;
            this.dgvXiangLinWangDianXinXi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvXiangLinWangDianXinXi_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "相邻网点名称";
            this.dataGridViewTextBoxColumn1.HeaderText = "相邻网点名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "相邻网点ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "相邻网点ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // 距离
            // 
            this.距离.DataPropertyName = "距离";
            this.距离.HeaderText = "距离";
            this.距离.Name = "距离";
            this.距离.ReadOnly = true;
            // 
            // FRM_XianLuGuanLi_WangDianGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 547);
            this.Controls.Add(this.dgvXiangLinWangDianXinXi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvWangDianXinXi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_XianLuGuanLi_WangDianGuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网点管理";
            this.Load += new System.EventHandler(this.FRM_XianLuGuanLi_WangDianGuanLi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWangDianXinXi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXiangLinWangDianXinXi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbXinZeng_Insert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbXiuGai_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbShanChu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChaXunWangDianXinXi;
        private System.Windows.Forms.TextBox txtWangDianMingCheng;
        private System.Windows.Forms.RadioButton rbtWangDianMingCheng;
        private System.Windows.Forms.DataGridView dgvWangDianXinXi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网点名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网点ID;
        private System.Windows.Forms.DataGridView dgvXiangLinWangDianXinXi;
        private System.Windows.Forms.RadioButton chkYiTingYong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 距离;
    }
}