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
    public partial class FRM_CheLiangZhuangTai_Update : Form
    {
        public FRM_CheLiangZhuangTai_Update()
        {
            InitializeComponent();
        } 
        int intTuPianWenZhiY = 0;
        List<string> lisWenJianMing = new List<string>();
        List<byte[]> lstBytes = new List<byte[]>();
        BLL物流管理系统.车辆状态.FRM_CheLiangZhuangTai_Update.FRM_CheLiangZhuangTai_UpdateClient myFRM_CheLiangZhuangTai_UpdateClient = new BLL物流管理系统.车辆状态.FRM_CheLiangZhuangTai_Update.FRM_CheLiangZhuangTai_UpdateClient();
        public string strCheLiangID;
        string strZhuangTaiID;
        byte[][] myTuPianByte;
        private void FRM_CheLiangZhuangTai_Update_Load(object sender, EventArgs e)
        {
            DataTable dtSiJi = myFRM_CheLiangZhuangTai_UpdateClient.FRM_CheLiangZhuangTai_Update_Load_ChaXunSiJi().Tables[0];
            DataTable dtCheDui = myFRM_CheLiangZhuangTai_UpdateClient.FRM_CheLiangZhuangTai_Update_Load_ChaXunCheDui().Tables[0]; 
            DataTable dtCheLiang = myFRM_CheLiangZhuangTai_UpdateClient.FRM_CheLiangZhuangTai_Update_Load_IDChaXunCheLiang(strCheLiangID).Tables[0]; 
            cboFuZeRen.DataSource = dtSiJi;
            cboFuZeRen.DisplayMember = "司机名称";
            cboFuZeRen.ValueMember = "司机ID";
            cboJinJiLianXiRen.DataSource = dtSiJi;
            cboJinJiLianXiRen.DisplayMember = "司机名称";
            cboJinJiLianXiRen.ValueMember = "司机ID";
            cboCheDui.DataSource = dtCheDui;
            cboCheDui.DisplayMember = "车队名称";
            cboCheDui.ValueMember = "车队ID"; 
            cboFuZeRen.SelectedValue = dtCheLiang.Rows[0]["负责人_司机ID"];
            cboJinJiLianXiRen.SelectedValue = dtCheLiang.Rows[0]["紧急联系人_司机ID"];
            cboCheDui.SelectedValue = dtCheLiang.Rows[0]["车队ID"];
            txtChePaiHao.Text= dtCheLiang.Rows[0]["车牌号"].ToString();
            txtCheJiaHao.Text = dtCheLiang.Rows[0]["车架号"].ToString();
            txtFaDongJiHao.Text = dtCheLiang.Rows[0]["发动机号"].ToString();
            this.txtXingShiZhengHao .Text = dtCheLiang.Rows[0]["行驶证号"].ToString();
            txtBaoXianZhengHao.Text = dtCheLiang.Rows[0]["保险证号"].ToString();
            strZhuangTaiID = dtCheLiang.Rows[0]["状态ID"].ToString() ;
            string strLuJing = dtCheLiang.Rows[0]["车辆照片"].ToString().Trim();
             myTuPianByte = myFRM_CheLiangZhuangTai_UpdateClient.FRM_CheLiangZhuangTai_Update_Load_ChaXunTuPian(strLuJing);
             this.pnlTuPian.AutoScroll = true;//超出panel是显示滚动条
            for (int i = 0; i < myTuPianByte.Length; i++)
            {
                XianShiTuPian(myTuPianByte[i]);
            }
            intTuPianWenZhiY = 0;
        }

      
        #region  显示图片
        private void XianShiTuPian(byte[] mybyte)
        {
            MemoryStream stmBLOBData = new MemoryStream(mybyte);
            PictureBox myPictureBox = new PictureBox();
            Image myImage = Image.FromStream(stmBLOBData);
            myPictureBox.Size = myImage.Size;
            myPictureBox.Location = new Point(0, intTuPianWenZhiY);//相对于容器位置 
            myPictureBox.BackgroundImage = myImage;
            myPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            this.pnlTuPian.Controls.Add(myPictureBox);
            intTuPianWenZhiY += myImage.Size.Height;
        }
        #endregion
        private void btnBaoCun_Update_Click(object sender, EventArgs e)
        {
        


            string strXingShiZhengHao = txtXingShiZhengHao.Text.Trim();
            string strFaDongJiHao = txtFaDongJiHao.Text.Trim();
            string strBaoXianZhengHao = txtBaoXianZhengHao.Text.Trim();
            string strCheJiaHao = txtCheJiaHao.Text.Trim();
            string strFuZeRenID = cboFuZeRen.SelectedValue.ToString();
            string strJinJiLianXiRenID = cboJinJiLianXiRen.SelectedValue.ToString();
            string strCheDuiID = this.cboCheDui.SelectedValue.ToString();
            string strChePiaHao = txtChePaiHao.Text.Trim();
            int j = myFRM_CheLiangZhuangTai_UpdateClient.btnBaoCun_Update_Click_XiuGaiCheLiang(strCheDuiID, strChePiaHao
                , strXingShiZhengHao, strBaoXianZhengHao, strZhuangTaiID, strFaDongJiHao
                , strCheJiaHao, strFuZeRenID, strJinJiLianXiRenID, myTuPianByte, strCheLiangID
            );

            if (j > 0) { MessageBox.Show("修改成功！"); }
            else { MessageBox.Show("修改失败！"); }
        }
         

        private void btnLiuLan_Click(object sender, EventArgs e)
        {

            ofdWenJian.Multiselect = true;
            if (ofdWenJian.ShowDialog() == DialogResult.OK)
            {
                pnlTuPian.Controls.Clear();
                myTuPianByte = null;
                intTuPianWenZhiY=0;
                for (int i = 0; i < ofdWenJian.FileNames.Length; i++)
                {
                    txtLuJing.Text += ofdWenJian.FileNames[i] + ";";
                    using (Stream sm = new FileStream(ofdWenJian.FileNames[i], FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    {

                        //二进制文件长度
                        int length = (int)sm.Length;
                        //二进制文件存放的二进制数组
                        byte[] bytes = new byte[length];
                        //内存流读取
                        sm.Read(bytes, 0, length);
                        //关闭内存流
                        sm.Close();
                        ////将数据保存到数据库中
                        lstBytes.Add(bytes);
                        XianShiTuPian(bytes);
                    }
                }
                myTuPianByte = new byte[lstBytes.Count][];
                for (int i = 0; i < lstBytes.Count; i++)
                {
                    myTuPianByte[i] = lstBytes[i];
                }

            }
        }
    }
}
