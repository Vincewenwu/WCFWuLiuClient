using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF物流管理系统_Client.线路管理
{
    public partial class FRM_XianLuGuanLi_Update : Form
    {
        public FRM_XianLuGuanLi_Update()
        {
            InitializeComponent();
        }
    
        public FRM_XianLuGuanLi_Update(string 线路ID)
        {
            InitializeComponent();
            XianLuID = 线路ID;
        }
        #region 实例化全局变量
        string XianLuID = "";
        BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_InsertClient myFRM_XianLuGuanLi_InsertClient =
            new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_InsertClient();
        BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Update.FRM_XianLuGuanLi_UpdateClient myFRM_XianLuGuanLi_UpdateClient =
            new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Update.FRM_XianLuGuanLi_UpdateClient();
        #endregion
        public DataTable dtLinJu;
        public DataTable dtXianLu;
        string QiShiWangDian;
        string JieZhiWangDian;
        bool bolWanCheng = false;
        private void btnShengChengLuXian_Click(object sender, EventArgs e)
        {
            QiShiWangDian = this.cboQiShiWangDian.SelectedValue.ToString().Trim();
            JieZhiWangDian = this.cboJieShuWangDian.SelectedValue.ToString().Trim(); 
            dtXianLu = new DataTable();
            dtXianLu.Columns.Add("路线", typeof(string));
            dtXianLu.Columns.Add("距离", typeof(decimal));
            dtXianLu.Columns.Add("网点ID集合", typeof(string));
            ShengChengLuXian(QiShiWangDian, cboQiShiWangDian.Text.Trim(), 0, QiShiWangDian);
            dtLinJu = myFRM_XianLuGuanLi_InsertClient.btnShengChengLuXian_Click_ChaXunLinJu().Tables[0];


            
            if (this.dtXianLu.Rows.Count > 0)
            {
                DataView myDataView = new DataView(dtXianLu);
                myDataView.Sort = "距离";
                DataTable dtXianShi = myDataView.ToTable();
                dgvKeXuanXianLu.DataSource = dtXianShi;

            }
            else { MessageBox.Show("无法生成路线！"); }

        }
        decimal decZuiDuanLuJing = 0;
        void ShengChengLuXian(string strKaiShiWangID, string strLuXianJiHe, decimal decJuLi, string strWangDianIDJiHE)
        {
            //根据dtLinJu查找以strKaiShiWangID为起点，可以到达点网店集合。
            DataView myDataView = new DataView(dtLinJu);
            myDataView.RowFilter = "网点ID=" + strKaiShiWangID;
            DataTable dtChild = myDataView.ToTable();

            if (dtChild.Rows.Count > 0)
            {
                for (int i = 0; i < dtChild.Rows.Count; i++)
                {
                    string strLinJuWangDian = dtChild.Rows[i]["邻居网点ID"].ToString().Trim();
                    string strLuXianJiHeJuBu = strLuXianJiHe;
                    decimal decJuLiJuBu = decJuLi;
                    string strWangDianIDJiHEJuBu = strWangDianIDJiHE;


                    string[] strTest = strWangDianIDJiHEJuBu.Split(';');
                    bool bolBaoHanFou = false;

                    for (int j = 0; j < strTest.Length; j++)
                    {
                        if (strTest[j] == strLinJuWangDian)
                        {
                            bolBaoHanFou = true;
                            break;
                        }

                    }
                    if (bolBaoHanFou == true)
                    {
                        continue;
                    }
                    strLuXianJiHeJuBu = strLuXianJiHeJuBu + ">" + dtChild.Rows[i]["邻居网点"].ToString().Trim();
                    decJuLiJuBu = decJuLiJuBu + Convert.ToDecimal(dtChild.Rows[i]["距离"]);
                    strWangDianIDJiHEJuBu = strWangDianIDJiHEJuBu + ";" + dtChild.Rows[i]["邻居网点ID"].ToString().Trim();
                    if (decZuiDuanLuJing != 0)
                    {
                        if (decZuiDuanLuJing < decJuLiJuBu)
                        {
                            continue;
                        }
                    }
                    if (strLinJuWangDian == JieZhiWangDian)
                    {
                        DataRow dr = dtXianLu.NewRow();
                        dr["路线"] = strLuXianJiHeJuBu;
                        dr["距离"] = decJuLiJuBu;
                        decZuiDuanLuJing = decJuLiJuBu;
                        dr["网点ID集合"] = strWangDianIDJiHEJuBu;
                        dtXianLu.Rows.Add(dr);

                        continue;
                    }
                    ShengChengLuXian(strLinJuWangDian, strLuXianJiHeJuBu, decJuLiJuBu, strWangDianIDJiHEJuBu);



                }
            }
        }


        private void FRM_XianLuGuanLi_Update_Load(object sender, EventArgs e)
        {
            this.dgvKeXuanXianLu = PublicStaticMothd.SetDgv(dgvKeXuanXianLu);
            this.dgvZuiZhongXianLu = PublicStaticMothd.SetDgv(dgvZuiZhongXianLu);
            //绑定网点下拉框
            DataTable dt = myFRM_XianLuGuanLi_InsertClient.FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi().Tables[0];
            DataTable dt2 = dt.Copy();
            this.cboQiShiWangDian.DataSource = dt;
            this.cboQiShiWangDian.DisplayMember = "网点名称";
            this.cboQiShiWangDian.ValueMember = "网点ID";
            this.cboJieShuWangDian.DataSource = dt2;
            this.cboJieShuWangDian.DisplayMember = "网点名称";
            this.cboJieShuWangDian.ValueMember = "网点ID";
            dgvZuiZhongXianLu.AutoGenerateColumns = false;
            //根据线路ID查询线路信息和线路明细信息
            DataTable dtXianLuZuiZhong = myFRM_XianLuGuanLi_UpdateClient.FRM_XianLuGuanLi_Update_Load_ChaXunXianLuXinXi(XianLuID).Tables[0];
            DataTable dtXianLuZuiMingXi = myFRM_XianLuGuanLi_UpdateClient.FRM_XianLuGuanLi_Update_Load_ChaXunXianLuMingXiXinXi(XianLuID).Tables[0];
            //给相应控件绑定值
            txtXianLuMingCheng.Text = dtXianLuZuiZhong.Rows[0]["线路名称"].ToString();
            this.txtZhuJiMa.Text = dtXianLuZuiZhong.Rows[0]["助记码"].ToString();
            if (dtXianLuZuiMingXi.Rows.Count > 0)//如果存在线路明细
            { 
                dgvZuiZhongXianLu.DataSource = dtXianLuZuiMingXi;//绑定dgv
                cboQiShiWangDian.SelectedValue = dtXianLuZuiMingXi.Rows[0]["起始网点ID"];//以线路明细的第一行的起始网点ID作为cboQiShiWangDian下拉框的值绑定
                this.cboJieShuWangDian.SelectedValue = dtXianLuZuiMingXi.Rows[dtXianLuZuiZhong.Rows.Count - 1]["终止网点ID"];//以线路明细的第最后行的终止网点ID作为cboJieShuWangDian下拉框的值绑定
            }
            bolWanCheng = true;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridViewRow CurrentRow = this.dgvKeXuanXianLu.Rows[e.RowIndex]; 
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1); 
        }

        private void btnBaoCunXianLu_Update_Click(object sender, EventArgs e)
        {

            string XianLuMing = txtXianLuMingCheng.Text;
            string ZhuJiMa = txtZhuJiMa.Text;
            int j = myFRM_XianLuGuanLi_UpdateClient.btnBaoCunXianLu_Update_Click_XiuGaiXianLu(XianLuMing, ZhuJiMa, XianLuID); //修改路线信息
            DataTable resule2 = new DataTable();
            if (j > 0)
            {
                int i = myFRM_XianLuGuanLi_UpdateClient.btnBaoCunXianLu_Update_Click_ShanChuXianLuMingXi(XianLuID); 
                foreach (DataGridViewRow dr in dgvZuiZhongXianLu.Rows)
                {
                     int 网点ID = Convert.ToInt32(dr.Cells["起始网点ID"].Value.ToString().Trim());
                    int 邻居网点ID = Convert.ToInt32(dr.Cells["终止网点ID"].Value.ToString().Trim()); 
                    resule2 = myFRM_XianLuGuanLi_InsertClient.btnBaoCunXianLu_Click_BaoCunXianLuMingXi(Convert.ToInt32(XianLuID), 网点ID, 邻居网点ID).Tables[0];

                }
            }
            if (resule2.Rows.Count > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }

        private void cboQiShiWangDian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bolWanCheng == true)//如果数据已经绑定完成
            {
                string QiShiWangDian = this.cboQiShiWangDian.Text.ToString().Trim();
                string JieZhiWangDian = this.cboJieShuWangDian.Text.ToString().Trim();
                string XianLuMing = QiShiWangDian + "--" + JieZhiWangDian + "线";
                string ZhuJiMa = QiShiWangDian + JieZhiWangDian + "线";
                txtXianLuMingCheng.Text = XianLuMing;
                txtZhuJiMa.Text = ZhuJiMa;
            }
        }

        private void dgvKeXuanXianLu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKeXuanXianLu.CurrentRow != null)
            {
                string[] strWangDianKaiShiID = dgvKeXuanXianLu.CurrentRow.Cells["网点ID集合"].Value.ToString().Split(';');
                string[] strWangDianKaiShi = dgvKeXuanXianLu.CurrentRow.Cells["路线"].Value.ToString().Split('>');

                DataTable myDataTable = new DataTable();
                myDataTable.Columns.Add("起始网点ID", typeof(string));
                myDataTable.Columns.Add("起始网点", typeof(string));
                myDataTable.Columns.Add("终止网点ID", typeof(string));
                myDataTable.Columns.Add("终止网点", typeof(string));
                for (int i = 0; i < strWangDianKaiShi.Length; i++)
                {
                    if (i != strWangDianKaiShi.Length - 1)
                    {
                        //实例化行对象，并且给对应单元格赋值
                        DataRow dr = myDataTable.NewRow();
                        dr["起始网点ID"] = strWangDianKaiShiID[i];
                        dr["起始网点"] = strWangDianKaiShi[i];
                        dr["终止网点ID"] = strWangDianKaiShiID[i + 1];
                        dr["终止网点"] = strWangDianKaiShi[i + 1];
                        myDataTable.Rows.Add(dr);//把行对象加到表对象中
                    }
                    else
                    { //实例化行对象，并且给对应单元格赋值
                        DataRow dr = myDataTable.NewRow();
                        dr["起始网点ID"] = strWangDianKaiShiID[i];
                        dr["起始网点"] = strWangDianKaiShi[i];
                        dr["终止网点ID"] = 0;
                        dr["终止网点"] = "无";
                        myDataTable.Rows.Add(dr);//把行对象加到表对象中
                    }
                }
                dgvZuiZhongXianLu.DataSource = myDataTable;
            }
        }

    }
}
