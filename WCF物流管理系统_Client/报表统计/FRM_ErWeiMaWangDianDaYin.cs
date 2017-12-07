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
    public partial class FRM_ErWeiMaWangDianDaYin : Form
    {
        public FRM_ErWeiMaWangDianDaYin(DataTable dt)
        {
            InitializeComponent();
            dtErWeiMa = dt;
        }
        DataTable dtErWeiMa;

        private void FRM_ErWeiMaWangDianDaYin_Load(object sender, EventArgs e)
        {
            DS_WuLiu myDS_WuLiu = new DS_WuLiu();
            myDS_WuLiu.Tables["BaoBiao_网点二维码"].Merge(dtErWeiMa);
            CRP_ErWeiMaWangDianDaYin myCRP_ErWeiMaWangDianDaYin = new CRP_ErWeiMaWangDianDaYin();
            myCRP_ErWeiMaWangDianDaYin.SetDataSource(myDS_WuLiu);
            crystalReportViewer1.ReportSource = myCRP_ErWeiMaWangDianDaYin;
        }
    }
}
