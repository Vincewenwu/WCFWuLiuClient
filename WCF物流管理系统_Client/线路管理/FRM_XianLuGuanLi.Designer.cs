namespace WCF物流管理系统_Client.线路管理
{
    partial class FRM_XianLuGuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_XianLuGuanLi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbXinZeng_Insert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXiuGai_Update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShangChu_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWangDianGuanLi = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtXianLuMingCheng = new System.Windows.Forms.TextBox();
            this.cboQiShiWangDian = new System.Windows.Forms.ComboBox();
            this.cboJieShuWangDian = new System.Windows.Forms.ComboBox();
            this.btnChaXun_Select = new System.Windows.Forms.Button();
            this.txZhuJiMa = new System.Windows.Forms.TextBox();
            this.rdbZhuJiMa = new System.Windows.Forms.RadioButton();
            this.rdbQiZhiWangDian = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbXianLuMingCheng = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvXianLuXinXi = new System.Windows.Forms.DataGridView();
            this.线路名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.助记码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.线路ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvXianLuWangDianXinXi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.网点名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.相邻网点名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXianLuXinXi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXianLuWangDianXinXi)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbXinZeng_Insert,
            this.toolStripSeparator1,
            this.tsbXiuGai_Update,
            this.toolStripSeparator2,
            this.tsbShangChu_Delete,
            this.toolStripSeparator3,
            this.tsbWangDianGuanLi,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1034, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "关闭";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbXinZeng_Insert
            // 
            this.tsbXinZeng_Insert.Image = ((System.Drawing.Image)(resources.GetObject("tsbXinZeng_Insert.Image")));
            this.tsbXinZeng_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXinZeng_Insert.Name = "tsbXinZeng_Insert";
            this.tsbXinZeng_Insert.Size = new System.Drawing.Size(76, 22);
            this.tsbXinZeng_Insert.Text = "新增线路";
            this.tsbXinZeng_Insert.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbXiuGai_Update
            // 
            this.tsbXiuGai_Update.Image = ((System.Drawing.Image)(resources.GetObject("tsbXiuGai_Update.Image")));
            this.tsbXiuGai_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXiuGai_Update.Name = "tsbXiuGai_Update";
            this.tsbXiuGai_Update.Size = new System.Drawing.Size(76, 22);
            this.tsbXiuGai_Update.Text = "修改线路";
            this.tsbXiuGai_Update.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbShangChu_Delete
            // 
            this.tsbShangChu_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsbShangChu_Delete.Image")));
            this.tsbShangChu_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShangChu_Delete.Name = "tsbShangChu_Delete";
            this.tsbShangChu_Delete.Size = new System.Drawing.Size(76, 22);
            this.tsbShangChu_Delete.Text = "停用线路";
            this.tsbShangChu_Delete.Click += new System.EventHandler(this.tsbShangChu_Delete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbWangDianGuanLi
            // 
            this.tsbWangDianGuanLi.Image = ((System.Drawing.Image)(resources.GetObject("tsbWangDianGuanLi.Image")));
            this.tsbWangDianGuanLi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWangDianGuanLi.Name = "tsbWangDianGuanLi";
            this.tsbWangDianGuanLi.Size = new System.Drawing.Size(76, 22);
            this.tsbWangDianGuanLi.Text = "网点管理";
            this.tsbWangDianGuanLi.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 599);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtXianLuMingCheng);
            this.panel1.Controls.Add(this.cboQiShiWangDian);
            this.panel1.Controls.Add(this.cboJieShuWangDian);
            this.panel1.Controls.Add(this.btnChaXun_Select);
            this.panel1.Controls.Add(this.txZhuJiMa);
            this.panel1.Controls.Add(this.rdbZhuJiMa);
            this.panel1.Controls.Add(this.rdbQiZhiWangDian);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdbXianLuMingCheng);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 42);
            this.panel1.TabIndex = 0;
            // 
            // txtXianLuMingCheng
            // 
            this.txtXianLuMingCheng.Location = new System.Drawing.Point(474, 6);
            this.txtXianLuMingCheng.Name = "txtXianLuMingCheng";
            this.txtXianLuMingCheng.Size = new System.Drawing.Size(134, 21);
            this.txtXianLuMingCheng.TabIndex = 35;
            // 
            // cboQiShiWangDian
            // 
            this.cboQiShiWangDian.FormattingEnabled = true;
            this.cboQiShiWangDian.Location = new System.Drawing.Point(76, 8);
            this.cboQiShiWangDian.Name = "cboQiShiWangDian";
            this.cboQiShiWangDian.Size = new System.Drawing.Size(132, 20);
            this.cboQiShiWangDian.TabIndex = 34;
            // 
            // cboJieShuWangDian
            // 
            this.cboJieShuWangDian.FormattingEnabled = true;
            this.cboJieShuWangDian.Location = new System.Drawing.Point(237, 8);
            this.cboJieShuWangDian.Name = "cboJieShuWangDian";
            this.cboJieShuWangDian.Size = new System.Drawing.Size(141, 20);
            this.cboJieShuWangDian.TabIndex = 33;
            // 
            // btnChaXun_Select
            // 
            this.btnChaXun_Select.Location = new System.Drawing.Point(854, 5);
            this.btnChaXun_Select.Name = "btnChaXun_Select";
            this.btnChaXun_Select.Size = new System.Drawing.Size(75, 23);
            this.btnChaXun_Select.TabIndex = 29;
            this.btnChaXun_Select.Text = "查询";
            this.btnChaXun_Select.UseVisualStyleBackColor = true;
            this.btnChaXun_Select.Click += new System.EventHandler(this.btnChaXun_Select_Click);
            // 
            // txZhuJiMa
            // 
            this.txZhuJiMa.Location = new System.Drawing.Point(684, 6);
            this.txZhuJiMa.Name = "txZhuJiMa";
            this.txZhuJiMa.Size = new System.Drawing.Size(165, 21);
            this.txZhuJiMa.TabIndex = 28;
            // 
            // rdbZhuJiMa
            // 
            this.rdbZhuJiMa.AutoSize = true;
            this.rdbZhuJiMa.Location = new System.Drawing.Point(618, 8);
            this.rdbZhuJiMa.Name = "rdbZhuJiMa";
            this.rdbZhuJiMa.Size = new System.Drawing.Size(71, 16);
            this.rdbZhuJiMa.TabIndex = 26;
            this.rdbZhuJiMa.TabStop = true;
            this.rdbZhuJiMa.Text = "助记码：";
            this.rdbZhuJiMa.UseVisualStyleBackColor = true;
            // 
            // rdbQiZhiWangDian
            // 
            this.rdbQiZhiWangDian.AutoSize = true;
            this.rdbQiZhiWangDian.Location = new System.Drawing.Point(3, 9);
            this.rdbQiZhiWangDian.Name = "rdbQiZhiWangDian";
            this.rdbQiZhiWangDian.Size = new System.Drawing.Size(83, 16);
            this.rdbQiZhiWangDian.TabIndex = 15;
            this.rdbQiZhiWangDian.TabStop = true;
            this.rdbQiZhiWangDian.Text = "起止网点：";
            this.rdbQiZhiWangDian.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "至";
            // 
            // rdbXianLuMingCheng
            // 
            this.rdbXianLuMingCheng.AutoSize = true;
            this.rdbXianLuMingCheng.Location = new System.Drawing.Point(399, 9);
            this.rdbXianLuMingCheng.Name = "rdbXianLuMingCheng";
            this.rdbXianLuMingCheng.Size = new System.Drawing.Size(83, 16);
            this.rdbXianLuMingCheng.TabIndex = 32;
            this.rdbXianLuMingCheng.TabStop = true;
            this.rdbXianLuMingCheng.Text = "线路名称：";
            this.rdbXianLuMingCheng.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvXianLuXinXi);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvXianLuWangDianXinXi);
            this.splitContainer2.Size = new System.Drawing.Size(1034, 553);
            this.splitContainer2.SplitterDistance = 505;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvXianLuXinXi
            // 
            this.dgvXianLuXinXi.AllowUserToAddRows = false;
            this.dgvXianLuXinXi.AllowUserToDeleteRows = false;
            this.dgvXianLuXinXi.AllowUserToResizeColumns = false;
            this.dgvXianLuXinXi.AllowUserToResizeRows = false;
            this.dgvXianLuXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXianLuXinXi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.线路名称,
            this.助记码,
            this.线路ID});
            this.dgvXianLuXinXi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXianLuXinXi.Location = new System.Drawing.Point(0, 0);
            this.dgvXianLuXinXi.MultiSelect = false;
            this.dgvXianLuXinXi.Name = "dgvXianLuXinXi";
            this.dgvXianLuXinXi.ReadOnly = true;
            this.dgvXianLuXinXi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvXianLuXinXi.RowTemplate.Height = 27;
            this.dgvXianLuXinXi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXianLuXinXi.Size = new System.Drawing.Size(505, 553);
            this.dgvXianLuXinXi.TabIndex = 1;
            this.dgvXianLuXinXi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvXianLuXinXi_CellFormatting);
            this.dgvXianLuXinXi.SelectionChanged += new System.EventHandler(this.dgvXianLuXinXi_SelectionChanged);
            // 
            // 线路名称
            // 
            this.线路名称.DataPropertyName = "线路名称";
            this.线路名称.Frozen = true;
            this.线路名称.HeaderText = "线路名称";
            this.线路名称.Name = "线路名称";
            this.线路名称.ReadOnly = true;
            this.线路名称.Width = 200;
            // 
            // 助记码
            // 
            this.助记码.DataPropertyName = "助记码";
            this.助记码.HeaderText = "助记码";
            this.助记码.Name = "助记码";
            this.助记码.ReadOnly = true;
            this.助记码.Width = 200;
            // 
            // 线路ID
            // 
            this.线路ID.DataPropertyName = "线路ID";
            this.线路ID.HeaderText = "线路ID";
            this.线路ID.Name = "线路ID";
            this.线路ID.ReadOnly = true;
            this.线路ID.Visible = false;
            // 
            // dgvXianLuWangDianXinXi
            // 
            this.dgvXianLuWangDianXinXi.AllowUserToAddRows = false;
            this.dgvXianLuWangDianXinXi.AllowUserToDeleteRows = false;
            this.dgvXianLuWangDianXinXi.AllowUserToResizeColumns = false;
            this.dgvXianLuWangDianXinXi.AllowUserToResizeRows = false;
            this.dgvXianLuWangDianXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXianLuWangDianXinXi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.网点名称,
            this.相邻网点名称});
            this.dgvXianLuWangDianXinXi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXianLuWangDianXinXi.Location = new System.Drawing.Point(0, 0);
            this.dgvXianLuWangDianXinXi.MultiSelect = false;
            this.dgvXianLuWangDianXinXi.Name = "dgvXianLuWangDianXinXi";
            this.dgvXianLuWangDianXinXi.ReadOnly = true;
            this.dgvXianLuWangDianXinXi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvXianLuWangDianXinXi.RowTemplate.Height = 27;
            this.dgvXianLuWangDianXinXi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXianLuWangDianXinXi.Size = new System.Drawing.Size(525, 553);
            this.dgvXianLuWangDianXinXi.TabIndex = 2;
            this.dgvXianLuWangDianXinXi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvXianLuWangDianXinXi_CellFormatting);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "线路ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "线路ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // 网点名称
            // 
            this.网点名称.DataPropertyName = "网点名称";
            this.网点名称.HeaderText = "网点名称";
            this.网点名称.Name = "网点名称";
            this.网点名称.ReadOnly = true;
            this.网点名称.Width = 200;
            // 
            // 相邻网点名称
            // 
            this.相邻网点名称.DataPropertyName = "相邻网点名称";
            this.相邻网点名称.HeaderText = "相邻网点名称";
            this.相邻网点名称.Name = "相邻网点名称";
            this.相邻网点名称.ReadOnly = true;
            this.相邻网点名称.Width = 200;
            // 
            // FRM_XianLuGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 624);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_XianLuGuanLi";
            this.Text = "FRM_XianLuGuanLi";
            this.Load += new System.EventHandler(this.FRM_XianLuGuanLi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXianLuXinXi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXianLuWangDianXinXi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbXinZeng_Insert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbXiuGai_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbShangChu_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbWangDianGuanLi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChaXun_Select;
        private System.Windows.Forms.TextBox txZhuJiMa;
        private System.Windows.Forms.RadioButton rdbZhuJiMa;
        private System.Windows.Forms.RadioButton rdbQiZhiWangDian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbXianLuMingCheng;
        private System.Windows.Forms.ComboBox cboQiShiWangDian;
        private System.Windows.Forms.ComboBox cboJieShuWangDian;
        private System.Windows.Forms.ToolStripSeparator toolStripButton7;
        private System.Windows.Forms.TextBox txtXianLuMingCheng;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvXianLuXinXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn 线路名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 助记码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 线路ID;
        private System.Windows.Forms.DataGridView dgvXianLuWangDianXinXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网点名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 相邻网点名称;
    }
}