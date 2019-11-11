using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RiziFrame.Utility.Common
{
    public class FormHelper
    {

        /// <summary>
        /// 判断子窗体是否打开
        /// </summary>
        /// <param name="formName">要打开的子窗口Name</param>
        /// <returns></returns>
        private static bool IsChildWinOpened(string childFormName, Form mdiForm)
        {
            bool isOpen = false;

            //foreach (Form childrenForm in this.MdiChildren)
            foreach (Form cForm in mdiForm.MdiChildren)
            {
                // 检测是不是当前子窗口名称
                if (cForm.Name == childFormName)
                {
                    // 是，显示
                    cForm.Visible = true;
                    // 激活
                    cForm.Activate();
                    cForm.WindowState = FormWindowState.Maximized;
                    isOpen = true;
                }
            }
            return isOpen;
        }

    }
}
