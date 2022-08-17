using System;
using System.Linq;

namespace Jarai.Generic.Predicate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repository = new Repository();

            var record = repository.GetRecordsWhere(r => r.Value > 45 && r.Value < 55).First();

            Console.WriteLine(record);

            Console.ReadLine();
        }
    }
}