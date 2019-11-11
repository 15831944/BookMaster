using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zhiyueBook.Model;
using RiziFrame.Utility.Db;
using System.Data.OleDb;

namespace zhiyueBook.DAL
{
    public class TjjyService
    {

        /// <summary>
        /// 统计借阅信息： 统计
        /// </summary>
        /// <returns></returns>
        public List<Tjjy> Query(int stop, string rq_start, string rq_end, string keyword)
        {
            // 【1】定义SQL语句
            string sql = "select n.readercode,  n.name, n.tel, n.mobile, n.ValidityDate, n.stop, ";
            sql += string.Format(" m.LastBorrowDate1, m.LastReturnDate1, m.sumBrBooks, m.sumBookPrice1, m.sumRtBooks, m.NotRtBooks, m.daysAgo1");
            sql += string.Format(" from (");
            sql += string.Format(" select max(RCode) as Rcode1,");
            sql += string.Format(" max(LastBorrowDate) as LastBorrowDate1,");
            sql += string.Format(" max(LastFactReturnDate) as LastReturnDate1,");
            sql += string.Format(" sum(PreBorrowBookNums) as sumBrBooks, ");
            sql += string.Format(" sum(sumBookPrice) as sumBookPrice1, ");            
            sql += string.Format(" sum(PreReturnBookNums) as sumRtBooks,");
            sql += string.Format(" sum(PreBorrowBookNums)  -  sum(PreReturnBookNums) as NotRtBooks,");
            sql += string.Format(" min(daysAgo) as daysAgo1");
            sql += string.Format(" from (");
            sql += string.Format(" select RCode,");
            sql += string.Format(" MAX(BorrowDate) AS LastBorrowDate, ");
            sql += string.Format(" MAX(FactReturnDate) AS LastFactReturnDate, ");
            sql += string.Format(" count(BorrowDate) as PreBorrowBookNums,");
            sql += string.Format(" count(FactReturnDate) as PreReturnBookNums,");
            sql += string.Format(" sum(BookPrice) as sumBookPrice,");            
            sql += string.Format(" DateDiff('d', BorrowDate, Now()) as daysAgo  ");
            sql += string.Format(" from S_BookBorrow");
            sql += string.Format(" where BorrowDate between #{0}# and #{1}#", rq_start, rq_end);
            if(!"".Equals(keyword))
            {
                sql += string.Format(" and (ReaderName like '%{0}%' or ReaderNameCode like '%{0}%')", keyword);
            }
            //sql += string.Format(" where BorrowDate between '#2019-01-01#' and '#2019-09-01#'");
            sql += string.Format(" group by RCode, BorrowDate,FactReturnDate");
            sql += string.Format(" )");
            sql += string.Format(" group by Rcode");
            sql += string.Format(" ) m, t_reader n");
            sql += string.Format(" where m.rcode1 = n.readercode");

            // 【2】拼接字符串
            if (stop == 0)
            {
                sql += string.Format(" and stop = {0}", stop);
            }
            //if (!("".Equals(courseName)))
            //{
            //    sql += string.Format(" and Coursename like '%{0}%'", courseName);
            //}
            sql += string.Format(" order by m.daysAgo1");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<Tjjy> list = new List<Tjjy>();
            if (dr == null) return list;

            while (dr.Read())
            {
                Tjjy tjjy = new Tjjy();
                tjjy.Rcode = dr["readercode"].ToString();
                tjjy.Rname = dr["name"].ToString();
                tjjy.Tel = dr["tel"].ToString();
                tjjy.Mobile = dr["mobile"].ToString();

                tjjy.LastBorrowDate = Convert.ToDateTime(dr["LastBorrowDate1"]);

                // 判断 是否为： DBNull
                if ((dr["LastReturnDate1"] != DBNull.Value))
                {
                    tjjy.LastReturnDate = Convert.ToDateTime(dr["LastReturnDate1"]);
                }

                if ((dr["ValidityDate"] != DBNull.Value))
                {
                    tjjy.ValidityDate = Convert.ToDateTime(dr["ValidityDate"]);
                }

                tjjy.DaysAgo = Convert.ToInt32(dr["daysAgo1"]);
                tjjy.SumBrBooks = Convert.ToInt32(dr["sumBrBooks"]);
                tjjy.SumRtBooks = Convert.ToInt32(dr["sumRtBooks"]);
                tjjy.NotRtBooks = Convert.ToInt32(dr["NotRtBooks"]);

                tjjy.SumBookPrice = Math.Round(Convert.ToDouble(dr["sumBookPrice1"]),2);

                tjjy.Stop = Convert.ToInt32(dr["stop"]);
                
                list.Add(tjjy);
               
            }
            //}

            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list;            
        }

