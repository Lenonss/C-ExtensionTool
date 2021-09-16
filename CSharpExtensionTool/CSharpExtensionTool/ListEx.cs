using System;
using System.Collections.Generic;
using CSharpExtensionTool.Interfaces;
namespace CSharpExtensionTool.ListExtension
{
    public static class ListEx
    {
        /// <summary>
        /// 指定值初始化List数组,可指定数组容量。
        /// 指定类型不可为引用类型
        /// </summary>
        /// <typeparam name="T">数组类型，限定为struct</typeparam>
        /// <param name="selfList">数组</param>
        /// <param name="Value">指定值</param>
        /// <param name="capcity">List.Count=0才起效</param>
        /// <returns></returns>
        public static bool InitListWithValue<ST>(this List<ST> selfList, ST Value, int capcity = 0) where ST : struct
        {
            //数组不为空
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
        public static bool InitListWithClassValue<T>(this List<T> selfList, T Value, int capcity = 0) where T : ICopyClass
        {
            var newClass = Value.GetNewCopyClass<T>(Value);
            return true;
        }

    }

}
