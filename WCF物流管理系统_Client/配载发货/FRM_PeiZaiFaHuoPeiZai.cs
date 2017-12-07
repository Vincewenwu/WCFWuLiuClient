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
    public partial class FRM_PeiZaiFaHuoPeiZai : Form
    {
        #region 构造方法
        public FRM_PeiZaiFaHuoPeiZai()
        {
            InitializeComponent();
        }
        #endregion

        #region 定义参数
        BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai.PeiZaiFaHuoPeiZaiClient myPeiZaiFaHuoPeiZaiClient = 
            new BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai.PeiZaiFaHuoPeiZaiClient();
        int FaCheID =0;
        int FaCheZhuangTaiID =0;
        int SiJiID=0;
        int CheLiangID=0;
        int XianLuID = 0;
        DataTable dtFaCheZhuangTai = new DataTable();
        #endregion

        #region 菜单栏关闭按钮点击事件
        private void tsbGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region  Load事件设置窗体大小、窗体位置、加载配载发货单、加载车辆状态     
        private void FRM_PeiZaiFaHuoPeiZai_Load(object sender, EventArgs e)
        { 
            #region 定义窗体位置、窗体大小
            this.Left = PublicStaticObject.MainLeft;
            this.Top = PublicStaticObject.MainTop;
            this.Width = PublicStaticObject.MainWidth;
            this.Height = PublicStaticObject.MainHeight; 
            #endregion
            #region 加载配载发车单dgv和配载发车明细单dgv
            dtpJieShu.Value = dtpJieShu.Value.AddDays(1);
            this.dgvPeiZaiFaCheDan = PublicStaticMothd.SetDgv(dgvPeiZaiFaCheDan);
            this.dgvPeiZaiFaCheMingXi = PublicStaticMothd.SetDgv(dgvPeiZaiFaCheMingXi);  
            dtFaCheZhuangTai = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_Load_SelectFaCheZhuangTai().Tables[0];
            #endregion             
            #region 查询配载发货单表 
            DataTable dtPeiZaiFaHuoDan = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan().Tables[0];
            dgvPeiZaiFaCheDan.DataSource = dtPeiZaiFaHuoDan; 
            //加载车辆状态
            DataTable dtFACheZhuangTai = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_SelectCboFaCheZhaungTai().Tables[0];
            cboZhuangTai.DataSource = dtFACheZhuangTai;
            cboZhuangTai.DisplayMember = "发车状态";
            cboZhuangTai.ValueMember = "发车状态ID";
            #endregion
        }
        #endregion

        #region 菜单栏新增发车登记单按钮点击事件
        private void tsbXinZengFaCheDan_Insert_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_PeiZaiFaHuoPeiZai_Insert = new  FRM_PeiZaiFaHuoPeiZai_Insert();
            PublicStaticObject.Pub_FRM_PeiZaiFaHuoPeiZai_Insert.ShowDialog();
            #region 查询配载发货单表， 
            DataTable dtPeiZaiFaHuoDan = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan().Tables[0];
            dgvPeiZaiFaCheDan.DataSource = dtPeiZaiFaHuoDan;
            #endregion
            dgvPeiZaiFaCheMingXi.DataSource = "";
        } 
        #endregion

        #region 菜单栏修改发车登记单按钮点击事件
       private void tsbXiuGaiFaCheDan_Update_Click(object sender, EventArgs e)
        {
            if (FaCheID != 0)
            {
                DataTable dtFaCheZhuangTai = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_SelectFaCheZhuangTaiByPeiZaiFaCheID(FaCheID).Tables[0];
              if (Convert.ToInt32(dtFaCheZhuangTai.Rows[0]["发车状态ID"].ToString()) == 1 || Convert.ToInt32(dtFaCheZhuangTai.Rows[0]["发车状态ID"].ToString()) == 4)
                {
                    PublicStaticObject.Pub_FRM_PeiZaiFaHuoPeiZai_Update = new FRM_PeiZaiFaHuoPeiZai_Update(FaCheID);
                    PublicStaticObject.Pub_FRM_PeiZaiFaHuoPeiZai_Update.ShowDialog();
                    #region 刷新页面数据
                    DataTable dtPeiZaiFaHuoDan = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan().Tables[0];
                    dgvPeiZaiFaCheDan.DataSource = dtPeiZaiFaHuoDan;
                    FaCheID = 0;
                    FaCheZhuangTaiID = 0;
                    SiJiID = 0;
                    CheLiangID = 0;
                    dgvPeiZaiFaCheMingXi.DataSource = ""; 
                    #endregion
                }
                else
                {
                    MessageBox.Show("此配载单不能修改！");
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的数据！");
            }
        }
        #endregion

        #region 菜单栏删除发车登记单按钮点击事件
        private void tsbShangChuFaCheDan_Delete_Click(object sender, EventArgs e)
       {           
            DialogResult dr = MessageBox.Show("是否删除？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//弹出确定对话框
            if (dr == DialogResult.OK)//如果点了确定按钮
            {
                int countConcel = 0;
                int countDelMingXi = 0;
                int countDelPeiZaiDan = 0;
                if (FaCheID != 0)
                {
                    if (FaCheZhuangTaiID == 4)
                    {
                        if (SiJiID != 0 && CheLiangID != 0)
                        {
                            myPeiZaiFaHuoPeiZaiClient.frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(SiJiID);
                            myPeiZaiFaHuoPeiZaiClient.frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(CheLiangID);
                            DataTable dtMingXi = 
                                myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaCheID(FaCheID).Tables[0];
                            for (int i = 0; i < dtMingXi.Rows.Count; i++)
                            {
                                countConcel += 
                                    myPeiZaiFaHuoPeiZaiClient.
                                    frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(Convert.ToInt32(dtMingXi.Rows[i]["分包ID"]));
                                countDelMingXi += 
                                    myPeiZaiFaHuoPeiZaiClient.
                                    frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(Convert.ToInt32(dtMingXi.Rows[i]["分包ID"]));
                            }
                            if (countConcel != 0 && countDelMingXi == countConcel)
                            {
                                countDelPeiZaiDan = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanByID(FaCheID);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("发车状态为“待配载”才能删除。。。");
                    }
                    if (countDelPeiZaiDan > 0)
                    {
                        MessageBox.Show("删除成功。。。");
                        #region 查询配载发货单表，刷新页面数据
                        FaCheID = 0;
                        FaCheZhuangTaiID = 0;
                        SiJiID = 0;
                        CheLiangID = 0;
                        DataTable dtPeiZaiFaHuoDan = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan().Tables[0];
                        dgvPeiZaiFaCheDan.DataSource = dtPeiZaiFaHuoDan;
                        #endregion
                        dgvPeiZaiFaCheMingXi.DataSource = "";
                    }
                }
                else
                {
                    MessageBox.Show("请选择要删除的行。。");
                }
            }
        }
        #endregion

        #region 按钮查询点击事件
        private void btnChaXun_Select_Click(object sender, EventArgs e)
      {
          string DingDanbianHao = txtPeiZaiFaCheDanHao.Text.ToString();
          DateTime QiShiShiJian = dtpKaiShi.Value;
          DateTime JieShuShiJian = dtpJieShu.Value;
          int FaCheZhuangTaiID = Convert.ToInt32(cboZhuangTai.SelectedValue);

          if (chkPeiZaiFaCheDanHao.Checked == false)
          {
              DingDanbianHao = "";

          }
          if (chkRiQi.Checked == false)
          {
              QiShiShiJian = Convert.ToDateTime("1991-09-13");
              JieShuShiJian = Convert.ToDateTime("1991-09-13");
          }
          if (chkZhuangTai.Checked == false)
          {
              FaCheZhuangTaiID = 0;
          }
           DataTable dtPeiZaiDan =  myPeiZaiFaHuoPeiZaiClient.
                FRM_PeiZaiFaHuoPeiZai_MoHuSelectPeiZaiFaCheDan(
               QiShiShiJian, JieShuShiJian, FaCheZhuangTaiID, DingDanbianHao).Tables[0];
           dgvPeiZaiFaCheDan.DataSource = dtPeiZaiDan;
        }
        #endregion

        #region 绘制发车状态dgv颜色
        private void dgvPeiZaiFaCheDan_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
      {
          if (e.ColumnIndex == 10)//若绘制的单元格是“发车状态”对应的单元格
          {
              e.Paint(e.CellBounds, DataGridViewPaintParts.All);
              e.Handled = true;//挂起（取消）本来的绘制事件
              string s = (e.FormattedValue as string).Trim();
              int sIndex = -1;
              string strKeyWord = "";
              string strKeyColor = "";
              foreach (DataRow dr in dtFaCheZhuangTai.Rows)
              {
                  //s ?? ""，判断s是否为null，若是，则返回""，若否，则返回s
                  sIndex = (s ?? "").IndexOf(dr["发车状态"].ToString());
                  if (sIndex > -1)
                  {
                      strKeyWord = dr["发车状态"].ToString().Trim();
                      strKeyColor = dr["状态颜色"].ToString().Trim();
                      break;
                  }
              }
              if (sIndex == -1)
                  return;
              var g = e.Graphics;
              var sz = g.MeasureString(strKeyWord, e.CellStyle.Font);
              var bound = new RectangleF(0, 0, sz.Width, e.CellBounds.Height);
              bound.Offset(e.CellBounds.Location);
              ColorConverter cc = new ColorConverter();
              e.CellStyle.ForeColor = (Color)cc.ConvertFromString(strKeyColor);
              var orgClip = g.ClipBounds;
              g.SetClip(bound);
              e.PaintContent(Rectangle.Round(bound));
              g.SetClip(orgClip);
          };
        }
        #endregion

        #region 按钮出车申请点击事件
        private void btnChuCheShenQing_Click(object sender, EventArgs e)
      {
          int 发车状态ID = (int)dgvPeiZaiFaCheDan.CurrentRow.Cells["发车状态ID"].Value;
          if (发车状态ID == 4)
          {
              int 配载发车单ID = (int)dgvPeiZaiFaCheDan.CurrentRow.Cells["配载发车单ID"].Value;
              int count = myPeiZaiFaHuoPeiZaiClient.FRM_PeiZaiFaHuoPeiZai_btnChuCheShenQing_Click_UpdateCheLiangZhuangTai(
                    配载发车单ID
                  );
              if (count > 0)
              {
                  MessageBox.Show("提交发车申请成功！");
                  FRM_PeiZaiFaHuoPeiZai_Load(null,null);
              }
              else
              {
                  MessageBox.Show("提交发车申请失败！");
              }
          }
          else
          {
              MessageBox.Show("只有待配载的发车单才能提交发车申请！");
          }
        }
        #endregion

        #region 点击配载发车单dgv加载配载发车单明细
        private void dgvPeiZaiFaCheDan_SelectionChanged(object sender, EventArgs e)
      {
          if (dgvPeiZaiFaCheDan.CurrentRow != null)
          {
              FaCheID = Convert.ToInt32(dgvPeiZaiFaCheDan.CurrentRow.Cells["配载发车单ID"].Value);
              FaCheZhuangTaiID = Convert.ToInt32(dgvPeiZaiFaCheDan.CurrentRow.Cells["发车状态ID"].Value);
              SiJiID = Convert.ToInt32(dgvPeiZaiFaCheDan.CurrentRow.Cells["司机ID"].Value);
              CheLiangID = Convert.ToInt32(dgvPeiZaiFaCheDan.CurrentRow.Cells["车辆ID"].Value);
              XianLuID = Convert.ToInt32(dgvPeiZaiFaCheDan.CurrentRow.Cells["线路ID"].Value);
              DataTable dtXianLuWAngDian = myPeiZaiFaHuoPeiZaiClient.
                    FRM_PeiZaiFaHuoPeiZai_SelectWangDianByByXianLu(XianLuID).Tables[0];
              tvwWangDian.Nodes.Clear();
              for (int i = 0; i < dtXianLuWAngDian.Rows.Count; i++)//处理每行数据
              {
                  //if( i==  )
                  TreeNode trn_网点 = new TreeNode(dtXianLuWAngDian.Rows[i]["网点名称"].ToString());
                    //创建树节点，显示文本为该行的班级名
                  int 网点ID = Convert.ToInt32(dtXianLuWAngDian.Rows[i]["网点ID"].ToString());//绑定班级ID
                  trn_网点.Tag = 网点ID;
                  tvwWangDian.Nodes.Add(trn_网点);//将该加点添加到树形控件的节点集合

              }
              DataTable dtMingXi = myPeiZaiFaHuoPeiZaiClient.
                    FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaCheID(FaCheID).Tables[0];

              dgvPeiZaiFaCheMingXi.DataSource = dtMingXi;
          }
        }
        #endregion

        #region 右键新增发车单点击事件
        private void 新增发车单ToolStripMenuItem_Click(object sender, EventArgs e)
      {
          tsbXinZengFaCheDan_Insert_Click(null,null);
        }
        #endregion 
    }
}
