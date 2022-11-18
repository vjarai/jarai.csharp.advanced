namespace Optional.ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meinAuto = new Auto { KfzKennzeichen = "MTK XY 123" };

            meinAuto.Waschen();
            meinAuto.Versichern();
        }
    }
}