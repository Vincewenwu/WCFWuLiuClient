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
    public partial class  FRM_DaoDaDengJi : Form
    { 
        #region 构造方法
        public FRM_DaoDaDengJi()
        {
            InitializeComponent();
        }
        #endregion
         
        #region 定义参数
        BLL物流管理系统.出车登记.FRM_DaoDaDengJi.FRM_DaoDaDengJiClient myFRM_DaoDaDengJiClient = 
            new BLL物流管理系统.出车登记.FRM_DaoDaDengJi.FRM_DaoDaDengJiClient();   
        public DataTable dtCheLiang;
        string strCheLiangID;
        int intTuX;
        int intTuY;
        int intTuWidth;
        int intTuHeight;
        string strZhuangTaiID;
        #endregion

        #region Load事件定义窗体位置、窗体大小，加载起始网点、目的网点、状态、到达网点
        private void FRM_DaoDaDengJi_Load(object sender, EventArgs e)
        {
            #region 定义窗体位置、窗体大小
            this.Left = PublicStaticObject.MainLeft;
            this.Top = PublicStaticObject.MainTop;
            this.Width = PublicStaticObject.MainWidth;
            this.Height = PublicStaticObject.MainHeight;
            #endregion
            dgvCheLiangPeiZaiXinXi.AllowUserToAddRows = false;
            DataTable dtWangDian = myFRM_DaoDaDengJiClient.
                FRM_DaoDaDengJi_Load_ChaXunWangDian().Tables[0];
            DataTable dtWangDian2 = dtWangDian.Copy();
            DataTable dtWangDian3 = dtWangDian.Copy();
            DataTable dtZhuangTai = myFRM_DaoDaDengJiClient.
                FRM_DaoDaDengJi_Load_ChaXunZhuangTai().Tables[0];
            //绑定起始网点
            cboKaiShi.DataSource = dtWangDian;
            cboKaiShi.DisplayMember = "网点名称";
            cboKaiShi.ValueMember = "网点ID";
            //绑定目标网点
            cboJieShu.DataSource = dtWangDian2;
            cboJieShu.DisplayMember = "网点名称";
            cboJieShu.ValueMember = "网点ID";
            //绑定状态
            cboZhuangTai.DataSource = dtZhuangTai;
            cboZhuangTai.DisplayMember = "状态";
            cboZhuangTai.ValueMember = "状态ID";
            //绑定到达网点
            this.cboDaoDa.DataSource = dtWangDian3;
            cboDaoDa.DisplayMember = "网点名称";
            cboDaoDa.ValueMember = "网点ID";
            //绑定车辆配载信息dgv
            dgvCheLiangPeiZaiXinXi = PublicStaticMothd.SetDgv(dgvCheLiangPeiZaiXinXi);
             dtCheLiang = myFRM_DaoDaDengJiClient.
                FRM_DaoDaDengJi_Load_ChaXunQuanBuCheLiang().Tables[0]; //查询车辆表
            createPictuerBoxstrCarList(dtCheLiang); 
        }
        #endregion

        #region 菜单栏关闭按钮单击事件
        private void tsbGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 生成图片
        public void createPictuerBoxstrCarList(DataTable dtCheLiang)
        {
            flpCheLiang.Controls.Clear();
            flpCheLiang.AutoScroll = true;//超出panel是显示滚动条
            foreach (DataRow myRowChe in dtCheLiang.Rows)
            {
                #region 根据车辆表、车辆序数动态创建车辆视图
                PictureBox myPictureBox = new PictureBox();
                myPictureBox.Tag = myRowChe["车辆ID"].ToString();//绑定位置 
                myPictureBox.Size = new Size(150, 100);
                int tag = Convert.ToInt32(myPictureBox.Tag);
                int strCarStatusID = Convert.ToInt32(myRowChe["状态ID"]); 
                string strCarName = myRowChe["车牌号"].ToString().Trim(); 
                    switch (strCarStatusID)//设置不同车辆状态显示不同颜色
                    {
                    case 1: myPictureBox.BackgroundImage = Properties.Resources.停运2; break;
                    case 2: myPictureBox.BackgroundImage = Properties.Resources.空闲2; break;
                    case 3: myPictureBox.BackgroundImage = Properties.Resources.卸货; break;
                    case 4: myPictureBox.BackgroundImage = Properties.Resources.配载; break;
                    case 5: myPictureBox.BackgroundImage = Properties.Resources.运送; break;
                    }
                myPictureBox.BackgroundImageLayout = ImageLayout.Stretch;  
                myPictureBox.Click += new EventHandler(myPictureBox_Click);
                myPictureBox.MouseEnter += new EventHandler(myPictureBox_MouseEnter);
                myPictureBox.MouseLeave += new EventHandler(myPictureBox_MouseLeave);
                myPictureBox.Paint += new PaintEventHandler(myPictureBox_Paint);
                this.flpCheLiang.Controls.Add(myPictureBox);
                #endregion
            }
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

             createPictuerBoxstrCarList(dtCheLiang);
        }
        #endregion

        #region 取消显示选中框
        void myPictureBox_MouseLeave(object sender, EventArgs e)
        {
            
            PictureBox pb = sender as PictureBox;
            if(pb.Tag.ToString()!=strCheLiangID)
            {
            Pen pen = new Pen(flpCheLiang.BackColor, 5);//用于绘图
            Graphics gra = flpCheLiang.CreateGraphics();
            gra.DrawRectangle(pen, new Rectangle(pb.Location.X - 1, 
                pb.Location.Y, pb.Size.Width, pb.Size.Height)); //用于透明绘图
             }
        }
        #endregion

        #region 增加显示选中框
        void myPictureBox_MouseEnter(object sender, EventArgs e)
        {

            PictureBox pb = sender as PictureBox;
            pb.Cursor = Cursors.Hand;//显示手指按钮 
            Pen pen = new Pen(Color.Red, 5);//用于绘图
            Graphics gra = flpCheLiang.CreateGraphics();
            gra.DrawRectangle(pen, new Rectangle(pb.Location.X - 1, 
                pb.Location.Y, pb.Size.Width, pb.Size.Height)); //用于绘图

        }
        #endregion

        #region 绘制车牌，状态，司机等文字
        void myPictureBox_Paint(object sender, PaintEventArgs e)
        {
            #region 为动态创建的车辆视图绑定显示的数据
            PictureBox pb = sender as PictureBox;
            Graphics g = e.Graphics;
            int tag = Convert.ToInt32(pb.Tag);
            DataTable myDataTable = dtCheLiang;
            foreach (DataRow myRow in myDataTable.Rows)
            {
                if (Convert.ToInt32(myRow["车辆ID"]) == tag)
                {
                    string strCarName = myRow["车牌号"].ToString().Trim();
                    string strDriverName = myRow["司机名称"].ToString().Trim();
                    string strCarStatus = myRow["状态"].ToString().Trim();
                    g.DrawString("车牌：" + strCarName + "\n" + "状态：" + strCarStatus 
                        + "\n" + "司机：" + strDriverName, new Font("宋体", 10, FontStyle.Bold), 
                        SystemBrushes.ActiveCaptionText, new PointF(10, 5));
                }
            }
            #endregion
        }
        #endregion

        #region 图片单击事件
        void myPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb.Tag.ToString() != strCheLiangID)
            {
                Pen pen = new Pen(flpCheLiang.BackColor, 5);//用于绘图
                Graphics gra = flpCheLiang.CreateGraphics();
                gra.DrawRectangle(pen, new Rectangle(intTuX - 1, intTuY, intTuWidth, intTuHeight)); //用于透明绘图 
            } 
            strCheLiangID = pb.Tag.ToString();
         
            intTuX = pb.Location.X;
            intTuY = pb.Location.Y;
            intTuWidth = pb.Size.Width;
            intTuHeight = pb.Size.Height;
            DataTable myDataTable = myFRM_DaoDaDengJiClient.
                pb_MouseClick_ChaXunMingXi(Convert.ToInt32(strCheLiangID)).Tables[0];
            dgvCheLiangPeiZaiXinXi.DataSource = myDataTable;
        }
        #endregion

        #region 到达单击事件
        private void btnDaoDa_Click(object sender, EventArgs e)
        {
             if (strCheLiangID == null)
            {
                MessageBox.Show("请选择车辆！");
                return;
            }
            strZhuangTaiID = 
                myFRM_DaoDaDengJiClient.
                FRM_DaoDaDengJi_IDChaXunCheLiangZhuangTai(
                    Convert.ToInt32(strCheLiangID)).Tables[0].Rows[0][0].ToString();
             if (strZhuangTaiID == "5")
            {
                string strWangDianID = cboDaoDa.SelectedValue.ToString();
                int i = myFRM_DaoDaDengJiClient.btnDaoDa_Click_ChaXunFaCheDian(
                    strCheLiangID, strWangDianID);//插入跟踪信息，某车辆到达某个网点

                if (i > 0)
                {
                    MessageBox.Show("车辆到达成功！");
                }
                else { MessageBox.Show("车辆到达失败！"); }
            }
            else { MessageBox.Show("只有运送中的车辆才能到达！"); }

        }
        #endregion  
    }
}
