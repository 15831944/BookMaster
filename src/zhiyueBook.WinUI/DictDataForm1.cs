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
    public partial class DictDataForm1 : Form
    {

        /**
         * 1. 添加“字典类型”成功后:
         *    dgv自动添加数据，同时tv也自动添加数据。但是，dgv选择的数据行不变。
         * 2. 更新“字典类型”成功后：
         *    dgv和tv数据自动更新，dgv选择的数据行不变。
         * 3. 删除“字典类型”成功后：    
         *    dgv和tv数据自动删除，选择的行自动上移一行。         
         */
        
        private string tabIndexTag = string.Empty;   // tabpage选择页

        // 创建数据访问服务        
        // 字典类型服务
        private DictTypeService srvDictType = new DictTypeService();
        private BindingCollection<DictTypeModel> mySourceDictType = new BindingCollection<DictTypeModel>();

        // 字典服务
        private ICommonCURD<DictModel> srvDict = new DictService();
        private BindingCollection<DictModel> mySourceDict = null;
        private List<DictModel> listDict = null;

        // 会员类型
        private ICommonCURD<MbTypeModel> srvMbType = new MbTypeService();        
        private BindingCollection<MbTypeModel> mySourceMbType = null;

        public List<MbTypeModel> ListMbType
        {
            get { return srvMbType.QueryList(""); }
        }

        // 保存查询结果，作为缓存，后面修改和删除的时候都要使用。
        public List<DictTypeModel> QueryListDictType
        {
            get { return srvDictType.QueryList(""); }
        }

        private TreeNode tvNodeSelected = null;

        public DictDataForm1()
        {
            InitializeComponent();

            // 初始化
            this.DgvInit(this.dgvMain);
            this.DgvInit(this.dgvMainChangGui);
            this.DgvInit(this.dgvMainMbType);

        }

        private void DgvInit(DataGridView dgv)
        {
            this.tabIndexTag = this.tpHylx.Tag.ToString();

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
            // 绑定数据
            mySourceDictType = new BindingCollection<DictTypeModel>(QueryListDictType);            
            dgvMain.DataSource = mySourceDictType;

            // 绑定数据-会员类型            
            mySourceMbType = new BindingCollection<MbTypeModel>(ListMbType);
            dgvMainMbType.DataSource = mySourceMbType;
        }

        #region 新增
        private void btnGrpsCurd_UCAddBtnClicked(object sender, EventArgs e)
        {
            //if (tvNodeSelected.Level == 0) this.AddDictType();
            if ("hylx".Equals(tabIndexTag)) this.AddMbType();
            
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
                }
            }
            frm.Close();
        }

        /// <summary>
        /// 会员类型新增
        /// </summary>
        private void AddMbType() 
        {
            MbTypeXxForm frm = new MbTypeXxForm(null);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                // 新增
                MbTypeModel newObj = new MbTypeModel();
                newObj = frm.curObject;  // 新对象=Dialog窗口.curObject对象

                int result = srvMbType.Add(newObj);
                if (result == 1)
                {
                    ListMbType.Add(newObj);
                    this.mySourceMbType.Add(newObj);      // 数据源新增               
                }
            }
            frm.Close();

        }

        #endregion

        #region 删除
        private void btnGrpsCurd_UCDelBtnClicked(object sender, EventArgs e)
        {
            //this.Del();
            if ("hylx".Equals(tabIndexTag)) this.DelMbType();
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
                    }
                }
            }
        }

        private void DelMbType()
        {
            /**
            * 1. 获取当前行和对象，并转化为对象            
            * 2. 删除数据库中数据
            *   3.1 删除dgv数据
            *   3.2 需要找到treeview节点并删除
            */
            MbTypeModel currRowObj = null;
            int rowIndex = dgvMainMbType.CurrentRow.Index;  // 获取当前行
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvMainMbType.Rows[rowIndex];
                currRowObj = row.DataBoundItem as MbTypeModel;

                string msg = string.Format("确定删除数据：({0}) {1}", currRowObj.Id, currRowObj.Name);
                DialogResult result = MessageBox.Show(msg, "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    if (srvMbType.Del(currRowObj) == 1)  // 数据库删除成功，执行dgv删除行
                    {
                        this.dgvMainMbType.Rows.Remove(row);
                    }
                }
            }
        }
        #endregion

        #region 修改
        private void btnGrpsCurd_UCEdtBtnClicked(object sender, EventArgs e)
        {
            //this.Mod();
            if ("hylx".Equals(tabIndexTag)) this.ModMbType();
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
                        MessageBox.Show("修改成功！", "提示", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                frm.Close();
            }
        }

        private void ModMbType()
        {
            /**
             * 1. 获取当前行和对象，并转化为对象
             * 2. 传递对象到打开的编辑窗口中
             * 3. 如果编辑窗口时保存，则进行修改：
             *   3.1 修改数据库数据后，dgv自动更新数据
             *   3.2 需要找到treeview节点并更新name数据
             */

            MbTypeModel currRowObj = null;
            int rowIndex = dgvMainMbType.CurrentRow.Index;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvMainMbType.Rows[rowIndex];
                currRowObj = row.DataBoundItem as MbTypeModel;

                MbTypeXxForm frm = new MbTypeXxForm(currRowObj);

                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    // 修改
                    MbTypeModel modObj = new MbTypeModel();
                    modObj = frm.curObject;  // 新对象=Dialog窗口.curObject对象                    

                    int result = srvMbType.Upd(modObj);
                    if (result == 1)
                    {
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabIndexTag = this.tabControl1.SelectedTab.Tag.ToString();
        }

        private void dgvMainMbType_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.ModMbType();
        }
    }
}
