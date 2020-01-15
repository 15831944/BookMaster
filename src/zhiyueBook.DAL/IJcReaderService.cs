using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zhiyueBook.DAL
{   
    /// <summary>
    /// 1. 常规的增删改查
    /// 2. 获取最大MaxCode
    /// 3. 删除读者时，需要查询读者的借阅记录，有的话不能删除，可以转存到历史中。
    /// 4. 修改读者的读者编号时，需要查询修改后的编号是否存在？另外还需要修改所有的借阅记录相关编号。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IJcReaderService<T> : ICommonCURD <T>
    {

        /// <summary>
        /// 获取读者最大编号
        /// </summary>
        /// <returns></returns>
        String GetMaxCode();

       int GetBrNumByCode(string pkCode);


    }
}
