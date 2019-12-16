namespace zhiyueBook.WinUI
{
    partial class TjtsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboAllRq = new System.Windows.Forms.CheckBox();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAllCount = new System.Windows.Forms.Label();
            this.lblSumBookPriceJc = new System.Windows.Forms.Label();
            this.lblSumBookPriceZg = new System.Windows.Forms.Label();
            this.lblSumBookPrice = new System.Windows.Forms.Label();
            this.cboStop = new System.Windows.Forms.CheckBox();
            this.dgvMain = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRestNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastRtReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNotBrDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNotRtDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJccs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuolv = new System.Windows.Forms.Button();
            this.pnlTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAllRq
            // 
            this.cboAllRq.AutoSize = true;
            this.cboAllRq.Enabled = false;
            this.cboAllRq.Location = new System.Drawing.Point(724, 14);
            this.cboAllRq.Name = "cboAllRq";
            this.cboAllRq.Size = new System.Drawing.Size(72, 16);
            this.cboAllRq.TabIndex = 15;
            this.cboAllRq.Text = "全部日期";
            this.cboAllRq.UseVisualStyleBackColor = true;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(134, 11);
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
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "书名、拼音/条形码：";
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopRight.Controls.Add(this.lblState);
            this.pnlTopRight.Controls.Add(this.lblAllCount);
            this.pnlTopRight.Controls.Add(this.lblSumBookPriceJc);
            this.pnlTopRight.Controls.Add(this.lblSumBookPriceZg);
            this.pnlTopRight.Controls.Add(this.lblSumBookPrice);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopRight.Location = new System.Drawing.Point(0, 547);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(1276, 37);
            this.pnlTopRight.TabIndex = 8;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.Blue;
            this.lblState.Location = new System.Drawing.Point(158, 6);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(238, 20);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "（其中：借出：{0}本,  在馆：{1}本）";
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
            // lblSumBookPriceJc
            // 
            this.lblSumBookPriceJc.AutoSize = true;
            this.lblSumBookPriceJc.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumBookPriceJc.ForeColor = System.Drawing.Color.Red;
            this.lblSumBookPriceJc.Location = new System.Drawing.Point(1090, 6);
            this.lblSumBookPriceJc.Name = "lblSumBookPriceJc";
            this.lblSumBookPriceJc.Size = new System.Drawing.Size(101, 20);
            this.lblSumBookPriceJc.TabIndex = 7;
            this.lblSumBookPriceJc.Text = "借出总价：0元";
            // 
            // lblSumBookPriceZg
            // 
            this.lblSumBookPriceZg.AutoSize = true;
            this.lblSumBookPriceZg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumBookPriceZg.ForeColor = System.Drawing.Color.Blue;
            this.lblSumBookPriceZg.Location = new System.Drawing.Point(908, 6);
            this.lblSumBookPriceZg.Name = "lblSumBookPriceZg";
            this.lblSumBookPriceZg.Size = new System.Drawing.Size(101, 20);
            this.lblSumBookPriceZg.TabIndex = 6;
            this.lblSumBookPriceZg.Text = "在馆总价：0元";
            // 
            // lblSumBookPrice
            // 
            this.lblSumBookPrice.AutoSize = true;
            this.lblSumBookPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumBookPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblSumBookPrice.Location = new System.Drawing.Point(718, 6);
            this.lblSumBookPrice.Name = "lblSumBookPrice";
            this.lblSumBookPrice.Size = new System.Drawing.Size(101, 20);
            this.lblSumBookPrice.TabIndex = 5;
            this.lblSumBookPrice.Text = "图书总价：0元";
            // 
            // cboStop
            // 
            this.cboStop.AutoSize = true;
            this.cboStop.Location = new System.Drawing.Point(612, 14);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(96, 16);
            this.cboStop.TabIndex = 1;
            this.cboStop.Text = "显示无条形码";
            this.cboStop.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnCondition = "";
            this.dgvMain.ColumnHeadersHeight = 26;
            this.dgvMain.ColumnNames = "";
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cState,
            this.cBookCode,
            this.cName,
            this.cBarcode,
            this.cBookPrice,
            this.cBookPlace,
            this.cNumber,
            this.cRestNumber,
            this.cRegDate,
            this.cLastBorrowDate,
            this.cLastReaderName,
            this.cLastReturnDate,
            this.cLastRtReaderName,
            this.cNotBrDays,
            this.cNotRtDays,
            this.cJccs,
            this.cNameCode});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowIndexEdit = 0;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.ShowRowNumber = true;
            this.dgvMain.Size = new System.Drawing.Size(1276, 547);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            this.dgvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDoubleClick);
            this.dgvMain.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMain_RowPostPaint);
            // 
            // cState
            // 
            this.cState.DataPropertyName = "State";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cState.DefaultCellStyle = dataGridViewCellStyle1;
            this.cState.Frozen = true;
            this.cState.HeaderText = "状态";
            this.cState.Name = "cState";
            this.cState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cState.Width = 50;
            // 
            // cBookCode
            // 
            this.cBookCode.DataPropertyName = "BookCode";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cBookCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.cBookCode.Frozen = true;
            this.cBookCode.HeaderText = "图书编号";
            this.cBookCode.Name = "cBookCode";
            this.cBookCode.Width = 80;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Name";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cName.DefaultCellStyle = dataGridViewCellStyle3;
            this.cName.Frozen = true;
            this.cName.HeaderText = "图书名称";
            this.cName.Name = "cName";
            this.cName.Width = 230;
            // 
            // cBarcode
            // 
            this.cBarcode.DataPropertyName = "Barcode";
            this.cBarcode.Frozen = true;
            this.cBarcode.HeaderText = "条形码";
            this.cBarcode.Name = "cBarcode";
            this.cBarcode.Width = 80;
            // 
            // cBookPrice
            // 
            this.cBookPrice.DataPropertyName = "BookPrice";
            this.cBookPrice.HeaderText = "价格";
            this.cBookPrice.Name = "cBookPrice";
            this.cBookPrice.Width = 50;
            // 
            // cBookPlace
            // 
            this.cBookPlace.DataPropertyName = "BookPlace";
            this.cBookPlace.HeaderText = "位置";
            this.cBookPlace.Name = "cBookPlace";
            this.cBookPlace.Width = 50;
            // 
            // cNumber
            // 
            this.cNumber.DataPropertyName = "Number";
            this.cNumber.HeaderText = "馆藏数量";
            this.cNumber.Name = "cNumber";
            this.cNumber.Width = 60;
            // 
            // cRestNumber
            // 
            this.cRestNumber.DataPropertyName = "RestNumber";
            this.cRestNumber.HeaderText = "馆内剩余";
            this.cRestNumber.Name = "cRestNumber";
            this.cRestNumber.Width = 60;
            // 
            // cRegDate
            // 
            this.cRegDate.DataPropertyName = "RegDate";
            this.cRegDate.HeaderText = "登记日期";
            this.cRegDate.Name = "cRegDate";
            this.cRegDate.Width = 80;
            // 
            // cLastBorrowDate
            // 
            this.cLastBorrowDate.DataPropertyName = "LastBorrowDate";
            this.cLastBorrowDate.HeaderText = "最后借出日期";
            this.cLastBorrowDate.Name = "cLastBorrowDate";
            // 
            // cLastReaderName
            // 
            this.cLastReaderName.DataPropertyName = "LastReaderName";
            this.cLastReaderName.HeaderText = "最后借出人";
            this.cLastReaderName.Name = "cLastReaderName";
            this.cLastReaderName.Width = 80;
            // 
            // cLastReturnDate
            // 
            this.cLastReturnDate.DataPropertyName = "LastReturnDate";
            this.cLastReturnDate.HeaderText = "最后还书日期";
            this.cLastReturnDate.Name = "cLastReturnDate";
            // 
            // cLastRtReaderName
            // 
            this.cLastRtReaderName.DataPropertyName = "LastRtReaderName";
            this.cLastRtReaderName.HeaderText = "最后还书人";
            this.cLastRtReaderName.Name = "cLastRtReaderName";
            this.cLastRtReaderName.Width = 80;
            // 
            // cNotBrDays
            // 
            this.cNotBrDays.DataPropertyName = "NotBrDays";
            this.cNotBrDays.HeaderText = "未借天数";
            this.cNotBrDays.Name = "cNotBrDays";
            this.cNotBrDays.Width = 60;
            // 
            // cNotRtDays
            // 
            this.cNotRtDays.DataPropertyName = "NotRtDays";
            this.cNotRtDays.HeaderText = "未还天数";
            this.cNotRtDays.Name = "cNotRtDays";
            this.cNotRtDays.Width = 60;
            // 
            // cJccs
            // 
            this.cJccs.DataPropertyName = "Jccs";
            this.cJccs.HeaderText = "借出次数";
            this.cJccs.Name = "cJccs";
            this.cJccs.Width = 60;
            // 
            // cNameCode
            // 
            this.cNameCode.DataPropertyName = "NameCode";
            this.cNameCode.HeaderText = "拼音码";
            this.cNameCode.Name = "cNameCode";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMain);
            this.pnlMain.Controls.Add(this.pnlTopRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 43);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1276, 584);
            this.pnlMain.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(423, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(111, 31);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "刷新数据(&R)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.btnGuolv);
            this.pnlTop.Controls.Add(this.cboAllRq);
            this.pnlTop.Controls.Add(this.txtKeyWord);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cboStop);
            this.pnlTop.Controls.Add(this.btnFind);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1276, 43);
            this.pnlTop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(893, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "提示：如果数据有变化，先刷新数据，再过滤查询数据";
            // 
            // btnGuolv
            // 
            this.btnGuolv.Location = new System.Drawing.Point(305, 7);
            this.btnGuolv.Name = "btnGuolv";
            this.btnGuolv.Size = new System.Drawing.Size(91, 31);
            this.btnGuolv.TabIndex = 16;
            this.btnGuolv.Text = "查询(&F)";
            this.btnGuolv.UseVisualStyleBackColor = true;
            this.btnGuolv.Click += new System.EventHandler(this.btnGuolv_Click);
            // 
            // TjtsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 627);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "TjtsForm";
            this.Text = "图书统计";
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cboAllRq;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAllCount;
        private System.Windows.Forms.Label lblSumBookPriceJc;
        private System.Windows.Forms.Label lblSumBookPriceZg;
        private System.Windows.Forms.Label lblSumBookPrice;
        private System.Windows.Forms.CheckBox cboStop;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnGuolv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRestNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastRtReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNotBrDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNotRtDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJccs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameCode;
    }
}