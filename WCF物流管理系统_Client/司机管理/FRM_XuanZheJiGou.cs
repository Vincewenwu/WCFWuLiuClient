using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.司机管理
{
    public partial class FRM_XuanZheJiGou : Form
    {
        int Flag;
        public FRM_XuanZheJiGou(int flag)
        {
            Flag=flag;
            InitializeComponent();
        }
        BLL物流管理系统.司机管理.BLL_FRM_XuanZheJiGou.BLL_FRM_XuanZheJiGouClient BLL_FRM_XuanZheJiGou =
            new BLL物流管理系统.司机管理.BLL_FRM_XuanZheJiGou.BLL_FRM_XuanZheJiGouClient();
        private void FRM_XuanZheJiGou_Load(object sender, EventArgs e)
        {
            DataTable dt = BLL_FRM_XuanZheJiGou.FRM_XuanZheJiGou_Load_ChaXunJiGouZuZhi(0).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)//遍历绑定顶级节点
            {
                TreeNode tn = new TreeNode();//实例化节点
                tn.Text = dt.Rows[i]["机构组织名称"].ToString();//指定节点文本
                tn.Tag = dt.Rows[i]["机构组织ID"];//绑定节点数据
                trvXuanZheJiGou.Nodes.Add(tn);//将节点添加到树控件
                bindingChildNode(tn);//调用绑定子节点方法
            }
        }

        private void bindingChildNode(TreeNode tnF)
        {
            //获取父ID是节点tnF的ID的数据
            DataTable dt = BLL_FRM_XuanZheJiGou.FRM_XuanZheJiGou_Load_ChaXunJiGouZuZhi(int.Parse(tnF.Tag.ToString())).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)//遍历处理结果
            {
                TreeNode tn = new TreeNode();
                tn.Text = dt.Rows[i]["机构组织名称"].ToString();
                tn.Tag = dt.Rows[i]["机构组织ID"];
                tnF.Nodes.Add(tn);//将结果绑定到父节点tnF中
                bindingChildNode(tn);//递归调用绑定方法

            }
        }

        private void trvXuanZheJiGou_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (Flag == 1)
            {
                PublicStaticObject.Pub_FRM_SiJIGuanLi_Insert.txtJiGouZuZhi.Text = e.Node.Text;
                PublicStaticObject.Pub_FRM_SiJIGuanLi_Insert.txtJiGouZuZhi.Tag = e.Node.Tag;
            }
            else
            {
                PublicStaticObject.Pub_FRM_SiJIGuanLi_Update.txtJiGouZuZhi.Text = e.Node.Text;
                PublicStaticObject.Pub_FRM_SiJIGuanLi_Update.txtJiGouZuZhi.Tag = e.Node.Tag;
            }
            this.Close();
        }

      
    }
}
