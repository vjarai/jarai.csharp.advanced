using Jarai.Patterns.FactoryMethod.Exceptions;

namespace Jarai.Patterns.FactoryMethod
{
    public abstract class M�bel // Sobald eine Klasse mindestens eine abstracte Methode enth�lt,
        // wird die Klasse zur abstracten Basisclasse (ABC)
        // Von abstracten Klassen kann keine Instanz erstellt werden 
    {
        protected bool IsAssembled = false;

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
            if (!IsAssembled)
                throw new InvalidUserOperationException("M�bel muss vor benutzung montiert werden.");
            // Best Practice: Fehlermeldungen positiv formulieren (d.h. das Wort "nicht" vermeiden),
        }
    }
}