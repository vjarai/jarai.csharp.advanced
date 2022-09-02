using System;

namespace Jarai.CSharp.Generic.Func
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var taxCalculator = new TaxCalculator(v => v * (decimal)0.19, WriteLog);

            Console.WriteLine(taxCalculator.CalculateTax(100));
        }

        private static void WriteLog(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}