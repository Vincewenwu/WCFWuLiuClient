using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb; 
//using Microsoft.Office.Interop.Excel;
//using  Excel= Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using WCF物流管理系统_Client.用户权限管理;

namespace WCF物流管理系统_Client.司机管理
{
    public partial class FRM_SiJiGuanLi : Form
    {
        public FRM_SiJiGuanLi()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BLL物流管理系统.司机管理.BLL_FRM_SiJiGuanLi.BLL_FRM_SiJiGuanLiClient BLL_FRM_SiJiGuanLi =
            new BLL物流管理系统.司机管理.BLL_FRM_SiJiGuanLi.BLL_FRM_SiJiGuanLiClient();
        private void FRM_SiJiGuanLi_Load(object sender, EventArgs e)
        {
            bool b = 用户权限管理.authCheck.checkAuthByType(this, 
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!b) 
            { 
                MessageBox.Show("没有该权限，请联系管理员！"); 
                this.Close(); 
                return; 
            }
            this.Left = PublicStaticObject.MainLeft;
            this.Top = PublicStaticObject.MainTop;
            this.Width = PublicStaticObject.MainWidth;
            this.Height = PublicStaticObject.MainHeight;
            this.dgvDaoRu = PublicStaticMothd.SetDgv(dgvDaoRu);
           
            dgvSiJiXinXi.AutoGenerateColumns = false;
            System.Data.DataTable dt司机信息 = BLL_FRM_SiJiGuanLi.FRM_SiJiGuanLi_Load_ChaXunSiJiXinXi().Tables[0];
            dsSiJiGuanLi1.Tables["dtSiJiXinXi"].Merge(dt司机信息);
        }

        private void tsbXinZeng_Insert_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_SiJIGuanLi_Insert = new FRM_SiJiGuanLi_Insert();
            PublicStaticObject.Pub_FRM_SiJIGuanLi_Insert.ShowDialog();
            refresh();
        }
        private void refresh()
        {
            dgvSiJiXinXi.AutoGenerateColumns = false;
        }

        private void tsbXiuGai_Update_Click(object sender, EventArgs e)
        {
            PublicStaticObject.Pub_FRM_SiJIGuanLi_Update = new FRM_SiJiGuanLi_Update(dgvSiJiXinXi.CurrentRow);
            PublicStaticObject.Pub_FRM_SiJIGuanLi_Update.ShowDialog();
            refresh();
        }

        private void tsbShanChu_Delete_Click(object sender, EventArgs e)
        {
            bool b = 用户权限管理.authCheck.checkAuthByType(this, 
                System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!b) {
                MessageBox.Show("没有该权限，请联系管理员！"); 
                return; 
            }
            if (BLL_FRM_SiJiGuanLi.tsbShanChu_Delete_Click_ShanChu(
                Convert.ToInt32(dgvSiJiXinXi.CurrentRow.Cells["c司机ID"].Value.ToString())))
            {
                MessageBox.Show("删除司机成功！");
            }
            else
            {
                MessageBox.Show("删除司机失败！");
            }
            refresh();
        }

        private void tsbDaoChu_Click(object sender, EventArgs e)
        {
            System.Data.DataTable 司机信息 = dsSiJiGuanLi1.Tables["dtSiJiXinXi"].Copy();
            司机信息.Columns.Remove("司机ID");
            司机信息.Columns.Remove("机构组织ID");
            司机信息.Columns.Remove("准驾车型ID");
            ExportToExcel("司机信息表", 司机信息);
        }
        
