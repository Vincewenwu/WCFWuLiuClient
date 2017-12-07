using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.车辆状态
{
    public partial class FRM_CheLiangZhuangTai : Form
    {
        public FRM_CheLiangZhuangTai()
        {
            InitializeComponent();
        }

       
        # region 声明全局变量
        BLL物流管理系统.车辆状态.FRM_CheLiangZhuangTai.FRM_CheLiangZhuangTaiClient myFRM_CheLiangZhuangTaiClient = new BLL物流管理系统.车辆状态.FRM_CheLiangZhuangTai.FRM_CheLiangZhuangTaiClient();//实例化bll对象
       public DataTable dtCheLiang;
        string strCheLiangID;
        string strCheLiangIDY;
        int intTuX;
        int intTuY;
        int intTuWidth;
        int intTuHeight;
        #endregion
        #region 窗体加载事件
        private void FRM_CheLiangZhuangTai_Load(object sender, EventArgs e)
        { 
            //设定窗体位置和大小
            this.Left = PublicStaticObject.MainLeft;
            this.Top = PublicStaticObject.MainTop;
            this.Width = PublicStaticObject.MainWidth;
            this.Height = PublicStaticObject.MainHeight;
            DataTable dtWangDian = myFRM_CheLiangZhuangTaiClient.FRM_CheLiangZhuangTai_Load_ChaXunWangDian().Tables[0];//查询所有网点
            DataTable dtWangDian2 = dtWangDian.Copy();       //复制dtWangDian再赋值给dtWangDian2
            DataTable dtZhuangTai = myFRM_CheLiangZhuangTaiClient.FRM_CheLiangZhuangTai_Load_ChaXunZhuangTai().Tables[0];//查询状态表
            cboKaiShi.DataSource = dtWangDian;     //设定cboKaiShi的数据源为dtWangDian
            cboKaiShi.DisplayMember = "网点名称";   //设定cboKaiShi的显示成员为列名为“网点名称”的列 
            cboKaiShi.ValueMember = "网点ID";       //设定cboKaiShi的值成员为列名为“网点ID”的列
            cboJieShu.DataSource = dtWangDian2;
            cboJieShu.DisplayMember = "网点名称";
            cboJieShu.ValueMember = "网点ID";
            cboZhuangTai.DataSource = dtZhuangTai;
            cboZhuangTai.DisplayMember = "状态";
            cboZhuangTai.ValueMember = "状态ID";
            //加载右键菜单的状态选项
            for (int i=0; i < dtZhuangTai.Rows.Count; i++)
            {
               ToolStripMenuItem tbsmiCaiDan = new ToolStripMenuItem();//实例化对象
               tbsmiCaiDan.Text = dtZhuangTai.Rows[i]["状态"].ToString().Trim();//设置显示的文本
               tbsmiCaiDan.Tag = dtZhuangTai.Rows[i]["状态ID"].ToString().Trim();//设置键值
               cmsYouJianCaiDan.Items.Add(tbsmiCaiDan);//把菜单加到菜单控件中
               tbsmiCaiDan.Click += new EventHandler(ToolStripMenuItem_Click);//tbsmiCaiDan方法加载到菜单对象的单击事件中
               
            }
             dtCheLiang=myFRM_CheLiangZhuangTaiClient.FRM_CheLiangZhuangTai_Load_ChaXunQuanBuCheLiang().Tables[0];
               createPictuerBoxstrCarList(dtCheLiang );//生成车辆视图
        
        }
        #endregion
        #region 添加按钮的单击事件
        private void tsbXinZeng_Insert_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_CheLiangZhuangTai_Insert = new FRM_CheLiangZhuangTai_Insert();
            PublicStaticObject.Pub_FRM_CheLiangZhuangTai_Insert.ShowDialog(); 
        }
        #endregion
        #region 修改按钮的单击事件
        private void tsbXiuGai_Update_Click(object sender, EventArgs e)
        {
            if (strCheLiangID == null)
            {
                MessageBox.Show("请选择车辆");
                return;
            }
            PublicStaticObject.Pub_FRM_CheLiangZhuangTai_Update = new FRM_CheLiangZhuangTai_Update();
            PublicStaticObject.Pub_FRM_CheLiangZhuangTai_Update.strCheLiangID = strCheLiangID;  //给Pub_FRM_CheLiangZhuangTai_Update对象的strCheLiangID成员变量为strCheLiangID
            PublicStaticObject.Pub_FRM_CheLiangZhuangTai_Update.ShowDialog();
              createPictuerBoxstrCarList( dtCheLiang);  //修改数据后刷新显示
        }
        #endregion
        #region 删除按钮的单击事件
        private void tsbShanChu_Delete_Click(object sender, EventArgs e)
        {
            if (strCheLiangID == null)
            {
                MessageBox.Show("请选择车辆");
                return;
            }
           DialogResult dr= MessageBox.Show("是否删除？","系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//获取确定对话框的值
            if (dr == DialogResult.OK)//如果点击了确定按钮
            {
                int i =myFRM_CheLiangZhuangTaiClient.tsbShanChu_Delete_Click_ShanChuCheLiang(strCheLiangID);//根据车辆ID删除车辆

          if (i > 0) 
          { 
              MessageBox.Show("删除成功！");
              //刷新数据
               createPictuerBoxstrCarList(dtCheLiang );
          }
              else { MessageBox.Show("删除失败！"); }
            }  
        }
        #endregion
        #region 关闭按钮单击事件
        private void tsbGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 查询单击事件
        private void btnChaXun_Select_Click(object sender, EventArgs e)
        {
            //初始化变量
            string strFaCheWangDianID = null;
            string strMuDIWangDianID = null;
            string strZhuangTaiID = null;
            string strSiJiMingCheng = null;
            if (chkQiZhiWangDian.Checked)//如果起止网点的复选框打勾
            {
                //给网点变量赋值
                strFaCheWangDianID = cboKaiShi.SelectedValue.ToString();
                strMuDIWangDianID = cboJieShu.SelectedValue.ToString();
            }
            if (this.chkZhuangTai.Checked)//如果状态复选框打勾
            {
                //给状态ID变量赋值
                strZhuangTaiID = cboZhuangTai.SelectedValue.ToString();
            }
            if (chkSiJiXingMing.Checked)//如果司机名复选框打勾
            {    //给司机名变量赋值
                strSiJiMingCheng = this.txtSiJiXingMing.Text.ToString();
            }
            //刷新数据

        DataTable    dtCheLiang = myFRM_CheLiangZhuangTaiClient.btnChaXun_Select_Click_DuoTiaoJianChaXunCheLiang(strFaCheWangDianID, strMuDIWangDianID, strZhuangTaiID, strSiJiMingCheng).Tables[0];

              createPictuerBoxstrCarList( dtCheLiang);

        }
        #endregion
        #region 生成汽车图片
        void creatstrCarShiTu(string strCheLiangID,  int leftX, int leftY)
        {
            #region 根据车辆表、车辆序数、相对容器x、y坐标动态创建车辆视图
            PictureBox myPictureBox = new PictureBox(); //实例化图片对象
            myPictureBox.Tag = strCheLiangID;//绑定位置 
            myPictureBox.Size = new Size(150, 100);//设定对象的大小
            myPictureBox.Location = new Point(leftX, leftY);//设定位置：相对于容器位置
            int tag = Convert.ToInt32(myPictureBox.Tag); //获取图片对应的车辆ID值
            DataTable myDataTable = myFRM_CheLiangZhuangTaiClient.FRM_CheLiangZhuangTai_Load_ChaXunQuanBuCheLiang().Tables[0];//查询车辆
            foreach (DataRow myRow in myDataTable.Rows)
            {
                if (Convert.ToInt32(myRow["车辆ID"]) == tag)
                {
                    string strCarName = myRow["车牌号"].ToString().Trim();
                    int strCarStatusID = Convert.ToInt32(myRow["状态ID"]);
                    switch (strCarStatusID)//设置不同车辆状态显示不同颜色
                    {
                        case 1: myPictureBox.BackgroundImage = Properties.Resources.停运2; break;//如果状态ID为1则把图片对象的背景图片设为停运2
                        case 2: myPictureBox.BackgroundImage = Properties.Resources.空闲2; break;//如果状态ID为2则把图片对象的背景图片设为空闲2
                        case 3: myPictureBox.BackgroundImage = Properties.Resources.卸货; break;//如果状态ID为3则把图片对象的背景图片设为卸货
                        case 4: myPictureBox.BackgroundImage = Properties.Resources.配载; break;//如果状态ID为4则把图片对象的背景图片设为配载
                        case 5: myPictureBox.BackgroundImage = Properties.Resources.运送; break;//如果状态ID为5则把图片对象的背景图片设为运送
                    }
                    myPictureBox.BackgroundImageLayout = ImageLayout.Stretch;//设定图片对象的背景图片布局方式为拉伸
                    myPictureBox.ContextMenuStrip = cmsYouJianCaiDan;
                    myPictureBox.Click += new EventHandler(myPictureBox_Click); //myPictureBox_Click方法加载到图片对象的单击事件中
                    //myPictureBox.DoubleClick += new EventHandler(tsbXiuGai_Update_Click);
                    myPictureBox.MouseEnter += new EventHandler(myPictureBox_MouseEnter);//myPictureBox_MouseEnter方法加载到图片对象的鼠标进入事件中
                    myPictureBox.MouseLeave += new EventHandler(myPictureBox_MouseLeave);//myPictureBox_MouseLeave方法加载到图片对象的鼠标离开事件中
                    myPictureBox.Paint += new PaintEventHandler(myPictureBox_Paint);//myPictureBox_Paint方法加载到图片对象的画图事件中
                    this.pnlZhuJieMian.Controls.Add(myPictureBox);                   //把图片对象加到画板的控件集合中
                }
            
            }
            #endregion
        }
        #endregion
        #region 取消显示选中框
        void myPictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;          //把触发事件的对象转换为图片对象
            if (pb.Tag.ToString() != strCheLiangID)
            { 
                Pen pen = new Pen(pnlZhuJieMian.BackColor, 5);//用于绘图，实例化画笔对象，颜色为画板的背景颜色，粗细为5个像素
                Graphics gra = pnlZhuJieMian.CreateGraphics();  //实例化画板的绘图对象
                gra.DrawRectangle(pen, new Rectangle(pb.Location.X - 1, pb.Location.Y, pb.Size.Width, pb.Size.Height)); //用于透明绘图
            }
        }
        #endregion
        #region 增加显示选中框
        void myPictureBox_MouseEnter(object sender, EventArgs e)
        {
          
            PictureBox pb = sender as PictureBox; //把触发事件的对象转换为图片对象
            strCheLiangIDY = pb.Tag.ToString();
            pb.Cursor = Cursors.Hand;//显示手指按钮 
            Pen pen = new Pen(Color.Red, 5);//用于绘图，实例化画笔对象，颜色为红色，粗细为5个像素
            Graphics gra = pnlZhuJieMian.CreateGraphics(); //实例化画板的绘图对象
            gra.DrawRectangle(pen, new Rectangle(pb.Location.X - 1, pb.Location.Y, pb.Size.Width, pb.Size.Height)); //用于绘图
         
        }
        #endregion
        #region 生成汽车图片的坐标
        public void createPictuerBoxstrCarList(DataTable dtCheLiang )
        {
            pnlZhuJieMian.Controls.Clear(); //清空画板对象的控件集合
            pnlZhuJieMian.AutoScroll = true;//超出panel是显示滚动条
         //PublicStaticObject.myDataTablestrCar = myDataTable;//将车辆表数据放在全局变量表，用于绑定车辆界面数据
            for (int strCarXuShu = 0, leftX = 200, leftY = 100; strCarXuShu < dtCheLiang.Rows.Count; strCarXuShu++)//leftX,leftY相对于容器的坐标
            {
                int rowsCount = strCarXuShu / 8;//设置车辆行数
                if (strCarXuShu % 8 == 0)
                {
                    leftX = 10;//x坐标 换行时的值    
                }
                else
                {
                    leftX += 200;
                }
                leftY = 10 + rowsCount * 120;//按行数设置y坐标
                string strCheLiangID = dtCheLiang.Rows[strCarXuShu]["车辆ID"].ToString();//获取车辆ID
                creatstrCarShiTu(strCheLiangID, leftX, leftY);//自定义方法创建车辆视图     
            }
        
        }
        #endregion
        #region 图片单击事件
        void myPictureBox_Click(object sender , EventArgs e)
        {


            PictureBox pb = sender as PictureBox;//把触发事件的对象转换为图片对象
            if (pb.Tag.ToString() != strCheLiangID)
            {
                Pen pen = new Pen(this.panel1.BackColor, 5);//用于绘图
                Graphics gra = pnlZhuJieMian.CreateGraphics();
                gra.DrawRectangle(pen, new Rectangle(intTuX - 1, intTuY, intTuWidth, intTuHeight)); //用于透明绘图 
            }
            strCheLiangID = pb.Tag.ToString();// 把图片对应的车辆ID赋值给全局变量strCheLiangID
            intTuX = pb.Location.X;
            intTuY = pb.Location.Y;
            intTuWidth = pb.Size.Width;
            intTuHeight = pb.Size.Height;


 
        }
        #endregion
        #region 绘制车牌，状态，司机等文字
        void myPictureBox_Paint(object sender, PaintEventArgs e)
        {
            #region 为动态创建的车辆视图绑定显示的数据
            PictureBox pb = sender as PictureBox;  //把触发事件的对象转换为图片对象
            Graphics g = e.Graphics;              //实例化图片的绘图对象
            int tag = Convert.ToInt32(pb.Tag);    //获取图片对应的车辆ID
            DataTable myDataTable = dtCheLiang;
            foreach (DataRow myRow in myDataTable.Rows)//遍历全局变量myDataTable车辆表
            {
                if (Convert.ToInt32(myRow["车辆ID"]) == tag)//如果车辆表的车辆ID与图片对应的ID相等
                {
                    //给相应变量赋值
                    string strCarName = myRow["车牌号"].ToString().Trim();
                    string strDriverName = myRow["司机名称"].ToString().Trim(); 
                    string strCarStatus = myRow["状态"].ToString().Trim();
                    g.DrawString("车牌：" + strCarName + "\n" + "状态：" + strCarStatus + "\n" + "司机：" + strDriverName, new Font("宋体", 10, FontStyle.Bold), SystemBrushes.ActiveCaptionText, new PointF(10, 5));//在图片上画字符
                }
            }
            #endregion
        } 
       
        #endregion 
        #region 菜单单击事件
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否修改？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//弹出确定对话框
              if (dr == DialogResult.OK)//如果点了确定按钮
              {
                  ToolStripMenuItem tsmi = sender as ToolStripMenuItem;//转换为菜单对象
                  //修改状态
                  int i = myFRM_CheLiangZhuangTaiClient.ToolStripMenuItem_Click_XiuGaiZhuangTai(tsmi.Tag.ToString().Trim(), strCheLiangIDY);
                  if (i > 0)
                  { MessageBox.Show("状态修改成功！");
                  createPictuerBoxstrCarList(dtCheLiang);
                  }
                  else { { MessageBox.Show("状态修改失败！"); } }
              }
        }
        #endregion

    }
}
