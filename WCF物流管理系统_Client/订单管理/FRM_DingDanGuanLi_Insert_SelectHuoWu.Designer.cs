namespace WCF物流管理系统_Client.订单管理
{
    partial class FRM_DingDanGuanLi_Insert_SelectHuoWu
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
            this.dgvHuoWu = new System.Windows.Forms.DataGridView();
            this.货物ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货物名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.计量单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货物类别ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbKeHu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuoWu)).BeginInit();
            this.gpbKeHu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHuoWu
            // 
            this.dgvHuoWu.AllowUserToAddRows = false;
            this.dgvHuoWu.AllowUserToDeleteRows = false;
            this.dgvHuoWu.AllowUserToResizeColumns = false;
            this.dgvHuoWu.AllowUserToResizeRows = false;
            this.dgvHuoWu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuoWu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.货物ID,
            this.货物名称,
            this.计量单位,
            this.货物类别ID});
            this.dgvHuoWu.Location = new System.Drawing.Point(0, 20);
            this.dgvHuoWu.MultiSelect = false;
            this.dgvHuoWu.Name = "dgvHuoWu";
            this.dgvHuoWu.ReadOnly = true;
            this.dgvHuoWu.RowTemplate.Height = 23;
            this.dgvHuoWu.Size = new System.Drawing.Size(245, 239);
            this.dgvHuoWu.TabIndex = 0;
            this.dgvHuoWu.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHuoWu_CellMouseDoubleClick);
            // 
            // 货物ID
            // 
            this.货物ID.DataPropertyName = "货物ID";
            this.货物ID.HeaderText = "货物ID";
            this.货物ID.Name = "货物ID";
            this.货物ID.ReadOnly = true;
            this.货物ID.Visible = false;
            // 
            // 货物名称
            // 
            this.货物名称.DataPropertyName = "货物名称";
            this.货物名称.HeaderText = "货物名称";
            this.货物名称.Name = "货物名称";
            this.货物名称.ReadOnly = true;
            // 
            // 计量单位
            // 
            this.计量单位.DataPropertyName = "计量单位";
            this.计量单位.HeaderText = "计量单位";
            this.计量单位.Name = "计量单位";
            this.计量单位.ReadOnly = true;
            // 
            // 货物类别ID
            // 
            this.货物类别ID.DataPropertyName = "货物类别ID";
            this.货物类别ID.HeaderText = "货物类别ID";
            this.货物类别ID.Name = "货物类别ID";
            this.货物类别ID.ReadOnly = true;
            this.货物类别ID.Visible = false;
            // 
            // gpbKeHu
            // 
            this.gpbKeHu.Controls.Add(this.dgvHuoWu);
            this.gpbKeHu.Location = new System.Drawing.Point(3, 1);
            this.gpbKeHu.Name = "gpbKeHu";
            this.gpbKeHu.Size = new System.Drawing.Size(249, 259);
            this.gpbKeHu.TabIndex = 1;
            this.gpbKeHu.TabStop = false;
            this.gpbKeHu.Text = "货物名称";
            // 
            // FRM_DingDanGuanLi_Insert_SelectHuoWu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(255, 262);
            this.Controls.Add(this.gpbKeHu);
            this.Name = "FRM_DingDanGuanLi_Insert_SelectHuoWu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "货物信息";
            this.Load += new System.EventHandler(this.FRM_DingDanGuanLi_Insert_SelectHuoWu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuoWu)).EndInit();
            this.gpbKeHu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHuoWu;
        private System.Windows.Forms.GroupBox gpbKeHu;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 计量单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物类别ID;
    }
}