using System.Collections.Generic;

namespace Jarai.CSharp.Generic.WithRestriction
{
    internal class PkwComparer : IComparer<Pkw>
    {
        public int Compare(Pkw x, Pkw y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;

            return x.Leistung.CompareTo(y.Leistung);
        }
    }
}