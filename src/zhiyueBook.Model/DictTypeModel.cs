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

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Code { get; set; }  
        public string Name { get; set; }
        
    }
}
