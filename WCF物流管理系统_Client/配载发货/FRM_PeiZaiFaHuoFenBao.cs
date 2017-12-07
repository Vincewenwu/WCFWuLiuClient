using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.配载发货
{
    public partial class FRM_PeiZaiFaHuoFenBao : Form
    { 
        #region 构造方法
        public FRM_PeiZaiFaHuoFenBao()
        {
            InitializeComponent();
        }
        #endregion

        #region 定义参数
        BLL物流管理系统.配载发货.FRM_PeiZaiFaHuoFenBao.FRM_PeiZaiFaHuoFenBaoClient myFRM_PeiZaiFaHuoFenBaoClient 
            = new BLL物流管理系统.配载发货.FRM_PeiZaiFaHuoFenBao.FRM_PeiZaiFaHuoFenBaoClient(); 
        #endregion

        #region Load加载托运方信息、收货方信息
        private void FRM_PeiZaiFaHuo_Load(object sender, EventArgs e)
        { 
            this.Left = PublicStaticObject.MainLeft;
            this.Top = PublicStaticObject.MainTop;
            this.Width = PublicStaticObject.MainWidth;
            this.Height = PublicStaticObject.MainHeight;

            cboTuoYunFang.DataSource = myFRM_PeiZaiFaHuoFenBaoClient.FRM_PeiZaiFaHuo_Load_SelectKeHu().Tables[0];
            cboTuoYunFang.DisplayMember = "客户全称";
            cboTuoYunFang.ValueMember = "客户ID";

            cboShouHuoFang.DataSource = myFRM_PeiZaiFaHuoFenBaoClient.FRM_PeiZaiFaHuo_Load_SelectKeHu().Tables[0];
            cboShouHuoFang.DisplayMember = "客户全称";
            cboShouHuoFang.ValueMember = "客户ID";
            ///btnChaXun_Select_Click_SelectDingDanXinXi是不定条件查询方法，条件为空即查询所有数据
            dgvHuoYunDan.DataSource = myFRM_PeiZaiFaHuoFenBaoClient.btnChaXun_Select_Click_SelectDingDanXinXi().Tables[0];
            dgvHuoYunDan = PublicStaticMothd.SetDgv(dgvHuoYunDan);
        }
        #endregion

        #region 菜单栏按钮修改分包单点击事件
        private void tsbXiuGaiFenBaoDan_Update_Click(object sender, EventArgs e)
        {
            if (dgvHuoYunDan.CurrentRow != null)
            {
                int int货运单ID = Convert.ToInt32(dgvHuoYunDan.CurrentRow.Cells["货运单ID"].Value.ToString());
                string str订单编号 = dgvHuoYunDan.CurrentRow.Cells["单据编号"].Value.ToString().Trim();
                string str寄件网点 = dgvHuoYunDan.CurrentRow.Cells["寄件网点"].Value.ToString().Trim();
                string str收货网点 = dgvHuoYunDan.CurrentRow.Cells["收货网点"].Value.ToString().Trim();
                PublicStaticObject.Pub_FRM_PeiZaiFaHuo_FenBao_Update = new 配载发货.FRM_PeiZaiFaHuoFenBao_Update
                    (int货运单ID, str订单编号, str寄件网点, str收货网点);
                PublicStaticObject.Pub_FRM_PeiZaiFaHuo_FenBao_Update.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选中一条订单信息！");
            }

        }
        #endregion

        #region 菜单栏按钮关闭点击事件
        private void tsbGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 按钮查询点击事件
        private void btnChaXun_Select_Click(object sender, EventArgs e)
        {
            string 动态条件 ="";
            if (chkRiQi.Checked)
            {
                动态条件 += " and ( PW_货运单表.接单时间 between '"
                    +dtpKaiShi.Value.ToShortDateString()
                    +" 00:00:00.000' and '" 
                    + dtpJieShu.Value.ToShortDateString() 
                    +" 23:59:59.999' )";
            }
            if (chkShouHuoFang.Checked)
            {
                动态条件 += " and PW_货运单表.收货方ID = " + cboShouHuoFang.SelectedValue.ToString();
            }
            if (chkTuoYunFang.Checked)
            {
                动态条件 += " and PW_货运单表.托运方ID = " + cboTuoYunFang.SelectedValue.ToString() ;
            }
            if (chkDingDanHao.Checked)
            {
                动态条件 += " and PW_货运单表.单据编号 = " + txtDingDanHao.Text ;
            }
            dgvHuoYunDan.DataSource = myFRM_PeiZaiFaHuoFenBaoClient.
                btnChaXun_Select_Click_SelectDingDanXinXi_DongTai(动态条件).Tables[0];
          
            dgvHuoYunDan = PublicStaticMothd.SetDgv(dgvHuoYunDan);
            if (dgvHuoYunDan.RowCount <= 0)
            {
                ((DataTable)dgvMingXi.DataSource).Rows.Clear();
                ((DataTable)dgvFenBao.DataSource).Rows.Clear();
                MessageBox.Show("无符合当前条件的记录，请改变条件后重新查询！");
            }
        }
        #endregion

        #region 货运单dgv双击选择
        private void dgvHuoYunDan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHuoYunDan.CurrentRow != null)
            {
                int int货运单ID = Convert.ToInt32(dgvHuoYunDan.CurrentRow.Cells["货运单ID"].Value);
                dgvMingXi.DataSource = myFRM_PeiZaiFaHuoFenBaoClient.
                    dgvHuoYunDan_SelectionChanged_SelectDingDanMingXi(int货运单ID).Tables[0];
                dgvMingXi = PublicStaticMothd.SetDgv(dgvMingXi);
                if (dgvMingXi.Rows.Count < 1)
                {
                     ((DataTable)dgvFenBao.DataSource).Rows.Clear();
                }
            }
        }
        #endregion

        #region 货运单明细dgv双击选择
        private void dgvMingXi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMingXi.Rows.Count > 0)
            {
                if (dgvMingXi.CurrentRow != null)
                {
                    int int货运单明细ID = Convert.ToInt32(dgvMingXi.CurrentRow.Cells["货运单明细ID"].Value);
                    dgvFenBao.DataSource = myFRM_PeiZaiFaHuoFenBaoClient.
                        dgvMingXi_SelectionChanged_SelectFenBao(int货运单明细ID).Tables[0];
                    dgvFenBao = PublicStaticMothd.SetDgv(dgvFenBao);
                }
            }
            else
            {
                ((DataTable)dgvFenBao.DataSource).Rows.Clear(); 
            }
        }
        #endregion 
    }
}
