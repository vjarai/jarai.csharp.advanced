using System;
using System.Collections.Generic;

namespace Jarai.CSharp.Generic.WithRestriction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myList = new List<Pkw>
            {
                new Pkw { Leistung = 100 },
                new Pkw { Leistung = 45 },
                new Pkw { Leistung = 120 }
            };

            var sortAlgorithm = new SortAlgorithm();

            sortAlgorithm.SortAscending(myList);
            ShowData(myList);

            sortAlgorithm.SortDescending(myList);
            ShowData(myList);

            sortAlgorithm.Sort(myList, new PkwComparer());
            ShowData(myList);

            Console.ReadLine();
        }

        /// <summary>
        ///     Writes the given data to the Console
        /// </summary>
        /// <typeparam name="T">Type of an item in the data collection</typeparam>
        /// <param name="data">Data collection to be shown</param>
        private static void ShowData<T>(IEnumerable<T> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}