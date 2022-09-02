using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public class Abgehoben : Zustand
    {
        public Abgehoben()
            : base("<Hörer ist abgenommen>")
        {
        }

        public override Zustand Auflegen()
        {
            Debug.WriteLine("Hörer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override Zustand Wählen()
        {
            Debug.WriteLine("Rufnummer wird gewählt.");
            return new Verbunden();
        }
    }
}