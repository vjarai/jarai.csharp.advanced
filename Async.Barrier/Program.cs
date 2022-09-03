using System;
using System.Threading;
using System.Threading.Tasks;

// https://dotnetpattern.com/threading-barrier

// https://devblogs.microsoft.com/pfxteam/tag/coordination-data-structures/

internal class Program
{
    const int TaskCount = 5;
    private static readonly Barrier _barrier = new Barrier(TaskCount);

    private static void GetDataAndStoreData(int index)
    {
        Console.WriteLine("Getting data from server: " + index);
        Thread.Sleep(TimeSpan.FromSeconds(2));

        _barrier.SignalAndWait();

        Console.WriteLine("Sending data to Backup server: " + index);

        _barrier.SignalAndWait();
    }

    private static void Main(string[] args)
    {
        var tasks = new Task[TaskCount];

        for (var i = 0; i < tasks.Length; ++i)
        {
            var j = i;
            tasks[j] = Task.Run(() => { GetDataAndStoreData(j); });
        }

        Task.WaitAll(tasks);

        Console.WriteLine("Backup completed");
        Console.ReadLine();
    }
}