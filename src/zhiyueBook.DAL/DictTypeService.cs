using RiziFrame.Utility.Db;
using System;
using System.Collections.Generic;
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


        public DictTypeModel GetSingleObj(int pkid)
        {
            throw new NotImplementedException();
        }

        public DictTypeModel GetSingleObj(string pkid)
        {
            throw new NotImplementedException();
        }

        public List<DictTypeModel> Query(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<DictTypeModel> QueryDictType()
        {
            // 【1】定义SQL语句
            string sql = "select id, parentId,  Name";
            sql += string.Format(" from T_DataDict");
            sql += string.Format(" where parentId = 0");
            sql += string.Format(" order by id");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<DictTypeModel> list = new List<DictTypeModel>();
            if (dr == null) return list;

            while (dr.Read())
            {
                DictTypeModel obj = new DictTypeModel();
                obj.id = Convert.ToInt32(dr["id"]);
                obj.name = dr["name"].ToString();                
               
                list.Add(obj);
            }
            
            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list;
        }

        public int Add(DictTypeModel obj)
        {
            // 【1】定义SQL语句
            //  字段type的数据写死 = DictType - 字典类型
            string sql = "Insert Into T_DataDict (Name, ParentId)";
            sql += string.Format(" values('{0}',0)",
                obj.code
                );
            // 执行SQL语句
            return OleDbHelper.ExecuteCmd(sql);
        }

        public int Upd(DictTypeModel obj)
        {
            throw new NotImplementedException();
        }

        public int Del(DictTypeModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
