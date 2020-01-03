namespace zhiyueBook.WinUI
{
    partial class JcReaderXxForm
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
            this.btnGrp21 = new RiziFrame.Utility.Uc.BtnGrp2();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYajinSs = new System.Windows.Forms.TextBox();
            this.txtYajinYs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHuifeiSs = new System.Windows.Forms.TextBox();
            this.txtHuifeiYs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMembType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPinyin = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbSex = new RiziFrame.Utility.Uc.MyCombobox();
            this.dtpValidityDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(96)))), ((int)(((byte)(162)))));
            this.pnlTop.Controls.Add(this.btnGrp21);
            this.pnlTop.Controls.Add(this.checkBox1);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(807, 63);
            this.pnlTop.TabIndex = 0;
            // 
            // btnGrp21
            // 
            this.btnGrp21.Location = new System.Drawing.Point(608, 16);
            this.btnGrp21.Name = "btnGrp21";
            this.btnGrp21.Size = new System.Drawing.Size(189, 34);
            this.btnGrp21.TabIndex = 2;
            this.btnGrp21.UCSaveBtnClicked += new RiziFrame.Utility.Uc.BtnGrp2.UCSaveBtnClickHandle(this.btnGrp21_UCSaveBtnClicked);
            this.btnGrp21.UCExtBtnClicked += new RiziFrame.Utility.Uc.BtnGrp2.UCExtBtnClickHandle(this.btnGrp21_UCExtBtnClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(509, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "停用";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(310, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "押　金：已收";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "会员费：已收";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "会员：张三 -【年卡】";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 63);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(807, 371);
            this.pnlMain.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYajinSs);
            this.groupBox2.Controls.Add(this.txtYajinYs);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtHuifeiSs);
            this.groupBox2.Controls.Add(this.txtHuifeiYs);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbMembType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(546, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "费用信息";
            // 
            // txtYajinSs
            // 
            this.txtYajinSs.Location = new System.Drawing.Point(91, 190);
            this.txtYajinSs.Name = "txtYajinSs";
            this.txtYajinSs.Size = new System.Drawing.Size(121, 21);
            this.txtYajinSs.TabIndex = 12;
            // 
            // txtYajinYs
            // 
            this.txtYajinYs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtYajinYs.Enabled = false;
            this.txtYajinYs.Location = new System.Drawing.Point(91, 156);
            this.txtYajinYs.Name = "txtYajinYs";
            this.txtYajinYs.Size = new System.Drawing.Size(121, 21);
            this.txtYajinYs.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(22, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "实收押金：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(22, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "应收押金：";
            // 
            // txtHuifeiSs
            // 
            this.txtHuifeiSs.Location = new System.Drawing.Point(91, 107);
            this.txtHuifeiSs.Name = "txtHuifeiSs";
            this.txtHuifeiSs.Size = new System.Drawing.Size(121, 21);
            this.txtHuifeiSs.TabIndex = 8;
            // 
            // txtHuifeiYs
            // 
            this.txtHuifeiYs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtHuifeiYs.Enabled = false;
            this.txtHuifeiYs.Location = new System.Drawing.Point(91, 73);
            this.txtHuifeiYs.Name = "txtHuifeiYs";
            this.txtHuifeiYs.Size = new System.Drawing.Size(121, 21);
            this.txtHuifeiYs.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(22, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "实收会费：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(22, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "应收会费：";
            // 
            // cbbMembType
            // 
            this.cbbMembType.FormattingEnabled = true;
            this.cbbMembType.Location = new System.Drawing.Point(91, 40);
            this.cbbMembType.Name = "cbbMembType";
            this.cbbMembType.Size = new System.Drawing.Size(121, 20);
            this.cbbMembType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(22, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "会员类型：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPinyin);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cbbSex);
            this.groupBox1.Controls.Add(this.dtpValidityDate);
            this.groupBox1.Controls.Add(this.dtpRegDate);
            this.groupBox1.Controls.Add(this.dtpBirthDay);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtRname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtRcode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // txtPinyin
            // 
            this.txtPinyin.Location = new System.Drawing.Point(89, 147);
            this.txtPinyin.Name = "txtPinyin";
            this.txtPinyin.Size = new System.Drawing.Size(152, 21);
            this.txtPinyin.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(26, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 17);
            this.label19.TabIndex = 38;
            this.label19.Text = "拼音码：";
            // 
            // cbbSex
            // 
            this.cbbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.ItemHeight = 12;
            this.cbbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbbSex.Location = new System.Drawing.Point(89, 74);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(149, 20);
            this.cbbSex.TabIndex = 37;
            // 
            // dtpValidityDate
            // 
            this.dtpValidityDate.Location = new System.Drawing.Point(350, 312);
            this.dtpValidityDate.Name = "dtpValidityDate";
            this.dtpValidityDate.Size = new System.Drawing.Size(152, 21);
            this.dtpValidityDate.TabIndex = 36;
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Location = new System.Drawing.Point(89, 312);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(152, 21);
            this.dtpRegDate.TabIndex = 35;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(350, 74);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(152, 21);
            this.dtpBirthDay.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(280, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "有效期至：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(19, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "登记日期：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(89, 228);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(413, 55);
            this.txtRemark.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(38, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "备注：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(89, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(413, 21);
            this.txtAddress.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(38, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "地址：";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(350, 111);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(152, 21);
            this.txtMobile.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(301, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "手机：";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(89, 111);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(152, 21);
            this.txtTel.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(38, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "电话：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(301, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "生日：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(38, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "性别：";
            // 
            // txtRname
            // 
            this.txtRname.Location = new System.Drawing.Point(350, 39);
            this.txtRname.Name = "txtRname";
            this.txtRname.Size = new System.Drawing.Size(152, 21);
            this.txtRname.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(301, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "姓名：";
            // 
            // txtRcode
            // 
            this.txtRcode.Location = new System.Drawing.Point(89, 40);
            this.txtRcode.Name = "txtRcode";
            this.txtRcode.Size = new System.Drawing.Size(152, 21);
            this.txtRcode.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(14, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "读者编号：";
            // 
            // JcReaderXxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 434);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JcReaderXxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者信息";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMembType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHuifeiSs;
        private System.Windows.Forms.TextBox txtHuifeiYs;
        private System.Windows.Forms.TextBox txtYajinSs;
        private System.Windows.Forms.TextBox txtYajinYs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private RiziFrame.Utility.Uc.BtnGrp2 btnGrp21;
        private System.Windows.Forms.DateTimePicker dtpValidityDate;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private RiziFrame.Utility.Uc.MyCombobox cbbSex;
        private System.Windows.Forms.TextBox txtPinyin;
        private System.Windows.Forms.Label label19;
    }
}