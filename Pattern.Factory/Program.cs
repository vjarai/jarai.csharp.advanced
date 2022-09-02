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
                var meinMöbel = ikeaFrankfurt.Verkaufen();

                if (meinMöbel != null) // wurde etwas gekauft?
                {
                    // meinMöbel.Benutzen(); // InvalidUserOperationException: Nicht montiert!

                    meinMöbel.Montieren();
                    meinMöbel.Benutzen();
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