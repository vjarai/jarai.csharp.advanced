using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Jarai.CSharp.Reflection
{
    internal class UmlEditor
    {
        public static void ShowClass<T>()
        {
            var type = typeof(T);

            // Informationen über den Typ via Reflection ermitteln
            var constructorInfos = type.GetConstructors();
            var methodInfos = type.GetMethods().Where(m => !m.IsSpecialName);
            var propertyInfos = type.GetProperties();
            
            Console.WriteLine(type.Name);

            ShowConstructors(constructorInfos);
            
            ShowMethods(methodInfos);

            ShowProperties(propertyInfos);
        }



        private static void ShowConstructors(ConstructorInfo[] constructorInfos)
        {
            Console.WriteLine("==========================");

            // Alle Konstruktoren anzeigen
            foreach (var methodInfo in constructorInfos)
            {
                Console.Write(methodInfo.Name + "(");
                var parameterInfos = methodInfo.GetParameters();

                // Alle Methoden Parameter anzeigen
                foreach (var parameterInfo in parameterInfos)
                {
                    Console.Write(parameterInfo.Name + " : " + parameterInfo.ParameterType + ", ");
                }

                Console.WriteLine(")" );
            }
        }

        private static void ShowProperties(PropertyInfo[] propertyInfos)
        {
            Console.WriteLine("==========================");

            // Alle Properties anzeigen
            foreach (var propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.Name + " : " + propertyInfo.PropertyType.Name);
            }
        }

        private static void ShowMethods(IEnumerable<MethodInfo> methodInfos)
        {
            Console.WriteLine("==========================");

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
        }
    }
}