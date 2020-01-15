using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace zhiyueBook.DAL
{
    public interface ICommonCURD <T>
    {
        /// <summary>
        /// 根据ID获取对象
        /// </summary>
        /// <param name="pkid"></param>
        /// <returns></returns>
        T GetSingleObj(int pkid);

        /// <summary>
        /// 根据ID获取对象
        /// </summary>
        /// <param name="pkid"></param>
        /// <returns></returns>
        T GetSingleObj(string pkid);
        
        /// <summary>
        /// 查询返回列表
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        List<T> QueryList(string keyword);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int Add(T obj);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int Upd(T obj);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int Del(T obj);

        int Del(string id);
    }
}
