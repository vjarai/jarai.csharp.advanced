using System;
using System.Linq;
using System.Reflection;

namespace Jarai.CSharp.Reflection
{
    internal class UmlEditor
    {
        public static void ShowClass<T>()
        {
            var type = typeof(T);

            Console.WriteLine(type.Name);
            Console.WriteLine("==========================");

            var methodInfos = type.GetMethods().Where(m => !m.IsSpecialName);

            // Alle Methoden anzeigen
            foreach (var methodInfo in methodInfos)
            {
                Console.Write(methodInfo.Name + "(");
                var parameterInfos = methodInfo.GetParameters();

                // Alle Methoden Parameter anzeigen
                foreach (var parameterInfo in parameterInfos)
                {
                    Console.Write(parameterInfo.Name + " : " + parameterInfo.ParameterType + ", ");
                }

                Console.WriteLine(") : " + methodInfo.ReturnType.Name);
            }

            // Properties anzeigen
            Console.WriteLine("==========================");

            foreach (var propertyInfo in type.GetProperties())
            {
                Console.WriteLine(propertyInfo.Name + " : " + propertyInfo.PropertyType.Name);
            }
        }
    }
}