using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.出车登记
{
    public partial class FRM_ChuCheDengJi : Form
    { 
        #region 构造方法
        public FRM_ChuCheDengJi()
        {
            InitializeComponent();
        }
        #endregion
         
        #region 定义参数
         BLL物流管理系统.出车登记.FRM_ChuCheDengJi.FRM_ChuCheDengJiClient myFRM_ChuCheDengJiClient = new BLL物流管理系统.出车登记.FRM_ChuCheDengJi.FRM_ChuCheDengJiClient();      
        public DataTable dtCheLiang;
        string strCheLiangZhuangTaiID;
        string strCheLiangID;
        int intTuX;
        int intTuY;
        int intTuWidth;
        int intTuHeight;
        int 配载发车单ID = 0;
        #endregion

        #region Load事件定义窗体大小、窗体位置、起始网点、目的网点、状态、车辆信息
        private void FRM_ChuCheDengJi_Load(object sender, EventArgs e)
        {
            #region 定义窗体大小、窗体位置
            this.Left = PublicStaticObject.MainLeft;
            this.Top = PublicStaticObject.MainTop;
            this.Width = PublicStaticObject.MainWidth;
            this.Height = PublicStaticObject.MainHeight;
            #endregion
            dgvCheLiangPeiZaiXinXi.AllowUserToAddRows = false;
            DataTable dtWangDian =
                myFRM_ChuCheDengJiClient.
                FRM_ChuCheDengJi_Load_ChaXunWangDian().Tables[0];
            DataTable dtWangDian2 = dtWangDian.Copy();
            DataTable dtZhuangTai =
                myFRM_ChuCheDengJiClient.
                FRM_ChuCheDengJi_Load_ChaXunZhuangTai().Tables[0];
            //加载起始网点下拉框
            cboKaiShi.DataSource = dtWangDian;
            cboKaiShi.DisplayMember = "网点名称";
            cboKaiShi.ValueMember = "网点ID";
            //加载目的网点下拉框
            cboJieShu.DataSource = dtWangDian2;
            cboJieShu.DisplayMember = "网点名称";
            cboJieShu.ValueMember = "网点ID";
            //加载状态下拉框
            cboZhuangTai.DataSource = dtZhuangTai;
            cboZhuangTai.DisplayMember = "状态";
            cboZhuangTai.ValueMember = "状态ID";
            dgvCheLiangPeiZaiXinXi =PublicStaticMothd. SetDgv(dgvCheLiangPeiZaiXinXi);
            //查询车辆表
            dtCheLiang = myFRM_ChuCheDengJiClient.FRM_ChuCheDengJi_Load_ChaXunCheLiang().Tables[0];
            //生成车辆视图
            for (int i = 0; i < dtCheLiang.Rows.Count; i++)
            {
                PictureBox pb = new PictureBox();//创建一个图片框控件
                pb.Size = new Size(150,100);
                pb.Tag = dtCheLiang.Rows[i];//把当前行数据放到tag对象中
                int 车辆状态ID = (int)dtCheLiang.Rows[i]["状态ID"];
                switch (车辆状态ID)
                {
                    case 1: pb.BackgroundImage = Properties.Resources.停运; break;
                    case 2: pb.BackgroundImage = Properties.Resources.空闲; break;
                    case 3: pb.BackgroundImage = Properties.Resources.卸货; break;
                    case 4: pb.BackgroundImage = Properties.Resources.配载; break;
                    case 5: pb.BackgroundImage = Properties.Resources.运送; break;
                }
                pb.BackgroundImageLayout = ImageLayout.Stretch;
                pb.Paint += new PaintEventHandler(pb_Paint);
                pb.MouseEnter += new EventHandler(pb_MouseEnter);
                pb.MouseLeave += new EventHandler(pb_MouseLeave);
                pb.MouseClick += new MouseEventHandler(pb_MouseClick);
                flpCheLiang.Controls.Add(pb);//将pb添加到flp控件中
            }
        }
        #endregion

        #region 车辆图片点击事件
        void pb_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;//将sender转换成PictureBox
            DataRow dr = (DataRow)pb.Tag;//获取pb绑定的数据行
            strCheLiangZhuangTaiID = dr["状态ID"].ToString();
            strCheLiangID = dr["车辆ID"].ToString();
            配载发车单ID = (int)dr["配载发车单ID"];//获取配载发车单ID
            dgvCheLiangPeiZaiXinXi.DataSource =
                myFRM_ChuCheDengJiClient.pb_MouseClick_ChaXunMingXi(配载发车单ID).Tables[0];
            //提取配载发车单明细
            foreach (Control c in flpCheLiang.Controls)//遍历flp中的控件(flp中的PictureBox)
            {
                PictureBox pbc = c as PictureBox;
                DataRow drc = (DataRow)pbc.Tag;
                if (drc["配载发车单ID"].ToString() != 配载发车单ID.ToString())
                    //判断每个PictureBox的配载发车单ID是否跟当前点击的PictureBox的配载发车单ID相等，
                    //若不等则清除边框
                {
                    Pen pen = new Pen(flpCheLiang.BackColor, 4);
                    Graphics g = flpCheLiang.CreateGraphics();
                    Rectangle 矩形 = new Rectangle();
                    矩形.X = pbc.Location.X - 2;
                    矩形.Y = pbc.Location.Y - 2;
                    矩形.Width = pbc.Size.Width + 4;
                    矩形.Height = pbc.Size.Height + 4;
                    g.DrawRectangle(pen, 矩形);
                }
            }
        }
        #endregion

        #region 鼠标离开车辆图片事件
        void pb_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            DataRow dr = (DataRow)pb.Tag;
            if (dr["配载发车单ID"].ToString() != 配载发车单ID.ToString())
            {
                pb.Cursor = Cursors.Hand;
                Pen pen = new Pen(flpCheLiang.BackColor, 4);
                Graphics g = flpCheLiang.CreateGraphics();
                Rectangle 矩形 = new Rectangle();
                矩形.X = pb.Location.X - 2;
                矩形.Y = pb.Location.Y - 2;
                矩形.Width = pb.Size.Width + 4;
                矩形.Height = pb.Size.Height + 4;
                g.DrawRectangle(pen, 矩形);
            }
        }
        #endregion

        #region 鼠标点击车辆图片事件
        void pb_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Cursor = Cursors.Hand;
            Pen pen = new Pen(Color.Red,4);
            Graphics g = flpCheLiang.CreateGraphics();
            Rectangle 矩形 = new Rectangle();
            矩形.X = pb.Location.X - 2;
            矩形.Y = pb.Location.Y - 2;
            矩形.Width = pb.Size.Width + 4;
            矩形.Height = pb.Size.Height + 4;
            g.DrawRectangle(pen, 矩形);
        }
        #endregion

        #region 车辆图片绘制文字事件
        void pb_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            Graphics g = e.Graphics;
            DataRow dr = (DataRow)pb.Tag;
            string 司机名称 = dr["司机名称"].ToString().Trim();
            string 车牌号 = dr["车牌号"].ToString().Trim();
            string 状态 = dr["状态"].ToString().Trim();
            string 绘制字符串 = "车牌：" + 车牌号 + "\n"
                                + "司机：" + 司机名称 + "\n"
                                + "状态：" + 状态;
            Font 字体样式 = new System.Drawing.Font("微软雅黑",10,FontStyle.Bold);
            PointF 字符串坐标 = new PointF(10,5);
             g.DrawString(绘制字符串,字体样式,SystemBrushes.ActiveCaptionText,字符串坐标);
        }
        #endregion
         
        #region 菜单栏按钮关闭点击事件
        private void tsbGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 按钮查询单击事件
        private void btnChaXun_Select_Click(object sender, EventArgs e)
        {
            string strFaCheWangDianID = null;
            string strMuDIWangDianID = null;
            string strZhuangTaiID = null;
            string strSiJiMingCheng = null;
            if (chkQiZhiWangDian.Checked)
            {
                strFaCheWangDianID = cboKaiShi.SelectedValue.ToString();
                strMuDIWangDianID = cboJieShu.SelectedValue.ToString();
            }
            if (this.chkZhuangTai.Checked)
            {
                strZhuangTaiID = cboZhuangTai.SelectedValue.ToString();
            }
            if (chkSiJiXingMing.Checked)
            {
                strSiJiMingCheng = this.txtSiJiXingMing.Text.ToString();
            } 
          //  dtCheLiang = myFRM_CheLiangZhuangTaiClient.btnChaXun_Select_Click_DuoTiaoJianChaXunCheLiang(strFaCheWangDianID, strMuDIWangDianID, strZhuangTaiID, strSiJiMingCheng).Tables[0];
        }
        #endregion
       
        #region 菜单栏按钮出车点击事件
        private void tsbChuChe_Click(object sender, EventArgs e)
        {
            if (strCheLiangZhuangTaiID == null)
            {
                MessageBox.Show("请选择车辆！");
                return;
            }   
            if (strCheLiangZhuangTaiID != "1" && strCheLiangZhuangTaiID != "5")
            {
                int result=myFRM_ChuCheDengJiClient.FRM_ChuCheDengJi_tsbChuChe_Click_UpdateChuChe
                    (Convert.ToInt32(strCheLiangID)); 
                if(result>0)
                {
                    MessageBox.Show("出车成功！");
                }
                else
                {
                    MessageBox.Show("出车失败！");
                }
            }
            else
            {
                MessageBox.Show("停运或者运输中的车辆无法出车！");
            } 
        }
        #endregion

    }
}
