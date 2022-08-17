using System.Diagnostics;

namespace Jarai.Patterns.State
{
    public class Aufgelegt : Zustand
    {
        public Aufgelegt()
            : base("<Hörer ist aufgelegt>")
        {
        }

        public override Zustand Abheben()
        {
            Debug.WriteLine("Hörer wird abgehoben.");
            return new Abgehoben();
        }

        public override Zustand AnnehmenAnruf()
        {
            Debug.WriteLine("Anruf wird angenommen.");
            return new Verbunden();
        }
    }
}