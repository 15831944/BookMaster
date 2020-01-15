using RiziFrame.Utility.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using zhiyueBook.Model;

namespace zhiyueBook.DAL
{
    /// <summary>
    /// 数据字典类型 - 服务类
    /// </summary>
    public class DictTypeService : ICommonCURD<DictTypeModel>
    {
        private string SqlQuery = string.Empty;

        public DictTypeService()
        {
            // 查询SQL
            SqlQuery = "select id, parentId,  Name";
            SqlQuery += string.Format(" from T_DataDict");
            SqlQuery += string.Format(" where parentId = 0");
            SqlQuery += string.Format(" order by id");
        }

        public DictTypeModel GetSingleObj(int pkid)
        {
            throw new NotImplementedException();
        }

        public DictTypeModel GetSingleObj(string pkid)
        {
            throw new NotImplementedException();
        }

        public DataTable QueryDataTable()
        {
            DataTable dt = OleDbHelper.GetDataTable(SqlQuery, "DictType");
            return dt;
        }

        public List<DictTypeModel> QueryList(string keyword)
        {
            // 【1】定义SQL语句
            //string sql = "select id, parentId,  Name";
            //sql += string.Format(" from T_DataDict");
            //sql += string.Format(" where parentId = 0");
            //sql += string.Format(" order by id");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(SqlQuery);

            // 【4】封装对象
            List<DictTypeModel> list = new List<DictTypeModel>();
            if (dr == null) return list;

            while (dr.Read())
            {
                DictTypeModel obj = new DictTypeModel();
                obj.Id = Convert.ToInt32(dr["id"]);
                obj.Name = dr["name"].ToString();

                list.Add(obj);
            }

            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list;
        }

        public List<DictTypeModel> QueryDictType()
        {

            throw new NotImplementedException();
        }

        public int Add(DictTypeModel obj)
        {
            // 【1】定义SQL语句
            //  字段type的数据写死 = DictType - 字典类型
            string sql = "Insert Into T_DataDict (Name, ParentId)";
            sql += string.Format(" values('{0}',0)",
                obj.Name
                );
            // 执行SQL语句
            return OleDbHelper.ExecuteCmd(sql);
        }

        public int Upd(DictTypeModel obj)
        {
            string sql = "update T_DataDict";
            sql += string.Format(" set name='{0}'", obj.Name);
            sql += string.Format(" where id = {0}", obj.Id);
            // 执行SQL语句
            return OleDbHelper.ExecuteCmd(sql);
        }

        public int Del(DictTypeModel obj)
        {
            return Del(obj.Id.ToString());
        }


        public int Del(string id)
        {
            string sql = "delete from T_DataDict";
            sql += string.Format(" where id={0}", id);
            // 执行SQL语句
            return OleDbHelper.ExecuteCmd(sql);
        }
    }
}
