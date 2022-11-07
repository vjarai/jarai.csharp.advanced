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
        ///     Factory Method: Erstellt M�bel Instanzen unterschiedlichen Typs
        /// </summary>
        /// <returns>Neues M�bel</returns>
        public M�bel Verkaufen(string m�belTyp)
        {
            Console.WriteLine($"Willkommen bei Ikea {_standort}.");

            M�bel neuesM�bel = null;

            if (m�belTyp == "Tisch")
                neuesM�bel = new Tisch();
            else if (m�belTyp == "Stuhl")
                neuesM�bel = new Stuhl();

            // Oder Eleganter via Reflection:
            // neuesM�bel = CreateM�belViaReflection(m�belTyp);

            if (neuesM�bel == null)
                throw new NichtAufLagerException($"{m�belTyp} ist leider nicht auf Lager.");

            _konzernumsatz += neuesM�bel.Preis;
            _filialumsatz += neuesM�bel.Preis;

            return neuesM�bel;
        }


        private M�bel CreateM�belViaReflection(string m�belTyp)
        {
            var className = GetType().Namespace + "." + m�belTyp; // namespace erg�nzen

            // Instanz via Reflection / CreateInstance �ber den Klassennamen erstellen, statt new
            var m�bel = (M�bel)Assembly.GetExecutingAssembly().CreateInstance(className, true);

            return m�bel;
        }
    }
}