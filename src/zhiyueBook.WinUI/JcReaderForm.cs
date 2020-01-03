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
        private ICommonCURD<JcReader> srv = new JcReaderService();

        // 保存查询结果，作为缓存，后面修改和删除的时候都要使用。
        private List<JcReader> queryList = null;
        //private BindingCollection<JcReader> bcQueryList = null;  // 这个可以支持"列头排序"
        private BindingList<JcReader> bQueryList = null;      


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

            // 设置dgvMain的数据源
            this.ShowList();
            this.dgvMain.DataSource = bQueryList;
        }

        private void btnGrpsCurd_UCExtBtnClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.ShowList();
            this.dgvMain.DataSource = bQueryList;
        }


        // 根据“关键字”查询
        private void QueryByKeyWord()
        {
            this.ShowList();
            this.dgvMain.DataSource = bQueryList;
        }

        /// <summary>
        /// 显示所有信息
        /// </summary>
        private void ShowList()
        {
            this.queryList = srv.Query(txtKeyWord.Text.Trim());
            this.bQueryList = new BindingCollection<JcReader>(this.queryList);
            //this.bcQueryList = new BindingCollection<JcReader>(this.queryList);
            //this.dgvMain.DataSource = bQueryList;

            //this.bQueryList = new BindingList<Tjjy>(this.queryList);

            //MessageBox.Show(this.queryList.Count().ToString());
            //this.dgvMain.DataSource = this.queryList;
            
            //绑定 BindingCollection
            //this.dgvMain.DataSource = bcQueryList;
            //this.dgvMain.ba


            this.ShowState();

        }

        /// <summary>
        /// 显示状态信息
        /// </summary>
        private void ShowState()
        {
            // 显示借阅信息
            int allCount = 0,
                _sumBrBooks = 0,
                _sumRtBooks = 0,
                _notRtBooks = 0,
                normalRd = 0,  // 正常
                stopRd = 0,    // 停用
                expireRd = 0;  // 即将过期


            allCount = this.queryList.Count();
            //_sumBrBooks = this.queryList.Sum(it => it.SumBrBooks);
            //_sumRtBooks = this.queryList.Sum(it => it.SumRtBooks);
            //_notRtBooks = this.queryList.Sum(it => it.NotRtBooks);

            normalRd = this.queryList.Count(it => it.State == "正常");
            stopRd = this.queryList.Count(it => it.State == "停用");
            expireRd = this.queryList.Count(it => it.State == "即将过期");

            this.lblAllCount.Text = string.Format("总记录：{0}", allCount.ToString());

            this.lblSumBrBooks.Text = string.Format("借阅总数：{0} 本", _sumBrBooks.ToString());
            //this.lblSumRtBooks.Text = string.Format("还书总数：{0} 本", _sumRtBooks.ToString());
            //this.lblNotRtBooks.Text = string.Format("未还数：{0} 本", _notRtBooks.ToString());

            this.lblState.Text = string.Format("其中：正常：{0}人,  停用：{1}人,  即将到期：{2}人",
                normalRd, stopRd, expireRd);

        }

        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewColumnHelper.ColStateSetBgc(this.dgvMain, e);
        }

        private void txtKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.QueryByKeyWord();
            }
        }

        private void dgvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            //双击行时能得到rowIndex
            int index = e.RowIndex;

            // 当前行获取值
            if (this.dgvMain.CurrentRow == null) return;
            DataGridViewRow dgvr = this.dgvMain.CurrentRow;
            string val = dgvr.Cells["cRcode"].Value.ToString();
            //MessageBox.Show(val);

            // 利用构造函数传值到弹出页面，并在构造函数中做赋值操作            
            JcReader curobj = new JcReader();
            // 根据cid获取obj实例
            curobj = srv.GetSingleObj(Convert.ToInt32(dgvr.Cells["cid"].Value));
            
            // 设置传递的值
            PostArgHelper postArg = new PostArgHelper();
            postArg.postFlag = PostArgType.Mod ;
            postArg.postObj = curobj;

            JcReaderXxForm frm = new JcReaderXxForm(postArg);
            //JcReaderXxForm frm = new JcReaderXxForm();
            frm.ShowDialog();
        }


        /// <summary>
        /// 选中当前的“读者”，并关闭窗口返回
        /// </summary>
        private void SelectedMember()
        {
            // 【1】 选中选择的对象
            int rowIndex = this.dgvMain.CurrentRow.Index;
            if (rowIndex < 0) return;

            DataGridViewRow row = dgvMain.Rows[rowIndex];
            JcReader curReader = row.DataBoundItem as JcReader;

            // 【2】 保存当前已经修改的对象
            //  窗体提供了Tag属性，可以存储任意的属性
            this.Tag = curReader;

            // 设置传递的值
            PostArgHelper postArg = new PostArgHelper();
            postArg.postFlag = PostArgType.Mod;
            postArg.postObj = curReader;

            JcReaderXxForm frm = new JcReaderXxForm(postArg);
            frm.ShowDialog();

            //curReader.Remark = "testtest111";
            ((JcReader)this.Tag).Remark = "testtest111";
            //this.DialogResult = DialogResult.OK; // 设定窗口返回值
            //this.Close();
        }


        private void btnGrpsCurd_UCAddBtnClicked(object sender, EventArgs e)
        {

            // 设置传递的值
            PostArgHelper postArg = new PostArgHelper();
            postArg.postFlag = PostArgType.New;
            postArg.postObj = null;

            JcReaderXxForm frm = new JcReaderXxForm(postArg);
            //JcReaderXxForm frm = new JcReaderXxForm();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedMember();
        }
       
    }
}
