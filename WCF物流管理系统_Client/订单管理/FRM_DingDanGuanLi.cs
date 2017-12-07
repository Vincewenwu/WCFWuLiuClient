using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.订单管理
{
    public partial class FRM_DingDanGuanLi : Form
    {
        #region 构造方法
        public FRM_DingDanGuanLi()
        {
            InitializeComponent(); 
        }
        #endregion

        #region 参数设置
        BLL物流管理系统.订单管理.DingDanGuanLi.DingDanGuanLiClient myDingDanGuanLi =
            new BLL物流管理系统.订单管理.DingDanGuanLi.DingDanGuanLiClient(); 
        int 页面大小 = 10;
        int 页码 = 1;
        int 最大页码 = 0;
        int 货运单总数 = 0; 
        #endregion

        #region Load事件,设置窗体位置和窗体大小，并绑定数据
        private void FRM_DingDanGuanLi_Load(object sender, EventArgs e)
        {
            try
            {
                #region 设置窗体位置和窗体大小
                    dgvDingDanXinXi.AutoGenerateColumns = false;
                    this.Left = PublicStaticObject.MainLeft;
                    this.Top = PublicStaticObject.MainTop;
                    this.Width = PublicStaticObject.MainWidth;
                    this.Height = PublicStaticObject.MainHeight;
                #endregion

                #region 绑定数据
                    dttmpkDaoDaShiJian.Value = dttmpkQiShiShiJian.Value.AddDays(1);
                    //绑定到达时间为起始时间加一天
                    this.dgvDingDanXinXi = PublicStaticMothd.SetDgv(dgvDingDanXinXi);
                    //绑定订单信息DGV
                    this.dgvDingDanXinXiMingXi = PublicStaticMothd.SetDgv(dgvDingDanXinXiMingXi);
                    //绑定订单明细信息DGV 
                    #region 绑定货物名称、揽收状态、收件客户名称、寄件客户名称
                        //绑定货物名称下拉框
                        cboHuoMing.DataSource = myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectHuoMing().Tables[0];
                        cboHuoMing.DisplayMember = "货物名称";
                        cboHuoMing.ValueMember = "货物ID"; 
                        //绑定货物揽收状态下拉框
                        cboZhuangTai.DataSource = myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectZhuangTai().Tables[0];
                        cboZhuangTai.DisplayMember = "货物揽收状态";
                        cboZhuangTai.ValueMember = "货物揽收状态ID"; 
                        //绑定收货方客户名称
                        DataTable dtKeHu = myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectKeHu().Tables[0];
                        cboShouHuoFang.DataSource = dtKeHu;
                        cboShouHuoFang.DisplayMember = "客户全称";
                        cboShouHuoFang.ValueMember = "客户ID"; 
                        //绑定托运方客户名称 
                        cboTuoYunFang.DataSource = dtKeHu.Copy();
                        //cboTuoYunFang.DataSource = myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectKeHu().Tables[0];
                        cboTuoYunFang.DisplayMember = "客户全称";
                        cboTuoYunFang.ValueMember = "客户ID";
                #endregion
                #endregion

                #region 初始化查询全部订单信息，并根据页面大小进行分页
                //查询全部订单 
                DataTable dt = 
                        myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectHuoYunDanByFenYe(页面大小, 页码).Tables[0];
                dgvDingDanXinXi.DataSource = dt;
                    货运单总数 = myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectHuoYunDanCount(); 
                    最大页码 = 货运单总数 / 页面大小; 
                    if (货运单总数 % 页面大小 > 0)
                    {
                        最大页码++;
                    } 
                    lblTotalPage.Text = 最大页码.ToString();
                    lblCurrentPage.Text = 页码.ToString();
                    lblDanJuShu.Text = 货运单总数.ToString(); 
                    SheZhiSuoDingAnNiu();
                #endregion
            }
            catch
            { 
            }
        }
        #endregion

        #region 关闭按钮
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 打开订单管理模块中的新增订单信息
        private void tspbtnXinZengDingDan_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_DingDanGuanLi_Insert = new 订单管理.FRM_DingDanGuanLi_Insert();
            PublicStaticObject.Pub_FRM_DingDanGuanLi_Insert.ShowDialog();
        }
        #endregion

        #region 订单DGV中审核订单信息
        private void dgvHuoYunDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    if (dgvDingDanXinXi.CurrentRow.Cells["锁定"].Value.ToString() == "未审核")
                    {
                        int countSuccess = 0;
                        //更新货运单的审核否字段，设置为真
                        int 货运单ID = Convert.ToInt32(dgvDingDanXinXi.CurrentRow.Cells["货运单ID"].Value);
                        if (myDingDanGuanLi.dgvHuoYunDan_CellClick_UpdateShenHe(
                                 货运单ID
                            ) > 0)
                        {
                            //审核之后，针对每一个明细，生成一条默认的分包数据
                            foreach (DataGridViewRow dgvr in dgvDingDanXinXiMingXi.Rows)
                            {
                                int 货运单明细ID = Convert.ToInt32(dgvr.Cells["货运单明细ID"].Value);
                                decimal 分包数量 = Convert.ToDecimal(dgvr.Cells["数量"].Value);
                                countSuccess += myDingDanGuanLi.dgvHuoYunDan_CellClick_InsertFenBao(货运单明细ID,分包数量);
                            }
                        }
                        if (countSuccess == dgvDingDanXinXiMingXi.RowCount)
                        {
                            MessageBox.Show("审核成功！");
                            FRM_DingDanGuanLi_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("审核失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("订单已经审核！");
                    }
                }
            }
        }
        #endregion

        #region 打开订单管理模块中的修改订单信息
        private void tspbtnXiuGaiDingDan_Click(object sender, EventArgs e)
        {
            if (dgvDingDanXinXi.CurrentRow.Cells["锁定"].Value.ToString() == "未审核")
            {
                PublicStaticObject.Pub_FRM_DingDanGuanLi_Update = 
                    new 订单管理.FRM_DingDanGuanLi_Update(Convert.ToInt32(dgvDingDanXinXi.CurrentRow.Cells["货运单ID"].Value));
                PublicStaticObject.Pub_FRM_DingDanGuanLi_Update.ShowDialog();//修改订单之后的刷新数据操作。
            }
            else
            {
                MessageBox.Show("已审核的货物无法修改！");
            }
        }
        #endregion

        #region 删除订单信息
        private void tspBtnShanChuDingDan_Click(object sender, EventArgs e)
        {
            if (dgvDingDanXinXi.CurrentRow.Cells["锁定"].Value.ToString() == "未审核")
            {
                int countSuccess = 0;
                //删除货运单
                int 货运单ID = Convert.ToInt32(dgvDingDanXinXi.CurrentRow.Cells["货运单ID"].Value);
                if (myDingDanGuanLi.tspBtnShanChuDingDan_Click_DeleteHuoYunDan(货运单ID) > 0)
                {
                    //删除货运单明细
                    countSuccess = myDingDanGuanLi.tspBtnShanChuDingDan_Click_DeleteHuoYunDanMingXi(货运单ID);
                }

                if (countSuccess == dgvDingDanXinXiMingXi.RowCount)
                {
                    MessageBox.Show("删除成功！");
                    FRM_DingDanGuanLi_Load(null, null);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {
                MessageBox.Show("已审核的货物无法修改！");
            }

        }
        #endregion

        #region 订单管理DGV行标题添加序号
        private void dgvHuoYunDan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvDingDanXinXi.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        } 
        #endregion

        #region 货物信息DGV行标题添加序号
        private void dgvHuoYunDanMingXi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvDingDanXinXiMingXi.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        }
        #endregion

        #region 设置订单管理DGV中审核否按钮信息
        void SheZhiSuoDingAnNiu()
        {
            if (dgvDingDanXinXi.DataSource != null)
            {
                foreach (DataGridViewRow dgvr in dgvDingDanXinXi.Rows)
                {
                    if (Convert.ToBoolean(dgvr.Cells["审核否"].FormattedValue))
                    {
                        dgvr.Cells["锁定"].Value = "已审核";
                    }
                    else
                    {
                        dgvr.Cells["锁定"].Value = "未审核";
                    }
                }
            }
        }
        #endregion

        #region 查询按钮
        private void btnChaXun_Click(object sender, EventArgs e)
        {
            if (rdbtnRiQi.Checked)
            {
                DateTime 开始日期 = dttmpkQiShiShiJian.Value;
                DateTime 结束日期 = dttmpkDaoDaShiJian.Value;
                bool 审核否 = chkShenHeFou.Checked;
                dgvDingDanXinXi.DataSource =
                    myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectDingDanByRiQi(开始日期,结束日期,审核否).Tables[0];
            }
            if (rdbtnHuoMing.Checked)
            {
                int 货物ID = Convert.ToInt32(cboHuoMing.SelectedValue);
                bool 审核否 = chkShenHeFou.Checked;
                dgvDingDanXinXi.DataSource = 
                    myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectDingDanByHuoWuID(货物ID,审核否).Tables[0];
            }

            SheZhiSuoDingAnNiu();
            if (dgvDingDanXinXi.Rows.Count <= 0)
            {
                dgvDingDanXinXiMingXi.DataSource = null;
            }
            tspCaiDan.Visible = false;
        }
        #endregion

        #region DGV订单管理翻页——下一页
        private void tsbXiaYiYe_Click(object sender, EventArgs e)
        {
            if (页码 < 最大页码)
            {
                页码++;
                dgvDingDanXinXi.DataSource =
                    myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectHuoYunDanByFenYe(页面大小, 页码).Tables[0];
                lblCurrentPage.Text = 页码.ToString();
                SheZhiSuoDingAnNiu();
            }
            else
            {
                MessageBox.Show("已经是尾页了！！！！");
            }
        }
        #endregion

        #region DGV订单管理翻页——上一页
        private void tsbShangYiYe_Click(object sender, EventArgs e)
        {
            if (页码 > 1)
            {
                页码--;
                dgvDingDanXinXi.DataSource =
                    myDingDanGuanLi.FRM_DingDanGuanLi_Load_SelectHuoYunDanByFenYe(页面大小, 页码).Tables[0];
                lblCurrentPage.Text = 页码.ToString();
                SheZhiSuoDingAnNiu();
            }
            else
            {
                MessageBox.Show("已经是首页了！！！！");
            }
        }
        #endregion

        #region 根据DGV订单管理中选中的订单信息查询对应的货物信息并绑定在DGV货物中
        private void dgvHuoYunDan_SelectionChanged(object sender, EventArgs e)
        {
            //查询明细
            if (dgvDingDanXinXi.CurrentRow != null)
            {
                int 货运单ID = Convert.ToInt32(dgvDingDanXinXi.CurrentRow.Cells["货运单ID"].Value);
                dgvDingDanXinXiMingXi.DataSource =
                    myDingDanGuanLi.dgvHuoYunDan_SelectionChanged_SelectHuoYunDanMingXi(货运单ID).Tables[0];
            }
            else
            {
                dgvDingDanXinXiMingXi.DataSource = null;
            }
        }
        #endregion

        #region 弹出物流信息查询模块
        private void tsbWuLiu_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_WuLiuXinXiChaXun = new FRM_WuLiuXinXiChaXun();
            PublicStaticObject.Pub_FRM_WuLiuXinXiChaXun.ShowDialog();
        }
        #endregion  
    }
}
