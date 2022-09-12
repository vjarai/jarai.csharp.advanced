using System;
using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public abstract class Zustand
    {
        protected Zustand(string bezeichnung)
        {
            Bezeichnung = bezeichnung;
        }

        public string Bezeichnung { get; }

        public virtual Zustand Abheben()
        {
            throw new InvalidOperationException("Sie können derzeit den Hörer nicht abheben.");
        }

        public virtual Zustand AnnehmenAnruf()
        {
            throw new InvalidOperationException("Sie können derzeit keinen Anruf annehmen.");
            }

        public virtual Zustand Auflegen()
        {
            throw new InvalidOperationException("Sie können derzeit den Hörer nicht auflegen.");
        }

        public virtual Zustand Sprechen()
        {
            throw new InvalidOperationException("Sie können derzeit nicht sprechen.");
        }


        public override string ToString()
        {
            return Bezeichnung;
        }

        public virtual Zustand Wählen()
        {
            throw new InvalidOperationException("Sie können derzeit keine Nummer wählen.");
        }
    }
}