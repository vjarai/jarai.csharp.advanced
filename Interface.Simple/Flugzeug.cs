using System;

namespace Jarai.CSharp.Interface.Simple
{
    public class Flugzeug : IFliegbar
    {
        public void Fliegen()
        {
            Console.WriteLine("mit Flugzeug");
        }
    }
}