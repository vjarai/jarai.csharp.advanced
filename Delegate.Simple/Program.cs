using System;

namespace Delegate.Simple
{
    internal delegate int RechenFunktion(int x, int y);

    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = 100;
            var y = 200;

            // Variable (vom Typ) RechenFunktion anlegen und initialisieren
            RechenFunktion rechenFunktion = Add;

            var ergebnis1 = rechenFunktion(x, y); // ruft Add() auf
            Console.WriteLine($"Ergebnis1: {ergebnis1}");

            rechenFunktion = Subtract;
            var ergebnis2 = rechenFunktion(x, y); // ruft Subtract() auf
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