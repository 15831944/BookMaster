using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zhiyueBook.Model
{
    public class Tjtsxx
    {
        public Tjtsxx() { }

        /*
         BookCode: 图书编号
         Name: 图书名称         
         Barcode : 条形码
          
         BorrowDate: 借书日期
         ReturnDate: 应还书日期   
         FactReturnDate: 实际还书日期   
         ExceedDay: 逾期天数   
         
         RCode： 读者编号
         ReaderName : 读者姓名
         Tel： 电话
         Mobile : 手机
         * 
         * 
         */

        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string Barcode { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime FactReturnDate { get; set; }
        public int ExceedDay { get; set; }

        public string RCode { get; set; }
        public string RName { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }

        // 联系方式
        public string LinkTel
        {
            get
            {
                string val = Mobile;

                if (!"".Equals(Tel))
                {
                    val = Tel + "; " + Mobile;
                }
                return val;
            }
        }

        
    }
}
