using System;
namespace CSharpExtensionTool.Interfaces
{
    /// <summary>
    /// 引用类型副本接口
    /// </summary>
    public interface IDuplicateClass
    {
        /// <summary>
        /// 生成给定类对象的副本类对象返回
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="OriClass">初始类</param>
        /// <returns></returns>
        public T GetDuplicateClass<T>(T OriClass);
    }
}
