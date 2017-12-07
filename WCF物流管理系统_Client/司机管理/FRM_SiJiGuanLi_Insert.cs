using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WCF物流管理系统_Client.司机管理
{
    public partial class FRM_SiJiGuanLi_Insert : Form
    {
        public FRM_SiJiGuanLi_Insert()
        {
            InitializeComponent();
        }
        BLL物流管理系统.司机管理.BLL_FRM_SiJiGuanLi_Insert.BLL_FRM_SiJiGuanLi_InsertClient BLL_FRM_SiJiGuanLi_Insert =
            new BLL物流管理系统.司机管理.BLL_FRM_SiJiGuanLi_Insert.BLL_FRM_SiJiGuanLi_InsertClient();
        private void FRM_SiJiGuanLi_Insert_Load(object sender, EventArgs e)
        {
            bool b = 用户权限管理.authCheck.checkAuthByType(this, System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!b) { MessageBox.Show("没有该权限，请联系管理员！"); this.Close(); return; }
            cboZhunJiaCheXing.DataSource = BLL_FRM_SiJiGuanLi_Insert.FRM_SiJiGuanLi_Load_Insert_ChaXunZhunJiaCheXin().Tables[0];
            cboZhunJiaCheXing.DisplayMember = "准驾车型名称";
            cboZhunJiaCheXing.ValueMember = "准驾车型ID";
        }

        private void btnXuan_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_XuanZheJiGou = new FRM_XuanZheJiGou(1);
            PublicStaticObject.Pub_FRM_XuanZheJiGou.ShowDialog();
        }

        private void btnQueDing_Click(object sender, EventArgs e)
        {


            string SiJiMingCheng = txtSiJiMingCheng.Text.Trim();
            string ChuShengRiQi=dtpChuShengRiQi.Text;
            string LianXiDianHua = txtLianXiDianHua.Text.Trim();
            string LianXiDiZi = txtLianXiDiZhi.Text.Trim();
            string ShenFenZhengHao = txtShenFenZhengHao.Text.Trim();
            string JiaShiZhengHao = txtJiaShiZhengHao.Text.Trim();
            int ZhunJiaCheXing =Convert.ToInt32(cboZhunJiaCheXing.SelectedValue);
            if (txtJiGouZuZhi.Tag == null || SiJiMingCheng == null || ChuShengRiQi == null || LianXiDianHua == null || LianXiDiZi == null || JiaShiZhengHao==null)
            {
                MessageBox.Show("填写完成信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int JiGouZuZhi =Convert.ToInt32(txtJiGouZuZhi.Tag);
            string BeiZu = txtBeiZu.Text.Trim();
            bool LiZHiFou = chkShiFouLiZhi.Checked;
            
            if ((!Regex.IsMatch(txtShenFenZhengHao.Text, @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
            {
                MessageBox.Show("请输入正确的身份证号码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (BLL_FRM_SiJiGuanLi_Insert.btnQueDing_Click_XinZhengSiJi(SiJiMingCheng, ChuShengRiQi, LianXiDianHua, LianXiDiZi, ShenFenZhengHao
                 , JiaShiZhengHao, BeiZu, JiGouZuZhi, ZhunJiaCheXing, LiZHiFou))
            {
                MessageBox.Show("新增司机成功！");
            }
            else
            {
                MessageBox.Show("新增司机失败！");
            }
            this.Close();
        }

        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
