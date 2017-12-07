using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.报表统计
{
    public partial class FRM_YuanGongGongZuoZhengDaYin : Form
    {
        public FRM_YuanGongGongZuoZhengDaYin()
        {
            InitializeComponent();
        }

        private void FRM_YuanGongGongZuoZhengDaYin_Load(object sender, EventArgs e)
        {
            BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng.FRM_YuanGongGongZuoZhengClient myFRM_YuanGongGongZuoZhengClient = new BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng.FRM_YuanGongGongZuoZhengClient();
            DataTable dtDingDan = myFRM_YuanGongGongZuoZhengClient.FRM_YuanGongGongZuoZhengDaYin_Load_ChaXunYuanGong().Tables[0];
            DS_WuLiu myDS_WuLiu = new DS_WuLiu();
            myDS_WuLiu.Tables["BaoBiao_员工表"].Merge(dtDingDan);
            CRP_YuanGongGongZuoZhengDaYin myCRP_YuanGongGongZuoZhengDaYin = new CRP_YuanGongGongZuoZhengDaYin();
            myCRP_YuanGongGongZuoZhengDaYin.SetDataSource(myDS_WuLiu);
            crystalReportViewer1.ReportSource = myCRP_YuanGongGongZuoZhengDaYin;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