        public void ExportToExcel(string 默认文件名,System.Data.DataTable 数据)
        {
            if (数据 == null) return;

            string 保存文件名 = "";
            bool 是否保存 = false;

            SaveFileDialog saveDialog = new SaveFileDialog();//创建一个保存文件对话框

            saveDialog.DefaultExt = "xls";

            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = 默认文件名;

            //if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    保存文件名 = saveDialog.FileName;

            //    //创建一个Excel应用对象
            //    //Microsoft.Office.Interop.Excel.Application xlApp
            //        //= new Microsoft.Office.Interop.Excel.Application();
            //    if (xlApp == null)
            //    {
            //        MessageBox.Show("创建Excel对象失败，可能您的电脑尚未安装Excel");
            //        return;
            //    }
            //    //通过xlApp对象返回一个工作簿
            //    Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            //    //往工作簿workbooks添加工作页
            //    Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(
            //            Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet
            //        );
            //    Microsoft.Office.Interop.Excel.Worksheet worksheet
            //        = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];


            //    ((Range)worksheet.Columns[1]).ColumnWidth = 15;//设置列宽度
            //    ((Range)worksheet.Columns[4]).ColumnWidth = 20;//设置列宽度
            //    ((Range)worksheet.Columns[5]).ColumnWidth = 25;//设置列宽度
            //    ((Range)worksheet.Columns[7]).ColumnWidth = 15;//设置列宽度
            //    ((Range)worksheet.Columns[11]).ColumnWidth = 15;//设置列宽度
            //    ((Range)worksheet.Columns[12]).ColumnWidth = 35;//设置列宽度

            //    //for循环，将列名添加到工作页中
            //    for (int i = 0; i < 数据.Columns.Count; i++)
            //    {
            //        worksheet.Cells[1, i + 1] = 数据.Columns[i].ColumnName;
            //        Microsoft.Office.Interop.Excel.Range range =
            //            (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
            //        range.Interior.ColorIndex = 15;
            //        range.Font.Bold = true;
            //    }

            //    //for循环填写数据
            //    for (int i = 0; i < 数据.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < 数据.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = "'" + 数据.Rows[i][j];
            //        }
            //        System.Windows.Forms.Application.DoEvents();
            //    }

            //    if (保存文件名 != "")
            //    {
            //        workbook.Saved = true;
            //        workbook.SaveCopyAs(保存文件名);
            //        是否保存 = true;
            //    }
            //    else
            //    {
            //        是否保存 = false;
            //    }
            //    xlApp.Quit();
            //    GC.Collect();
            //    if (是否保存 && File.Exists(保存文件名))
            //        System.Diagnostics.Process.Start(保存文件名);

            //}


        }

      

        private void btnDaoRu_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Data.DataTable dt = ExcelToDT(openFileDialog1.FileName);
                this.pnlDaoRu .Visible = true;
                this.dgvDaoRu.DataSource= dt; 
            }
        }
        #region 方法：[ExcelToDS]把excel转换成DataSet
        /// 创始人：冯铭健
        /// 功能描述：读取Excel文档 
        /// 参数命：Path：文件名称 
        /// 返回值：返回一个数据表 
        /// 创建日期：20110827
        public System.Data. DataTable ExcelToDT(string Path)
        {
            try
            {
                string 连接字符串 = @"Provider=Microsoft.Jet.OLEDB.4.0;
                Data Source = " + Path+";Extended Properties=Excel 8.0;";
                OleDbConnection 连接对象 = new OleDbConnection(连接字符串);
                连接对象.Open();
                System.Data.DataTable dt = 连接对象.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,null);
                string Excel文件名 = dt.Rows[0][2].ToString().Trim();
                string 查询语句 = "";//查询语句

                OleDbDataAdapter OLEDB数据适配器 = null;
                DataSet ds = new DataSet();
                查询语句 = "select * from [" + Excel文件名 + "]";
                OLEDB数据适配器 = new OleDbDataAdapter(查询语句, 连接对象);
                OLEDB数据适配器.Fill(ds);

                System.Data.DataTable excelDT = ds.Tables[0];

                return excelDT;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void dgvDaoRu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDaoRuGuanBi_Click(object sender, EventArgs e)
        {
            pnlDaoRu.Visible = false;
        }


      

    }
}
