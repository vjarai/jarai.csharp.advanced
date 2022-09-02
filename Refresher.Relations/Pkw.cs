using System;

namespace Jarai.CSharp.Refresher.Relations
{
    public class Pkw : Kfz
    {

        public Pkw(string marke, Motor motor) : base(marke, motor)
        {
        }

        public override string ToString()
        {
            return "Pkw Daten:" + base.ToString();
        }

       
        public override void Fahren(double strecke)
        {
            Console.WriteLine("Wir fahren mit dem Pkw.");
            base.Fahren(strecke);
        }
    }
}