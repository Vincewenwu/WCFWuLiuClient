using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.订单管理
{
    public partial class FRM_WuLiuXinXiChaXun : Form
    {
        public FRM_WuLiuXinXiChaXun()
        {
            InitializeComponent();
        }

        private void FRM_WuLiuXinXiChaXun_Load(object sender, EventArgs e)
        {
            dgvWuLiuGenZong = PublicStaticMothd.SetDgv(dgvWuLiuGenZong);
        }

        BLL物流管理系统.订单管理.DingDanGuanLi.DingDanGuanLiClient myDingDanGuanLiClient
            = new BLL物流管理系统.订单管理.DingDanGuanLi.DingDanGuanLiClient();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                DataTable dt = myDingDanGuanLiClient.Search_WuLiuGenZhongXinXi(this.textBox1.Text.ToString()).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    this.dgvWuLiuGenZong.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("请输入订单编号！！！");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)//查询按钮
        {
            if (this.textBox1.Text != "")
            {
                this.timer1.Enabled = true;
                DataTable dt = myDingDanGuanLiClient.Search_WuLiuGenZhongXinXi(this.textBox1.Text.ToString()).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    this.dgvWuLiuGenZong.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("请输入订单编号！！！");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            this.timer1.Enabled = false;
        }

    }
}
