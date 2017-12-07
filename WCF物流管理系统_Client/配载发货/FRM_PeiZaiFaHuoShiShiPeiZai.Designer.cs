namespace WCF物流管理系统_Client.配载发货
{
    partial class FRM_PeiZaiFaHuoShiShiPeiZai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PeiZaiFaHuoShiShiPeiZai));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbChongZhi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQueDing = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFanHui = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chkDinDanZhuangTai = new System.Windows.Forms.CheckBox();
            this.chkJieShuShiJian = new System.Windows.Forms.CheckBox();
            this.chkQiShiShiJian = new System.Windows.Forms.CheckBox();
            this.chkMuDiWangDian = new System.Windows.Forms.CheckBox();
            this.chkShiFaWangDian = new System.Windows.Forms.CheckBox();
            this.chkDingDanBianHao = new System.Windows.Forms.CheckBox();
            this.btnChaXun = new System.Windows.Forms.Button();
            this.dtpQiShiShiJian = new System.Windows.Forms.DateTimePicker();
            this.cboDingDanZhuangTai = new System.Windows.Forms.ComboBox();
            this.dtpJieZhiShiJian = new System.Windows.Forms.DateTimePicker();
            this.txtDingDanBianHao = new System.Windows.Forms.TextBox();
            this.cboMuDiWangDian = new System.Windows.Forms.ComboBox();
            this.cboShiFaWangDian = new System.Windows.Forms.ComboBox();
            this.dgvFenBao = new System.Windows.Forms.DataGridView();
            this.分包ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货运单明细ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFenBao)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChongZhi,
            this.toolStripSeparator3,
            this.tsbQueDing,
            this.toolStripSeparator1,
            this.tsbFanHui,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(539, 25);
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbChongZhi
            // 
            this.tsbChongZhi.Image = ((System.Drawing.Image)(resources.GetObject("tsbChongZhi.Image")));
            this.tsbChongZhi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChongZhi.Name = "tsbChongZhi";
            this.tsbChongZhi.Size = new System.Drawing.Size(52, 22);
            this.tsbChongZhi.Text = "重置";
            this.tsbChongZhi.Click += new System.EventHandler(this.tsbChongZhi_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbQueDing
            // 
            this.tsbQueDing.Image = ((System.Drawing.Image)(resources.GetObject("tsbQueDing.Image")));
            this.tsbQueDing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQueDing.Name = "tsbQueDing";
            this.tsbQueDing.Size = new System.Drawing.Size(52, 22);
            this.tsbQueDing.Text = "确定";
            this.tsbQueDing.Click += new System.EventHandler(this.tsbQueDing_Click);
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
            this.tsbFanHui.Click += new System.EventHandler(this.tsbFanHui_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chkDinDanZhuangTai);
            this.splitContainer2.Panel1.Controls.Add(this.chkJieShuShiJian);
            this.splitContainer2.Panel1.Controls.Add(this.chkQiShiShiJian);
            this.splitContainer2.Panel1.Controls.Add(this.chkMuDiWangDian);
            this.splitContainer2.Panel1.Controls.Add(this.chkShiFaWangDian);
            this.splitContainer2.Panel1.Controls.Add(this.chkDingDanBianHao);
            this.splitContainer2.Panel1.Controls.Add(this.btnChaXun);
            this.splitContainer2.Panel1.Controls.Add(this.dtpQiShiShiJian);
            this.splitContainer2.Panel1.Controls.Add(this.cboDingDanZhuangTai);
            this.splitContainer2.Panel1.Controls.Add(this.dtpJieZhiShiJian);
            this.splitContainer2.Panel1.Controls.Add(this.txtDingDanBianHao);
            this.splitContainer2.Panel1.Controls.Add(this.cboMuDiWangDian);
            this.splitContainer2.Panel1.Controls.Add(this.cboShiFaWangDian);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvFenBao);
            this.splitContainer2.Size = new System.Drawing.Size(539, 428);
            this.splitContainer2.SplitterDistance = 116;
            this.splitContainer2.TabIndex = 77;
            // 
            // chkDinDanZhuangTai
            // 
            this.chkDinDanZhuangTai.AutoSize = true;
            this.chkDinDanZhuangTai.Location = new System.Drawing.Point(279, 67);
            this.chkDinDanZhuangTai.Name = "chkDinDanZhuangTai";
            this.chkDinDanZhuangTai.Size = new System.Drawing.Size(72, 16);
            this.chkDinDanZhuangTai.TabIndex = 94;
            this.chkDinDanZhuangTai.Text = "揽收状态";
            this.chkDinDanZhuangTai.UseVisualStyleBackColor = true;
            // 
            // chkJieShuShiJian
            // 
            this.chkJieShuShiJian.AutoSize = true;
            this.chkJieShuShiJian.Location = new System.Drawing.Point(279, 40);
            this.chkJieShuShiJian.Name = "chkJieShuShiJian";
            this.chkJieShuShiJian.Size = new System.Drawing.Size(72, 16);
            this.chkJieShuShiJian.TabIndex = 93;
            this.chkJieShuShiJian.Text = "结束时间";
            this.chkJieShuShiJian.UseVisualStyleBackColor = true;
            // 
            // chkQiShiShiJian
            // 
            this.chkQiShiShiJian.AutoSize = true;
            this.chkQiShiShiJian.Location = new System.Drawing.Point(279, 16);
            this.chkQiShiShiJian.Name = "chkQiShiShiJian";
            this.chkQiShiShiJian.Size = new System.Drawing.Size(72, 16);
            this.chkQiShiShiJian.TabIndex = 92;
            this.chkQiShiShiJian.Text = "起始时间";
            this.chkQiShiShiJian.UseVisualStyleBackColor = true;
            // 
            // chkMuDiWangDian
            // 
            this.chkMuDiWangDian.AutoSize = true;
            this.chkMuDiWangDian.Location = new System.Drawing.Point(8, 67);
            this.chkMuDiWangDian.Name = "chkMuDiWangDian";
            this.chkMuDiWangDian.Size = new System.Drawing.Size(72, 16);
            this.chkMuDiWangDian.TabIndex = 91;
            this.chkMuDiWangDian.Text = "目的网点";
            this.chkMuDiWangDian.UseVisualStyleBackColor = true;
            // 
            // chkShiFaWangDian
            // 
            this.chkShiFaWangDian.AutoSize = true;
            this.chkShiFaWangDian.Location = new System.Drawing.Point(8, 40);
            this.chkShiFaWangDian.Name = "chkShiFaWangDian";
            this.chkShiFaWangDian.Size = new System.Drawing.Size(72, 16);
            this.chkShiFaWangDian.TabIndex = 90;
            this.chkShiFaWangDian.Text = "始发网点";
            this.chkShiFaWangDian.UseVisualStyleBackColor = true;
            // 
            // chkDingDanBianHao
            // 
            this.chkDingDanBianHao.AutoSize = true;
            this.chkDingDanBianHao.Location = new System.Drawing.Point(8, 16);
            this.chkDingDanBianHao.Name = "chkDingDanBianHao";
            this.chkDingDanBianHao.Size = new System.Drawing.Size(72, 16);
            this.chkDingDanBianHao.TabIndex = 89;
            this.chkDingDanBianHao.Text = "订单编号";
            this.chkDingDanBianHao.UseVisualStyleBackColor = true;
            // 
            // btnChaXun
            // 
            this.btnChaXun.Location = new System.Drawing.Point(3, 91);
            this.btnChaXun.Name = "btnChaXun";
            this.btnChaXun.Size = new System.Drawing.Size(530, 26);
            this.btnChaXun.TabIndex = 88;
            this.btnChaXun.Text = "查询";
            this.btnChaXun.UseVisualStyleBackColor = true;
            this.btnChaXun.Click += new System.EventHandler(this.btnChaXun_Click);
            // 
            // dtpQiShiShiJian
            // 
            this.dtpQiShiShiJian.Location = new System.Drawing.Point(357, 13);
            this.dtpQiShiShiJian.Name = "dtpQiShiShiJian";
            this.dtpQiShiShiJian.Size = new System.Drawing.Size(176, 21);
            this.dtpQiShiShiJian.TabIndex = 83;
            // 
            // cboDingDanZhuangTai
            // 
            this.cboDingDanZhuangTai.FormattingEnabled = true;
            this.cboDingDanZhuangTai.Location = new System.Drawing.Point(357, 65);
            this.cboDingDanZhuangTai.Name = "cboDingDanZhuangTai";
            this.cboDingDanZhuangTai.Size = new System.Drawing.Size(176, 20);
            this.cboDingDanZhuangTai.TabIndex = 86;
            // 
            // dtpJieZhiShiJian
            // 
            this.dtpJieZhiShiJian.Location = new System.Drawing.Point(357, 38);
            this.dtpJieZhiShiJian.Name = "dtpJieZhiShiJian";
            this.dtpJieZhiShiJian.Size = new System.Drawing.Size(176, 21);
            this.dtpJieZhiShiJian.TabIndex = 84;
            // 
            // txtDingDanBianHao
            // 
            this.txtDingDanBianHao.Location = new System.Drawing.Point(80, 13);
            this.txtDingDanBianHao.Name = "txtDingDanBianHao";
            this.txtDingDanBianHao.Size = new System.Drawing.Size(193, 21);
            this.txtDingDanBianHao.TabIndex = 77;
            // 
            // cboMuDiWangDian
            // 
            this.cboMuDiWangDian.FormattingEnabled = true;
            this.cboMuDiWangDian.Location = new System.Drawing.Point(80, 65);
            this.cboMuDiWangDian.Name = "cboMuDiWangDian";
            this.cboMuDiWangDian.Size = new System.Drawing.Size(193, 20);
            this.cboMuDiWangDian.TabIndex = 79;
            // 
            // cboShiFaWangDian
            // 
            this.cboShiFaWangDian.FormattingEnabled = true;
            this.cboShiFaWangDian.Location = new System.Drawing.Point(80, 40);
            this.cboShiFaWangDian.Name = "cboShiFaWangDian";
            this.cboShiFaWangDian.Size = new System.Drawing.Size(193, 20);
            this.cboShiFaWangDian.TabIndex = 76;
            // 
            // dgvFenBao
            // 
            this.dgvFenBao.AllowUserToAddRows = false;
            this.dgvFenBao.AllowUserToDeleteRows = false;
            this.dgvFenBao.AllowUserToResizeColumns = false;
            this.dgvFenBao.AllowUserToResizeRows = false;
            this.dgvFenBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFenBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.分包ID,
            this.货运单明细ID,
            this.选择});
            this.dgvFenBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFenBao.Location = new System.Drawing.Point(0, 0);
            this.dgvFenBao.MultiSelect = false;
            this.dgvFenBao.Name = "dgvFenBao";
            this.dgvFenBao.ReadOnly = true;
            this.dgvFenBao.RowHeadersVisible = false;
            this.dgvFenBao.RowTemplate.Height = 23;
            this.dgvFenBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFenBao.Size = new System.Drawing.Size(539, 308);
            this.dgvFenBao.TabIndex = 0;
            // 
            // 分包ID
            // 
            this.分包ID.DataPropertyName = "分包ID";
            this.分包ID.HeaderText = "分包ID";
            this.分包ID.Name = "分包ID";
            this.分包ID.ReadOnly = true;
            this.分包ID.Visible = false;
            // 
            // 货运单明细ID
            // 
            this.货运单明细ID.DataPropertyName = "货运单明细ID";
            this.货运单明细ID.HeaderText = "货运单明细ID";
            this.货运单明细ID.Name = "货运单明细ID";
            this.货运单明细ID.ReadOnly = true;
            this.货运单明细ID.Visible = false;
            // 
            // 选择
            // 
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.ReadOnly = true;
            // 
            // FRM_PeiZaiFaHuoShiShiPeiZai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 453);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_PeiZaiFaHuoShiShiPeiZai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实时配载";
            this.Load += new System.EventHandler(this.FRM_PeiZaiFaHuoShiShiPeiZai_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFenBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbChongZhi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbQueDing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbFanHui;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox chkDinDanZhuangTai;
        private System.Windows.Forms.CheckBox chkJieShuShiJian;
        private System.Windows.Forms.CheckBox chkQiShiShiJian;
        private System.Windows.Forms.CheckBox chkMuDiWangDian;
        private System.Windows.Forms.CheckBox chkShiFaWangDian;
        private System.Windows.Forms.CheckBox chkDingDanBianHao;
        private System.Windows.Forms.Button btnChaXun;
        private System.Windows.Forms.DateTimePicker dtpQiShiShiJian;
        private System.Windows.Forms.ComboBox cboDingDanZhuangTai;
        private System.Windows.Forms.DateTimePicker dtpJieZhiShiJian;
        private System.Windows.Forms.TextBox txtDingDanBianHao;
        private System.Windows.Forms.ComboBox cboMuDiWangDian;
        private System.Windows.Forms.ComboBox cboShiFaWangDian;
        private System.Windows.Forms.DataGridView dgvFenBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分包ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货运单明细ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;

    }
}