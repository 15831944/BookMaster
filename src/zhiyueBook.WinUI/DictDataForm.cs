using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using zhiyueBook.DAL;
using zhiyueBook.Model;

namespace zhiyueBook.WinUI
{
    public partial class DictDataForm : Form
    {
        //private string opFlag = "new";  // 操作标志

        // 创建数据访问服务        
        // 字典类型服务
        private ICommonCURD<DictTypeModel> srvDictType = new DictTypeService();
        // 字典服务
        private ICommonCURD<DictModel> srvDict = new DictService();
        
        public DictDataForm()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            //JcJcsjXxFormcs frm = new JcJcsjXxFormcs();
            //frm.ShowDialog();

            //if (frm.DialogResult == DialogResult.OK)
            //{
            //    // 新增
            //    listObj = frm.curObject;


            //    //label1.Text = "Phone number is " + frm.PhoneNumber;
            //}
            //else if (frm.DialogResult == DialogResult.Cancel)
            //{

            //    //label1.Text = "form wascanceled";

            //}

            //frm.Close();
        }

        private void JcJcsjForm_Load(object sender, EventArgs e)
        {
            InitTreeViewDictData(tvMain);
        }


        #region 初始化TreeView数据
        private void InitTreeViewDictData(TreeView tv)
        {
            // 构造tree: 数据字典类型
            TreeNode tvnode_root_dictType = new TreeNode();
            tvnode_root_dictType.Text = "字典类型";
            tvnode_root_dictType.Tag = "DictType";
            tvnode_root_dictType.ImageIndex = 0;
            tvnode_root_dictType.SelectedImageIndex = 0;
            tv.Nodes.Add(tvnode_root_dictType);

            //// 构造tree: 会员卡设置
            //TreeNode tvnode_root_card = new TreeNode();
            //tvnode_root_card.Text = "会员卡设置";
            //tvnode_root_card.Tag = "MemCard";
            //tvnode_root_card.ImageIndex = 0;
            //tvnode_root_card.SelectedImageIndex = 0;
            //tv.Nodes.Add(tvnode_root_card);

            //// 构造tree
            //TreeNode tvnode_root = new TreeNode();
            //tvnode_root.Text = " 数据字典 ";
            //tvnode_root.Tag = "DataDict";
            //tvnode_root.ImageIndex = 0;
            //tvnode_root.SelectedImageIndex = 0;
            //tv.Nodes.Add(tvnode_root);

            //// 构造子1级: 数据字典
            //DataDictTypeService ser = new DataDictTypeService();
            //foreach (DataDictType obj in ser.GetList())
            //{
            //    TreeNode tvnode = new TreeNode();
            //    tvnode.Text = obj.TypeName;
            //    // tvnode.Tag = obj.id;
            //    tvnode.Tag = obj.Type;

            //    tvnode.ImageIndex = 1;
            //    tvnode.SelectedImageIndex = 2;
            //    tvnode_root.Nodes.Add(tvnode);
            //}

            //tvnode_root.ExpandAll();
        }
        #endregion

        private void btnGrpsCurd_UCAddBtnClicked(object sender, EventArgs e)
        {
            this.Add();
        }

        /// <summary>
        /// 新增
        /// </summary>
        private void Add()
        {
            DictTypeModel newObj = new DictTypeModel ();

            DictTypeXxForm frm = new DictTypeXxForm();

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                // 新增
                newObj = frm.curObject;

                //MessageBox.Show(newObj.code);

                srvDictType.Add(newObj);
                
            }
            frm.Close();
        }


    }
}
