namespace WCF物流管理系统_Client.线路管理
{
    partial class FRM_XianLuGuanLi_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_XianLuGuanLi_Insert));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvZuiZhongXianLu = new System.Windows.Forms.DataGridView();
            this.起始网点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.终止网点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.终止网点ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.起始网点ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtZhuJiMa = new System.Windows.Forms.TextBox();
            this.txtXianLuMingCheng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKeXuanXianLu = new System.Windows.Forms.DataGridView();
            this.路线 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.网点ID集合 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.距离 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShengChengLuXian = new System.Windows.Forms.Button();
            this.cboJieShuWangDian = new System.Windows.Forms.ComboBox();
            this.cboQiShiWangDian = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBaoCunXianLu_Insert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbChongZhi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBaoCun_Insert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFanHui = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZuiZhongXianLu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeXuanXianLu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "新增线路";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvZuiZhongXianLu);
            this.groupBox1.Controls.Add(this.txtZhuJiMa);
            this.groupBox1.Controls.Add(this.txtXianLuMingCheng);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvKeXuanXianLu);
            this.groupBox1.Controls.Add(this.btnShengChengLuXian);
            this.groupBox1.Controls.Add(this.cboJieShuWangDian);
            this.groupBox1.Controls.Add(this.cboQiShiWangDian);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 320);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "线路信息";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 90;
            this.label7.Text = "最终线路：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 89;
            this.label6.Text = "可选线路：";
            // 
            // dgvZuiZhongXianLu
            // 
            this.dgvZuiZhongXianLu.AllowUserToAddRows = false;
            this.dgvZuiZhongXianLu.AllowUserToDeleteRows = false;
            this.dgvZuiZhongXianLu.AllowUserToResizeColumns = false;
            this.dgvZuiZhongXianLu.AllowUserToResizeRows = false;
            this.dgvZuiZhongXianLu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZuiZhongXianLu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.起始网点,
            this.终止网点,
            this.终止网点ID,
            this.起始网点ID});
            this.dgvZuiZhongXianLu.Location = new System.Drawing.Point(293, 67);
            this.dgvZuiZhongXianLu.MultiSelect = false;
            this.dgvZuiZhongXianLu.Name = "dgvZuiZhongXianLu";
            this.dgvZuiZhongXianLu.ReadOnly = true;
            this.dgvZuiZhongXianLu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvZuiZhongXianLu.RowTemplate.Height = 23;
            this.dgvZuiZhongXianLu.Size = new System.Drawing.Size(237, 211);
            this.dgvZuiZhongXianLu.TabIndex = 88;
            // 
            // 起始网点
            // 
            this.起始网点.DataPropertyName = "起始网点";
            this.起始网点.HeaderText = "起始网点";
            this.起始网点.Name = "起始网点";
            this.起始网点.ReadOnly = true;
            // 
            // 终止网点
            // 
            this.终止网点.DataPropertyName = "终止网点";
            this.终止网点.HeaderText = "终止网点";
            this.终止网点.Name = "终止网点";
            this.终止网点.ReadOnly = true;
            // 
            // 终止网点ID
            // 
            this.终止网点ID.DataPropertyName = "终止网点ID";
            this.终止网点ID.HeaderText = "终止网点ID";
            this.终止网点ID.Name = "终止网点ID";
            this.终止网点ID.ReadOnly = true;
            this.终止网点ID.Visible = false;
            // 
            // 起始网点ID
            // 
            this.起始网点ID.DataPropertyName = "起始网点ID";
            this.起始网点ID.HeaderText = "起始网点ID";
            this.起始网点ID.Name = "起始网点ID";
            this.起始网点ID.ReadOnly = true;
            this.起始网点ID.Visible = false;
            // 
            // txtZhuJiMa
            // 
            this.txtZhuJiMa.Location = new System.Drawing.Point(260, 285);
            this.txtZhuJiMa.Name = "txtZhuJiMa";
            this.txtZhuJiMa.Size = new System.Drawing.Size(121, 21);
            this.txtZhuJiMa.TabIndex = 87;
            // 
            // txtXianLuMingCheng
            // 
            this.txtXianLuMingCheng.Location = new System.Drawing.Point(68, 286);
            this.txtXianLuMingCheng.Name = "txtXianLuMingCheng";
            this.txtXianLuMingCheng.Size = new System.Drawing.Size(121, 21);
            this.txtXianLuMingCheng.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 85;
            this.label4.Text = "助记码 ：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 84;
            this.label5.Text = "线路名称：";
            // 
            // dgvKeXuanXianLu
            // 
            this.dgvKeXuanXianLu.AllowUserToAddRows = false;
            this.dgvKeXuanXianLu.AllowUserToDeleteRows = false;
            this.dgvKeXuanXianLu.AllowUserToResizeColumns = false;
            this.dgvKeXuanXianLu.AllowUserToResizeRows = false;
            this.dgvKeXuanXianLu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeXuanXianLu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.路线,
            this.网点ID集合,
            this.距离});
            this.dgvKeXuanXianLu.Location = new System.Drawing.Point(10, 67);
            this.dgvKeXuanXianLu.MultiSelect = false;
            this.dgvKeXuanXianLu.Name = "dgvKeXuanXianLu";
            this.dgvKeXuanXianLu.ReadOnly = true;
            this.dgvKeXuanXianLu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvKeXuanXianLu.RowTemplate.Height = 23;
            this.dgvKeXuanXianLu.Size = new System.Drawing.Size(278, 211);
            this.dgvKeXuanXianLu.TabIndex = 76;
            this.dgvKeXuanXianLu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dgvKeXuanXianLu.SelectionChanged += new System.EventHandler(this.dgvKeXuanXianLu_SelectionChanged);
            // 
            // 路线
            // 
            this.路线.DataPropertyName = "路线";
            this.路线.HeaderText = "路线";
            this.路线.Name = "路线";
            this.路线.ReadOnly = true;
            this.路线.Width = 150;
            // 
            // 网点ID集合
            // 
            this.网点ID集合.DataPropertyName = "网点ID集合";
            this.网点ID集合.HeaderText = "网点ID集合";
            this.网点ID集合.Name = "网点ID集合";
            this.网点ID集合.ReadOnly = true;
            this.网点ID集合.Visible = false;
            // 
            // 距离
            // 
            this.距离.DataPropertyName = "距离";
            this.距离.HeaderText = "距离";
            this.距离.Name = "距离";
            this.距离.ReadOnly = true;
            // 
            // btnShengChengLuXian
            // 
            this.btnShengChengLuXian.Location = new System.Drawing.Point(400, 16);
            this.btnShengChengLuXian.Name = "btnShengChengLuXian";
            this.btnShengChengLuXian.Size = new System.Drawing.Size(75, 30);
            this.btnShengChengLuXian.TabIndex = 75;
            this.btnShengChengLuXian.Text = "生成线路";
            this.btnShengChengLuXian.UseVisualStyleBackColor = true;
            this.btnShengChengLuXian.Click += new System.EventHandler(this.btnShengChengLuXian_Click);
            // 
            // cboJieShuWangDian
            // 
            this.cboJieShuWangDian.FormattingEnabled = true;
            this.cboJieShuWangDian.Location = new System.Drawing.Point(260, 22);
            this.cboJieShuWangDian.Name = "cboJieShuWangDian";
            this.cboJieShuWangDian.Size = new System.Drawing.Size(121, 20);
            this.cboJieShuWangDian.TabIndex = 3;
            this.cboJieShuWangDian.SelectedIndexChanged += new System.EventHandler(this.cboQiShiWangDian_SelectedIndexChanged);
            // 
            // cboQiShiWangDian
            // 
            this.cboQiShiWangDian.FormattingEnabled = true;
            this.cboQiShiWangDian.Location = new System.Drawing.Point(68, 22);
            this.cboQiShiWangDian.Name = "cboQiShiWangDian";
            this.cboQiShiWangDian.Size = new System.Drawing.Size(121, 20);
            this.cboQiShiWangDian.TabIndex = 2;
            this.cboQiShiWangDian.SelectedIndexChanged += new System.EventHandler(this.cboQiShiWangDian_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "目的网点：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "起始网点：";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(83, 379);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 91;
            this.button6.Text = "重置";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(299, 379);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(21, 30);
            this.button11.TabIndex = 90;
            this.button11.Text = ">";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(383, 379);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(21, 30);
            this.button10.TabIndex = 89;
            this.button10.Text = ">";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(407, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 88;
            this.button4.Text = "返回";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 87;
            this.button3.Text = "打印";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBaoCunXianLu_Insert
            // 
            this.btnBaoCunXianLu_Insert.Location = new System.Drawing.Point(245, 379);
            this.btnBaoCunXianLu_Insert.Name = "btnBaoCunXianLu_Insert";
            this.btnBaoCunXianLu_Insert.Size = new System.Drawing.Size(75, 30);
            this.btnBaoCunXianLu_Insert.TabIndex = 86;
            this.btnBaoCunXianLu_Insert.Text = "保存";
            this.btnBaoCunXianLu_Insert.UseVisualStyleBackColor = true;
            this.btnBaoCunXianLu_Insert.Click += new System.EventHandler(this.btnBaoCunXianLu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 85;
            this.button1.Text = "全选";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChongZhi,
            this.toolStripSeparator3,
            this.tsbBaoCun_Insert,
            this.toolStripSeparator1,
            this.tsbFanHui,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(540, 25);
            this.toolStrip1.TabIndex = 94;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsbBaoCun_Insert
            // 
            this.tsbBaoCun_Insert.Image = ((System.Drawing.Image)(resources.GetObject("tsbBaoCun_Insert.Image")));
            this.tsbBaoCun_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBaoCun_Insert.Name = "tsbBaoCun_Insert";
            this.tsbBaoCun_Insert.Size = new System.Drawing.Size(52, 22);
            this.tsbBaoCun_Insert.Text = "保存";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFanHui
            // 
            this.tsbFanHui.Image = ((System.Drawing.Image)(resources.GetObject("tsbFanHui.Image")));
            this.tsbFanHui.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFanHui.Name = "tsbFanHui";
            this.tsbFanHui.Size = new System.Drawing.Size(52, 22);
            this.tsbFanHui.Text = "返回";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // FRM_XianLuGuanLi_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 410);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBaoCunXianLu_Insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_XianLuGuanLi_Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建线路";
            this.Load += new System.EventHandler(this.FRM_XianLuGuanLi_Insert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZuiZhongXianLu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeXuanXianLu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShengChengLuXian;
        private System.Windows.Forms.ComboBox cboJieShuWangDian;
        private System.Windows.Forms.ComboBox cboQiShiWangDian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKeXuanXianLu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBaoCunXianLu_Insert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtZhuJiMa;
        private System.Windows.Forms.TextBox txtXianLuMingCheng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbChongZhi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbBaoCun_Insert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbFanHui;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView dgvZuiZhongXianLu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 路线;
        private System.Windows.Forms.DataGridViewTextBoxColumn 网点ID集合;
        private System.Windows.Forms.DataGridViewTextBoxColumn 距离;
        private System.Windows.Forms.DataGridViewTextBoxColumn 起始网点;
        private System.Windows.Forms.DataGridViewTextBoxColumn 终止网点;
        private System.Windows.Forms.DataGridViewTextBoxColumn 终止网点ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 起始网点ID;

    }
}