using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WCF物流管理系统_Client.订单管理
{
    public partial class FRM_DingDanGuanLi_Update : Form
    {
        #region 定义参数
        int HuoYunDanID;
        BLL物流管理系统.订单管理.DingDanGuanLi_Update.DingDanGuanLi_UpdateClient myDingDanGuanLi_Update =
            new BLL物流管理系统.订单管理.DingDanGuanLi_Update.DingDanGuanLi_UpdateClient();
        bool bolIfTuoYun = true;
        int flagYuanGong = 0;//0业务员，1制单人，2修单人
        int tuoYunFangID = 0;
        int shouHuoFangID = 0;
        int yeWuYuanID = 0;
        int xiuDanRenID = 0;
        int zhiDanRenID = 0;
        decimal decZongJinE = 0;
        ArrayList arrDeleteMingXiID = new ArrayList();
        #endregion

        #region 重载构造方法，传递货运单ID
        public FRM_DingDanGuanLi_Update(int CHuoYunDanID)
        {
            HuoYunDanID = CHuoYunDanID;
            InitializeComponent();
        }
        #endregion 

        #region 其他保存按钮
        private void btnQiTaBaoCun_Click(object sender, EventArgs e)
        {
            this.btnQiTaBaoCun.ContextMenuStrip = null;
            Point p = this.btnQiTaBaoCun.Parent.PointToScreen(this.btnQiTaBaoCun.Location);
            p.Y += this.btnQiTaBaoCun.Height;
            this.保存.Show(p);
        }
        #endregion

        #region Load事件加载寄件网点、收件网点、结算方式、货物揽收状态、计费方式、员工信息、要修改的订单信息
        private void FRM_DingDanGuanLi_Update_Load(object sender, EventArgs e)
        {
            //绑定寄件网点下拉框
            DataTable dt = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectWangDian().Tables[0];
            cboJiJianWangDian.DataSource = dt;
            cboJiJianWangDian.DisplayMember = "网点名称";
            cboJiJianWangDian.ValueMember = "网点ID";
            //绑定收件网点下拉框
            cboShouHuoWangDian.DataSource = dt.Copy();
            cboShouHuoWangDian.DisplayMember = "网点名称";
            cboShouHuoWangDian.ValueMember = "网点ID";
            //绑定结算方式下拉框
            cboJieSuanFangShi.DataSource = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectJieSuanFangShi().Tables[0];
            cboJieSuanFangShi.DisplayMember = "结算方式";
            cboJieSuanFangShi.ValueMember = "结算方式ID";
            //绑定货物揽收状态下拉框
            CboLanShouZhangTai.DataSource = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectCboLanShouZhuangTai().Tables[0];
            CboLanShouZhangTai.DisplayMember = "货物揽收状态";
            CboLanShouZhangTai.ValueMember = "货物揽收状态ID";
            //绑定计费方式下拉框
            计费公式.DataSource = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectJiFeiGongShi().Tables[0];
            计费公式.DisplayMember = "计费公式";
            计费公式.ValueMember = "计费公式ID";
            //绑定员工信息dgv
            dgvYuanGong.DataSource = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectYuanGong().Tables[0]; 
            //通过订单ID查询对应的订单信息
            DataTable dtHuoYunDan = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_Load_SelectHuoYunDan(HuoYunDanID).Tables[0];
            //将根据订单ID查询到的订单信息绑定在特定的控件上
            #region 将根据订单ID查询到的订单信息绑定在特定的控件上 
            txtDingDanBianHao.Text = dtHuoYunDan.Rows[0]["单据编号"].ToString();
            dtpJieDanShiJian.Value = Convert.ToDateTime(dtHuoYunDan.Rows[0]["接单时间"].ToString());
            dtpSongDaShiJian.Value = Convert.ToDateTime(dtHuoYunDan.Rows[0]["要求送达时间"].ToString());
            txtTuoYunFang.Text = dtHuoYunDan.Rows[0]["托运方"].ToString();
            txtTuoYunLianXiRen.Text = dtHuoYunDan.Rows[0]["托运联系人"].ToString();
            txtTuoYunLianXiDianHua.Text = dtHuoYunDan.Rows[0]["托运联系电话"].ToString();
            rTxtFaHuoDiZhi.Text = dtHuoYunDan.Rows[0]["寄件地址"].ToString();
            tuoYunFangID = Convert.ToInt32(dtHuoYunDan.Rows[0]["托运方ID"].ToString());
            TxtShouHuoFang.Text = dtHuoYunDan.Rows[0]["收货方"].ToString();
            TxtShouHuoLianXiRen.Text = dtHuoYunDan.Rows[0]["收货联系人"].ToString();
            txtShouHuoLianXiDianHua.Text = dtHuoYunDan.Rows[0]["收货联系电话"].ToString();
            txtShouHuoDiZhi.Text = dtHuoYunDan.Rows[0]["收货地址"].ToString();
            shouHuoFangID = Convert.ToInt32(dtHuoYunDan.Rows[0]["收货方ID"].ToString());
            cboJiJianWangDian.SelectedValue = dtHuoYunDan.Rows[0]["寄件网点ID"].ToString().Trim();
            cboShouHuoWangDian.SelectedValue = dtHuoYunDan.Rows[0]["收货网点ID"].ToString().Trim();
            txtTiDanHao.Text = dtHuoYunDan.Rows[0]["提单号"].ToString().Trim();
            txtYeWuYuan.Text = dtHuoYunDan.Rows[0]["业务员"].ToString().Trim();
            txtzhiDanRen.Text = dtHuoYunDan.Rows[0]["制单人"].ToString().Trim();
            txtXiuDanRen.Text = dtHuoYunDan.Rows[0]["修单人"].ToString().Trim();
            yeWuYuanID = Convert.ToInt32(dtHuoYunDan.Rows[0]["业务员_员工ID"].ToString().Trim());
            zhiDanRenID = Convert.ToInt32(dtHuoYunDan.Rows[0]["制单人_员工ID"].ToString().Trim());
            xiuDanRenID = Convert.ToInt32(dtHuoYunDan.Rows[0]["修单人_员工ID"].ToString().Trim());
            txtYunFeiZongJia.Text = dtHuoYunDan.Rows[0]["运费总价"].ToString().Trim();
            cboJieSuanFangShi.SelectedValue = dtHuoYunDan.Rows[0]["结算方式ID"].ToString().Trim();
            CboLanShouZhangTai.SelectedValue = dtHuoYunDan.Rows[0]["货物揽收状态ID"].ToString().Trim();
            rtxtBeiZhu.Text = dtHuoYunDan.Rows[0]["备注"].ToString().Trim();
            decZongJinE = Convert.ToDecimal(txtYunFeiZongJia.Text);
            pnlKeHu.Visible = false;
            #endregion
            //根据订单信息dgv查询货物信息并绑定到DGV，如何给DGV里面的下拉框绑定数据
            #region 根据订单信息dgv查询货物信息并绑定到DGV，如何给DGV里面的下拉框绑定数据
            DataTable dtHuoYunDanMingXi = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectHuoYunDanMingXiByHuoYunDanID(HuoYunDanID).Tables[0]; 
            for (int i = 0; i < dtHuoYunDanMingXi.Rows.Count; i++)
            {
                dgvHuoWuList.Rows.Add();
                dgvHuoWuList.Rows[i].Cells["货物名称"].Value = dtHuoYunDanMingXi.Rows[i]["货物名称"].ToString();
                dgvHuoWuList.Rows[i].Cells["货运单明细ID"].Value = dtHuoYunDanMingXi.Rows[i]["货运单明细ID"].ToString();
                dgvHuoWuList.Rows[i].Cells["货物ID"].Value = dtHuoYunDanMingXi.Rows[i]["货物ID"].ToString();
                dgvHuoWuList.Rows[i].Cells["货物类别"].Value = dtHuoYunDanMingXi.Rows[i]["货物类别"].ToString();
                dgvHuoWuList.Rows[i].Cells["数量"].Value = dtHuoYunDanMingXi.Rows[i]["数量"].ToString();
                dgvHuoWuList.Rows[i].Cells["运费单价"].Value = dtHuoYunDanMingXi.Rows[i]["运费单价"].ToString();
                dgvHuoWuList.Rows[i].Cells["计量单位"].Value = dtHuoYunDanMingXi.Rows[i]["计量单位"].ToString();
                dgvHuoWuList.Rows[i].Cells["揽收否"].Value = dtHuoYunDanMingXi.Rows[i]["揽收否"].ToString();
                dgvHuoWuList.Rows[i].Cells["计费公式"].Value = dtHuoYunDanMingXi.Rows[i]["计费公式ID"];
            }
            dgvHuoWuList.Rows.Add();
            #endregion
        }
        #endregion 

        #region 查询托运方客户信息按钮点击事件
        private void btnChaXunTuoYunFang_Click(object sender, EventArgs e)
        {
            bolIfTuoYun = true;
            dgvKeHu.DataSource = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectKeHu(txtTuoYunFang.Text.Trim()).Tables[0];
            pnlKeHu.Visible = true;
        }
        #endregion 

        #region 查询收货方客户信息按钮点击事件
        private void btnShouHuoFang_Click(object sender, EventArgs e)
        { 
            bolIfTuoYun = false;
            dgvKeHu.DataSource = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectKeHu(TxtShouHuoFang.Text.Trim()).Tables[0];
            pnlKeHu.Visible = true;
        }
        #endregion 

        #region  双击客户信息dgv并根据触发者不同绑定到不同的客户信息 
        private void dgvKeHu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (bolIfTuoYun)
            {
                txtTuoYunFang.Text = dgvKeHu.CurrentRow.Cells["客户名称"].Value.ToString().Trim();
                txtTuoYunLianXiRen.Text = dgvKeHu.CurrentRow.Cells["联系人"].Value.ToString().Trim();
                txtTuoYunLianXiDianHua.Text = dgvKeHu.CurrentRow.Cells["联系电话"].Value.ToString().Trim();
                rTxtFaHuoDiZhi.Text = dgvKeHu.CurrentRow.Cells["联系地址"].Value.ToString().Trim();
                tuoYunFangID = Convert.ToInt32(dgvKeHu.CurrentRow.Cells["客户ID"].Value);
            }
            else
            {
                TxtShouHuoFang.Text = dgvKeHu.CurrentRow.Cells["客户名称"].Value.ToString().Trim();
                TxtShouHuoLianXiRen.Text = dgvKeHu.CurrentRow.Cells["联系人"].Value.ToString().Trim();
                txtShouHuoLianXiDianHua.Text = dgvKeHu.CurrentRow.Cells["联系电话"].Value.ToString().Trim();
                txtShouHuoDiZhi.Text = dgvKeHu.CurrentRow.Cells["联系地址"].Value.ToString().Trim();
                shouHuoFangID = Convert.ToInt32(dgvKeHu.CurrentRow.Cells["客户ID"].Value);
            }
            pnlKeHu.Visible = false;
        }
        #endregion

        #region 查询业务员信息按钮点击事件
        private void btnYeWuYuan_Click(object sender, EventArgs e)
        { 
            flagYuanGong = 0;
            dgvYuanGong.Visible = true;
        }
        #endregion

        #region 查询制单人信息按钮点击事件
        private void btnZhiDanRen_Click(object sender, EventArgs e)
        { 
            flagYuanGong = 1;
            dgvYuanGong.Visible = true;
        }
        #endregion

        #region 查询修单人信息按钮点击事件
        private void btnXiuDanRen_Click(object sender, EventArgs e)
        { 
            flagYuanGong = 2;
            dgvYuanGong.Visible = true;
        }
        #endregion

        #region 双击员工信息dgv并根据触发者不同绑定到不同的员工信息
        private void dgvYuanGong_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (flagYuanGong)
            {
                case 0:
                    {
                        txtYeWuYuan.Text = dgvYuanGong.CurrentRow.Cells["员工姓名"].Value.ToString().Trim();
                        yeWuYuanID = Convert.ToInt32(dgvYuanGong.CurrentRow.Cells["员工ID"].Value);
                    }
                    break;
                case 1:
                    {
                        txtzhiDanRen.Text = dgvYuanGong.CurrentRow.Cells["员工姓名"].Value.ToString().Trim();
                        zhiDanRenID = Convert.ToInt32(dgvYuanGong.CurrentRow.Cells["员工ID"].Value);
                    }
                    break;
                case 2:
                    {
                        txtXiuDanRen.Text = dgvYuanGong.CurrentRow.Cells["员工姓名"].Value.ToString().Trim();
                        xiuDanRenID = Convert.ToInt32(dgvYuanGong.CurrentRow.Cells["员工ID"].Value);
                    }
                    break;
                default:
                    break;
            }
            dgvYuanGong.Visible = false;
        }
        #endregion 

        #region 根据货物单价和数量计算货物总价
        private void dgvHuoWuList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    if (dgvHuoWuList.CurrentRow.Cells["数量"].Value != null &&
                   dgvHuoWuList.CurrentRow.Cells["运费单价"].Value != null &&
                   dgvHuoWuList.CurrentRow.Cells["货物名称"].Value != null)
                    {
                        decZongJinE -= Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["数量"].Value) *
                             Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["运费单价"].Value);
                        txtYunFeiZongJia.Text = decZongJinE.ToString();
                    }
                    if (dgvHuoWuList.CurrentRow.Cells["货运单明细ID"].Value != null)
                    {
                        arrDeleteMingXiID.Add(dgvHuoWuList.CurrentRow.Cells["货运单明细ID"].Value);
                    }

                    if (dgvHuoWuList.Rows[e.RowIndex].Cells["货物名称"].Value != null)
                        dgvHuoWuList.Rows.RemoveAt(e.RowIndex); 
                }
                if (e.ColumnIndex == 1)
                {
                    FRM_DingDanGuanLi_Update_SelectHuoWu myfrm = new FRM_DingDanGuanLi_Update_SelectHuoWu(this, e);
                    myfrm.ShowDialog();
                    dgvHuoWuList.BeginEdit(true);
                    dgvHuoWuList.EndEdit();
                }
            }
        }
        #endregion

        #region 在货物列表dgv中结束编辑时计算货物总价
        private void dgvHuoWuList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHuoWuList.CurrentRow.Cells["数量"].Value != null &&
                dgvHuoWuList.CurrentRow.Cells["运费单价"].Value != null &&
                dgvHuoWuList.CurrentRow.Cells["货物名称"].Value != null)
            {
                decZongJinE += Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["数量"].Value) *
                     Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["运费单价"].Value);
                txtYunFeiZongJia.Text = decZongJinE.ToString();
            }
        }
        #endregion

        #region 保存按钮，保存前验证数据完整性
        private void btnBaoCun_Update_Click(object sender, EventArgs e)
        {
            //保存单据
            //修改旧的货物
            //新增新的货物
            //删除被移除的货物 
            //保存单据
            int countDanJu = myDingDanGuanLi_Update.btnBaoCun_Click_UpdateDanJu
                (txtDingDanBianHao.Text,
                dtpJieDanShiJian.Value,
                yeWuYuanID,
                dtpSongDaShiJian.Value,
                tuoYunFangID,
                txtTiDanHao.Text,
                shouHuoFangID,
                rTxtFaHuoDiZhi.Text,
                txtShouHuoDiZhi.Text,
                Convert.ToInt32(cboJieSuanFangShi.SelectedValue),
                decZongJinE,
                rtxtBeiZhu.Text,
                zhiDanRenID,
                xiuDanRenID,
                Convert.ToInt32(cboJiJianWangDian.SelectedValue),
                Convert.ToInt32(cboShouHuoWangDian.SelectedValue),
                Convert.ToInt32(CboLanShouZhangTai.SelectedValue),
                HuoYunDanID
            );
            int countSuccess = 0;
            int countMingXi = 0;
            int countDelete = 0;
            if (countDanJu > 0)
            {
                //保存修改的明细
                foreach (DataGridViewRow dgvr in dgvHuoWuList.Rows)
                {
                    if (dgvr.Cells["货物ID"].Value != null &&
                   dgvr.Cells["数量"].Value != null &&
                   dgvr.Cells["计费公式"].Value != null &&
                   dgvr.Cells["运费单价"].Value != null)
                    {
                        countMingXi++;
                        if (dgvr.Cells["货运单明细ID"].Value != null)
                        {
                            countSuccess += myDingDanGuanLi_Update.btnBaoCun_Click_UpdateMingXi(
                                Convert.ToInt32(dgvr.Cells["货物ID"].Value),
                                Convert.ToDecimal(dgvr.Cells["数量"].Value),
                                Convert.ToInt32(dgvr.Cells["计费公式"].Value),
                                Convert.ToDecimal(dgvr.Cells["运费单价"].Value),
                                Convert.ToBoolean(dgvr.Cells["揽收否"].Value),
                                HuoYunDanID,
                                Convert.ToInt32(dgvr.Cells["货运单明细ID"].Value) );
                        }
                        else
                        {
                            //新增新的明细
                            countSuccess += myDingDanGuanLi_Update.btnBaoCun_Click_InsertDanJuMingXi(
                                Convert.ToInt32(dgvr.Cells["货物ID"].Value),
                                Convert.ToDecimal(dgvr.Cells["数量"].Value),
                                Convert.ToInt32(dgvr.Cells["计费公式"].Value),
                                Convert.ToDecimal(dgvr.Cells["运费单价"].Value),
                                Convert.ToBoolean(dgvr.Cells["揽收否"].Value),
                                HuoYunDanID
                            );
                        }
                    }
                }
                //删除旧的明细
                for (int i = 0; i < arrDeleteMingXiID.Count; i++)
                {
                    countDelete += myDingDanGuanLi_Update.btnBaoCun_Click_DeleteDanJuMingXi(Convert.ToInt32(arrDeleteMingXiID[i]));
                }
            }
            if (countMingXi == countSuccess && countDelete == arrDeleteMingXiID.Count && countSuccess > 0 && countDelete > 0)
            {
                MessageBox.Show("修改成功！");
                btnChongZhi_Click(null, null);
            }
            else
            {
                if (arrDeleteMingXiID.Count > 0)
                {
                    MessageBox.Show("修改失败！");
                }
                else
                {
                    MessageBox.Show("修改成功！");
                }
            }
        }
        #endregion

        #region 重置按钮，清空客户输入初始化界面数据
        private void btnChongZhi_Click(object sender, EventArgs e)
        {
            dgvHuoWuList.Rows.Clear();
            arrDeleteMingXiID.Clear();
            FRM_DingDanGuanLi_Update_Load(null, null);
        }
        #endregion

        #region 返回按钮，点击返回主界面
        private void btnFanHui_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 单元格编辑事件，设置行标题定义行号
        private void dgvHuoWuList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvHuoWuList.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        } 
        #endregion

        #region 单元格编辑事件，设置行标题定义行号
        private void dgvKeHu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow CurrentRow = this.dgvKeHu.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        }
        #endregion

        #region 根据用户输入客户名称搜索是否存在客户信息，不存在则提示新增客户信息，并弹出新增客户窗体
        private void txtTuoYunFang_TextChanged(object sender, EventArgs e)
        {
            bolIfTuoYun = true;
            dgvKeHu.DataSource = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectKeHu(txtTuoYunFang.Text.Trim()).Tables[0];
            pnlKeHu.Visible = true;
        }
        #endregion

        #region 根据用户输入客户名称搜索是否存在客户信息，不存在则提示新增客户信息，并弹出新增客户窗体
        private void TxtShouHuoFang_TextChanged(object sender, EventArgs e)
        {
            bolIfTuoYun = false;
            dgvKeHu.DataSource = myDingDanGuanLi_Update.frmDingDanGuanLi_Update_SelectKeHu(TxtShouHuoFang.Text.Trim()).Tables[0];
            pnlKeHu.Visible = true;
        }
        #endregion

        #region 启动计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlKeHu.Visible = false;
            timer1.Enabled = false;
        }
        private void toolStrip2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void dgvKeHu_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void dgvKeHu_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void toolStrip2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        #endregion

        #region 计算运费总价
        private void dgvHuoWuList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvHuoWuList.CurrentRow.Cells["数量"].Value != null &&
              dgvHuoWuList.CurrentRow.Cells["运费单价"].Value != null &&
              dgvHuoWuList.CurrentRow.Cells["货物名称"].Value != null)
            {
                decZongJinE -= Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["数量"].Value) *
                     Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["运费单价"].Value);
            }
        }
        #endregion 

    }
}
