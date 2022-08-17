namespace Jarai.Generic.Method
{
    internal class Swapper
    {
        /// <summary>
        ///     SCHLECHT: Kann nur die werte von zwei doubles tauschen
        /// </summary>
        public static void Swap(ref double x, ref double y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        /// <summary>
        ///     SCHLECHT: Kann nur die werte von zwei decimal tauschen
        /// </summary>
        public static void Swap(ref decimal x, ref decimal y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        /// <summary>
        ///     BESSER: Generische Methode, tauscht die werte für beliebige Datentypen
        /// </summary>
        public static void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }
}