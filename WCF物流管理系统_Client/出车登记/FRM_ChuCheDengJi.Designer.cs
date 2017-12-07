namespace WCF物流管理系统_Client.出车登记
{
    partial class FRM_ChuCheDengJi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ChuCheDengJi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboKaiShi = new System.Windows.Forms.ComboBox();
            this.cboJieShu = new System.Windows.Forms.ComboBox();
            this.btnChaXun_Select = new System.Windows.Forms.Button();
            this.txtSiJiXingMing = new System.Windows.Forms.TextBox();
            this.cboZhuangTai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSiJiXingMing = new System.Windows.Forms.CheckBox();
            this.chkZhuangTai = new System.Windows.Forms.CheckBox();
            this.chkQiZhiWangDian = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnlZhuJieMian = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCheLiangPeiZaiXinXi = new System.Windows.Forms.DataGridView();
            this.flpCheLiang = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbGuanBi = new System.Windows.Forms.ToolStripButton();
            this.tsbChuChe = new System.Windows.Forms.ToolStripButton();
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
            this.pnlZhuJieMian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheLiangPeiZaiXinXi)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuanBi,
            this.tsbChuChe,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(969, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.splitContainer1.Size = new System.Drawing.Size(969, 561);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboKaiShi);
            this.panel1.Controls.Add(this.cboJieShu);
            this.panel1.Controls.Add(this.btnChaXun_Select);
            this.panel1.Controls.Add(this.txtSiJiXingMing);
            this.panel1.Controls.Add(this.cboZhuangTai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkSiJiXingMing);
            this.panel1.Controls.Add(this.chkZhuangTai);
            this.panel1.Controls.Add(this.chkQiZhiWangDian);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 38);
            this.panel1.TabIndex = 1;
            // 
            // cboKaiShi
            // 
            this.cboKaiShi.FormattingEnabled = true;
            this.cboKaiShi.Location = new System.Drawing.Point(76, 6);
            this.cboKaiShi.Name = "cboKaiShi";
            this.cboKaiShi.Size = new System.Drawing.Size(132, 20);
            this.cboKaiShi.TabIndex = 34;
            // 
            // cboJieShu
            // 
            this.cboJieShu.FormattingEnabled = true;
            this.cboJieShu.Location = new System.Drawing.Point(237, 6);
            this.cboJieShu.Name = "cboJieShu";
            this.cboJieShu.Size = new System.Drawing.Size(141, 20);
            this.cboJieShu.TabIndex = 33;
            // 
            // btnChaXun_Select
            // 
            this.btnChaXun_Select.Location = new System.Drawing.Point(859, 2);
            this.btnChaXun_Select.Name = "btnChaXun_Select";
            this.btnChaXun_Select.Size = new System.Drawing.Size(75, 23);
            this.btnChaXun_Select.TabIndex = 29;
            this.btnChaXun_Select.Text = "查询";
            this.btnChaXun_Select.UseVisualStyleBackColor = true;
            this.btnChaXun_Select.Click += new System.EventHandler(this.btnChaXun_Select_Click);
            // 
            // txtSiJiXingMing
            // 
            this.txtSiJiXingMing.Location = new System.Drawing.Point(683, 5);
            this.txtSiJiXingMing.Name = "txtSiJiXingMing";
            this.txtSiJiXingMing.Size = new System.Drawing.Size(163, 21);
            this.txtSiJiXingMing.TabIndex = 28;
            // 
            // cboZhuangTai
            // 
            this.cboZhuangTai.FormattingEnabled = true;
            this.cboZhuangTai.Location = new System.Drawing.Point(435, 6);
            this.cboZhuangTai.Name = "cboZhuangTai";
            this.cboZhuangTai.Size = new System.Drawing.Size(157, 20);
            this.cboZhuangTai.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "至";
            // 
            // chkSiJiXingMing
            // 
            this.chkSiJiXingMing.AutoSize = true;
            this.chkSiJiXingMing.Checked = true;
            this.chkSiJiXingMing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSiJiXingMing.Location = new System.Drawing.Point(602, 7);
            this.chkSiJiXingMing.Margin = new System.Windows.Forms.Padding(2);
            this.chkSiJiXingMing.Name = "chkSiJiXingMing";
            this.chkSiJiXingMing.Size = new System.Drawing.Size(84, 16);
            this.chkSiJiXingMing.TabIndex = 2;
            this.chkSiJiXingMing.Text = "司机姓名：";
            this.chkSiJiXingMing.UseVisualStyleBackColor = true;
            // 
            // chkZhuangTai
            // 
            this.chkZhuangTai.AutoSize = true;
            this.chkZhuangTai.Location = new System.Drawing.Point(381, 7);
            this.chkZhuangTai.Margin = new System.Windows.Forms.Padding(2);
            this.chkZhuangTai.Name = "chkZhuangTai";
            this.chkZhuangTai.Size = new System.Drawing.Size(60, 16);
            this.chkZhuangTai.TabIndex = 1;
            this.chkZhuangTai.Text = "状态：";
            this.chkZhuangTai.UseVisualStyleBackColor = true;
            // 
            // chkQiZhiWangDian
            // 
            this.chkQiZhiWangDian.AutoSize = true;
            this.chkQiZhiWangDian.Location = new System.Drawing.Point(6, 7);
            this.chkQiZhiWangDian.Margin = new System.Windows.Forms.Padding(2);
            this.chkQiZhiWangDian.Name = "chkQiZhiWangDian";
            this.chkQiZhiWangDian.Size = new System.Drawing.Size(84, 16);
            this.chkQiZhiWangDian.TabIndex = 0;
            this.chkQiZhiWangDian.Text = "起止网点：";
            this.chkQiZhiWangDian.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pnlZhuJieMian);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(969, 519);
            this.splitContainer2.SplitterDistance = 325;
            this.splitContainer2.TabIndex = 0;
            // 
            // pnlZhuJieMian
            // 
            this.pnlZhuJieMian.Controls.Add(this.flpCheLiang);
            this.pnlZhuJieMian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlZhuJieMian.Location = new System.Drawing.Point(0, 0);
            this.pnlZhuJieMian.Name = "pnlZhuJieMian";
            this.pnlZhuJieMian.Size = new System.Drawing.Size(969, 325);
            this.pnlZhuJieMian.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvCheLiangPeiZaiXinXi);
            this.splitContainer3.Size = new System.Drawing.Size(969, 190);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 68;
            this.label5.Text = "车辆配载信息：";
            // 
            // dgvCheLiangPeiZaiXinXi
            // 
            this.dgvCheLiangPeiZaiXinXi.AllowUserToAddRows = false;
            this.dgvCheLiangPeiZaiXinXi.AllowUserToDeleteRows = false;
            this.dgvCheLiangPeiZaiXinXi.AllowUserToResizeColumns = false;
            this.dgvCheLiangPeiZaiXinXi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheLiangPeiZaiXinXi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheLiangPeiZaiXinXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheLiangPeiZaiXinXi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheLiangPeiZaiXinXi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheLiangPeiZaiXinXi.Location = new System.Drawing.Point(0, 0);
            this.dgvCheLiangPeiZaiXinXi.MultiSelect = false;
            this.dgvCheLiangPeiZaiXinXi.Name = "dgvCheLiangPeiZaiXinXi";
            this.dgvCheLiangPeiZaiXinXi.ReadOnly = true;
            this.dgvCheLiangPeiZaiXinXi.RowTemplate.Height = 27;
            this.dgvCheLiangPeiZaiXinXi.Size = new System.Drawing.Size(969, 161);
            this.dgvCheLiangPeiZaiXinXi.TabIndex = 0;
            // 
            // flpCheLiang
            // 
            this.flpCheLiang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCheLiang.Location = new System.Drawing.Point(0, 0);
            this.flpCheLiang.Name = "flpCheLiang";
            this.flpCheLiang.Size = new System.Drawing.Size(969, 325);
            this.flpCheLiang.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tsbGuanBi
            // 
            this.tsbGuanBi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGuanBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbGuanBi.ForeColor = System.Drawing.Color.Red;
            this.tsbGuanBi.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuanBi.Image")));
            this.tsbGuanBi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuanBi.Name = "tsbGuanBi";
            this.tsbGuanBi.Size = new System.Drawing.Size(53, 22);
            this.tsbGuanBi.Text = "关闭";
            this.tsbGuanBi.Click += new System.EventHandler(this.tsbGuanBi_Click);
            // 
            // tsbChuChe
            // 
            this.tsbChuChe.Image = ((System.Drawing.Image)(resources.GetObject("tsbChuChe.Image")));
            this.tsbChuChe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChuChe.Name = "tsbChuChe";
            this.tsbChuChe.Size = new System.Drawing.Size(52, 22);
            this.tsbChuChe.Text = "出车";
            this.tsbChuChe.Click += new System.EventHandler(this.tsbChuChe_Click);
            // 
            // FRM_ChuCheDengJi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 586);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ChuCheDengJi";
            this.Text = "FRM_ChuCheDengJi_";
            this.Load += new System.EventHandler(this.FRM_ChuCheDengJi_Load);
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
            this.pnlZhuJieMian.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheLiangPeiZaiXinXi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuanBi;
        private System.Windows.Forms.ToolStripButton tsbChuChe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvCheLiangPeiZaiXinXi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlZhuJieMian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSiJiXingMing;
        private System.Windows.Forms.ComboBox cboKaiShi;
        private System.Windows.Forms.CheckBox chkZhuangTai;
        private System.Windows.Forms.ComboBox cboJieShu;
        private System.Windows.Forms.CheckBox chkQiZhiWangDian;
        private System.Windows.Forms.Button btnChaXun_Select;
        private System.Windows.Forms.TextBox txtSiJiXingMing;
        private System.Windows.Forms.ComboBox cboZhuangTai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpCheLiang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}