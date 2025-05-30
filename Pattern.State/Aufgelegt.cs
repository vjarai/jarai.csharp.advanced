using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public class Aufgelegt : Zustand
    {
        public Aufgelegt()
            : base("<H�rer ist aufgelegt>")
        {
        }

        public override Zustand Abheben()
        {
            Debug.WriteLine("H�rer wird abgehoben.");
            return new Abgehoben();
        }

        public override Zustand AnnehmenAnruf()
        {
            Debug.WriteLine("Anruf wird angenommen.");
            return new Verbunden();
        }
    }
}