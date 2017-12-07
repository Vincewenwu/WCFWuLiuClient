using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Text.RegularExpressions;

namespace WCF物流管理系统_Client.配载发货
{
    public partial class FRM_PeiZaiFaHuoFenBao_Update : Form
    {
        #region 定义参数
        int int货运单ID;
        string str订单编号;
        string str寄件网点;
        string str收货网点;
        BLL物流管理系统.配载发货.FRM_PeiZaiFaHuoFenBao_Update.FRM_PeiZaiFaHuoFenBao_UpdateClient myFRM_PeiZaiFaHuoFenBao_UpdateClient =
            new BLL物流管理系统.配载发货.FRM_PeiZaiFaHuoFenBao_Update.FRM_PeiZaiFaHuoFenBao_UpdateClient();
        Hashtable 分包状态保存 = new Hashtable();
        List<int> 货运单明细ID列表 = new List<int>();

        #endregion

        #region 重载构造方法
        //重载构造函数，实现本窗体实例化时给相关参数赋初始值
        public FRM_PeiZaiFaHuoFenBao_Update(int int货运单ID, string str订单编号, string str寄件网点, string str收货网点)
        {
            InitializeComponent();
            //知识点连接：this关键字、字段与局部变量的作用范围
            this.int货运单ID = int货运单ID;
            this.str订单编号 = str订单编号;
            this.str寄件网点 = str寄件网点;
            this.str收货网点 = str收货网点;
        }
        #endregion

        #region 按钮其他保存点击事件
        private void btnQiTaBaoCun_Click(object sender, EventArgs e)
        {
            this.button11.ContextMenuStrip = null;
            Point p = this.button11.Parent.PointToScreen(this.button11.Location);
            p.Y += this.button11.Height;
            this.保存.Show(p);
        }
        #endregion

        #region Load事件记载配载货运单明细dgv
        private void FRM_PeiZaiFaHuoFenBao_Update_Load(object sender, EventArgs e)
        {
            txtDingDanBianHao.Text = str订单编号;
            txtJiLianWangDian.Text = str寄件网点;
            txtShouHuoWangDian.Text = str收货网点;
            dgvMingXi.AutoGenerateColumns = false;
            dgvMingXi.DataSource = myFRM_PeiZaiFaHuoFenBao_UpdateClient.
                FRM_PeiZaiFaHuoFenBao_Update_Load_SelectDingDanMingXi(int货运单ID).Tables[0];
            dgvMingXi.Columns["单据编号"].Frozen = true;//冻结"单据编号"列
            dgvMingXi.Columns["货物名称"].Frozen = true;//冻结"货物名称"列

            dgvFenBao = PublicStaticMothd.SetDgv(dgvFenBao);
        }
        #endregion

        #region 点击配载货运单明细dgv根据选中的货物信息查看配载信息
        private void dgvMingXi_SelectionChanged(object sender, EventArgs e)
        {
            //若货运单明细数据大于0
            if (dgvMingXi.Rows.Count > 0)
            {
                //若货运单明细表当前行不为空
                if (dgvMingXi.CurrentRow != null)
                {
                    int 货运单明细ID = (int)dgvMingXi.CurrentRow.Cells["货运单明细ID"].Value;
                    if (!货运单明细ID列表.Exists(i => i == 货运单明细ID))
                    {
                        //根据订单明细ID，提取分包信息
                        dgvFenBao.DataSource = myFRM_PeiZaiFaHuoFenBao_UpdateClient.dgvMingXi_SelectionChanged_SelectFenBao
                            (货运单明细ID).Tables[0];
                    }
                    else
                    {
                        dgvFenBao.DataSource = (DataTable)分包状态保存[货运单明细ID];
                    }
                }
            }
            else
            {
                ((DataTable)dgvFenBao.DataSource).Rows.Clear();//清空dgvFenBao的数据
            }
        }
        #endregion

