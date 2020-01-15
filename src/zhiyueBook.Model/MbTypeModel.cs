using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zhiyueBook.Model
{
    /// <summary>
    /// 会员类型
    /// </summary>
    public class MbTypeModel
    {
        public MbTypeModel() { }

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

        //public string State { get; set; } 

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type = "MemberType";
        public int MaxOutNums { get; set; }
        public double HuiFee { get; set; }
        public double YaJin { get; set; }
        public string Remark { get; set; }  
    }
}
