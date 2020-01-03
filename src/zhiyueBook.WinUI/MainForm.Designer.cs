namespace zhiyueBook.WinUI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_xtsz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_jczl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReader = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_jygl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJhts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tjcx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Jytj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tstj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Test1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_xtbz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_rjzc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnReader = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnJhts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtn_Jytj = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_nyfx = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtn_Tstj = new System.Windows.Forms.ToolStripButton();
            this.tsmiJcsj = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_xtsz,
            this.tsmi_jczl,
            this.tsmi_jygl,
            this.tsmi_tjcx,
            this.tsmi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 25);
            this.menuStrip1.TabIndex = 0;
            // 
            // tsmi_xtsz
            // 
            this.tsmi_xtsz.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJcsj});
            this.tsmi_xtsz.Name = "tsmi_xtsz";
            this.tsmi_xtsz.Size = new System.Drawing.Size(84, 21);
            this.tsmi_xtsz.Text = "系统设置(&X)";
            // 
            // tsmi_jczl
            // 
            this.tsmi_jczl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReader,
            this.tsmiBook});
            this.tsmi_jczl.Name = "tsmi_jczl";
            this.tsmi_jczl.Size = new System.Drawing.Size(81, 21);
            this.tsmi_jczl.Text = "基础资料(&J)";
            // 
            // tsmiReader
            // 
            this.tsmiReader.Name = "tsmiReader";
            this.tsmiReader.Size = new System.Drawing.Size(152, 22);
            this.tsmiReader.Text = "读者管理(&R)";
            this.tsmiReader.Click += new System.EventHandler(this.tsmiReader_Click);
            // 
            // tsmiBook
            // 
            this.tsmiBook.Name = "tsmiBook";
            this.tsmiBook.Size = new System.Drawing.Size(152, 22);
            this.tsmiBook.Text = "图书管理(&B)";
            this.tsmiBook.Click += new System.EventHandler(this.tsmiBook_Click);
            // 
            // tsmi_jygl
            // 
            this.tsmi_jygl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJhts});
            this.tsmi_jygl.Name = "tsmi_jygl";
            this.tsmi_jygl.Size = new System.Drawing.Size(84, 21);
            this.tsmi_jygl.Text = "借还管理(&B)";
            // 
            // tsmiJhts
            // 
            this.tsmiJhts.Name = "tsmiJhts";
            this.tsmiJhts.Size = new System.Drawing.Size(137, 22);
            this.tsmiJhts.Text = "借还图书(&J)";
            this.tsmiJhts.Click += new System.EventHandler(this.tsmi_jhts_Click);
            // 
            // tsmi_tjcx
            // 
            this.tsmi_tjcx.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Jytj,
            this.tsmi_Tstj});
            this.tsmi_tjcx.Name = "tsmi_tjcx";
            this.tsmi_tjcx.Size = new System.Drawing.Size(83, 21);
            this.tsmi_tjcx.Text = "统计查询(&T)";
            // 
            // tsmi_Jytj
            // 
            this.tsmi_Jytj.Name = "tsmi_Jytj";
            this.tsmi_Jytj.Size = new System.Drawing.Size(140, 22);
            this.tsmi_Jytj.Text = "借阅统计(&B)";
            this.tsmi_Jytj.Click += new System.EventHandler(this.tsmi_Jytj_Click);
            // 
            // tsmi_Tstj
            // 
            this.tsmi_Tstj.Name = "tsmi_Tstj";
            this.tsmi_Tstj.Size = new System.Drawing.Size(140, 22);
            this.tsmi_Tstj.Text = "图书统计(&S)";
            this.tsmi_Tstj.Click += new System.EventHandler(this.tsmi_Tstj_Click);
            // 
            // tsmi_Help
            // 
            this.tsmi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Test1,
            this.tsmi_xtbz,
            this.toolStripMenuItem1,
            this.tsmi_rjzc,
            this.tsmi_about});
            this.tsmi_Help.Name = "tsmi_Help";
            this.tsmi_Help.Size = new System.Drawing.Size(61, 21);
            this.tsmi_Help.Text = "帮助(&H)";
            // 
            // tsmi_Test1
            // 
            this.tsmi_Test1.Name = "tsmi_Test1";
            this.tsmi_Test1.Size = new System.Drawing.Size(141, 22);
            this.tsmi_Test1.Text = "测试1";
            this.tsmi_Test1.Click += new System.EventHandler(this.tsmi_Test1_Click);
            // 
            // tsmi_xtbz
            // 
            this.tsmi_xtbz.Name = "tsmi_xtbz";
            this.tsmi_xtbz.Size = new System.Drawing.Size(141, 22);
            this.tsmi_xtbz.Text = "系统帮助(&D)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // tsmi_rjzc
            // 
            this.tsmi_rjzc.Name = "tsmi_rjzc";
            this.tsmi_rjzc.Size = new System.Drawing.Size(141, 22);
            this.tsmi_rjzc.Text = "软件注册(&R)";
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(141, 22);
            this.tsmi_about.Text = "关于我们(&A)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnReader,
            this.tsBtnBook,
            this.toolStripSeparator3,
            this.tsBtnJhts,
            this.toolStripSeparator2,
            this.tsBtn_Jytj,
            this.tsBtn_nyfx,
            this.toolStripSeparator1,
            this.tsBtn_Tstj});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(937, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnReader
            // 
            this.tsBtnReader.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnReader.Image")));
            this.tsBtnReader.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnReader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReader.Name = "tsBtnReader";
            this.tsBtnReader.Size = new System.Drawing.Size(92, 36);
            this.tsBtnReader.Text = "读者管理";
            this.tsBtnReader.Click += new System.EventHandler(this.tsmiReader_Click);
            // 
            // tsBtnBook
            // 
            this.tsBtnBook.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnBook.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBook.Image")));
            this.tsBtnBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBook.Name = "tsBtnBook";
            this.tsBtnBook.Size = new System.Drawing.Size(92, 36);
            this.tsBtnBook.Text = "图书管理";
            this.tsBtnBook.Click += new System.EventHandler(this.tsmiBook_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnJhts
            // 
            this.tsBtnJhts.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnJhts.Image")));
            this.tsBtnJhts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnJhts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnJhts.Name = "tsBtnJhts";
            this.tsBtnJhts.Size = new System.Drawing.Size(92, 36);
            this.tsBtnJhts.Text = "借还图书";
            this.tsBtnJhts.Click += new System.EventHandler(this.tsmi_jhts_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtn_Jytj
            // 
            this.tsBtn_Jytj.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Jytj.Image")));
            this.tsBtn_Jytj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Jytj.Name = "tsBtn_Jytj";
            this.tsBtn_Jytj.Size = new System.Drawing.Size(76, 36);
            this.tsBtn_Jytj.Text = "借阅统计";
            this.tsBtn_Jytj.Click += new System.EventHandler(this.tsmi_Jytj_Click);
            // 
            // tsBtn_nyfx
            // 
            this.tsBtn_nyfx.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_nyfx.Image")));
            this.tsBtn_nyfx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_nyfx.Name = "tsBtn_nyfx";
            this.tsBtn_nyfx.Size = new System.Drawing.Size(76, 36);
            this.tsBtn_nyfx.Text = "借阅分析";
            this.tsBtn_nyfx.Click += new System.EventHandler(this.tsBtn_nyfx_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtn_Tstj
            // 
            this.tsBtn_Tstj.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Tstj.Image")));
            this.tsBtn_Tstj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Tstj.Name = "tsBtn_Tstj";
            this.tsBtn_Tstj.Size = new System.Drawing.Size(76, 36);
            this.tsBtn_Tstj.Text = "图书统计";
            this.tsBtn_Tstj.Click += new System.EventHandler(this.tsmi_Tstj_Click);
            // 
            // tsmiJcsj
            // 
            this.tsmiJcsj.Name = "tsmiJcsj";
            this.tsmiJcsj.Size = new System.Drawing.Size(152, 22);
            this.tsmiJcsj.Text = "基础数据(&J)";
            this.tsmiJcsj.Click += new System.EventHandler(this.tsmiJcsj_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 655);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "图书借阅-辅助查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tjcx;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Jytj;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_Jytj;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Test1;
        private System.Windows.Forms.ToolStripButton tsBtn_nyfx;
        private System.Windows.Forms.ToolStripButton tsBtn_Tstj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_jygl;
        private System.Windows.Forms.ToolStripMenuItem tsmiJhts;
        private System.Windows.Forms.ToolStripButton tsBtnJhts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Tstj;
        private System.Windows.Forms.ToolStripMenuItem tsmi_xtsz;
        private System.Windows.Forms.ToolStripMenuItem tsmi_jczl;
        private System.Windows.Forms.ToolStripMenuItem tsmi_xtbz;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_rjzc;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.ToolStripMenuItem tsmiReader;
        private System.Windows.Forms.ToolStripMenuItem tsmiBook;
        private System.Windows.Forms.ToolStripButton tsBtnReader;
        private System.Windows.Forms.ToolStripButton tsBtnBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiJcsj;
    }
}

