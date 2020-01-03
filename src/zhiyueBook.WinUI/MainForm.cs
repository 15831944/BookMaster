using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhiyueBook.WinUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region 借阅统计
        private void tsmi_Jytj_Click(object sender, EventArgs e)
        {
            this.FrmJytj();
        }

        /// <summary>
        /// 打开“借阅统计"窗口
        /// </summary>
        private void FrmJytj()
        {
            if (!IsChildWinOpened("TjjyForm"))
            {
                TjjyForm frm = new TjjyForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        #endregion

        private void tsmi_Test1_Click(object sender, EventArgs e)
        {
            
                Form1 frm = new Form1();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 借阅年月分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtn_nyfx_Click(object sender, EventArgs e)
        {
            if (!IsChildWinOpened("TjjyfxForm"))
            {
                TjfxForm frm = new TjfxForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }            
        }

        /// <summary>
        /// 判断子窗体是否打开
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        private bool IsChildWinOpened(string formName)
        {
            bool isOpen = false;

            foreach (Form childrenForm in this.MdiChildren)
            {
                // 检测是不是当前子窗口名称
                if (childrenForm.Name == formName)
                { 
                    // 是，显示
                    childrenForm.Visible = true;
                    // 激活
                    childrenForm.Activate();
                    childrenForm.WindowState = FormWindowState.Maximized;
                    isOpen = true;
                }
            }
            return isOpen;
        }

        #region 基础数据
        /// <summary>
        /// 打开“基础数据"窗口
        /// </summary>
        private void FrmJcsj()
        {
            if (!IsChildWinOpened("JcJcsjForm"))
            {
                DictDataForm frm = new DictDataForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void tsmiJcsj_Click(object sender, EventArgs e)
        {
            this.FrmJcsj();
        }
        #endregion

        #region 借还图书
        private void tsmi_jhts_Click(object sender, EventArgs e)
        {
            this.FrmJhts();
        }

        /// <summary>
        /// 打开“借还图书"窗口
        /// </summary>
        private void FrmJhts()
        {
            if (!IsChildWinOpened("JhtsForm"))
            {
                JhtsForm frm = new JhtsForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        #endregion

        #region 图书统计

        private void tsmi_Tstj_Click(object sender, EventArgs e)
        {
            this.FrmTstj();
        }

        /// <summary>
        /// 打开“图书统计"窗口
        /// </summary>
        private void FrmTstj()
        {
            if (!IsChildWinOpened("TjtsForm"))
            {
                TjtsForm frm = new TjtsForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        #endregion
        
        #region 读者管理
        private void tsmiReader_Click(object sender, EventArgs e)
        {
            this.FrmJcReader();
        }

        /// <summary>
        /// 打开“读者管理"窗口
        /// </summary>
        private void FrmJcReader()
        {
            if (!IsChildWinOpened("JcReaderForm"))
            {
                JcReaderForm frm = new JcReaderForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        #endregion

        #region 图书管理
        private void tsmiBook_Click(object sender, EventArgs e)
        {
            this.FrmJcBook();
        }

        /// <summary>
        /// 打开“图书管理"窗口
        /// </summary>
        private void FrmJcBook()
        {
            if (!IsChildWinOpened("JcBookForm"))
            {
                JcBookForm frm = new JcBookForm();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        #endregion

        
    }
}
