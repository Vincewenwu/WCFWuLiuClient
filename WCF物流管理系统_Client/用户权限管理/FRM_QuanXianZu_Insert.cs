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
    public partial class FRM_QuanXianZu_Insert : Form
    {
        public FRM_QuanXianZu_Insert()
        {
            InitializeComponent();
        }
        BLL物流管理系统.用户权限管理.BLL_QuanXianZu_Insert.BLL_QuanXianZu_InsertClient BLL_QuanXianZu_Insert =
            new BLL物流管理系统.用户权限管理.BLL_QuanXianZu_Insert.BLL_QuanXianZu_InsertClient();
        DataTable dtMoKuai;
        private void FRM_QuanXianZu_Insert_Load(object sender, EventArgs e)
        {
            dgvMoKuai.AutoGenerateColumns=false;
            dtMoKuai = BLL_QuanXianZu_Insert.FRM_QuanXianZu_Insert_Load_ChaXunMoKuai().Tables[0];
            dtMoKuai.Columns.Add(new DataColumn("选择", System.Type.GetType("System.Boolean")));
            dgvMoKuai.DataSource = dtMoKuai;
            
                            this.dgvMoKuai = PublicStaticMothd.SetDgv(dgvMoKuai);
            dgvMoKuai.ReadOnly = false;
        }

        private void btnChaXunMoKuai_Click(object sender, EventArgs e)
        {
            int length = txtChaXunMoKuai.Text.Length;                         //获得字符长度
            string nameSearch = txtChaXunMoKuai.Text.ToString().Trim();      //获得输入内容
            try
            {
                #region 当筛选条件为空时
                if (txtChaXunMoKuai.Text.Trim() == "")                           //当筛选条件为空时
                {
                    for (int count = 0; count < dgvMoKuai.Rows.Count; count++)
                    {
                        //把所有行的背景色设置为白色
                            
                    }
                }
                #endregion
                #region 当筛选条件不为空时
                else        //当筛选条件不为空时
                {
                    for (int count = 0; count < dgvMoKuai.Rows.Count; count++)
                    { 
                        //把所有行的背景色设置为白色  
                    }
                    for (int count = 0; count < dgvMoKuai.Rows.Count; count++)              //检索所有行
                    {
                        
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                //打印异常情况
                MessageBox.Show(ex.ToString());                            
            }
        }

        private void btnQueDing_Click(object sender, EventArgs e)
        {

            int count = 0;
            foreach (DataGridViewRow dgvr in dgvMoKuai.Rows)
            {
                if (Convert.ToBoolean(dgvr.Cells["选择"].FormattedValue) == true)
                {
                    count++;
                }
            }
            int[] MoKuaiID = new int[count];
            count = 0;
            foreach (DataGridViewRow dgvr in dgvMoKuai.Rows)
            {
                if (Convert.ToBoolean(dgvr.Cells["选择"].FormattedValue) == true)
                {
                    MoKuaiID[count] = Convert.ToInt32(dgvr.Cells["模块ID"].Value.ToString());
                    count++;
                }
            }

            int flag = BLL_QuanXianZu_Insert.FRM_QuanXianZu_Insert_btnQueDing_Click_TianJiaQuanXianZu(MoKuaiID,txtQuanXianZuMingCheng.Text.Trim());

            if (flag > 0)
            {
                MessageBox.Show("添加权限组成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加权限组失败！");
            }
        }

    
    }
}
