using System;
using System.Collections.Generic;

namespace Jarai.CSharp.Generic.WithRestriction
{
    internal class SortAlgorithm
    {
        /// <summary>
        ///     Sortiert eine Liste von beliebigen Daten
        ///     Voraussetzung: Der Typ T der Nutzdaten muss eine Sortierreihenfolge (IComparable) definieren.
        ///     Vorteil: Durch die where Restriction wird aus einem Laufzeitfehler ein Compilezeitfehler.
        /// </summary>
        public void SortAscending<T>(List<T> dataToSort) where T : IComparable<T>
        {
            dataToSort.Sort();
        }

        public void SortDescending<T>(List<T> dataToSort) where T : IComparable<T>
        {
            dataToSort.Sort((x, y) => y.CompareTo(x));
        }

        public void Sort<T>(List<T> dataToSort, IComparer<T> sortComparer)
        {
            dataToSort.Sort(sortComparer);
        }
    }
}