using System;

namespace Jarai.Patterns.Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var firma1 = new Firma("Mal mal was");
            var firma2 = new Firma("Möbel maker");

            firma1.Einstellen(new Maler("Paul"));
            firma1.Einstellen(new Maler("Jens"));

            firma2.Einstellen(new Schreiner("Gerd"));
            firma2.Einstellen(new Schreiner("Gregor"));

            firma1.Produzieren();
            firma2.Produzieren();

            Console.Read();
        }
    }
}