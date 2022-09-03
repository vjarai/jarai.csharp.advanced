using System;

namespace Jarai.CSharp.Pattern.Observer
{
    public class Beobachter
    {
        private readonly string _name;

        public Beobachter(string name)
        {
            _name = name;
        }

        public void PrüfeKauf(object sender, KursChangedEventArg e)
        {
            Console.WriteLine($"{_name} hat {e.Wkn} zum Kurs von ({e.AktuellerKurs}) gekauft.");
        }

        public void PrüfeVerkauf(object sender, KursChangedEventArg e)
        {
            Console.WriteLine($"{_name} hat {e.Wkn} zum Kurs von ({e.AktuellerKurs}) verkauft.");
        }
    }
}