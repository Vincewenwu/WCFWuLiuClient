using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WCF物流管理系统_Client.报表统计
{
    public partial class FRM_YuanGongGongZuoZheng : Form
    {
        public FRM_YuanGongGongZuoZheng()
        {
            InitializeComponent();
        }
        OpenFileDialog myOpenFileDialog=new OpenFileDialog();


        private void btnLiuLan_Click(object sender, EventArgs e)
        {


            //打开文件名
            openFileDialog1.FileName = "";
            //是否选中多个文件
            //openFileDialog1.Multiselect = true;
            ////打开的对话框标题
            //openFileDialog1.Title = Shown;
            ////文件类型
            //openFileDialog1.Filter = type;
            //确定
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //文本名显示在对话框
                txtShangChuan.Text = openFileDialog1.FileName;

            }
        }
        private void SaveAnyFileToDb(string strFileName)
        {
            //定义一个托管代码
            using (Stream sm = new FileStream(strFileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                //文件类型
                string Ext = Path.GetExtension(strFileName);
                //文件名
                string Name = Path.GetFileName(strFileName);
                //二进制文件长度
                int length = (int)sm.Length;
                //二进制文件存放的二进制数组
                byte[] bytes = new byte[length];
                //内存流读取
                sm.Read(bytes, 0, length);
                //关闭内存流
                sm.Close();
                ////将数据保存到数据库中
                try
                {
                    BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng.FRM_YuanGongGongZuoZhengClient myFRM_YuanGongGongZuoZhengClient = new  BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng.FRM_YuanGongGongZuoZhengClient();//实例化BLL对象
                int i=   myFRM_YuanGongGongZuoZhengClient.btnShangChuan_Click_UpdateYuanGong(bytes);//执行插入方法保存图片
                  if(i>0)  MessageBox.Show("保存成功！", "信息提示");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());//抛出异常
                }

            }
        }

        private void btnShangChuan_Click(object sender, EventArgs e)
        {
            //选择打开的文件
            if (String.IsNullOrEmpty(txtShangChuan.Text.Trim()))
            {
                MessageBox.Show("请选择文件！", "信息提示");
                return;
            }
            //保存进数据库
            this.SaveAnyFileToDb(txtShangChuan.Text.Trim());   
        }

        private void btnDaYin_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_YuanGongGongZuoZhengDaYin = new FRM_YuanGongGongZuoZhengDaYin();
            PublicStaticObject.Pub_FRM_YuanGongGongZuoZhengDaYin.ShowDialog();
        }

        private void FRM_YuanGongGongZuoZheng_Load(object sender, EventArgs e)
        {

        }
    }
}
