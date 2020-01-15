using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RiziFrame.Utility.Common;
using RiziFrame.Utility.Uc;
using RiziFrame.Utility.Db;
using zhiyueBook.DAL;
using zhiyueBook.Model;
using System.Reflection;
using System.Collections;
using zhiyueBook.WinUI.CustomDgv;

namespace zhiyueBook.WinUI
{
    public partial class DictDataForm : Form
    {

        /**
         * 1. 添加“字典类型”成功后:
         *    dgv自动添加数据，同时tv也自动添加数据。但是，dgv选择的数据行不变。
         * 2. 更新“字典类型”成功后：
         *    dgv和tv数据自动更新，dgv选择的数据行不变。
         * 3. 删除“字典类型”成功后：    
         *    dgv和tv数据自动删除，选择的行自动上移一行。         
         */
        
        TreeNode tvnode_root = null;   // tv根节点

        // 创建数据访问服务        
        // 字典类型服务
        private DictTypeService srvDictType = new DictTypeService();
        private BindingCollection<DictTypeModel> mySourceDictType = new BindingCollection<DictTypeModel>();

        // 字典服务
        private ICommonCURD<DictModel> srvDict = new DictService();
        private BindingCollection<DictModel> mySourceDict = null;
        private List<DictModel> listDict = null;        

        // 保存查询结果，作为缓存，后面修改和删除的时候都要使用。
        public List<DictTypeModel> QueryListDictType
        {
            get { return srvDictType.QueryList(""); }
        }

        private TreeNode tvNodeSelected = null;

        public DictDataForm()
        {
            InitializeComponent();

            // 初始化
            this.DgvInit(this.dgvMain);
            this.DgvInit(this.dgvMainChangGui);

        }

        private void DgvInit(DataGridView dgv)
        { 
            // 初始化
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false; // 不允许用户向dgv添加行
            dgv.AllowUserToDeleteRows = false; // 不允许用户向dgv删除行
            dgv.AllowUserToOrderColumns = true; // 不允许用户向dgv添加行.

            // 冻结字段, 和奇偶行样式冲突
            DataGridViewHelp.ColumnReadOnly(dgv);
            DataGridViewHelp.SetStyleGrid(dgv);           
        }

        private void JcJcsjForm_Load(object sender, EventArgs e)
        {
            // treeview
            ControlHelper.TreeViewInit(this.tvMain);

            // 绑定数据
            mySourceDictType = new BindingCollection<DictTypeModel>(QueryListDictType);
            this.TvBindData(tvMain);

            dgvMain.DataSource = mySourceDictType;
        }
        
        #region 初始化TreeView数据

        private void TvChildNodeAdd(TreeNode tnParent)
        {
            foreach (DictTypeModel item in QueryListDictType)
            {
                TreeNode tvnode = TvChildNodeAdd(item);
                tnParent.Nodes.Add(tvnode);
            }
        }

        private TreeNode TvChildNodeAdd(DictTypeModel obj)
        {
            TreeNode tvnode = new TreeNode();
            tvnode.Text = obj.Name;
            tvnode.Tag = obj.Id.ToString();

            tvnode.ImageIndex = 1;
            tvnode.SelectedImageIndex = 1;

            return tvnode;
        }

        private void TvNodeAdd(TreeNode tnParent, DictTypeModel obj)
        {
            tnParent.Nodes.Add(TvChildNodeAdd(obj));
        }

        /// <summary>
        /// treeview绑定数据
        /// </summary>
        /// <param name="tv"></param>
        private void TvBindData(TreeView tv)
        {
            this.tvMain.ImageList = this.imageList1;

            //this.tvMain.HideSelection = false; //失去焦点后不隐藏选中节点
            //this.tvMain.DrawMode = TreeViewDrawMode.OwnerDrawText;

            // 构造tree 根节点
            tvnode_root = new TreeNode();
            tvnode_root.Text = " 数据字典 ";
            tvnode_root.Tag = "DataDict";
            tvnode_root.ImageIndex = 0;
            tvnode_root.SelectedImageIndex = 0;


            tv.Nodes.Add(tvnode_root);
          
            this.TvChildNodeAdd(tvnode_root);
            tvnode_root.ExpandAll();
        }

        /// <summary>
        /// 通过tag=id遍历查询节点
        /// </summary>
        /// <param name="tnParent"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private TreeNode TvFindNode(TreeNode tnParent, string id)
        {
            if (tnParent == null) return null;
            //if (tnParent.Text == strValue) return tnParent;
            if (tnParent.Tag.Equals(id)) return tnParent;
            TreeNode tnRet = null;
            foreach (TreeNode tn in tnParent.Nodes)
            {
                tnRet = TvFindNode(tn, id);
                if (tnRet != null) break;
            }
            return tnRet;
        }

        #endregion

