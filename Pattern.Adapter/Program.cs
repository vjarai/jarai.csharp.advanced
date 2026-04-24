using System;

namespace Jarai.Patterns.Structural.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var applePhone = new ApplePhone();

            var lightningLadegerät = new LightningLadegerät();
            applePhone.Aufladen(lightningLadegerät);


            var usbLadegerät = new UsbLadegerät();
            var adapter = new UsbToLightningAdapter(usbLadegerät);
            applePhone.Aufladen(adapter);

            Console.Read();
        }
    }
}