using System.Diagnostics;

namespace Jarai.Patterns.State
{
    public class Verbunden : Zustand
    {
        public Verbunden()
            : base("<Verbindung ist hergestellt>")
        {
        }

        public override Zustand Auflegen()
        {
            Debug.WriteLine("Hörer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override Zustand Sprechen()
        {
            Debug.WriteLine("Es wird gesprochen.");
            return this;
        }
    }
}