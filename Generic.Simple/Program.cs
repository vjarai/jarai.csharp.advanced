using System;

namespace Jarai.Generic.Class
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myIntContainer = new Container<int>();
            myIntContainer.SetValue(100);
            Console.WriteLine(myIntContainer.GetValue());

            var myStringContainer = new Container<string>();
            myStringContainer.SetValue("Hallo");
            Console.WriteLine(myStringContainer.GetValue());
        }
    }
}