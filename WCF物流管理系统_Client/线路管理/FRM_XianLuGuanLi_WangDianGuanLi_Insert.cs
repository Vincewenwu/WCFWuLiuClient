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
    public partial class FRM_XianLuGuanLi_WangDianGuanLi_Insert : Form
    {
        public FRM_XianLuGuanLi_WangDianGuanLi_Insert()
        {
            InitializeComponent();
        }
        #region 实例化全局对象
        string 停用否 = "false";
            BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Insert.FRM_XianLuGuanLi_WangDianGuanLi_InsertClient myFRM_XianLuGuanLi_WangDianGuanLi_InsertClient =
            new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Insert.FRM_XianLuGuanLi_WangDianGuanLi_InsertClient();
            #endregion
            private void FRM_XianLuGuanLi_WangDianGuanLi_Insert_Load(object sender, EventArgs e)
        {
            this.dgvXiangLinWangDian = PublicStaticMothd.SetDgv(dgvXiangLinWangDian);
            DataTable dt = myFRM_XianLuGuanLi_WangDianGuanLi_InsertClient.FRM_XianLuGuanLi_WangDianGuanLi_Insert_Load_ChaXunWangDianXinXi().Tables[0];//查询全部网点信息
            this.dgvXiangLinWangDian.AllowUserToAddRows = false;//禁止增加行
            this.dgvXiangLinWangDian.AllowUserToResizeRows = false;//禁止改变行大小
            this.dgvXiangLinWangDian.DataSource = dt;//绑定dgv
            停用否 = "false";
        }
       private void btnBaoCun_Click(object sender, EventArgs e)
     {
            dgvXiangLinWangDian.EndEdit();//结束dgv的编辑状态
            foreach (DataGridViewRow dr in dgvXiangLinWangDian.Rows)//检查是否都输入距离
            {
                if (Convert.ToBoolean(dr.Cells["选中否"].FormattedValue))
                {
                    if (dr.Cells["距离"].Value == null)
                    { 
                        MessageBox.Show("请输入距离！");
                        return;//结束方法
                    }
                 
                }
            } 
            string 网点名称 =this.txtWangDianMingCheng.Text.ToString().Trim();//获取网点名称
            DataTable resule = myFRM_XianLuGuanLi_WangDianGuanLi_InsertClient.btnBaoCun_Click_ChaRuWangDianXinXi(网点名称, 停用否).Tables[0];//插入网点信息
           if (resule.Rows.Count > 0)
           {
               DataTable resule2 = new DataTable();
               foreach(DataGridViewRow dr in dgvXiangLinWangDian.Rows )//遍历相邻网点信息
               {
                   if (Convert.ToBoolean(dr.Cells["选中否"].FormattedValue))//是否被选择
                   {
                       //给相应参数赋值
                           int 网点ID = Convert.ToInt32(resule.Rows[0][0].ToString().Trim());
                           int 邻居网点ID = Convert.ToInt32(dr.Cells["网点ID"].Value.ToString().Trim());
                           decimal 距离 = Convert.ToDecimal(dr.Cells["距离"].Value.ToString().Trim());
                           resule2 = myFRM_XianLuGuanLi_WangDianGuanLi_InsertClient.btnBaoCun_Click_ChaRuWangDianXinXi_ChaRuXiangLinWangDian(网点ID, 邻居网点ID, 距离).Tables[0];//插入邻居网点表
                       
                   }
               }
                if (resule2.Rows.Count > 0)
               {
                    MessageBox.Show("添加成功！");               
                    this.Close();
                    PublicStaticObject.Pub_FRM_XianLuGuanLi_WangDianGuanLi.ShuaXin();//刷新
                }
           }


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //设置行号
            DataGridViewRow CurrentRow = this.dgvXiangLinWangDian.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        }

        private void btnQiYongWangDian_Click(object sender, EventArgs e)
        {
            this.btnQiYongWangDian.Enabled = false;
            this.btnTingYongWangDian.Enabled = true;
            停用否 = "false";
        }

        private void btnTingYongWangDian_Click(object sender, EventArgs e)
        {
            this.btnQiYongWangDian.Enabled = true;
            this.btnTingYongWangDian.Enabled = false;
            停用否 = "true";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
         
    }
}
