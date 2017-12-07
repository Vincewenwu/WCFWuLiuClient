using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.配载发货
{
    public partial class FRM_PeiZaiFaHuoPeiZai_Insert : Form
    { 
        #region 构造方法
        public FRM_PeiZaiFaHuoPeiZai_Insert()
        {
            InitializeComponent();
        }
        #endregion

        #region 定义参数
        BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Insert.PeiZaiFaHuoPeiZai_InsertClient myPeiZaiFaHuoPeiZai_Insert = new BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Insert.PeiZaiFaHuoPeiZai_InsertClient();
        int int司机ID = 0;//在选择司机的时候
        bool flagBaoCunChengGong = false;
        bool bolStartFinish = false;
        string strDanJuShu;
        #endregion
         
        #region 生成单据编号
        public string ShengChengDanHao()
        {
            strDanJuShu = myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuoPeiZai_Insert_SelectHuodanhao().Tables[0].Rows[0][0].ToString().Trim();
            switch (strDanJuShu.Length)
            {
                case 1:
                    strDanJuShu = "000" + strDanJuShu;
                    break;
                case 2:
                    strDanJuShu = "00" + strDanJuShu;
                    break;
                case 3:
                    strDanJuShu = "0" + strDanJuShu;
                    break;
                case 4:
                    strDanJuShu = "" + strDanJuShu;
                    break;
                default:
                    break;
            }
            DateTime dtnNow = DateTime.Now;
            string strYear = dtnNow.Year.ToString().Trim();
            string strMouth = dtnNow.Month.ToString().Trim();
            strMouth = (strMouth.Length == 1 ? "0" + strMouth : strMouth);
            string strDay = dtnNow.Day.ToString().Trim();
            strDay = (strDay.Length == 1 ? "0" + strDay : strDay);
            return "PZ" + strYear + strMouth + strDay + strDanJuShu;
        }
        #endregion

        #region Load事件加载发货网点、收货网点、车辆信息 
        private void FRM_PeiZaiFaHuoPeiZai_Insert_Load(object sender, EventArgs e)
        {
            #region 下拉框的绑定
            this.dgvPeiZaiFaHuoMingXi = PublicStaticMothd.SetDgv(dgvPeiZaiFaHuoMingXi);
            this.dgvPeiZaiFaHuoMingXi.ReadOnly = false;
            this.dgvSiJi = PublicStaticMothd.SetDgv(dgvSiJi);
            //始发网点下拉框
            DataTable dtFaHuoWangDian = myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_SelectcboWiangDian().Tables[0];
            cboFaHuoWangDian.DataSource = dtFaHuoWangDian;
            cboFaHuoWangDian.DisplayMember = "网点名称";
            cboFaHuoWangDian.ValueMember = "网点ID";
            cboFaHuoWangDian.SelectedIndex = -1;
            //收货网点下拉框
            DataTable dtMuDiWangDian = myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_SelectcboWiangDian().Tables[0];
            cboMuDiWangDian.DataSource = dtMuDiWangDian;
            cboMuDiWangDian.DisplayMember = "网点名称";
            cboMuDiWangDian.ValueMember = "网点ID";
            cboMuDiWangDian.SelectedIndex = -1;
            cboXianLuXuanZhe.Visible = false; 
            txtPeiZaiFaHuoDanBianHao.Text = ShengChengDanHao();
            //车辆信息下拉框
            DataTable dtCheliang = myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_SelectcboCheLiang().Tables[0];
            cboXuanZheCheLiang.DataSource = dtCheliang;
            cboXuanZheCheLiang.DisplayMember = "车牌号";
            cboXuanZheCheLiang.ValueMember = "车辆ID";
            #endregion
            dgvPeiZaiFaHuoMingXi.RowHeadersVisible = false;
            bolStartFinish = true;
        }
        #endregion

        #region 按钮查询司机点击事件
        private void btnChaXun_Click(object sender, EventArgs e)
        {
            DataTable dtSiJi = myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_SelectSiJi().Tables[0];
            dgvSiJi.DataSource = dtSiJi;
            dgvSiJi.Visible = true;
            dgvSiJi.RowHeadersVisible = false;
        } 
        #endregion

        #region 司机信息dgv双击选择司机
        private void dgvSiJi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSiJi.CurrentRow != null)
            {
                txtSiJiXingMing.Text = dgvSiJi.CurrentRow.Cells["司机名称"].Value.ToString().Trim();
                txtLianXieDanHua.Text = dgvSiJi.CurrentRow.Cells["联系电话"].Value.ToString().Trim();
                int司机ID = Convert.ToInt32(dgvSiJi.CurrentRow.Cells["司机ID"].Value.ToString().Trim());//隐藏的ID
                dgvSiJi.Hide();
            }
        }
        #endregion

        #region 按钮添加配载明细点击事件
        private void btnTianJiaMingXi_Click(object sender, EventArgs e)
       {
           //new FRM_PeiZaiFaHuoShiShiPeiZai(this);通过构造函数，
           //将本窗体作为参数传递到Pub_FRM_PeiZaiFaHuo_ShiShiPeiZai窗体。
           PublicStaticObject.Pub_FRM_PeiZaiFaHuo_ShiShiPeiZai = new FRM_PeiZaiFaHuoShiShiPeiZai(this);
           PublicStaticObject.Pub_FRM_PeiZaiFaHuo_ShiShiPeiZai.ShowDialog();
        }
        #endregion

        #region 按钮返回点击事件
        private void btnFanHui_Click(object sender, EventArgs e)
        {
            if (!flagBaoCunChengGong)
            {
                #region 返回时把分包锁定取消
                for (int i = 0; i < dgvPeiZaiFaHuoMingXi.Rows.Count; i++)
                {
                    myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value));
                }
                #endregion
            }
            this.Close();
        }
        #endregion

        #region 窗体关闭事件
        private void FRM_PeiZaiFaHuoPeiZai_Insert_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!flagBaoCunChengGong)//若保存失败，则解锁数据， bool flagBaoCunChengGong = false;
            {
                #region 返回时把分包锁定取消
                for (int i = 0; i < dgvPeiZaiFaHuoMingXi.Rows.Count; i++)
                {
                    myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value));
                }
                #endregion
            }
        }
        #endregion

        #region 按钮删除明细点击事件
        private void btnShanChuMingXi_Click(object sender, EventArgs e)
        {            
            for (int i =dgvPeiZaiFaHuoMingXi.Rows.Count-1; i >=0 ;i--)
            {
                if (Convert.ToBoolean(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["选择"].FormattedValue))
                {
                    #region 删除明细的时候把分包锁定取消
                    myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value));
                    #endregion
                    dgvPeiZaiFaHuoMingXi.Rows.RemoveAt(i);
                }
            }
        }
        #endregion

        #region 按钮重置点击事件
        private void btnChongZhi_Click(object sender, EventArgs e)//重置
        {
            txtSiJiXingMing.Text = "";
            txtLianXieDanHua.Text = "";
            cboFaHuoWangDian.SelectedIndex = 0;
            cboMuDiWangDian.SelectedIndex = 0;
            cboXianLuXuanZhe.SelectedIndex = 0;
            cboXuanZheCheLiang.SelectedIndex = 0; 
            dtpJieDanShiJian.Value = DateTime.Now;
            if (dgvPeiZaiFaHuoMingXi.Rows.Count>0)
           {
                for (int i = dgvPeiZaiFaHuoMingXi.Rows.Count - 1; i >= 0; i--)
                {
                        #region 删除明细的时候把分包锁定取消
                        myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value));
                        #endregion
                        dgvPeiZaiFaHuoMingXi.Rows.RemoveAt(i);
                }
            }
        }
        #endregion

        #region 按钮保存点击事件
        private void btnBaoCun_Insert_Click(object sender, EventArgs e)
      {
          string 配载发车单号 = txtPeiZaiFaHuoDanBianHao.Text; 
          int 车辆ID = Convert.ToInt32(cboXuanZheCheLiang.SelectedValue);
          int 发车网点ID  = Convert.ToInt32(cboFaHuoWangDian.SelectedValue);
          int 目的网点ID = Convert.ToInt32(cboMuDiWangDian.SelectedValue);
          DateTime 接单时间 = dtpJieDanShiJian.Value;
        if (cboXianLuXuanZhe.DataSource == null)
        {
            MessageBox.Show("请选择线路！");
            return;
        }
        int 线路ID = Convert.ToInt32(cboXianLuXuanZhe.SelectedValue);
        if (int司机ID == 0)
        {
            MessageBox.Show("请选择司机！");
        }
        else if (车辆ID == 0)
        {
            MessageBox.Show("无可用车辆！");
        }
        else
        {
             //新增配载发车单据，返回配载发车单ID
            int 配载发车单ID =  myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_InsertPeiZaiFaChe(
                配载发车单号, 车辆ID,int司机ID,发车网点ID, 线路ID,目的网点ID, 接单时间);
            int 新增明细成功统计 = 0;
            //根据配载发车单ID，遍历明细表，新增明细
            if (配载发车单ID > 0)
            {
                foreach (DataGridViewRow dgvr in dgvPeiZaiFaHuoMingXi.Rows)
                {
                    int 分包ID = (int)dgvr.Cells["分包ID"].Value;
                    新增明细成功统计 += myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_InsertPeiZaiFaCheMingXi(配载发车单ID,分包ID);
                }

                if (新增明细成功统计 == dgvPeiZaiFaHuoMingXi.Rows.Count)
                {
                    myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_UpdateCheLiangZhuangTai(车辆ID);
                    myPeiZaiFaHuoPeiZai_Insert.frmPeiZaiFaHuo_Insert_UpdateSiJiZhuangTai(int司机ID);
                    MessageBox.Show("新增成功！");
                }
                else
                {
                    MessageBox.Show("新增失败！");
                }
            } 
        }
        }
        #endregion

        #region  根据起始网点选择线路
        private void cboFaHuoWangDian_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (bolStartFinish == true)
          {
              int KaiShiWangDianID = Convert.ToInt32(cboFaHuoWangDian.SelectedValue);
              int JieShuWangDian = Convert.ToInt32(this.cboMuDiWangDian.SelectedValue);
              DataTable dtXianLu = myPeiZaiFaHuoPeiZai_Insert.cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(KaiShiWangDianID, JieShuWangDian).Tables[0];
              if (dtXianLu.Rows.Count > 0)
              {
                  cboXianLuXuanZhe.Visible = true; 
                  cboXianLuXuanZhe.DataSource = dtXianLu;
                  cboXianLuXuanZhe.ValueMember = "线路ID";
                  cboXianLuXuanZhe.DisplayMember = "线路名称";
                  lblTips.Visible = false;
              }
              else
              {
                  cboXianLuXuanZhe.DataSource = null;
                  cboXianLuXuanZhe.Visible = false;
                  lblTips.Text = "无符合条件的线路！";
                  lblTips.Visible = true;
              }
          }
        }
        #endregion

        #region 根据目的网点选择线路 
        private void cboMuDiWangDian_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (bolStartFinish == true)
          {
              int 发货网点ID = Convert.ToInt32(cboFaHuoWangDian.SelectedValue);
              int 目的网点ID = Convert.ToInt32(this.cboMuDiWangDian.SelectedValue);
           DataTable dtXianLu=   myPeiZaiFaHuoPeiZai_Insert.cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(发货网点ID, 目的网点ID).Tables[0];
           if (dtXianLu.Rows.Count > 0)
           {
               cboXianLuXuanZhe.Visible = true; 
               cboXianLuXuanZhe.DataSource = dtXianLu;
               cboXianLuXuanZhe.ValueMember = "线路ID";
               cboXianLuXuanZhe.DisplayMember = "线路名称";
               lblTips.Visible = false; 
           }
           else
           {
               cboXianLuXuanZhe.DataSource = null;
               cboXianLuXuanZhe.Visible = false;
               lblTips.Text = "无符合条件的线路！";
               lblTips.Visible = true;
           }
          }
        }
        #endregion  
    }
}
