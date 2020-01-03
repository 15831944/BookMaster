using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RiziFrame.Utility.Uc
{
    public partial class BtnGrp1 : UserControl
    {
        public BtnGrp1()
        {
            InitializeComponent();
        }

        #region 自定义用户控件事件
        //自定义用户控件事件
        //定义委托
        /// <summary>
        /// 新增事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void UCAddBtnClickHandle(object sender, EventArgs e);
        public delegate void UCDelBtnClickHandle(object sender, EventArgs e);
        public delegate void UCEdtBtnClickHandle(object sender, EventArgs e);
        public delegate void UCFndBtnClickHandle(object sender, EventArgs e);
        public delegate void UCReflashBtnClickHandle(object sender, EventArgs e);
        public delegate void UCExtBtnClickHandle(object sender, EventArgs e);
        //定义事件

        // 新增事件
        public event UCAddBtnClickHandle UCAddBtnClicked;
        public event UCDelBtnClickHandle UCDelBtnClicked;
        public event UCEdtBtnClickHandle UCEdtBtnClicked;
        public event UCFndBtnClickHandle UCFndBtnClicked;
        public event UCReflashBtnClickHandle UCReflashBtnClicked;
        public event UCExtBtnClickHandle UCExtBtnClicked;
        #endregion

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UCAddBtnClicked != null)
                UCAddBtnClicked(sender, new EventArgs());//把按钮自身作为参数传递
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdt_Click(object sender, EventArgs e)
        {
            if (UCEdtBtnClicked != null)
                UCEdtBtnClicked(sender, new EventArgs());//把按钮自身作为参数传递
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (UCDelBtnClicked != null)
                UCDelBtnClicked(sender, new EventArgs());//把按钮自身作为参数传递
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (UCExtBtnClicked != null)
                UCExtBtnClicked(sender, new EventArgs());//把按钮自身作为参数传递
        }
    }
}
