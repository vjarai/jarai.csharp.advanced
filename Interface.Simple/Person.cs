using System;

namespace Jarai.CSharp.Interface.Simple
{
    internal class Person
    {
        public void Fahren(IFahrbar fahrzeug)
        {
            Console.WriteLine("Die Person fährt...");
            fahrzeug.Fahren();
        }

        public void Fliegen(IFliegbar flieger)
        {
            Console.WriteLine("Die Person fliegt...");
            flieger.Fliegen();
        }
    }
}