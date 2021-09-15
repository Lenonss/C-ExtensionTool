using System;
using System.Collections.Generic;

namespace CSharpExtensionTool.ListExtension
{
    public static class ListEx
    {
        /// <summary>
        /// 指定值初始化List数组,可指定数组容量
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="selfList">数组</param>
        /// <param name="Value">指定值</param>
        /// <param name="capcity">List.Count=0才起效</param>
        /// <returns></returns>
        public static bool InitListWithValue<T>(this List<T> selfList, T Value, int capcity = 0)
        {
            if (selfList == null)
            {
                return false;
            }
            //记录
            capcity = selfList.Count > 0 ? selfList.Count : capcity;
            //清空
            selfList.Clear();

            //初始化添加
            for (int i = 0; i < capcity; i++)
            {
                selfList.Add(Value);
            }

            return true;
        }
    }
}
