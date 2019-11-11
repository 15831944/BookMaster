using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RiziFrame.Utility.Db;
using RiziFrame.Utility.Uc;
using zhiyueBook.Model;
using zhiyueBook.DAL;

namespace zhiyueBook.WinUI
{
    public partial class TjtsxxFrom : Form
    {
        // 创建数据访问对象        
        private TjjyService srv = new TjjyService();

        // 保存查询结果，作为缓存，后面修改和删除的时候都要使用。
        private List<Tjtsxx> queryList = null;

        // 传递的“统计借阅”
        private Tjts qj_tjts;

        public TjtsxxFrom(PostTjts postTjts)
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
            //DataGridViewHelp.SetBgColorJO(this.dgvMain, Color.FromArgb(253, 168, 158));
            qj_tjts = postTjts.ArgTjts;

            //this.dtpStart.Text = postTjts.RqStart;
            //this.dtpEnd.Text = postTjts.RqEnd;

            this.lblName.Text = string.Format("《{0}》",postTjts.ArgTjts.Name);
            this.lblBookPrice.Text = string.Format("价格：{0} 元", postTjts.ArgTjts.BookPrice.ToString());
            this.lblBookCfwz.Text = string.Format("存放位置：{0} ", postTjts.ArgTjts.BookPlace);
            this.lblBookJycs.Text = string.Format("借阅次数：{0} ", postTjts.ArgTjts.Jccs);

            // 显示数据列表
            this.TsxxListShow(postTjts.ArgTjts.BookCode);

        }

        private void dgvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 显示借阅详细信息
        /// </summary>
        private void TsxxListShow(string bookCode)
        {
            //string rcode = "00031086";
            OleDbHelper.SetConn(new DbProvider().ConnectionString);
            this.queryList = srv.TjtsxxQuery(bookCode);

            // 绑定 BindingCollection
            this.dgvMain.DataSource = new BindingCollection<Tjtsxx>(this.queryList);

            //this.lblAllCount.Text = string.Format("记录数：{0}", this.dgvMain.RowCount.ToString());
        }
    }
}
