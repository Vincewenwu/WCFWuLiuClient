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
    public partial class FRM_BaoBiaoDingDanLiuLan : Form
    {
        public FRM_BaoBiaoDingDanLiuLan()
        {
            InitializeComponent();
        }
        BLL物流管理系统.报表统计.FRM_BaoBiaoDingDanLiuLan.FRM_BaoBiaoDingDanLiuLanClient myFRM_BaoBiaoDingDanLiuLanClient = new BLL物流管理系统.报表统计.FRM_BaoBiaoDingDanLiuLan.FRM_BaoBiaoDingDanLiuLanClient();

        private void FRM_BaoBiaoDingDanLiuLan_Load(object sender, EventArgs e)
        {
            this.dgvDingDan = PublicStaticMothd.SetDgv(dgvDingDan);
            this.dgvMingXi = PublicStaticMothd.SetDgv(dgvMingXi);
        }

        private void btnChaXun_Select_Click(object sender, EventArgs e)
        {
            dgvDingDan.DataSource = myFRM_BaoBiaoDingDanLiuLanClient.btnChaXun_Select_Click_ChaXunDingDan(dtpKaiShi.Value.ToString("yyyy-MM-dd"), dtpJieShu.Value.ToString("yyyy-MM-dd")).Tables[0];//按时间段查询订单并绑定到dgv
           
        }
        string strDingDanID = "";
        private void dgvDingDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDingDan.CurrentRow!=null)
            {
                strDingDanID = dgvDingDan.CurrentRow.Cells["货运单ID"].Value.ToString();//获取当前行的货运单ID
              dgvMingXi.DataSource = myFRM_BaoBiaoDingDanLiuLanClient.dgvDingDan_CellClick_ChaXunDingDanMingXi(strDingDanID).Tables[0];//根据货运单ID查询明细记录并绑定到dgvMingXi
             }
        }

        private void btnDaYin_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_DingDanBaoBiao = new FRM_DingDanBaoBiao();
            PublicStaticObject.Pub_FRM_DingDanBaoBiao.strDingDanID = strDingDanID;//给Pub_FRM_DingDanBaoBiao对象的strDingDanID成员变量赋值为当前行的货运单ID
            PublicStaticObject.Pub_FRM_DingDanBaoBiao.ShowDialog();
        }
    }
}
