using System;

namespace Jarai.CSharp.Interface.Simple
{
    internal class Person
    {
        public void Verreisen(ISchiff schiff)
        {
            Console.WriteLine("Die Person f�hrt...");
            schiff.Schwimmen();
        }

        public void Fliegen(IFlugzeug flieger)
        {
            Console.WriteLine("Die Person fliegt...");
            flieger.Fliegen();
        }
    }
}