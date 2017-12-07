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
    public partial class FRM_YongHuQuanXian_Update : Form
    {
        DataGridViewRow DGVR;
        public FRM_YongHuQuanXian_Update(DataGridViewRow dgvr)
        {
            DGVR = dgvr;
            InitializeComponent();
        }

        BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian_Update.BLL_YongHuQuanXian_UpdateClient BLL_YongHuQuanXian_Update =
        new BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian_Update.BLL_YongHuQuanXian_UpdateClient();

        private void FRM_YongHuQuanXian_Update_Load(object sender, EventArgs e)
        {
            DataTable dt = BLL_YongHuQuanXian_Update.FRM_YongHuQuanXian_Update_ChaXunQuanXianZu().Tables[0];
            cboQuanXianZu.DataSource = dt;
            cboQuanXianZu.DisplayMember = "权限组名称";
            cboQuanXianZu.ValueMember = "权限组ID";
            cboQuanXianZu.SelectedValue = DGVR.Cells["所属权限组ID"].Value;

            DataTable dt1 = BLL_YongHuQuanXian_Update.FRM_YongHuQuanXian_Update_Load_ChaXunYuanGong().Tables[0];
            cboYuanGong.DataSource = dt1;
            cboYuanGong.DisplayMember = "员工姓名";
            cboYuanGong.ValueMember = "员工ID";
            cboYuanGong.SelectedValue = DGVR.Cells["员工ID"].Value;

            txtZhangHao.Text = DGVR.Cells["账号"].Value.ToString();
            txtMiMa.Text = DGVR.Cells["密码"].Value.ToString();

            if (Convert.ToInt32(DGVR.Cells["用户ID"].Value.ToString()) == PublicStaticObject.YongHuID)        //不能修改自己的权限组
            {
                cboQuanXianZu.Enabled = false;
            }

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
            int QuanXianZu = Convert.ToInt32(cboQuanXianZu.SelectedValue.ToString());
            int YuanGongID = Convert.ToInt32(cboYuanGong.SelectedValue.ToString());
            int count = BLL_YongHuQuanXian_Update.FRM_YongHuQuanXian_Update_btnQueDing_Click(ZhangHao, MiMa, QuanXianZu, 
                YuanGongID,Convert.ToInt32(DGVR.Cells["用户ID"].Value.ToString()));
            if (count > 0)
            {
                MessageBox.Show("修改用户成功！");
            }
            else
            {
                MessageBox.Show("修改用户失败！");
            }
            this.Close();
        }
    }
}
