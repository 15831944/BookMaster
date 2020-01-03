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
    public partial class BtnGrp2 : UserControl
    {
        public BtnGrp2()
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
        public delegate void UCSaveBtnClickHandle(object sender, EventArgs e);
        public delegate void UCExtBtnClickHandle(object sender, EventArgs e);
        //定义事件

        // 新增事件
        public event UCSaveBtnClickHandle UCSaveBtnClicked;
        public event UCExtBtnClickHandle UCExtBtnClicked;
        #endregion

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UCSaveBtnClicked != null)
                UCSaveBtnClicked(sender, new EventArgs());//把按钮自身作为参数传递
        }

        // <summary>
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
