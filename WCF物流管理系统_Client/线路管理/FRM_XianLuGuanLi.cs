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
    public partial class FRM_XianLuGuanLi : Form
    {
        public FRM_XianLuGuanLi()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BLL物流管理系统.线路管理.FRM_XianLuGuanLi.FRM_XianLuGuanLiClient myFRM_XianLuGuanLiClient = 
            new BLL物流管理系统.线路管理.FRM_XianLuGuanLi.FRM_XianLuGuanLiClient();
        BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_InsertClient myFRM_XianLuGuanLi_InsertClient = new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_InsertClient();
              
        Color color ;
        private void FRM_XianLuGuanLi_Load(object sender, EventArgs e)
        {
            this.dgvXianLuWangDianXinXi = PublicStaticMothd.SetDgv(dgvXianLuWangDianXinXi);
            this.dgvXianLuXinXi = PublicStaticMothd.SetDgv(dgvXianLuXinXi);
            //设置窗体的位置和大小
             this.Left = PublicStaticObject.MainLeft;
            this.Top = PublicStaticObject.MainTop;
            this.Width = PublicStaticObject.MainWidth;
            this.Height = PublicStaticObject.MainHeight;
            dgvXianLuXinXi.AutoGenerateColumns = false;
            this.dgvXianLuWangDianXinXi.AutoGenerateColumns = false;
            DataTable dt = myFRM_XianLuGuanLi_InsertClient.FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi().Tables[0]; //查询所有网点
            DataTable dt2 = dt.Copy();    //复制dtWangDian再赋值给dtWangDian2
            this.cboQiShiWangDian.DataSource = dt;                //设定cboQiShiWangDian的数据源为dtWangDian
            this.cboQiShiWangDian.DisplayMember = "网点名称";     //设定cboQiShiWangDian的显示成员为列名为“网点名称”的列 
            this.cboQiShiWangDian.ValueMember = "网点ID";         //设定cboQiShiWangDian的值成员为列名为“网点ID”的列 
            this.cboJieShuWangDian.DataSource = dt2;
            this.cboJieShuWangDian.DisplayMember = "网点名称";
            this.cboJieShuWangDian.ValueMember = "网点ID";

           dgvXianLuXinXi.DataSource=myFRM_XianLuGuanLiClient.FRM_XianLuGuanLi_Load_ChaXunQuanBuXianLu ().Tables[0];//查询所有线路并绑定到dgv
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_XianLuGuanLi_Insert = new 线路管理.FRM_XianLuGuanLi_Insert();
            PublicStaticObject.Pub_FRM_XianLuGuanLi_Insert.ShowDialog();
            dgvXianLuXinXi.DataSource = myFRM_XianLuGuanLiClient.FRM_XianLuGuanLi_Load_ChaXunQuanBuXianLu().Tables[0];

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string 线路ID = dgvXianLuXinXi.CurrentRow.Cells["线路ID"].Value.ToString().Trim(); //获取当前行的线路ID
            PublicStaticObject.Pub_FRM_XianLuGuanLi_Update = new 线路管理.FRM_XianLuGuanLi_Update(线路ID); //实例化修改对象，并以线路ID作为参数执行构造方法
            PublicStaticObject.Pub_FRM_XianLuGuanLi_Update.ShowDialog();
            dgvXianLuXinXi.DataSource = myFRM_XianLuGuanLiClient.FRM_XianLuGuanLi_Load_ChaXunQuanBuXianLu().Tables[0];

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_XianLuGuanLi_WangDianGuanLi = new 线路管理.FRM_XianLuGuanLi_WangDianGuanLi();
            PublicStaticObject.Pub_FRM_XianLuGuanLi_WangDianGuanLi.ShowDialog(); 
            
        }


        private void dgvXianLuWangDianXinXi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvXianLuWangDianXinXi.Rows[e.RowIndex];//获取当前行
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);//把行的最左边的列的序号设为对应的行号
        }

        private void dgvXianLuXinXi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvXianLuXinXi.Rows[e.RowIndex];//获取当前行
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);//把行的最左边的列的序号设为对应的行号
        }

       


        private void tsbShangChu_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否停用？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//弹出确定对话框
            if (dr == DialogResult.OK)//如果点了确定按钮
            {
                if (dgvXianLuXinXi.CurrentRow != null)
                {
                    int i = myFRM_XianLuGuanLiClient.tsbShangChu_Delete_Click_ShanChuXianLu(dgvXianLuXinXi.CurrentRow.Cells["线路ID"].Value.ToString());//把当前行的线路ID作为条件停用线路
                    if (i > 0)
                    {
                        MessageBox.Show("停用成功！");
                        dgvXianLuXinXi.DataSource = myFRM_XianLuGuanLiClient.FRM_XianLuGuanLi_Load_ChaXunQuanBuXianLu().Tables[0];//刷新线路
                    }
                    else
                    {
                        MessageBox.Show("停用失败！");
                    }
                }
            }

        }
        private void dgvXianLuXinXi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvXianLuXinXi.CurrentRow != null)
            {
                string 线路ID = this.dgvXianLuXinXi.CurrentRow.Cells["线路ID"].Value.ToString();    //获取当前行的线路ID
                DataTable dt = myFRM_XianLuGuanLiClient.dgvXianLuXinXi_CellClick_ChaXunXianLuXiangXiXinXi(线路ID).Tables[0];//以线路ID为参数执行查询，得到线路明细
                this.dgvXianLuWangDianXinXi.AllowUserToAddRows = false;  //禁止dgv增加行 
                this.dgvXianLuWangDianXinXi.DataSource = dt;   //指定数据源
            }
        }
 
        private void btnChaXun_Select_Click(object sender, EventArgs e)
        {
            //给相应变量赋值
            string 线路名称 = this.txtXianLuMingCheng.Text.Trim();
            string 助记码 = this.txZhuJiMa.Text.Trim();
            if (rdbXianLuMingCheng.Checked)//如果线路名称单选按钮选择
            { 
                dgvXianLuXinXi.DataSource = myFRM_XianLuGuanLiClient.FRM_XianLuGuanLi_Load_DuoTiaoJianChaXunXianLu(线路名称, null).Tables[0];//以线路名称为条件查询线路
            }
            if (this.rdbZhuJiMa.Checked)//如果助记码单选按钮选择
            {
                dgvXianLuXinXi.DataSource = myFRM_XianLuGuanLiClient.FRM_XianLuGuanLi_Load_DuoTiaoJianChaXunXianLu(null, 助记码).Tables[0];//以助记码为条件查询线路
            }
            if (this.rdbQiZhiWangDian.Checked)//如果起止网点单选按钮选择
            {
                DataTable dtLinJu = myFRM_XianLuGuanLiClient.dgvXianLuXinXi_CellClick_ChaXunXianLuXiangXiXinXi(null).Tables[0]; //查询全部网点邻居表
                DataTable dtLuXian = myFRM_XianLuGuanLiClient.FRM_XianLuGuanLi_Load_ChaXunQuanBuXianLu().Tables[0]; //查询全部线路
                DataTable dtXianLuHeBing = dtLuXian.Clone();   //赋值线路表的结构
                string strQiShiWangDianID = cboQiShiWangDian.SelectedValue.ToString();//获取起始网点
                string strZhongZhiWangDianID = this.cboJieShuWangDian.SelectedValue.ToString();//获取终止网点
                for (int i = 0; i < dtLuXian.Rows.Count; i++) //遍历线路表
                {
                    //以线路ID为条件过滤网点邻居表
                    DataView myDataView = new DataView(dtLinJu);//实例化数据视图对象
                    myDataView.RowFilter = "线路ID=" + dtLuXian.Rows[i]["线路ID"].ToString();//过滤
                    DataTable dtGuoLv = myDataView.ToTable();//转换为表对象
                    if (dtGuoLv.Rows.Count > 0)
                    {
                        //如果邻居表的第一行的网点ID与起始网点ID相同 ，切最后一行的邻居ID与终止网点ID相同，说明这线路符合要求
                        if (dtGuoLv.Rows[0]["网点ID"].ToString() == strQiShiWangDianID && dtGuoLv.Rows[dtGuoLv.Rows.Count - 1]["邻居网点ID"].ToString() == strZhongZhiWangDianID)
                        {

                            DataRow dr = dtXianLuHeBing.NewRow();//实例化行对象并复制
                            dr["线路ID"] = dtLuXian.Rows[i]["线路ID"].ToString();
                            dr["线路名称"] = dtLuXian.Rows[i]["线路名称"].ToString();
                            dr["助记码"] = dtLuXian.Rows[i]["助记码"].ToString();
                            dtXianLuHeBing.Rows.Add(dr);//把行对象加到表对象dtXianLuHeBing
                        }
                    }
                }
                dgvXianLuXinXi.DataSource = dtXianLuHeBing;//把处理后的线路结果显示到DGV
            }
        }

    }
}
