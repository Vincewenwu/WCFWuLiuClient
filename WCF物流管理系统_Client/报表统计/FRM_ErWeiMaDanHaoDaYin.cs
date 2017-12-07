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
    public partial class FRM_ErWeiMaDanHaoDaYin : Form
    {
        public FRM_ErWeiMaDanHaoDaYin(DataTable dt)
        {
            InitializeComponent();
            dtErWeiMa = dt;
        }
        DataTable dtErWeiMa;
        private void FRM_ErWeiMaDanHaoDaYin_Load(object sender, EventArgs e)
        {
            DS_WuLiu myDS_WuLiu = new DS_WuLiu();
            //DataTable dtER1 = dtErWeiMa.Clone();
            //DataTable dtER2 = dtErWeiMa.Clone();
            int intBan = 0;
            if (dtErWeiMa.Rows.Count % 2 == 0)
            { intBan = dtErWeiMa.Rows.Count / 2; }
            else { intBan = (dtErWeiMa.Rows.Count / 2 )+1 ; }
            DataTable dtER1 = myDS_WuLiu.Tables["BaoBiao_单据二维码"].Clone();

            for (int i = 0; i < intBan;  i++)
            {
                dtER1.Rows.Add();
            }
          
            for (int i = 0; i < dtErWeiMa.Rows.Count; i++)
            {
                if (i < intBan)
                {

                    dtER1.Rows[i]["单据编号"] = dtErWeiMa.Rows[i]["单据编号"];
                    dtER1.Rows[i]["二维码"] = dtErWeiMa.Rows[i]["二维码"];

                }
                else
                {
                    dtER1.Rows[i - intBan]["单据编号1"] = dtErWeiMa.Rows[i]["单据编号"];
                    dtER1.Rows[i - intBan]["二维码1"] = dtErWeiMa.Rows[i]["二维码"];

                }
            }
            myDS_WuLiu.Tables["BaoBiao_单据二维码"].Merge(dtER1);
            //myDS_WuLiu.Tables["BaoBiao_单据二维码1"].Merge(dtErWeiMa);
            //myDS_WuLiu.Tables["BaoBiao_单据二维码2"].Merge(dtER2);

            CRP_ErWeiMaDanHaoDaYin myCRP_ErWeiMaDanHaoDaYin = new CRP_ErWeiMaDanHaoDaYin();
            myCRP_ErWeiMaDanHaoDaYin.SetDataSource(myDS_WuLiu);
            crystalReportViewer1.ReportSource = myCRP_ErWeiMaDanHaoDaYin;
        }
    }
}
