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
    public partial class FRM_XianLuGuanLi_Insert : Form
    {
        public FRM_XianLuGuanLi_Insert()
        {
            InitializeComponent();
        }
        #region  实例化全局变量
        BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_InsertClient myFRM_XianLuGuanLi_InsertClient =
            new BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_InsertClient();
        public DataTable dtLinJu;
        public DataTable dtXianLu ;
        string QiShiWangDian;
        string JieZhiWangDian;
        #endregion
        private void btnShengChengLuXian_Click(object sender, EventArgs e)
        {
              //给相应变量赋值
              QiShiWangDian = this.cboQiShiWangDian.SelectedValue.ToString().Trim();
              JieZhiWangDian = this.cboJieShuWangDian.SelectedValue.ToString().Trim();
              //实例化表对象并设定好结构
              dtXianLu = new DataTable();
              dtXianLu.Columns.Add("路线", typeof(string));//往dtXianLu添加列"线路"，数据类型为string
              dtXianLu.Columns.Add("距离", typeof(decimal));//往dtXianLu添加列"距离"，数据类型为decimal
              dtXianLu.Columns.Add("网点ID集合", typeof(string));//往dtXianLu添加列"网点ID集合"，数据类型为string
              dtLinJu = myFRM_XianLuGuanLi_InsertClient.btnShengChengLuXian_Click_ChaXunLinJu().Tables[0];//查询邻接表
              //执行生成线路方法
              //。。。。。。
              ShengChengLuXian(QiShiWangDian, cboQiShiWangDian.Text.Trim(), 0, QiShiWangDian);
              if (this.dtXianLu.Rows.Count > 0)
              {
                  DataView myDataView = new DataView(dtXianLu);
                  myDataView.Sort = "距离";//根据距离排序
                  DataTable dtXianShi = myDataView.ToTable();
                  dgvKeXuanXianLu.DataSource = dtXianShi;//把可选择的线路绑定到dgv
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



        private void FRM_XianLuGuanLi_Insert_Load(object sender, EventArgs e)
        {
            //绑定线路下拉框
            this.dgvKeXuanXianLu = PublicStaticMothd.SetDgv(dgvKeXuanXianLu);
            this.dgvZuiZhongXianLu = PublicStaticMothd.SetDgv(dgvZuiZhongXianLu);
            DataTable dt = myFRM_XianLuGuanLi_InsertClient.FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi().Tables[0];
            DataTable dt2 = myFRM_XianLuGuanLi_InsertClient.FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi().Tables[0];
            this.cboQiShiWangDian.DataSource = dt;
            this.cboQiShiWangDian.DisplayMember = "网点名称";
            this.cboQiShiWangDian.ValueMember = "网点ID";
            this.cboJieShuWangDian.DataSource = dt2;
            this.cboJieShuWangDian.DisplayMember = "网点名称";
            this.cboJieShuWangDian.ValueMember = "网点ID";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //把最左边的序号列设为当前行号
            DataGridViewRow CurrentRow = this.dgvKeXuanXianLu.Rows[e.RowIndex];
            CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
        }

        private void btnBaoCunXianLu_Click(object sender, EventArgs e)
        {
           //给相应参数赋值
            string XianLuMing = txtXianLuMingCheng.Text ; 
            string ZhuJiMa = txtZhuJiMa.Text;
            DataTable resule = myFRM_XianLuGuanLi_InsertClient.btnBaoCunXianLu_Click_BaoCunXianLu(XianLuMing, ZhuJiMa).Tables[0];
            DataTable resule2 = new DataTable();
            if (resule.Rows.Count > 0)
            {
                foreach (DataGridViewRow dr in dgvZuiZhongXianLu.Rows)//遍历最终线路DGV，把路线保存到数据库
                {
                    //给相应参数赋值
                    int 线路ID = Convert.ToInt32(resule.Rows[0][0].ToString().Trim());
                    int 网点ID = Convert.ToInt32(dr.Cells["起始网点ID"].Value.ToString().Trim());
                    int 邻居网点ID = Convert.ToInt32(dr.Cells["终止网点ID"].Value.ToString().Trim());
                    
                    resule2 = myFRM_XianLuGuanLi_InsertClient.btnBaoCunXianLu_Click_BaoCunXianLuMingXi(线路ID, 网点ID, 邻居网点ID).Tables[0]; //保存到数据库
                   
                }
            } 
            if (resule2.Rows.Count > 0)
            {
                MessageBox.Show("添加成功！");
                this.Close(); 
            }  
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        private void cboQiShiWangDian_SelectedIndexChanged(object sender, EventArgs e)
        {
            //给相应参数赋值
            string QiShiWangDian = this.cboQiShiWangDian.Text.ToString().Trim();
            string JieZhiWangDian = this.cboJieShuWangDian.Text.ToString().Trim();
            string XianLuMing = QiShiWangDian + "--" + JieZhiWangDian + "线";
            string ZhuJiMa = QiShiWangDian + JieZhiWangDian + "线";
            //把生成的路线名称和助记码绑定到文本框
            txtXianLuMingCheng.Text = XianLuMing;
            txtZhuJiMa.Text = ZhuJiMa;
        }
      

       

        private void dgvKeXuanXianLu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKeXuanXianLu.CurrentRow != null)
            {
                string[] strWangDianKaiShiID = dgvKeXuanXianLu.CurrentRow.Cells["网点ID集合"].Value.ToString().Split(';');  //把当前行的网点集合以‘；’分理处字符串数组
                string[] strWangDianKaiShi = dgvKeXuanXianLu.CurrentRow.Cells["路线"].Value.ToString().Split('>');  //把当前行的路线以‘>’分理处字符串数组
                //实例化表对象并设置好四个列的属性
                DataTable myDataTable = new DataTable();
                myDataTable.Columns.Add("起始网点ID", typeof(string));
                myDataTable.Columns.Add("起始网点", typeof(string));
                myDataTable.Columns.Add("终止网点ID", typeof(string));
                myDataTable.Columns.Add("终止网点", typeof(string));
                for (int i = 0; i < strWangDianKaiShi.Length; i++)//遍历strWangDianKaiShi数组，不包含最后一个字符，因为最后一个字符已经是终止网点了。
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
                dgvZuiZhongXianLu.DataSource = myDataTable;//把表对象绑定到dgv
            }
        }

 
    }
}
