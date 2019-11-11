using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zhiyueBook.Model;

namespace zhiyueBook.WinUI
{
    /// <summary>
    /// 传递“统计借阅类”参数
    /// </summary>
    public class PostTjts
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        public string RqStart { get; set; }  
        /// <summary>
        /// 截止日期
        /// </summary>
        public string RqEnd { get; set; }
        /// <summary>
        /// 传参的统计图书借阅类
        /// </summary>                
        public Tjts ArgTjts { get; set; }
    }


}
