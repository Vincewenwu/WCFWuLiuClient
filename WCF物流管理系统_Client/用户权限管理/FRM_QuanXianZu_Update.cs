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
    public partial class FRM_QuanXianZu_Update : Form
    {
        public FRM_QuanXianZu_Update(int quanxianzuid,string quanxianzumingcheng)
        {
            InitializeComponent();
            QuanXianZuID = quanxianzuid;
            txtQuanXianZuMingCheng.Text = quanxianzumingcheng;
        }

        int QuanXianZuID;
        BLL物流管理系统.用户权限管理.BLL_QuanXianZu_Update.BLL_QuanXianZu_UpdateClient BLL_QuanXianZu_Update =
            new BLL物流管理系统.用户权限管理.BLL_QuanXianZu_Update.BLL_QuanXianZu_UpdateClient();
        private void FRM_QuanXianZu_Update_Load(object sender, EventArgs e)
        {
            DataTable dtQuanXianMoKuai = BLL_QuanXianZu_Update.FRM_QuanXianZu_Update_Load_ChaXunQuanXianZuMoKuai(QuanXianZuID).Tables[0];
            dgvMoKuai.DataSource = dtQuanXianMoKuai;
            this.dgvMoKuai = PublicStaticMothd.SetDgv(dgvMoKuai);
            dgvMoKuai.ReadOnly = false;
        }

        private void btnQueDing_Click(object sender, EventArgs e)
        {
            string QuanXianZuMingCheng = txtQuanXianZuMingCheng.Text.Trim();
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

           int flag= BLL_QuanXianZu_Update.FRM_QuanXianZu_Update_btnQueDing_Click(MoKuaiID, QuanXianZuMingCheng, QuanXianZuID);

           if (flag > 0)
           {
               MessageBox.Show("修改权限组成功！");
               this.Close();
           }
           else
           {
               MessageBox.Show("添加权限组失败！");
           }
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
                        //dgvJiaoShiDaiXuan.Rows[count].Visible = true;
                        dgvMoKuai.Rows[count].DefaultCellStyle.BackColor = Color.Empty;     //把所有行的背景色设置为白色
                        //dgv_AnYongHuGuanLi.Rows[count].Visible = true;
                    }
                }
                #endregion
                #region 当筛选条件不为空时
                else        //当筛选条件不为空时
                {
                    //CurrencyManager cm = (CurrencyManager)BindingContext[dgv_AnYongHuGuanLi.DataSource];
                    for (int count = 0; count < dgvMoKuai.Rows.Count; count++)
                    {
                        //dgvJiaoShiDaiXuan.Rows[count].Visible = true;
                        dgvMoKuai.Rows[count].DefaultCellStyle.BackColor = Color.Empty;     //把所有行的背景色设置为白色
                        //dgv_AnYongHuGuanLi.Rows[count].Visible = false;
                    }
                    for (int count = 0; count < dgvMoKuai.Rows.Count; count++)              //检索所有行
                    {
                        string nameTeacher = dgvMoKuai.Rows[count].Cells["模块名称"].Value.ToString().Trim(); //获取当前行的姓名
                        if (nameTeacher.Length >= length)
                        {
                            for (int countLength = 0; countLength < nameTeacher.Length; countLength++)              //从第countLength个字符开始获取
                            {
                                if (countLength + length <= nameTeacher.Length)                                     //如果获取的字符不越界，这执行以下操作
                                {
                                    string name = nameTeacher.Substring(countLength, length);                       //获取字符
                                    if (name == nameSearch.Trim())                                                         //进行比较
                                    {
                                        ///*如果条件符合*/
                                        dgvMoKuai.Rows[count].DefaultCellStyle.BackColor = Color.LightBlue; //背景色设置为亮蓝色
                                        //dgvJiaoShiDaiXuan.Rows[count].Visible = true;
                                        dgvMoKuai.CurrentCell = dgvMoKuai.Rows[count].Cells["模块名称"];  //把行设定为当前选定行
                                        //cm.SuspendBinding(); //挂起，这行必需有
                                        //dgv_AnYongHuGuanLi.Rows[count].Visible = true; 
                                        //cm.ResumeBinding();//继续，这行必需有
                                    }
                                    //else                                                                    //如果条件不符合
                                    //{
                                    //    //dgvJiaoShiDaiXuan.Rows[count].DefaultCellStyle.BackColor = Color.Empty;
                                    //    dgvJiaoShiDaiXuan.Rows[count].Visible = false;
                                    //}
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            //catch (IndexOutOfRangeException)
            //{

            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                             //打印异常情况
            }
            
        }
    }
}
