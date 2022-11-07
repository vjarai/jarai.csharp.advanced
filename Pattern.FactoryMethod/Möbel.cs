using Jarai.CSharp.Pattern.FactoryMethod.Exceptions;

namespace Jarai.CSharp.Pattern.FactoryMethod
{
    /// <summary>
    ///     Abstracte Basisklasse für alle Möbel Arten
    ///     Sobald eine Klasse mindestens eine abstracte Methode enthält,
    ///     wird muss die Klasse selbst abstract sein.
    ///     Von abstracten Klassen können keine Instanzen erstellt werden!
    /// </summary>
    public abstract class Möbel
    {
        protected bool IstMontiert = false;

        protected string Name;

        protected Möbel(string name, double preis)
        {
            Name = name;
            Preis = preis;
        }

        public double Preis { get; }

        public abstract void Benutzen(); // Abstracte Methoden MÜSSEN überschrieben werden

        public abstract void Montieren(); // und können in der Basisklasse NICHT implementiert werden

        protected void ThrowExceptionIfNotAssembled()
        {
            if (!IstMontiert)
                throw new InvalidUserOperationException("Möbel muss vor benutzung montiert werden.");
            // Best Practice: Fehlermeldungen positiv formulieren (d.h. das Wort "nicht" vermeiden),
        }
    }
}