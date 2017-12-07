using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.订单管理
{
    public partial class FRM_DingDanGuanLi_Update_SelectHuoWu : Form
    { 
        #region 定义参数
        FRM_DingDanGuanLi_Update updfrm; 
        DataGridViewCellEventArgs dgvE;
        BLL物流管理系统.订单管理.DingDanGuanLi_Update.DingDanGuanLi_UpdateClient myDingDanGuanLi_UpdateClient = 
            new BLL物流管理系统.订单管理.DingDanGuanLi_Update.DingDanGuanLi_UpdateClient();      
        #endregion

        #region 重载构造方法
        public FRM_DingDanGuanLi_Update_SelectHuoWu(FRM_DingDanGuanLi_Update frm, DataGridViewCellEventArgs e)
        {
            updfrm = frm;
            //  QuFenKH = QuFenKeHu;
            InitializeComponent();
            dgvE = e;
        }
        #endregion

        #region Load事件加载货物dgv
         private void FRM_DingDanGuanLi_Update_SelectHuoWu_Load(object sender, EventArgs e)
        {
            DataTable dtHuoWu = myDingDanGuanLi_UpdateClient.frmDingDanGuanLi_Update_SelectHuoWu().Tables[0];
            dgvHuoWu.DataSource = dtHuoWu;
            this.dgvHuoWu = PublicStaticMothd.SetDgv(dgvHuoWu);
        }
        #endregion

        #region 双击货物dgv选择货物信息
        private void dgvHuoWu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvHuoWu.CurrentRow != null)
            {
                int Row = dgvE.RowIndex;//获取行数
                if (updfrm.dgvHuoWuList.Rows[Row].Cells["货物名称"].Value == null)
                {
                    updfrm.dgvHuoWuList.Rows.Add();
                }
                updfrm.dgvHuoWuList.Rows[Row].Cells["货物名称"].Value = 
                    dgvHuoWu.CurrentRow.Cells["货物名称"].Value.ToString().Trim();
                updfrm.dgvHuoWuList.Rows[Row].Cells["货物ID"].Value = 
                    dgvHuoWu.CurrentRow.Cells["货物ID"].Value.ToString().Trim();
                updfrm.dgvHuoWuList.Rows[Row].Cells["计量单位"].Value = 
                    dgvHuoWu.CurrentRow.Cells["计量单位"].Value.ToString().Trim();
                updfrm.dgvHuoWuList.Rows[Row].Cells["货物类别"].Value = 
                    dgvHuoWu.CurrentRow.Cells["货物类别"].Value.ToString().Trim();
                updfrm.dgvHuoWuList.Rows[Row].Cells["计费公式"].Value = 1;
                this.Close();
            }
        }
        #endregion 
    }
}
