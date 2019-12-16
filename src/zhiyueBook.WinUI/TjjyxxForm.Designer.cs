namespace zhiyueBook.WinUI
{
    partial class TjjyxxForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNotRtBooks = new System.Windows.Forms.Label();
            this.lblSumRtBooks = new System.Windows.Forms.Label();
            this.lblSumBrBooks = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMain = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFactReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAllCount = new System.Windows.Forms.Label();
            this.lblSumBookPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTabRq = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlTab1_Top = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTab2 = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTab2_Top = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlTab1_Top.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 11);
            this.pnlTop.TabIndex = 2;
            // 
            // lblNotRtBooks
            // 
            this.lblNotRtBooks.AutoSize = true;
            this.lblNotRtBooks.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNotRtBooks.ForeColor = System.Drawing.Color.Red;
            this.lblNotRtBooks.Location = new System.Drawing.Point(534, 8);
            this.lblNotRtBooks.Name = "lblNotRtBooks";
            this.lblNotRtBooks.Size = new System.Drawing.Size(87, 20);
            this.lblNotRtBooks.TabIndex = 4;
            this.lblNotRtBooks.Text = "未还数：0本";
            // 
            // lblSumRtBooks
            // 
            this.lblSumRtBooks.AutoSize = true;
            this.lblSumRtBooks.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumRtBooks.ForeColor = System.Drawing.Color.Blue;
            this.lblSumRtBooks.Location = new System.Drawing.Point(397, 8);
            this.lblSumRtBooks.Name = "lblSumRtBooks";
            this.lblSumRtBooks.Size = new System.Drawing.Size(117, 20);
            this.lblSumRtBooks.TabIndex = 3;
            this.lblSumRtBooks.Text = "还书总数：100本";
            // 
            // lblSumBrBooks
            // 
            this.lblSumBrBooks.AutoSize = true;
            this.lblSumBrBooks.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumBrBooks.ForeColor = System.Drawing.Color.Blue;
            this.lblSumBrBooks.Location = new System.Drawing.Point(259, 8);
            this.lblSumBrBooks.Name = "lblSumBrBooks";
            this.lblSumBrBooks.Size = new System.Drawing.Size(117, 20);
            this.lblSumBrBooks.TabIndex = 2;
            this.lblSumBrBooks.Text = "借阅总数：100本";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Green;
            this.lblName.Location = new System.Drawing.Point(749, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 39);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "张三";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(865, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnCondition = "";
            this.dgvMain.ColumnHeadersHeight = 26;
            this.dgvMain.ColumnNames = "";
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cState,
            this.cRcode,
            this.cName,
            this.cBookCode,
            this.cBookName,
            this.cBookPrice,
            this.cBorrowDate,
            this.cReturnDate,
            this.cFactReturnDate});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 52);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowIndexEdit = 0;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.ShowRowNumber = true;
            this.dgvMain.Size = new System.Drawing.Size(962, 453);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMain_RowPostPaint);
            // 
            // cState
            // 
            this.cState.DataPropertyName = "State";
            this.cState.HeaderText = "状态";
            this.cState.Name = "cState";
            this.cState.Width = 50;
            // 
            // cRcode
            // 
            this.cRcode.DataPropertyName = "Rcode";
            this.cRcode.HeaderText = "读者编号";
            this.cRcode.Name = "cRcode";
            // 
            // cName
            // 
            this.cName.DataPropertyName = "rName";
            this.cName.HeaderText = "姓名";
            this.cName.Name = "cName";
            this.cName.Width = 80;
            // 
            // cBookCode
            // 
            this.cBookCode.DataPropertyName = "BookCode";
            this.cBookCode.HeaderText = "图书编号";
            this.cBookCode.Name = "cBookCode";
            // 
            // cBookName
            // 
            this.cBookName.DataPropertyName = "BookName";
            this.cBookName.HeaderText = "图书名称";
            this.cBookName.Name = "cBookName";
            this.cBookName.Width = 220;
            // 
            // cBookPrice
            // 
            this.cBookPrice.DataPropertyName = "BookPrice";
            this.cBookPrice.HeaderText = "图书价格(元)";
            this.cBookPrice.Name = "cBookPrice";
            // 
            // cBorrowDate
            // 
            this.cBorrowDate.DataPropertyName = "BorrowDate";
            this.cBorrowDate.HeaderText = "借书日期";
            this.cBorrowDate.Name = "cBorrowDate";
            // 
            // cReturnDate
            // 
            this.cReturnDate.DataPropertyName = "ReturnDate";
            this.cReturnDate.HeaderText = "应还日期";
            this.cReturnDate.Name = "cReturnDate";
            // 
            // cFactReturnDate
            // 
            this.cFactReturnDate.DataPropertyName = "FactReturnDate";
            this.cFactReturnDate.HeaderText = "还书日期";
            this.cFactReturnDate.Name = "cFactReturnDate";
            // 
            // lblAllCount
            // 
            this.lblAllCount.AutoSize = true;
            this.lblAllCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAllCount.ForeColor = System.Drawing.Color.Red;
            this.lblAllCount.Location = new System.Drawing.Point(674, 8);
            this.lblAllCount.Name = "lblAllCount";
            this.lblAllCount.Size = new System.Drawing.Size(73, 20);
            this.lblAllCount.TabIndex = 5;
            this.lblAllCount.Text = "记录数：0";
            // 
            // lblSumBookPrice
            // 
            this.lblSumBookPrice.AutoSize = true;
            this.lblSumBookPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumBookPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSumBookPrice.Location = new System.Drawing.Point(774, 8);
            this.lblSumBookPrice.Name = "lblSumBookPrice";
            this.lblSumBookPrice.Size = new System.Drawing.Size(129, 20);
            this.lblSumBookPrice.TabIndex = 6;
            this.lblSumBookPrice.Text = "借阅价值（元）：0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "起止日期：";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(193, 14);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(101, 21);
            this.dtpEnd.TabIndex = 15;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(80, 14);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(93, 21);
            this.dtpStart.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "-";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFooter.Controls.Add(this.lblTabRq);
            this.pnlFooter.Controls.Add(this.lblSumBrBooks);
            this.pnlFooter.Controls.Add(this.lblSumRtBooks);
            this.pnlFooter.Controls.Add(this.lblSumBookPrice);
            this.pnlFooter.Controls.Add(this.lblNotRtBooks);
            this.pnlFooter.Controls.Add(this.lblAllCount);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 534);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(976, 39);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblTabRq
            // 
            this.lblTabRq.AutoSize = true;
            this.lblTabRq.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTabRq.ForeColor = System.Drawing.Color.Blue;
            this.lblTabRq.Location = new System.Drawing.Point(0, 8);
            this.lblTabRq.Name = "lblTabRq";
            this.lblTabRq.Size = new System.Drawing.Size(247, 20);
            this.lblTabRq.TabIndex = 7;
            this.lblTabRq.Text = "日期：2019.01.01 至 2019.09.12 ===";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(326, 9);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 31);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "查询(&F)";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 534);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dgvMain);
            this.tabPage1.Controls.Add(this.pnlTab1_Top);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询日期内";
            // 
            // pnlTab1_Top
            // 
            this.pnlTab1_Top.Controls.Add(this.btnFind);
            this.pnlTab1_Top.Controls.Add(this.label3);
            this.pnlTab1_Top.Controls.Add(this.dtpStart);
            this.pnlTab1_Top.Controls.Add(this.label2);
            this.pnlTab1_Top.Controls.Add(this.dtpEnd);
            this.pnlTab1_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTab1_Top.Location = new System.Drawing.Point(3, 3);
            this.pnlTab1_Top.Name = "pnlTab1_Top";
            this.pnlTab1_Top.Size = new System.Drawing.Size(962, 49);
            this.pnlTab1_Top.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dgvTab2);
            this.tabPage2.Controls.Add(this.pnlTab2_Top);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "阅读情况分析";
            // 
            // dgvTab2
            // 
            this.dgvTab2.ColumnCondition = "";
            this.dgvTab2.ColumnHeadersHeight = 26;
            this.dgvTab2.ColumnNames = "";
            this.dgvTab2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvTab2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTab2.Location = new System.Drawing.Point(3, 52);
            this.dgvTab2.Name = "dgvTab2";
            this.dgvTab2.RowIndexEdit = 0;
            this.dgvTab2.RowTemplate.Height = 23;
            this.dgvTab2.ShowRowNumber = true;
            this.dgvTab2.Size = new System.Drawing.Size(516, 453);
            this.dgvTab2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rcode";
            this.dataGridViewTextBoxColumn2.HeaderText = "读者编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "rName";
            this.dataGridViewTextBoxColumn3.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BookCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "年/月";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn5.HeaderText = "阅读数量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BookPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "阅读价值(元)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // pnlTab2_Top
            // 
            this.pnlTab2_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTab2_Top.Location = new System.Drawing.Point(3, 3);
            this.pnlTab2_Top.Name = "pnlTab2_Top";
            this.pnlTab2_Top.Size = new System.Drawing.Size(962, 49);
            this.pnlTab2_Top.TabIndex = 0;
            // 
            // JyxxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 573);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.MaximizeBox = false;
            this.Name = "JyxxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借阅信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlTab1_Top.ResumeLayout(false);
            this.pnlTab1_Top.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RiziFrame.Utility.Uc.DataGridViewEx dgvMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSumRtBooks;
        private System.Windows.Forms.Label lblSumBrBooks;
        private System.Windows.Forms.Label lblNotRtBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFactReturnDate;
        private System.Windows.Forms.Label lblSumBookPrice;
        private System.Windows.Forms.Label lblAllCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlTab1_Top;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlTab2_Top;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvTab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblTabRq;
    }
}