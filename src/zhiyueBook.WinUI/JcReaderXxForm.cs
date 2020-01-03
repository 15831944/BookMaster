using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RiziFrame.Utility.Common;
using zhiyueBook.Model;
using zhiyueBook.DAL;

namespace zhiyueBook.WinUI
{
    public partial class JcReaderXxForm : Form
    {
        // 创建数据访问服务        
        private ICommonCURD<JcReader> srv = new JcReaderService();

        string postFlag = string.Empty;      // 传递的标志
        JcReader postObj = new JcReader ();  // 传递的对象

        public JcReaderXxForm(PostArgHelper postArg)
        {
            InitializeComponent();
                        
            // 初始化数据
            BandingData();

            // 接受传递的数据
            postFlag = postArg.postFlag.ToString();
            postObj = (JcReader)postArg.postObj;

            this.init();
            
        }

        private void btnGrp21_UCExtBtnClicked(object sender, EventArgs e)
        {
            this.Close();
        }


        private void init() 
        {
            // 修改
            if ((PostArgType.Mod.ToString()).Equals(postFlag))
            {                 
                this.ModStatus(postObj);
            }
            else {
                this.NewStatus(postObj);
            }
            
        }

        #region 【1】 窗口打开时的数据显示
        /// <summary>
        /// 设置mod状态时的数据
        /// </summary>
        private void ModStatus(JcReader obj)
        {
            // 设置不可修改字段
            //this.txtRcode.Enabled = false;
            //this.dtpRegDate.Enabled = false;

            // 设置初始化值
            this.txtRcode.Text = obj.Rcode;
            this.txtRname.Text = obj.Rname;            
            this.cbbSex.Text = obj.Sex;
            this.dtpBirthDay.Text = obj.BirthDay.ToShortDateString();

            this.txtTel.Text = obj.Tel;
            this.txtMobile.Text = obj.Mobile;

            this.cbbMembType.Text = obj.MembType;
            this.txtPinyin.Text = obj.PinYin;
            this.txtAddress.Text = obj.Address;
            this.txtRemark.Text = obj.Remark;
            
            this.dtpRegDate.Text = obj.RegDate.ToShortDateString();
            this.dtpValidityDate.Text = obj.ValidityDate.ToShortDateString();

            // 设置标题文字
            lblTitle.Text = string.Format("{0} -【{1}】", this.txtRname.Text, this.cbbMembType.Text);

        }

        /// <summary>
        /// 设置New状态时的数据
        /// </summary>
        private void NewStatus(JcReader obj)
        {
            ControlHelper.DtpTip(this.dtpBirthDay, "按BackSpace键删除日期");
            ControlHelper.DtpTip(this.dtpValidityDate, "按BackSpace键删除日期");

            ControlHelper.DtpNull(this.dtpBirthDay);            
            ControlHelper.DtpNull(this.dtpValidityDate);

            // 设置标题文字
            lblTitle.Text = string.Format("会员：{0} -【{1}】", "xxx", "xx");
        }

        #endregion

        private void BandingData()
        {
            List<string> lstSex = new List<string>();
            lstSex.Add("");
            lstSex.Add("男");
            lstSex.Add("女");       
            ControlHelper.CbbBindData(cbbSex, lstSex);

            ControlHelper.CbbBindData(cbbMembType, lstSex);

        }

        /// <summary>
        /// 获取 窗口 共有数据
        /// </summary>
        private JcReader GetWindowPublicData()
        {
            // 修改
            JcReader obj = new JcReader();

            obj.id = postObj.id;
            obj.Rcode = this.txtRcode.Text;
            obj.Rname = this.txtRname.Text;
            obj.Sex = this.cbbSex.Text;
            obj.BirthDay = this.dtpBirthDay.Value;

            obj.Tel = this.txtTel.Text;
            obj.Mobile = this.txtMobile.Text;

            obj.MembType = this.cbbMembType.Text;
            obj.PinYin = this.txtPinyin.Text;
            obj.Address = this.txtAddress.Text;
            obj.Remark = this.txtRemark.Text;

            obj.ValidityDate = this.dtpValidityDate.Value;

            return obj;
        }

        /// <summary>
        /// 保存
        /// </summary>
        private void Save()
        {
            JcReader obj = GetWindowPublicData();

            if ((PostArgType.Mod.ToString()).Equals(postFlag))
            {
                //MessageBox.Show(JcReaderForm

                int val = srv.Upd(obj);
                if (val == 1)
                    MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 新增
                //this.New(postObj);
            }
           
        }

        private void btnGrp21_UCSaveBtnClicked(object sender, EventArgs e)
        {            
            this.Save();
        }


    }
}
