namespace WCF物流管理系统_Client.订单管理
{
    partial class FRM_DingDanGuanLi_Update_SelectHuoWu
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
            this.gpbKeHu = new System.Windows.Forms.GroupBox();
            this.dgvHuoWu = new System.Windows.Forms.DataGridView();
            this.货物ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货物名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.计量单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货物类别ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbKeHu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuoWu)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbKeHu
            // 
            this.gpbKeHu.Controls.Add(this.dgvHuoWu);
            this.gpbKeHu.Location = new System.Drawing.Point(2, 2);
            this.gpbKeHu.Name = "gpbKeHu";
            this.gpbKeHu.Size = new System.Drawing.Size(256, 259);
            this.gpbKeHu.TabIndex = 2;
            this.gpbKeHu.TabStop = false;
            this.gpbKeHu.Text = "货物名称";
            // 
            // dgvHuoWu
            // 
            this.dgvHuoWu.AllowUserToAddRows = false;
            this.dgvHuoWu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuoWu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.货物ID,
            this.货物名称,
            this.计量单位,
            this.货物类别ID});
            this.dgvHuoWu.Location = new System.Drawing.Point(6, 14);
            this.dgvHuoWu.Name = "dgvHuoWu";
            this.dgvHuoWu.RowTemplate.Height = 23;
            this.dgvHuoWu.Size = new System.Drawing.Size(249, 239);
            this.dgvHuoWu.TabIndex = 0;
            this.dgvHuoWu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvHuoWu_MouseDoubleClick);
            // 
            // 货物ID
            // 
            this.货物ID.DataPropertyName = "货物ID";
            this.货物ID.HeaderText = "货物ID";
            this.货物ID.Name = "货物ID";
            this.货物ID.Visible = false;
            // 
            // 货物名称
            // 
            this.货物名称.DataPropertyName = "货物名称";
            this.货物名称.HeaderText = "货物名称";
            this.货物名称.Name = "货物名称";
            // 
            // 计量单位
            // 
            this.计量单位.DataPropertyName = "计量单位";
            this.计量单位.HeaderText = "计量单位";
            this.计量单位.Name = "计量单位";
            // 
            // 货物类别ID
            // 
            this.货物类别ID.DataPropertyName = "货物类别ID";
            this.货物类别ID.HeaderText = "货物类别ID";
            this.货物类别ID.Name = "货物类别ID";
            this.货物类别ID.Visible = false;
            // 
            // FRM_DingDanGuanLi_Update_SelectHuoWu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 262);
            this.Controls.Add(this.gpbKeHu);
            this.Name = "FRM_DingDanGuanLi_Update_SelectHuoWu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "货物信息";
            this.Load += new System.EventHandler(this.FRM_DingDanGuanLi_Update_SelectHuoWu_Load);
            this.gpbKeHu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuoWu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbKeHu;
        private System.Windows.Forms.DataGridView dgvHuoWu;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 计量单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物类别ID;
    }
}