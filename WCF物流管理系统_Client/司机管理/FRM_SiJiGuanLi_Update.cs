using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.司机管理
{
    public partial class FRM_SiJiGuanLi_Update : Form
    {
        DataGridViewRow DGVR;
        public FRM_SiJiGuanLi_Update(DataGridViewRow dgvr)
        {
            DGVR = dgvr;
            InitializeComponent();
        }

        BLL物流管理系统.司机管理.BLL_FRM_SiJiGuanLi_Update.BLL_FRM_SiJiGuanLi_UpdateClient BLL_FRM_SiJiGuanLi_Update =
            new BLL物流管理系统.司机管理.BLL_FRM_SiJiGuanLi_Update.BLL_FRM_SiJiGuanLi_UpdateClient();

        private void FRM_SiJiGuanLi_Update_Load(object sender, EventArgs e)
        {
            bool b = 用户权限管理.authCheck.checkAuthByType(this, System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!b) { MessageBox.Show("没有该权限，请联系管理员！"); this.Close(); return; }
            cboZhunJiaCheXing.DataSource = BLL_FRM_SiJiGuanLi_Update.FRM_SiJiGuanLi_Load_Update_ChaXunZhunJiaCheXin().Tables[0];
            cboZhunJiaCheXing.DisplayMember = "准驾车型名称";
            cboZhunJiaCheXing.ValueMember = "准驾车型ID";

            txtSiJiMingCheng.Text = DGVR.Cells["c司机名称"].Value.ToString();
            txtLianXiDiZhi.Text = DGVR.Cells["c联系地址"].Value.ToString();
            txtLianXiDianHua.Text = DGVR.Cells["c联系电话"].Value.ToString();
            txtShenFenZhengHao.Text = DGVR.Cells["c身份证号"].Value.ToString();
            txtJiaShiZhengHao.Text = DGVR.Cells["c驾驶证号"].Value.ToString();
            txtJiGouZuZhi.Text = DGVR.Cells["c机构组织名称"].Value.ToString();
            txtJiGouZuZhi.Tag =Convert.ToInt32(DGVR.Cells["c机构组织ID"].Value.ToString());
            txtBeiZu.Text = DGVR.Cells["c备注"].Value.ToString();
            chkShiFouLiZhi.Checked = Convert.ToBoolean(DGVR.Cells["c是否离职"].Value.ToString());
            dtpChuShengRiQi.Value = Convert.ToDateTime(DGVR.Cells["c出生日期"].Value.ToString());
            cboZhunJiaCheXing.SelectedValue = Convert.ToInt32(DGVR.Cells["c准驾车型ID"].Value.ToString());

        }

        private void btnXuan_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_XuanZheJiGou = new FRM_XuanZheJiGou(2);
            PublicStaticObject.Pub_FRM_XuanZheJiGou.ShowDialog();
        }

        private void btnQueDing_Click(object sender, EventArgs e)
        {
            string SiJiMingCheng = txtSiJiMingCheng.Text.Trim();
            string ChuShengRiQi = dtpChuShengRiQi.Text;
            string LianXiDianHua = txtLianXiDianHua.Text.Trim();
            string LianXiDiZi = txtLianXiDiZhi.Text.Trim();
            string ShenFenZhengHao = txtShenFenZhengHao.Text.Trim();
            string JiaShiZhengHao = txtJiaShiZhengHao.Text.Trim();
            int ZhunJiaCheXing = Convert.ToInt32(cboZhunJiaCheXing.SelectedValue);
            int JiGouZuZhi = Convert.ToInt32(txtJiGouZuZhi.Tag);
            string BeiZu = txtBeiZu.Text.Trim();
            int SiJiID = Convert.ToInt32(DGVR.Cells["c司机ID"].Value.ToString());
            bool LiZHiFou = chkShiFouLiZhi.Checked;

            if (BLL_FRM_SiJiGuanLi_Update.btnQueDing_Click_XiuGaiSiJi(SiJiMingCheng, ChuShengRiQi, LianXiDianHua, LianXiDiZi, ShenFenZhengHao
                 , JiaShiZhengHao, BeiZu, JiGouZuZhi, ZhunJiaCheXing, LiZHiFou,SiJiID))
            {
                MessageBox.Show("修改司机成功！");
            }
            else
            {
                MessageBox.Show("修改司机失败！");
            }
            this.Close();
        }
    }
}
