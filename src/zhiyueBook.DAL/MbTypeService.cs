using RiziFrame.Utility.Db;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using zhiyueBook.Model;

namespace zhiyueBook.DAL
{
    public class MbTypeService : ICommonCURD<MbTypeModel>
    {
        private string type = new MbTypeModel().Type;

        public MbTypeModel GetSingleObj(int pkid)
        {
            throw new NotImplementedException();
        }

        public MbTypeModel GetSingleObj(string pkid)
        {
            throw new NotImplementedException();
        }

        public List<MbTypeModel> QueryList(string keyword)
        {
            /*
              * 数据字典单独设计会员类型： ;  
              * id：主键
              * name：会员类型名称
              * Type = 'MemberType'
              * MaxOutNums 最大借出册数 -- BookNum
              * HuiFee 会费; BookRent  -- BookRent
              * YaJin 押金; BookExceedFund  -- BookExceedFund
              * Remark 备注 = code 编号;
              * 
              */

            // 【1】定义SQL语句
            string sql = "select id, Name, BookNum, BookRent, BookExceedFund ,code";
            sql += string.Format(" from T_DataDict");
            sql += string.Format(" where type = '{0}'", type);
            sql += string.Format(" order by id");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<MbTypeModel> list = new List<MbTypeModel>();
            if (dr == null) return list;

            while (dr.Read())
            {
                MbTypeModel obj = new MbTypeModel();
                obj.Id = Convert.ToInt32(dr["id"]);
                obj.Name = dr["name"].ToString();
                obj.MaxOutNums = Convert.ToInt32(dr["BookNum"]);
                obj.HuiFee = Convert.ToDouble(dr["BookRent"]);
                obj.YaJin = Convert.ToDouble(dr["BookExceedFund"]);
                obj.Remark = dr["code"].ToString();

                list.Add(obj);
            }

            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list;
        }

        public int Add(MbTypeModel obj)
        {
            // 【1】定义SQL语句
            //  字段type的数据写死 = DictType - 字典类型
            string sql = "Insert Into T_DataDict (type, Name, BookNum, BookRent, BookExceedFund ,code)";
            sql += string.Format(" values('{0}','{1}', {2}, {3}, {4}, '{5}')",
                type,
                obj.Name,
                obj.MaxOutNums,
                obj.HuiFee,
                obj.YaJin,
                obj.Remark
                );
            // 执行SQL语句
            return OleDbHelper.ExecuteCmd(sql);
        }

        public int Upd(MbTypeModel obj)
        {
            string sql = "update T_DataDict";
            sql += string.Format(" set name='{0}',BookNum={1}, BookRent={2}, BookExceedFund={3} ,code='{4}' ", 
                obj.Name, obj.MaxOutNums, obj.HuiFee, obj.YaJin, obj.Remark);
            sql += string.Format(" where id = {0}", obj.Id);
            // 执行SQL语句
            return OleDbHelper.ExecuteCmd(sql);
        }

        public int Del(MbTypeModel obj)
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

        public string GetName (string id)
        {
            string val = string.Empty;
            string sql = "select name from T_DataDict";
            sql += string.Format(" where id={0}", id);

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 执行SQL语句            
            if (dr.Read())
            {
                val = dr["name"].ToString();
            }
            return val;
        }
    }
}
