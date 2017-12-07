using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;


namespace WCF物流管理系统_Client.公共方法
{
    public   class ImportXML
    {
          XmlDocument xmlDoc = new XmlDocument();
          //DataView dvBrand;
         public DataTable Import(string path)
        {
            DataTable dt = new DataTable();
            try
            {
                xmlDoc.Load(path);
                XmlNodeList Datas = xmlDoc.SelectNodes("Datas");
                foreach (XmlNode cxn in Datas[0].ChildNodes[0].ChildNodes)
                 {
                       dt.Columns.Add(cxn.Name);
                 }
                foreach (XmlNode xn in Datas[0].ChildNodes)
                {
                        DataRow dr = dt.NewRow();
                        foreach (XmlNode cxn in xn.ChildNodes)
                        {
                            
                            dr[cxn.Name] = cxn.InnerText;
                            
                        }
                        dt.Rows.Add(dr);
                }
                //dvBrand = dt.DefaultView;
              }
               catch (Exception ex)
               {
                   ex.ToString();
               }
            return dt;
         }
    }
}
