using System;

namespace Jarai.CSharp.Interface.Simple
{
    public class Flugzeug : IFlugzeug
    {
        public void Fliegen()
        {
            Console.WriteLine("mit Flugzeug");
        }
    }
}