namespace Jarai.CSharp.Pattern.State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var meinTelefon = new Telefon();

            meinTelefon.AnnehmenAnruf();
            meinTelefon.Sprechen();
            meinTelefon.Auflegen();

            meinTelefon.Abheben();
            meinTelefon.W�hlen();
            meinTelefon.Sprechen();
            meinTelefon.Sprechen();
            meinTelefon.Auflegen();
        }
    }
}