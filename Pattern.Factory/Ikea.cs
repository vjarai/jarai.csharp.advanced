using System;
using System.Diagnostics;
using System.Reflection;
using Jarai.CSharp.Pattern.FactoryMethod.Exceptions;

namespace Jarai.CSharp.Pattern.FactoryMethod
{
    public class Ikea
    {
        private static double _konzernumsatz;
        private readonly string _standort;
        private double _filialumsatz;

        /// <summary>
        ///     Static Construcor / Class Initializer is called before first instance is constructed
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
        ///     Factory Method: Erstellt Möbel Instanzen unterschiedlichen Typs
        /// </summary>
        /// <returns>Neues Möbel</returns>
        public Möbel Verkaufen(string möbelTyp)
        {
            Console.WriteLine($"Willkommen bei Ikea {_standort}.");
            
            var className = GetType().Namespace + "." + möbelTyp;

            // Instanz via Reflection über den Klassennamen erstellen, statt new
            var möbel = (Möbel)Assembly.GetExecutingAssembly().CreateInstance(className, true);
            
            if (möbel == null)
                throw new NichtAufLagerException($"{möbelTyp} ist leider nicht auf Lager.");

            _konzernumsatz += möbel.Preis;
            _filialumsatz += möbel.Preis;

            return möbel;
        }
    }
}