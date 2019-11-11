using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zhiyueBook.Model
{
    public class Tjjy
    {
        public Tjjy() { }

        /*
         Rcode: 读者编号
         LastBorrowDate: 最后一次借书日期
         LastReturnDate : 最后一次还书日期
         sumBrBooks: 总借书本书
         sumRtBooks: 总还书本书
         NotRtBooks: 未还本书
         daysAgo: 最后一次借书距今时间
         SumBookPrice：借阅价值
         */

        public string Rcode { get; set; } 
        public string Rname { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }

        public DateTime LastBorrowDate { get; set; }
        public DateTime LastReturnDate { get; set; }
        public int DaysAgo { get; set; }
        public int SumBrBooks { get; set; }
        public int SumRtBooks { get; set; }
        public int NotRtBooks { get; set; }

        public Double SumBookPrice { get; set; }

        public int Stop { get; set; }  // 停用标志
        public DateTime ValidityDate { get; set; }  // 过期时间

        // 联系方式
        public string LinkTel
        {
            get { 
                string val = Mobile;

                if(!"".Equals(Tel))
                {
                    val = Tel + "; " + Mobile;
                }
                return val;
            } 
        }

        // 剩余天数
        public int SyDays { 
            get 
            {
                int val = 0;

                if (Stop != 1)  // 停用 = 0
                {
                    val = Math.Abs((ValidityDate - System.DateTime.Now).Days);
                }
                return val;
            } 
        }  

        // 状态
        public string State {
            get {
                string val = "正常";

                if (Stop == 1)
                {
                    val = "停用";
                }
                else
                {
                    // 剩余天数<=10 即将过期
                    if (SyDays <= 10) { val = "即将过期"; }
                }

                return val;
            }
        }
        

    }
}