        #region 新增
        private void btnGrpsCurd_UCAddBtnClicked(object sender, EventArgs e)
        {
            if (tvNodeSelected.Level == 0) this.AddDictType();
            if (tvNodeSelected.Level == 1) this.AddDict();
            
        }

        
        /// <summary>
        /// 数据字典类型新增
        /// </summary>
        private void AddDictType()
        {
            DictTypeXxForm frm = new DictTypeXxForm(null);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                // 新增
                DictTypeModel newObj = new DictTypeModel();
                newObj = frm.curObject;  // 新对象=Dialog窗口.curObject对象
                
                int result = srvDictType.Add(newObj);
                if (result == 1) 
                {
                    QueryListDictType.Add(newObj);
                    this.mySourceDictType.Add(newObj);      // 数据源新增
                    this.TvNodeAdd(tvnode_root, newObj);    // tv新增节点                    
                }
            }
            frm.Close();
        }

        /// <summary>
        /// 数据字典新增
        /// </summary>
        private void AddDict() 
        {
            DictDataXxForm frm = new DictDataXxForm(null);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                // 新增
                DictTypeModel newObj = new DictTypeModel();
                newObj = frm.curObject;  // 新对象=Dialog窗口.curObject对象

                int result = srvDictType.Add(newObj);
                if (result == 1)
                {
                    QueryListDictType.Add(newObj);
                    this.mySourceDictType.Add(newObj);      // 数据源新增
                    this.TvNodeAdd(tvnode_root, newObj);    // tv新增节点                    
                }
            }
            frm.Close();

        }

        #endregion

        #region 删除
        private void btnGrpsCurd_UCDelBtnClicked(object sender, EventArgs e)
        {
            this.Del();
        }
                
        private void Del()
        {
            /**
            * 1. 获取当前行和对象，并转化为对象            
            * 2. 删除数据库中数据
            *   3.1 删除dgv数据
            *   3.2 需要找到treeview节点并删除
            */
            DictTypeModel currRowObj = null;
            int rowIndex = dgvMain.CurrentRow.Index;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvMain.Rows[rowIndex];
                currRowObj = row.DataBoundItem as DictTypeModel;

                string msg = string.Format("确定删除数据：({0}) {1}", currRowObj.Id, currRowObj.Name);
                DialogResult result = MessageBox.Show(msg, "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    if (srvDictType.Del(currRowObj) == 1)  // 数据库删除成功，执行dgv删除行
                    {
                        this.dgvMain.Rows.Remove(row);
                        // 修改treenode节点
                        TreeNode tvnode = this.TvFindNode(tvnode_root, currRowObj.Id.ToString());
                        tvnode.Remove();  // 删除节点
                    }
                }
            }
        }
        #endregion

        #region 修改
        private void btnGrpsCurd_UCEdtBtnClicked(object sender, EventArgs e)
        {
            this.Mod();
        }

        private void dgvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Mod();
        }

        private void Mod() 
        {
            /**
             * 1. 获取当前行和对象，并转化为对象
             * 2. 传递对象到打开的编辑窗口中
             * 3. 如果编辑窗口时保存，则进行修改：
             *   3.1 修改数据库数据后，dgv自动更新数据
             *   3.2 需要找到treeview节点并更新name数据
             */
            
            DictTypeModel currRowObj = null;
            int rowIndex = dgvMain.CurrentRow.Index;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvMain.Rows[rowIndex];
                currRowObj = row.DataBoundItem as DictTypeModel;

                DictTypeXxForm frm = new DictTypeXxForm(currRowObj);

                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    // 修改
                    DictTypeModel modObj = new DictTypeModel();
                    modObj = frm.curObject;  // 新对象=Dialog窗口.curObject对象                    

                    int result = srvDictType.Upd(modObj);
                    if (result == 1)
                    {
                        // 修改treenode节点
                        TreeNode tvnode = this.TvFindNode(tvnode_root, modObj.Id.ToString());
                        tvnode.Text = modObj.Name;
                        MessageBox.Show("修改成功！", "提示", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                frm.Close();
            }
        }

        #endregion


        #region 选择字典
        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvNodeSelected = this.tvMain.SelectedNode;            
            //MessageBox.Show(tvNode.Level.ToString());

            tabControl1.SelectedIndex = tvNodeSelected.Level;
            if (tvNodeSelected.Level == 1)
            {
                tabControl1.SelectedIndex = 1;
                lblTitle.Text = string.Format("选择的基础数据：{0}", tvNodeSelected.Text);

                // 根据选择的tvNode筛选数据
                listDict = srvDict.QueryList(tvNodeSelected.Tag.ToString());
                mySourceDict = new BindingCollection<DictModel>(listDict);
                dgvMainChangGui.DataSource = mySourceDict;
            }             
        }

        #endregion

        private void btnGrpsCurd_UCExtBtnClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
