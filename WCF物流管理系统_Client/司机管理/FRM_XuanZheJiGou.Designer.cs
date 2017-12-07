namespace WCF物流管理系统_Client.司机管理
{
    partial class FRM_XuanZheJiGou
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
            this.trvXuanZheJiGou = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvXuanZheJiGou
            // 
            this.trvXuanZheJiGou.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvXuanZheJiGou.Location = new System.Drawing.Point(0, 0);
            this.trvXuanZheJiGou.Name = "trvXuanZheJiGou";
            this.trvXuanZheJiGou.Size = new System.Drawing.Size(154, 262);
            this.trvXuanZheJiGou.TabIndex = 0;
            this.trvXuanZheJiGou.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvXuanZheJiGou_NodeMouseDoubleClick);
            // 
            // FRM_XuanZheJiGou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 262);
            this.Controls.Add(this.trvXuanZheJiGou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_XuanZheJiGou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择机构";
            this.Load += new System.EventHandler(this.FRM_XuanZheJiGou_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvXuanZheJiGou;
    }
}