using System;

namespace Jarai.CSharp.Generic.Func
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var taxCalculator = new TaxCalculator(TaxCalculationFunction, WriteLogAction);
            var tax = taxCalculator.CalculateTax(100);

            Console.WriteLine(tax);
        }

        private static decimal TaxCalculationFunction(decimal value)
        {
            return value * (decimal)0.19;
        }

        private static void WriteLogAction(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}