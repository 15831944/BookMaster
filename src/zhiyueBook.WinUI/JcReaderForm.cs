using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RiziFrame.Utility.Common;
using RiziFrame.Utility.Uc;
using RiziFrame.Utility.Db;
using zhiyueBook.Model;
using zhiyueBook.DAL;

namespace zhiyueBook.WinUI
{
    public partial class JcReaderForm : Form
    {
        // 创建数据访问服务        
        private JcReaderService srv = new JcReaderService();

        private BindingCollection<JcReaderModel> mySource = null;
        private List<JcReaderModel> listQuery = null;
        public List<JcReaderModel> ListQuery
        {
            get { return listQuery; }
            set { listQuery = value; }
        }

        public JcReaderForm()
        {
            InitializeComponent();

            // 初始化
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.AllowUserToAddRows = false; // 不允许用户向dgv添加行
            this.dgvMain.AllowUserToDeleteRows = false; // 不允许用户向dgv删除行
            this.dgvMain.AllowUserToOrderColumns = true; // 不允许用户向dgv添加行.

            // 冻结字段, 和奇偶行样式冲突
            DataGridViewHelp.ColumnReadOnly(this.dgvMain);
            DataGridViewHelp.SetStyleGrid(this.dgvMain);
        }

        private void JcReaderForm_Load(object sender, EventArgs e)
        {
            // 绑定数据
            this.Find();
        }

        private void btnGrpsCurd_UCExtBtnClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {         
            this.Find();
        }


        // 根据“关键字”查询
        private void Find()
        {
            // 绑定数据
            listQuery = srv.QueryList(txtKeyWord.Text.Trim());
            mySource = new BindingCollection<JcReaderModel>(listQuery);
            this.dgvMain.DataSource = mySource;
            this.ShowState();
        }             

        /// <summary>
        /// 显示状态信息
        /// </summary>
        private void ShowState()
        {
            // 显示借阅信息
            int allCount = 0,       // 全部记录
                _sumBrBooks = 0,
                _sumRtBooks = 0,
                _notRtBooks = 0,
                normalRd = 0,  // 正常
                stopRd = 0,    // 停用
                expireRd = 0,  // 过期
                willExpireRd = 0;  // 即将过期


            allCount = this.listQuery.Count();　　// 获取全部记录
            //_sumBrBooks = this.queryList.Sum(it => it.SumBrBooks);
            //_sumRtBooks = this.queryList.Sum(it => it.SumRtBooks);
            //_notRtBooks = this.queryList.Sum(it => it.NotRtBooks);

            normalRd = this.listQuery.Count(it => it.State == "正常");
            stopRd = this.listQuery.Count(it => it.State == "停用");
            expireRd = this.listQuery.Count(it => it.State == "过期");
            willExpireRd = this.listQuery.Count(it => it.State == "即将过期");

            this.lblAllCount.Text = string.Format("总记录：{0}", allCount.ToString());

            //this.lblSumBrBooks.Text = string.Format("借阅总数：{0} 本", _sumBrBooks.ToString());
            //this.lblSumRtBooks.Text = string.Format("还书总数：{0} 本", _sumRtBooks.ToString());
            //this.lblNotRtBooks.Text = string.Format("未还数：{0} 本", _notRtBooks.ToString());

            this.lblState.Text = string.Format("其中：正常：{0}人，  停用/过期：{1}人，  即将到期：{2}人",
                normalRd, stopRd + expireRd, willExpireRd);

        }

        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewColumnHelper.ColStateSetBgc(this.dgvMain, e);
        }

        private void txtKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Find();
            }
        }

        #region 修改
        private void Mod()
        {
            /**
             * 1. 获取当前行和对象，并转化为对象
             * 2. 传递对象到打开的编辑窗口中
             * 3. 如果编辑窗口时保存，则进行修改：
             *   3.1 修改数据库数据后，dgv自动更新数据
             *   3.2 需要找到treeview节点并更新name数据
             */

            JcReaderModel currRowObj = null;
            int rowIndex = dgvMain.CurrentRow.Index;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvMain.Rows[rowIndex];
                currRowObj = row.DataBoundItem as JcReaderModel;

                JcReaderXxForm frm = new JcReaderXxForm(currRowObj);

                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    // 修改
                    JcReaderModel modObj = new JcReaderModel();
                    modObj = frm.curObject;  // 新对象=Dialog窗口.curObject对象                    

                    int result = srv.Upd(modObj);
                    if (result == 1)
                    {
                        MessageBox.Show("修改成功！", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                frm.Close();
            }
        }

        private void dgvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Mod();
        }
        
        #endregion

        #region 新增
        private void btnGrpsCurd_UCAddBtnClicked(object sender, EventArgs e)
        {
            this.Add();   
        }      

        /// <summary>
        /// 会员类型新增
        /// </summary>
        private void Add() 
        {
            JcReaderXxForm frm = new JcReaderXxForm(null);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                // 新增
                JcReaderModel newObj = new JcReaderModel();
                newObj = frm.curObject;  // 新对象=Dialog窗口.curObject对象

                int result = srv.Add(newObj);
                if (result == 1)
                {
                    ListQuery.Add(newObj);
                    this.mySource.Add(newObj);      // 数据源新增               
                }
            }
            frm.Close();

        }

        #endregion

        private void btnGrpsCurd_UCDelBtnClicked(object sender, EventArgs e)
        {
            JcReaderModel currRowObj = null;
            int rowIndex = dgvMain.CurrentRow.Index;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvMain.Rows[rowIndex];
                currRowObj = row.DataBoundItem as JcReaderModel;

                string msg = string.Empty;
                
                if (srv.GetBrNumByCode(currRowObj.Rcode) >0 )
                {
                    msg = string.Format("读者【{0}】有借阅数据，不能删除", currRowObj.Rname);
                    MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    msg = string.Format("确定删除读者【{0}】?", currRowObj.Rname);                    
                    DialogResult result = MessageBox.Show(msg, "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        if (srv.Del(currRowObj) == 1)  // 数据库删除成功，执行dgv删除行
                        {
                            this.dgvMain.Rows.Remove(row);
                        }
                    }
                }
            }
            
        }
       
    }
}
