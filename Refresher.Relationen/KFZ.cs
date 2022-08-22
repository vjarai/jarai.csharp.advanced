using System;

namespace Jarai.Refresher.Relations
{
    public abstract class Kfz
    {
        private readonly string _marke;

        private readonly Rad[] _räder = new Rad[4];

        private readonly Motor _motor;

        public Kfz(string marke)
        {
            _marke = marke;
            _motor = new Motor(100);

            for (var i = 0; i < 4; i++)
            {
                _räder[i] = new Rad(60);
            }
        }

        public virtual void Anzeigen()
        {
            Console.WriteLine("Marke: {0}", _marke);
            _motor.Anzeigen();

            foreach (var rad in _räder)
            {
                rad.Anzeigen();
            }
        }

        public virtual void Fahren()
        {
            Console.WriteLine("KFZ fährt!");
        }
    }
}