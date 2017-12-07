using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks;
using ThoughtWorks.QRCode;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using System.IO;
 

namespace WCF物流管理系统_Client.报表统计
{
    public partial class FRM_ErWeiMaMain : Form
    {
        public FRM_ErWeiMaMain()
        {
            InitializeComponent();
        }

        private void btnDanHao_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_ErWeiMaDanHao = new 报表统计.FRM_ErWeiMaDanHao();
            PublicStaticObject.Pub_FRM_ErWeiMaDanHao.ShowDialog(); 
        }
        #region 生成二维码dt
        public DataTable ShengChengZuoBiao(DataTable dtWangDian)
        {

          
            dtWangDian.Columns.Add("二维码", typeof(byte[]));
            for (int i = 0; i < dtWangDian.Rows.Count; i++)
            {
                string strNeiRong=dtWangDian.Rows[i]["网点ID"].ToString();
                 QRCodeEncoder qrCodeEncoder = new QRCodeEncoder(); 
                Bitmap bt = qrCodeEncoder.Encode(strNeiRong, Encoding.UTF8);
                Bitmap btErWeiMa = bt;
                string strBaoCunLuJing = System.AppDomain.CurrentDomain.BaseDirectory;//获取项目路径
                string strWenJian = strBaoCunLuJing + "image\\" + "WangDian" + strNeiRong + ".jpg";
                bt.Save(strWenJian); 
               dtWangDian.Rows[i] ["二维码"] = WenJianLiuZhuanHuanLuJing(strWenJian);
               //dtWangDian.Rows[i]["网点ID"] = dtWangDian.Rows[i]["网点ID"].ToString();
                if (File.Exists(strWenJian))
                {
                    //如果存在则删除
                    File.Delete(strWenJian);
                }
            }
            return dtWangDian;

        }
        #endregion
        #region  路径转换文件流
        private byte[] WenJianLiuZhuanHuanLuJing(string strLuJing)
        {
            using (Stream sm = new FileStream(strLuJing, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
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
                return bytes;
            }

        }
        #endregion 
        private void btnWangDian_Click(object sender, EventArgs e)
        {
            BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi.FRM_XianLuGuanLi_WangDianGuanLiClient myFRM_XianLuGuanLi_WangDianGuanLiClient=new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_WangDianGuanLi.FRM_XianLuGuanLi_WangDianGuanLiClient();
            DataTable dtWangDian = myFRM_XianLuGuanLi_WangDianGuanLiClient.btnChaXunWangDianXinXi_Click_ChaXunWangDianXinXiONZhuangTai("False").Tables[0];

            DataTable dtErWeiMa = ShengChengZuoBiao(dtWangDian);
            PublicStaticObject.Pub_FRM_ErWeiMaWangDianDaYin = new 报表统计.FRM_ErWeiMaWangDianDaYin(dtErWeiMa);
            PublicStaticObject.Pub_FRM_ErWeiMaWangDianDaYin.ShowDialog();
            
            
        }

        private void FRM_ErWeiMaMain_Load(object sender, EventArgs e)
        {

        }
    }
}
