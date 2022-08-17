using System;
using System.Threading.Tasks;

namespace Jarai.Async.Lock
{
    internal class Philosoph
    {
        private State _state;

        public Philosoph(string name, Gabel linkeGabel, Gabel rechteGabel)
        {
            Name = name;
            LinkeGabel = linkeGabel;
            RechteGabel = rechteGabel;
            _state = State.Denkend;
        }

        public int Alter { get; set; }

        public Gabel LinkeGabel { get; set; }

        public string Name { get; set; }

        public Gabel RechteGabel { get; set; }

        public void Leben()
        {
            Console.WriteLine($"{Name} startet leben...");

            while (++Alter < 100)
            {
                Console.WriteLine(this);

                if (_state == State.Denkend) _state = State.Hungrig;

                if (_state == State.Hungrig) Essen();
            }

            Console.WriteLine($"{Name} beendet leben...");
        }

        public Task StartLivingTask()
        {
            var task = new Task(Leben);
            task.Start();
            return task;
        }

        public override string ToString()
        {
            return $"{Name} {Alter} {_state}";
        }

        private void Essen()
        {
            lock (LinkeGabel)
            {
                lock (RechteGabel)
                {
                    _state = State.Essend;
                    Console.WriteLine(this);
                }
            }

            _state = State.Denkend;
        }

        private enum State
        {
            Essend,
            Denkend,
            Hungrig
        }
    }
}