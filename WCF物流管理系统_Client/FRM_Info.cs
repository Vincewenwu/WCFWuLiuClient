using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client
{
    public partial class FRM_Info : Form
    {
        public FRM_Info()
        {
            InitializeComponent();
        }

        private void FRM_Info_Load(object sender, EventArgs e)
        {
            公共方法.ImportXML import = new 公共方法.ImportXML();
            DataTable dt = import.Import("brief.xml");
            txtBoxContent.Text = dt.Rows[0][0].ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            txtBoxContent.Enabled = true;
            btnSaveChange.Enabled = true;
            btnQuXiao.Enabled = true;
            btnChange.Enabled = false;
        }

        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            txtBoxContent.Enabled = false;
            btnChange.Enabled = true;
            btnSaveChange.Enabled = false;
            btnQuXiao.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            公共方法.UpdateXMLNode updateNode = new 公共方法.UpdateXMLNode();
            updateNode.updateNode("brief.xml", "/Datas/Data/Content", txtBoxContent.Text);
            MessageBox.Show("修改成功！");
            txtBoxContent.Enabled = false;
            btnChange.Enabled = true;
            btnSaveChange.Enabled = false;
            btnQuXiao.Enabled = false;

        }

     
    }
}
