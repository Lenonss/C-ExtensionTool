using System;
namespace CSharpExtensionTool.Interfaces
{
    public interface ICopyClass
    {
        public T GetNewCopyClass<T>(T OriClass);
    }
}
