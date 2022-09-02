using System;

namespace Jarai.CSharp.Interface.Simple
{
    internal class Ski : IFahrbar
    {
        public void Fahren()
        {
            Console.WriteLine("Die Ski fahren.");
        }
    }
}