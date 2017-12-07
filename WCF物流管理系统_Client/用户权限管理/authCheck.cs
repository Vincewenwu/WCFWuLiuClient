using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.用户权限管理
{
    class authCheck
    {
        private static BLL物流管理系统.用户权限管理.BLL_authCheck.BLL_authCheckClient BLL_authCheck =
            new BLL物流管理系统.用户权限管理.BLL_authCheck.BLL_authCheckClient();

        public static bool checkAuthByType(object obj, string method)
        {
            string[] 窗体类型全称 = obj.GetType().ToString().Split('.');
            string 窗体名称 = 窗体类型全称[窗体类型全称.Length - 1];
            //判断窗体类型全称长度是否为3，因为系统是三级的，正常调用的情况下，全称的长度都应该为3
            if (窗体类型全称.Length == 3)
            {
                string[] 窗体所调用的方法名 = method.Split('_');
                string[] 窗体操作类型名称 = 窗体名称.Split('_');
                string 删除名称 = 窗体所调用的方法名[窗体所调用的方法名.Length - 2];

                if (删除名称 == "Delete")
                {
                    窗体名称 = 窗体名称 + "_Delete";
                }
                else if (窗体操作类型名称.Length == 2)
                {
                    窗体名称 = 窗体名称 + "_Query";
                }

            }
            int 权限组ID = PublicStaticObject.YongHuQuanXianZuID;
            return BLL_authCheck.BLL_authCheck_checkAuthByType(窗体名称, 权限组ID);
        }


        public static bool checkAuthByName(string name)
        {
            //直接根据模块代码和操作代码拼接查询
            return BLL_authCheck.BLL_authCheck_checkAuthByType(name, PublicStaticObject.YongHuQuanXianZuID);
        }
    }
}
