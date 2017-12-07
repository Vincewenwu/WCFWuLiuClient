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
    public partial class FRM_DingDanGuanLi_Insert : Form
    {
        #region 构造方法
        public FRM_DingDanGuanLi_Insert()
        {
            InitializeComponent();
        }
        #endregion

        #region 定义参数
        BLL物流管理系统.订单管理.DingDanGuanLi_Insert.DingDanGuanLi_InsertClient
          myDingDanGuanLi_Insert = new BLL物流管理系统.订单管理.DingDanGuanLi_Insert.DingDanGuanLi_InsertClient();
        bool 是否托运方 = true;
        string strDanJuShu;
        public decimal 运费总价 = 0;
        int 员工标记 = 0;//0业务员，1制单人，2修单人
        int 托运方ID = 0;
        int 收货方ID = 0;
        int 业务员_员工ID = 0;
        int 修单人_员工ID = 0;
        int 制单人_员工ID = 0;
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

        #region Load事件，绑定网点信息、结算方式、揽收状态、计费方式、员工信息、货物列表
        private void FRM_DingDanGuanLi_Insert_Load(object sender, EventArgs e)
        {
            #region 绑定数据
            //绑定寄件网点下拉框
            DataTable dt = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectWangDian().Tables[0];
            cboJiJianWangDian.DataSource = dt;
            cboJiJianWangDian.DisplayMember = "网点名称";
            cboJiJianWangDian.ValueMember = "网点ID";
            //绑定收货网点下拉框
            cboShouHuoWangDian.DataSource = dt.Copy();
            cboShouHuoWangDian.DisplayMember = "网点名称";
            cboShouHuoWangDian.ValueMember = "网点ID";
            //绑定结算方式下拉框
            cboJieSuanFangShi.DataSource = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectJieSuanFangShi().Tables[0];
            cboJieSuanFangShi.DisplayMember = "结算方式";
            cboJieSuanFangShi.ValueMember = "结算方式ID";
            //绑定货物揽收状态下拉框
            cboLanShouZhangTai.DataSource = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectCboLanShouZhuangTai().Tables[0];
            cboLanShouZhangTai.DisplayMember = "货物揽收状态";
            cboLanShouZhangTai.ValueMember = "货物揽收状态ID";
            //绑定计费方式下拉框
            计费公式.DataSource = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectJiFeiGongShi().Tables[0];
            计费公式.DisplayMember = "计费公式";
            计费公式.ValueMember = "计费公式ID";
            //绑定员工信息DGV
            dgvYuanGong.DataSource = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectYuanGong().Tables[0];
            //在dgv货物信息列表中添加一个空行，本dgv默认为不自动添加行
            dgvHuoWuList.Rows.Add();
            this.dtpSongDaShiJian.Value = this.dtpJieDanShiJian.Value.AddDays(1);
            #endregion
        }
        #endregion

        #region 查询托运方客户信息按钮点击事件
        private void btnChaXunTuoYunFang_Click(object sender, EventArgs e)
        {
            是否托运方 = true;
            string 客户全称 = txtTuoYunFang.Text.Trim();
            dgvKeHu.DataSource = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectKeHu(客户全称).Tables[0];
            pnlKeHu.Visible = true;
        }
        #endregion

        #region 查询收货方客户信息按钮点击事件
        private void btnShouHuoFang_Click(object sender, EventArgs e)
        {
            是否托运方 = false;
            string 客户全称 = txtShouHuoFang.Text.Trim();
            dgvKeHu.DataSource = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectKeHu(客户全称).Tables[0];
            pnlKeHu.Visible = true;
        }
        #endregion

        #region 双击客户信息dgv并根据触发者不同绑定到不同的客户信息 
        private void dgvKeHu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (是否托运方)
            {
                txtTuoYunFang.Text = dgvKeHu.CurrentRow.Cells["客户名称"].Value.ToString().Trim();
                txtTuoYunLianXiRen.Text = dgvKeHu.CurrentRow.Cells["联系人"].Value.ToString().Trim();
                txtTuoYunLianXiDianHua.Text = dgvKeHu.CurrentRow.Cells["联系电话"].Value.ToString().Trim();
                rTxtFaHuoDiZhi.Text = dgvKeHu.CurrentRow.Cells["联系地址"].Value.ToString().Trim();
                托运方ID = Convert.ToInt32(dgvKeHu.CurrentRow.Cells["客户ID"].Value);
            }
            else
            {
                txtShouHuoFang.Text = dgvKeHu.CurrentRow.Cells["客户名称"].Value.ToString().Trim();
                txtShouHuoLianXiRen.Text = dgvKeHu.CurrentRow.Cells["联系人"].Value.ToString().Trim();
                txtShouHuoLianXiDianHua.Text = dgvKeHu.CurrentRow.Cells["联系电话"].Value.ToString().Trim();
                rtxtShouHuoDiZhi.Text = dgvKeHu.CurrentRow.Cells["联系地址"].Value.ToString().Trim();
                收货方ID = Convert.ToInt32(dgvKeHu.CurrentRow.Cells["客户ID"].Value);
            }
            pnlKeHu.Visible = false;
        }
        #endregion

        #region 查询业务员信息按钮点击事件
        private void btnYeWuYuan_Click(object sender, EventArgs e)
        {
            员工标记 = 0;
            dgvYuanGong.Visible = true;
        }
        #endregion

        #region 查询制单人信息按钮点击事件
        private void btnZhiDanRen_Click(object sender, EventArgs e)
        {
            员工标记 = 1;
            dgvYuanGong.Visible = true;
        }
        #endregion

        #region 查询修单人信息按钮点击事件
        private void btnXiuDanRen_Click(object sender, EventArgs e)
        {
            员工标记 = 2;
            dgvYuanGong.Visible = true;
        }
        #endregion

        #region 根据单据数 日期生成订单编号
        public string ShengChengDanHao()
        {
            //查询当前最大单据号
            strDanJuShu = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectHuodanhao().Tables[0].Rows[0][0].ToString().Trim();
            //判断最大单据号长度，根据单据号长度进行拼接
            switch (strDanJuShu.Length)
            {
                case 1:
                    strDanJuShu = "000" + strDanJuShu;
                    break;
                case 2:
                    strDanJuShu = "00" + strDanJuShu;
                    break;
                case 3:
                    strDanJuShu = "0" + strDanJuShu;
                    break;
                case 4:
                    strDanJuShu = "" + strDanJuShu;
                    break;
                default:
                    break;
            }
            //生成订单单据号规则：“DD+年+月+日+当前单据数”
            DateTime dtnNow = DateTime.Now;
            string strYear = dtnNow.Year.ToString().Trim();
            string strMouth = dtnNow.Month.ToString().Trim();
            strMouth = (strMouth.Length == 1 ? "0" + strMouth : strMouth);
            string strDay = dtnNow.Day.ToString().Trim();
            strDay = (strDay.Length == 1 ? "0" + strDay : strDay);
            return "DD" + strYear + strMouth + strDay + strDanJuShu;
        }
        #endregion 

        #region 双击员工信息dgv并根据触发者不同绑定到不同的员工信息
        private void dgvYuanGong_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (员工标记)
            {
                case 0:
                    {
                        txtYeWuYuan.Text = dgvYuanGong.CurrentRow.Cells["员工姓名"].Value.ToString().Trim();
                        业务员_员工ID = Convert.ToInt32(dgvYuanGong.CurrentRow.Cells["员工ID"].Value);
                    }
                    break;
                case 1:
                    {
                        txtzhiDanRen.Text = dgvYuanGong.CurrentRow.Cells["员工姓名"].Value.ToString().Trim();
                        制单人_员工ID = Convert.ToInt32(dgvYuanGong.CurrentRow.Cells["员工ID"].Value);
                    }
                    break;
                case 2:
                    {
                        txtXiuDanRen.Text = dgvYuanGong.CurrentRow.Cells["员工姓名"].Value.ToString().Trim();
                        修单人_员工ID = Convert.ToInt32(dgvYuanGong.CurrentRow.Cells["员工ID"].Value);
                    }
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
                        运费总价 -= Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["数量"].Value) *
                             Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["运费单价"].Value);
                        txtYunFeiZongJia.Text = 运费总价.ToString();
                    }
                    if (dgvHuoWuList.Rows.Count == 1)
                    {
                        dgvHuoWuList.Rows.RemoveAt(e.RowIndex);
                        dgvHuoWuList.Rows.Add();
                    }
                    else
                    {
                        dgvHuoWuList.Rows.RemoveAt(e.RowIndex);
                    }
                }
                if (e.ColumnIndex == 1)
                {
                    FRM_DingDanGuanLi_Insert_SelectHuoWu myfrm =
                        new FRM_DingDanGuanLi_Insert_SelectHuoWu(this, e.RowIndex);
                    myfrm.ShowDialog();
                    dgvHuoWuList.EndEdit();
                    txtYunFeiZongJia.Text = 运费总价.ToString();
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
                运费总价 += Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["数量"].Value) *
                     Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["运费单价"].Value);
                txtYunFeiZongJia.Text = 运费总价.ToString();
            }
        }
        #endregion

        #region 保存按钮，保存前验证数据完整性
        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            //新增单据，并返回该单据的ID
            //新增明细 
            int zuiDaDanHao = myDingDanGuanLi_Insert.btnBaoCun_Click_SelectZuiDaDanHao();
            string strZuiDaDanHao = zuiDaDanHao.ToString();

            string 单据编号 = "";
            单据编号 = DateTime.Now.Year.ToString() +
                (DateTime.Now.Month > 9 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month.ToString()) +
                (DateTime.Now.Day > 9 ? DateTime.Now.Day.ToString() : "0" + DateTime.Now.Day.ToString());

            for (int i = strZuiDaDanHao.Length; i < 5; i++)
            {
                strZuiDaDanHao = "0" + strZuiDaDanHao;
            }
            单据编号 = "DD" + 单据编号 + strZuiDaDanHao;
            txtDingDanBianHao.Text = 单据编号;
            txtTiDanHao.Text = 单据编号.Replace("DD", "TD");
            //新增订单单据，并返回该单据ID
            /*单据编号, 接单时间, 业务员_员工ID, 要求送达时间, 
				托运方ID, 提单号, 收货方ID, 寄件地址, 收货地址,
             * 结算方式ID, 运费总价, 
				备注, 制单人_员工ID, 修单人_员工ID, 寄件网点ID,
             * 收货网点ID, 
                      货物揽收状态ID*/

            DateTime 接单时间 = dtpJieDanShiJian.Value;
            DateTime 要求送达时间 = dtpSongDaShiJian.Value;
            string 提单号 = txtTiDanHao.Text;
            string 寄件地址 = rTxtFaHuoDiZhi.Text;
            string 收货地址 = rtxtShouHuoDiZhi.Text;
            int 结算方式ID = Convert.ToInt32(cboJieSuanFangShi.SelectedValue);
            string 备注 = rtxtBeiZhu.Text;
            int 寄件网点ID = Convert.ToInt32(cboJiJianWangDian.SelectedValue);
            int 收货网点ID = Convert.ToInt32(cboShouHuoWangDian.SelectedValue);
            int 货物揽收状态ID = Convert.ToInt32(cboLanShouZhangTai.SelectedValue);
            int 货运单ID = myDingDanGuanLi_Insert.btnBaoCun_Click_InsertDanJu(
                单据编号,
                接单时间,
                业务员_员工ID,
                要求送达时间,
                托运方ID,
                提单号,
                收货方ID,
                寄件地址,
                收货地址,
                结算方式ID,
                运费总价,
                备注,
                制单人_员工ID,
                修单人_员工ID,
                寄件网点ID,
                收货网点ID,
                货物揽收状态ID
                );
            //新增明细
            int CountSuccess = 0;
            int CountMingXi = 0;
            foreach (DataGridViewRow dgvr in dgvHuoWuList.Rows)
            {
                /*货物ID, 数量, 计费公式ID, 运费单价,
                 * 揽收否, 货运单ID*/
                if (dgvr.Cells["货物ID"].Value != null &&
                    dgvr.Cells["数量"].Value != null &&
                    dgvr.Cells["计费公式"].Value != null &&
                    dgvr.Cells["运费单价"].Value != null)
                {
                    CountMingXi++;
                    int 货物ID = Convert.ToInt32(dgvr.Cells["货物ID"].Value);
                    decimal 数量 = Convert.ToDecimal(dgvr.Cells["数量"].Value);
                    int 计费公式ID = Convert.ToInt32(dgvr.Cells["计费公式"].Value);
                    decimal 运费单价 = Convert.ToDecimal(dgvr.Cells["运费单价"].Value);
                    bool 揽收否 = Convert.ToBoolean(dgvr.Cells["揽收否"].Value);
                    CountSuccess += myDingDanGuanLi_Insert.btnBaoCun_Click_InsertMingXi(
                        货物ID,
                        数量,
                        计费公式ID,
                        运费单价,
                        揽收否,
                        货运单ID
                    );
                }
            }

            if (CountMingXi == CountSuccess && CountSuccess > 0)
            {
                MessageBox.Show("新增成功");
            }
            else
            {
                MessageBox.Show("新增失败");
            }
        }
        #endregion

        #region 清空按钮，清空客户输入初始化界面数据
        private void button1_Click(object sender, EventArgs e)//重置按钮，清空数据
        {
            txtTuoYunFang.Text = "";
            txtTuoYunLianXiRen.Text = "";
            txtTuoYunLianXiDianHua.Text = "";
            rTxtFaHuoDiZhi.Text = "";
            txtShouHuoFang.Text = "";
            txtShouHuoLianXiRen.Text = "";
            txtShouHuoLianXiDianHua.Text = "";
            rtxtShouHuoDiZhi.Text = "";
            cboJiJianWangDian.SelectedIndex = 1;
            cboShouHuoWangDian.SelectedIndex = 1;
            cboJieSuanFangShi.SelectedIndex = 1;
            cboLanShouZhangTai.SelectedIndex = 1;

            txtYeWuYuan.Text = PublicStaticObject.YuanGongMingCheng;
            txtzhiDanRen.Text = PublicStaticObject.YuanGongMingCheng;
            txtXiuDanRen.Text = PublicStaticObject.YuanGongMingCheng;

            dgvHuoWuList.Rows.Clear();
            dgvHuoWuList.Rows.Add();
            txtYunFeiZongJia.Text = "";
            rtxtBeiZhu.Text = "";
        }
        #endregion

        #region 返回按钮，点击返回主界面
        private void btnFanHui_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 根据用户输入客户名称搜索是否存在客户信息，不存在则提示新增客户信息，并弹出新增客户窗体
        private void txtTuoYunFang_Leave(object sender, EventArgs e)
        {
            if (dgvKeHu.Rows.Count <= 0)
            {
                if (MessageBox.Show("没有该客户信息，是否新增？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    FRM_DingDanGuanLi_Insert_InsertKeHu myfrm =
                        new FRM_DingDanGuanLi_Insert_InsertKeHu();
                    myfrm.ShowDialog();
                }
            }
        }
        #endregion
          
        #region 根据托运方名称搜索客户信息
        private void txtTuoYunFang_TextChanged(object sender, EventArgs e)
        {
            是否托运方 = true;
            string 客户全称 = txtTuoYunFang.Text.Trim();
            dgvKeHu.DataSource = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectKeHu(客户全称).Tables[0];
            pnlKeHu.Visible = true;
        }
        #endregion

        #region 客户信息dgv鼠标离开事件
        private void dgvKeHu_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        #endregion

        #region 鼠标离开员工dgv时隐藏员工dgv
        private void dgvYuanGong_MouseLeave(object sender, EventArgs e)
        {
            dgvYuanGong.Visible = false;
        }
        #endregion

        #region 定时隐藏
        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlKeHu.Visible = false;
            timer1.Enabled = false;
        }
        #endregion

        #region 启动计时器
        private void toolStrip2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void toolStrip2_MouseLeave(object sender, EventArgs e)
        {

            timer1.Enabled = true;
        }

        private void dgvKeHu_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        } 
        #endregion

        #region 计算运费总价
        private void dgvHuoWuList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvHuoWuList.CurrentRow.Cells["数量"].Value != null &&
               dgvHuoWuList.CurrentRow.Cells["运费单价"].Value != null &&
               dgvHuoWuList.CurrentRow.Cells["货物名称"].Value != null)
            {
                运费总价 -= Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["数量"].Value) *
                     Convert.ToDecimal(dgvHuoWuList.CurrentRow.Cells["运费单价"].Value);
            }
        }
        #endregion 
    } 
}
