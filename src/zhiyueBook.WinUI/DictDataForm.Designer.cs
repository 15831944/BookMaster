namespace zhiyueBook.WinUI
{
    partial class DictDataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictDataForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMain = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMainChangGui = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGrpsCurd = new RiziFrame.Utility.Uc.BtnGrp1();
            this.pnlMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainChangGui)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Controls.Add(this.splitter1);
            this.pnlMain.Controls.Add(this.tvMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(860, 566);
            this.pnlMain.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(248, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 566);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMain);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据字典";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dgvMain.Size = new System.Drawing.Size(598, 517);
            this.dgvMain.TabIndex = 3;
            this.dgvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDoubleClick);
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
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Name";
            this.cName.Frozen = true;
            this.cName.HeaderText = "名称";
            this.cName.Name = "cName";
            this.cName.Width = 180;
            // 
            // cParentId
            // 
            this.cParentId.DataPropertyName = "ParentId";
            this.cParentId.HeaderText = "父类型";
            this.cParentId.Name = "cParentId";
            // 
            // cRemark
            // 
            this.cRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cRemark.DataPropertyName = "Remark";
            this.cRemark.HeaderText = "备注";
            this.cRemark.Name = "cRemark";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMainChangGui);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "常规字典";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.dgvMainChangGui.Size = new System.Drawing.Size(598, 462);
            this.dgvMainChangGui.TabIndex = 4;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ParentId";
            this.dataGridViewTextBoxColumn4.HeaderText = "父类型";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn5.HeaderText = "备注";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 55);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "node_root.png");
            this.imageList1.Images.SetKeyName(1, "node_child1.png");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(245, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 566);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // tvMain
            // 
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Name = "tvMain";
            this.tvMain.Size = new System.Drawing.Size(245, 566);
            this.tvMain.TabIndex = 0;
            this.tvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterSelect);
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
            // DictDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 622);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "DictDataForm";
            this.Text = "基础信息";
            this.Load += new System.EventHandler(this.JcJcsjForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainChangGui)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMain;
        private RiziFrame.Utility.Uc.BtnGrp1 btnGrpsCurd;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cParentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemark;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMainChangGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}