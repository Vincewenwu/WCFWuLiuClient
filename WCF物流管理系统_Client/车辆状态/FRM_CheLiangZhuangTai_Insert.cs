using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WCF物流管理系统_Client.车辆状态
{
    public partial class FRM_CheLiangZhuangTai_Insert : Form
    {
        public FRM_CheLiangZhuangTai_Insert()
        {
            InitializeComponent();
        }
        BLL物流管理系统.车辆状态.FRM_CheLiangZhuangTai_Insert.FRM_CheLiangZhuangTai_InsertClient myFRM_CheLiangZhuangTai_InsertClient = new BLL物流管理系统.车辆状态.FRM_CheLiangZhuangTai_Insert.FRM_CheLiangZhuangTai_InsertClient();

        private void FRM_CheLiangZhuangTai_Insert_Load(object sender, EventArgs e)
        {
            DataTable dtSiJi = myFRM_CheLiangZhuangTai_InsertClient.FRM_CheLiangZhuangTai_Insert_Load_ChaXunSiJi().Tables[0];
            DataTable dtCheDui=myFRM_CheLiangZhuangTai_InsertClient.FRM_CheLiangZhuangTai_Insert_Load_ChaXunCheDui().Tables[0];
            cboFuZeRen.DataSource = dtSiJi;
            cboFuZeRen.DisplayMember = "司机名称";
            cboFuZeRen.ValueMember = "司机ID";
            cboJinJiLianXiRen.DataSource = dtSiJi;
            cboJinJiLianXiRen.DisplayMember = "司机名称";
            cboJinJiLianXiRen.ValueMember = "司机ID";
            cboCheDui.DataSource = dtCheDui;
            cboCheDui.DisplayMember = "车队名称";
            cboCheDui.ValueMember = "车队ID";
            this.pnlTuPian.AutoScroll = true;//超出panel是显示滚动条
        }

        private void btnBaoCun_Insert_Click(object sender, EventArgs e)
        {
         byte[][] bytWenJian=new  byte[lstBytes.Count][ ];
         for(int i=0;i<lstBytes.Count;i++)
         {
             bytWenJian[i]=lstBytes[i];
         }
 

            string strXingShiZhengHao=txtXingShiZhengHao.Text.Trim();
            string strFaDongJiHao= txtFaDongJiHao.Text.Trim(); 
            string strBaoXianZhengHao= txtBaoXianZhengHao.Text.Trim(); 
            string strCheJiaHao= txtCheJiaHao.Text.Trim();
            string strFuZeRenID=cboFuZeRen.SelectedValue.ToString();
            string strJinJiLianXiRenID= cboJinJiLianXiRen.SelectedValue.ToString();
            string strCheDuiID=this.cboCheDui.SelectedValue.ToString(); 
            string strChePiaHao=txtChePaiHao.Text.Trim();
            int j = myFRM_CheLiangZhuangTai_InsertClient.btnBaoCun_Insert_Click_ChaRuCheLiang(strCheDuiID,strChePiaHao
                ,strXingShiZhengHao,strBaoXianZhengHao,"2",strFaDongJiHao
                ,strCheJiaHao,strFuZeRenID,strJinJiLianXiRenID,bytWenJian
            );
           
                if (j > 0) { MessageBox.Show("添加成功！");
                BLL物流管理系统.车辆状态.FRM_CheLiangZhuangTai.FRM_CheLiangZhuangTaiClient myFRM_CheLiangZhuangTaiClient = new BLL物流管理系统.车辆状态.FRM_CheLiangZhuangTai.FRM_CheLiangZhuangTaiClient();
            PublicStaticObject.Pub_FRM_CheLiangZhuangTai.createPictuerBoxstrCarList(  PublicStaticObject.Pub_FRM_CheLiangZhuangTai.dtCheLiang );
                
                
                }
                else { MessageBox.Show("添加失败！"); }
        }

        int intTuPianWenZhiY = 0;
        List<string> lisWenJianMing = new List<string>();
        //List<byte[]> lstBytes = new List<byte[]>();
  
        //private void btnLiuLan_Click(object sender, EventArgs e)
        //{
        
        //    ofdWenJian.Multiselect = true; 
        //    if (ofdWenJian.ShowDialog() == DialogResult.OK)
        //    { 
        //        for (int i = 0; i < ofdWenJian.FileNames.Length; i++)
        //        {
        //            txtLuJing.Text += ofdWenJian.FileNames[i] + ";";
        //            using (Stream sm = new FileStream(ofdWenJian.FileNames[i], FileMode.Open, FileAccess.ReadWrite, FileShare.None))
        //            {
     
        //                //二进制文件长度  文件件流
        //                int length = (int)sm.Length;
        //                //二进制文件存放的二进制数组
        //                byte[] bytes = new byte[length];
        //                //内存流读取
        //                sm.Read(bytes, 0, length);
        //                //关闭内存流
        //                sm.Close();
        //                ////将数据保存到数据库中

        //                lstBytes.Add(bytes);
        //                XianShiTuPian(bytes);
        //            }
        //        }
             
        //    }
        //}










        List<byte[]> lstBytes = new List<byte[]>();
        private void btnLiuLan_Click(object sender, EventArgs e)
        {
            ofdWenJian.Multiselect = true;
            if (ofdWenJian.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofdWenJian.FileNames.Length; i++)
                {
                    txtLuJing.Text += ofdWenJian.FileNames[i] + ";";
                    using (Stream sm = new FileStream(ofdWenJian.FileNames[i],FileMode.Open,FileAccess.ReadWrite,FileShare.None))
                   {
                       int length = (int)sm.Length;
                       byte[] bytes = new byte[length];
                       sm.Read(bytes,0,length);
                       sm.Close();
                       lstBytes.Add(bytes);
                       XianShiTuPian(bytes);
                   }
                }   
            }

        }

        void XianShiTuPian(byte[] mybyte)
        {
            MemoryStream myMemoryStream = new MemoryStream(mybyte);
            Image myImage = Image.FromStream(myMemoryStream);
            PictureBox myPictureBox = new PictureBox();
            myPictureBox.Size = myImage.Size;
            myPictureBox.Location = new Point(0, intTuPianWenZhiY);
            myPictureBox.BackgroundImage = myImage;
            myPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTuPian.Controls.Add(myPictureBox);
            intTuPianWenZhiY += myImage.Size.Height;


        }













        //#region  显示图片
        //private void XianShiTuPian(byte[] mybyte)
        //{
        //        MemoryStream stmBLOBData = new MemoryStream(mybyte); 
        //    PictureBox myPictureBox = new PictureBox();
        //    Image  myImage=Image.FromStream(stmBLOBData);  
        //    myPictureBox.Size =  myImage.Size ;
        //    myPictureBox.Location = new Point(0, intTuPianWenZhiY);//相对于容器位置 
        //    myPictureBox.BackgroundImage = myImage;
        //    myPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
        //    this.pnlTuPian.Controls.Add(myPictureBox);
        //    intTuPianWenZhiY += myImage.Size.Height;
        //}
        //#endregion
    }
}
