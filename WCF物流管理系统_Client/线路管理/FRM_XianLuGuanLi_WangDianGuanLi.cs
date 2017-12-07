using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.线路管理
{
    public partial class FRM_XianLuGuanLi_WangDianGuanLi : Form
    {
        public FRM_XianLuGuanLi_WangDianGuanLi()
        {
            InitializeComponent();
        }
        #region 实例化全局对象
        BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi.FRM_XianLuGuanLi_WangDianGuanLiClient myFRM_XianLuGuanLi_WangDianGuanLiClient
        = new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi.FRM_XianLuGuanLi_WangDianGuanLiClient();
        #endregion
        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            PublicStaticObject.Pub_FRM_XianLuGuanLi_WangDianGuanLi_Insert = new 线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Insert();
            PublicStaticObject.Pub_FRM_XianLuGuanLi_WangDianGuanLi_Insert.ShowDialog(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvWangDianXinXi.CurrentRow != null)
            {
                DataGridViewRow dr = this.dgvWangDianXinXi.CurrentRow;//获取当前行对象
                PublicStaticObject.Pub_FRM_XianLuGuanLi_WangDianGuanLi_Update = new 线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Update(dr);//以行对象为参数执行FRM_XianLuGuanLi_WangDianGuanLi_Update的构造方法
                PublicStaticObject.Pub_FRM_XianLuGuanLi_WangDianGuanLi_Update.ShowDialog();
            }
        }
         private void btnChaXunWangDianXinXi_Click(object sender, EventArgs e)
        {
            ShuaXin();//执行刷新方法
        }

        private void dgvWangDianXinXi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //设置行序号
            DataGridViewRow CurrentRow = this.dgvWangDianXinXi.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        }

        private void dgvWangDianXinXi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChaXunXiangLinWangDian();
        }
        public void ShuaXin()
        {
            if (this.rbtWangDianMingCheng.Checked == true)
            {
                string 网点名称 = this.txtWangDianMingCheng.Text.ToString().Trim();
                DataTable dt = myFRM_XianLuGuanLi_WangDianGuanLiClient.btnChaXunWangDianXinXi_Click_ChaXunWangDianXinXi(网点名称).Tables[0];//以网点名称查询网点信息
                this.dgvWangDianXinXi.AllowUserToAddRows = false;//禁止增加行
                this.dgvWangDianXinXi.AllowUserToResizeRows = false;//禁止调整行大小
                this.dgvWangDianXinXi.DataSource = dt;//绑定dgv
                ChaXunXiangLinWangDian();
            }
            if (this.chkYiTingYong.Checked == true)
            {
                string 停用否 = this.chkYiTingYong.Checked.ToString();
                DataTable dt = myFRM_XianLuGuanLi_WangDianGuanLiClient.btnChaXunWangDianXinXi_Click_ChaXunWangDianXinXiONZhuangTai(停用否).Tables[0];//以停运否来查询网点信息
                this.dgvWangDianXinXi.AllowUserToAddRows = false;//禁止增加行
                this.dgvWangDianXinXi.AllowUserToResizeRows = false;//禁止调整行大小
                this.dgvWangDianXinXi.DataSource = dt;//绑定dgv
                ChaXunXiangLinWangDian();//查询相邻网点并刷新
            }
        }
        public void ChaXunXiangLinWangDian()
        {
            if (dgvWangDianXinXi.CurrentRow != null)
            {
                if (this.dgvWangDianXinXi.Rows.Count > 0)
                {
                    string 网点ID = this.dgvWangDianXinXi.CurrentRow.Cells["网点ID"].Value.ToString().Trim();//获取当前行的网点ID
                    DataTable dt = myFRM_XianLuGuanLi_WangDianGuanLiClient.dgvWangDianXinXi_CellClick_ChaXunXiangLinWangDianXinXi(网点ID).Tables[0];//以网点ID查询网点邻居信息
                    this.dgvXiangLinWangDianXinXi.AllowUserToAddRows = false;//禁止增加行
                    this.dgvXiangLinWangDianXinXi.AllowUserToResizeRows = false;//禁止调整行大小
                    this.dgvXiangLinWangDianXinXi.DataSource = dt;//绑定数据到dgv
                }
                else
                {
                    MessageBox.Show("未找到相应网点，请检查名称是否正确！");
                }
            }
        }
        private void dgvXiangLinWangDianXinXi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvXiangLinWangDianXinXi.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        } 
        private void FRM_XianLuGuanLi_WangDianGuanLi_Activated(object sender, EventArgs e)
        {
           
        }

        private void FRM_XianLuGuanLi_WangDianGuanLi_Load(object sender, EventArgs e)
        {
            this.dgvWangDianXinXi = PublicStaticMothd.SetDgv(dgvWangDianXinXi);
            this.dgvXiangLinWangDianXinXi = PublicStaticMothd.SetDgv(dgvXiangLinWangDianXinXi);
            this.rbtWangDianMingCheng.Checked = true;
            ShuaXin();
        }

        private void tsbShanChu_Delete_Click(object sender, EventArgs e)
        {
            if (dgvWangDianXinXi.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("是否停用？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//弹出确定对话框
                if (dr == DialogResult.OK)//如果点了确定按钮
                {

                    int i = myFRM_XianLuGuanLi_WangDianGuanLiClient.tsbShanChu_Delete_Click_ShanChuWangDian(dgvWangDianXinXi.CurrentRow.Cells["网点ID"].Value.ToString());//根据当前行的网点ID停用网点

                    if (i > 0)
                    {
                        MessageBox.Show("停用成功！");
                        ShuaXin();

                    }
                    else { MessageBox.Show("停用失败！"); }
                }
            }
        }

        private void txtWangDianMingCheng_TextChanged(object sender, EventArgs e)
        {

        }

        

      

      
    }
}
