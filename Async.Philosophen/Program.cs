using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jarai.Async.Lock
{
    internal class Program
    {
        private static Gabel[] ErstelleGabeln(int anzahl)
        {
            var gabeln = new Gabel[anzahl];

            for (var i = 0; i < anzahl; i++)
            {
                gabeln[i] = new Gabel("Gabel" + (i + 1));
            }

            return gabeln;
        }

        private static IEnumerable<Task> ErstelleLebensTasks(IEnumerable<Philosoph> philosophen)
        {
            foreach (var philosoph in philosophen)
            {
                yield return Task.Run(philosoph.Leben);
            }
        }

        private static Philosoph[] ErstellePhilosophen(Gabel[] gabeln)
        {
            var philosophen = new Philosoph[gabeln.Length];

            for (var i = 0; i < philosophen.Length; i++)
            {
                philosophen[i] = new Philosoph("Philosoph" + (i + 1), gabeln[i], gabeln[i == gabeln.Length - 1 ? 0 : i + 1])
                {
                    MaxAlter = 5
                };
            }

            return philosophen;
        }

        private static void Main(string[] args)
        {
            var gabeln = ErstelleGabeln(4);

            var philosophen = ErstellePhilosophen(gabeln);

            var livingTasks = ErstelleLebensTasks(philosophen);

            Task.WaitAll(livingTasks.ToArray());

            Console.WriteLine("Philosophen Dinner beendet.");
        }
    }
}