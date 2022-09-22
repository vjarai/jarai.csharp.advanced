namespace Delegate.Simple
{
    internal delegate int RechenFunktion(int x, int y);

    internal class Program
    {


        private static void Main(string[] args)
        {
            var x = 100;
            var y = 200;
            int z;

            RechenFunktion aktuelleFunktion; // Variable aktuelleFunktion vom Typ RechenFunktion anlegen
            aktuelleFunktion = Add; // Variable initialisieren

            z = aktuelleFunktion(x, y); // ruft Add() auf

            aktuelleFunktion = Sub;
            z = aktuelleFunktion(x, y); // ruft Sub() auf
        }


        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Sub(int x, int y)
        {
            return x + y;
        }
    }
}