using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Strategy
{
    public class Firma
    {
        private readonly List<Arbeiter> _mitarbeiter = new List<Arbeiter>();
        private readonly string _name;

        public Firma(string name)
        {
            _name = name;
        }

        public IEnumerable<Arbeiter> Mitarbeiter
        {
            get { return _mitarbeiter; }
        }

        public void Einstellen(Arbeiter arbeiter)
        {
            _mitarbeiter.Add(arbeiter);
        }

        public void Produzieren()
        {
            Console.WriteLine("Firma '{0}' produziert:", _name);

            foreach (var arbeiter in Mitarbeiter)
            {
                arbeiter.Arbeiten();
            }
        }
    }
}