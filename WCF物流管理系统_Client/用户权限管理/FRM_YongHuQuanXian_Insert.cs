using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.用户权限管理
{
    public partial class FRM_YongHuQuanXian_Insert : Form
    {
        public FRM_YongHuQuanXian_Insert()
        {
            InitializeComponent();
        }
        BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian_Insert.BLL_YongHuQuanXian_InsertClient myBLL_BLL_YongHuQuanXian_Insert =
            new BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian_Insert.BLL_YongHuQuanXian_InsertClient();
        private void FRM_YongHuQuanXian_Insert_Load(object sender, EventArgs e)
        {
            DataTable dt = myBLL_BLL_YongHuQuanXian_Insert.FRM_YongHuQuanXian_Insert_Load_ChaXunQuanXianZu().Tables[0];
            cboQuanXianZu.DataSource = dt;
            cboQuanXianZu.DisplayMember = "权限组名称";
            cboQuanXianZu.ValueMember = "权限组ID";

            DataTable dt1 = myBLL_BLL_YongHuQuanXian_Insert.FRM_YongHuQuanXian_Insert_Load_ChaXunYuanGong().Tables[0];
            cboYuanGong .DataSource = dt1;
            cboYuanGong.DisplayMember = "员工姓名";
            cboYuanGong.ValueMember = "员工ID";

        }

        private void btnQueDing_Click(object sender, EventArgs e)
        {
            if (PublicStaticObject.YongHuQuanXianZuID != 1 && Convert.ToInt32(cboQuanXianZu.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("只有拥有超级管理员权限的人才能赋予超级管理员组权限！", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ZhangHao = txtZhangHao.Text.Trim();
            string MiMa = txtMiMa.Text.Trim();
            int QuanXianZu =Convert.ToInt32( cboQuanXianZu.SelectedValue.ToString());
            int YuanGongID = Convert.ToInt32(cboYuanGong.SelectedValue.ToString());
            int count = myBLL_BLL_YongHuQuanXian_Insert.FRM_YongHuQuanXian_Insert_btnQueDing_Click(ZhangHao,MiMa,QuanXianZu,YuanGongID);
            if (count > 0)
            {
                MessageBox.Show("新增用户成功！");
            }
            else
            {
                MessageBox.Show("新增用户失败！");
            }
            this.Close();
        }
    }
}
