using Jarai.CSharp.Pattern.FactoryMethod.Exceptions;

namespace Jarai.CSharp.Pattern.FactoryMethod
{
    /// <summary>
    ///     Abstracte Basisklasse f�r alle M�bel Arten
    ///     Sobald eine Klasse mindestens eine abstracte Methode enth�lt,
    ///     wird muss die Klasse selbst abstract sein.
    ///     Von abstracten Klassen k�nnen keine Instanzen erstellt werden!
    /// </summary>
    public abstract class M�bel
    {
        protected bool IstMontiert = false;

        protected string Name;

        protected M�bel(string name, double preis)
        {
            Name = name;
            Preis = preis;
        }

        public double Preis { get; }

        public abstract void Benutzen(); // Abstracte Methoden M�SSEN �berschrieben werden

        public abstract void Montieren(); // und k�nnen in der Basisklasse NICHT implementiert werden

        protected void ThrowExceptionIfNotAssembled()
        {
            if (!IstMontiert)
                throw new InvalidUserOperationException("M�bel muss vor benutzung montiert werden.");
            // Best Practice: Fehlermeldungen positiv formulieren (d.h. das Wort "nicht" vermeiden),
        }
    }
}