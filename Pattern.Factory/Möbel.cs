using Jarai.Patterns.FactoryMethod.Exceptions;

namespace Jarai.Patterns.FactoryMethod
{
    public abstract class Möbel // Sobald eine Klasse mindestens eine abstracte Methode enthält,
        // wird die Klasse zur abstracten Basisclasse (ABC)
        // Von abstracten Klassen kann keine Instanz erstellt werden 
    {
        protected bool IsAssembled = false;

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
            if (!IsAssembled)
                throw new InvalidUserOperationException("Möbel muss vor benutzung montiert werden.");
            // Best Practice: Fehlermeldungen positiv formulieren (d.h. das Wort "nicht" vermeiden),
        }
    }
}