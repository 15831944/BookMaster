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
        public JcReaderModel curObject = new JcReaderModel();
        private string status = "新增";  // 初始状态=新增

        public JcReaderXxForm(JcReaderModel postObject)
        {
            InitializeComponent();

            // 初始化cbb绑定数据
            this.InitCbbBandingData();

            // 根据postObject判断“新增”还是“修改”并绑定数据
            this.BindData(postObject);
            
        }

        private void btnGrp21_UCExtBtnClicked(object sender, EventArgs e)
        {
            this.Close();
        }
      

        #region 【1】 窗口打开时的数据显示
        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="obj"></param>
        private void BindData(JcReaderModel obj)
        {
            // 通过postObject判断是新增，还是修改
            if (obj != null)
            {
                status = "修改";
                this.BindModData(obj);   // 修改状态时绑定postObj对象数据            
            }
            else
            {
                this.BindNewData();   // 修改状态时绑定postObj对象数据
            }
            this.Text = string.Format("读者信息-{0}", status);
        }

        private void BindModData(JcReaderModel obj)
        {
            // 设置当前对象curObject = 传来的obj对象
            this.curObject = obj;

            // 设置初始化值
            this.txtRcode.Text = obj.Rcode;
            this.txtRname.Text = obj.Rname;
            this.cbbSex.Text = obj.Sex;
            this.dtpBirthDay.Text = obj.BirthDay.ToShortDateString();

            this.txtTel.Text = obj.Tel;
            this.txtMobile.Text = obj.Mobile;

            this.cbbMembType.SelectedValue = obj.MembTypeId;

            this.txtPinyin.Text = obj.PinYin;
            this.txtAddress.Text = obj.Address;
            this.txtRemark.Text = obj.Remark;

            this.dtpRegDate.Text = obj.RegDate.ToShortDateString();

            DateTime validityDate = DateTime.Parse(Convert.ToDateTime(obj.ValidityDate).ToString("yyyy-MM-dd"));
            if (validityDate != DateTime.Parse(Convert.ToDateTime(obj.ValidityDate).ToString("0001-1-1")))
                this.dtpValidityDate.Text = validityDate.ToShortDateString();

            if (obj.Stop == 1) this.cbxStop.Checked = true; // stop = 1; 停用

            // 设置标题文字
            lblTitle.Text = string.Format("会员：{0} -【{1}】", this.txtRname.Text, this.cbbMembType.Text);
        }

        /// <summary>
        /// 设置New状态时的数据
        /// </summary>
        private void BindNewData()
        {
            ControlHelper.DtpTip(this.dtpBirthDay, "按BackSpace键删除日期");
            ControlHelper.DtpTip(this.dtpValidityDate, "按BackSpace键删除日期");

            ControlHelper.DtpNull(this.dtpBirthDay);
            ControlHelper.DtpNull(this.dtpValidityDate);

            JcReaderService srv = new JcReaderService();
            // 设置初始化值
            
            string maxCode = (Convert.ToInt32(srv.GetMaxCode()) + 1000000001).ToString();
            string readerCode = maxCode.Substring(1, 9);
            this.txtRcode.Text = readerCode;

            // 设置标题文字
            lblTitle.Text = string.Format("会员：{0} -【{1}】", "xxx", "xx");
        }       


        #endregion

        private void InitCbbBandingData()
        {
            // 初始化 cbbSex 下拉数据
            List<string> lstSex = new List<string>();
            lstSex.Add("");
            lstSex.Add("男");
            lstSex.Add("女");       
            ControlHelper.CbbBindData(cbbSex, lstSex);

            // 初始化 cbbMembType 下拉数据            
            List<MbTypeModel> lstMbType = new MbTypeService().QueryList("");
            Dictionary<int, string> kvDictonary = new Dictionary<int, string>();
            kvDictonary.Add(-1, "");
            foreach (MbTypeModel item in lstMbType)
            {
                kvDictonary.Add(item.Id, item.Name);
            }
            ControlHelper.CbbBindData(cbbMembType, kvDictonary);            
        }
       
        /// <summary>
        /// 保存
        /// </summary>
        private void Save()
        {
            this.Close();           
        }

        private void btnGrp21_UCSaveBtnClicked(object sender, EventArgs e)
        {
            //if (!ControlHelper.TextBoxNoEmpty(this.txtName, "名称")) return;
            //if (!ControlHelper.TextBoxOnlyNumber(this.txtHuiFee, "会费")) return;
            //if (!ControlHelper.TextBoxOnlyNumber(this.txtMaxOutNums, "最大借出册数")) return;
            //if (!ControlHelper.TextBoxOnlyNumber(this.txtYaJin, "押金")) return;

            // 赋值            
            curObject.Rcode = this.txtRcode.Text;
            curObject.Rname = this.txtRname.Text;
            curObject.Sex = this.cbbSex.Text;
            curObject.BirthDay = this.dtpBirthDay.Value;

            curObject.Tel = this.txtTel.Text;
            curObject.Mobile = this.txtMobile.Text;

            curObject.MembTypeId = Convert.ToInt32(this.cbbMembType.SelectedValue);
            curObject.MembTypeName = this.cbbMembType.Text;

            curObject.PinYin = this.txtPinyin.Text;
            curObject.Address = this.txtAddress.Text;
            curObject.Remark = this.txtRemark.Text;

            curObject.RegDate = this.dtpRegDate.Value;
            curObject.ValidityDate = this.dtpValidityDate.Value;

            // stop = 1; 停用
            curObject.Stop = (this.cbxStop.Checked) ? 1 : 0;


            this.DialogResult = DialogResult.OK;   // 直接设置窗口的DialogResult = DialogResult.OK
        }


    }
}
