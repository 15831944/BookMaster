using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zhiyueBook.Model
{
    public class Jyxx
    {
        public Jyxx() { }

        /*
         state: 借还状态
         Rcode: 读者编号
         Rname：读者名称
         Bookcode: 图书编号
         BookName : 图书名称
         BookPrice: 图书价格
         sumBrBooks: 总借书本书
         BorrowDate: 借书日期
         ReturnDate: 应还书日期          
         */

        public string State { get; set; } 
        public string Rcode { get; set; } 
        public string Rname { get; set; }
        public string Bookcode { get; set; }
        public string BookName { get; set; }
        public Double BookPrice { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime FactReturnDate { get; set; }
       
    }
}
