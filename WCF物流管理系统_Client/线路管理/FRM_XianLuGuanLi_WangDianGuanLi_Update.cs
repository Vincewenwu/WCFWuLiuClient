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
    public partial class FRM_XianLuGuanLi_WangDianGuanLi_Update : Form
    {
        public FRM_XianLuGuanLi_WangDianGuanLi_Update()
        {
            InitializeComponent();
        }
        DataGridViewRow myDR;
        public FRM_XianLuGuanLi_WangDianGuanLi_Update(DataGridViewRow DR)
        {
            InitializeComponent();
            myDR = DR;
        }

        #region 实例化全局对象
        string 停用否 = "false";
        BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Update.FRM_XianLuGuanLi_WangDianGuanLi_UpdateClient myFRM_XianLuGuanLi_WangDianGuanLi_UpdateClient =
        new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Update.FRM_XianLuGuanLi_WangDianGuanLi_UpdateClient();
        BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Insert.FRM_XianLuGuanLi_WangDianGuanLi_InsertClient myFRM_XianLuGuanLi_WangDianGuanLi_InsertClient =
          new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Insert.FRM_XianLuGuanLi_WangDianGuanLi_InsertClient();

        public int  int网点ID=0;
        #endregion
        private void FRM_XianLuGuanLi_WangDianGuanLi_Update_Load(object sender, EventArgs e)
        {
            //给各个变量相应赋值
            int网点ID = Convert.ToInt32(myDR.Cells["网点ID"].Value.ToString().Trim());
            string 网点名称 =  myDR.Cells["网点名称"].Value.ToString().Trim() ;
            this.txtWangDianMingCheng.Text = 网点名称;
            this.dgvXiangLinWangDian = PublicStaticMothd.SetDgv(dgvXiangLinWangDian);
          
            //以网点ID为条件查询网点表格网点邻居表
            DataTable dt = myFRM_XianLuGuanLi_WangDianGuanLi_UpdateClient.FRM_XianLuGuanLi_WangDianGuanLi_Update_Load_ChaXunWangDianXinXi(int网点ID).Tables[0];
            DataTable dt2 = myFRM_XianLuGuanLi_WangDianGuanLi_UpdateClient.FRM_XianLuGuanLi_WangDianGuanLi_Update_Load_ChaXunWangDianXinXi_JvLi(int网点ID).Tables[0]; 
            //实例化表对象并设置列的属性
            DataTable dt3 = new DataTable();
            DataColumn dc = new DataColumn();
            dc = dt3.Columns.Add("选中否", Type.GetType("System.Boolean"));
            dc = dt3.Columns.Add("网点ID", Type.GetType("System.Int32"));
            dc = dt3.Columns.Add("网点名称", Type.GetType("System.String"));
            dc = dt3.Columns.Add("距离", Type.GetType("System.String"));

            //遍历网点表
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow newRow = dt3.NewRow();
                newRow["网点ID"] = dt.Rows[i]["网点ID"].ToString().Trim();
                newRow["网点名称"] = dt.Rows[i]["网点名称"].ToString().Trim();
                //遍历网点邻居表
                for (int j = 0;j < dt2.Rows.Count; j++)
                {
                    if (dt.Rows[i]["网点ID"].ToString().Trim() == dt2.Rows[j]["相邻网点ID"].ToString().Trim())//如果网点表的网点ID与网店邻居表的相邻网店ID相等时：
                    {
                        //给行对象的单元格相应赋值
                        newRow["距离"] = dt2.Rows[j]["距离"].ToString().Trim();
                        newRow["选中否"] = true;
                    }
                }
                dt3.Rows.Add(newRow); //把行对象加到表对象李
                
            }
            this.dgvXiangLinWangDian.AllowUserToAddRows = false;
            this.dgvXiangLinWangDian.AllowUserToResizeRows = false;
            this.dgvXiangLinWangDian.DataSource = dt3;//绑定数据
            停用否 = "false";
            
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

        private void dgvXiangLinWangDian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvXiangLinWangDian.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCun_Update_Click(object sender, EventArgs e)
        {
            dgvXiangLinWangDian.EndEdit();
            foreach (DataGridViewRow dr in dgvXiangLinWangDian.Rows)//检查距离是否都输入
            {
                if (Convert.ToBoolean(dr.Cells["选中否"].FormattedValue))
                {
                    if (dr.Cells["距离"].Value.ToString()=="")
                    {

                        MessageBox.Show("请输入距离！");
                        return;
                    }

                }
            }
            //给变量相应赋值
            string 网点名称 = this.txtWangDianMingCheng.Text.ToString().Trim();
            int resule = myFRM_XianLuGuanLi_WangDianGuanLi_UpdateClient.btnBaoCun_Update_Click_XiuGaiWangDian(网点名称, 停用否, int网点ID.ToString());//修改网点新信息
               int   ShanChuWangDian= myFRM_XianLuGuanLi_WangDianGuanLi_UpdateClient. btnBaoCun_Update_Click_ShanChuXiangLinWangDian(int网点ID.ToString());//以网点ID为条件删除网点邻居表的信息
            if (resule > 0)
            {
                DataTable resule2 = new DataTable();
                foreach (DataGridViewRow dr in dgvXiangLinWangDian.Rows)
                {
                    if (Convert.ToBoolean(dr.Cells["选中否"].FormattedValue))
                    {

                     //给相应网点赋值
                        int 邻居网点ID = Convert.ToInt32(dr.Cells["网点ID"].Value.ToString().Trim());
                        decimal 距离 = Convert.ToDecimal(dr.Cells["距离"].Value.ToString().Trim());
                        resule2 = myFRM_XianLuGuanLi_WangDianGuanLi_InsertClient.btnBaoCun_Click_ChaRuWangDianXinXi_ChaRuXiangLinWangDian(int网点ID, 邻居网点ID, 距离).Tables[0];//插入网点邻居表

                    }
                }
                if (resule2.Rows.Count > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                    PublicStaticObject.Pub_FRM_XianLuGuanLi_WangDianGuanLi.ShuaXin();//刷新dgv
                }
            }

        }

       
    }
}
