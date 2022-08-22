using System;
using System.Collections.Generic;
using System.Linq;

namespace Jarai.Patterns.Observer
{
    public class Börse
    {
        public Börse(string name, Aktie[] aktien)
        {
            Aktien = aktien;
            Name = name;
        }

        /// <summary>
        ///     Auflistung aller an diesem Handelsplatz verfügbaren Aktien
        /// </summary>
        public IEnumerable<Aktie> Aktien { get; set; }


        /// <summary>
        ///     Indexer, ermöglicht Zugriff auf eine Aktie
        /// </summary>
        /// <param name="wkn"></param>
        /// <returns></returns>
        public Aktie this[string wkn]
        {
            get { return Aktien.Single(a => a.Wkn == wkn); }
        }

        /// <summary>
        ///     Name des Handelsplatzes
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Ermittelt die neuen Aktienkurse
        /// </summary>
        public void AktualisiereKurse()
        {
            var rand = new Random();

            foreach (var aktie in Aktien)
            {
                aktie.AktuellerKurs = Math.Round(aktie.AktuellerKurs + 10 * (decimal)rand.NextDouble() - 5, 2);
            }
        }
    }
}