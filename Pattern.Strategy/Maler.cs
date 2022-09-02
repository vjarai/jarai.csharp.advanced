using System;

namespace Jarai.CSharp.Pattern.Strategy
{
    public class Maler : Arbeiter
    {
        public Maler(string name) : base(name)
        {
        }

        public override void Arbeiten()
        {
            Console.WriteLine("- weiße Wand produziert durch '{0}'", Name);
        }
    }
}