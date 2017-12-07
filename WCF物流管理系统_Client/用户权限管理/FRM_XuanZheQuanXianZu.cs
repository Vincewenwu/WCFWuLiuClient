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
    public partial class FRM_XuanZheQuanXianZu : Form
    {
        int[] YongHuID;
        public FRM_XuanZheQuanXianZu(int[] yonghuid)
        {
            YongHuID = yonghuid;
            InitializeComponent();
        }
        BLL物流管理系统.用户权限管理.BLL_XuanZheQuanXianZu.BLL_XuanZheQuanXianZuClient BLL_XuanZheQuanXianZu=
            new BLL物流管理系统.用户权限管理.BLL_XuanZheQuanXianZu.BLL_XuanZheQuanXianZuClient();
        private void FRM_XuanZheQuanXianZu_Load(object sender, EventArgs e)
        {
            DataTable dt = BLL_XuanZheQuanXianZu.FRM_XuanZheQuanXianZu_Load_ChaXunQuanXianZu().Tables[0];
            cboQuanXianZu.DataSource = dt;
            cboQuanXianZu.DisplayMember = "权限组名称";
            cboQuanXianZu.ValueMember = "权限组ID";
        }

        private void btnQueDing_Click(object sender, EventArgs e)
        {
            if (PublicStaticObject.YongHuQuanXianZuID != 1 && Convert.ToInt32(cboQuanXianZu.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("只有拥有超级管理员权限的人才能赋予超级管理员组权限！","警告!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("是否确定批量修改为\"" + cboQuanXianZu.Text.Trim() + "\"？",
                        "确定", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                int QuanXianID = Convert.ToInt32(cboQuanXianZu.SelectedValue.ToString());
                for (int i = 0; i < YongHuID.Length; i++)
                {
                    BLL_XuanZheQuanXianZu.FRM_XuanZheQuanXianZu_btnQueDing_Click(YongHuID[i], QuanXianID);
                }

                MessageBox.Show("批量修改权限组完成！");
                this.Close();
            }
        }
    }
}
