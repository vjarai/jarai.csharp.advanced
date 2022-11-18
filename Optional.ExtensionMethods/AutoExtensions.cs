using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional.ExtensionMethods
{
    /// <summary>
    /// Eine Klasse mit Extension Methoden muss immer static sein
    /// </summary>
    internal static class AutoExtensions
    {
        /// <summary>
        /// Eine Extension Methode muss immer static sein
        /// Durch "this" im Parameter ist eine Aufruf wie eine normale Methode möglich.
        ///
        /// Vorteile:
        /// Fachfremdes Wissen kann in andere Klassen ausgelagert werden.
        /// Wird trotzdem wie eine normale Mothode im Intellisense angzeigt.
        /// </summary>
        public static void Versichern(this Auto zuVersicherndesAuto)
        {
            Console.WriteLine($"Das Auto '{zuVersicherndesAuto.KfzKennzeichen}' wird günstig versichert.");
        }


        public static void Waschen(this Auto zuWaschendesAuto)
        {
            Console.WriteLine($"Das Auto '{zuWaschendesAuto.KfzKennzeichen}' wird blitzblank gewaschen.");
        }
    }
}
