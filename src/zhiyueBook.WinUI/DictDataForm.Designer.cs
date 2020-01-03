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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvMain = new RiziFrame.Utility.Uc.DataGridViewEx();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.btnGrpsCurd = new RiziFrame.Utility.Uc.BtnGrp1();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlMainTop.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMain);
            this.pnlMain.Controls.Add(this.pnlMainTop);
            this.pnlMain.Controls.Add(this.splitter1);
            this.pnlMain.Controls.Add(this.tvMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(860, 566);
            this.pnlMain.TabIndex = 5;
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
            this.cRemark});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(248, 55);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowIndexEdit = 0;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.ShowRowNumber = true;
            this.dgvMain.Size = new System.Drawing.Size(612, 511);
            this.dgvMain.TabIndex = 3;
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
            // cName
            // 
            this.cName.DataPropertyName = "Name";
            this.cName.Frozen = true;
            this.cName.HeaderText = "名称";
            this.cName.Name = "cName";
            this.cName.Width = 180;
            // 
            // cRemark
            // 
            this.cRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cRemark.DataPropertyName = "Remark";
            this.cRemark.HeaderText = "备注";
            this.cRemark.Name = "cRemark";
            // 
            // pnlMainTop
            // 
            this.pnlMainTop.BackColor = System.Drawing.SystemColors.Info;
            this.pnlMainTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainTop.Controls.Add(this.lblTitle);
            this.pnlMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTop.Location = new System.Drawing.Point(248, 0);
            this.pnlMainTop.Name = "pnlMainTop";
            this.pnlMainTop.Size = new System.Drawing.Size(612, 55);
            this.pnlMainTop.TabIndex = 2;
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
            // 
            // btnGrpsCurd
            // 
            this.btnGrpsCurd.Location = new System.Drawing.Point(12, 12);
            this.btnGrpsCurd.Name = "btnGrpsCurd";
            this.btnGrpsCurd.Size = new System.Drawing.Size(387, 33);
            this.btnGrpsCurd.TabIndex = 12;
            this.btnGrpsCurd.UCAddBtnClicked += new RiziFrame.Utility.Uc.BtnGrp1.UCAddBtnClickHandle(this.btnGrpsCurd_UCAddBtnClicked);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnGrpsCurd);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(860, 56);
            this.pnlTop.TabIndex = 6;
            // 
            // JcJcsjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 622);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "JcJcsjForm";
            this.Text = "基础信息";
            this.Load += new System.EventHandler(this.JcJcsjForm_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlMainTop.ResumeLayout(false);
            this.pnlMainTop.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private RiziFrame.Utility.Uc.DataGridViewEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemark;
        private System.Windows.Forms.Panel pnlMainTop;
        private RiziFrame.Utility.Uc.BtnGrp1 btnGrpsCurd;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
    }
}