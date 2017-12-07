using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;

namespace WCF物流管理系统_Client.公共方法
{
   public   class ExportXML
    {
        public void Export(string XMLName,DataTable dt)
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = xmlDoc.CreateElement("Datas");
            xmlDoc.AppendChild(root);
            for (int j = 0; j < dt.Rows.Count;j++)
            {
                XmlNode  node1 = xmlDoc.CreateNode(XmlNodeType.Element, "Data", null);
                for (int i = 0; i < dt.Columns.Count; i++)
                { 
                    CreateNode(xmlDoc, node1, dt.Columns[i].ColumnName.ToString(), dt.Rows[j][i].ToString());
                 }
                root.AppendChild(node1);
            }
           
           try  
            {
                xmlDoc.Save("d://"+XMLName);  
            }  
            catch (Exception e)  
            {  
                //显示错误信息  
             }  
        }
        public void CreateNode(XmlDocument xmlDoc,XmlNode parentNode,string name,string value)  
        {  
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);  
            node.InnerText = value;  
            parentNode.AppendChild(node);  
        }  
    }
 }
