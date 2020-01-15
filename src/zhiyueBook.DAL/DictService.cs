using RiziFrame.Utility.Db;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using zhiyueBook.Model;

namespace zhiyueBook.DAL
{
    public class DictService : ICommonCURD<DictModel>
    {
        private string SqlQuery = string.Empty;

        public DictService()
        {
           
        }

        

        public DictModel GetSingleObj(int pkid)
        {
            throw new NotImplementedException();
        }

        public DictModel GetSingleObj(string pkid)
        {
            throw new NotImplementedException();
        }

        public List<DictModel> QueryList(string keyword)
        {
            // 【1】定义SQL语句
            string sql = "select id, parentId,  Name";
            sql += string.Format(" from T_DataDict");
            sql += string.Format(" where parentId = {0}", keyword);
            sql += string.Format(" order by id");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<DictModel> list = new List<DictModel>();
            if (dr == null) return list;

            while (dr.Read())
            {
                DictModel obj = new DictModel();
                obj.Id = Convert.ToInt32(dr["id"]);
                obj.Name = dr["name"].ToString();

                list.Add(obj);
            }

            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list;
        }

        public int Add(DictModel obj)
        {
            throw new NotImplementedException();
        }

        public int Upd(DictModel obj)
        {
            throw new NotImplementedException();
        }

        public int Del(DictModel obj)
        {
            throw new NotImplementedException();
        }


        public int Del(string id)
        {
            throw new NotImplementedException();
        }
    }
}
