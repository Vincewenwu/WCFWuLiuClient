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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            int iWidth = rect.Width;
            int iHeight = rect.Height;
            this.Height = iHeight;
            this.Width = iWidth;
        }
    }
}
