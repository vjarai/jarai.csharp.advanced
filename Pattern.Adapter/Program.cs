using System;

namespace Jarai.CSharp.Pattern.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var iphone = new IPhone();

            var lightningLadegerät = new LightningLadegerät();
            iphone.Aufladen(lightningLadegerät);


            var usbLadegerät = new UsbLadegerät();
            var adapter = new UsbToLightningAdapter(usbLadegerät);
            iphone.Aufladen(adapter);

            Console.Read();
        }
    }
}