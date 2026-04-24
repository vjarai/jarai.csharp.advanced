using System;

namespace Jarai.CSharp.Pattern.Adapter
{
    public class UsbLadegerät
    {
        public int LiefereStromViaUsb()
        {
            int strom = 500;

            Console.WriteLine($"USB Ladegerät liefert {strom} mA Strom.");

            return strom;
        }
    }
}