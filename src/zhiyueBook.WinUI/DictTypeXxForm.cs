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
    public partial class DictTypeXxForm : Form
    {        
        public DictTypeModel curObject = new DictTypeModel();
        private string status = "新增";  // 初始状态=新增

        public DictTypeXxForm(DictTypeModel postObject)
        {
            InitializeComponent();

            // 通过postObject判断是新增，还是修改
            if (postObject != null)
            {
                status = "修改";
                this.Text = string.Format("字典类型-{0}", status);                
                this.BindData(postObject);
            }            

            // 设置 DialogResult 的值
            // 此处不能设置按钮的DialogResult = DialogResult.OK，否则无论判断真假，都会关闭窗口
            //this.btnSave.DialogResult = DialogResult.OK; 
            //this.btnExit.DialogResult = DialogResult.Cancel;            
        }       

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (!ControlHelper.TextBoxNoEmpty(this.txtName, "名称")) return;
            
            curObject.Name = this.txtName.Text;

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
        private void BindData(DictTypeModel obj) 
        {
            curObject = obj;
            this.txtName.Text = obj.Name;
        }
    }
}
