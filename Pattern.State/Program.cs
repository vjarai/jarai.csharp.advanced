namespace Jarai.CSharp.Pattern.State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var meinTelefon = new Telefon();

            meinTelefon.Auflegen();
            meinTelefon.AnnehmenAnruf();
            meinTelefon.Sprechen();
            meinTelefon.Auflegen();

            meinTelefon.Abheben();
            meinTelefon.Wählen();
            meinTelefon.Sprechen();
            meinTelefon.Auflegen();
        }
    }
}