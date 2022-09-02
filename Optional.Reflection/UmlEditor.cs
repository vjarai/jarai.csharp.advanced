using System;
using System.Linq;

namespace Jarai.CSharp.Reflection
{
    internal class UmlEditor
    {
        public static void ShowClass<T>()
        {
            var type = typeof(T);

            Console.WriteLine(type.Name);
            Console.WriteLine("==========================");

            foreach (var methodInfo in type.GetMethods().Where(m => !m.IsSpecialName))
            {
                Console.WriteLine(methodInfo.Name + "() : " + methodInfo.ReturnType.Name);
            }

            Console.WriteLine("==========================");

            foreach (var propertyInfo in type.GetProperties())
            {
                Console.WriteLine(propertyInfo.Name + " : " + propertyInfo.PropertyType.Name);
            }
        }
    }
}