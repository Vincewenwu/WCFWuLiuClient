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
    public partial class FRM_ErWeiMaDanHao : Form
    {
        public FRM_ErWeiMaDanHao()
        {
            InitializeComponent();
        }
        #region 生成二维码dt
        public DataTable ShengChengZuoBiao(int intDanJuShu)
        {
            
           DataTable dtErWeiMaLinShi = new DataTable();
           dtErWeiMaLinShi.Columns.Add("单据编号", typeof(string));
           dtErWeiMaLinShi.Columns.Add("二维码", typeof(byte[]));
           for (int i = 0; i < intDanJuShu; i++)
            {

                if (PublicStaticObject.Pub_FRM_DingDanGuanLi_Insert == null)
                {
                    PublicStaticObject.Pub_FRM_DingDanGuanLi_Insert = new 订单管理.FRM_DingDanGuanLi_Insert();
                }
                string strDanHao = PublicStaticObject.Pub_FRM_DingDanGuanLi_Insert.ShengChengDanHao();
                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                Bitmap bt = qrCodeEncoder.Encode(strDanHao, Encoding.UTF8);
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                Bitmap btErWeiMa = bt;
                string strBaoCunLuJing = System.AppDomain.CurrentDomain.BaseDirectory;//获取项目路径
                string strWenJian = strBaoCunLuJing + "image\\" + strDanHao + ".jpg";
                bt.Save(strWenJian); 
                DataRow dr = dtErWeiMaLinShi.NewRow();
                dr["单据编号"] = strDanHao;
                dr["二维码"] = WenJianLiuZhuanHuanLuJing(strWenJian);

                dtErWeiMaLinShi.Rows.Add(dr);
                if (File.Exists(strWenJian))
                {
                    //如果存在则删除
                    File.Delete(strWenJian);
                }
            }
          return dtErWeiMaLinShi;

        }
        #endregion
        #region 生成按钮单击事件
        private void btnShengCheng_Click(object sender, EventArgs e)
        {

            DataTable dt=  ShengChengZuoBiao(Convert.ToInt16(nudShengChengShuLiang.Value));//根据选择的数量生成。
            PublicStaticObject.Pub_FRM_ErWeiMaDanHaoDaYin = new FRM_ErWeiMaDanHaoDaYin(dt);
            PublicStaticObject.Pub_FRM_ErWeiMaDanHaoDaYin.ShowDialog(); 
        }
        #endregion
        #region  路径转换文件流
        private byte[] WenJianLiuZhuanHuanLuJing(string strLuJing)
        { 
                    using (Stream sm = new FileStream(strLuJing , FileMode.Open, FileAccess.ReadWrite, FileShare.None))
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
                       return bytes ;
                    } 
             
        }
        #endregion 
    }
}
