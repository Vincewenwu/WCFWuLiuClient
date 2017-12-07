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
    public partial class FRM_DingDanGuanLi_Insert_SelectHuoWu : Form
    { 
        #region 定义参数
        FRM_DingDanGuanLi_Insert frmInsert;
        int rowIndex = 0;
        BLL物流管理系统.订单管理.DingDanGuanLi_Insert.DingDanGuanLi_InsertClient myDingDanGuanLi_Insert =
              new BLL物流管理系统.订单管理.DingDanGuanLi_Insert.DingDanGuanLi_InsertClient();
        #endregion

        #region 重载构造方法
        public FRM_DingDanGuanLi_Insert_SelectHuoWu(FRM_DingDanGuanLi_Insert frm,int i)
        {
            InitializeComponent();
            frmInsert = frm;
            rowIndex = i;
        }
        #endregion

        #region 双击货物dgv选择货物
        private void dgvHuoWu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
          {
              if (dgvHuoWu.CurrentRow != null)
              {
                  if (frmInsert.dgvHuoWuList.Rows[rowIndex].Cells["货物名称"].Value == null)
                  {
                      frmInsert.dgvHuoWuList.Rows.Add();
                      if (frmInsert.dgvHuoWuList.CurrentRow.Cells["数量"].Value != null &&
                  frmInsert.dgvHuoWuList.CurrentRow.Cells["运费单价"].Value != null )
                      {
                          frmInsert.运费总价 += Convert.ToDecimal(frmInsert.dgvHuoWuList.CurrentRow.Cells["数量"].Value) *
                               Convert.ToDecimal(frmInsert.dgvHuoWuList.CurrentRow.Cells["运费单价"].Value);
                      }
                  }
                  frmInsert.dgvHuoWuList.Rows[rowIndex].Cells["货物ID"].Value =
                      dgvHuoWu.CurrentRow.Cells["货物ID"].Value;
                  frmInsert.dgvHuoWuList.Rows[rowIndex].Cells["货物名称"].Value =
                      dgvHuoWu.CurrentRow.Cells["货物名称"].Value;
                  frmInsert.dgvHuoWuList.Rows[rowIndex].Cells["计量单位"].Value =
                      dgvHuoWu.CurrentRow.Cells["计量单位"].Value;
                  frmInsert.dgvHuoWuList.Rows[rowIndex].Cells["货物类别"].Value =
                      dgvHuoWu.CurrentRow.Cells["货物类别"].Value;
                  frmInsert.dgvHuoWuList.Rows[rowIndex].Cells["计费公式"].Value = 1;
                  this.Close();
              }
        }
        #endregion

        #region Load事件加载货物列表
        private void FRM_DingDanGuanLi_Insert_SelectHuoWu_Load(object sender, EventArgs e)
          {
              dgvHuoWu.DataSource = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectHuoWu().Tables[0];
        }
        #endregion
    }
}