        public List<Tjjy> Query(string rq_start, string rq_end, string keyword)
        {
            return Query(0, rq_start, rq_end, keyword);
        }

        /// <summary>
        /// 借阅信息查询,查询“个人”借阅图书信息
        /// </summary>
        /// <param name="rcode"></param>
        /// <returns></returns>
        public List<Jyxx> JyxxQuery(string rcode)
        {

            // 【1】定义SQL语句
            string sql = "SELECT  state, rcode, readername,  bookcode, name, bookPrice,  BorrowDate, ReturnDate, FactReturnDate";
            sql += string.Format(" FROM S_BookBorrow");
            sql += string.Format(" Where 1=1");            

            // 【2】拼接字符串     
            if (!("".Equals(rcode)))
            {
                sql += string.Format(" and rcode = '{0}'", rcode);
            }
            sql += string.Format(" order by state desc, BorrowDate desc ");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<Jyxx> list = new List<Jyxx>();
            if (dr == null) return list;

            while (dr.Read())
            {
                Jyxx obj = new Jyxx();
                obj.State = dr["state"].ToString();
                obj.Rcode = dr["rcode"].ToString();
                obj.Rname = dr["readername"].ToString();
                obj.Bookcode = dr["bookcode"].ToString();
                obj.BookName = dr["name"].ToString();

                obj.BorrowDate = Convert.ToDateTime(dr["BorrowDate"]);
                obj.BookPrice = Math.Round(Convert.ToDouble(dr["BookPrice"]),2);


                // 判断 是否为： DBNull
                if ((dr["ReturnDate"] != DBNull.Value))
                {
                    obj.ReturnDate = Convert.ToDateTime(dr["ReturnDate"]);
                }

                if ((dr["FactReturnDate"] != DBNull.Value))
                {
                    obj.FactReturnDate = Convert.ToDateTime(dr["FactReturnDate"]);
                }
                list.Add(obj);

            }
            
            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list; 
        }

        /// <summary>
        /// 借阅数量年月分析
        /// </summary>
        /// <returns></returns>
        public List<Tjjyfx> JyxxNyfx(string rq_start, string rq_end)
        {

            // 【1】定义SQL语句            
            string sql = "select m.ny, m.jysl, n.jyrc";
            sql += string.Format(" from ( "); //  -- 每月借阅本数
            sql += string.Format(" select Format(BorrowDate, 'YYYY-mm') as ny, count(BorrowDate) as jysl");
            sql += string.Format(" from S_BookBorrow	");
            //sql += string.Format(" where BorrowDate between #2019-01-01# and #019-09-16#");
            sql += string.Format(" where BorrowDate between #{0}# and #{1}#", rq_start, rq_end);
            sql += string.Format(" group by Format(BorrowDate, 'YYYY-mm') ");
            sql += string.Format(" ) m,  ( ");  //  -- 每月借阅人次 
            sql += string.Format(" select count(rcode)  as jyrc, Format(ny, 'YYYY-mm') as ny");
            sql += string.Format(" from ( ");
            sql += string.Format(" select Format(BorrowDate, 'YYYY-mm-dd') as ny, rcode, count(BorrowDate) as jysl ");
            sql += string.Format(" from S_BookBorrow");
            //sql += string.Format(" where BorrowDate between #2019-01-01# and #019-09-16# ");
            sql += string.Format(" where BorrowDate between #{0}# and #{1}#", rq_start, rq_end);
            sql += string.Format(" group by Format(BorrowDate, 'YYYY-mm-dd'), rcode  ");
            sql += string.Format(" ) group by Format(ny, 'YYYY-mm')  ");
            sql += string.Format(" )	n ");
            sql += string.Format(" where m.ny = n.ny ");

            // 【2】拼接字符串     
            //if (!("".Equals(rcode)))
            //{
            //    sql += string.Format(" and rcode = '{0}'", rcode);
            //}
            //sql += string.Format(" order by state desc, BorrowDate desc ");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<Tjjyfx> list = new List<Tjjyfx>();
            if (dr == null) return list;

            while (dr.Read())
            {
                Tjjyfx obj = new Tjjyfx();
                obj.Ny = dr["ny"].ToString();
                obj.Jysl = Convert.ToInt32(dr["jysl"]);
                obj.Jyrc = Convert.ToInt32(dr["jyrc"]);

                list.Add(obj);
            }

            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list;
        }

