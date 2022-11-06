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
                Console.WriteLine("Was möchten Sie kaufen? (Tisch, Stuhl oder Leer).");
                var möbelTyp = Console.ReadLine();

                if (string.IsNullOrEmpty(möbelTyp)) return;

                var meinMöbel = ikeaFrankfurt.Verkaufen(möbelTyp);

                if (meinMöbel != null) // wurde etwas gekauft?
                {
                    // meinMöbel.Benutzen(); // InvalidUserOperationException: Nicht montiert!

                    meinMöbel.Montieren();
                    meinMöbel.Benutzen();
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