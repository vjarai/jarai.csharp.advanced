using System;

namespace Jarai.CSharp.Pattern.Adapter
{
    public class Printer
    {
        public virtual void Print(string text)
        {
            Console.WriteLine("DRUCKEN: {0}", text);
        }
    }
}