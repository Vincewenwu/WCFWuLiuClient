using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WCF物流管理系统_Client
{
    public partial class FRM_Login : Form
    {
        #region 声明变量
        public string yanzhengma = "";
        bool bolStar = true;
        Panel pyanzhengma = new Panel();
        BLL物流管理系统.Login.LoginClient myBLL_LoginClient = new BLL物流管理系统.Login.LoginClient();
        #endregion

        #region 构造函数
        public FRM_Login()
        {
            InitializeComponent();
        }
        #endregion 

        #region 窗体加载事件（显示验证码）
        private void FRM_Login_Load(object sender, EventArgs e)
        {
            myBLL_LoginClient.FaSongYouJian();
            #region 获取系统所有用户名
            DataTable dtYonfHuMing = myBLL_LoginClient.frmLogin_SelectYongHuMing().Tables[0];
            cbo_YongHuMing.DataSource = dtYonfHuMing;
            cbo_YongHuMing.DisplayMember = "账号";
            cbo_YongHuMing.ValueMember = "用户ID";//加载用户名信息 
            #endregion

            #region 显示验证码
            CreateYanZheengMa();
            #endregion
        }
        #endregion 
     
        #region pyanzhengma验证码显示控件的绘制事件
        public void p_Paint(object sender, PaintEventArgs e)
        { 
            CreateImage(yanzhengma, e); 
        }
        #endregion

        #region 绘制验证码背景噪音线与前景噪音点
        private void CreateImage(string checkCode, PaintEventArgs e)
        {
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;
            Bitmap image = new Bitmap(checkCode.Length * 15 + 10, 24);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器 
                Random random = new Random();
                //清空图片背景色 
                g.Clear(Color.White);
                //画图片的背景噪音线 
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }

                Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.BlueViolet, Color.Crimson, 1.2f, true);
                g.DrawString(checkCode, font, brush, 2, 2);
                //画图片的前景噪音点 
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                //画图片的边框线 
                g.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    e.Graphics.DrawImage(image, new Point(1, 0));
                }
            }
            catch { }

            finally
            {
                bolStar = false;
                g.Dispose();
                image.Dispose();
            }
        }
        #endregion

        #region 产生随机验证码
        private string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] allCharArray = allChar.Split(',');
            int temp = -1;
            string randomCode = "";
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                } 
                int t = rand.Next(61);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                } 
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode; 
        }
        #endregion

        #region 验证码生成方法
        public void CreateYanZheengMa()
        {
            //清空界面控件panel1的内容
            this.panel1.Controls.Clear(); 
            //使用动态声明Panel类型的控件pyanzhengma，并设置该控件显示的相对位置
            pyanzhengma.Location = new Point(0, 0);
            //设置pyanzhengma的控件大小，宽度为84，高度为26
            pyanzhengma.Size = new Size(84, 26);
            //使用重载运算符“+=”为pyanzhengma注册绘制事件，让pyanzhengma中出现文字、前景噪音点 、背景噪音线 
            pyanzhengma.Paint += new PaintEventHandler(p_Paint);
            //为pyanzhengma注册单击事件，使单击验证码图像的时候验证码更新
            pyanzhengma.Click += new EventHandler(pyanzhengma_Click);
            //将设置好的pyanzhengma控件添加到panel1的控件集合中，即可将验证码显示
            this.panel1.Controls.Add(pyanzhengma);
            //生成随机4个文字的验证码，并赋值给自定义的公共字段yanzhengma
            yanzhengma = CreateRandomCode(4); 
        }
        #endregion

        #region 窗体关闭前弹出关闭警告
        private void FRM_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断出发窗体关闭原因
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //显示一个消息框，该消息框包含消息（是否退出程序？）、标题栏标题（操作提示）、按钮（MessageBoxButtons.YesNo）和图标（MessageBoxIcon.Question），并且返回结果。
                DialogResult r = MessageBox.Show("是否退出程序？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //判断是否点击“确认”按钮
                if (r != DialogResult.OK)
                {
                    /*e:包含事件数据*/
                    e.Cancel = true;//执行取消动作 
                }
            }
        }
        #endregion

        #region 登录按钮
        private void btn_DengLu_Click(object sender, EventArgs e)
        {
            string YongHuMing = cbo_YongHuMing.Text;
            string MiMa = txt_MiMa.Text;
            if (this.cbo_YongHuMing.Text != "" && this.txt_MiMa.Text != "")
            {
                if (this.txtYanZhengMa.Text != "")
                {
                    if (this.txtYanZhengMa.Text.ToLower() == yanzhengma.ToLower())
                    {
                        DataTable dtYanZheng = myBLL_LoginClient.frmLogin_SelectYongHuID(YongHuMing, MiMa).Tables[0];
                        if (dtYanZheng.Rows.Count > 0)
                        {
                            DataTable dtYongHuID = myBLL_LoginClient.frmLogin_SelectYongHuID(YongHuMing, MiMa).Tables[0];
                            PublicStaticObject.YongHuID = Convert.ToInt16(dtYongHuID.Rows[0]["用户ID"].ToString().Trim());
                            PublicStaticObject.YongHuMing = dtYongHuID.Rows[0]["账号"].ToString().Trim();//静态变量存储用户ID和账号名
                            PublicStaticObject.YongHuQuanXianZuID = Convert.ToInt32(dtYongHuID.Rows[0]["权限组ID"].ToString().Trim());
                            DataTable dtYuanGong = myBLL_LoginClient.frmLogin_SelectYuanGongByYongHuID(PublicStaticObject.YongHuID).Tables[0];
                            PublicStaticObject.YuanGongID = Convert.ToInt32(dtYuanGong.Rows[0]["员工ID"].ToString().Trim());
                            PublicStaticObject.YuanGongMingCheng = dtYuanGong.Rows[0]["员工姓名"].ToString().Trim();
                            PublicStaticObject.Pub_FRM_Main = new FRM_Main();
                            PublicStaticObject.Pub_FRM_Main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码不正确！");
                            txt_MiMa.Text = "";
                            txtYanZhengMa.Text = "";
                            CreateYanZheengMa();
                        }
                    }
                    else
                    {
                        MessageBox.Show("验证码输入错误！");
                        txt_MiMa.Text = "";
                        txtYanZhengMa.Text = "";
                        CreateYanZheengMa();
                    }
                }
                else
                {
                    MessageBox.Show("验证码不能为空！");
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
        }
        #endregion

        #region 取消按钮事件（关闭窗体）
        private void btn_QvXiao_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("是否退出程序？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //判断是否点击“确认”按钮
            if (r == DialogResult.OK)
            {
                //从内存中删除,不能再使用该资源
                this.Dispose();
            }
        }
        #endregion

        #region Esc按钮退出窗体
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int WM_KEYDOWN = 256;
            int WM_SYSKEYDOWN = 260;
            if (msg.Msg == WM_KEYDOWN | msg.Msg == WM_SYSKEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        this.Close();//esc关闭窗体 
                        break;
                }
            }
            return false;
        }

        #endregion

        #region 回车键登录
        private void txtYanZhengMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DengLu_Click(null, null);
            }
        }
        #endregion

        #region 刷新验证码
        private void pyanzhengma_Click(object sender, EventArgs e)
        {
            if (bolStar == false)
            {
                bolStar = true;
                CreateYanZheengMa();
            } 
        }
        #endregion 
    }
}
