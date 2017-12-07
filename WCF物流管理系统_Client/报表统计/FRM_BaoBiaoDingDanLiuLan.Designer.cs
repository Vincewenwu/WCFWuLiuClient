namespace WCF物流管理系统_Client.报表统计
{
    partial class FRM_BaoBiaoDingDanLiuLan
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
            this.dtpKaiShi = new System.Windows.Forms.DateTimePicker();
            this.dtpJieShu = new System.Windows.Forms.DateTimePicker();
            this.btnChaXun_Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDingDan = new System.Windows.Forms.DataGridView();
            this.货运单ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单据编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接单时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.要求送达时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.提单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄件地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收货地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.运费总价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收货方 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结算方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.制单人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修单人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄件网点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收货网店 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMingXi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDaYin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDingDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMingXi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpKaiShi
            // 
            this.dtpKaiShi.Location = new System.Drawing.Point(84, 13);
            this.dtpKaiShi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpKaiShi.Name = "dtpKaiShi";
            this.dtpKaiShi.Size = new System.Drawing.Size(137, 25);
            this.dtpKaiShi.TabIndex = 13;
            // 
            // dtpJieShu
            // 
            this.dtpJieShu.Location = new System.Drawing.Point(257, 13);
            this.dtpJieShu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpJieShu.Name = "dtpJieShu";
            this.dtpJieShu.Size = new System.Drawing.Size(137, 25);
            this.dtpJieShu.TabIndex = 14;
            // 
            // btnChaXun_Select
            // 
            this.btnChaXun_Select.Location = new System.Drawing.Point(402, 13);
            this.btnChaXun_Select.Margin = new System.Windows.Forms.Padding(4);
            this.btnChaXun_Select.Name = "btnChaXun_Select";
            this.btnChaXun_Select.Size = new System.Drawing.Size(100, 29);
            this.btnChaXun_Select.TabIndex = 30;
            this.btnChaXun_Select.Text = "查询";
            this.btnChaXun_Select.UseVisualStyleBackColor = true;
            this.btnChaXun_Select.Click += new System.EventHandler(this.btnChaXun_Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "至";
            // 
            // dgvDingDan
            // 
            this.dgvDingDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDingDan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.货运单ID,
            this.单据编号,
            this.接单时间,
            this.要求送达时间,
            this.提单号,
            this.寄件地址,
            this.收货地址,
            this.运费总价,
            this.备注,
            this.收货方,
            this.结算方式,
            this.制单人,
            this.修单人,
            this.寄件网点,
            this.收货网店});
            this.dgvDingDan.Location = new System.Drawing.Point(25, 80);
            this.dgvDingDan.Name = "dgvDingDan";
            this.dgvDingDan.RowTemplate.Height = 27;
            this.dgvDingDan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDingDan.Size = new System.Drawing.Size(890, 236);
            this.dgvDingDan.TabIndex = 33;
            this.dgvDingDan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDingDan_CellClick);
            // 
            // 货运单ID
            // 
            this.货运单ID.DataPropertyName = "货运单ID";
            this.货运单ID.HeaderText = "货运单ID";
            this.货运单ID.Name = "货运单ID";
            this.货运单ID.Visible = false;
            // 
            // 单据编号
            // 
            this.单据编号.DataPropertyName = "单据编号";
            this.单据编号.HeaderText = "单据编号";
            this.单据编号.Name = "单据编号";
            this.单据编号.Width = 130;
            // 
            // 接单时间
            // 
            this.接单时间.DataPropertyName = "接单时间";
            this.接单时间.HeaderText = "接单时间";
            this.接单时间.Name = "接单时间";
            this.接单时间.Width = 130;
            // 
            // 要求送达时间
            // 
            this.要求送达时间.DataPropertyName = "要求送达时间";
            this.要求送达时间.HeaderText = "要求送达时间";
            this.要求送达时间.Name = "要求送达时间";
            this.要求送达时间.Width = 130;
            // 
            // 提单号
            // 
            this.提单号.DataPropertyName = "提单号";
            this.提单号.HeaderText = "提单号";
            this.提单号.Name = "提单号";
            // 
            // 寄件地址
            // 
            this.寄件地址.DataPropertyName = "寄件地址";
            this.寄件地址.HeaderText = "寄件地址";
            this.寄件地址.Name = "寄件地址";
            this.寄件地址.Width = 200;
            // 
            // 收货地址
            // 
            this.收货地址.DataPropertyName = "收货地址";
            this.收货地址.HeaderText = "收货地址";
            this.收货地址.Name = "收货地址";
            this.收货地址.Width = 200;
            // 
            // 运费总价
            // 
            this.运费总价.DataPropertyName = "运费总价";
            this.运费总价.HeaderText = "运费总价";
            this.运费总价.Name = "运费总价";
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "备注";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // 收货方
            // 
            this.收货方.DataPropertyName = "收货方";
            this.收货方.HeaderText = "收货方";
            this.收货方.Name = "收货方";
            // 
            // 结算方式
            // 
            this.结算方式.DataPropertyName = "结算方式";
            this.结算方式.HeaderText = "结算方式";
            this.结算方式.Name = "结算方式";
            // 
            // 制单人
            // 
            this.制单人.DataPropertyName = "制单人";
            this.制单人.HeaderText = "制单人";
            this.制单人.Name = "制单人";
            // 
            // 修单人
            // 
            this.修单人.DataPropertyName = "修单人";
            this.修单人.HeaderText = "修单人";
            this.修单人.Name = "修单人";
            // 
            // 寄件网点
            // 
            this.寄件网点.DataPropertyName = "寄件网点";
            this.寄件网点.HeaderText = "寄件网点";
            this.寄件网点.Name = "寄件网点";
            // 
            // 收货网店
            // 
            this.收货网店.DataPropertyName = "收货网店";
            this.收货网店.HeaderText = "收货网店";
            this.收货网店.Name = "收货网店";
            // 
            // dgvMingXi
            // 
            this.dgvMingXi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMingXi.Location = new System.Drawing.Point(25, 349);
            this.dgvMingXi.Name = "dgvMingXi";
            this.dgvMingXi.RowTemplate.Height = 27;
            this.dgvMingXi.Size = new System.Drawing.Size(890, 209);
            this.dgvMingXi.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "订单明细：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "订单信息：";
            // 
            // btnDaYin
            // 
            this.btnDaYin.Location = new System.Drawing.Point(510, 13);
            this.btnDaYin.Margin = new System.Windows.Forms.Padding(4);
            this.btnDaYin.Name = "btnDaYin";
            this.btnDaYin.Size = new System.Drawing.Size(100, 29);
            this.btnDaYin.TabIndex = 37;
            this.btnDaYin.Text = "打印";
            this.btnDaYin.UseVisualStyleBackColor = true;
            this.btnDaYin.Click += new System.EventHandler(this.btnDaYin_Click);
            // 
            // FRM_BaoBiaoDingDanLiuLan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 577);
            this.Controls.Add(this.btnDaYin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMingXi);
            this.Controls.Add(this.dgvDingDan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChaXun_Select);
            this.Controls.Add(this.dtpKaiShi);
            this.Controls.Add(this.dtpJieShu);
            this.Name = "FRM_BaoBiaoDingDanLiuLan";
            this.Text = "订单查询";
            this.Load += new System.EventHandler(this.FRM_BaoBiaoDingDanLiuLan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDingDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMingXi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpKaiShi;
        private System.Windows.Forms.DateTimePicker dtpJieShu;
        private System.Windows.Forms.Button btnChaXun_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDingDan;
        private System.Windows.Forms.DataGridView dgvMingXi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDaYin;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货运单ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单据编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接单时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 要求送达时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 提单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寄件地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收货地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 运费总价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收货方;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结算方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 制单人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修单人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寄件网点;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收货网店;
    }
}