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
    public partial class FRM_YeWuYuanYeJi : Form
    {
        public FRM_YeWuYuanYeJi()
        {
            InitializeComponent();
        }

        private void FRM_YeWuYuanYeJi_Load(object sender, EventArgs e)
        {
            BLL物流管理系统.报表统计.FRM_YeWuYuanYeJi.FRM_YeWuYuanYeJiClient myFRM_YeWuYuanYeJiClient = new BLL物流管理系统.报表统计.FRM_YeWuYuanYeJi.FRM_YeWuYuanYeJiClient();
            DataTable dtDingDan = myFRM_YeWuYuanYeJiClient.FRM_YeWuYuanYeJi_Load_ChaXunDingDan().Tables[0];
            DS_WuLiu myDS_WuLiu = new DS_WuLiu();
            myDS_WuLiu.Tables["BaoBiao_订单报表"].Merge(dtDingDan); 
            CRP_YeWuYuanYeJi myCRP_YeWuYuanYeJi = new CRP_YeWuYuanYeJi();
            myCRP_YeWuYuanYeJi.SetDataSource(myDS_WuLiu);
            crystalReportViewer1.ReportSource = myCRP_YeWuYuanYeJi;
        }
    }
}
