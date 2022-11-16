using System;

namespace Jarai.CSharp.Interface.Simple
{
    internal class Schiff : ISchiff
    {
        public void Schwimmen()
        {
            Console.WriteLine("Das Schiff fährt.");
        }
    }
}