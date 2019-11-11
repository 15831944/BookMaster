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
    public partial class JyxxForm : Form
    {
        // 创建数据访问对象        
        private TjjyService srv = new TjjyService();

        // 保存查询结果，作为缓存，后面修改和删除的时候都要使用。
        private List<Jyxx> queryList = null;

        // 传递的“统计借阅”
        private Tjjy qj_tjjy ;

        public JyxxForm(PostTjjy postTjjy)
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
            qj_tjjy = postTjjy.ArgTjjy;

            this.dtpStart.Text = postTjjy.RqStart;
            this.dtpEnd.Text = postTjjy.RqEnd;

            lblTabRq.Text = string.Format("日期：{0} 至 {1} ===", postTjjy.RqStart, postTjjy.RqEnd);

            this.lblName.Text = postTjjy.ArgTjjy.Rname;
            this.lblSumBrBooks.Text = string.Format("借阅总数：{0} 本", postTjjy.ArgTjjy.SumBrBooks.ToString());
            this.lblSumRtBooks.Text = string.Format("还书总数：{0} 本", postTjjy.ArgTjjy.SumRtBooks.ToString());
            this.lblNotRtBooks.Text = string.Format("未还数：{0} 本", postTjjy.ArgTjjy.NotRtBooks.ToString());

            this.lblSumBookPrice.Text = string.Format("借阅价值（元）：{0}", postTjjy.ArgTjjy.SumBookPrice.ToString());
            this.lblAllCount.Text = string.Format("记录数：{0}", this.dgvMain.RowCount.ToString());

            // 显示数据列表
            this.JyxxListShow(postTjjy.ArgTjjy.Rcode);
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 显示借阅详细信息
        /// </summary>
        private void JyxxListShow(string rcode)
        {
            //string rcode = "00031086";
            OleDbHelper.SetConn(new DbProvider().ConnectionString);
            this.queryList = srv.JyxxQuery(rcode);

            // 绑定 BindingCollection
            this.dgvMain.DataSource = new BindingCollection<Jyxx>(this.queryList);

            this.lblAllCount.Text = string.Format("记录数：{0}", this.dgvMain.RowCount.ToString());
        }

        /// <summary>
        /// 根据状态：“未还”设置cell的背景色
        /// 需要放在 dgvMain_RowPostPaint 事件中
        /// </summary>
        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow dgRow = this.dgvMain.Rows[e.RowIndex];
            //判断
            if ((dgRow.Cells["cState"].Value).Equals("未还"))
            {
                //将这行的背景色设置成红色
                //dgRow.DefaultCellStyle.BackColor = Color.Red;
                dgRow.Cells["cState"].Style.BackColor = Color.FromArgb(255, 127, 80);
            }
            else
            {
                dgRow.Cells["cState"].Style.BackColor = Color.GreenYellow;

            }
        }
    }
}
