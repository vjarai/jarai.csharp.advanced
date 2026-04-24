namespace Jarai.Patterns.Structural.Adapter
{
    public class UsbToLightningAdapter : LightningLadegerät
    {
        private readonly UsbLadegerät _usbLadegerät;

        public UsbToLightningAdapter(UsbLadegerät usbLadegerät)
        {
            _usbLadegerät = usbLadegerät;
        }


        public override int LiefereStromViaLightning()
        {
           int strom = _usbLadegerät.LiefereStromViaUsb();


            return strom;
        }
    }
}