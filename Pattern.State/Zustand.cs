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
            Debug.WriteLine("Sie k�nnen derzeit den H�rer nicht abheben.");
            return this;
        }

        public virtual Zustand AnnehmenAnruf()
        {
            Debug.WriteLine("Sie k�nnen derzeit keinen Anruf annehmen.");
            return this;
        }

        public virtual Zustand Auflegen()
        {
            Debug.WriteLine("Sie k�nnen derzeit den H�rer nicht auflegen.");
            return this;
        }

        public virtual Zustand Sprechen()
        {
            Debug.WriteLine("Sie k�nnen derzeit nicht sprechen.");
            return this;
        }


        public override string ToString()
        {
            return Bezeichnung;
        }

        public virtual Zustand W�hlen()
        {
            Debug.WriteLine("Sie k�nnen derzeit keine Nummer w�hlen.");
            return this;
        }
    }
}