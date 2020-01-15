using RiziFrame.Utility.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using zhiyueBook.Model;

namespace zhiyueBook.WinUI
{
    public partial class MbTypeXxForm : Form
    {
        public MbTypeModel curObject = new MbTypeModel();
        private string status = "新增";  // 初始状态=新增

        public MbTypeXxForm(MbTypeModel postObject)
        {
            InitializeComponent();

            // 通过postObject判断是新增，还是修改
            if (postObject != null)
            {
                status = "修改";                             
                this.BindData(postObject);
            }

            this.Text = string.Format("会员类型-{0}", status);   

            // 设置 DialogResult 的值
            // 此处不能设置按钮的DialogResult = DialogResult.OK，否则无论判断真假，都会关闭窗口
            //this.btnSave.DialogResult = DialogResult.OK; 
            //this.btnExit.DialogResult = DialogResult.Cancel;            
        }       

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (!ControlHelper.TextBoxNoEmpty(this.txtName, "名称")) return;
            if (!ControlHelper.TextBoxOnlyNumber(this.txtHuiFee, "会费")) return;
            if (!ControlHelper.TextBoxOnlyNumber(this.txtMaxOutNums, "最大借出册数")) return;
            if (!ControlHelper.TextBoxOnlyNumber(this.txtYaJin, "押金")) return;
            
            curObject.Name = this.txtName.Text;
            curObject.MaxOutNums = Convert.ToInt32(this.txtMaxOutNums.Text);
            curObject.HuiFee = Convert.ToDouble(this.txtHuiFee.Text);
            curObject.YaJin = Convert.ToDouble(this.txtYaJin.Text);
            curObject.Remark = this.txtRemark.Text;

            this.DialogResult = DialogResult.OK;   // 直接设置窗口的DialogResult = DialogResult.OK
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DictTypeXxForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="obj"></param>
        private void BindData(MbTypeModel obj) 
        {
            curObject = obj;
            this.txtName.Text = obj.Name;
            this.txtMaxOutNums.Text = obj.MaxOutNums.ToString();
            this.txtHuiFee.Text = obj.HuiFee.ToString();
            this.txtYaJin.Text = obj.YaJin.ToString();
            this.txtRemark.Text = obj.Remark;
        }
    }
}
