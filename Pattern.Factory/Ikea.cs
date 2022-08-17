using System;
using System.Diagnostics;
using System.Reflection;
using Jarai.Patterns.FactoryMethod.Exceptions;

namespace Jarai.Patterns.FactoryMethod
{
    public class Ikea
    {
        private static double _konzernumsatz = 0;
        private double _filialumsatz;
        private readonly string _standort;

        /// <summary>
        /// Static Construcor / Class Initializer is called before first instance is constructed
        /// </summary>
        static Ikea()
        {
            _konzernumsatz = 0;
        }

        public Ikea(string standort)
        {
            _standort = standort;
            _filialumsatz = 0;
        }

        public void Show()
        {
            Debug.WriteLine("=======================================");
            Debug.WriteLine("Ikea in      : " + _standort);
            Debug.WriteLine("Filialumsatz : " + _filialumsatz);
            Debug.WriteLine("Konzernumsatz: " + _konzernumsatz);
        }

        /// <summary>
        /// Factory Method: Erstellt Möbel Instanzen unterschiedlichen Typs
        /// </summary>
        /// <returns>Neues Möbel</returns>
        public Möbel Verkaufen()
        {
            Console.WriteLine($"Willkommen bei Ikea {_standort}.");
            Console.WriteLine("Was möchten Sie kaufen? (Tisch, Stuhl oder Leer).");

            var eingabe = Console.ReadLine();

            if (string.IsNullOrEmpty(eingabe))
                return null;

            var typeName = GetType().Namespace + "." + eingabe;

            // Instanz via Reflection über den Klassennamen erstellen
            var möbel = (Möbel)Assembly.GetExecutingAssembly().CreateInstance(typeName, true);

            if (möbel == null)
                throw new NichtAufLagerException($"{eingabe} ist leider nicht auf Lager.");

            _konzernumsatz += möbel.Preis;
            _filialumsatz += möbel.Preis;

            return möbel;
        }
    }
}