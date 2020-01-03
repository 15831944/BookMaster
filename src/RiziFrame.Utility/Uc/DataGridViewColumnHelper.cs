using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace RiziFrame.Utility.Uc
{
    /// <summary>
    /// 功能：
    /// 1) 设置"状态"字段"不同状态"的背景颜色： 
    /// </summary>
    public static class DataGridViewColumnHelper
    {

        /// <summary>
        /// 设置"状态"字段"不同状态"的背景颜色， 该方法需要dgv的RowPostPaint事件
        /// </summary>
        /// <param name="dgvMain"></param>
        /// <param name="e"></param>
        public static void ColStateSetBgc(DataGridView dgvMain, DataGridViewRowPostPaintEventArgs e) 
        {
            DataGridViewRow dgRow = dgvMain.Rows[e.RowIndex];
            Color stopColor = Color.FromArgb(255, 127, 80);  // 停用记录背景色
            Color normalColor = Color.FromArgb(157, 255, 100);  // 正常背景色
            Color expireColor = Color.Yellow;  // 快到期背景色


            //判断；是否是停用
            if ("正常".Equals(dgRow.Cells["cState"].Value))
            {
                //将这行的背景色设置成红色
                //dgRow.DefaultCellStyle.BackColor = normalColor;
                dgRow.Cells["cState"].Style.BackColor = normalColor;
            }
            if ("即将过期".Equals(dgRow.Cells["cState"].Value))
            {
                //将这行的背景色设置成红色                
                dgRow.Cells["cState"].Style.BackColor = expireColor;
                dgRow.Cells["cSyDays"].Style.BackColor = expireColor;
            }
            if ("停用".Equals(dgRow.Cells["cState"].Value))
            {
                //将这行的背景色设置成红色                
                dgRow.Cells["cState"].Style.BackColor = stopColor;
                dgRow.Cells["cSyDays"].Style.BackColor = stopColor;
            }
        }

    }
}
