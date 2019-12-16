namespace zhiyueBook.WinUI
{
    partial class TjjyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cboAllRq = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAllCount = new System.Windows.Forms.Label();
            this.lblNotRtBooks = new System.Windows.Forms.Label();
            this.lblSumRtBooks = new System.Windows.Forms.Label();
            this.lblSumBrBooks = new System.Windows.Forms.Label();
            this.cboStop = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvMain = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSyDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDaysAgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSumBrBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSumBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSumRtBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNotRtBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboAllRq);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.dtpEnd);
            this.pnlTop.Controls.Add(this.dtpStart);
            this.pnlTop.Controls.Add(this.txtKeyWord);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cboStop);
            this.pnlTop.Controls.Add(this.btnFind);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(918, 47);
            this.pnlTop.TabIndex = 0;
            // 
            // cboAllRq
            // 
            this.cboAllRq.AutoSize = true;
            this.cboAllRq.Enabled = false;
            this.cboAllRq.Location = new System.Drawing.Point(942, 14);
            this.cboAllRq.Name = "cboAllRq";
            this.cboAllRq.Size = new System.Drawing.Size(72, 16);
            this.cboAllRq.TabIndex = 15;
            this.cboAllRq.Text = "全部日期";
            this.cboAllRq.UseVisualStyleBackColor = true;
            this.cboAllRq.CheckedChanged += new System.EventHandler(this.cboAllRq_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "起止日期：";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(439, 12);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(144, 21);
            this.dtpEnd.TabIndex = 12;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(292, 12);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(122, 21);
            this.dtpStart.TabIndex = 11;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(86, 12);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(123, 21);
            this.txtKeyWord.TabIndex = 10;
            this.txtKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyWord_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "姓名或拼音：";
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopRight.Controls.Add(this.lblState);
            this.pnlTopRight.Controls.Add(this.lblAllCount);
            this.pnlTopRight.Controls.Add(this.lblNotRtBooks);
            this.pnlTopRight.Controls.Add(this.lblSumRtBooks);
            this.pnlTopRight.Controls.Add(this.lblSumBrBooks);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopRight.Location = new System.Drawing.Point(0, 474);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(918, 37);
            this.pnlTopRight.TabIndex = 8;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.Blue;
            this.lblState.Location = new System.Drawing.Point(152, 6);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(272, 20);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "（正常：0        停用: 0        即将到期：0）";
            // 
            // lblAllCount
            // 
            this.lblAllCount.AutoSize = true;
            this.lblAllCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAllCount.ForeColor = System.Drawing.Color.Blue;
            this.lblAllCount.Location = new System.Drawing.Point(37, 6);
            this.lblAllCount.Name = "lblAllCount";
            this.lblAllCount.Size = new System.Drawing.Size(89, 20);
            this.lblAllCount.TabIndex = 8;
            this.lblAllCount.Text = "总记录：100";
            // 
            // lblNotRtBooks
            // 
            this.lblNotRtBooks.AutoSize = true;
            this.lblNotRtBooks.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNotRtBooks.ForeColor = System.Drawing.Color.Red;
            this.lblNotRtBooks.Location = new System.Drawing.Point(1144, 6);
            this.lblNotRtBooks.Name = "lblNotRtBooks";
            this.lblNotRtBooks.Size = new System.Drawing.Size(87, 20);
            this.lblNotRtBooks.TabIndex = 7;
            this.lblNotRtBooks.Text = "未还数：0本";
            // 
            // lblSumRtBooks
            // 
            this.lblSumRtBooks.AutoSize = true;
            this.lblSumRtBooks.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumRtBooks.ForeColor = System.Drawing.Color.Blue;
            this.lblSumRtBooks.Location = new System.Drawing.Point(977, 6);
            this.lblSumRtBooks.Name = "lblSumRtBooks";
            this.lblSumRtBooks.Size = new System.Drawing.Size(117, 20);
            this.lblSumRtBooks.TabIndex = 6;
            this.lblSumRtBooks.Text = "还书总数：100本";
            // 
            // lblSumBrBooks
            // 
            this.lblSumBrBooks.AutoSize = true;
            this.lblSumBrBooks.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumBrBooks.ForeColor = System.Drawing.Color.Blue;
            this.lblSumBrBooks.Location = new System.Drawing.Point(809, 6);
            this.lblSumBrBooks.Name = "lblSumBrBooks";
            this.lblSumBrBooks.Size = new System.Drawing.Size(117, 20);
            this.lblSumBrBooks.TabIndex = 5;
            this.lblSumBrBooks.Text = "借阅总数：100本";
            // 
            // cboStop
            // 
            this.cboStop.AutoSize = true;
            this.cboStop.Checked = true;
            this.cboStop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboStop.Location = new System.Drawing.Point(830, 14);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(96, 16);
            this.cboStop.TabIndex = 1;
            this.cboStop.Text = "显示停用读者";
            this.cboStop.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(618, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 31);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "查询(&F)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMain);
            this.pnlMain.Controls.Add(this.pnlTopRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 47);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(918, 511);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvMain
            // 
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnCondition = "";
            this.dgvMain.ColumnHeadersHeight = 26;
            this.dgvMain.ColumnNames = "";
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cState,
            this.cSyDays,
            this.cRcode,
            this.cName,
            this.cTel,
            this.cLastBorrowDate,
            this.cLastReturnDate,
            this.cDaysAgo,
            this.cSumBrBooks,
            this.cSumBookPrice,
            this.cSumRtBooks,
            this.cNotRtBooks});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowIndexEdit = 0;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.ShowRowNumber = true;
            this.dgvMain.Size = new System.Drawing.Size(918, 474);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDoubleClick);
            this.dgvMain.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMain_RowPostPaint);
            // 
            // cState
            // 
            this.cState.DataPropertyName = "State";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cState.DefaultCellStyle = dataGridViewCellStyle9;
            this.cState.Frozen = true;
            this.cState.HeaderText = "状态";
            this.cState.Name = "cState";
            this.cState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cState.Width = 80;
            // 
            // cSyDays
            // 
            this.cSyDays.DataPropertyName = "SyDays";
            this.cSyDays.Frozen = true;
            this.cSyDays.HeaderText = "剩余天数";
            this.cSyDays.Name = "cSyDays";
            this.cSyDays.Width = 68;
            // 
            // cRcode
            // 
            this.cRcode.DataPropertyName = "Rcode";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cRcode.DefaultCellStyle = dataGridViewCellStyle10;
            this.cRcode.Frozen = true;
            this.cRcode.HeaderText = "读者编号";
            this.cRcode.Name = "cRcode";
            this.cRcode.Width = 80;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Rname";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cName.DefaultCellStyle = dataGridViewCellStyle11;
            this.cName.Frozen = true;
            this.cName.HeaderText = "姓名";
            this.cName.Name = "cName";
            this.cName.Width = 80;
            // 
            // cTel
            // 
            this.cTel.DataPropertyName = "LinkTel";
            this.cTel.HeaderText = "电话/手机";
            this.cTel.Name = "cTel";
            this.cTel.Width = 160;
            // 
            // cLastBorrowDate
            // 
            this.cLastBorrowDate.DataPropertyName = "LastBorrowDate";
            this.cLastBorrowDate.HeaderText = "最后借书日期";
            this.cLastBorrowDate.Name = "cLastBorrowDate";
            // 
            // cLastReturnDate
            // 
            this.cLastReturnDate.DataPropertyName = "LastReturnDate";
            this.cLastReturnDate.HeaderText = "最后还书日期";
            this.cLastReturnDate.Name = "cLastReturnDate";
            // 
            // cDaysAgo
            // 
            this.cDaysAgo.DataPropertyName = "daysAgo";
            this.cDaysAgo.HeaderText = "至今未借书天数";
            this.cDaysAgo.Name = "cDaysAgo";
            // 
            // cSumBrBooks
            // 
            this.cSumBrBooks.DataPropertyName = "sumBrBooks";
            this.cSumBrBooks.HeaderText = "借书总数";
            this.cSumBrBooks.Name = "cSumBrBooks";
            // 
            // cSumBookPrice
            // 
            this.cSumBookPrice.DataPropertyName = "sumBookPrice";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Teal;
            this.cSumBookPrice.DefaultCellStyle = dataGridViewCellStyle12;
            this.cSumBookPrice.HeaderText = "借阅价值(元)";
            this.cSumBookPrice.Name = "cSumBookPrice";
            // 
            // cSumRtBooks
            // 
            this.cSumRtBooks.DataPropertyName = "sumRtBooks";
            this.cSumRtBooks.HeaderText = "还书总数";
            this.cSumRtBooks.Name = "cSumRtBooks";
            this.cSumRtBooks.Width = 80;
            // 
            // cNotRtBooks
            // 
            this.cNotRtBooks.DataPropertyName = "NotRtBooks";
            this.cNotRtBooks.HeaderText = "未还总数";
            this.cNotRtBooks.Name = "cNotRtBooks";
            this.cNotRtBooks.Width = 80;
            // 
            // TjjyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 558);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "TjjyForm";
            this.Text = "借阅统计";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        //private System.Windows.Forms.DataGridView dataGridView1;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMain;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.CheckBox cboStop;
        private System.Windows.Forms.Label lblNotRtBooks;
        private System.Windows.Forms.Label lblSumBrBooks;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Label lblAllCount;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.CheckBox cboAllRq;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSyDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDaysAgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSumBrBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSumBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSumRtBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNotRtBooks;
        private System.Windows.Forms.Label lblSumRtBooks;
    }
}