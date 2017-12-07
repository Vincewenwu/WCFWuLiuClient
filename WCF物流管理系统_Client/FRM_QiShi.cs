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
    public partial class FRM_QiShi : Form
    {
        public FRM_QiShi()
        {
            InitializeComponent();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            SYS_FromMove.ReleaseCapture();
            SYS_FromMove.SendMessage(this.Handle, SYS_FromMove.WM_SYSCOMMAND, SYS_FromMove.SC_MOVE + SYS_FromMove.HTCAPTION, 0); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_Login = new FRM_Login();
            PublicStaticObject.Pub_FRM_Login.Show();
            this.Hide();
            this.timer1.Enabled = false;
        }

        private void FRM_QiShi_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000; 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