        /// <summary>
        /// 统计图书
        /// </summary>
        /// <returns></returns>
        public List<Tjts> TjtsQuery(bool showAll, string keyword)
        {

            // 【1】定义SQL语句            
            //string sql = "SELECT BookCode, Name, NameCode, BookPlace, BookPrice, RegDate, Barcode,  Number, RestNumber";
            //sql += string.Format("  FROM T_Book ");

            string sql = "SELECT   m.BookCode, m.Name, m.NameCode, m.BookPlace, m.BookPrice, m.BarCode, m.RegDate, m.Number, m.RestNumber, ";
            sql += string.Format("  n.BorrowDate, n.ReaderName, n.factReturnDate, n.rtReaderName, n.jccs");
            sql += string.Format("  FROM      ((SELECT   BookCode, Name, NameCode, BookPlace, BookPrice, BarCode, RegDate, Number, RestNumber");
            sql += string.Format("  FROM      T_Book");            
            if (!showAll)
            {
                sql += string.Format("  where (Barcode is not null)");
            }
            sql += string.Format(" ) m LEFT OUTER JOIN");

            sql += string.Format("  (	select i.Code, i.Name, i.BorrowDate, i.RCode, i.ReaderName, i.jccs, j.factReturnDate, j.rtRcode, j.rtReaderName");
            sql += string.Format("  from ( SELECT   a.Code, a.Name, a.BorrowDate, a.RCode, a.ReaderName, b.jccs");
            sql += string.Format("  FROM      (S_BookBorrow a INNER JOIN");
            // 最后借书人 
            sql += string.Format("   (SELECT   Code, COUNT(Code) AS jccs, MAX(BorrowDate) AS lastBorrowDate, max(factReturnDate) AS lastReturnDate");
            sql += string.Format("   FROM      S_BookBorrow ");


            sql += string.Format("   GROUP BY Code) b ON a.Code = b.Code AND a.BorrowDate = b.lastBorrowDate)");
            sql += string.Format("   ) i left join (");
            // 最后还书人 
            sql += string.Format("   SELECT   a.Code, a.Name, a.factReturnDate, a.RCode as rtRcode, a.ReaderName as rtReaderName ");
            sql += string.Format("   FROM      (S_BookBorrow a INNER JOIN ");


            sql += string.Format("   (SELECT   Code, MAX(BorrowDate) AS lastBorrowDate, max(factReturnDate) AS lastReturnDate ");
            sql += string.Format("   FROM      S_BookBorrow ");
            sql += string.Format("   GROUP BY Code) b ON a.Code = b.Code AND a.factReturnDate = b.lastReturnDate) ");
            sql += string.Format("   ) j	on i.code = j.code     ) n ON  ");
            sql += string.Format("   m.BookCode = n.Code)");
            sql += string.Format(" order by m.RegDate desc");

            // 【2】拼接字符串     
            //if (!("".Equals(rcode)))
            //{
            //    sql += string.Format(" and rcode = '{0}'", rcode);
            //}
            //sql += string.Format(" order by state desc, BorrowDate desc ");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<Tjts> list = new List<Tjts>();
            if (dr == null) return list;

            while (dr.Read())
            {
                Tjts obj = new Tjts();
                obj.BookCode = dr["BookCode"].ToString();
                obj.Name = dr["Name"].ToString();
                obj.NameCode = dr["NameCode"].ToString();
                obj.BookPlace = dr["BookPlace"].ToString();

                obj.Barcode = dr["Barcode"].ToString();
                obj.BookPlace = dr["BookPlace"].ToString();               


                // 判断 是否为： DBNull
                if ((dr["Number"] != DBNull.Value))
                {
                    obj.Number = Convert.ToInt32(dr["Number"]);
                }

                // 判断 是否为： DBNull
                if ((dr["RestNumber"] != DBNull.Value))
                {
                    obj.RestNumber = Convert.ToInt32(dr["RestNumber"]);
                }   

                // 判断 是否为： DBNull
                if ((dr["BookPrice"] != DBNull.Value))
                {
                    obj.BookPrice = Math.Round(Convert.ToDouble(dr["BookPrice"]), 2);
                }                             


                // 判断 是否为： DBNull
                if ((dr["RegDate"] != DBNull.Value))
                {
                    obj.RegDate = Convert.ToDateTime(dr["RegDate"]);
                }

                // 判断 是否为： DBNull
                if ((dr["BorrowDate"] != DBNull.Value))
                {
                    obj.LastBorrowDate = Convert.ToDateTime(dr["BorrowDate"]);
                }

                // 判断 是否为： DBNull
                if ((dr["ReaderName"] != DBNull.Value))
                {
                    obj.LastReaderName = dr["ReaderName"].ToString();
                }
            
                // 判断 是否为： DBNull 最后还书日期
                if ((dr["factReturnDate"] != DBNull.Value))
                {
                    obj.LastReturnDate = Convert.ToDateTime(dr["factReturnDate"]);
                }

                // 判断 是否为： DBNull 最后还书人
                if ((dr["rtReaderName"] != DBNull.Value))
                {
                    obj.LastRtReaderName = dr["rtReaderName"].ToString();
                }

                // 判断 是否为： DBNull 借出次数
                if ((dr["jccs"] != DBNull.Value))
                {
                    obj.Jccs = Convert.ToInt32(dr["jccs"]);
                }

                list.Add(obj);
            }

            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list;
        }


