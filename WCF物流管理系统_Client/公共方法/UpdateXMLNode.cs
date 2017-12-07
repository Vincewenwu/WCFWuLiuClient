using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace WCF物流管理系统_Client.公共方法
{
    public class UpdateXMLNode
    {
        //声明并创建XML文档对象
        XmlDocument xmlDoc = new XmlDocument();
        public void updateNode(string path,string node,string value)
        {
            try
            {
                //根据路径加载XML文档
                xmlDoc.Load(path);
                //根据节点路径获取节点
                XmlNode xmlnode = xmlDoc.SelectSingleNode(node);
                //为节点文本赋值（更新）
                xmlnode.InnerText = value;
                //保存XML文档
                xmlDoc.Save(path);
            }
            catch(Exception e)
            {
                e.ToString();
            }
        }
    }
}
