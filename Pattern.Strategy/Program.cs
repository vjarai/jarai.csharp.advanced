using System;

namespace Jarai.CSharp.Pattern.Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var firma1 = new Firma("Malermeister Buntig");
            var firma2 = new Firma("Schreinerei Maker");

            firma1.Einstellen(new Maler("Paul"));
            firma1.Einstellen(new Maler("Jens"));

            firma2.Einstellen(new Schreiner("Gerd"));
            firma2.Einstellen(new Schreiner("Gregor"));

            firma1.Produzieren();   // Wände werden gestrichen
            firma2.Produzieren();   // Möbel werden produziert

            Console.Read();
        }
    }
}