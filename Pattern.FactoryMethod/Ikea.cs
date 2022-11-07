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
            Console.WriteLine("=======================================");
            Console.WriteLine("Ikea in      : " + _standort);
            Console.WriteLine("Filialumsatz : " + _filialumsatz);
            Console.WriteLine("Konzernumsatz: " + _konzernumsatz);
        }

        /// <summary>
        ///     Factory Method: Erstellt Möbel Instanzen unterschiedlichen Typs
        /// </summary>
        /// <returns>Neues Möbel</returns>
        public Möbel Verkaufen(string möbelTyp)
        {
            Console.WriteLine($"Willkommen bei Ikea {_standort}.");

            Möbel neuesMöbel = null;

            if (möbelTyp == "Tisch")
                neuesMöbel = new Tisch();
            else if (möbelTyp == "Stuhl")
                neuesMöbel = new Stuhl();

            // Oder Eleganter via Reflection:
            // neuesMöbel = CreateMöbelViaReflection(möbelTyp);

            if (neuesMöbel == null)
                throw new NichtAufLagerException($"{möbelTyp} ist leider nicht auf Lager.");

            _konzernumsatz += neuesMöbel.Preis;
            _filialumsatz += neuesMöbel.Preis;

            return neuesMöbel;
        }


        private Möbel CreateMöbelViaReflection(string möbelTyp)
        {
            var className = GetType().Namespace + "." + möbelTyp; // namespace ergänzen

            // Instanz via Reflection / CreateInstance über den Klassennamen erstellen, statt new
            var möbel = (Möbel)Assembly.GetExecutingAssembly().CreateInstance(className, true);

            return möbel;
        }
    }
}