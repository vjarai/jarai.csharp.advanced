using System;
using System.Diagnostics;
using Jarai.CSharp.Pattern.FactoryMethod.Exceptions;

namespace Jarai.CSharp.Pattern.FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ikeaFrankfurt = new Ikea("Frankfurt");
            var ikeaStuttgart = new Ikea("Stuttgart");

            try
            {
                Console.WriteLine("Was m�chten Sie kaufen? (Tisch, Stuhl oder Leer).");
                var m�belTyp = Console.ReadLine();

                if (string.IsNullOrEmpty(m�belTyp)) return;

                var meinM�bel = ikeaFrankfurt.Verkaufen(m�belTyp);

                if (meinM�bel != null) // wurde etwas gekauft?
                {
                    // meinM�bel.Benutzen(); // InvalidUserOperationException: Nicht montiert!

                    meinM�bel.Montieren();
                    meinM�bel.Benutzen();
                }
            }
            catch (NichtAufLagerException e)
            {
                Console.WriteLine(e);
                // Todo: Ersatzartikel anbieten?
            }
            catch (InvalidUserOperationException e)
            {
                Console.WriteLine(e);
                // Todo: Anleitung zusenden?
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Todo: Fehler loggen
            }

            ikeaFrankfurt.Show();
        }
    }
}