        /// <summary>
        /// 统计图书：按图书-展示图书借阅信息
        /// </summary>
        /// <returns></returns>
        public List<Tjtsxx> TjtsxxQuery(string bookCode)
        {

            // 【1】定义SQL语句            
            //string sql = "SELECT BookCode, Name, NameCode, BookPlace, BookPrice, RegDate, Barcode,  Number, RestNumber";
            //sql += string.Format("  FROM T_Book ");

            string sql = "SELECT BookBorrowID, BookCode, Name, '' as  BarCode,  RCode, ReaderName, Tel, Mobile, ";
            sql += string.Format("  BorrowDate, ReturnDate,  FactReturnDate, ExceedDay");
            sql += string.Format("  FROM S_BookBorrow");
            sql += string.Format(" Where 1=1");

            // 【2】拼接字符串     
            if (!("".Equals(bookCode)))
            {
                sql += string.Format(" and BookCode = '{0}'", bookCode);
            }
            sql += string.Format(" order by BorrowDate desc ");

            // 【3】执行查询
            OleDbDataReader dr = OleDbHelper.ExecuteReader(sql);

            // 【4】封装对象
            List<Tjtsxx> list = new List<Tjtsxx>();
            if (dr == null) return list;

            while (dr.Read())
            {
                Tjtsxx obj = new Tjtsxx();                
                
                obj.BookCode = dr["bookCode"].ToString();
                obj.BookName = dr["name"].ToString();
                obj.Barcode = dr["barcode"].ToString();

                obj.RCode = dr["RCode"].ToString();
                obj.RName = dr["ReaderName"].ToString();
                obj.Tel = dr["Tel"].ToString();
                obj.Mobile = dr["Mobile"].ToString();

                obj.BorrowDate = Convert.ToDateTime(dr["BorrowDate"]);
                obj.ExceedDay = Convert.ToInt32(dr["ExceedDay"]);


                // 判断 是否为： DBNull
                if ((dr["ReturnDate"] != DBNull.Value))
                {
                    obj.ReturnDate = Convert.ToDateTime(dr["ReturnDate"]);
                }

                if ((dr["FactReturnDate"] != DBNull.Value))
                {
                    obj.FactReturnDate = Convert.ToDateTime(dr["FactReturnDate"]);
                }
                list.Add(obj);

            }

            //if (isClose) { dr.Close(); dr.Dispose(); dr = null; }
            dr.Close(); dr.Dispose(); dr = null;
            return list; 
        }
    }
}
