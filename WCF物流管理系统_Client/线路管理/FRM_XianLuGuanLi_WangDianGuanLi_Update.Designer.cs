namespace WCF物流管理系统_Client.线路管理
{
    partial class FRM_XianLuGuanLi_WangDianGuanLi_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_XianLuGuanLi_WangDianGuanLi_Update));
            this.btnChongZhi = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.button10 = new System.Windows.Forms.Button();
            this.tsbBaoCun_Update = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTingYongWangDian = new System.Windows.Forms.Button();
            this.btnQiYongWangDian = new System.Windows.Forms.Button();
            this.txtWangDianMingCheng = new System.Windows.Forms.TextBox();
            this.dgvXiangLinWangDian = new System.Windows.Forms.DataGridView();
            this.选中否 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.网点名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.距离 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.网点ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tsbFanHui = new System.Windows.Forms.ToolStripButton();
            this.tsbChongZhi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.button11 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFanHui = new System.Windows.Forms.Button();
            this.btnDaYin = new System.Windows.Forms.Button();
            this.btnBaoCun_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXiangLinWangDian)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChongZhi
            // 
            this.btnChongZhi.Location = new System.Drawing.Point(163, 380);
            this.btnChongZhi.Name = "btnChongZhi";
            this.btnChongZhi.Size = new System.Drawing.Size(75, 30);
            this.btnChongZhi.TabIndex = 110;
            this.btnChongZhi.Text = "重置";
            this.btnChongZhi.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(383, 380);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(21, 30);
            this.button10.TabIndex = 108;
            this.button10.Text = ">";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // tsbBaoCun_Update
            // 
            this.tsbBaoCun_Update.Image = ((System.Drawing.Image)(resources.GetObject("tsbBaoCun_Update.Image")));
            this.tsbBaoCun_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBaoCun_Update.Name = "tsbBaoCun_Update";
            this.tsbBaoCun_Update.Size = new System.Drawing.Size(52, 22);
            this.tsbBaoCun_Update.Text = "保存";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTingYongWangDian);
            this.groupBox1.Controls.Add(this.btnQiYongWangDian);
            this.groupBox1.Controls.Add(this.txtWangDianMingCheng);
            this.groupBox1.Controls.Add(this.dgvXiangLinWangDian);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 320);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网点信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 12);
            this.label3.TabIndex = 104;
            this.label3.Text = "可到达网点列表（以自己为出发点）：";
            // 
            // btnTingYongWangDian
            // 
            this.btnTingYongWangDian.Location = new System.Drawing.Point(401, 15);
            this.btnTingYongWangDian.Name = "btnTingYongWangDian";
            this.btnTingYongWangDian.Size = new System.Drawing.Size(75, 48);
            this.btnTingYongWangDian.TabIndex = 103;
            this.btnTingYongWangDian.Text = "停用";
            this.btnTingYongWangDian.UseVisualStyleBackColor = true;
            this.btnTingYongWangDian.Click += new System.EventHandler(this.btnTingYongWangDian_Click);
            // 
            // btnQiYongWangDian
            // 
            this.btnQiYongWangDian.Enabled = false;
            this.btnQiYongWangDian.Location = new System.Drawing.Point(320, 15);
            this.btnQiYongWangDian.Name = "btnQiYongWangDian";
            this.btnQiYongWangDian.Size = new System.Drawing.Size(75, 48);
            this.btnQiYongWangDian.TabIndex = 102;
            this.btnQiYongWangDian.Text = "启用";
            this.btnQiYongWangDian.UseVisualStyleBackColor = true;
            this.btnQiYongWangDian.Click += new System.EventHandler(this.btnQiYongWangDian_Click);
            // 
            // txtWangDianMingCheng
            // 
            this.txtWangDianMingCheng.Location = new System.Drawing.Point(83, 21);
            this.txtWangDianMingCheng.Name = "txtWangDianMingCheng";
            this.txtWangDianMingCheng.Size = new System.Drawing.Size(210, 21);
            this.txtWangDianMingCheng.TabIndex = 77;
            // 
            // dgvXiangLinWangDian
            // 
            this.dgvXiangLinWangDian.AllowUserToAddRows = false;
            this.dgvXiangLinWangDian.AllowUserToDeleteRows = false;
            this.dgvXiangLinWangDian.AllowUserToResizeColumns = false;
            this.dgvXiangLinWangDian.AllowUserToResizeRows = false;
            this.dgvXiangLinWangDian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXiangLinWangDian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选中否,
            this.网点名称,
            this.距离,
            this.网点ID});
            this.dgvXiangLinWangDian.Location = new System.Drawing.Point(10, 69);
            this.dgvXiangLinWangDian.MultiSelect = false;
            this.dgvXiangLinWangDian.Name = "dgvXiangLinWangDian";
            this.dgvXiangLinWangDian.ReadOnly = true;
            this.dgvXiangLinWangDian.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvXiangLinWangDian.RowTemplate.Height = 23;
            this.dgvXiangLinWangDian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXiangLinWangDian.Size = new System.Drawing.Size(466, 241);
            this.dgvXiangLinWangDian.TabIndex = 76;
            // 
            // 选中否
            // 
            this.选中否.DataPropertyName = "选中否";
            this.选中否.HeaderText = "选中否";
            this.选中否.Name = "选中否";
            this.选中否.ReadOnly = true;
            this.选中否.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.选中否.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 网点名称
            // 
            this.网点名称.DataPropertyName = "网点名称";
            this.网点名称.HeaderText = "网点名称";
            this.网点名称.Name = "网点名称";
            this.网点名称.ReadOnly = true;
            this.网点名称.Width = 150;
            // 
            // 距离
            // 
            this.距离.DataPropertyName = "距离";
            this.距离.HeaderText = "距离";
            this.距离.Name = "距离";
            this.距离.ReadOnly = true;
            this.距离.Width = 150;
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
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "新网点名称：";
            // 
            // tsbFanHui
            // 
            this.tsbFanHui.Image = ((System.Drawing.Image)(resources.GetObject("tsbFanHui.Image")));
            this.tsbFanHui.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFanHui.Name = "tsbFanHui";
            this.tsbFanHui.Size = new System.Drawing.Size(52, 22);
            this.tsbFanHui.Text = "返回";
            // 
            // tsbChongZhi
            // 
            this.tsbChongZhi.Image = ((System.Drawing.Image)(resources.GetObject("tsbChongZhi.Image")));
            this.tsbChongZhi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChongZhi.Name = "tsbChongZhi";
            this.tsbChongZhi.Size = new System.Drawing.Size(52, 22);
            this.tsbChongZhi.Text = "重置";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(299, 380);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(21, 30);
            this.button11.TabIndex = 109;
            this.button11.Text = ">";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChongZhi,
            this.toolStripSeparator3,
            this.tsbBaoCun_Update,
            this.toolStripSeparator2,
            this.tsbFanHui,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(488, 25);
            this.toolStrip1.TabIndex = 103;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFanHui
            // 
            this.btnFanHui.Location = new System.Drawing.Point(407, 380);
            this.btnFanHui.Name = "btnFanHui";
            this.btnFanHui.Size = new System.Drawing.Size(75, 30);
            this.btnFanHui.TabIndex = 107;
            this.btnFanHui.Text = "返回";
            this.btnFanHui.UseVisualStyleBackColor = true;
            // 
            // btnDaYin
            // 
            this.btnDaYin.Location = new System.Drawing.Point(326, 380);
            this.btnDaYin.Name = "btnDaYin";
            this.btnDaYin.Size = new System.Drawing.Size(75, 30);
            this.btnDaYin.TabIndex = 106;
            this.btnDaYin.Text = "打印";
            this.btnDaYin.UseVisualStyleBackColor = true;
            // 
            // btnBaoCun_Update
            // 
            this.btnBaoCun_Update.Location = new System.Drawing.Point(245, 380);
            this.btnBaoCun_Update.Name = "btnBaoCun_Update";
            this.btnBaoCun_Update.Size = new System.Drawing.Size(75, 30);
            this.btnBaoCun_Update.TabIndex = 105;
            this.btnBaoCun_Update.Text = "保存";
            this.btnBaoCun_Update.UseVisualStyleBackColor = true;
            this.btnBaoCun_Update.Click += new System.EventHandler(this.btnBaoCun_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(162, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 102;
            this.label1.Text = "修改网点";
            // 
            // FRM_XianLuGuanLi_WangDianGuanLi_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 410);
            this.Controls.Add(this.btnChongZhi);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnFanHui);
            this.Controls.Add(this.btnDaYin);
            this.Controls.Add(this.btnBaoCun_Update);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_XianLuGuanLi_WangDianGuanLi_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改网点";
            this.Load += new System.EventHandler(this.FRM_XianLuGuanLi_WangDianGuanLi_Update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXiangLinWangDian)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChongZhi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ToolStripButton tsbBaoCun_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTingYongWangDian;
        private System.Windows.Forms.Button btnQiYongWangDian;
        private System.Windows.Forms.TextBox txtWangDianMingCheng;
        private System.Windows.Forms.DataGridView dgvXiangLinWangDian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsbFanHui;
        private System.Windows.Forms.ToolStripButton tsbChongZhi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnFanHui;
        private System.Windows.Forms.Button btnDaYin;
        private System.Windows.Forms.Button btnBaoCun_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选中否;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网点名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 距离;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网点ID;
        private System.Windows.Forms.Label label3;


    }
}