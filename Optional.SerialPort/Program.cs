using System.IO.Ports;

namespace Optional.Rs232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var serialPort = new SerialPort("COM1"))
            {
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;

                serialPort.Open();
                serialPort.DataReceived += (sender, eventargs) =>
                {
                   string receivedData = serialPort.ReadExisting();
                   Console.WriteLine(receivedData);
                };

                serialPort.Write("Hallo Welt");
                Thread.Sleep(1000);
                serialPort.Close();
            }
        }

    }
}