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
    public partial class FRM_QuanXianZu : Form
    {
        public FRM_QuanXianZu()
        {
            InitializeComponent();
        }
        BLL物流管理系统.用户权限管理.BLL_QuanXianZu.BLL_QuanXianZuClient BLL_QuanXianZu =
           new BLL物流管理系统.用户权限管理.BLL_QuanXianZu.BLL_QuanXianZuClient();
        private void FRM_QuanXianZu_Load(object sender, EventArgs e)
        {
            this.dgvAuthGroup = PublicStaticMothd.SetDgv(dgvAuthGroup);
            this.dgvMoKuai = PublicStaticMothd.SetDgv(dgvMoKuai);
          
                dgvAuthGroup.AutoGenerateColumns = false;
                dgvAuthGroup.DataSource = BLL_QuanXianZu.FRM_QuanXianZu_Load_ChaXunQuanXianZu().Tables[0];

                int QuanXianZuID = Convert.ToInt32(dgvAuthGroup.CurrentRow.Cells["权限组ID"].Value.ToString());
                dgvMoKuai.DataSource = BLL_QuanXianZu.FRM_QuanXianZu_dgvAuthGroup_CellClick_ChaXunMoKuai(QuanXianZuID).Tables[0];
           
        }

        private void dgvAuthGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAuthGroup.CurrentRow != null)
            {
                int QuanXianZuID = Convert.ToInt32(dgvAuthGroup.CurrentRow.Cells["权限组ID"].Value.ToString());
                dgvMoKuai.DataSource = BLL_QuanXianZu.FRM_QuanXianZu_dgvAuthGroup_CellClick_ChaXunMoKuai(QuanXianZuID).Tables[0];
            }
        }

        private void btnInsertQuanXianZu_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_QuanXianZu_Insert = new FRM_QuanXianZu_Insert();
            PublicStaticObject.Pub_FRM_QuanXianZu_Insert.ShowDialog();
            refresh();
        }

        private void btnEditQuanXianZu_Click(object sender, EventArgs e)
        {
            if (dgvAuthGroup.CurrentRow != null)
            {
                PublicStaticObject.Pub_FRM_QuanXianZu_Update = new FRM_QuanXianZu_Update(Convert.ToInt32(dgvAuthGroup.CurrentRow.Cells["权限组ID"].Value)
                    , dgvAuthGroup.CurrentRow.Cells["权限组名称"].Value.ToString());
                PublicStaticObject.Pub_FRM_QuanXianZu_Update.ShowDialog();
                refresh();
            }
        }

        private void refresh()
        {
            if (dgvAuthGroup.CurrentRow != null)
            {
                dgvAuthGroup.AutoGenerateColumns = false;
                dgvAuthGroup.DataSource = BLL_QuanXianZu.FRM_QuanXianZu_Load_ChaXunQuanXianZu().Tables[0];

                int QuanXianZuID = Convert.ToInt32(dgvAuthGroup.CurrentRow.Cells["权限组ID"].Value.ToString());
                dgvMoKuai.DataSource = BLL_QuanXianZu.FRM_QuanXianZu_dgvAuthGroup_CellClick_ChaXunMoKuai(QuanXianZuID).Tables[0];
            }
        }
        private void btnQuanXianZu_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定删除用户？",
                      "确定", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                int flag = BLL_QuanXianZu.FRM_QuanXianZu_btnDelQuanXianZu_Click(Convert.ToInt32(dgvAuthGroup.CurrentRow.Cells["权限组ID"].Value.ToString()));
                if (flag > 0)
                {
                    MessageBox.Show("删除权限组成功！");
                }
                else
                {
                    MessageBox.Show("删除权限组失败！");
                }
                refresh();

            }
        }
    }
}
