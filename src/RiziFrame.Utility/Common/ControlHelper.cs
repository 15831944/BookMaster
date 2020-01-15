using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RiziFrame.Utility.Common
{
    public static class ControlHelper
    {

        #region ComboBox 绑定数据
        public static void ComboBoxInit(this ComboBox box)
        {
            box.ItemHeight = 18;            
            box.DropDownStyle = ComboBoxStyle.DropDownList;
            box.DrawMode = DrawMode.OwnerDrawFixed;
        }

        /// <summary>
        /// 绑定数据, 先声明一个list, 可以是key，value模式的list
        /// </summary>
        /// <param name="box"></param>
        /// <param name="data"></param>
        public static void CbbBindData(this ComboBox box, List<KeyValuePair<long, string>> data)
        {
            ComboBoxInit(box);
            box.DataSource = data;
            box.DrawItem += (sender, e) =>
            {
                if (e.Index < 0)
                {
                    return;
                }
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(data[e.Index].Value.ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X, e.Bounds.Y + 3);
            };
        }

        /// <summary>
        /// 绑定数据，Dictionary的数据, 获取key: cbb.SelectedValue.ToString(), value = cbbMembType.Text
        /// </summary>
        /// <param name="box"></param>
        /// <param name="data"></param>
        public static void CbbBindData(this ComboBox box, Dictionary<int, string> data)
        {
            ComboBoxInit(box);

            BindingSource bs = new BindingSource();
            bs.DataSource = data;
            box.DataSource = bs;
            box.ValueMember = "Key";
            box.DisplayMember = "Value";

            box.DrawItem += (sender, e) =>
            {
                if (e.Index == -1) { return; } // 未下拉的当前框文本, 不需要重绘制

                ComboBox thisComboBox = sender as ComboBox;  // 当前组合框
                string itemText = Convert.ToString(thisComboBox.Items[e.Index]);  // 由DrawString()处理null情况

                // [key, value]去除[]取value
                string[] sArray = itemText.TrimStart('[').TrimEnd(']').Split(new char[1] { ','}); 

                e.DrawBackground();  // 绘制背景
                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(sArray[1].Trim(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X, e.Bounds.Y + 3);  // 绘制文本
                }
                e.DrawFocusRectangle();  // 绘制聚焦框                
            };
        }

        /// <summary>
        /// 绑定数据，string list的数据
        /// </summary>
        /// <param name="box"></param>
        /// <param name="data"></param>
        public static void CbbBindData(this ComboBox box, List<string> data)
        {
            ComboBoxInit(box);

            box.DataSource = data;
            box.DrawItem += (sender, e) =>
            {
                if (e.Index < 0)
                {
                    return;
                }
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(data[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X, e.Bounds.Y + 3);
            };

        }
        #endregion

        #region 设置DateTimePicker控件初始化值可以空

        public static void DtpNull(this DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = " ";

            dtp.ValueChanged += (sender, e) =>
            {
                dtp = (DateTimePicker)sender;                                 
                dtp.Format = DateTimePickerFormat.Long;
                dtp.CustomFormat = null; //null;
                dtp.Checked = false;  // 解决bug，防止日期控件不能选择相同日期的  -- 要放置在设置格式之后
            };

            dtp.KeyPress += (sender, e) =>
            {
                //if (e.KeyChar == (char)46)  // del删除键  -- 不知道为什么不能用                
                if (e.KeyChar == (char)8)  // backspace左删除键                
                {
                    dtp = (DateTimePicker)sender;
                    dtp.Format = DateTimePickerFormat.Custom;
                    dtp.CustomFormat = " ";
                }      
            };
        }

        private static ToolTip ttMsg = new ToolTip(); 
        /// <summary>
        /// Tip提示信息
        /// </summary>
        /// <param name="dtp"></param>
        /// <param name="msg"></param>
        public static void DtpTip(this DateTimePicker dtp, string msg)
        {
           
            ttMsg.SetToolTip(dtp, msg);
        }
        #endregion

        #region ComboBox 常用日期区间选择：本月，上月，本年，去年，全部
        public static void CbbSetDateList(this ComboBox box)
        {
            List<string> lst = new List<string>();
            lst.Add("全部");
            lst.Add("本月");
            lst.Add("上月");
            lst.Add("今年");
            lst.Add("去年");
            ControlHelper.CbbBindData(box, lst);
            box.Text = "全部";
        }
        
        public static void CbbSetDateArea(this ComboBox box, DateTimePicker dtpStart, DateTimePicker dtpEnd )
        {
            CbbSetDateList(box);

            box.SelectedIndexChanged += (sender, e) =>
            {
                switch (box.Text)
                {
                    case "全部":
                        dtpStart.Value = Convert.ToDateTime("2001-01-01");
                        dtpEnd.Value = System.DateTime.Now;
                        break;
                    case "本月":
                        dtpStart.Value = DateHelper.ByFirstDay;
                        dtpEnd.Value = DateHelper.ByEndDay;
                        break;
                    case "上月":
                        dtpStart.Value = DateHelper.SyFirstDay;
                        dtpEnd.Value = DateHelper.SyEndDay;
                        break;
                    case "今年":
                        dtpStart.Value = DateHelper.BnFirstDay;
                        dtpEnd.Value = DateHelper.BnEndDay;
                        break;
                    case "去年":
                        dtpStart.Value = DateHelper.QnFirstDay;
                        dtpEnd.Value = DateHelper.QnEndDay;
                        break;
                    default:
                        break;
                }
            };
        }
        #endregion
               
         
        #region TextBox常用方法
        /** 
         * 1. 
         */
        private static bool Validate(string str, string regexStr)
        {
            Regex regex = new Regex(regexStr);
            Match match = regex.Match(str);
            if (match.Success)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 判断txt只能为数值
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool TextBoxOnlyNumber(this TextBox txt, string title = "")
        {
            bool val = true;
            string msg = "只能输入数值！";
            if (!"".Equals(title)) msg = string.Format("【{0}】只能输入数值！", title);

            if (!Validate(((TextBox)txt).Text.Trim(), @"^(-?\d+)(\.\d+)?$"))//判断输入的数值只能是数值
            {
                MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val = false;
            }
            return val;

        }
        
        /// <summary>
        /// 判断txt不能为空值
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool TextBoxNoEmpty(this TextBox txt, string title = "")
        {
            bool val = true;
            string msg = "不能为空！";
            if (!"".Equals(title)) msg = string.Format("【{0}】不能为空！", title);

            if (((TextBox)txt).Text == null || ((TextBox)txt).Text.Length == 0 || ((TextBox)txt).Text == " ")//判断输入的数值不能为空
            {
                MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                val = false;
            }
            return val;

        }



        #endregion

        public static void TreeViewInit(this TreeView tv)
        {
            // 失去焦点时选中节点仍突显
            tv.HideSelection = false;
            // 设置tree树高度
            //tv.ItemHeight = 32;

            ////自已绘制  
            //tv.DrawMode = TreeViewDrawMode.OwnerDrawText;

            //tv.DrawNode += (sender, e) =>
            //{
            //    e.DrawDefault = true; //使用默认颜色，只需要在TreeView失去焦点时选中节点仍然突显  
            //};
        }
    }
}
