namespace zhiyueBook.WinUI
{
    partial class JcReaderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JcReaderForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvMain = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSyDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMembType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAgeBrith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLinkTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJssrDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValidityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSumBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPinYin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAllCount = new System.Windows.Forms.Label();
            this.lblSumBrBooks = new System.Windows.Forms.Label();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGrpsCurd = new RiziFrame.Utility.Uc.BtnGrp1();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTopRight.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMain);
            this.pnlMain.Controls.Add(this.pnlTopRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 48);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1276, 544);
            this.pnlMain.TabIndex = 3;
            // 
            // dgvMain
            // 
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnCondition = "";
            this.dgvMain.ColumnHeadersHeight = 26;
            this.dgvMain.ColumnNames = "";
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cState,
            this.cId,
            this.cSyDays,
            this.cRcode,
            this.cName,
            this.cSex,
            this.cMembType,
            this.cTypeName,
            this.cAgeBrith,
            this.cLinkTel,
            this.cRegDate,
            this.cJssrDate,
            this.cValidityDate,
            this.cSumBookPrice,
            this.cPinYin,
            this.cAddress,
            this.cRemark});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowIndexEdit = 0;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.ShowRowNumber = true;
            this.dgvMain.Size = new System.Drawing.Size(1276, 507);
            this.dgvMain.TabIndex = 0;
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
            this.cState.Width = 68;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.Frozen = true;
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            this.cId.Visible = false;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cRcode.DefaultCellStyle = dataGridViewCellStyle2;
            this.cRcode.Frozen = true;
            this.cRcode.HeaderText = "读者编号";
            this.cRcode.Name = "cRcode";
            this.cRcode.Width = 68;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Rname";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cName.DefaultCellStyle = dataGridViewCellStyle3;
            this.cName.Frozen = true;
            this.cName.HeaderText = "姓名";
            this.cName.Name = "cName";
            this.cName.Width = 68;
            // 
            // cSex
            // 
            this.cSex.DataPropertyName = "Sex";
            this.cSex.Frozen = true;
            this.cSex.HeaderText = "性别";
            this.cSex.Name = "cSex";
            this.cSex.Width = 42;
            // 
            // cMembType
            // 
            this.cMembType.DataPropertyName = "MembTypeId";
            this.cMembType.Frozen = true;
            this.cMembType.HeaderText = "会员类型";
            this.cMembType.Name = "cMembType";
            this.cMembType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cMembType.Visible = false;
            this.cMembType.Width = 80;
            // 
            // cTypeName
            // 
            this.cTypeName.DataPropertyName = "MembTypeName";
            this.cTypeName.HeaderText = "会员类型名称";
            this.cTypeName.Name = "cTypeName";
            // 
            // cAgeBrith
            // 
            this.cAgeBrith.DataPropertyName = "AgeBrith";
            this.cAgeBrith.HeaderText = "生日/年龄";
            this.cAgeBrith.Name = "cAgeBrith";
            this.cAgeBrith.Width = 150;
            // 
            // cLinkTel
            // 
            this.cLinkTel.DataPropertyName = "LinkTel";
            this.cLinkTel.HeaderText = "电话/手机";
            this.cLinkTel.Name = "cLinkTel";
            this.cLinkTel.Width = 160;
            // 
            // cRegDate
            // 
            this.cRegDate.DataPropertyName = "RegDate";
            this.cRegDate.HeaderText = "登记日期";
            this.cRegDate.Name = "cRegDate";
            // 
            // cJssrDate
            // 
            this.cJssrDate.DataPropertyName = "JssrDate";
            this.cJssrDate.HeaderText = "借书首日";
            this.cJssrDate.Name = "cJssrDate";
            // 
            // cValidityDate
            // 
            this.cValidityDate.DataPropertyName = "ValidityDate";
            this.cValidityDate.HeaderText = "有效期至";
            this.cValidityDate.Name = "cValidityDate";
            // 
            // cSumBookPrice
            // 
            this.cSumBookPrice.DataPropertyName = "sumBookPrice";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            this.cSumBookPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.cSumBookPrice.HeaderText = "收费信息";
            this.cSumBookPrice.Name = "cSumBookPrice";
            // 
            // cPinYin
            // 
            this.cPinYin.DataPropertyName = "PinYin";
            this.cPinYin.HeaderText = "拼音码";
            this.cPinYin.Name = "cPinYin";
            this.cPinYin.Width = 50;
            // 
            // cAddress
            // 
            this.cAddress.DataPropertyName = "Address";
            this.cAddress.HeaderText = "地址";
            this.cAddress.Name = "cAddress";
            this.cAddress.Width = 120;
            // 
            // cRemark
            // 
            this.cRemark.DataPropertyName = "Remark";
            this.cRemark.HeaderText = "备注";
            this.cRemark.Name = "cRemark";
            this.cRemark.Width = 200;
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopRight.Controls.Add(this.lblState);
            this.pnlTopRight.Controls.Add(this.lblAllCount);
            this.pnlTopRight.Controls.Add(this.lblSumBrBooks);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopRight.Location = new System.Drawing.Point(0, 507);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(1276, 37);
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
            this.lblAllCount.Location = new System.Drawing.Point(15, 6);
            this.lblAllCount.Name = "lblAllCount";
            this.lblAllCount.Size = new System.Drawing.Size(117, 20);
            this.lblAllCount.TabIndex = 8;
            this.lblAllCount.Text = "读者总记录：100";
            // 
            // lblSumBrBooks
            // 
            this.lblSumBrBooks.AutoSize = true;
            this.lblSumBrBooks.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumBrBooks.ForeColor = System.Drawing.Color.Blue;
            this.lblSumBrBooks.Location = new System.Drawing.Point(1033, 6);
            this.lblSumBrBooks.Name = "lblSumBrBooks";
            this.lblSumBrBooks.Size = new System.Drawing.Size(195, 20);
            this.lblSumBrBooks.TabIndex = 5;
            this.lblSumBrBooks.Text = "日期：2019年12月1日 星期日";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(84, 14);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(123, 21);
            this.txtKeyWord.TabIndex = 10;
            this.txtKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyWord_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "姓名或拼音：";
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(222, 9);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 31);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = " 查询(&F)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnGrpsCurd);
            this.pnlTop.Controls.Add(this.txtKeyWord);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnFind);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1276, 48);
            this.pnlTop.TabIndex = 2;
            // 
            // btnGrpsCurd
            // 
            this.btnGrpsCurd.Location = new System.Drawing.Point(315, 7);
            this.btnGrpsCurd.Name = "btnGrpsCurd";
            this.btnGrpsCurd.Size = new System.Drawing.Size(387, 33);
            this.btnGrpsCurd.TabIndex = 11;
            this.btnGrpsCurd.UCAddBtnClicked += new RiziFrame.Utility.Uc.BtnGrp1.UCAddBtnClickHandle(this.btnGrpsCurd_UCAddBtnClicked);
            this.btnGrpsCurd.UCDelBtnClicked += new RiziFrame.Utility.Uc.BtnGrp1.UCDelBtnClickHandle(this.btnGrpsCurd_UCDelBtnClicked);
            this.btnGrpsCurd.UCExtBtnClicked += new RiziFrame.Utility.Uc.BtnGrp1.UCExtBtnClickHandle(this.btnGrpsCurd_UCExtBtnClicked);
            // 
            // JcReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 592);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "JcReaderForm";
            this.Text = "读者管理";
            this.Load += new System.EventHandler(this.JcReaderForm_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMain;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAllCount;
        private System.Windows.Forms.Label lblSumBrBooks;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel pnlTop;
        private RiziFrame.Utility.Uc.BtnGrp1 btnGrpsCurd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSyDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMembType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAgeBrith;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLinkTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJssrDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValidityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSumBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPinYin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemark;
    }
}