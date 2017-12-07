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
    public partial class FRM_DingDanBaoBiao : Form
    {
        public FRM_DingDanBaoBiao()
        {
            InitializeComponent();
        }
        public string strDingDanID = "";
        private void FRM_DingDanBaoBiao_Load(object sender, EventArgs e)
        {
            BLL物流管理系统.报表统计.FRM_DingDanBaoBiao.FRM_DingDanBaoBiaoClient myFRM_DingDanBaoBiaoClient = new BLL物流管理系统.报表统计.FRM_DingDanBaoBiao.FRM_DingDanBaoBiaoClient();//实例化BLL对象
            DataTable dtDingDan = myFRM_DingDanBaoBiaoClient.FRM_DingDanBaoBiao_Load_ChaXunDingDan(strDingDanID).Tables[0];//根据货运单ID查询货运单信息
            DS_WuLiu myDS_WuLiu = new DS_WuLiu();//实例化物流数据集
           myDS_WuLiu.Tables["BaoBiao_订单报表"].Merge(dtDingDan);//把数据集中名为“BaoBiao_订单报表”与查询得到的dtDingDan合并
            DataTable dtMingXi = myFRM_DingDanBaoBiaoClient.FRM_DingDanBaoBiao_Load_ChaXunMingXi(strDingDanID).Tables[0];//根据货运单ID查询货运单明细信息
            myDS_WuLiu.Tables["BaoBiao_订单报表明细"].Merge(dtMingXi);//把数据集中名为“BaoBiao_订单报表明细”与查询得到的dtMingXi合并
            CRP_DingDanBaoBiao myCRP_DingDanBaoBiao = new CRP_DingDanBaoBiao();//实例化报表对象
            myCRP_DingDanBaoBiao.SetDataSource(myDS_WuLiu);//设定报表的数据源为数据集对象
            crystalReportViewer1.ReportSource = myCRP_DingDanBaoBiao;//指定水晶报表视图控件的报表源为报表对象
        }
    }
}
