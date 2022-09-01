using System;

namespace Jarai.Generic.Parameters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 1, y = 2;

            Swapper.Swap(ref x, ref y);
            Console.WriteLine($"x={x}, y={y}");

            string a = "Hallo", b = "welt";

            Swapper.Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");
        }
    }
}