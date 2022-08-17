using System;

namespace Jarai.Interface.Simple
{
    internal class Maler
    {
        public void Fahren(IFahrbar fahrzeug)
        {
            Console.WriteLine("Der Maler f�hrt...");
            fahrzeug.Fahren();
        }

        public void Lackieren(ILackierbar gegenstand, string neueFarbe)
        {
            Console.WriteLine("Der Maler lackiert...");
            gegenstand.Farbe = neueFarbe;
        }
    }
}