using System.Threading.Tasks;

namespace Jarai.Async.Lock
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var philosophen = new Philosoph[5];
            var gabeln = new Gabel[philosophen.Length];
            var livingTasks = new Task[5];

            for (var i = 0; i < gabeln.Length; i++) gabeln[i] = new Gabel("Gabel" + i);

            for (var i = 0; i < philosophen.Length; i++)
            {
                philosophen[i] = new Philosoph("Philosoph" + i, gabeln[i], gabeln[i == gabeln.Length - 1 ? 0 : i + 1]);
                livingTasks[i] = philosophen[i].StartLivingTask();
            }

            Task.WaitAll(livingTasks);
        }
    }
}