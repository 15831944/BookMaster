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
            this.tsmi_tjcx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Jytj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Test1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_Jytj = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_nyfx = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Tstj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_tjcx,
            this.tsmi_help,
            this.tsmi_Test});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 25);
            this.menuStrip1.TabIndex = 0;
            // 
            // tsmi_tjcx
            // 
            this.tsmi_tjcx.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Jytj});
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
            // tsmi_help
            // 
            this.tsmi_help.Name = "tsmi_help";
            this.tsmi_help.Size = new System.Drawing.Size(61, 21);
            this.tsmi_help.Text = "帮助(&H)";
            // 
            // tsmi_Test
            // 
            this.tsmi_Test.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Test1});
            this.tsmi_Test.Name = "tsmi_Test";
            this.tsmi_Test.Size = new System.Drawing.Size(59, 21);
            this.tsmi_Test.Text = "测试(T)";
            // 
            // tsmi_Test1
            // 
            this.tsmi_Test1.Name = "tsmi_Test1";
            this.tsmi_Test1.Size = new System.Drawing.Size(107, 22);
            this.tsmi_Test1.Text = "测试1";
            this.tsmi_Test1.Click += new System.EventHandler(this.tsmi_Test1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_Jytj,
            this.tsBtn_nyfx,
            this.toolStripSeparator1,
            this.tsBtn_Tstj});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(937, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtn_Jytj
            // 
            this.tsBtn_Jytj.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Jytj.Image")));
            this.tsBtn_Jytj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Jytj.Name = "tsBtn_Jytj";
            this.tsBtn_Jytj.Size = new System.Drawing.Size(76, 22);
            this.tsBtn_Jytj.Text = "借阅统计";
            this.tsBtn_Jytj.Click += new System.EventHandler(this.tsBtn_Jytj_Click);
            // 
            // tsBtn_nyfx
            // 
            this.tsBtn_nyfx.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_nyfx.Image")));
            this.tsBtn_nyfx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_nyfx.Name = "tsBtn_nyfx";
            this.tsBtn_nyfx.Size = new System.Drawing.Size(76, 22);
            this.tsBtn_nyfx.Text = "借阅分析";
            this.tsBtn_nyfx.Click += new System.EventHandler(this.tsBtn_nyfx_Click);
            // 
            // tsBtn_Tstj
            // 
            this.tsBtn_Tstj.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Tstj.Image")));
            this.tsBtn_Tstj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Tstj.Name = "tsBtn_Tstj";
            this.tsBtn_Tstj.Size = new System.Drawing.Size(76, 22);
            this.tsBtn_Tstj.Text = "图书统计";
            this.tsBtn_Tstj.Click += new System.EventHandler(this.tsBtn_Tstj_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
        private System.Windows.Forms.ToolStripMenuItem tsmi_help;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_Jytj;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Test;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Test1;
        private System.Windows.Forms.ToolStripButton tsBtn_nyfx;
        private System.Windows.Forms.ToolStripButton tsBtn_Tstj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

