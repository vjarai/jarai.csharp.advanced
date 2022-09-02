using System;

namespace Jarai.CSharp.Generic.WithRestriction
{
    internal class Pkw : IComparable<Pkw>
    {
        public int Leistung { get; set; }

        public override string ToString()
        {
            return $"Pkw mit {Leistung} PS.";
        }

        public int CompareTo(Pkw other)
        {
            if (Leistung > other.Leistung)
                return 1;
            if (Leistung < other.Leistung)
                return -1;

            return 0;
        }
    }
}