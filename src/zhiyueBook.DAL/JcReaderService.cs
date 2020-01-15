using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using zhiyueBook.Model;
using RiziFrame.Utility.Db;
using System.Data.OleDb;

namespace zhiyueBook.DAL
{
    public class JcReaderService: IJcReaderService<JcReaderModel>
    {
        /// <summary>
        /// 根据关键字查询
        /// </summary>
        /// <returns></returns>
        public List<JcReaderModel> QueryList(string keyword)
        {
            // 【1】定义SQL语句
            string sql = "select a.id, ReaderCode,  a.Name, NameCode, Sex, a.memberType, b.name as TypeName, BirthDay, Tel, Mobile, stop, ";
            sql += string.Format(" RegDate,Field8, ValidityDate, AllTime, Address, Memo");
            sql += string.Format(" from T_Reader a LEFT OUTER JOIN T_DataDict b ON a.memberType = b.ID");
            sql += string.Format(" where 1=1");
            if (!"".Equals(keyword))
            {
                sql += string.Format(" and (Name like '%{0}%' or NameCode like '%{0}%' or ReaderCode like '%{0}%')", keyword);
            }
           
            //if (!("".Equals(courseName)))
            //{
            //    sql += string.Format(" and Coursename like '%{0}%'", courseName);
            //}
            sql += string.Format(" order by ReaderCode");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<JcReaderModel> list = new List<JcReaderModel>();
            if (dr == null) return list;

            while (dr.Read())
            {
                JcReaderModel obj = new JcReaderModel();
                obj.id = Convert.ToInt32(dr["id"]);
                obj.Rcode = dr["readercode"].ToString();
                obj.Rname = dr["name"].ToString();
                obj.Sex = dr["sex"].ToString();

                if ((dr["memberType"] != DBNull.Value))
                {
                    obj.MembTypeId = Convert.ToInt32(dr["memberType"]);
                }
                obj.MembTypeName = dr["TypeName"].ToString();

                obj.Tel = dr["tel"].ToString();
                obj.Mobile = dr["mobile"].ToString();

                obj.PinYin = dr["NameCode"].ToString();
                
                obj.Address = dr["Address"].ToString();
                obj.Remark = dr["Memo"].ToString();

                // 判断 是否为： DBNull
                if ((dr["BirthDay"] != DBNull.Value))
                {
                    obj.BirthDay = Convert.ToDateTime(dr["BirthDay"]);
                }

                // 登记日期 是否为： DBNull
                if ((dr["RegDate"] != DBNull.Value))
                {
                    obj.RegDate = Convert.ToDateTime(dr["RegDate"]);
                }


                // 开卡日期
                if ((dr["Field8"] != DBNull.Value))
                {
                    obj.KaikaDate = Convert.ToDateTime(dr["Field8"]);
                }

                // 有效期至
                if ((dr["ValidityDate"] != DBNull.Value))
                {
                    obj.ValidityDate = Convert.ToDateTime(dr["ValidityDate"]);
                }

                //tjjy.DaysAgo = Convert.ToInt32(dr["daysAgo1"]);
                //tjjy.SumBrBooks = Convert.ToInt32(dr["sumBrBooks"]);
                //tjjy.SumRtBooks = Convert.ToInt32(dr["sumRtBooks"]);
                //tjjy.NotRtBooks = Convert.ToInt32(dr["NotRtBooks"]);

                //tjjy.SumBookPrice = Math.Round(Convert.ToDouble(dr["sumBookPrice1"]), 2);

                obj.Stop = Convert.ToInt32(dr["stop"]);
                
                list.Add(obj);

            }
            //}

            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Add(JcReaderModel obj)
        {
            // 获取最大code + 1， Code确定为8位
            string maxCode = (Convert.ToInt32(this.GetMaxCode()) + 1000000001).ToString();
            string readerCode = maxCode.Substring(1,9);


            // 【1】定义SQL语句
            string sql = "Insert Into T_Reader  (ReaderCode,  Name, NameCode, Sex, memberType, BirthDay, Tel, Mobile, stop, ";
            sql += string.Format(" RegDate, ValidityDate, Address, Memo, type)");
            sql += string.Format(" values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}',{8},'{9}','{10}','{11}', '{12}','未知')",
                readerCode,
                obj.Rname,
                obj.PinYin,
                obj.Sex,
                obj.MembTypeId,
                obj.BirthDay,
                obj.Tel,
                obj.Mobile,
                obj.Stop,
                obj.RegDate,
                obj.ValidityDate,
                obj.Address,
                obj.Remark
                );
            // 执行SQL语句
            return OleDbHelper.ExecuteCmd(sql);
        }


        public int Upd(JcReaderModel obj)
        {
            string sql = "update T_Reader";
            sql += string.Format(" set ReaderCode='{0}'", obj.Rcode );
            sql += string.Format(" ,Name='{0}'", obj.Rname );
            sql += string.Format(" ,Sex='{0}'", obj.Sex );
            sql += string.Format(" ,BirthDay='{0}'", obj.BirthDay);                                  
            
            sql += string.Format(" ,Tel='{0}'", obj.Tel);
            sql += string.Format(" ,Mobile='{0}'", obj.Mobile);

            sql += string.Format(" ,MemberType='{0}'", obj.MembTypeId);
            sql += string.Format(" ,NameCode='{0}'", obj.PinYin);
            sql += string.Format(" ,Address='{0}'", obj.Address);
            sql += string.Format(" ,[Memo]='{0}'", obj.Remark);

            sql += string.Format(" ,ValidityDate='{0}'", obj.ValidityDate);
            
            //NameCode, Sex, Type, BirthDay, Tel, Mobile, stop, ";
            //sql += string.Format(" RegDate,Field8, ValidityDate, AllTime, Address, Memo");
            //sql += string.Format(" from T_Reader");
            sql += string.Format(" where id = {0}", obj.id);
            int val = OleDbHelper.ExecuteCmd(sql);

            return val;
        }

        public int Del(JcReaderModel obj)
        {
            string sql = "delete from T_Reader";
            sql += string.Format(" where id = {0}", obj.id);

            int val = OleDbHelper.ExecuteCmd(sql);

            return val;
        }

        public JcReaderModel GetSingleObj(string pkid)
        {
            throw new NotImplementedException();
        }

        public JcReaderModel GetSingleObj(int pkid)
        {
            throw new NotImplementedException();
        }


        public int Del(string id)
        {
            throw new NotImplementedException();
        }

        public string GetMaxCode()
        {
            string val = string.Empty;

           // 【1】定义SQL语句
            string sql = "select Max(ReaderCode) as ReaderCode from T_Reader";         

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<JcReaderModel> list = new List<JcReaderModel>();
            
            if (dr.Read())
            {
                val = dr["readercode"].ToString();
            }

            return val;

        }


        public int GetBrNumByCode(string pkCode)
        {
            // 【1】定义SQL语句
            string sql = "select count(*) as icount from T_BookBorrow";
            sql += string.Format(" where Rcode = '{0}'", pkCode);

            int val = 0;

            // 【3】执行查询, 返回第1行第1列
            val = (int)OleDbHelper.ExecuteScalar(sql);

            // 【4】封装对象            
            return val;
        }
    }
}
