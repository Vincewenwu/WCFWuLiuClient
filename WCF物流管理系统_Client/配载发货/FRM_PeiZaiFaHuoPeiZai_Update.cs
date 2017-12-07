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
    public partial class FRM_PeiZaiFaHuoPeiZai_Update : Form
    { 
        #region 构造方法
        public FRM_PeiZaiFaHuoPeiZai_Update(int FaCheID)
        {
            InitializeComponent();
            PeiZaiFaCheDanID = FaCheID;
        }
        #endregion

        #region 定义参数
        int PeiZaiFaCheDanID;
        int NewSiJiID = 0;
        int SiJiID = 0;
        int[] FenBaoID;
        int FenBaoIndex = 0;
        //int NewCheLiangID = 0;
        int CheLiangID = 0;
        int Count;
        int PeiZaiFaHuoDanID;
        bool bolStartFinish = false;        
        BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Update.PeiZaiFaHuoPeiZai_UpdateClient myPeiZaiFaHuoPeiZai_UpdateClient = 
            new BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Update.PeiZaiFaHuoPeiZai_UpdateClient();
        #endregion

        #region Load事件加载起始网点、目的网点、线路信息、配载发货单dgv、配载发货明细dgv、车辆信息
        private void FRM_PeiZaiFaHuoPeiZai_Update_Load(object sender, EventArgs e)
        {
            #region 下拉框的绑定
            //加载起始网点下拉框
            DataTable dtFaHuoWangDian = 
                myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Insert_SelectcboWiangDian().Tables[0];
            cboFaHuoWangDian.DataSource = dtFaHuoWangDian;
            cboFaHuoWangDian.DisplayMember = "网点名称";
            cboFaHuoWangDian.ValueMember = "网点ID";
            //加载目的网点下拉框
            DataTable dtMuDiWangDian = 
                myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Insert_SelectcboWiangDian().Tables[0];
            cboMuDiWangDian.DataSource = dtMuDiWangDian;
            cboMuDiWangDian.DisplayMember = "网点名称";
            cboMuDiWangDian.ValueMember = "网点ID";
            //加载线路下拉框
            DataTable dtXianLu = 
                myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Insert_SelectcboXianLu().Tables[0];
            cboXianLuXuanZhe.DataSource = dtXianLu;
            cboXianLuXuanZhe.DisplayMember = "线路名称";
            cboXianLuXuanZhe.ValueMember = "线路ID"; 
             #endregion
            //加载配载发货dgv
            this.dgvPeiZaiFaHuoMingXi = PublicStaticMothd.SetDgv(dgvPeiZaiFaHuoMingXi);
            dgvPeiZaiFaHuoMingXi.ReadOnly = false;
                      this.dgvSiJi = PublicStaticMothd.SetDgv(dgvSiJi);
            dgvPeiZaiFaHuoMingXi.RowHeadersVisible = false; 
            DataTable dtFaCheDan = 
                myPeiZaiFaHuoPeiZai_UpdateClient.
                FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaHuoDanBYPeiZaiFaHuoDanID(PeiZaiFaCheDanID).Tables[0];
            DataTable dtCheliang = 
                myPeiZaiFaHuoPeiZai_UpdateClient.
                frmPeiZaiFaHuo_Update_SelectcboCheLiang(Convert.ToInt32(dtFaCheDan.Rows[0]["车辆ID"].ToString())).Tables[0];
            //加载车辆信息下拉框
            cboXuanZheCheLiang.DataSource = dtCheliang;
            cboXuanZheCheLiang.DisplayMember = "车牌号";
            cboXuanZheCheLiang.ValueMember = "车辆ID";
            PeiZaiFaHuoDanID = Convert.ToInt32(dtFaCheDan.Rows[0]["配载发车单ID"].ToString());
            btnPeiZaiFaHuoDanBianHao.Text = dtFaCheDan.Rows[0]["配载发车单号"].ToString();
            cboFaHuoWangDian.SelectedValue = dtFaCheDan.Rows[0]["始发网点ID"].ToString();
            cboMuDiWangDian.SelectedValue = dtFaCheDan.Rows[0]["目的网点ID"].ToString();
            cboXianLuXuanZhe.SelectedValue = dtFaCheDan.Rows[0]["线路ID"].ToString();
            if (Convert.ToInt32(dtFaCheDan.Rows[0]["发车状态ID"].ToString()) == 1)
            {
                cboXuanZheCheLiang.Enabled = false;
            }
            else
            {
                cboXuanZheCheLiang.Enabled = true;
            }
            cboXuanZheCheLiang.SelectedValue = dtFaCheDan.Rows[0]["车辆ID"].ToString();
            SiJiID = Convert.ToInt32(dtFaCheDan.Rows[0]["司机ID"].ToString());
            CheLiangID = Convert.ToInt32(dtFaCheDan.Rows[0]["车辆ID"].ToString()); 
            txtSiJiXingMing.Text = dtFaCheDan.Rows[0]["司机名称"].ToString();
            txtLianXieDanHua.Text = dtFaCheDan.Rows[0]["联系电话"].ToString();
            DataTable dtMingXi = 
                myPeiZaiFaHuoPeiZai_UpdateClient.
                FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaHuoDanID(PeiZaiFaCheDanID).Tables[0];
            for (int i = 0; i < dtMingXi.Rows.Count; i++)
            {
                dgvPeiZaiFaHuoMingXi.Rows.Add();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["配载发车单明细ID"].Value = dtMingXi.Rows[i]["配载发车单明细ID"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value = dtMingXi.Rows[i]["分包ID"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["货物名称"].Value = dtMingXi.Rows[i]["货物名称"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["货物类别"].Value = dtMingXi.Rows[i]["货物类别"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["计量单位"].Value = dtMingXi.Rows[i]["计量单位"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包数量"].Value = dtMingXi.Rows[i]["分包数量"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["寄件网点"].Value = dtMingXi.Rows[i]["寄件网点"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["目的网点"].Value = dtMingXi.Rows[i]["目的网点"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["单据编号"].Value = dtMingXi.Rows[i]["单据编号"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["运费单价"].Value = dtMingXi.Rows[i]["运费单价"].ToString();
                Count++; 
            }
            FenBaoID = new int[Count];
             bolStartFinish = true;
        }
        #endregion

        #region 按钮查询点击事件
        private void btnChaXun_Click(object sender, EventArgs e)
        {
            DataTable dtSiJi = myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Update_SelectSiJiBySiJiID(SiJiID).Tables[0];//.frmPeiZaiFaHuo_Insert_SelectSiJi().Tables[0];
            dgvSiJi.DataSource = dtSiJi;
            dgvSiJi.Visible = true;
            dgvSiJi.RowHeadersVisible = false;
        }
        #endregion

        #region 按钮重置点击事件
        private void btnChongZhi_Click(object sender, EventArgs e)
        {
            #region 重置与加载时一样的代码
            DataTable dtFaCheDan = myPeiZaiFaHuoPeiZai_UpdateClient.FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaHuoDanBYPeiZaiFaHuoDanID(PeiZaiFaCheDanID).Tables[0];
            DataTable dtCheliang = myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Update_SelectcboCheLiang(Convert.ToInt32(dtFaCheDan.Rows[0]["状态ID"].ToString())).Tables[0];
            cboXuanZheCheLiang.DataSource = dtCheliang;
            cboXuanZheCheLiang.DisplayMember = "车牌号";
            cboXuanZheCheLiang.ValueMember = "车辆ID";
            btnPeiZaiFaHuoDanBianHao.Text = dtFaCheDan.Rows[0]["配载发车单号"].ToString();
            cboFaHuoWangDian.SelectedValue = dtFaCheDan.Rows[0]["始发网点ID"].ToString();
            cboMuDiWangDian.SelectedValue = dtFaCheDan.Rows[0]["目的网点ID"].ToString();
            cboXianLuXuanZhe.SelectedValue = dtFaCheDan.Rows[0]["线路ID"].ToString();
            cboXuanZheCheLiang.SelectedValue = dtFaCheDan.Rows[0]["车辆ID"].ToString();
            SiJiID = Convert.ToInt32(dtFaCheDan.Rows[0]["司机ID"].ToString());
            // DataTable dtSiJi = myPeiZaiFaHuoPeiZai_UpdateClient.FRM_PeiZaiFaHuoPeiZai_SiJiBySiJiID(SiJiID).Tables[0];
            txtSiJiXingMing.Text = dtFaCheDan.Rows[0]["司机名称"].ToString();
            txtLianXieDanHua.Text = dtFaCheDan.Rows[0]["联系电话"].ToString();
            #region 把新添加的删除再取消锁定
            if (dgvPeiZaiFaHuoMingXi.Rows.Count > 0)
            {
                for (int i = dgvPeiZaiFaHuoMingXi.Rows.Count - 1; i >= 0; i--)
                {
                    if (Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["配载发车单明细ID"].Value) == 0)
                    {
                        #region 删除明细的时候把分包锁定取消
                        myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value));
                        #endregion
                        dgvPeiZaiFaHuoMingXi.Rows.RemoveAt(i);
                    }
                }
            } 
            #endregion
            DataTable dtMingXi = myPeiZaiFaHuoPeiZai_UpdateClient.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaHuoDanID(PeiZaiFaCheDanID).Tables[0];
            for (int i = 0; i < dtMingXi.Rows.Count; i++)
            {
                dgvPeiZaiFaHuoMingXi.Rows.Add();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["配载发车单明细ID"].Value = dtMingXi.Rows[i]["配载发车单明细ID"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value = dtMingXi.Rows[i]["分包ID"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["货物名称"].Value = dtMingXi.Rows[i]["货物名称"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["货物类别"].Value = dtMingXi.Rows[i]["货物类别"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["计量单位"].Value = dtMingXi.Rows[i]["计量单位"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包数量"].Value = dtMingXi.Rows[i]["分包数量"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["寄件网点"].Value = dtMingXi.Rows[i]["寄件网点"].ToString();
                dgvPeiZaiFaHuoMingXi.Rows[i].Cells["目的网点"].Value = dtMingXi.Rows[i]["目的网点"].ToString();
                Count++; 
            #endregion
            } 
        }
        #endregion
          
        #region 按钮返回点击事件
        private void btnFanHui_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 按钮添加明细点击事件
        private void btnTianJiaMingXi_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_PeiZaiFaHuo_ShiShiPeiZai = new FRM_PeiZaiFaHuoShiShiPeiZai(this);
            PublicStaticObject.Pub_FRM_PeiZaiFaHuo_ShiShiPeiZai.ShowDialog();
        }
        #endregion

        #region 按钮保存点击事件
        private void btnBaoCun_Update_Click(object sender, EventArgs e)
        {
            int countDel;
            int countCel;
            int countMX=0;
            int countPZ=0;
            int countShuLiang=0;
            int NewCheLiangID = Convert.ToInt32(cboXuanZheCheLiang.SelectedValue);
            if (cboXianLuXuanZhe.DataSource == null)
            {
                MessageBox.Show("请选择线路！");
                return;
            }
            if (dgvPeiZaiFaHuoMingXi.Rows.Count > 0)
            {
                if (NewSiJiID == 0)
                {
                    NewSiJiID = SiJiID;
                }
                else
                {
                    myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(SiJiID);//之前选的司机取消任务状态
                    myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Insert_UpdateSiJiZhuangTai(NewSiJiID);//新司机变为任务状态
                }
                if (NewCheLiangID != CheLiangID)
                {
                    myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Insert_UpdateCheLiangZhuangTai(NewCheLiangID);//新车状态改为配载中
                    myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(CheLiangID);//原来的车改为空闲
                }
                DateTime JieDanShiJian = dtpJieDanShiJian.Value;
                int FaCheWangDianID = Convert.ToInt32(cboFaHuoWangDian.SelectedValue);
                int MuDiWangDianID = Convert.ToInt32(cboMuDiWangDian.SelectedValue);
                int XianLuID = Convert.ToInt32(cboXianLuXuanZhe.SelectedValue);
                countPZ = myPeiZaiFaHuoPeiZai_UpdateClient.
                    frmPeiZaiFaHuo_Update_UpdatePeiZaiFaCheDanByFaCheDanID(
                    NewCheLiangID, NewSiJiID, FaCheWangDianID, XianLuID, MuDiWangDianID, JieDanShiJian, PeiZaiFaHuoDanID);
                for (int i = 0; i < Count; i++)
                {
                    if (FenBaoID[i] != 0)
                    {
                        countCel = myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(FenBaoID[i]);
                        if (countCel > 0)
                        {
                            countDel = myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(FenBaoID[i]);
                        }
                    }
                }
                for (int i = 0; i < dgvPeiZaiFaHuoMingXi.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["配载发车单明细ID"].Value) == 0)
                    {
                        countShuLiang++;
                        countMX += myPeiZaiFaHuoPeiZai_UpdateClient.
                            frmPeiZaiFaHuo_Insert_InsertPeiZaiFaCheMingXi(
                            PeiZaiFaHuoDanID, Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value));
                    }
                }
            }
           else
           {
               MessageBox.Show("请添加明细！");
           }
            if (countPZ > 0 && (countShuLiang == countMX))
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改不成功！");
            }
        }
        #endregion
         
        #region dgv选择司机
        private void dgvSiJi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSiJi.CurrentRow != null)
            {
                txtSiJiXingMing.Text = dgvSiJi.CurrentRow.Cells["司机名称"].Value.ToString().Trim();
                txtLianXieDanHua.Text = dgvSiJi.CurrentRow.Cells["联系电话"].Value.ToString().Trim();
                NewSiJiID = Convert.ToInt32(dgvSiJi.CurrentRow.Cells["司机ID"].Value.ToString().Trim());//隐藏的ID
                dgvSiJi.Hide();
            }
        } 
        #endregion

        #region 明细表中已有的数据就保存在数组里，当点击保存的时候再删除明细ID并且分包表取消锁定，只在dgv不在明细表中的直接去除锁定移除行就可
        private void btnShanChuMingXi_Click(object sender, EventArgs e)
        {
            for (int i = dgvPeiZaiFaHuoMingXi.Rows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["选择"].FormattedValue))
                {
                    //如果配载发车单明细ID不为零，就说明这个配载分包是从数据库提出出来的旧数据
                    if (Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["配载发车单明细ID"].Value) != 0)
                    {
                        //记录下分包ID，把该分包从配载发货单明细表中删除，并解锁分包
                        FenBaoID[FenBaoIndex] = Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value);//暂时把明细ID保存在数组中。等到保存的时候把分包锁定取消和明细ID删除
                        FenBaoIndex++;
                    }
                    else
                    {
                        #region 在DGV但是还没生产明细单的数据直接在删除的时候去除锁定就好了
                        myPeiZaiFaHuoPeiZai_UpdateClient.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(Convert.ToInt32(dgvPeiZaiFaHuoMingXi.Rows[i].Cells["分包ID"].Value));
                        #endregion
                    }
                    dgvPeiZaiFaHuoMingXi.Rows.RemoveAt(i);
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
                DataTable dtXianLu = myPeiZaiFaHuoPeiZai_UpdateClient.cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(KaiShiWangDianID, JieShuWangDian).Tables[0];
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
                int KaiShiWangDianID = Convert.ToInt32(cboFaHuoWangDian.SelectedValue);
                int JieShuWangDian = Convert.ToInt32(this.cboMuDiWangDian.SelectedValue);
                DataTable dtXianLu = myPeiZaiFaHuoPeiZai_UpdateClient.cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(KaiShiWangDianID, JieShuWangDian).Tables[0];
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
