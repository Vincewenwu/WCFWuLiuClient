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
    public partial class FRM_ShenHeHuoPinTongJi : Form
    {
        public FRM_ShenHeHuoPinTongJi()
        {
            InitializeComponent();
        }

        private void FRM_ShenHeHuoPinTongJi_Load(object sender, EventArgs e)
        {
            BLL物流管理系统.报表统计.FRM_ShenHeHuoPinTongJi.FRM_ShenHeHuoPinTongJiClient myFRM_ShenHeHuoPinTongJiClient = new BLL物流管理系统.报表统计.FRM_ShenHeHuoPinTongJi.FRM_ShenHeHuoPinTongJiClient();
            DataTable dtDingDan = myFRM_ShenHeHuoPinTongJiClient.FRM_ShenHeHuoPinTongJi_Load_ChaXunHuiZong().Tables[0];
            DS_WuLiu myDS_WuLiu = new DS_WuLiu();
            myDS_WuLiu.Tables["BaoBiao_审核货品统计"].Merge(dtDingDan);
            CRP_ShenHeHuoPinTongJi myCRP_ShenHeHuoPinTongJi = new CRP_ShenHeHuoPinTongJi();
            myCRP_ShenHeHuoPinTongJi.SetDataSource(myDS_WuLiu);
            crystalReportViewer1.ReportSource = myCRP_ShenHeHuoPinTongJi;
        }
    }
}
