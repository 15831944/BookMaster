namespace RiziFrame.Utility.Uc
{
    partial class BtnGrp1
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BtnGrp1));
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdt
            // 
            this.btnEdt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdt.Image = ((System.Drawing.Image)(resources.GetObject("btnEdt.Image")));
            this.btnEdt.Location = new System.Drawing.Point(104, 0);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEdt.Size = new System.Drawing.Size(92, 34);
            this.btnEdt.TabIndex = 16;
            this.btnEdt.Text = " 编辑 (&E)";
            this.btnEdt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdt.UseVisualStyleBackColor = true;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(198, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDel.Size = new System.Drawing.Size(92, 34);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = " 删除 (&D)";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(10, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = " 新增 (&A)";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(4, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(292, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(92, 34);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = " 关闭 (&X)";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnGrp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdt);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "BtnGrp1";
            this.Size = new System.Drawing.Size(385, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
    }
}
