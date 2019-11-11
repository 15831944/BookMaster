using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RiziFrame.Utility.Db;
using zhiyueBook.Model;
using zhiyueBook.DAL;
using RiziFrame.Utility.Uc;
using RiziFrame.Utility.Common;

namespace zhiyueBook.WinUI
{
    public partial class TjtsForm : Form
    {
        DbProvider dbProvider = new DbProvider();

        // 创建数据访问对象        
        private TjjyService srv = new TjjyService();

        // 保存查询结果，作为缓存，后面修改和删除的时候都要使用。
        private List<Tjts> queryList = null;
        private BindingCollection<Tjts> bcQueryList = null;
        private BindingList<Tjts> bQueryList = null;        

        public TjtsForm()
        {
            InitializeComponent();

            // 初始化
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.AllowUserToAddRows = false; // 不允许用户向dgv添加行
            this.dgvMain.AllowUserToDeleteRows = false; // 不允许用户向dgv删除行
            this.dgvMain.AllowUserToOrderColumns = true; // 不允许用户向dgv添加行.

            // 冻结字段, 和奇偶行样式冲突
            //DataGridViewHelp.SetColumFrozen(this.cRcode);
            //DataGridViewHelp.SetColumFrozen(this.cName);

            DataGridViewHelp.ColumnReadOnly(this.dgvMain);
            DataGridViewHelp.SetStyleGrid(this.dgvMain);
            //DataGridViewHelp.SetStyleGrid(this.dgvMain, 40 ); 

            //this.btnEdit.Enabled = this.btnDel.Enabled = false; // 禁用修改和删除按钮

            //设置日期
            //this.dtpStart.Text = is_rq_start;
            //this.dtpEnd.Text = is_rq_end;

            //this.InitCbb();
            this.ShowList();
            this.dgvMain.DataSource = bQueryList;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.ShowList();
        }


        private void ShowList()
        {
            OleDbHelper.SetConn(dbProvider.ConnectionString);
            this.queryList = srv.TjtsQuery(this.cboStop.Checked, this.txtKeyWord.Text.Trim());

            //if (cboStop.Checked)
            //{
            //    this.queryList = srv.TjtsQuery();
            //    //this.bQueryList = (BindingCollection < Tjjy > )srv.Query(1);
            //}
            //else
            //{
            //    this.queryList = srv.Query(is_rq_start, is_rq_end, txtKeyWord.Text.Trim());
            //}
            this.bQueryList = new BindingCollection<Tjts>(this.queryList);
            this.dgvMain.DataSource = bQueryList;

            this.ShowState(this.queryList);
        }

        private void ShowState(List<Tjts> lst) 
        {
            
            // 显示借阅信息
            double _sumBookPrice = 0,
                _zaiGuanPrice = 0,
                _jieChuPrice = 0;

            int allCount = 0,
                zaiGuan = 0,   // 在馆
                jieChu = 0;    // 借出
                


            allCount = lst.Count();
            _sumBookPrice = lst.Sum(it => (it.BookPrice * it.Number));
            _zaiGuanPrice = lst.Where(it => it.State == "在馆").Sum(it => it.BookPrice);
            _jieChuPrice = lst.Where(it => it.State == "借出").Sum(it => it.BookPrice);

            zaiGuan = lst.Count(it => it.State == "在馆");
            jieChu = lst.Count(it => it.State == "借出");
            //expireRd = this.queryList.Count(it => it.State == "即将过期");

            this.lblAllCount.Text = string.Format("总记录：{0}", allCount.ToString());
            this.lblSumBookPrice.Text = string.Format("图书总价：{0}元", Math.Round(_sumBookPrice, 2).ToString());
            this.lblSumBookPriceZg.Text = string.Format("在馆总价：{0}元", Math.Round(_zaiGuanPrice, 2).ToString());
            this.lblSumBookPriceJc.Text = string.Format("借出总价：{0}元", Math.Round(_jieChuPrice, 2).ToString());


            this.lblState.Text = string.Format("其中：在馆：{1}本    借出：{0}本",
                zaiGuan, jieChu);
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow dgRow = this.dgvMain.Rows[e.RowIndex];
            Color stopColor = Color.FromArgb(255, 127, 80);  // 停用记录背景色
            Color normalColor = Color.FromArgb(157, 255, 100);  // 正常背景色
            Color expireColor = Color.Yellow;  // 快到期背景色


            //判断；是否是停用
            if ("在馆".Equals(dgRow.Cells["cState"].Value))
            {
                //将这行的背景色设置成红色
                //dgRow.DefaultCellStyle.BackColor = normalColor;
                dgRow.Cells["cState"].Style.BackColor = normalColor;
            }
            if ("借出".Equals(dgRow.Cells["cState"].Value))
            {
                //将这行的背景色设置成红色                
                dgRow.Cells["cState"].Style.BackColor = stopColor;
                //dgRow.Cells["cSyDays"].Style.BackColor = stopColor;
            }
            if (Convert.ToInt32(dgRow.Cells["cNumber"].Value) > 1)
            {
                //将这行的背景色设置成红色                
                dgRow.Cells["cNumber"].Style.BackColor = expireColor;
                //dgRow.Cells["cSyDays"].Style.BackColor = stopColor;
            }
        }

        private void btnGuolv_Click(object sender, EventArgs e)
        {
            this.QueryByKeyWord();
        }

        /// <summary>
        /// 按关键字查询list
        /// </summary>
        private void QueryByKeyWord()
        {
            string keyWord = this.txtKeyWord.Text.Trim();
            List<Tjts> lsQueryList = null;
            lsQueryList = this.queryList.Where(it => it.Name.Contains(keyWord)
                || it.NameCode.ToLower().Contains(keyWord.ToLower())
                || it.Barcode.Contains(keyWord)).ToList();

            this.dgvMain.DataSource = new BindingCollection<Tjts>(lsQueryList); ;

            this.ShowState(lsQueryList);
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
            string val = dgvr.Cells["cBookCode"].Value.ToString();
            //MessageBox.Show(val);

            //利用构造函数传值到弹出页面，并在构造函数中做赋值操作            
            PostTjts curobj = new PostTjts();
            curobj.ArgTjts = new Tjts();

            curobj.ArgTjts.Name = dgvr.Cells["cName"].Value.ToString();
            curobj.ArgTjts.BookCode = dgvr.Cells["cBookCode"].Value.ToString();
            curobj.ArgTjts.Jccs = Convert.ToInt32(dgvr.Cells["cJccs"].Value); 
            curobj.ArgTjts.BookPlace = dgvr.Cells["cBookPlace"].Value.ToString(); 
            curobj.ArgTjts.BookPrice = Convert.ToDouble(dgvr.Cells["cBookPrice"].Value);
            
            TjtsxxFrom frm = new TjtsxxFrom(curobj);
            //JyxxForm frm = new JyxxForm(val);
            frm.ShowDialog();
        }
    }
}
