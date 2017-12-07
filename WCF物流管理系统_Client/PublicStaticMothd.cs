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
   public class PublicStaticMothd
    {
       #region 设置下拉框

       public static ComboBox SetZhiXiaLaKuang(ComboBox cbo下拉框, DataTable dt数据表, string str列ID, string str列名)
       {
           try
           {
               cbo下拉框.DataSource = dt数据表;
               cbo下拉框.DisplayMember = str列名;
               cbo下拉框.ValueMember = str列ID;
               return cbo下拉框;
           }
           catch (Exception exc) 
           { 
               MessageBox.Show(exc.ToString());
               return null;
           }
       }
       #endregion
       #region 设置自动完成源

       public static ComboBox SetZhiXiaLaKuang(ComboBox cbo下拉框, DataTable dt数据表, string str列ID, string str列名, bool bol是否完成源)
       {
           try
           {
               cbo下拉框.DataSource = dt数据表;
               cbo下拉框.DisplayMember = str列名;
               cbo下拉框.ValueMember = str列ID;
               cbo下拉框.DropDownStyle = ComboBoxStyle.DropDown; //或者是 ComboBoxStyle.Simple ，当为DropDownList时，ComboBox不能输入任何文本，因此自动完成源无效 
               string[] str = new string[dt数据表.Rows.Count];
               for (int x = 0; x < dt数据表.Rows.Count; x++)
               {
                   str[x] = dt数据表.Rows[x][str列名].ToString();
               }
               cbo下拉框.AutoCompleteSource = AutoCompleteSource.CustomSource;//指定源
               cbo下拉框.AutoCompleteCustomSource.AddRange(str);//为源添加数据
               cbo下拉框.AutoCompleteMode = AutoCompleteMode.Suggest;//为用户完成源并显示下拉框给用户选择  
               return cbo下拉框;
           }
           catch (Exception exc)
           {
               MessageBox.Show(exc.ToString());
               return null;
           }
       }
       #endregion

       #region 加载dgvCellFormatting方法
       public static DataGridView SetDgv(DataGridView  dgv)
       {
           dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
           dgv.MultiSelect = false;
           dgv.AllowUserToAddRows = false;
           dgv.AllowUserToDeleteRows = false;
           dgv.AllowUserToResizeColumns = false;
           dgv.AllowUserToResizeRows = false;
           dgv.ReadOnly = true;
           dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
           dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            return dgv; 
       }
       #endregion


       #region 加载dgvCellFormatting方法
        public static  void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
       {
           DataGridView dgv = sender as DataGridView;
           DataGridViewRow CurrentRow = dgv.Rows[e.RowIndex];
           CurrentRow.HeaderCell.Value = Convert.ToString(e.RowIndex + 1);
       }
       #endregion
    }
}
