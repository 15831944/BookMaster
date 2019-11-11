namespace zhiyueBook.WinUI
{
    partial class TjtsxxFrom
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
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookCfwz = new System.Windows.Forms.Label();
            this.lblBookJycs = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMain = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.pnlTab1_Top = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFactReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExceedDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTab1_Top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblBookPrice.Location = new System.Drawing.Point(16, 9);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(112, 20);
            this.lblBookPrice.TabIndex = 2;
            this.lblBookPrice.Text = "价格：100.00 元";
            // 
            // lblBookCfwz
            // 
            this.lblBookCfwz.AutoSize = true;
            this.lblBookCfwz.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookCfwz.ForeColor = System.Drawing.Color.Blue;
            this.lblBookCfwz.Location = new System.Drawing.Point(152, 9);
            this.lblBookCfwz.Name = "lblBookCfwz";
            this.lblBookCfwz.Size = new System.Drawing.Size(96, 20);
            this.lblBookCfwz.TabIndex = 3;
            this.lblBookCfwz.Text = "存放位置：C1";
            // 
            // lblBookJycs
            // 
            this.lblBookJycs.AutoSize = true;
            this.lblBookJycs.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookJycs.ForeColor = System.Drawing.Color.Red;
            this.lblBookJycs.Location = new System.Drawing.Point(272, 9);
            this.lblBookJycs.Name = "lblBookJycs";
            this.lblBookJycs.Size = new System.Drawing.Size(87, 20);
            this.lblBookJycs.TabIndex = 5;
            this.lblBookJycs.Text = "借阅次数：0";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 520);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dgvMain);
            this.tabPage1.Controls.Add(this.pnlTab1_Top);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询日期内";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnCondition = "";
            this.dgvMain.ColumnHeadersHeight = 26;
            this.dgvMain.ColumnNames = "";
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cState,
            this.cBookCode,
            this.cBookName,
            this.cBarcode,
            this.cRcode,
            this.cName,
            this.cTel,
            this.cBorrowDate,
            this.cReturnDate,
            this.cFactReturnDate,
            this.cExceedDay});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 53);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowIndexEdit = 0;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.ShowRowNumber = true;
            this.dgvMain.Size = new System.Drawing.Size(938, 438);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDoubleClick);
            // 
            // pnlTab1_Top
            // 
            this.pnlTab1_Top.Controls.Add(this.panel1);
            this.pnlTab1_Top.Controls.Add(this.btnClose);
            this.pnlTab1_Top.Controls.Add(this.lblName);
            this.pnlTab1_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTab1_Top.Location = new System.Drawing.Point(3, 3);
            this.pnlTab1_Top.Name = "pnlTab1_Top";
            this.pnlTab1_Top.Size = new System.Drawing.Size(938, 50);
            this.pnlTab1_Top.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(864, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Green;
            this.lblName.Location = new System.Drawing.Point(14, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(154, 22);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "《小公主励志故事》";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblBookJycs);
            this.panel1.Controls.Add(this.lblBookPrice);
            this.panel1.Controls.Add(this.lblBookCfwz);
            this.panel1.Location = new System.Drawing.Point(478, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 39);
            this.panel1.TabIndex = 7;
            // 
            // cState
            // 
            this.cState.DataPropertyName = "State";
            this.cState.Frozen = true;
            this.cState.HeaderText = "状态";
            this.cState.Name = "cState";
            this.cState.Width = 50;
            // 
            // cBookCode
            // 
            this.cBookCode.DataPropertyName = "BookCode";
            this.cBookCode.Frozen = true;
            this.cBookCode.HeaderText = "图书编号";
            this.cBookCode.Name = "cBookCode";
            this.cBookCode.Visible = false;
            // 
            // cBookName
            // 
            this.cBookName.DataPropertyName = "BookName";
            this.cBookName.Frozen = true;
            this.cBookName.HeaderText = "书名";
            this.cBookName.Name = "cBookName";
            this.cBookName.Visible = false;
            this.cBookName.Width = 220;
            // 
            // cBarcode
            // 
            this.cBarcode.DataPropertyName = "Barcode";
            this.cBarcode.Frozen = true;
            this.cBarcode.HeaderText = "条形码";
            this.cBarcode.Name = "cBarcode";
            this.cBarcode.Visible = false;
            // 
            // cRcode
            // 
            this.cRcode.DataPropertyName = "Rcode";
            this.cRcode.HeaderText = "读者编号";
            this.cRcode.Name = "cRcode";
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Rname";
            this.cName.HeaderText = "读者姓名";
            this.cName.Name = "cName";
            // 
            // cTel
            // 
            this.cTel.DataPropertyName = "LinkTel";
            this.cTel.HeaderText = "电话/手机";
            this.cTel.Name = "cTel";
            this.cTel.Width = 200;
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
            // cExceedDay
            // 
            this.cExceedDay.DataPropertyName = "ExceedDay";
            this.cExceedDay.HeaderText = "逾期天数";
            this.cExceedDay.Name = "cExceedDay";
            // 
            // TjtsxxFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 520);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "TjtsxxFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅历史信息";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTab1_Top.ResumeLayout(false);
            this.pnlTab1_Top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookCfwz;
        private System.Windows.Forms.Label lblBookJycs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMain;
        private System.Windows.Forms.Panel pnlTab1_Top;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFactReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExceedDay;
    }
}