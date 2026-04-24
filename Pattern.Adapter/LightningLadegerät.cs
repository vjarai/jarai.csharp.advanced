using System;

namespace Jarai.CSharp.Pattern.Adapter
{
    public class LightningLadegerät
    {
        public virtual int LiefereStromViaLightning()
        {
            int strom = 1000;

            Console.WriteLine($"Lightning Ladegerät liefert {strom} mA Strom.");

            return strom;
        }
    }
}