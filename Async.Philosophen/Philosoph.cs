namespace Jarai.CSharp.Async.Lock
{
    internal class Philosoph
    {
        private readonly Random _random = new();
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

        public int MaxAlter { get; set; } = 85;

        public string Name { get; set; }

        public Gabel RechteGabel { get; set; }

        public void Leben()
        {
            Console.WriteLine($"{Name} startet leben...");

            while (++Alter < MaxAlter)
            {
                Thread.Sleep(_random.Next(500));

                if (_state == State.Denkend)
                    _state = State.Hungrig;

                Console.WriteLine(this);

                if (_state == State.Hungrig)
                    EssenMitDeadlock();
            }

            Console.WriteLine($"{Name} beendet leben...");
        }


        public override string ToString()
        {
            return $"{Name} ist {_state}.";
        }

        private void EssenMitDeadlock()
        {
            lock (LinkeGabel)
            {
                LinkeGabel.Grab(this);

                Thread.Sleep(_random.Next(200));

                lock (RechteGabel)
                {
                    RechteGabel.Grab(this);

                    _state = State.Essend;
                    Console.WriteLine(this);

                    Thread.Sleep(_random.Next(1000));

                    RechteGabel.Put();
                    LinkeGabel.Put();

                    _state = State.Denkend;
                }
            }
        }

        private void EssenMitTimeout()
        {
            if (Monitor.TryEnter(LinkeGabel, 1000))
            {
                LinkeGabel.Grab(this);
                Thread.Sleep(_random.Next(200));

                if (Monitor.TryEnter(RechteGabel, 1000))
                {
                    RechteGabel.Grab(this);

                    _state = State.Essend;
                    Console.WriteLine(this);

                    Thread.Sleep(_random.Next(1000));

                    RechteGabel.Put();

                    Monitor.Exit(RechteGabel);

                    _state = State.Denkend;
                }
                else
                {
                    Console.WriteLine($"*** {Name} timeout beim warten auf {RechteGabel.Name} ***");
                }

                LinkeGabel.Put();
                Monitor.Exit(LinkeGabel);
            }
        }
    }
}