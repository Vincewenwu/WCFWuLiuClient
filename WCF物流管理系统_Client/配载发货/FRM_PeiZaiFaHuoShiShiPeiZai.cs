using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WCF物流管理系统_Client.配载发货
{
    public partial class FRM_PeiZaiFaHuoShiShiPeiZai : Form
    {
        #region 定义变量
        FRM_PeiZaiFaHuoPeiZai_Insert Frm_Insert;
        FRM_PeiZaiFaHuoPeiZai_Update Frm_Update;
        bool bolXinZeng = true;//是否新增界面
        BLL物流管理系统.配载发货.PeiZaiFaHuo_ShiShiPeiZai.PeiZaiFaHuo_ShiShiPeiZaiClient myPeiZaiFaHuo_ShiShiPeiZaiClient 
            = new BLL物流管理系统.配载发货.PeiZaiFaHuo_ShiShiPeiZai.PeiZaiFaHuo_ShiShiPeiZaiClient();
        BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Insert.PeiZaiFaHuoPeiZai_InsertClient myPeiZaiFaHuoPeiZai_InsertClient
            = new BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Insert.PeiZaiFaHuoPeiZai_InsertClient();
        #endregion

        #region 重载构造方法
        //重载构造函数，通过构造函数初始化窗体对象，获取父窗体的值
        public FRM_PeiZaiFaHuoShiShiPeiZai(FRM_PeiZaiFaHuoPeiZai_Update frm)
        {
            Frm_Update = frm;
            bolXinZeng =false;
            InitializeComponent();
        }
        public FRM_PeiZaiFaHuoShiShiPeiZai(FRM_PeiZaiFaHuoPeiZai_Insert frm)
        {
            Frm_Insert = frm;
            bolXinZeng = true;
            InitializeComponent();
        }
        #endregion

        #region Load事件加载始发网点、目的网点、揽收状态、分包dgv
        private void FRM_PeiZaiFaHuoShiShiPeiZai_Load(object sender, EventArgs e)
        {
            this.dgvFenBao = PublicStaticMothd.SetDgv(dgvFenBao);
            dgvFenBao.ReadOnly = false;
            #region 查询绑定下拉框
            dgvFenBao.RowHeadersVisible = false;
            //绑定始发网点下拉框
            DataTable dtQiShiWangDian = myPeiZaiFaHuo_ShiShiPeiZaiClient.frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboWiangDian().Tables[0];
            cboShiFaWangDian.DataSource = dtQiShiWangDian;
            cboShiFaWangDian.DisplayMember = "网点名称";
            cboShiFaWangDian.ValueMember = "网点ID";
            //绑定揽收状态下拉框
            DataTable dtLanShouZhuangTai = myPeiZaiFaHuo_ShiShiPeiZaiClient.frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboLanShouZhuangTai().Tables[0];
            cboDingDanZhuangTai.DataSource = dtLanShouZhuangTai;
            cboDingDanZhuangTai.DisplayMember = "货物揽收状态";
            cboDingDanZhuangTai.ValueMember = "货物揽收状态ID";
            //绑定目的网点下拉框
            DataTable dtMuDiWangDian = myPeiZaiFaHuo_ShiShiPeiZaiClient.frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboWiangDian().Tables[0];
            cboMuDiWangDian.DataSource = dtMuDiWangDian;
            cboMuDiWangDian.DisplayMember = "网点名称";
            cboMuDiWangDian.ValueMember = "网点ID";
            //加载分包dgv
            DataTable dtLoadFenBao = myPeiZaiFaHuo_ShiShiPeiZaiClient.frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBao().Tables[0];
            dgvFenBao.DataSource = dtLoadFenBao;
            #endregion
        }
        #endregion
         
        #region 查询条件查询货运单明细和分包
        private void btnChaXun_Click(object sender, EventArgs e)
        {
            string DingDanbianHao = txtDingDanBianHao.Text.ToString();
            DateTime QiShiShiJian = dtpQiShiShiJian.Value;
            DateTime JieShuShiJian = dtpJieZhiShiJian.Value;
            int ShiFaWangDianID = Convert.ToInt32(cboShiFaWangDian.SelectedValue);
            int MuDiWangDianID = Convert.ToInt32(cboMuDiWangDian.SelectedValue);
            int ZhuangTaiID = Convert.ToInt32(cboDingDanZhuangTai.SelectedValue);
            if (chkDingDanBianHao.Checked == false)
            {
                DingDanbianHao = "";
            }
            if (chkQiShiShiJian.Checked == false)
            {
                QiShiShiJian = Convert.ToDateTime("1991-09-13");
            }
            if (chkJieShuShiJian.Checked == false)
            {
                JieShuShiJian = Convert.ToDateTime("1991-09-13");
            }
            if (chkShiFaWangDian.Checked == false)
            {
                ShiFaWangDianID = 0;
            }
            if (chkMuDiWangDian.Checked == false)
            {
                MuDiWangDianID = 0;
            }
            if (chkDinDanZhuangTai.Checked == false)
            {
                ZhuangTaiID = 0;
            }
            DataTable dtFenBaoPeiZai = myPeiZaiFaHuo_ShiShiPeiZaiClient.frmPeiZaiFaHuo_ShiShiPeiZai_SelectPeiZaiFenBao(DingDanbianHao, ShiFaWangDianID, MuDiWangDianID, ZhuangTaiID, QiShiShiJian, JieShuShiJian).Tables[0];
            dgvFenBao.DataSource = dtFenBaoPeiZai;
        }
        #endregion

        #region 菜单栏重置按钮点击事件
        private void tsbChongZhi_Click(object sender, EventArgs e)
        {
            cboShiFaWangDian.SelectedIndex = 0;
            cboDingDanZhuangTai.SelectedIndex = 0;
            cboMuDiWangDian.SelectedIndex = 0;
            DataTable dtLoadFenBao = myPeiZaiFaHuo_ShiShiPeiZaiClient.frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBao().Tables[0];
            dgvFenBao.DataSource = dtLoadFenBao;
            chkDingDanBianHao.Checked = false;
            chkQiShiShiJian.Checked = false; 
            chkJieShuShiJian.Checked = false; 
            chkShiFaWangDian.Checked = false; 
            chkMuDiWangDian.Checked = false;
            chkDinDanZhuangTai.Checked = false;
            txtDingDanBianHao.Text = "";
        }
        #endregion

        #region 菜单栏返回按钮点击事件
        private void tsbFanHui_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 菜单栏确定按钮点击事件
        private void tsbQueDing_Click(object sender, EventArgs e)
        {
            dgvFenBao.EndEdit();
            int 选中行数 = 0;
            int 锁定成功行数 = 0;
            foreach(DataGridViewRow dgvr in dgvFenBao.Rows)
            {
                bool 是否选中 = (bool)dgvr.Cells["选择"].FormattedValue;
                if(是否选中)
                {
                    选中行数++;
                    if (bolXinZeng)
                    {
                        int rowIndex = Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows.Add();
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["分包ID"].Value = dgvr.Cells["分包ID"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["货运单明细ID"].Value = dgvr.Cells["货运单明细ID"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["货物名称"].Value = dgvr.Cells["货物名称"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["计量单位"].Value = dgvr.Cells["计量单位"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["分包数量"].Value = dgvr.Cells["分包数量"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["运费单价"].Value = dgvr.Cells["运费单价"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["货物类别"].Value = dgvr.Cells["货物类别"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["寄件网点"].Value = dgvr.Cells["寄件网点"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["目的网点"].Value = dgvr.Cells["目的网点"].Value;
                        Frm_Insert.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["单据编号"].Value = dgvr.Cells["单据编号"].Value;
                    }
                    else
                    {
                        int rowIndex = Frm_Update.dgvPeiZaiFaHuoMingXi.Rows.Add();
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["分包ID"].Value = dgvr.Cells["分包ID"].Value;
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["货物名称"].Value = dgvr.Cells["货物名称"].Value;
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["计量单位"].Value = dgvr.Cells["计量单位"].Value;
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["分包数量"].Value = dgvr.Cells["分包数量"].Value;
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["运费单价"].Value = dgvr.Cells["运费单价"].Value;
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["货物类别"].Value = dgvr.Cells["货物类别"].Value;
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["寄件网点"].Value = dgvr.Cells["寄件网点"].Value;
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["目的网点"].Value = dgvr.Cells["目的网点"].Value;
                        Frm_Update.dgvPeiZaiFaHuoMingXi.Rows[rowIndex].Cells["单据编号"].Value = dgvr.Cells["单据编号"].Value;
                    }
                    int 分包ID = (int)dgvr.Cells["分包ID"].Value;
                    锁定成功行数 += myPeiZaiFaHuoPeiZai_InsertClient.frmPeiZaiFaHuo_Insert_LockFenBaoSuoDing(分包ID);
                }
            }
            MessageBox.Show("已选中" + 选中行数 + "行数据，成功添加" + 锁定成功行数 + "行，被占用" + (选中行数 - 锁定成功行数) + "行！");
            if (选中行数 == 锁定成功行数 && 选中行数 > 0)
            {
                this.Close();
            }
        }
        #endregion  
    }
}
