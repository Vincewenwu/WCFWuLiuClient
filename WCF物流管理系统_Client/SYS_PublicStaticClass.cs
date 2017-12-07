using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WCF物流管理系统_Client
{
    public static class SYS_FromMove
    {
        [DllImport("user32.dll")]  //需添加using System.Runtime.InteropServices
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;   
    }
    public static class PublicStaticObject
    {
        public static int MainLeft = 0;
        public static int MainTop = 0;
        public static int MainWidth = 0;
        public static int MainHeight = 0;
        public static string Main_Lab_Show = "";
        public static int YongHuID = 2;
        public static int YongHuQuanXianZuID = 1;
        public static string YongHuMing = "";
        public static int YuanGongID = 1;
        public static string YuanGongMingCheng = "管理员";
        public static FRM_Login Pub_FRM_Login;
        public static FRM_Main Pub_FRM_Main;


        public static FRM_Info Pub_FRM_Info;
        public static 订单管理.FRM_DingDanGuanLi Pub_FRM_DingDanGuanLi;
        public static 订单管理.FRM_DingDanGuanLi_Insert Pub_FRM_DingDanGuanLi_Insert;
        public static 订单管理.FRM_DingDanGuanLi_Update Pub_FRM_DingDanGuanLi_Update;
        public static 订单管理.FRM_WuLiuXinXiChaXun Pub_FRM_WuLiuXinXiChaXun; 


        
        public static 配载发货.FRM_PeiZaiFaHuoFenBao Pub_FRM_FRM_PeiZaiFaHuoFenBao;
        public static 配载发货.FRM_PeiZaiFaHuoFenBao_Update Pub_FRM_PeiZaiFaHuo_FenBao_Update;
        public static 配载发货.FRM_PeiZaiFaHuoPeiZai Pub_FRM_PeiZaiFaHuoPeiZai;
        public static 配载发货.FRM_PeiZaiFaHuoPeiZai_Insert Pub_FRM_PeiZaiFaHuoPeiZai_Insert;
        public static 配载发货.FRM_PeiZaiFaHuoPeiZai_Update Pub_FRM_PeiZaiFaHuoPeiZai_Update;
        public static 配载发货.FRM_PeiZaiFaHuoShiShiPeiZai Pub_FRM_PeiZaiFaHuo_ShiShiPeiZai;
        //public static 配载发货.FRM_PeiZaiFaHuoShiShiPeiZai_Update Pub_FRM_PeiZaiFaHuoShiShiPeiZai_Update; 
        public static 用户权限管理.FRM_YongHuQuanXian Pub_FRM_UserAuth;
        public static 用户权限管理.FRM_YongHuQuanXian_Insert Pub_FRM_YongHuQuanXian_Insert;
        public static 用户权限管理.FRM_YongHuQuanXian_Update Pub_FRM_YongHuQuanXian_Update;
        public static 用户权限管理.FRM_XuanZheQuanXianZu Pub_FRM_XuanZheQuanXianZu;
        public static 用户权限管理.FRM_QuanXianZu_Insert Pub_FRM_QuanXianZu_Insert;
        public static 用户权限管理.FRM_QuanXianZu_Update Pub_FRM_QuanXianZu_Update;
        public static 用户权限管理.FRM_QuanXianZu Pub_FRM_FRM_QuanXianZu; 
        public static 司机管理.FRM_SiJiGuanLi Pub_FRM_SiJiGuanLi;
        public static 司机管理.FRM_SiJiGuanLi_Insert Pub_FRM_SiJIGuanLi_Insert;
        public static 司机管理.FRM_XuanZheJiGou Pub_FRM_XuanZheJiGou;
        public static 司机管理.FRM_SiJiGuanLi_Update Pub_FRM_SiJIGuanLi_Update;

        
        public static 出车登记.FRM_ChuCheDengJi Pub_FRM_ChuCheDengJi;
        public static 出车登记.FRM_DaoDaDengJi Pub_FRM_DaoDaDengJi;  
        public static 线路管理.FRM_XianLuGuanLi Pub_FRM_XianLuGuanLi;
        public static 线路管理.FRM_XianLuGuanLi_WangDianGuanLi Pub_FRM_XianLuGuanLi_WangDianGuanLi;
        public static 线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Insert Pub_FRM_XianLuGuanLi_WangDianGuanLi_Insert;
        public static 线路管理.FRM_XianLuGuanLi_WangDianGuanLi_Update Pub_FRM_XianLuGuanLi_WangDianGuanLi_Update;
        public static 线路管理.FRM_XianLuGuanLi_Insert Pub_FRM_XianLuGuanLi_Insert;
        public static 线路管理.FRM_XianLuGuanLi_Update Pub_FRM_XianLuGuanLi_Update;
        public static 车辆状态.FRM_CheLiangZhuangTai Pub_FRM_CheLiangZhuangTai;
     
        public static 车辆状态.FRM_CheLiangZhuangTai_Insert Pub_FRM_CheLiangZhuangTai_Insert;
        public static 车辆状态.FRM_CheLiangZhuangTai_Update Pub_FRM_CheLiangZhuangTai_Update;
        public static 报表统计.FRM_BaoBiaoDingDanLiuLan Pub_FRM_BaoBiaoDingDanLiuLan;
        public static 报表统计.FRM_DingDanBaoBiao Pub_FRM_DingDanBaoBiao;
        public static 报表统计.FRM_YeWuYuanYeJi Pub_FRM_YeWuYuanYeJi;
        public static 报表统计.FRM_WeiTuoYunFangTongJi Pub_FRM_WeiTuoYunFangTongJi;
        public static 报表统计.FRM_ShouHuoFangTongJi Pub_FRM_ShouHuoFangTongJi;
        public static 报表统计.FRM_RiQiWangDianTongJi Pub_FRM_RiQiWangDianTongJi;
        public static 报表统计.FRM_RenShiKaoHeBiao Pub_FRM_RenShiKaoHeBiao;
        public static 报表统计.FRM_ShenHeHuoPinTongJi Pub_FRM_ShenHeHuoPinTongJi;
        public static 报表统计.FRM_YuanGongGongZuoZheng Pub_FRM_YuanGongGongZuoZheng;
        public static 报表统计.FRM_YuanGongGongZuoZhengDaYin Pub_FRM_YuanGongGongZuoZhengDaYin;
        public static 报表统计.FRM_ErWeiMaDanHao Pub_FRM_ErWeiMaDanHao;
        public static 报表统计.FRM_ErWeiMaMain Pub_FRM_ErWeiMaMain;
        public static 报表统计.FRM_ErWeiMaDanHaoDaYin Pub_FRM_ErWeiMaDanHaoDaYin;
        public static 报表统计.FRM_ErWeiMaWangDianDaYin Pub_FRM_ErWeiMaWangDianDaYin;
   
        
    }
}
