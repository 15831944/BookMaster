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
    public partial class DictDataXxForm : Form
    {

        public DialogResult result;
        private string status = "新增";  // 初始状态=新增

        public DictDataXxForm(DictModel postObject)
        {
            InitializeComponent();

            // 通过postObject判断是新增，还是修改
            if (postObject != null)
            {
                status = "修改";
                this.Text = string.Format("字典类型-{0}", status);
                //this.BindData(postObject);
            }            
        }

        public DictTypeModel curObject = new DictTypeModel();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ControlHelper.TextBoxNoEmpty(this.txtCode, "编码")) return;
            if (!ControlHelper.TextBoxNoEmpty(this.txtName, "名称")) return;


            curObject.Code = this.txtCode.Text;
            curObject.Name = this.txtName.Text;
            this.DialogResult = DialogResult.OK;   // 直接设置窗口的DialogResult = DialogResult.OK
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
