using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zhiyueBook.Model
{
    public class DictTypeModel
    {
        public DictTypeModel() { }

        /*
         * id：主键
         * name：读者名称
         * type: 标注字典类型 = dict
         */

        //public string State { get; set; } 

        public int id { get; set; }
        public int parentId { get; set; }
        public string code { get; set; }  
        public string name { get; set; }
        
    }
}
