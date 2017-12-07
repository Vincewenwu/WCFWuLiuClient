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
    public partial class FRM_YongHuQuanXian : Form
    {
        public FRM_YongHuQuanXian()
        {
            InitializeComponent();
        }
        BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian.BLL_YongHuQuanXianClient myBLL_BLL_YongHuQuanXia = new
            BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian.BLL_YongHuQuanXianClient();     //实例化BLL
        private void FRM_YongHuQuanXian_Load(object sender, EventArgs e)
        {
            DataTable dt = myBLL_BLL_YongHuQuanXia.FRM_YongHuQuanXian_Load_ChaXunYongHu().Tables[0];
            dgv_User.SelectionMode = DataGridViewSelectionMode.FullRowSelect;       //设定选定行的模式
            dgv_User.AutoGenerateColumns = false;
            dgv_User.DataSource = dt;
            dgv_User = PublicStaticMothd.SetDgv(dgv_User);
            dgv_User.MultiSelect = true;
        }

        private void btnYongHu_Del_Click(object sender, EventArgs e)
        {
            if (dgv_User.CurrentRow != null)
            {
                if (MessageBox.Show("是否确定删除用户？",
                            "确定", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int yongHuID = Convert.ToInt32(dgv_User.CurrentRow.Cells["用户ID"].Value.ToString());
                    int i = myBLL_BLL_YongHuQuanXia.FRM_YongHuQuanXian_btnYongHu_Del_Click(yongHuID);
                    if (i > 0)
                    {
                        MessageBox.Show("删除用户成功！");
                    }
                    else
                    {
                        MessageBox.Show("删除用户失败！");
                    }
                    refreshDGV();
                }
            }
        }

        private void btnInserYongHu_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_YongHuQuanXian_Insert = new FRM_YongHuQuanXian_Insert();
            PublicStaticObject.Pub_FRM_YongHuQuanXian_Insert.ShowDialog();
            refreshDGV();
        }

        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnYongHu_Del_Click(null, null);
        }

        private void 批量赋予用户权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] IDs = new int[dgv_User.SelectedRows.Count];
            int count = 0;

            foreach (DataGridViewRow dgvr in dgv_User.SelectedRows)
            {
                IDs[count] = Convert.ToInt32(dgvr.Cells["用户ID"].Value.ToString());
                count++;
            }

            PublicStaticObject.Pub_FRM_XuanZheQuanXianZu = new FRM_XuanZheQuanXianZu(IDs);
            PublicStaticObject.Pub_FRM_XuanZheQuanXianZu.ShowDialog();
            refreshDGV();
           
        }

        private void refreshDGV()
        {
            DataTable dt = myBLL_BLL_YongHuQuanXia.FRM_YongHuQuanXian_Load_ChaXunYongHu().Tables[0];
            dgv_User.AutoGenerateColumns = false;
            dgv_User.DataSource = dt;
        }

        private void btnUpdateYongHu_Click(object sender, EventArgs e)
        {
            if (dgv_User.CurrentRow != null)
            {
                DataGridViewRow dgvr = dgv_User.CurrentRow;
                PublicStaticObject.Pub_FRM_YongHuQuanXian_Update = new FRM_YongHuQuanXian_Update(dgvr);
                PublicStaticObject.Pub_FRM_YongHuQuanXian_Update.ShowDialog();
                refreshDGV();
            }
        }

    }
}
