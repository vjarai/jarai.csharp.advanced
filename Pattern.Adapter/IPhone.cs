using System;

namespace Jarai.CSharp.Pattern.Adapter
{
    public class IPhone
    {

        public void Aufladen(LightningLadegerät lightningLadegerät)
        {
            int strom = lightningLadegerät.LiefereStromViaLightning();

            Console.WriteLine($"Apple Phone wird mit {strom} mA aufgeladen.");
        }
    }
}