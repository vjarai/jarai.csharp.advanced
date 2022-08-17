using System.Diagnostics;

namespace Jarai.Patterns.State
{
    public abstract class Zustand
    {
        public Zustand(string bezeichnung)
        {
            Bezeichnung = bezeichnung;
        }

        public string Bezeichnung { get; }

        public virtual Zustand Abheben()
        {
            Debug.WriteLine("Sie können derzeit den Hörer nicht abheben.");
            return this;
        }

        public virtual Zustand AnnehmenAnruf()
        {
            Debug.WriteLine("Sie können derzeit keinen Anruf annehmen.");
            return this;
        }

        public virtual Zustand Auflegen()
        {
            Debug.WriteLine("Sie können derzeit den Hörer nicht auflegen.");
            return this;
        }

        public virtual Zustand Sprechen()
        {
            Debug.WriteLine("Sie können derzeit nicht sprechen.");
            return this;
        }


        public override string ToString()
        {
            return Bezeichnung;
        }

        public virtual Zustand Wählen()
        {
            Debug.WriteLine("Sie können derzeit keine Nummer wählen.");
            return this;
        }
    }
}