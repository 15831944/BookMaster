using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RiziFrame.Utility.Common;

namespace zhiyueBook.Model
{
    public class JcReader
    {
        public JcReader() { }

        /*
         * id：主键
         * state: 读者状态  -- 扩展属性
         * SyDays：剩余天数 -- 扩展属性
         * Rcode: 读者编号
         * Rname：读者名称  
         * Sex: 性别
         * MembType: 会员类型   
         * 
         * BirthDay: 生日
         * Tel：电话
         * Mobile：手机
         * LinkTel: 联系方式   -- 扩展属性 显示的是“电话+手机”
         * AgeBrith: 年龄生日  -- 扩展属性 显示"[年龄]-生日"
         * Address： 通讯地址
         * 
         * RegDate: 登记日期
         * KaikaDate：  开卡日期 对应原库字段: Field8
         * ValidityDate： 有效期至
         
         */

        //public string State { get; set; } 
        public int id { get; set; }
        public string Rcode { get; set; } 
        public string Rname { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDay { get; set; }      // 生日

        public string MembType { get; set; }        // 会员类型   

        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        public DateTime RegDate { get; set; }       // 登记日期
        public DateTime KaikaDate { get; set; }     // 开卡日期
        public DateTime ValidityDate { get; set; }  // 过期日期
        
        public int Stop { get; set; }  // 停用标志

        public string PinYin { get; set; }  // 拼音码
        public string Remark { get; set; }  // 备注
        

        //public DateTime FactReturnDate { get; set; }

        #region 扩展属性
        // 年龄生日
        public string AgeBrith
        {
            get
            {
                string val = string.Empty;
                
                //val = Math.Abs((BirthDay - System.DateTime.Now).ye.Days);
                int[] kk = DateHelper.toResult(BirthDay, System.DateTime.Now, diffResultFormat.yymm);
                if (kk[0] < 4) {
                    val = string.Format("{2} - [{0}岁{1}个月]", kk[0], kk[1], BirthDay.ToShortDateString());
                } else {
                    val = string.Format("{1} - [{0}岁] ", kk[0], BirthDay.ToShortDateString());
                }

                return val;
            }
        }

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

        // 剩余天数
        public int SyDays
        {
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
        public string State
        {
            get
            {
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

        #endregion

    }
}
