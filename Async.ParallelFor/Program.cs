using System.Collections.Concurrent;
using System.Diagnostics;

namespace Jarai.CSharp.Async.ParallelFor
{
    internal class Program
    {
        private static void Main()
        {
            // 2 million
            var limit = 2_000_000;
            var numbers = Enumerable.Range(0, limit).ToList();

            var watch = Stopwatch.StartNew();
            var primeNumbersFromForeach = GetPrimeList(numbers);
            watch.Stop();

            var watchForParallel = Stopwatch.StartNew();
            var primeNumbersFromParallelForeach = GetPrimeListWithParallel(numbers);
            watchForParallel.Stop();

            var watchForPlinq = Stopwatch.StartNew();
            var primeNumbersFromPlinq = GetPrimeListWithPlinq(numbers);
            watchForPlinq.Stop();

            Console.WriteLine(
                $"Classical foreach loop | Total prime numbers : {primeNumbersFromForeach.Count} | Time Taken : {watch.ElapsedMilliseconds} ms.");
            Console.WriteLine(
                $"Parallel.ForEach loop  | Total prime numbers : {primeNumbersFromParallelForeach.Count} | Time Taken : {watchForParallel.ElapsedMilliseconds} ms.");
            Console.WriteLine(
                $"PLINQ                  | Total prime numbers : {primeNumbersFromPlinq.Count} | Time Taken : {watchForPlinq.ElapsedMilliseconds} ms.");

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        /// <summary>
        ///     GetPrimeList returns Prime numbers by using sequential ForEach
        /// </summary>
        private static IList<int> GetPrimeList(IEnumerable<int> numbers)
        {
            return numbers.Where(IsPrime).ToList();
        }

        /// <summary>
        ///     GetPrimeListWithPlinq returns Prime numbers by using Parallel LINQ (PLINQ)
        /// </summary>
        private static IList<int> GetPrimeListWithPlinq(IEnumerable<int> numbers)
        {
            return numbers.AsParallel().Where(IsPrime).ToList(); // .AsParallel() => PLINQ (Parallel Linq)
        }

        /// <summary>
        ///     GetPrimeListWithParallel returns Prime numbers by using Parallel.ForEach
        /// </summary>
        private static IList<int> GetPrimeListWithParallel(IEnumerable<int> numbers)
        {
            var primeNumbers = new ConcurrentBag<int>();

            void AddPrime(int number)
            {
                if (IsPrime(number)) primeNumbers.Add(number);
            }

            Parallel.ForEach(numbers, AddPrime); // Ausführung auf mehreren Tasks

            return primeNumbers.ToList();
        }

        /// <summary>
        ///     IsPrime returns true if number is Prime, else false.(https://en.wikipedia.org/wiki/Prime_number)
        /// </summary>
        private static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                if (number % divisor == 0)
                    return false;
            return true;
        }
    }
}