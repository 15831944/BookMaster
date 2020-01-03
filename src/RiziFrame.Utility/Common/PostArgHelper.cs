using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using System.Web.Script.Serialization;
//using Newtonsoft.Json;

namespace RiziFrame.Utility.Common
{
    /// <summary>
    /// 主要声明传递类，以方便识别是“新增”或者“修改”状态
    /// </summary>
    public class PostArgHelper
    {
        public PostArgType postFlag { get; set; }  // 传递标志: new or mod
        public object  postObj { get; set; }   // 传递对象


        /// <summary>
        /// 将object对象转换为实体对象
        /// </summary>
        /// <typeparam name="T">实体对象类名</typeparam>
        /// <param name="asObject">object对象</param>
        /// <returns></returns>
        //public T ConvertObjectByJson<T>(object asObject) where T : new()
        //{
        //    var serializer = new JavaScriptSerializer();
        //    //将object对象转换为json字符
        //    var json = serializer.Serialize(asObject);
        //    //将json字符转换为实体对象
        //    var t = serializer.Deserialize<T>(json);
        //    return t;
        //}
        
    }

    public enum PostArgType
    {
        /// <summary>
        /// 新增
        /// </summary>
        New = 1,
        /// <summary>
        /// 编辑
        /// </summary>
        Mod = 2,
    }
}