        #region 按钮重新分包点击事件
        //重新分包按钮Click事件
        private void btnChongXinFenBao_Click(object sender, EventArgs e)
        {
            //若dgvMingXi当前行不为空
            if (dgvMingXi.CurrentRow != null)
            {
                if (MessageBox.Show("是否重新分包？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataTable dt = (DataTable)dgvFenBao.DataSource;
                    dt.Rows.Clear();
                    int 货运单明细ID = (int)dgvMingXi.CurrentRow.Cells["货运单明细ID"].Value;
                    object 键 = 货运单明细ID;
                    object 值 = dt.Copy();
                    if (!货运单明细ID列表.Exists(i => i == 货运单明细ID))
                    {
                        货运单明细ID列表.Add(货运单明细ID);
                        分包状态保存.Add(键, 值);
                    }
                    分包状态保存[键] = 值;
                    dgvMingXi.CurrentRow.Cells["未分包数量"].Value =
                        dgvMingXi.CurrentRow.Cells["数量"].Value;
                }
            }
        }
        #endregion

        #region 按钮删除分包点击事件
        //删除分包按钮Click事件
        private void btnShangChu_Delete_Click(object sender, EventArgs e)
        {
            if (dgvMingXi.CurrentRow != null)
            {
                if (MessageBox.Show("是否删除分包？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataTable dt = (DataTable)dgvFenBao.DataSource;
                    dgvMingXi.CurrentRow.Cells["未分包数量"].Value =
                        Convert.ToDecimal(dgvMingXi.CurrentRow.Cells["未分包数量"].Value)
                        + Convert.ToDecimal(dgvFenBao.CurrentRow.Cells["分包数量"].Value);
                    dt.Rows.RemoveAt(dgvFenBao.CurrentRow.Index);
                    int 货运单明细ID = (int)dgvMingXi.CurrentRow.Cells["货运单明细ID"].Value;
                    object 键 = 货运单明细ID;
                    object 值 = dt.Copy();
                    if (!货运单明细ID列表.Exists(i => i == 货运单明细ID))
                    {
                        货运单明细ID列表.Add(货运单明细ID);
                        分包状态保存.Add(键, 值);
                    }
                    分包状态保存[键] = 值;
                }
            }
        }
        #endregion

        #region 按钮一键分包点击事件
        private void btnYJianFenBao_Click(object sender, EventArgs e)
        {
            if (dgvMingXi.CurrentRow != null)
            {
                if (MessageBox.Show("提示", "是否一键分包？", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    decimal 分包数量 = Convert.ToDecimal(txtFenBaoShuLiang.Text);
                    decimal 未分包数量 = Convert.ToDecimal(dgvMingXi.CurrentRow.Cells["未分包数量"].Value);
                    if (分包数量 > 0 && 分包数量 <= 未分包数量)
                    {
                        //遍历并禁用所有控件
                        foreach (Control c in this.Controls)
                        {
                            c.Enabled = false;
                        }
                        //显示pnl
                        pnlFenBaoTip.Visible = true;
                        DataTable dt = (DataTable)dgvFenBao.DataSource;
                        while (未分包数量 >= 分包数量)
                        {
                            DataRow dr = dt.NewRow();
                            dr["货物名称"] = dgvMingXi.CurrentRow.Cells["货物名称"].Value;
                            dr["计量单位"] = dgvMingXi.CurrentRow.Cells["计量单位名称"].Value;
                            dr["分包数量"] = 分包数量;
                            dr["发车状态"] = "待配载";
                            dt.Rows.Add(dr);
                            未分包数量 = 未分包数量 - 分包数量;
                            dgvMingXi.CurrentRow.Cells["未分包数量"].Value = 未分包数量;
                        }
                        if (未分包数量 > 0)
                        {
                            DataRow dr = dt.NewRow();
                            dr["货物名称"] = dgvMingXi.CurrentRow.Cells["货物名称"].Value;
                            dr["计量单位"] = dgvMingXi.CurrentRow.Cells["计量单位名称"].Value;
                            dr["分包数量"] = 未分包数量;
                            dr["发车状态"] = "待配载";
                            dgvMingXi.CurrentRow.Cells["未分包数量"].Value = 0;
                            dt.Rows.Add(dr);
                        }
                        int 货运单明细ID = (int)dgvMingXi.CurrentRow.Cells["货运单明细ID"].Value;
                        object 键 = 货运单明细ID;
                        object 值 = dt.Copy();
                        if (!货运单明细ID列表.Exists(i => i == 货运单明细ID))
                        {
                            货运单明细ID列表.Add(货运单明细ID);
                            分包状态保存.Add(键, 值);
                        }
                        分包状态保存[键] = 值;
                        dgvFenBao.DataSource = dt.Copy();
                        //遍历并启用所有控件
                        foreach (Control c in this.Controls)
                        {
                            c.Enabled = true;
                        }
                        //隐藏pnl
                        pnlFenBaoTip.Visible = false;
                    }
                }
            }
        }
        #endregion

        #region 按钮分包点击事件
        private void btnFenBao_Click(object sender, EventArgs e)
        {
            if (dgvMingXi.CurrentRow != null)
            {
                int 货运单明细ID = Convert.ToInt32(dgvMingXi.CurrentRow.Cells["货运单明细ID"].Value);
                DataTable dt = (DataTable)dgvFenBao.DataSource;
                if (txtFenBaoShuLiang.Text.Trim() == "")
                {
                    MessageBox.Show("请输入分包数量！");
                    txtFenBaoShuLiang.Focus();
                }
                else if (Convert.ToDecimal(txtFenBaoShuLiang.Text.Trim()) > 
                    Convert.ToDecimal(dgvMingXi.CurrentRow.Cells["未分包数量"].Value))
                {
                    MessageBox.Show("分包数量不能大于订单明细中的【未分包数量】！");
                }
                else if (Convert.ToDecimal(dgvMingXi.CurrentRow.Cells["未分包数量"].Value) == 0)
                {
                    MessageBox.Show("该订单明细已完全分包！");
                }
                else if (Convert.ToDecimal(txtFenBaoShuLiang.Text.Trim()) <= 0)
                {
                    MessageBox.Show("分包数量必须大于0！");
                }
                else
                {
                    DataTable dtFenBao = (DataTable)dgvFenBao.DataSource;
                    DataRow dr = dtFenBao.NewRow();
                    dr["货物名称"] = dgvMingXi.CurrentRow.Cells["货物名称"].Value;
                    dr["计量单位"] = dgvMingXi.CurrentRow.Cells["计量单位名称"].Value;
                    dr["分包数量"] = Convert.ToDecimal(txtFenBaoShuLiang.Text.Trim()).ToString("f2");
                    dr["发车状态"] = "待配载";
                    dtFenBao.Rows.Add(dr);
                    dgvMingXi.CurrentRow.Cells["未分包数量"].Value =
                        (Convert.ToDecimal(dgvMingXi.CurrentRow.Cells["未分包数量"].Value) - 
                        Convert.ToDecimal(txtFenBaoShuLiang.Text.Trim())).ToString("f2");
                    object 键 = 货运单明细ID;
                    object 值 = dt.Copy();
                    if (!货运单明细ID列表.Exists(i => i == 货运单明细ID))
                    {
                        货运单明细ID列表.Add(货运单明细ID);
                        分包状态保存.Add(键, 值);
                    }
                    分包状态保存[键] = 值;
                }
            }
        }
        #endregion

        #region 按钮重置点击事件
        private void btnChongZhi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否重置？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                货运单明细ID列表.Clear();
                分包状态保存.Clear();
                FRM_PeiZaiFaHuoFenBao_Update_Load(null, null);
            }
        }
        #endregion

        #region 按钮保存点击事件
        private void btnBaoCun_Update_Click(object sender, EventArgs e)
        {
            //遍历窗体控件
            foreach (Control c in this.Controls)
            {
                //禁用所有控件
                c.Enabled = false;
            }
            //显示pnlBaoCunTip
            pnlBaoCunTip.Visible = true;
            int 未分包明细统计 = 0;
            foreach (DataGridViewRow dgvr in dgvMingXi.Rows)
            {
                decimal 未分包数量 = 0;
                未分包数量 = Convert.ToDecimal(dgvr.Cells["未分包数量"].Value);
                if (未分包数量 > 0)
                {
                    未分包明细统计++;
                }
            }
            if (未分包明细统计 == 0)
            {
                for (int i = 0; i < 货运单明细ID列表.Count; i++)
                {
                    //删除旧的分包信息
                    int 货运单明细ID = 货运单明细ID列表[i];
                    myFRM_PeiZaiFaHuoFenBao_UpdateClient.btnBaoCun_Update_Click_DeleteOldFenBao(货运单明细ID);
                    DataTable dt = (DataTable)分包状态保存[货运单明细ID];
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        decimal 分包数量 = Convert.ToDecimal(dt.Rows[j]["分包数量"]);
                        //新增新的分包信息
                        myFRM_PeiZaiFaHuoFenBao_UpdateClient.btnBaoCun_Update_Click_InsertNewFenBao(货运单明细ID, 分包数量);
                    }
                }
            }
            else
            {
                MessageBox.Show("还有明细没有完成分包，请完成分包后再保存！");
            }
            //遍历窗体控件
            foreach (Control c in this.Controls)
            {
                //启用所有控件
                c.Enabled = true;
            }
            //隐藏pnlBaoCunTip
            pnlBaoCunTip.Visible = false;
        }
        #endregion

        #region 按钮返回点击事件
        private void btnFanHui_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 菜单栏按钮重置点击事件
        private void tsbChongZhi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否重置？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                FRM_PeiZaiFaHuoFenBao_Update_Load(null, null);
            }
        }
        #endregion

        #region 菜单栏保存按钮点击事件
        private void tsbBaoCun_Update_Click(object sender, EventArgs e)
        {
            btnBaoCun_Update_Click(null, null);
        }
        #endregion

        #region 菜单栏返回按钮点击事件
        private void tsbFanHui_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 限定分包数量只能输入数字
        private void txtFenBaoShuLiang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar >= Keys.D0 && (Keys)e.KeyChar <= Keys.D9 ||
                (Keys)e.KeyChar == Keys.Back || (Keys)e.KeyChar == Keys.Enter
                || (Keys)e.KeyChar == (Keys)46)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
