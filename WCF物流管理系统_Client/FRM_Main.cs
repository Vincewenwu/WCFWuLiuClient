using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client
{
    public partial class FRM_Main : Form
    {
        #region 构造方法
        public FRM_Main()
        {
            InitializeComponent();
        }
        #endregion

        #region load事件设置窗体位置和窗体大小，并弹出气泡提示
        private void FRM_Main_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this); 
            int iWidth = rect.Width; 
            int iHeight = rect.Height; 
            this.Height = iHeight; 
            this.Width = iWidth; 
            this.splitContainer1.IsSplitterFixed = true;
            this.groupBox1.Left = this.tbcZhuJieMian.Right + 3;
            this.groupBox1.Width = this.splitContainer1.Panel2.Width - this.tbcZhuJieMian.Width - 5;
            this.groupBox1.Top = this.tbcZhuJieMian.Top;
            this.timer1.Enabled = true;
            this.notifyIcon1.ShowBalloonTip(5000,"提示","欢迎使用 物流管理系统WCF标准教学版",ToolTipIcon.None);
            PublicStaticObject.MainLeft = this.panel2.Left + 4;
            PublicStaticObject.MainTop = this.panel2.Bottom + 50;
            PublicStaticObject.MainWidth = this.Width - 10;
            PublicStaticObject.MainHeight = this.splitContainer1.Panel2.Height;
        }
        #endregion

        #region Esc按钮退出窗体
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int WM_KEYDOWN = 256;
            int WM_SYSKEYDOWN = 260;
            if (msg.Msg == WM_KEYDOWN | msg.Msg == WM_SYSKEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        DialogResult result = MessageBox.Show("是否退出程序？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Dispose();
                            this.Close();
                            Environment.Exit(1);
                        } 
                       
                        break;
                }
            }
            return true;
        }
        #endregion

        #region 点击分页控件显示对应的题目
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tbcZhuJieMian.SelectedTab == tabPage1)
            {
                this.tbcZhuJieMian.TabPages[0].ImageKey = "A1.png";
                this.tbcZhuJieMian.TabPages[1].ImageKey = "2.png";
                this.tbcZhuJieMian.TabPages[2].ImageKey = "3.png";
                this.tbcZhuJieMian.TabPages[3].ImageKey = "4.png";
                this.tbcZhuJieMian.TabPages[4].ImageKey = "5.png";
                this.tbcZhuJieMian.TabPages[5].ImageKey = "6.png";
                this.tbcZhuJieMian.TabPages[6].ImageKey = "7.png";
                this.lab_Show.Text = "业务管理";
            }
            if (tbcZhuJieMian.SelectedTab == tabPage2)
            {
                this.tbcZhuJieMian.TabPages[0].ImageKey = "1.png";
                this.tbcZhuJieMian.TabPages[1].ImageKey = "A2.png";
                this.tbcZhuJieMian.TabPages[2].ImageKey = "3.png";
                this.tbcZhuJieMian.TabPages[3].ImageKey = "4.png";
                this.tbcZhuJieMian.TabPages[4].ImageKey = "5.png";
                this.tbcZhuJieMian.TabPages[5].ImageKey = "6.png";
                this.tbcZhuJieMian.TabPages[6].ImageKey = "7.png";
                this.lab_Show.Text = "车辆管理";
            }
            if (tbcZhuJieMian.SelectedTab == tabPage3)
            {
                this.tbcZhuJieMian.TabPages[0].ImageKey = "1.png";
                this.tbcZhuJieMian.TabPages[1].ImageKey = "2.png";
                this.tbcZhuJieMian.TabPages[2].ImageKey = "A3.png";
                this.tbcZhuJieMian.TabPages[3].ImageKey = "4.png";
                this.tbcZhuJieMian.TabPages[4].ImageKey = "5.png";
                this.tbcZhuJieMian.TabPages[5].ImageKey = "6.png";
                this.tbcZhuJieMian.TabPages[6].ImageKey = "7.png";
                this.lab_Show.Text = "油料管理";
            }
            if (tbcZhuJieMian.SelectedTab == tabPage4)
            {
                this.tbcZhuJieMian.TabPages[0].ImageKey = "1.png";
                this.tbcZhuJieMian.TabPages[1].ImageKey = "2.png";
                this.tbcZhuJieMian.TabPages[2].ImageKey = "3.png";
                this.tbcZhuJieMian.TabPages[3].ImageKey = "A4.png";
                this.tbcZhuJieMian.TabPages[4].ImageKey = "5.png";
                this.tbcZhuJieMian.TabPages[5].ImageKey = "6.png";
                this.tbcZhuJieMian.TabPages[6].ImageKey = "7.png";
                this.lab_Show.Text = "工资管理";
            }
            if (tbcZhuJieMian.SelectedTab == tabPage5)
            {
                this.tbcZhuJieMian.TabPages[0].ImageKey = "1.png";
                this.tbcZhuJieMian.TabPages[1].ImageKey = "2.png";
                this.tbcZhuJieMian.TabPages[2].ImageKey = "3.png";
                this.tbcZhuJieMian.TabPages[3].ImageKey = "4.png";
                this.tbcZhuJieMian.TabPages[4].ImageKey = "A5.png";
                this.tbcZhuJieMian.TabPages[5].ImageKey = "6.png";
                this.tbcZhuJieMian.TabPages[6].ImageKey = "7.png";
                this.lab_Show.Text = "仓储管理";
            }
            if (tbcZhuJieMian.SelectedTab == tabPage6)
            {
                this.tbcZhuJieMian.TabPages[0].ImageKey = "1.png";
                this.tbcZhuJieMian.TabPages[1].ImageKey = "2.png";
                this.tbcZhuJieMian.TabPages[2].ImageKey = "3.png";
                this.tbcZhuJieMian.TabPages[3].ImageKey = "4.png";
                this.tbcZhuJieMian.TabPages[4].ImageKey = "5.png";
                this.tbcZhuJieMian.TabPages[5].ImageKey = "A6.png";
                this.tbcZhuJieMian.TabPages[6].ImageKey = "7.png";
                this.lab_Show.Text = "辅助工具";
            }
            if (tbcZhuJieMian.SelectedTab == tabPage7)
            {
                this.tbcZhuJieMian.TabPages[0].ImageKey = "1.png";
                this.tbcZhuJieMian.TabPages[1].ImageKey = "2.png";
                this.tbcZhuJieMian.TabPages[2].ImageKey = "3.png";
                this.tbcZhuJieMian.TabPages[3].ImageKey = "4.png";
                this.tbcZhuJieMian.TabPages[4].ImageKey = "5.png";
                this.tbcZhuJieMian.TabPages[5].ImageKey = "6.png";
                this.tbcZhuJieMian.TabPages[6].ImageKey = "A7.png";
                this.lab_Show.Text = "报表统计";
            }
        }
        #endregion

        #region 窗体关闭前弹出关闭警告
        private void FRM_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出程序？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
                Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            } 
        }
        #endregion

        #region 主界面时钟显示
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel6.Text = DateTime.Now.ToString().Trim();
        }
        #endregion

        #region 退出程序警告
        private void 关闭系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出程序？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
                Environment.Exit(1);
            } 
        }
        #endregion

        #region 提示当前选择功能为订单管理并跳转
        private void button1_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 订单管理";
            PublicStaticObject.Pub_FRM_DingDanGuanLi = new 订单管理.FRM_DingDanGuanLi();
            PublicStaticObject.Pub_FRM_DingDanGuanLi.ShowDialog();
        }
        #endregion
         
        #region 提示当前选择功能为出车登记并跳转
        private void button3_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 出车登记"; 
            PublicStaticObject.Pub_FRM_ChuCheDengJi = new  出车登记.FRM_ChuCheDengJi ();
            PublicStaticObject.Pub_FRM_ChuCheDengJi.ShowDialog();
            
        }
        #endregion

        #region 提示当前选择功能为线路管理并跳转
        private void button6_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 线路管理";
            PublicStaticObject.Pub_FRM_XianLuGuanLi = new 线路管理.FRM_XianLuGuanLi ();
            PublicStaticObject.Pub_FRM_XianLuGuanLi.ShowDialog(); 
        }
        #endregion

        #region 提示当前选择功能为车辆状态并跳转
        private void button7_Click(object sender, EventArgs e)
        {  
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 车辆状态";
            PublicStaticObject.Pub_FRM_CheLiangZhuangTai = new 车辆状态.FRM_CheLiangZhuangTai ();
            PublicStaticObject.Pub_FRM_CheLiangZhuangTai.ShowDialog(); 
        }
        #endregion

        #region 提示当前选择功能为司机管理并跳转
        private void btnSiJiGuanLi_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 司机管理";
            PublicStaticObject.Pub_FRM_SiJiGuanLi = new  司机管理.FRM_SiJiGuanLi();
            PublicStaticObject.Pub_FRM_SiJiGuanLi.ShowDialog();
        }
        #endregion

        #region 提示当前选择功能为用户权限管理并跳转
        private void btnYongHuQuanXian_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 用户权限管理";
            PublicStaticObject.Pub_FRM_UserAuth = new 用户权限管理.FRM_YongHuQuanXian();
            PublicStaticObject.Pub_FRM_UserAuth.ShowDialog();
        }
        #endregion

        #region 提示当前选择功能为权限组管理并跳转
        private void btnQuanXianZu_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 权限组管理";
            PublicStaticObject.Pub_FRM_FRM_QuanXianZu = new 用户权限管理.FRM_QuanXianZu();
            PublicStaticObject.Pub_FRM_FRM_QuanXianZu.ShowDialog();
        }
        #endregion

        #region 提示当前选择功能为车辆配载并跳转
        private void btnCheLiangPeiZai_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 车辆配载";
            PublicStaticObject.Pub_FRM_PeiZaiFaHuoPeiZai = new 配载发货.FRM_PeiZaiFaHuoPeiZai();
            PublicStaticObject.Pub_FRM_PeiZaiFaHuoPeiZai.ShowDialog();
        }
        #endregion

        #region 提示当前选择功能为订单分包并跳转
        private void btnDingDanFenBao_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Main_Lab_Show = this.lab_Show.Text;
            this.lab_Show.Text = "业务管理 >> 订单分包";
            PublicStaticObject.Pub_FRM_FRM_PeiZaiFaHuoFenBao = new 配载发货.FRM_PeiZaiFaHuoFenBao();
            PublicStaticObject.Pub_FRM_FRM_PeiZaiFaHuoFenBao.ShowDialog();
        }
        #endregion

        #region  初始页面和二维码生成模块
        private void btnXml_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_Info = new FRM_Info();
            PublicStaticObject.Pub_FRM_Info.ShowDialog();
        }
      
        private void btnErWeiMa_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_ErWeiMaMain = new 报表统计.FRM_ErWeiMaMain();
            PublicStaticObject.Pub_FRM_ErWeiMaMain.ShowDialog(); 
        }
        #endregion 

        #region 报表管理模块
        private void btnDingDanBaoBiao_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_BaoBiaoDingDanLiuLan = new 报表统计.FRM_BaoBiaoDingDanLiuLan();
            PublicStaticObject.Pub_FRM_BaoBiaoDingDanLiuLan.ShowDialog();
        }

        private void btnYeWuYuanTongJi_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_YeWuYuanYeJi = new 报表统计.FRM_YeWuYuanYeJi();
            PublicStaticObject.Pub_FRM_YeWuYuanYeJi.ShowDialog();
        }

        private void btnWeiTuoFangTongJi_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_WeiTuoYunFangTongJi = new 报表统计.FRM_WeiTuoYunFangTongJi();
            PublicStaticObject.Pub_FRM_WeiTuoYunFangTongJi.ShowDialog();
        }

        private void btnShouHuoFangTongJi_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_ShouHuoFangTongJi = new 报表统计.FRM_ShouHuoFangTongJi();
            PublicStaticObject.Pub_FRM_ShouHuoFangTongJi.ShowDialog();
        }

        private void btnRiQiTongJiWangDian_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_RiQiWangDianTongJi = new 报表统计.FRM_RiQiWangDianTongJi();
            PublicStaticObject.Pub_FRM_RiQiWangDianTongJi.ShowDialog();
        }

        private void btnRenShiKaoHe_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_RenShiKaoHeBiao = new 报表统计.FRM_RenShiKaoHeBiao();
            PublicStaticObject.Pub_FRM_RenShiKaoHeBiao.ShowDialog();
        }

        private void btnShenHeHuoPinTongJi_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_ShenHeHuoPinTongJi = new 报表统计.FRM_ShenHeHuoPinTongJi();
            PublicStaticObject.Pub_FRM_ShenHeHuoPinTongJi.ShowDialog();
        }

        private void btnYuanGongGongZuoZheng_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_YuanGongGongZuoZheng = new 报表统计.FRM_YuanGongGongZuoZheng();
            PublicStaticObject.Pub_FRM_YuanGongGongZuoZheng.ShowDialog();
        }

        private void btnDaoDaDengJi_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_DaoDaDengJi = new 出车登记.FRM_DaoDaDengJi();
            PublicStaticObject.Pub_FRM_DaoDaDengJi.ShowDialog();
        }
        #endregion

        #region 返回页面时重新提示当前功能
        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            if (PublicStaticObject.Main_Lab_Show != "")
            {
                this.lab_Show.Text = PublicStaticObject.Main_Lab_Show;
            }
        }
        #endregion

    }
}
