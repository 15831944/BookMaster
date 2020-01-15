namespace zhiyueBook.WinUI
{
    partial class DictDataForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictDataForm1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGrpsCurd = new RiziFrame.Utility.Uc.BtnGrp1();
            this.tpHylx = new System.Windows.Forms.TabPage();
            this.dgvMainMbType = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cYaJin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHuiFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaxOutNums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCgzd = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvMainChangGui = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpZdlx = new System.Windows.Forms.TabPage();
            this.dgvMain = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.cRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnlTop.SuspendLayout();
            this.tpHylx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainMbType)).BeginInit();
            this.tpCgzd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainChangGui)).BeginInit();
            this.tpZdlx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "node_root.png");
            this.imageList1.Images.SetKeyName(1, "node_child1.png");
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnGrpsCurd);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(860, 56);
            this.pnlTop.TabIndex = 6;
            // 
            // btnGrpsCurd
            // 
            this.btnGrpsCurd.Location = new System.Drawing.Point(12, 12);
            this.btnGrpsCurd.Name = "btnGrpsCurd";
            this.btnGrpsCurd.Size = new System.Drawing.Size(387, 33);
            this.btnGrpsCurd.TabIndex = 12;
            this.btnGrpsCurd.UCAddBtnClicked += new RiziFrame.Utility.Uc.BtnGrp1.UCAddBtnClickHandle(this.btnGrpsCurd_UCAddBtnClicked);
            this.btnGrpsCurd.UCDelBtnClicked += new RiziFrame.Utility.Uc.BtnGrp1.UCDelBtnClickHandle(this.btnGrpsCurd_UCDelBtnClicked);
            this.btnGrpsCurd.UCEdtBtnClicked += new RiziFrame.Utility.Uc.BtnGrp1.UCEdtBtnClickHandle(this.btnGrpsCurd_UCEdtBtnClicked);
            this.btnGrpsCurd.UCExtBtnClicked += new RiziFrame.Utility.Uc.BtnGrp1.UCExtBtnClickHandle(this.btnGrpsCurd_UCExtBtnClicked);
            // 
            // tpHylx
            // 
            this.tpHylx.Controls.Add(this.dgvMainMbType);
            this.tpHylx.ImageIndex = 1;
            this.tpHylx.Location = new System.Drawing.Point(4, 39);
            this.tpHylx.Name = "tpHylx";
            this.tpHylx.Padding = new System.Windows.Forms.Padding(3);
            this.tpHylx.Size = new System.Drawing.Size(852, 523);
            this.tpHylx.TabIndex = 2;
            this.tpHylx.Tag = "hylx";
            this.tpHylx.Text = "会员类型";
            this.tpHylx.UseVisualStyleBackColor = true;
            // 
            // dgvMainMbType
            // 
            this.dgvMainMbType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMainMbType.ColumnCondition = "";
            this.dgvMainMbType.ColumnHeadersHeight = 26;
            this.dgvMainMbType.ColumnNames = "";
            this.dgvMainMbType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.cMaxOutNums,
            this.cHuiFee,
            this.cYaJin,
            this.dataGridViewTextBoxColumn10});
            this.dgvMainMbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainMbType.Location = new System.Drawing.Point(3, 3);
            this.dgvMainMbType.Name = "dgvMainMbType";
            this.dgvMainMbType.RowIndexEdit = 0;
            this.dgvMainMbType.RowTemplate.Height = 23;
            this.dgvMainMbType.ShowRowNumber = true;
            this.dgvMainMbType.Size = new System.Drawing.Size(846, 517);
            this.dgvMainMbType.TabIndex = 5;
            this.dgvMainMbType.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMainMbType_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn10.HeaderText = "备注";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // cYaJin
            // 
            this.cYaJin.DataPropertyName = "YaJin";
            this.cYaJin.HeaderText = "押金";
            this.cYaJin.Name = "cYaJin";
            // 
            // cHuiFee
            // 
            this.cHuiFee.DataPropertyName = "HuiFee";
            this.cHuiFee.HeaderText = "会费";
            this.cHuiFee.Name = "cHuiFee";
            // 
            // cMaxOutNums
            // 
            this.cMaxOutNums.DataPropertyName = "MaxOutNums";
            this.cMaxOutNums.HeaderText = "最大借出册数";
            this.cMaxOutNums.Name = "cMaxOutNums";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "类型名称";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "State";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "状态";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 68;
            // 
            // tpCgzd
            // 
            this.tpCgzd.Controls.Add(this.dgvMainChangGui);
            this.tpCgzd.Controls.Add(this.panel1);
            this.tpCgzd.ImageIndex = 1;
            this.tpCgzd.Location = new System.Drawing.Point(4, 39);
            this.tpCgzd.Name = "tpCgzd";
            this.tpCgzd.Padding = new System.Windows.Forms.Padding(3);
            this.tpCgzd.Size = new System.Drawing.Size(852, 523);
            this.tpCgzd.TabIndex = 1;
            this.tpCgzd.Tag = "cgzd";
            this.tpCgzd.Text = "常规字典";
            this.tpCgzd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 55);
            this.panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(10, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "选择的基础数据：";
            // 
            // dgvMainChangGui
            // 
            this.dgvMainChangGui.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMainChangGui.ColumnCondition = "";
            this.dgvMainChangGui.ColumnHeadersHeight = 26;
            this.dgvMainChangGui.ColumnNames = "";
            this.dgvMainChangGui.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvMainChangGui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainChangGui.Location = new System.Drawing.Point(3, 58);
            this.dgvMainChangGui.Name = "dgvMainChangGui";
            this.dgvMainChangGui.RowIndexEdit = 0;
            this.dgvMainChangGui.RowTemplate.Height = 23;
            this.dgvMainChangGui.ShowRowNumber = true;
            this.dgvMainChangGui.Size = new System.Drawing.Size(846, 462);
            this.dgvMainChangGui.TabIndex = 4;
            this.dgvMainChangGui.Tag = "cgzd";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn5.HeaderText = "备注";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ParentId";
            this.dataGridViewTextBoxColumn4.HeaderText = "父类型";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "State";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "状态";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 68;
            // 
            // tpZdlx
            // 
            this.tpZdlx.Controls.Add(this.dgvMain);
            this.tpZdlx.ImageIndex = 0;
            this.tpZdlx.Location = new System.Drawing.Point(4, 39);
            this.tpZdlx.Name = "tpZdlx";
            this.tpZdlx.Padding = new System.Windows.Forms.Padding(3);
            this.tpZdlx.Size = new System.Drawing.Size(852, 523);
            this.tpZdlx.TabIndex = 0;
            this.tpZdlx.Tag = "zdlx";
            this.tpZdlx.Text = "数据字典";
            this.tpZdlx.UseVisualStyleBackColor = true;
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
            this.cName,
            this.cParentId,
            this.cRemark});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 3);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowIndexEdit = 0;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.ShowRowNumber = true;
            this.dgvMain.Size = new System.Drawing.Size(846, 517);
            this.dgvMain.TabIndex = 3;
            this.dgvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDoubleClick);
            // 
            // cRemark
            // 
            this.cRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cRemark.DataPropertyName = "Remark";
            this.cRemark.HeaderText = "备注";
            this.cRemark.Name = "cRemark";
            // 
            // cParentId
            // 
            this.cParentId.DataPropertyName = "ParentId";
            this.cParentId.HeaderText = "父类型";
            this.cParentId.Name = "cParentId";
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Name";
            this.cName.Frozen = true;
            this.cName.HeaderText = "名称";
            this.cName.Name = "cName";
            this.cName.Width = 180;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.Frozen = true;
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            // 
            // cState
            // 
            this.cState.DataPropertyName = "State";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cState.DefaultCellStyle = dataGridViewCellStyle3;
            this.cState.Frozen = true;
            this.cState.HeaderText = "状态";
            this.cState.Name = "cState";
            this.cState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cState.Width = 68;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHylx);
            this.tabControl1.Controls.Add(this.tpCgzd);
            this.tabControl1.Controls.Add(this.tpZdlx);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 566);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Tag = "";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // DictDataForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlTop);
            this.Name = "DictDataForm1";
            this.Text = "基础信息";
            this.Load += new System.EventHandler(this.JcJcsjForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.tpHylx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainMbType)).EndInit();
            this.tpCgzd.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainChangGui)).EndInit();
            this.tpZdlx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RiziFrame.Utility.Uc.BtnGrp1 btnGrpsCurd;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tpHylx;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMainMbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaxOutNums;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHuiFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cYaJin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabPage tpCgzd;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMainChangGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tpZdlx;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemark;
        private System.Windows.Forms.TabControl tabControl1;
    }
}