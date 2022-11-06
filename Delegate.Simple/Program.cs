namespace Jarai.CSharp.Delegate.Simple
{
    internal delegate int RechenFunktion(int x, int y);

    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = 100;
            var y = 200;

            // Variable (vom Typ) RechenFunktion anlegen und initialisieren
            RechenFunktion aktuelleRechenFunktion = Add;

            var ergebnis1 = aktuelleRechenFunktion(x, y); // ruft Add() auf
            Console.WriteLine($"Ergebnis1: {ergebnis1}");

            aktuelleRechenFunktion = Subtract;
            var ergebnis2 = aktuelleRechenFunktion(x, y); // ruft Subtract() auf
            Console.WriteLine($"Ergebnis2: {ergebnis2}");
        }


        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Subtract(int x, int y)
        {
            return x + y;
        }
    }
}