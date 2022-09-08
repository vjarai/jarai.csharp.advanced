using System;

namespace Jarai.CSharp.Interface.Simple
{
    internal class Auto : IFahrbar
    {
        public void Fahren()
        {
            Console.WriteLine("Das Auto fährt.");
        }
    }
}