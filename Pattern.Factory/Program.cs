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
                var meinM�bel = ikeaFrankfurt.Verkaufen();

                if (meinM�bel != null) // wurde etwas gekauft?
                {
                    // meinM�bel.Benutzen(); // InvalidUserOperationException: Nicht montiert!

                    meinM�bel.Montieren();
                    meinM�bel.Benutzen();
                }
            }
            catch (NichtAufLagerException e)
            {
                Debug.WriteLine(e);
                // Todo: Ersatzartikel anbieten?
            }
            catch (InvalidUserOperationException e)
            {
                Debug.WriteLine(e);
                // Todo: Anleitung zusenden?
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                // Todo: Fehler loggen
            }

            ikeaFrankfurt.Show();
        }
    }
}