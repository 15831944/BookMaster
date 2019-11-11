using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zhiyueBook.Model
{
    public class Tjts
    {
        public Tjts() { }

        /*
         BookCode: 图书编号
         Name: 图书名称
         NameCode : 拼音码
         Barcode : 条形码
         BookPlace: 位置
         BookPrice: 价格
         RegDate: 登记日期
         Number: 藏书总量
         RestNumber: 馆内剩余
         
         lastBorrowDate： 最后借阅日期
         ReaderName : 最后借阅人          
         LastReturnDate： 最后还书日期
         LastRtReaderName : 最后还书人  
         */

        public string BookCode { get; set; }
        public string Name { get; set; }
        public string NameCode { get; set; }
        public string BookPlace { get; set; }
        public string Barcode { get; set; }

        public Double BookPrice { get; set; }

        public DateTime RegDate { get; set; }
        public int Number { get; set; }
        public int RestNumber { get; set; }

        public DateTime LastBorrowDate { get; set; }
        public string LastReaderName { get; set; }
        public DateTime LastReturnDate { get; set; }
        public string LastRtReaderName { get; set; }

        public int Jccs { get; set; }  // 借出次数

        // 未借天数
        // 如果是“借出”状态，则=0
        public int NotBrDays 
        { 
            get
            {
                int days = 0;
                if ("在馆".Equals(State))
                {
                    if (LastReturnDate >= Convert.ToDateTime("1970-01-01")) 
                    {
                        days = Math.Abs((LastReturnDate - System.DateTime.Now).Days);
                    }
                }
                
                return days;
            }
        }
        // 未还天数
        public int NotRtDays 
        {
            get
            {
                int days = 0;
                if ("借出".Equals(State))
                {
                    if (LastBorrowDate >= Convert.ToDateTime("1970-01-01"))
                    {
                        days = Math.Abs((LastBorrowDate - System.DateTime.Now).Days);
                    }
                }
                
                return days;
            }
        }  

        // 最近未借出天数； 
        // 如果“在馆”，取"最后还书日期"，标志“未借xx天”;
        // 如果已经“借出”，取“最后借出日期”，标志“未还xx天”
        public string LastNotBrNums 
        {
            get 
            {
                string val = "";
                int days = 0;
                if ("借出".Equals(State))
                {
                    //if ((LastBorrowDate != null) && (LastBorrowDate >= Convert.ToDateTime(1147763686)))
                    if (LastBorrowDate != null) 
                    { 
                        days = Math.Abs((LastBorrowDate - System.DateTime.Now).Days);
                    }
                    val = string.Format("借出{0}天", days.ToString());
                    
                }

                if ("在馆".Equals(State))
                {
                    if (LastReturnDate != null) { days = Math.Abs((LastReturnDate - System.DateTime.Now).Days); }                    
                    val = string.Format("在馆{0}天",days.ToString());
                }
                return val;
            } 
        }

        

        // 状态
        public string State
        {
            get
            {
                string val = "";

                if (RestNumber == 0)
                {
                    val = "借出";
                }
                else
                {
                    val = "在馆";
                }

                return val;
            }
        }
    }
}
